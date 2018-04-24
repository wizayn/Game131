using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOptionScript : MonoBehaviour {

    public static int temp = 0;
    public Sprite[] spriteArray;
    void Start()
    {
        spriteArray = new Sprite[temp];
    }

}
