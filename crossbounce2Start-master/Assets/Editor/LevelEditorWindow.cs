using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;

public class LevelEditorWindow : EditorWindow {
    public int arrayTemp = 0;
    public GameObject[] temp;
    public string[] options;
    public int index = 0;
    

    [MenuItem("Examples/Editor GUILayout Popup usage")]

    
    static void Init()
    {
        GameObject tempCamera = GameObject.Find("Main Camera");
        ObjectOptionScript tempScript = tempCamera.GetComponent<ObjectOptionScript>();
        for(int i = 0; i < tempScript  )
        EditorWindow window = GetWindow(typeof(LevelEditorWindow));
        window.Show();
    }

    void OnGUI()
    {
        index = EditorGUILayout.Popup(index, options);
            
    }
    ////only one instance of this private static variable
    private static LevelEditorWindow instance;
    public static void ShowWindow()
    {
        instance = EditorWindow.GetWindow<LevelEditorWindow>();
        instance.titleContent = new GUIContent("Level Editor");
    }

    //private float currentX = 0.0f;
    //private void OnGUI()
    //{
    //    GUILayout.Label("Hello world");

    //    //if(GUILayout.Button("Create Cube"))
    //    //{
    //    //    string[] cubeGuids = AssetDatabase.FindAssets("crossbowRoot");

    //    //    StringBuilder guidBuilder = new StringBuilder();
    //    //    foreach(string cubeGuid in cubeGuids)
    //    //    {
    //    //        guidBuilder.AppendLine(cubeGuid);

    //    //    }
    //    //    UnityEngine.MonoBehaviour.print(guidBuilder.ToString());

    //    //    if(cubeGuids.Length >0)
    //    //    {
    //    //        string trueCubeGuid = cubeGuids[0];

    //    //        // 2. Get the asset's path from the GUID
    //    //        string assetPath = AssetDatabase.GUIDToAssetPath(trueCubeGuid);
    //    //        UnityEngine.MonoBehaviour.print(assetPath);


    //    //        //3. Fetch the object
    //    //        GameObject cubeTemplate = AssetDatabase.LoadAssetAtPath(assetPath, typeof(GameObject)) as GameObject;

    //    //        GameObject newCube = GameObject.Instantiate(cubeTemplate);
    //    //        newCube.name = cubeTemplate.name;

    //    //        //Funsies = spawn in a line along x
    //    //        Vector3 newCubePosition = newCube.transform.position;
    //    //        newCubePosition.x = currentX;
    //    //        newCube.transform.position = newCubePosition;

    //    //        currentX += 1f;

    //    //    }
    //    //}
    //}



}
