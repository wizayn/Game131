using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPath : MonoBehaviour {
    public Transform startPoint;
    public Transform endPoint;

    private float dist;

    private LineRenderer lineR;
    public Color gridColor = Color.green;

    public GameObject toCreate;

    private void OnDrawGizmos()
    {
        Gizmos.color = gridColor;

        Gizmos.DrawLine(startPoint.position, endPoint.position);


    }

    private void Start()
    {
        placeObjectOnRail();
    }
    void placeObjectOnRail()
    {
        GameObject temp = GameObject.Instantiate(toCreate) as GameObject;
        Vector3 railObject = temp.transform.position;
        railObject.x = startPoint.position.x;
        railObject.y = startPoint.position.y;
        railObject.z = 0;

        temp.transform.position = railObject;
        
    }
}
