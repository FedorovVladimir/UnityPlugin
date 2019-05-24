using System.Collections;
using UnityEngine;
using UnityEditor;

public class Table : EditorWindow
{
    Texture2D mageSectionTexture;
    Rect mageSection;

    static PackageData pakageData;
    string packageName;

    public static void OpenWindow()
    {
        Table window = (Table)GetWindow(typeof(Table));
        window.minSize = new Vector2(600, 300);
        window.Show();
    }

    private void OnEnable()
    {
        InitTexture();
        InitData();
    }

    void InitTexture()
    {
        mageSectionTexture = new Texture2D(1, 1);
    }

    void InitData()
    {
        pakageData = (PackageData)ScriptableObject.CreateInstance(typeof(PackageData));
    }

    private void OnGUI()
    {
        DrawLayouts();
        DrawMain();
    }

    void DrawLayouts()
    {
        mageSection.x = 0;
        mageSection.y = 0;
        mageSection.width = 600;
        mageSection.height = Screen.height;

        GUI.DrawTexture(mageSection, mageSectionTexture);
    }

    void DrawMain()
    {
        GUILayout.BeginArea(mageSection);

        GUILayout.BeginHorizontal();
        EditorGUILayout.TextField("name");
        EditorGUILayout.TextField("selector");
        EditorGUILayout.TextField("path");
        GUILayout.EndHorizontal();

        for (int i = 0; i < 25; i++)
        {
            GUILayout.BeginHorizontal();
            EditorGUILayout.TextField("name_" + (i + 1));
            EditorGUILayout.TextField(".product");
            EditorGUILayout.TextField("/packege_" + (i + 1) + "/object_" + +(i + 1));
            GUILayout.EndHorizontal();
        }

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("export in excel"))
        {
            
        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("exit"))
        {
            // save
        }
        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }
}
