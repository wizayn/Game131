using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPath : MonoBehaviour {
    public Transform startPoint;
    public Transform endPoint;

    public Color gridColor = Color.green;

    private void OnDrawGizmos()
    {
        
        Gizmos.color = gridColor;

        Gizmos.DrawLine(startPoint.position, endPoint.position);

        
    }

}
