using UnityEditor;
using UnityEngine;

public class BatchRename : EditorWindow
{
    private string baseName = "NewName";
    private int startIndex = 0;

    [MenuItem("Tools/批量重命名")]
    static void Init()
    {
        GetWindow<BatchRename>("批量重命名");
    }

    void OnGUI()
    {
        baseName = EditorGUILayout.TextField("基础名称", baseName);
        startIndex = EditorGUILayout.IntField("起始编号", startIndex);

        if (GUILayout.Button("重命名选中对象"))
        {
            var objs = Selection.gameObjects;
            for (int i = 0; i < objs.Length; i++)
            {
                objs[i].name = baseName + (startIndex + i);
            }
        }
    }
}
