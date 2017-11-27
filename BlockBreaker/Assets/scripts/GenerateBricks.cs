using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBricks : MonoBehaviour {

    public List<GameObject> listOfBricks = new List<GameObject>();

	// Use this for initialization
	void Start () {

        //adding bricks from Resources to listOfBricks
        listOfBricks.AddRange(Resources.LoadAll<GameObject>(""));

        /*foreach (GameObject go in listOfBricks)
        {
            print("Brick " + go.name);
        }*/

        Vector3 brickPosition = new Vector3(-5f, 3f, 0);

        for (int row = 1; row <= 6; row++)
        {
            //prints bricks on x-axis
            for (int i = -5; i < 6; i++)
            {
                int rand = Random.Range(0, listOfBricks.Count);

                GameObject temp = listOfBricks[rand];

                brickPosition.x = i;

                Instantiate(temp, brickPosition, Quaternion.identity);
            }

            float yPos = brickPosition.y - 0.3f;

            brickPosition = new Vector3(-5f, yPos, 0);
        }

        
        /*
        for (int i = -5; i < 6; i++)
        {
            int rand = Random.Range(0, listOfBricks.Count);

            GameObject temp = listOfBricks[rand];

            brickPosition.x = i;

            Instantiate(temp, brickPosition, Quaternion.identity);
        }*/

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
