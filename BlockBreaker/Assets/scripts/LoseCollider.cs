using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    private LevelManager myLevelManager;

    //works when Collider is a Collider2D
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision with "+ collision.gameObject.name);  
    }

    //works when Collider is Trigger
    void OnTriggerEnter2D(Collider2D collision)
    {
        print("Triggered by " + collision.gameObject.name);
        myLevelManager.LoadLevel("Win");
    }

    // Use this for initialization
    void Start () {

        myLevelManager = GameObject.FindObjectOfType<LevelManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
