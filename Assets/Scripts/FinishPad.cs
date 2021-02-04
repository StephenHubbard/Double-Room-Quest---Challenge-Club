using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Check out https://community.gamedev.tv/(thisSpecificThread) to discuss this quest with other members of Challenge Club.
// If you'd like to discuss this challenge on Discord with other members of Challenge Club, be sure to check out https://discord.gg/abcdefg for the Challenge Club private channel.  

public class FinishPad : MonoBehaviour
{
    private GameHandler gameHandler;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>())
        {
            Destroy(other.gameObject);
        }
    }
}
