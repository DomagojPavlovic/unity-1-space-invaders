using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public static float Speed = 1f;
    //public static float Speed = 0f;
    private readonly float bounds = GameManager.BOUNDS;
    /**
     * false = left, true = right
     */
    private static bool direction = false;

    void Update()
    {
        Move();
    }

    void Move()
    {
        // were out of bounds, swap direction
        if ((direction && transform.position.x < -bounds) || (!direction && transform.position.x > bounds))
        {
            direction = !direction;
        }


        // current direction is left and we're in bounds so move left
        if (direction && transform.position.x > -bounds)
        {
            transform.Translate(-Speed * Time.deltaTime, 0f, 0f);
        }
        // currenct direction is right and we're in bounds so move right
        else if (!direction && transform.position.x < bounds)
        {
            transform.Translate(Speed * Time.deltaTime, 0f, 0f);
        }


    }
}
