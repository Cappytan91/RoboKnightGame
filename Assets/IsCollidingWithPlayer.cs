using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCollidingWithPlayer : MonoBehaviour
{
    // Tag of the player object we want to detect
    public string playerTag = "Player";

    // Reference to the child circle collider
    private Collider2D childCircleCollider;

    // Function to check if the child circle collider is touching the player
    private bool IsTouchingPlayer()
    {

	// Get the child circle collider component
        childCircleCollider = transform.Find("Explosion").GetComponent<Collider2D>();

        // Loop through all the colliders that intersect with the child circle collider
        Collider2D[] colliders = Physics2D.OverlapCircleAll(childCircleCollider.transform.position, childCircleCollider.radius);
        foreach (Collider2D collider in colliders)
        {
            // Check if the collider belongs to a game object with the player tag
            if (collider.CompareTag(playerTag))
            {
                return true; // Player is touching the child circle collider
            }
        }

        return false; // Player is not touching the child circle collider
    }

//    private void Start()
//    {
//        // Get the child circle collider component
 //       childCircleCollider = transform.Find("Explosion").GetComponent<Collider2D>();
   // }

//    private void Update()
  //  {
    //    // Check if the child circle collider is touching the player and output the result
      //  bool isTouchingPlayer = IsTouchingPlayer();
        //Debug.Log("Child circle collider is touching player: " + isTouchingPlayer);
    //}
}
