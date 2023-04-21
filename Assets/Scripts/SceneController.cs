using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("Island");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
