using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Derrota : MonoBehaviour
{
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            TooglePause();
        
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void TooglePause()
    {
        if (pauseMenu)
        {

            pauseMenu.SetActive(!pauseMenu.activeSelf);

            Time.timeScale = pauseMenu.activeSelf ? 0.0f : 1.0f;
        }
    }
}
