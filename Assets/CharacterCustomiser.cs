using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class CharacterCustomiser : MonoBehaviour
{
    public Texture2D[] Faces;
    public Material[] PlayerMats;
    public GameObject PlayerBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeFace()
    {
        PlayerMats[1].SetTexture("_DecalTex", Faces[Random.Range(0,Faces.Length)]);
    }
}
