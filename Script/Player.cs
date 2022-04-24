using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    //敲饭捞倔 捞悼关 积己
    public Vector3 Move;
    public GameObject players;
    public GameObject playermove;
    public List<GameObject> body_list;
    public bool isbool;
    public UImanenger uimng;
    public bool isplayjing;
   

    void Start()
    {
        uimng = GameObject.FindGameObjectWithTag("uimng").GetComponent<UImanenger>();
        playermove = Instantiate(players);
        isbool = true;
        isplayjing = true;

        body_list.Add(playermove);
        StartCoroutine("movement");
    }
    public bool SET_isplay (bool isp)
    {
        uimng.restartmenu.SetActive(!isp);
        isplayjing = isp;
        return isp;
    }
    void Update()
    {
        movement2();


        if (Input.GetKey(KeyCode.Space))
        {
            Move = Vector3.zero;
        }
    }

    IEnumerator movement()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            if (isbool == true)
            {
                if(body_list.Count <= 1)
                {
                    Debug.Log("body 积己 111" + body_list.Count);
                    body_list[0].transform.position += Move;                    
                }
                else
                {
                    Debug.Log("body 积己111" + isbool);
                    body_list[body_list.Count - 1].transform.position = body_list[0].transform.position + Move;

                    body_list[1].GetComponent<MeshRenderer>().material.color = Color.grey;
                    body_list.Insert(0, body_list[body_list.Count - 1].gameObject);
                    body_list.RemoveAt(body_list.Count - 1);
                    body_list[0].GetComponent<MeshRenderer>().material.color = Color.blue;
                }   
            }
            else
            {
                playermove = Instantiate(players);
                body_list.Add(playermove);
                body_list[body_list.Count-1].transform.position = body_list[0].transform.position + Move;
                isbool = true;
                Debug.Log("body 积己000 " + isbool);
               
            }
        }
    }
    public void aet()
    {
        isbool = false;
        Debug.Log("body 积己XX");
    }

    public void bnt_up()
    {
       
        Move = Vector3.forward;
    }
    public void bnt_down()
    {   
        Move = Vector3.back;       
    }
     
    public void but_left()
    { 
        Move = Vector3.left;      
    }

    public void but_right()
    {     
        Move = Vector3.right;    
    }
    //虐蔼 
    public void movement2()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Move = Vector3.back;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Move = Vector3.forward;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Move = Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Move = Vector3.right;
        }
    }
}
