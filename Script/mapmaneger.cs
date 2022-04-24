using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapmaneger : MonoBehaviour
{
    //∏   ƒ√∑Øπÿ ªÁ¿Ã¡Ó
    public GameObject map;


    void Start()
    {
        mapcreate();

        Debug.Log(6 % 2);
    }
    void mapcreate()
    {
        GameObject parent = new GameObject("parent");
        for (int x = 0; x < 100; x++)
        {
            for (int z = 0; z < 100; z++)
            {

                GameObject a = Instantiate(map);

                a.name = "x :" + x + "z :" + z;
                a.transform.position = new Vector3(x, -5, z);

                int i = z;
                if (z % 2 == 0 && (x % 2 == 0))
                    a.GetComponent<MeshRenderer>().material.color = new Color32(0, 0, 0, 255);
                else if (x % 2 == 1 && (x % 2 == 0))
                {
                    a.GetComponent<MeshRenderer>().material.color = new Color32(0, 0, 0, 255);     
                }

                a.transform.SetParent(parent.transform);
            }
        }
        parent.transform.position = new Vector3(-50, 0,-50);
    }
}