using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private int level;
    public int enemiesToKill;
    public int enemiesKilled;

    public int timer = 0;
    public bool transitionActivated;
    public readonly int TRANSITION_DURATION = 4 * 50;
    

    public static LevelManager instance;

    /**
     * Instantiates one singleton element.
     */
    private void Awake()
    {
        instance = this;
    }


    public bool EnemyKilled()
    {
        enemiesKilled++;
        if (enemiesKilled != enemiesToKill)
            return false;


        if (level != SceneManager.sceneCountInBuildSettings - 1)
        {
            transitionActivated = true;
            GameManager.instance.levelUI.UpdateUI(level + 2);
            GameManager.instance.levelUI.gameObject.SetActive(true);
        } else
        {
            return true;
        }

        return false;
    }

    private void Update()
    {
        if ((Input.GetKey(KeyCode.R))) 
            RestartGame();
    }

    void FixedUpdate()
    {
        if (!transitionActivated)
            return;

        timer++;
        if(timer == TRANSITION_DURATION)
        {
            timer = 0;
            transitionActivated = false;
            GameManager.instance.levelUI.gameObject.SetActive(false);
            LoadNextLevel();
        }
        
    }


    // Start is called before the first frame update
    void Start()
    {
        enemiesKilled = 0;
        level = SceneManager.GetActiveScene().buildIndex;
    }


    void SaveValuesForNextLevel()
    {
        StaticData.currentPlayerPosition = Player.instance.transform.position;  
        StaticData.currentPlayerHealth = Player.instance.GetComponent<PlayerHealth>().CurrentHealth;
        StaticData.currentPlayerLevel = Player.instance.GetComponent<PlayerBulletShoot>().level;
    }

    void LoadNextLevel()
    {
        SaveValuesForNextLevel();
        SceneManager.LoadScene(level + 1);
        
    }

    void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
