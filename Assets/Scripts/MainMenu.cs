using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    Button startBtn;
    Button quitBtn;

    void Awake()
    {
        startBtn = transform.GetChild(1).GetComponent<Button>();
        quitBtn = transform.GetChild(2).GetComponent<Button>();
        startBtn.onClick.AddListener(NewGame);
        quitBtn.onClick.AddListener(QuitGame);
    }

    void QuitGame()
    {
        Application.Quit();
        Debug.Log("ÍË³öÓÎÏ·");
    }

    void NewGame()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1);
    }
}
