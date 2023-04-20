using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject playerCharacter;
    public Vector3 pos;

    private void Awake()
    {
        //DontDestroyOnLoad(playerCharacter);
    }

    public void SwitchScene()
    {
        //playerCharacter.transform.position = pos;
        //StartCoroutine(TransferPlayer());
        SceneManager.LoadScene("Island");
    }

    IEnumerator TransferPlayer()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Island", LoadSceneMode.Additive);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        SceneManager.MoveGameObjectToScene(playerCharacter, SceneManager.GetSceneByName("Island"));
        SceneManager.UnloadSceneAsync(currentScene);
    }
}
