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
        //��ġ���� x���� 52�̻��϶� 
        if (transform.position.x >=50) { 
        //�α׸� ���
        Debug.Log(transform.position.x);
        //�ڱ��ڽ� ��ġ���� 
        transform.position = new Vector3(-50, transform.position.y, transform.position.z);

        }
       else if(transform.position.x < -50)
        {
            Debug.Log(transform.position.x);
            transform.position = new Vector3(49, transform.position.y, transform.position.z);
        }
        //��ġ���� z���� 52�̻��϶� 
        if (transform.position.z >= 50)
        {
            //�α׸� ���
            Debug.Log(transform.position.z);
            //�ڱ��ڽ� ��ġ���� 
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
