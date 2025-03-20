using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIHealth : MonoBehaviour
{
    public TextMeshProUGUI HealthText;

    public void UpdateUI(int current, int max)
    {
        HealthText.text = "HP: " + current + "/" + max;
    }
}
