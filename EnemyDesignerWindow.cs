using System.Collections;
using UnityEngine;
using UnityEditor;

public class EnemyDesignerWindow : EditorWindow
{
    [MenuItem("Window/Empty Designer")]
    static void OpenWindow()
    {
        EnemyDesignerWindow window = (EnemyDesignerWindow) GetWindow(typeof(EnemyDesignerWindow));
        window.minSize = new Vector2(600, 300);
        window.Show();
    }
}
