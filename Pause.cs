using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public GameObject pausePanel;

    private bool isPaused = false;
    // Use this for initialization
    public void Unpause()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Cancel"))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
        else if (!isPaused)
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void start1()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
