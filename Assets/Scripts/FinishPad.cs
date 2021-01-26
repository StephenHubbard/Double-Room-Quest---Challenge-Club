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
        //CHALLENGE 2a:  use in FindObjectOfType to assign gameHandler to our GameHandler class. 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>())
        {
            //CHALLENGE 4a:    
            // Hint: Use a SerializeField at the top of this script to assign a prefab of choice in the inspector you'd like to spawn into your scene.  
            // (https://docs.unity3d.com/ScriptReference/Object.Instantiate.html)

            Destroy(other.gameObject);
        }
    }
}
