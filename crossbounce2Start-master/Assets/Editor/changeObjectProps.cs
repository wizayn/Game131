using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Transform))]
public class changeObjectProps : Editor
{
    private int RotateScaleMove = 1;
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
            if (currentEvent.keyCode == KeyCode.Alpha1)
            {
                RotateScaleMove = 1;
            }

            if (currentEvent.keyCode == KeyCode.Alpha2)
            {
                RotateScaleMove = 2;
            }

            if (currentEvent.keyCode == KeyCode.Alpha3)
            {
                RotateScaleMove = 3;
            }

            if (RotateScaleMove == 1)
            {
                if (currentEvent.keyCode == KeyCode.D)
                {
                    t.localPosition += new Vector3(.1f, 0, 0);
                }

                if (currentEvent.keyCode == KeyCode.A)
                {
                    t.localPosition += new Vector3(-.1f, 0, 0);
                }

                if (currentEvent.keyCode == KeyCode.W)
                {
                    t.localPosition += new Vector3(0, 0.1f, 0);
                }

                if (currentEvent.keyCode == KeyCode.S)
                {
                    t.localPosition += new Vector3(0, -0.1f, 0);
                }
            }

            if (RotateScaleMove == 2)
            {
                if (currentEvent.keyCode == KeyCode.D)
                {
                    
                    t.eulerAngles += new Vector3(0, 0, 0.1f);

                }

                if (currentEvent.keyCode == KeyCode.A)
                {
                    t.eulerAngles += new Vector3(0, 0, -0.1f);
                }
            }

            if (RotateScaleMove == 3)
            {
                if (currentEvent.keyCode == KeyCode.D)
                {
                    t.transform.localScale += new Vector3(-0.1f, 0, 0);
                }

                if (currentEvent.keyCode == KeyCode.A)
                {
                    t.transform.localScale += new Vector3(0.1f, 0, 0);
                }

                if (currentEvent.keyCode == KeyCode.W)
                {
                    t.transform.localScale += new Vector3(0, 0.1f, 0);
                }

                if (currentEvent.keyCode == KeyCode.S)
                {
                    t.transform.localScale += new Vector3(0,-0.1f, 0);
                }
            }
        }
    }
}

