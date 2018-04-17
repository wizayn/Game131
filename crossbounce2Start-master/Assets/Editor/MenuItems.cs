using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuItems
{
    //Create MenuItem called Tools that has a sub option level creator and when show level editor is clicked it opens the editor window
    [MenuItem("Tools/Level Creator/Show level Editor")]
    private static void ShowLevelEditor()
    {
        LevelEditorWindow.ShowWindow();
    }
}
