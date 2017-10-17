using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonBreak : MonoBehaviour {

    public Text myText;

    void Cell()
    {
        myText.text = "“You are in a prison cell, " +
                "and you want to escape. There are " +
                "some dirty sheets on the bed, a mirror on " +
                "the wall, and the door " + "is locked from " +
                "the outside.\n\n" + "Press S to view Sheets, " +
                "M to view Mirror and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.sheets_0;
        }

    }

    void Sheets_0()
    {
        myText.text = "You can't believe you sleep in these things. " +
            "Surely it's " + "time somebody changed them. " +
            "The pleasures of prison life " +
            "I guess!\n\n" + "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }

    }

    private enum States
    {
        cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom
    };

    private States myStates;



	// Use this for initialization
	void Start () {

        myStates = States.cell;
		
	}
	
	// Update is called once per frame
	void Update () {

        print(myStates);

        if (myStates == States.cell)
        {
            Cell();
        }
        else if (myStates == States.sheets_0)
        {
            Sheets_0();
        }
		
	}
}
