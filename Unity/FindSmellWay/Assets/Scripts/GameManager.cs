using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text timeText;
    public Text endText;
    public GameObject endUI;
    public Select select;
    private float time;
    public bool isEndedGame;


    void Start()
    {
        time = 180f;
        isEndedGame = false;
        endUI.SetActive(false);

        if(SceneManager.GetActiveScene().name == "Stage1" || SceneManager.GetActiveScene().name == "Stage2")
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    void Update()
    {
        if (!isEndedGame)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                timeText.text = string.Format($"{(int)(time / 60)} :{(int)((int)(time % 60))}");
            }
            if(time <= 0 || select.count >= 3 || select.isSuccess == true)
            {
                isEndedGame = true;
            }
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            if (select.isSuccess)
            {
                if(SceneManager.GetActiveScene().name == "Stage1")
                {
                    endText.text = "NEXT STAGE";
                    Invoke("LoadNextStage", 2f);
                }
                else if(SceneManager.GetActiveScene().name == "Stage2")
                {
                    endText.text = "WIN";
                }
                
            }
            else
            {
                endText.text = "GAME OVER";
            }

            endUI.SetActive(true);
        }
    }

    public void StartGame(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadNextStage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
