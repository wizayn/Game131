using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBounce : MonoBehaviour {

    public float bounce;

    // Use this for initialization
    void Start()
    {
        //sets the bounciness value on the collider2Ds shared material of the object this is script is attached to bounce
        GetComponent<Collider2D>().sharedMaterial.bounciness = bounce;       
	}
	
	
}
