using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject characterCustomiser;
    int p;
    int s;

    public void SwitchScene()
    {
        //p = characterCustomiser.GetComponent<CharacterCustomiser>().PrimaryHair;
        //s = characterCustomiser.GetComponent<CharacterCustomiser>().SecondaryHair;
        //StartCoroutine(TransferManager());
        SceneManager.LoadScene("Island");
    }

    IEnumerator TransferManager()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Island", LoadSceneMode.Additive);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        SceneManager.MoveGameObjectToScene(this.gameObject, SceneManager.GetSceneByName("Island"));
        SceneManager.UnloadSceneAsync(currentScene);
    }
}
