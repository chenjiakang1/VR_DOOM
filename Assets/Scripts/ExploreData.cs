using System.Collections.Generic;
using UnityEngine;

public class ExploreData : MonoBehaviour
{
    public static ExploreData Instance;

    private Dictionary<string, float> exploreRates = new Dictionary<string, float>();
    private Dictionary<string, int> totalMonstersPerRoom = new Dictionary<string, int>();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetExplore(string roomId, float value)
    {
        exploreRates[roomId] = Mathf.Clamp(value, 0f, 100f);
    }

    public float GetExplore(string roomId)
    {
        return exploreRates.ContainsKey(roomId) ? exploreRates[roomId] : 0f;
    }

    public void SetTotalMonsters(string roomId, int count)
    {
        totalMonstersPerRoom[roomId] = count;
    }

    public int GetTotalMonsters(string roomId)
    {
        return totalMonstersPerRoom.ContainsKey(roomId) ? totalMonstersPerRoom[roomId] : 35; // 默认35
    }
}
