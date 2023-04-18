using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class CharacterCustomiser : MonoBehaviour
{
    public Texture2D[] faces;
    public Material[] playerMats;
    public GameObject playerBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeFace(int faceId)
    {
        playerMats[1].SetTexture("_DecalTex", faces[faceId]);
    }
}
