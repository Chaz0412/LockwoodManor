using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    //loads main scene
    public void PlayGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    //closes the game
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
