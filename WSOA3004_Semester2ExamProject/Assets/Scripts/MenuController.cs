using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject StartPanel;

    public void ExitGame()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }

    public void Replay()
    {
        Debug.Log("Replaying");
        SceneManager.LoadScene(0);
        StartPanel.SetActive(false);
    }

    public void startGame()
    {
        Debug.Log("Playing");
        SceneManager.LoadScene(1);
       
         
    }
}
