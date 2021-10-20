using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;


public class FindMissingScripts : Editor
{
    [MenuItem("Component/Find missing Script")]
    public static void FindMissingScript()
    {
        GameObject parent = null;
        string[] prefabsPaths = AssetDatabase.GetAllAssetPaths().Where((path) => path.EndsWith(".prefab", System.StringComparison.OrdinalIgnoreCase)).ToArray();
        foreach (string path in prefabsPaths)
        {
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            Component[] components = prefab.GetComponents<Component>();

            foreach (Component component in components)
            {
                if (component == null)
                {
                    if (parent == null)
                    {
                        parent = prefab;
                        //AssetDatabase.OpenAsset(AssetDatabase.LoadAssetAtPath<GameObject>(PrefabUtility.GetPrefabAssetPathOfNearestInstanceRoot(parent))); can open the scene that the gameobject is missing https://forum.unity.com/threads/open-prefab-scene-view-via-script.667165/ source
                        GameObjectUtility.RemoveMonoBehavioursWithMissingScript(parent);
                        Debug.Log("Found missing Script at gameobject " + parent.name);
                        break;
                    }
                }

            }
        }
    }
}