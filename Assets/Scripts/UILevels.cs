using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UILevels : MonoBehaviour
{
    public TextMeshProUGUI Text;


    public void UpdateUI(int level)
    {
        Text.text = "Level " + level;
    }
}
