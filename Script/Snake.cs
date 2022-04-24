using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public Player set_isplaying;

   
    void Start()
    {
        set_isplaying = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        Debug.Log(set_isplaying.isplayjing);
    }
    void Update()
    {
        //위치값이 x값이 52이상일때 
        if (transform.position.x >=50) { 
        //로그를 찍다
        Debug.Log(transform.position.x);
        //자기자신 위치값을 
        transform.position = new Vector3(-50, transform.position.y, transform.position.z);

        }
       else if(transform.position.x < -50)
        {
            Debug.Log(transform.position.x);
            transform.position = new Vector3(49, transform.position.y, transform.position.z);
        }
        //위치값이 z값이 52이상일때 
        if (transform.position.z >= 50)
        {
            //로그를 찍다
            Debug.Log(transform.position.z);
            //자기자신 위치값을 
            transform.position = new Vector3(-transform.position.x, transform.position.y, -50);

        }
        else if (transform.position.x < -50)
        {
            Debug.Log(transform.position.z);
            transform.position = new Vector3(transform.position.x, transform.position.y, 49);
        }
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {


        set_isplaying.SET_isplay(false);
        Debug.Log("test" + set_isplaying.isplayjing);
      }
    }
}
