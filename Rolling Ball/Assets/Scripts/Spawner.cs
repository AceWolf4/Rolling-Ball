using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] GroundPatternLeft;

    public GameObject[] GroundPatternMiddle;

    public GameObject[] GroundPatternRight;

    public GameObject player;

    private int previousEndPattern = 1;//center
	
	// Update is called once per frame
	void Update () {
        if (player.GetComponent<PlayerController>().canSpawn)
        {
            int randPattern = Random.Range(0, 2);
            int rand = Random.Range(0, 2);
            if (previousEndPattern == 0)
            {
                if (randPattern == 0)
                {
                    Instantiate(GroundPatternMiddle[rand], transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(GroundPatternRight[rand], transform.position, Quaternion.identity);
                }
            }
            else if (previousEndPattern == 1)
            {
                if (randPattern == 0)
                {
                    Instantiate(GroundPatternLeft[rand], transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(GroundPatternRight[rand], transform.position, Quaternion.identity);
                }
            }
            else
            {
                if (randPattern == 0)
                {
                    Instantiate(GroundPatternLeft[rand], transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(GroundPatternMiddle[rand], transform.position, Quaternion.identity);
                }
            }
            player.GetComponent<PlayerController>().canSpawn = false;
        }
	}
}
