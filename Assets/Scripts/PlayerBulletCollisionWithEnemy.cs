using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletCollisionWithEnemy : MonoBehaviour
{
    public string targetTag = "Enemy";

    private void OnTriggerEnter2D(Collider2D collider)
    {
        EnemyHealth enemyHealth = collider.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null && collider.gameObject.tag == targetTag)
        {
            enemyHealth.TakeDamage();
            Destroy(gameObject);
        }
    }
}
