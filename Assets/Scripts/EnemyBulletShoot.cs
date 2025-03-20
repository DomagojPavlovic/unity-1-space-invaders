using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletShoot : MonoBehaviour
{
    public GameObject Bullet;
    private float updatePeriod;
    /**
     * How often do you expect a single enemy to shoot: every 'expectationInSeconds' seconds.
     */
    private int expectationInSeconds = 3;

    private void Start()
    {
        updatePeriod = 1.0f / Time.fixedDeltaTime;
    }

    void FixedUpdate()
    {
        if (GameManager.instance.RANDOM.Next(1, (int) (expectationInSeconds * updatePeriod)) == 1)
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }
}
