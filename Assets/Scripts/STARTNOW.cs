using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class STARTNOW : MonoBehaviour
{
    Button startBtn;

    void Awake()
    {
        startBtn = transform.GetChild(0).GetComponent<Button>();
        startBtn.onClick.AddListener(NewGame);
    }

    void NewGame()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1);
    }
}
