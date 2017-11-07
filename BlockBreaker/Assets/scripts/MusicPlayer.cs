using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    //static variables or objects are available throughout 
    //all instances of the same class
    static MusicPlayer myMusicPlayer = null;

    //Awake() is the first method run
    // so we are destroying the object as soon as 
    // the program runs
    void Awake()
    {

        //if an instance of myMusicPlayer exists
        if (myMusicPlayer != null)
        {
            Debug.Log("Destroying object " + this.gameObject.GetInstanceID().ToString());
            //destroy the new object created
            Destroy(this.gameObject);
        }
        else //myMusicPlayer = null
        {
            //myMusicPlayer is filled with my FIRST Sound Object
            myMusicPlayer = this;
            //this.gameObject = the gameObject attached to 
            //this script, being SoundObject
            
            //DontDestroyOnLoad = do not destroy the gameObject
            //when loading a new scene
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
