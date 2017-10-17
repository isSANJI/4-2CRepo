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
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myStates = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.lock_0;
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

    void Mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape!" +
            " There are some dirty sheets on the bed, a mirror , " +
    "and that pesky door is still there, and firmly locked!\n\n" +
    "Press R to go back Cell or T to Take the Mirror";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            myStates = States.cell_mirror;
        }

    }

    void Cell_Mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
        "some dirty sheets on the bed, a mark where the mirror was, " +
        "and that pesky door is still there, and firmly locked!\n\n" +
        "Press S to view Sheets, or L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.lock_1;
        }
    }

    void Sheets_1()
    {
        myText.text = "Holding a mirror in your hand doesn't make the sheets look " +
		"any better.\n\n" +

        "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }

    }

    void Lock_1()
    {
        myText.text = "You carefully put the mirror through the bars, and turn it round " +
        "so you can see the lock. You can just make out fingerprints around " +
        "the buttons. You press the dirty buttons, and hear a click.\n\n" +
        "Press O to Open, or R to Return to your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            myStates = States.freedom;
        }

    }

    void Lock_0()
    {
        myText.text = "This is one of those button locks. You have no idea what the " +
      "combination is. You wish you could somehow see where the dirty " +
    "fingerprints were, maybe that would help.\n\n" +
    "Press R to Return to roaming your cell";

        if(Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }

    }

    void Freedom()
    {
        myText.text = "YOU ARE FREE!!\n\n Press P to Play again or Q to QUIT.";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myStates = States.cell;
        }
        else if(Input.GetKeyDown(KeyCode.Q))
        {
            UnityEditor.EditorApplication.isPlaying = false;
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
        else if (myStates == States.mirror)
        {
            Mirror();
        }
        else if (myStates == States.cell_mirror)
        {
            Cell_Mirror();
        }
        else if (myStates == States.sheets_1)
        {
            Sheets_1();
        }
        else if (myStates == States.lock_1)
        {
            Lock_1();
        }
        else if (myStates == States.freedom)
        {
            Freedom();
        }
        else if (myStates == States.lock_0)
        {
            Lock_0();

        }
		
	}
}
