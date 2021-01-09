using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKillBox : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "FPSController")
        {
            Debug.Log("playerHasCollidedWithGhost");
            //SceneManager.LoadScene("Dead");
        }
    }


}
