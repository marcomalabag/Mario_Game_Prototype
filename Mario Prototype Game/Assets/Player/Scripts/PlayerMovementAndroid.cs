using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementAndroid : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float walkDistance;

    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float jumpForce;

    private bool moveRight;
    private bool moveLeft;
    private bool Jump;

    // Start is called before the first frame update
    void Start()
    {
        moveLeft = false;
        moveRight = false;
        Jump =false;
    }

    // Update is called once per frame
    void Update()
    { 
        movement();
    }

    private void FixedUpdate()
    {
        if (!this.Jump)
        {
            this.rb.velocity = new Vector2(this.walkDistance, this.rb.velocity.y);
        }
        else
        {
            this.rb.velocity = new Vector2(this.rb.velocity.x, this.walkDistance);
        }

        
    }

    public void InputDownJump()
    {
        Jump = true;
    }

    public void InputUpJump()
    {
        Jump = false;
    }

    public void InputDownLeft()
    {
        moveLeft= true;
    }

    public void InputUpLeft()
    {
        moveLeft = false;
    }

    public void InputUpRight()
    {
        moveRight = false;
    }

    public void InputDownRight()
    {
        moveRight = true;
    }

    public void movement()
    {
        if (moveLeft)
        {
            this.walkDistance = Time.deltaTime * -(speed);
        }

        else if (moveRight)
        {
            this.walkDistance = Time.deltaTime * speed;
        }

        else if (Jump)
        {
            this.walkDistance = Time.deltaTime * jumpForce;
            
        }

        else
        {
            this.walkDistance = 0;
        }
    }


}
