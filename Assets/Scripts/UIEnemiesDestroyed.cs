using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIEnemiesDestroyed : MonoBehaviour
{
    public TextMeshProUGUI EnemiesDestroyedText;


    public void UpdateUI(int enemiesDestroyed, int enemiesToDestroy)
    {
        EnemiesDestroyedText.text = enemiesDestroyed + "/" + enemiesToDestroy;
    }
}
