using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine.UI;
using System.Reflection;
using UnityEditor.SceneManagement;

public class JunsicEditor : EditorWindow
{
    private static JunsicEditor window;
    [MenuItem("Window/JunSic Editor")]
    public static void Init()
    {
        // Get existing open window or if none, make a new one:
        window = (JunsicEditor)EditorWindow.GetWindow(typeof(JunsicEditor));
        window.Show();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
