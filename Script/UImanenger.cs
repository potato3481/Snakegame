using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanenger : MonoBehaviour
{

    public GameObject startMenu;  //���۸Ŵ�
    public GameObject ctrmenu;   //��Ʈ�� �Ŵ�
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
