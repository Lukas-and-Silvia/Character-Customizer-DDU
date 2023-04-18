using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class CharacterCustomiser : MonoBehaviour
{
    public Material[] playerMats;
    public GameObject[] hair;
    public Texture2D[] faces;

    int PrimaryHair = 0;
    int SecondaryHair = 0;

    public void ChangePrimaryHair(int hairId)
    {
        for (int i = 0; i < hair.Length; i++)
        {
            if (i == SecondaryHair)
            {
                continue;
            }
            hair[i].SetActive(false);
        }
        hair[hairId].SetActive(true);
        PrimaryHair = hairId;
    }

    public void ChangeSecondaryHair(int hairId)
    {
        for (int i = 0; i < hair.Length; i++)
        {
            if (i == PrimaryHair)
            {
                continue;
            }
            hair[i].SetActive(false);
        }
        hair[hairId].SetActive(true);
        SecondaryHair = hairId;
    }

    public void ChangeFace(int faceId)
    {
        playerMats[1].SetTexture("_DecalTex", faces[faceId]);
    }
}
