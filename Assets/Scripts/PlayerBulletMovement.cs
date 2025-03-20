using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMovement : MonoBehaviour
{
    public readonly float speed = 3f;
    //public readonly float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
        checkIfOutOfRange();
    }

    void checkIfOutOfRange()
    {
        if (transform.position.y > 2f)
        {
            Destroy(gameObject);
        }
    }
}
