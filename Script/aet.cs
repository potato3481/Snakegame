using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aet : MonoBehaviour
{
    //�÷��̾� ��ũ ���� �� ����
    public Player player;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("test");
            player.aet();
            Destroy(gameObject);
        }

    }

}
