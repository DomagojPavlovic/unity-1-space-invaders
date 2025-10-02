using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    private readonly float speed = 2f;


    void Update()
    {
        transform.Translate(0f, -speed * Time.deltaTime, 0f);
        checkIfOutOfRange();
    }

    void checkIfOutOfRange()
    {
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}
