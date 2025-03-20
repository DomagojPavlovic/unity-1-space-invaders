using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingDropCollisionWithPlayer : MonoBehaviour
{
    private int dropHealing = 1;
    private string targetTag = "Player";

    private void OnTriggerEnter2D(Collider2D collider)
    {
     
        PlayerHealth playerHealth = collider.gameObject.GetComponent<PlayerHealth>();
        if (playerHealth != null && collider.gameObject.tag == targetTag)
        {
            playerHealth.GainHealth(dropHealing);
            Destroy(gameObject);
        }
    }
}
