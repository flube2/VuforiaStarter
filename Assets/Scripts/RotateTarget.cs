using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTarget : MonoBehaviour {

    public string directionAsString;
    private float rotationSpeedMultiplier;
    private Vector3 direction;

	// Use this for initialization
	void Start () {
        
        switch(directionAsString.ToLower())
        {

            case "up":
                direction = Vector3.up;
                break;
            case "down":
                direction = Vector3.down;
                break;
            case "left":
                direction = Vector3.left;
                break;
            case "right":
                direction = Vector3.right;
                break;
            case "forward":
                direction = Vector3.forward;
                break;
            case "backward":
                direction = Vector3.back;
                break;

        }



	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(direction, Time.deltaTime*rotationSpeedMultiplier);
    }
}
