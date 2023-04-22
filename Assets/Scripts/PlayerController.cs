using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal"); 
        float zMove = Input.GetAxisRaw("Vertical"); 
        
        playerRb.AddForce(xMove * speed, playerRb.velocity.y, zMove * speed);
    }
}
