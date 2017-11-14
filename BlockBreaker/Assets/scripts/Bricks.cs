using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {

    public int maxHits;

    private int numberOfHits = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        numberOfHits++;
        print(numberOfHits);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
