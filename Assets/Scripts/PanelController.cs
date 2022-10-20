using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public bool isPaused;

    public GameObject pausePanel;
    public GameObject mainShopPanel;


    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !isPaused)
        {
            //pausePanel.SetActive(true);
            TogglePause();
        }
    }



    public void TogglePause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;

            //pausePanel.SetActive(false);
            mainShopPanel.SetActive(false);
        }
    }

    public void PausePanel()
    {
        isPaused = true;
        pausePanel.SetActive(true);
    }
    public void MainShop()
    {
        isPaused = true;
        Time.timeScale = 0;
        mainShopPanel.SetActive(true);
    }


}
