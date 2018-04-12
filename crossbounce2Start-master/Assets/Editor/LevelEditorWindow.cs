using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;

public class LevelEditorWindow : EditorWindow {
    public int arrayTemp = 0;
    public static Object[] temp;
    public static string[] options;
    public int index = 0;
    private GameObject toInstantiate;
    public float x = 0.0f;
    public float y = 0.0f;
    public float z = 0.0f;
    public float bounceAmount = 0.0f;
    GameObject toCreate;

    [MenuItem("Examples/Editor GUILayout Popup usage")]

    static void Init()
    {
        EditorWindow window = GetWindow(typeof(LevelEditorWindow));
        window.Show();     
    }

    public void Awake()
    {
        temp = Resources.LoadAll("", typeof(Object));
        options = new string[temp.Length];

        for (int i = 0; i < temp.Length; i++)
        {
            options[i] = temp[i].name;
            Debug.Log(options[i]);
        }
        
    }
    void OnGUI()
    {
        index = EditorGUILayout.Popup(index, options);

        x = EditorGUILayout.FloatField("X: ", x);
        y = EditorGUILayout.FloatField("Y: ", y);
        z = EditorGUILayout.FloatField("Z: ", z);
        bounceAmount = EditorGUILayout.FloatField("bounceAmount: ", bounceAmount);
        //Create a dictionary to access list of Resources
        if (GUILayout.Button("Create"))
            InstantiateObject();


    }
    ////only one instance of this private static variable
    private static LevelEditorWindow instance;
    public static void ShowWindow()
    {
        instance = EditorWindow.GetWindow<LevelEditorWindow>();
        instance.titleContent = new GUIContent("Level Editor");
    }

    void InstantiateObject()
    {
        toCreate = GameObject.Instantiate(temp[index]) as GameObject;
        Vector3 tempToCreate = toCreate.transform.position;
        tempToCreate.x = x;
        tempToCreate.y = y;
        tempToCreate.z = z;
        toCreate.transform.position = tempToCreate;
        toCreate.GetComponent<BoxCollider2D>().sharedMaterial.bounciness = bounceAmount;
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
