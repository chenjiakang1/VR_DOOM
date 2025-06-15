using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class UIStatusManager : MonoBehaviour
{
    public static UIStatusManager Instance;

    [Header("UI Text References")]
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI ammoText;
    public TextMeshProUGUI armorText;
    public TextMeshProUGUI exploreText;

    [Header("Input Actions")]
    public InputActionReference decreaseHealthAction;
    public InputActionReference increaseHealthAction;
    public InputActionReference decreaseAmmoAction;
    public InputActionReference increaseAmmoAction;
    public InputActionReference decreaseArmorAction;
    public InputActionReference increaseArmorAction;
    public InputActionReference increaseExploreAction;

    private int health = 100;
    private int ammo = 50;
    private int armor = 20;
    private float exploreRate = 0f;

    private int totalMonsters = 35;
    private int killedMonsters = 0;

    public string currentRoomId;

    void Awake()
    {
        Instance = this;
        Debug.Log($"✅ UIStatusManager Awake in {SceneManager.GetActiveScene().name}");
    }

    void Start()
    {
        currentRoomId = SceneManager.GetActiveScene().name;

        if (ExploreData.Instance != null)
        {
            // 👇 手动指定每个房间的怪物总数
            if (currentRoomId == "E1M1") ExploreData.Instance.SetTotalMonsters(currentRoomId, 35);
            if (currentRoomId == "E1M2") ExploreData.Instance.SetTotalMonsters(currentRoomId, 71);

            // 👇 读取探索度和总怪物数
            exploreRate = ExploreData.Instance.GetExplore(currentRoomId);
            totalMonsters = ExploreData.Instance.GetTotalMonsters(currentRoomId);
        }

        decreaseHealthAction.action.Enable();
        increaseHealthAction.action.Enable();
        decreaseAmmoAction.action.Enable();
        increaseAmmoAction.action.Enable();
        decreaseArmorAction.action.Enable();
        increaseArmorAction.action.Enable();
        increaseExploreAction.action.Enable();

        UpdateUI();
    }

    void Update()
    {
        if (decreaseHealthAction.action.triggered) ChangeHealth(-10);
        if (increaseHealthAction.action.triggered) ChangeHealth(10);
        if (decreaseAmmoAction.action.triggered) ChangeAmmo(-5);
        if (increaseAmmoAction.action.triggered) ChangeAmmo(5);
        if (decreaseArmorAction.action.triggered) ChangeArmor(-5);
        if (increaseArmorAction.action.triggered) ChangeArmor(5);
        if (increaseExploreAction.action.triggered) ChangeExplore(5f);
    }

    public void ChangeHealth(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, 100);
        UpdateUI();
    }

    public void ChangeAmmo(int amount)
    {
        ammo = Mathf.Max(0, ammo + amount);
        UpdateUI();
    }

    public void ChangeArmor(int amount)
    {
        armor = Mathf.Max(0, armor + amount);
        UpdateUI();
    }

    public void ChangeExplore(float amount)
    {
        exploreRate = Mathf.Min(100f, exploreRate + amount);
        if (ExploreData.Instance != null)
        {
            ExploreData.Instance.SetExplore(currentRoomId, exploreRate);
        }
        UpdateUI();
    }

    public void UpdateUI()
    {
        healthText.text = "Health: " + health;
        ammoText.text = "Ammo: " + ammo;
        armorText.text = "Armor: " + armor;

        // ✅ 不要拉 ExploreData，只用本地的 exploreRate 即可
        exploreText.text = $"Explore: {exploreRate:F2}%";
    }


    public void PickupItem(string type, int amount)
    {
        switch (type)
        {
            case "Health": ChangeHealth(amount); break;
            case "Ammo": ChangeAmmo(amount); break;
            case "Armor": ChangeArmor(amount); break;
            case "Explore": ChangeExplore(amount); break;
        }
    }

    public int GetHealth() => health;
    public int GetAmmo() => ammo;
    public int GetArmor() => armor;

    public void AddExploreByKill()
    {
        killedMonsters++;

        if (totalMonsters <= 0) totalMonsters = 35; // fallback
        float perKillExplore = 100f / totalMonsters;

        ChangeExplore(perKillExplore);
        Debug.Log($"☑️ 房间[{currentRoomId}] 击杀怪物：{killedMonsters}/{totalMonsters}，探索度 +{perKillExplore:F2}%");
    }
}
