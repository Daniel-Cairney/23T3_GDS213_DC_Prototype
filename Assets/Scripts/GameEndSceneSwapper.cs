using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndSceneSwapper : MonoBehaviour
{
    public void WinScene()
    {
        SceneManager.LoadScene("WinScene");
    }

    public void LoseScene()
    {
        SceneManager.LoadScene("LoseScene");
    }
}
