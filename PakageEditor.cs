using System.Collections;
using UnityEngine;
using UnityEditor;

public class PakageEditor : EditorWindow
{
    Texture2D mageSectionTexture;
    Rect mageSection;

    static PackageData pakageData;
    string packageName = "";
    string selector = "";
    string objectClass = "";
    string objectPrice = "";

    [MenuItem("Window/Package editor")]
    [MenuItem("Assets/Package editor")]
    static void OpenWindow()
    {
        PakageEditor window = (PakageEditor) GetWindow(typeof(PakageEditor));
        window.minSize = new Vector2(400, 300);
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
        mageSection.width = 400;
        mageSection.height = Screen.height;

        GUI.DrawTexture(mageSection, mageSectionTexture);
    }

    void DrawMain()
    {
        GUILayout.BeginArea(mageSection);

        GUILayout.BeginHorizontal();
        GUILayout.Label("select objects");
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("package");
        pakageData.data = (EnumPackageData)EditorGUILayout.EnumPopup(pakageData.data);
        GUILayout.EndHorizontal();

        //GUILayout.BeginHorizontal();
        //GUILayout.Label("input package");
        //packageName = EditorGUILayout.TextField(packageName);
        //GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("selector");
        pakageData.dataSelector = (EnumPackageSelector)EditorGUILayout.EnumPopup(pakageData.dataSelector);
        GUILayout.EndHorizontal();

        //EditorGUILayout.HelpBox("package is not selected", MessageType.Warning);
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("diaplay objects"))
        {
            Table.OpenWindow();
        }
        if (GUILayout.Button("export in excel"))
        {

        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("update objects");
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("class");
        objectClass = EditorGUILayout.TextField(objectClass);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("price");
        objectPrice = EditorGUILayout.TextField(objectPrice);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("width");
        objectPrice = EditorGUILayout.TextField(objectPrice);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("height");
        objectPrice = EditorGUILayout.TextField(objectPrice);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("damage");
        objectPrice = EditorGUILayout.TextField(objectPrice);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("lives");
        objectPrice = EditorGUILayout.TextField(objectPrice);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("update objects"))
        {
            // save
        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("import from excel"))
        {

        }
        GUILayout.EndHorizontal();

        //EditorGUILayout.HelpBox("update 1200 objects", MessageType.Info);

        GUILayout.EndArea();
    }
}
