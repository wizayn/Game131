using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuItems
{

    [MenuItem("Tools/Level Creator/Show level Editor")]

    private static void ShowLevelEditor()
    {
        LevelEditorWindow.ShowWindow();
    }
}
