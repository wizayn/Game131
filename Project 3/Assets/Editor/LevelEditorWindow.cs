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
	public int count = 4;
    private GameObject toInstantiate;
    public float x = 0.0f;
    public float y = 0.0f;
    public float z = 0.0f;
    public float defaultSpeed = 1f;
    GameObject toCreate;
    
    //opens the editor window
    [MenuItem("Examples/Editor GUILayout Popup usage")]
    static void Init()
    {
        EditorWindow window = GetWindow(typeof(LevelEditorWindow));
        window.Show();     
    }

    //loads all assets in the Resource folder.
    public void Awake()
    {
		temp = new Object[count];
		temp [0] = Resources.Load ("Rail");
		temp [1] = Resources.Load ("Target");
		temp [2] = Resources.Load ("wallBase");
		temp [3] = Resources.Load ("crossbowRoot");
		foreach (object i in temp) {
			Debug.Log (i);
		}
        options = new string[temp.Length];

        for (int i = 0; i < temp.Length; i++)
        {
            options[i] = temp[i].name;
            //Debug.Log(options[i]);
        }
        
    }

    //adds options to the editor window
    void OnGUI()
    {
        index = EditorGUILayout.Popup(index, options);

        x = EditorGUILayout.FloatField("X: ", x);
        y = EditorGUILayout.FloatField("Y: ", y);
        defaultSpeed = EditorGUILayout.FloatField("Default Speed: ", defaultSpeed);

        //Create a dictionary to access list of Resources
        if (GUILayout.Button("Create"))
            InstantiateObject();


    }

    //only one instance of this private static variable
    private static LevelEditorWindow instance;
    
    public static void ShowWindow()
    {
        instance = EditorWindow.GetWindow<LevelEditorWindow>();
        instance.titleContent = new GUIContent("Level Editor");
    }

    //when an object is selected and the create button is clicked it places and instance of the
    //selected object to the scene at the specified x, y location
    //The it adds a new shared material to the newly created object. 
    void InstantiateObject()
    {
        toCreate = GameObject.Instantiate(temp[index]) as GameObject;
        toCreate.name = temp[index].name;
        Vector3 tempToCreate = toCreate.transform.position;
        tempToCreate.x = x;
        tempToCreate.y = y;
        toCreate.transform.position = tempToCreate;
        
		if(toCreate.name == "Rail")
        toCreate.transform.GetChild(0).GetChild(0).GetComponent<MoveBetweenTwoPoints>().speed = defaultSpeed;
    }
}
