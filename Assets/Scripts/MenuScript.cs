using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject[] Menus;
    //public GameObject OpenMenu;

    public void SwitchMenus(GameObject OpenMenu)
    {
        for (int i = 0; i < Menus.Length; i++)
        {
            if (OpenMenu == Menus[i] && OpenMenu.activeInHierarchy)
            {
                Menus[i].SetActive(false);
                return;
            }
            Menus[i].SetActive(false);
        }
        OpenMenu.SetActive(true);
    }
}
