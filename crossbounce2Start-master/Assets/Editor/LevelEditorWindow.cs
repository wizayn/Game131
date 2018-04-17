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
        PhysicsMaterial2D mat = new PhysicsMaterial2D();
        toCreate.GetComponent<Collider2D>().sharedMaterial = mat;
    }
}
