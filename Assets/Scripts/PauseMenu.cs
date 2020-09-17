using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu instance;

    public string levelSelect, mainMenu;

    public GameObject pauseScreen;
    public bool isPaused;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUnpause();
        }
    }

    public void PauseUnpause()
    {
        if (isPaused)
        {
            isPaused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1f; // resume time.
        }
        else
        {
            isPaused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0f; // time thats passing in the game, set to zero which means no time goes by. Pause.
        }
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
        Time.timeScale = 1f; // resume time.

    }
    public void MenuMenu()
    {
        SceneManager.LoadScene(mainMenu);
        Time.timeScale = 1f; // resume time.
    }
}
