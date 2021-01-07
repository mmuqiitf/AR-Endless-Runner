using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject panelMenu;
    public static bool isGameStarted;
    public GameObject panelStart;
    public GameObject joyStick;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            panelMenu.SetActive(true);
            isGameStarted = false;

        }
        if (SwipeManager.tap)
        {
            isGameStarted = true;
            panelStart.SetActive(false);
        }
        if (isGameStarted == true)
        {
            joyStick.SetActive(true);
        } else
        {
            joyStick.SetActive(false);
        }
    }

    public void replayButton()
    {
        SceneManager.LoadScene("SampleScene");
        panelMenu.SetActive(false);
    }
}
