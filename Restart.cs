using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public static bool hasRestarted = false;
    public void restartScene()
    {
        hasRestarted = true;
        SceneManager.LoadScene("Level");
        Time.timeScale = 1f;

    }
}
