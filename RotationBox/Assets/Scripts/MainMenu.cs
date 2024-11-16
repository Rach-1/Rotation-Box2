using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] int boxes = 0;
    [SerializeField] int needBoxesToWin = 3;
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject losePanel;

    public int thisLvl;

    private Box box;
    private int LastCompletedLvl = 1;
    void Awake()
    {
        if (!PlayerPrefs.HasKey("FirstLaunch"))
        {
            PlayerPrefs.SetInt("LastCompletedLvl", 1);
            PlayerPrefs.SetInt("FirstLaunch", 1);
        }
    }
    public void Start()
    {
        if (PlayerPrefs.HasKey("LastCompletedLvl"))
        {
            LastCompletedLvl = PlayerPrefs.GetInt("LastCompletedLvl");
        }
        LastCompletedLvl = PlayerPrefs.GetInt("LastCompletedLvl");
        PlayerPrefs.SetInt("LastCompletedLvl", LastCompletedLvl);
    }
    public void NextLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        LastCompletedLvl++;
        PlayerPrefs.SetInt("LastCompletedLvl", LastCompletedLvl);
    }
    public void ContinuePlay()
    {
        if (LastCompletedLvl == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1f;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + LastCompletedLvl);
            Time.timeScale = 1f;
        }
    }
    public void Pause()
    {
        Time.timeScale = 0f;
    }
    public void Continue()
    {
        Time.timeScale = 1f;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        if(winPanel.active == true)
        {
            if (thisLvl == LastCompletedLvl)
            {
                LastCompletedLvl++;
                PlayerPrefs.SetInt("LastCompletedLvl", LastCompletedLvl);
            }
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "RGB")
        {
            if (collision.gameObject.tag != "Gray")
            {
                boxes++;
            }
        }
        box = collision.gameObject.GetComponent<Box>();
        if (collision.gameObject.tag == "Gray")
        {
            losePanel.SetActive(true);
        }
        else if (boxes == needBoxesToWin)
        {
            winPanel.SetActive(true);
        }
        box.Exit = true;
        Destroy(collision.gameObject);
    }
    public void Lvl1()
    {
        if (LastCompletedLvl >= 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1f;
        }
    }
    public void Lvl2()
    {
        if (LastCompletedLvl >= 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            Time.timeScale = 1f;
        }
    }
    public void Lvl3()
    {
        if (LastCompletedLvl >= 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            Time.timeScale = 1f;
        }
    }
    public void Lvl4()
    {
        if (LastCompletedLvl >= 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
            Time.timeScale = 1f;
        }
    }
    public void Lvl5()
    {
        if (LastCompletedLvl >= 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
            Time.timeScale = 1f;
        }
    }
    public void Lvl6()
    {
        if (LastCompletedLvl >= 6)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
            Time.timeScale = 1f;
        }
    }
    public void Lvl7()
    {
        if (LastCompletedLvl >= 7)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
            Time.timeScale = 1f;
        }
    }
    public void Lvl8()
    {
        if (LastCompletedLvl >= 8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
            Time.timeScale = 1f;
        }
    }
    public void Lvl9()
    {
        if (LastCompletedLvl >= 9)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
            Time.timeScale = 1f;
        }
    }
    public void Lvl10()
    {
        if (LastCompletedLvl >= 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
            Time.timeScale = 1f;
        }
    }
    public void Lvl11()
    {
        if (LastCompletedLvl >= 11)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
            Time.timeScale = 1f;
        }
    }
    public void Lvl12()
    {
        if (LastCompletedLvl >= 12)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12);
            Time.timeScale = 1f;
        }
    }
    public void Lvl13()
    {
        if (LastCompletedLvl >= 13)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 13);
            Time.timeScale = 1f;
        }
    }
    public void Lvl14()
    {
        if (LastCompletedLvl >= 14)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 14);
            Time.timeScale = 1f;
        }
    }
    public void Lvl15()
    {
        if (LastCompletedLvl >= 15)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 15);
            Time.timeScale = 1f;
        }
    }
    public void Lvl16()
    {
        if (LastCompletedLvl >= 16)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 16);
            Time.timeScale = 1f;
        }
    }
}