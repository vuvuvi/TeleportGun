using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;


public class TeleportBullet : MonoBehaviour
{

    public GameObject player;
    
   void OnCollisionEnter(Collision collision)
    {
     

        if (!collision.collider.CompareTag("Bounce"))
        {
        Destroy(gameObject);

        }
        //SceneManager.LoadScene("WinScene");
        

        if (collision.collider.CompareTag("Teleportation"))
        {
        player.transform.position = collision.GetContact(0).point;

        }

        
        
    }

}
