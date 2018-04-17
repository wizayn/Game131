using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBounce : MonoBehaviour {

    public float bounce;

    // Use this for initialization
    void Start()
    {
        GetComponent<Collider2D>().sharedMaterial.bounciness = bounce;       
	}
	
	
}
