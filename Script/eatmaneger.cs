using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatmaneger : MonoBehaviour
{
    //eat 생성 매니절
   // public Player player;
    public GameObject aet;

    void Start()
    {
        StartCoroutine(create());

    //    player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
   
    public IEnumerator create()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            GameObject a = Instantiate(aet);

            int x = Random.Range(-50, 51);
            int z = Random.Range(-50, 51);
            a.transform.position = new Vector3(x, 0, z);
        }
    }
  //  private void OnTriggerEnter(Collider other)
  //  {
  //      if (other.gameObject.tag == "Player")
  //      {
   //         Debug.Log("test");
   //         player.aet();
   //         Destroy(gameObject);
 //       }
 //    }
    }
