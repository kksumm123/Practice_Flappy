using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    public GameObject gameOverUI;
    public TextMeshProUGUI ScoureUI;
    bool isGameOver = false;
    public int score = 0;

    float scrollSpeedMult = 1;
    public float ScrollSpeedMult
    {
        get { return scrollSpeedMult; }
        set { scrollSpeedMult = value; }
    }

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
        score += value;
        ScoureUI.text = "Score : " + score;
    }
}
