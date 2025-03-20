using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupDropCollisionWithPlayer : MonoBehaviour
{
    private string targetTag = "Player";

    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.tag == targetTag)
        {
            PlayerBulletShoot playerBulletShoot = collider.gameObject.GetComponent<PlayerBulletShoot>();
            playerBulletShoot.LevelUp();
            Destroy(gameObject);
        }
    }
}
