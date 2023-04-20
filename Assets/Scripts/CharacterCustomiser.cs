using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class CharacterCustomiser : MonoBehaviour
{
    public Material[] playerMats;
    public GameObject[] hair;
    public Texture2D[] faces;
    public Texture2D[] shirts;
    public Texture2D[] pants;
    public Texture2D[] skinColor;

    int PrimaryHair = 0;
    int SecondaryHair = 0;

    private void Start()
    {
        playerMats[0].color = Color.black;
        ChangePrimaryHair(Random.Range(0, hair.Length));
        playerMats[1].SetTexture("_DecalTex", faces[Random.Range(0, faces.Length)]);
        playerMats[2].SetTexture("_DecalTex", shirts[Random.Range(0, shirts.Length)]);
        playerMats[3].SetTexture("_DecalTex", pants[Random.Range(0, pants.Length)]);
        Texture2D sc = skinColor[Random.Range(0, skinColor.Length)];
        for (int i = 1; i < playerMats.Length; i++)
        {
            playerMats[i].SetTexture("_MainTex", sc);
        }
    }

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

    public void ChangeHairColor(Color color)
    {
        playerMats[0].color = color;
    }

    public void ChangeFace(int faceId)
    {
        playerMats[1].SetTexture("_DecalTex", faces[faceId]);
    }

    public void ChangeShirt(int shirtId)
    {
        playerMats[2].SetTexture("_DecalTex", shirts[shirtId]);
    }

    public void ChangePants(int PantsId)
    {
        playerMats[3].SetTexture("_DecalTex", pants[PantsId]);
    }

    public void ChangeSkin(int SkinId)
    {
        for (int i = 1; i < playerMats.Length; i++)
        {
            playerMats[i].SetTexture("_MainTex", skinColor[SkinId]);
        }
    }
}
