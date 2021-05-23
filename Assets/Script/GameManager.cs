using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    public GameObject gameOverGO;
    public TextMeshProUGUI scoureUI;
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
        gameOverGO = GameObject.Find("GameOver");
        scoureUI = GameObject.Find("ScoreUI").GetComponent<TextMeshProUGUI>();
    }
    private void Start()
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
        gameOverGO.SetActive(value);
    }
    public void AddScore(int value)
    {
        score += value;
        scoureUI.text = "Score : " + score;
    }
}
