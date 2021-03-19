using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public GameObject Con;
    public GameObject Main;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void Controles()
    {
        if (Main)
        {
            Main.SetActive(!Main.activeSelf);
            Con.SetActive(!Con.activeSelf);
        }
        
    }
    public void Back()
    {
        if (Con)
        {
            Main.SetActive(!Main.activeSelf);
            Con.SetActive(!Con.activeSelf);
        }
    }
}
