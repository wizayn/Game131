using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSnap : MonoBehaviour
{

    public int rows;
    public int cols;
    public float gridSize = 2.08f;

    public Color gridColor = Color.green;

    private void OnDrawGizmos()
    {
        Gizmos.color = gridColor;

        //draw a number horizontal lines with length of gridSize * colums number and number of lines equal to cols value. 
        for (int i = 0; i <= cols; i++)
        {
            Gizmos.DrawLine(new Vector3(i * gridSize, 0, transform.position.z),
                    new Vector3(i * gridSize, rows * gridSize, transform.position.z));
        }

        //draw virtical lines with length of gidSize * rows number and number of lines equal to rows value.
        for (int j = 0; j <= rows; j++)
        {
            Gizmos.DrawLine(new Vector3(0, j * gridSize, transform.position.z),
                            new Vector3(cols * gridSize, j * gridSize, transform.position.z));
        }

        //find sprite renderer of current renderered object
        SpriteRenderer[] sprite = GameObject.FindObjectsOfType<SpriteRenderer>();

        //loops through the 
        for (int k = 0; k < sprite.Length; k++)
        {
            // get the center point of sprite
            SpriteRenderer thisSpritesRenderer = sprite[k];
            Sprite currentSprite = thisSpritesRenderer.sprite;

            // get the sprites center based on the current sprites bound center
            Vector3 spriteCenterWorld = thisSpritesRenderer.transform.position + currentSprite.bounds.center;

            //Convert from world corridinates to grid corrdinates
            Vector3 gridCords = new Vector3( Mathf.FloorToInt(spriteCenterWorld.x / gridSize),
                                             Mathf.FloorToInt(spriteCenterWorld.y / gridSize),
                                             thisSpritesRenderer.transform.position.z);

            //scale grid corrdinates by the gridSize to get back to world corrdinates
            thisSpritesRenderer.transform.position = transform.position + gridCords * gridSize;
        }
    }
}