using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Enemy hp is designated by multiple child gameObjects attached to the main enemy. Every time an enemy
 * is damaged the next lower sprite is turned on while the current one is turned off. The hp of the enemy
 * when being created is decided by the checkmark in the inspector next to the hp desired. Only one hp 
 * should be selected, others must be turned off.
 */
public class EnemyHealth : MonoBehaviour
{
    public List<GameObject> enemySprites;

    /**
     * Looks through the hp children gameObjects of the current enemy, turns off the current one
     * and turns on the next lower in hp. If the current enemy is on 1 hp, destroys the parent
     * gameObject and notifies the game manager.
     */
    public void TakeDamage()
    {
        for (int i = 0; i < enemySprites.Count; i++)
        {
            if (!enemySprites[i].activeSelf)
                continue;

            enemySprites[i].SetActive(false);

            if (i == 0)
            {
                GameManager.instance.OnEnemyDestroyed();
                Destroy(gameObject);
                GetComponent<EnemyDrops>().EnemyDied();
                break;
            }

            enemySprites[i - 1].SetActive(true);
        }
    }


}
