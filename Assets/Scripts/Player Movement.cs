using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float movementSpeed = 0;
    [SerializeField] float jumpForce = 0;
    int currentJumpAmount;
    [SerializeField] int maxJumpAmount;

    [SerializeField] ShopManager shopManagerScript;
    BallSpawning ballSpawningScript;

    public Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentJumpAmount != 0)
        {
            rigidBody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            currentJumpAmount -= 1;
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rigidBody2D.AddForce(new Vector2(movementSpeed, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody2D.AddForce(new Vector2(-movementSpeed, 0), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            currentJumpAmount = maxJumpAmount;
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            print("Touched");

            GameObject ball = collision.gameObject;

            Destroy(ball);
            if(shopManagerScript != null)
            {
            shopManagerScript.coins += 10;
            shopManagerScript.coinsTXT.text = "Coins: " + shopManagerScript.coins.ToString();
            }
            else
            {
                print("ShopManagerScript is not assigned");
            }
        }
    }
}
