using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int CurrentHealth;
    public readonly int MaxHealth = 3;
    public UIHealth HealthUI;
    private PlayerAnimation playerAnimation;

    private HealthDisplay healthDisplay;


    void Start()
    {
        playerAnimation = GetComponent<PlayerAnimation>();
        healthDisplay = GetComponent<HealthDisplay>();
        if(StaticData.LoadFromStaticData())
        {
            ResetHealth(StaticData.currentPlayerHealth);
        } 
        else
        {
            ResetHealth(MaxHealth);
        }
    }

    public void ResetHealth(int health)
    {
        CurrentHealth = health;
        healthDisplay.ResetHealth(health);
    }

    public void LoseHealth(int damage)
    {
        if(playerAnimation.LoseHealth())
        {
            CurrentHealth -= damage;
            healthDisplay.UpdateUI(CurrentHealth);
            GetComponent<PlayerBulletShoot>().LevelDown();

            CheckIfDead();
        }

    }

    public void GainHealth(int healing)
    {
        if (CurrentHealth < MaxHealth)
        {
            CurrentHealth += healing;
            healthDisplay.UpdateUI(CurrentHealth);
        }
    }

    public void CheckIfDead()
    {
        if (CurrentHealth <= 0)
        {
            GameManager.instance.OnPlayerDied();
            Destroy(gameObject);
        }
    }
}
