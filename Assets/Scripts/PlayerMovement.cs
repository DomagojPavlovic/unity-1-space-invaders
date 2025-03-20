using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /**
     * The movement speed of the player.
     */
    private readonly float speed = 2f;
    /**
     * The bounds of the game, so that the player cannot leave the screen.
     */
    private readonly float bounds = GameManager.BOUNDS;

    /**
     * Loads the current position of the player so it can be the same position the player ended on in the previous player.
     */
    private void Start()
    {
        if(StaticData.LoadFromStaticData())
        {
            transform.position = StaticData.currentPlayerPosition;
        }
    }

    /**
     * Used to move the player based on the input.
     */
    void Update()
    {
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x > -bounds)
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }
        if((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x < bounds)
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
    }
}