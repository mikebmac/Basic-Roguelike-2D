using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsMenu;

    public void StartGame() {
        SceneManager.LoadScene(1);
    }

    public void OpenSettings() {
        settingsMenu.SetActive(true);
    }

    public void CloseSettings() {
        settingsMenu.SetActive(false);
    }

    public void ExitGame() {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
