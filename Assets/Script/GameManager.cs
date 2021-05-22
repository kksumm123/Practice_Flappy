using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;
    public GameObject gameOverUI;
    public TextMeshPro ScoureUI;
    bool isGameOver = false;
    public int score = 0;
    void Awake()
    {
        instance = this;
        SetGamveOver(false);
    }

    void Update()
    {
        if (isGameOver)
        {
            if (Input.GetMouseButtonDown(0))
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void SetGamveOver(bool value)
    {
        isGameOver = value;
        gameOverUI.SetActive(value);
    }
    public void AddScore(int value)
    {
        ScoureUI.text = "Score : " + score;
    }
}
