using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternTranslate : MonoBehaviour {

    public bool canTranslate = false;

    private Vector2 targetPos;

    public float speed = 1;

    // Use this for initialization
    void Start () {
        targetPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (canTranslate)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - 4);
            //Debug.Log(parent.name+"update: "+targetPos);
            canTranslate = false;
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
}
