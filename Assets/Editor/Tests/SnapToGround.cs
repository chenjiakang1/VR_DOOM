
using UnityEditor;
using UnityEngine;

public class SnapToGround : MonoBehaviour
{
    [MenuItem("Tools/Snap To Ground %g")] // Ctrl+G快捷键
    static void SnapSelectedToGround()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            if (Physics.Raycast(obj.transform.position, Vector3.down, out RaycastHit hit))
            {
                obj.transform.position = hit.point;
                Debug.Log($"{obj.name} 已对齐地面");
            }
        }
    }
}