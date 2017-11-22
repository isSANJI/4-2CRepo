using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {

    //available throughout all the game
    public static int breakableCount = 0;

    public AudioClip myClip;

    public int maxHits;

    private LevelManager myLevelManager;

    private int numberOfHits = 0;

    private bool isBreakable = false;

    void HandleHits()
    {
        numberOfHits++;

        if (numberOfHits >= maxHits)
        {
            breakableCount--;
            AudioSource.PlayClipAtPoint(myClip, transform.position);
            Destroy(this.gameObject);
            myLevelManager.BrickDestroyed();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        

        
        //if isBreakable == true
        if (isBreakable )
        {
            HandleHits();
        }
        
    }

    void SimulateWin()
    {
        myLevelManager.LoadNextLevel();
    }

	// Use this for initialization
	void Start () {

        myLevelManager = GameObject.FindObjectOfType<LevelManager>();
        
        //if tag == break, isBreakable = true
        isBreakable = this.tag == ("break");

        if (isBreakable) //if (isBreakable == true)
        {
            breakableCount++;
        }


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
