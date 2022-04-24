using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aet : MonoBehaviour
{
    //플레이얼 태크 지정 후 삭제
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
