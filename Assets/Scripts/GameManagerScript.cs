using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject[] hair;

    int p;
    int s;

    // Start is called before the first frame update
    void Start()
    {
        p = CharacterCustomiser.PrimaryHair;
        s = CharacterCustomiser.SecondaryHair;

        for (int i = 0; i < hair.Length; i++)
        {
            if (i == p||i == s)
            {
                hair[i].SetActive(true);
            }
            else
            {
                hair[i].SetActive(false);
            }
        }
    }
}
