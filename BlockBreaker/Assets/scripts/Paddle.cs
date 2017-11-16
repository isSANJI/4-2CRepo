using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    private Ball myBall;

	// Use this for initialization
	void Start () {

        myBall = GameObject.FindObjectOfType<Ball>();
		
	}
	
	// Update is called once per frame
	void Update () {

        //saves the mousePosition in Units
        float mousePosInUnits = (Input.mousePosition.x / Screen.width * 13f) - 6.5f;

        //restricts mousePosInUnits between -6f and 6f
        //float mousePos = Mathf.Clamp(mousePosInUnits, -6f, 6f);
        float mousePos = Mathf.Clamp(myBall.transform.position.x, -6f, 6f);

        //Vector3: saves any coordinate in 3D space
        //as x,y,z
        //this.transform.position.y = keeps the original y-axis
        Vector3 paddlePosition = new Vector3(mousePos, this.transform.position.y, 0);

        this.transform.position = paddlePosition;
		
	}
}
