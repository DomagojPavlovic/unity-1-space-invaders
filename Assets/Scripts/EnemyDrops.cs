using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrops : MonoBehaviour
{
    /**
     * Drops once in HEAL_DROP_CHANCE enemies killed
     */
    private readonly int HEAL_DROP_CHANCE = 30;
    /**
     * Drops once in HEAL_DROP_CHANCE enemies killed
     */
    private readonly int POWERUP_DROP_CHANCE = 45;

    public GameObject healDrop;
    public GameObject powerupDrop;

    public void EnemyDied()
    {
        if (GameManager.instance.RANDOM.Next(1, 3) == 1)
        {
            AttemptToDropHealing();
        }
        else
        {
            AttemptToDropPowerup();
        }
    }

    void AttemptToDropHealing()
    {
        // I divide the drop chance by 2 because we multiply it when entering
        if (GameManager.instance.RANDOM.Next(1, HEAL_DROP_CHANCE / 2) == 1)
        {
            Instantiate(healDrop, transform.position, Quaternion.identity);
        }
    }

    void AttemptToDropPowerup()
    {
        // I divide the drop chance by 2 because we multiply it when entering
        if (GameManager.instance.RANDOM.Next(1, POWERUP_DROP_CHANCE / 2) == 1)
        {
            Instantiate(powerupDrop, transform.position, Quaternion.identity);
        }
    }
}
