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
        //Check if a key is pressed down
        if (currentEvent.type == EventType.KeyDown)
        {
            //if key pressed is 1, 2 or 3 change RotateScaleMove to the relative value
            if (currentEvent.keyCode == KeyCode.Alpha1)
            {
                RotateScaleMove = 1;

            }

            if (currentEvent.keyCode == KeyCode.Alpha2)
            {
                Event current = Event.current;
                current.Use();
                RotateScaleMove = 2;

            }

            if (currentEvent.keyCode == KeyCode.Alpha3)
            {
                RotateScaleMove = 3;

            }

            //if RotateScaleMove == 1 then you can use A,S,D or W to move the currently selected object up, down, left or right
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

            //if RoateScaleMove == 2 rotate object cloakwise with A or counter cloakwise with D
            if (RotateScaleMove == 2)
            {
                if (currentEvent.keyCode == KeyCode.D)
                {
                    
                    t.eulerAngles += new Vector3(0, 0, 0.5f);

                }

                if (currentEvent.keyCode == KeyCode.A)
                {
                    t.eulerAngles += new Vector3(0, 0, -0.5f);
                }
            }

            //if RoateScaleMove == 3 you can use A,S,D or W to scale the object width and hight
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
