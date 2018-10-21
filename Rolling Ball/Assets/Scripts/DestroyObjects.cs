using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyObjects : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Ground1")
        {
            Destroy(other.GetComponentsInParent<Transform>()[1].gameObject);
        }
        else if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
