using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;
    public GameObject gameOverUI;
    bool isGameOver = false;

    void Awake()
    {
        instance = this;
        SetGamveOver(false);
    }
    public void SetGamveOver(bool value)
    {
        isGameOver = value;
        gameOverUI.SetActive(value);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            if (Input.GetMouseButtonDown(0))
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
