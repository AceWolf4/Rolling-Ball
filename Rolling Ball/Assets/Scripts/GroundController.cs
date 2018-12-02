using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{

    public GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerController>().canJump = true;
            if (other.transform.position.y >= 0)
            {
                if (name == "Ground1")
                {
                    other.GetComponent<PlayerController>().canSpawn = true;
                }
                GetComponentInParent<PatternTranslate>().canTranslate = true;

                other.GetComponent<PlayerController>().currentPattern = GetComponentsInParent<Transform>()[1];
                other.GetComponent<PlayerController>().patternChanged();

                player.GetComponent<PlayerController>().score++;

            }
            other.isTrigger = false;
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (name == "Ground1")
        {
            other.GetComponent<PlayerController>().previousPattern = GetComponentsInParent<Transform>()[1];
        }
    }
   

}

    
