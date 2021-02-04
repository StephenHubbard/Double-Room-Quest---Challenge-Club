using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Check out https://community.gamedev.tv/(thisSpecificThread) to discuss this quest with other members of Challenge Club.
// If you'd like to discuss this challenge on Discord with other members of Challenge Club, be sure to check out https://discord.gg/abcdefg for the Challenge Club private channel. 

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody rb;

    private Vector3 moveDirection;

    void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(moveX, 0, moveZ).normalized;
    }

    private void Move()
    {
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, 0, moveDirection.z * moveSpeed);
    }
}
