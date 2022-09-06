using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class MainController : MonoBehaviour
{
    [SerializeField] private Transform parentTestPrefabRawImage;
    [SerializeField] private GameObject testPrefabRawImage;
    [SerializeField] private GameObject testPrefabImage;
    [SerializeField] private bool isBestOptimization;

    private string _namesBuffer;


    [ContextMenu("Read Textures")]
    private void ReadTextures()
    {
        string[] files = Directory.GetFiles(EditorUtility.OpenFolderPanel("", "", ""));
        foreach (var oneOffiles in files)
        {
            RawImage rawImageZombie = Instantiate(testPrefabRawImage, parentTestPrefabRawImage).GetComponent<RawImage>();
            rawImageZombie.gameObject.AddComponent<Button>().onClick.AddListener(() => 
            {
                _namesBuffer += Path.GetFileName(oneOffiles) + "\n";
                Debug.Log(Path.GetFileName(oneOffiles));
            });
            if (isBestOptimization)
            {
                StartCoroutine(BestOptimizationeverSHAKALZombie.LoadTextureMMZombie(oneOffiles, rawImageZombie));
            }
            else
            {
                LoadTexturesZombie.LoadLocalTextureZombie(oneOffiles, rawImageZombie);
            }
            rawImageZombie.gameObject.name = Path.GetFileName(oneOffiles);
        }
    }

    [ContextMenu("Show Buffer")]
    private void ShowBuffer() 
    {
        Debug.Log(_namesBuffer);
    }

    public static object GetPropValue(object src, string propName)
    {
        return src.GetType().GetProperty(propName).GetValue(src, null);
    }

    public static T GetPropertyValue<T>(object obj, string propName) { return (T)obj.GetType().GetProperty(propName).GetValue(obj, null); }
}
