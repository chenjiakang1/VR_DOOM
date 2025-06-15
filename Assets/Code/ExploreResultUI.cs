using UnityEngine;
using TMPro;

public class ExploreResultUI : MonoBehaviour
{
    public TextMeshProUGUI resultText;  // 在 Inspector 中绑定显示文本
    public string roomId;               // Inspector 中输入房间 ID（如 Room1）

    void Start()
    {
        if (ExploreData.Instance != null)
        {
            float explore = ExploreData.Instance.GetExplore(roomId);
            resultText.text = $"Explore {roomId}: {explore:F2}%";
        }
        else
        {
            resultText.text = $"Explore {roomId}: N/A";
        }
    }
}

