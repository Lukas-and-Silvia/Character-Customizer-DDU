using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject[] menus;
    public GameObject[] mainMenus;
    public Color[] hairColors;
    private List<GameObject> colorButtons;
    private List<int> colorIds;

    public GameObject characterCustom;
    public GameObject spawnLocation;
    public GameObject colorButtonPrefab;
    public GameObject playerModel;
    public GameObject checkmark;

    private bool toggleCustom = true;

    public Vector3 amount;

    private void Start()
    {
        colorButtons = new List<GameObject>();
        colorIds = new List<int>();

        for (int i = 0; i < hairColors.Length; i++)
        {
            int n = new int();
            n = i;
            colorIds.Add(n);
            colorButtons.Add(Instantiate(colorButtonPrefab, spawnLocation.transform));
            colorButtons[i].GetComponent<Image>().color = hairColors[i];
            colorButtons[i].GetComponent<Button>().onClick.AddListener(() => ButtonClickEvent(colorButtons[n]));
        }
    }

    public void ButtonClickEvent(GameObject button)
    {
        for (int i = 0; i < colorButtons.Count; i++)
        {
            if (colorButtons[i] == button)
            {
                characterCustom.GetComponent<CharacterCustomiser>().ChangeHairColor(hairColors[i]);
            }
        }
    }

    public void SwitchMenus(GameObject OpenMenu)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            if (OpenMenu == menus[i] && OpenMenu.activeInHierarchy)
            {
                menus[i].SetActive(false);
                return;
            }
            menus[i].SetActive(false);
        }
        OpenMenu.SetActive(true);
    }

    public void TurnPlayer(bool rotation)
    {
        if (rotation)
        {
            playerModel.transform.Rotate(amount);
        }
        else
        {
            playerModel.transform.Rotate(-amount);
        }
    }

    public void StartCustom(GameObject sender)
    {
        characterCustom.GetComponent<CharacterCustomiser>().Randomise();

        if (toggleCustom)
        {
            foreach (GameObject g in mainMenus)
            {
                if (g == sender)
                {
                    g.SetActive(false);
                    continue;
                }
                g.SetActive(true);
            }
        }
        else
        {

        }
    }

    public void ToggleCustom()
    {
        toggleCustom = !toggleCustom;
        if (toggleCustom)
        {
            checkmark.SetActive(true);
        }
        else
        {
            checkmark.SetActive(false);
        }
    }

    public Color RandomHairColor()
    {
        return (hairColors[Random.Range(0, hairColors.Length)]);
    }
}