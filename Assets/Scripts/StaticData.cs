using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaticData : MonoBehaviour
{
    public static Vector3 currentPlayerPosition;
    public static int currentPlayerHealth;
    public static int currentPlayerLevel;

    public static bool LoadFromStaticData()
    {
        return SceneManager.GetActiveScene().buildIndex != 0;
    }
}
