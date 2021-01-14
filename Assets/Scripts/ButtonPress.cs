using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public AudioSource buttonAudio;

    private void Awake()
    {
        
    }

    public void OnButtonClick()
    {
        buttonAudio.Play();
    }

    public void SceneOne()
    {
        SceneManager.LoadScene("1BlockCreation");
    }

    public void SceneTwo()
    {
        SceneManager.LoadScene("2WallsAndCorridors");
    }

    public void SceneThree()
    {
        SceneManager.LoadScene("3TheDrunkenCrawl");
    }

    public void SceneFour()
    {
        SceneManager.LoadScene("4CustomiseTheCrawl");
    }

    public void SceneFive()
    {
        SceneManager.LoadScene("5MazeWalkAround");
    }

    public void SceneSix()
    {
        SceneManager.LoadScene("6PrimsAlgorithm");
    }

    public void SceneSeven()
    {
        SceneManager.LoadScene("7WilsonsMazeGenerator");
    }

    public void ReturnToMain()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void MuteAudio()
    {
        if (!Music.instance.isMute)
        {
            AudioListener.volume = 0;
            Music.instance.isMute = true;
        } else
        {
            AudioListener.volume = 1;
            Music.instance.isMute = false;
        }

    }
    public void ExitApplication()
    {
        Application.Quit();
        Debug.Log("Application has closed");
    }
}
