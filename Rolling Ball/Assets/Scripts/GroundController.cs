using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collision");
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerController>().canJump = true;
            other.isTrigger = false;
        }
    }

}
