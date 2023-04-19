using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject[] menus;
    public Color[] hairColors;
    private List<GameObject> colorButtons;

    public GameObject characterCustom;
    public GameObject spawnLocation;
    public GameObject colorButtonPrefab;

    private void Start()
    {
        colorButtons = new List<GameObject>();

        for (int i = 0; i < hairColors.Length; i++)
        {
            GameObject g = new GameObject();
            g = Instantiate(colorButtonPrefab, spawnLocation.transform);
            g.GetComponent<Image>().color = hairColors[i];
            g.GetComponent<Button>().onClick.AddListener(() => ButtonClickEvent(g));
            colorButtons.Add(g);
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
}
