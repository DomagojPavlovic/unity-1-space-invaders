using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /**
     * The singleton instance of the GameManager.
     */
    public static GameManager instance;
    /**
     * The left/right bounds of the game, used so that the elements of the game don't leave the screen.
     */
    public static readonly float BOUNDS = 3.4f;
    /**
     * Single instance of the randomizer used in the game.
     */
    public readonly System.Random RANDOM = new();
    /**
     * The ui displayed when the game is lost.
     */
    public GameObject youDiedUI;
    /**
     * The ui displayed when the game is won.
     */
    public GameObject youWinUI;
    /**
     * The ui displayed between levels.
     */
    public UILevels levelUI;

    /**
     * Instantiates one singleton element.
     */
    private void Awake()
    {
        instance = this;
    }

    /**
     * Required to call when an enemy is destroyed. Tracks the killcount and displays the winning ui if 
     * the last enemy on the last level is destroyed.
     */
    public void OnEnemyDestroyed()
    {
        if(LevelManager.instance.EnemyKilled())
        {
            youWinUI.SetActive(true);
        }
    }

    /**
     * Required to call when the player died. Displays the losing ui.
     */
    public void OnPlayerDied()
    {
        youDiedUI.SetActive(true);
    }
}
