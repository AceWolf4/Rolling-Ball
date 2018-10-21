using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    public float jumpSpeed;

    private Rigidbody2D rb;

    private bool isJumping;

    public bool canJump=false;

    public bool canSpawn=false;

    public Transform previousPattern;

    public Transform currentPattern;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            isJumping = true;
            GetComponent<Collider2D>().isTrigger = true;
        }
        

    }

    

    private void FixedUpdate()
    {
        //horizontal movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb.AddForce(movement * speed);

        //jump
        if (isJumping)
        {
            Vector2 up = new Vector2(0, 1);
            rb.AddForce(up*jumpSpeed);
            isJumping = false;
            canJump = false;
        }
    }

    public void patternChanged()
    {
        if (previousPattern.name != currentPattern.name)
        {
            previousPattern.GetComponent<PatternTranslate>().canTranslate = true;
        }
    }
    
}
