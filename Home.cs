using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LoadLevel();
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void ToLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
     public void levelsPage()
    {
        SceneManager.LoadScene(4);
    }

    public void startmenu()
    {
        SceneManager.LoadScene(0);
    }
     public void loadLevel3()
    {
        SceneManager.LoadScene(3);
    }
}
