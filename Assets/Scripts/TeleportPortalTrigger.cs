using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class TeleportPortalTrigger : MonoBehaviour
{
    public string targetSceneName;

    private bool isTeleporting = false; // 防止多次触发

    private void OnTriggerEnter(Collider other)
    {
        if (isTeleporting) return;

        if (other.CompareTag("Player"))
        {
            isTeleporting = true;

            // 尝试禁用输入（如果存在 PlayerInput）
            PlayerInput input = other.GetComponent<PlayerInput>();
            if (input != null)
            {
                input.enabled = false;
                Debug.Log("✅ PlayerInput 已禁用，准备传送...");
            }

            // 延迟加载目标场景，确保旧引用清理干净
            StartCoroutine(LoadSceneDelayed());
        }
    }

    private System.Collections.IEnumerator LoadSceneDelayed()
    {
        yield return new WaitForSeconds(0.1f); // 给 Unity 一帧时间完成解绑等处理
        Debug.Log($"🚪 正在加载场景：{targetSceneName}");
        SceneManager.LoadScene(targetSceneName);
    }
}
