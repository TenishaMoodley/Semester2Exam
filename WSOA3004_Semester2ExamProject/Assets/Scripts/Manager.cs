using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{
    public int score;
    public TMP_Text Score_Txt_End;
    public TMP_Text Score_Txt_UI;

    private int Total = 8;
    private int Destroyed;

    public GameObject EndPanel;

    private void Start()
    {
        EndPanel.SetActive(false);
        Time.timeScale = 1f;
        score = 0;
        Destroyed = 0;
    }
    public void Addpoint()
    {
        score++;
    }
    public void DestroyedAdd()
    {
        Destroyed++;
    }

    private void Update()
    {
        Score_Txt_UI.text = "Score: "+score;
        Score_Txt_End.text = "Score: " + score;

        if ((score+Destroyed)==Total)
        {
            EndPanel.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
