using UnityEngine;
using System.IO;

public class SceneScreenshot : MonoBehaviour
{
    public KeyCode screenshotKey = KeyCode.F12;
    public string folderPath = "Screenshots";
    public int superSize = 1; // 1=普通分辨率，2=2倍分辨率

    void Update()
    {
        if (Input.GetKeyDown(screenshotKey))
        {
            string timestamp = System.DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string fileName = $"Screenshot_{timestamp}.png";
            string fullPath = Path.Combine(folderPath, fileName);

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            ScreenCapture.CaptureScreenshot(fullPath, superSize);
            Debug.Log($"截图已保存到: {fullPath}");
        }
    }
}