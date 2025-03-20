using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;

    public void UpdateUI(int newHealth)
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < newHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }

    public void ResetHealth(int maxHealth)
    {
        UpdateUI(maxHealth);
    }
}
