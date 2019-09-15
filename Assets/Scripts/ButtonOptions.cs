using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(3);
    }

    public void TrackSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void CharacterSelect()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    //Below are Track Select Buttons
    public void Track01()
    {
        SceneManager.LoadScene(3);
    }

    public void Track02()
    {
        SceneManager.LoadScene(4);
    }

}
