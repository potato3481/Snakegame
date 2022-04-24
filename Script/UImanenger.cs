using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanenger : MonoBehaviour
{

    public GameObject startMenu;  //시작매뉴
    public GameObject ctrmenu;   //컨트롤 매뉴
    public GameObject restartmenu;


    void Start()
    {
        if (startMenu.activeSelf)
        {
            ctrmenu.SetActive(!startMenu.activeSelf);
            restartmenu.SetActive(false);
        }
    }

    public void menu()
    {
        ctrmenu.SetActive(true);
        startMenu.SetActive(false);
    }
}
