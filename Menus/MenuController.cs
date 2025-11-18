using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string _newgame;

    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(_newgame);
    }

    /*
    public void LoadGameDialogYes() 
    {
        SceneManager.LoadScene(levelToLoad);
    }*/

    public void ExitBtn()
    {
        Application.Quit();
    }
}
