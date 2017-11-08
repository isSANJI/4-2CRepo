using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Paddle myPaddle;

    private Vector3 paddleToBallVector;

    private bool hasStarted = false;

	// Use this for initialization
	void Start () {

        //saves the distance between the ball and the paddle
        paddleToBallVector = this.transform.position - myPaddle.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!hasStarted) //if hasStarted == false
        {
            //attaches the ball to the paddle
            //keeping the distance
            this.transform.position = myPaddle.transform.position + paddleToBallVector;

            
            //if left click is pressed
            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
                Debug.Log(hasStarted);
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
                
            }
        }

        
		
	}
}
