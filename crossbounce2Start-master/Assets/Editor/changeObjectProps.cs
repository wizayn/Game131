using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Transform))]
public class changeObjectProps : Editor{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
    }

    private void OnEnable()
    {
        ArrayList sceneViews = SceneView.sceneViews;
        if (sceneViews.Count > 0)
            (sceneViews[0] as SceneView).Focus();
    }

    private void OnSceneGUI()
    {

        Transform t = (Transform)target;
        Event currentEvent = Event.current;

        if (currentEvent.type == EventType.KeyDown)
        {
            Debug.Log("Test");
            if (currentEvent.keyCode == KeyCode.D)
            {
                t.localPosition += new Vector3(.1f, 0, 0);

            }

            if (currentEvent.keyCode == KeyCode.A)
            {
                t.localPosition += new Vector3(-.1f, 0, 0);
            }
        }
    }
}
