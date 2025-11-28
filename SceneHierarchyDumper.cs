// 28/11/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using System;
using UnityEditor;
using UnityEngine;
using System.IO;

public class SceneHierarchyDumper : MonoBehaviour
{
    public string fileName = "SceneHierarchy.txt";

    void Start()
    {
        string path = Application.dataPath + "/" + fileName;
        using (StreamWriter writer = new StreamWriter(path))
        {
            // Get all root GameObjects in the scene
            var rootObjects = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();

            foreach (var rootObject in rootObjects)
            {
                DumpHierarchy(writer, rootObject.transform, 0);
            }
        }
        Debug.Log("Scene hierarchy dumped to: " + path);
    }

    void DumpHierarchy(StreamWriter writer, Transform obj, int depth)
    {
        string indent = new string(' ', depth * 2);
        writer.WriteLine($"{indent}{obj.name} (Position: {obj.position}, Rotation: {obj.rotation.eulerAngles}, Scale: {obj.localScale})");

        foreach (Transform child in obj)
        {
            DumpHierarchy(writer, child, depth + 1);
        }
    }
}
