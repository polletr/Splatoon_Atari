using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    private int pOnePoints;
    private int pTwoPoints;

    public UnityEvent OnGameStart;
    public UnityEvent<string, Color> OnGameEnd;

    [SerializeField]
    private TMP_Text pOnePointsText;

    [SerializeField]
    private TMP_Text pTwoPointsText;

    private Color playerColor;

    private bool gameStarted = false;

    bool gameEnd = false;

    [SerializeField]
    private float gameTime;

    [SerializeField]
    private TMP_Text timerText;

    [SerializeField]
    private TMP_Text pOneControlsText;

    [SerializeField]
    private TMP_Text pTwoControlsText;

    [SerializeField]
    private TMP_Text countdown;

    private float count;

    private TMP_Text defaultOneControlsText;

    private TMP_Text defaultTwoControlsText;

    private bool pOneReady;
    private bool pTwoReady;


    // Start is called before the first frame update
    void Start()
    {
        defaultOneControlsText = pOneControlsText;
        defaultTwoControlsText = pTwoControlsText;
        count = 3.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted && Input.GetButtonDown("Fire2"))
        {
            if(pOneReady)
            {
                pOneControlsText.text = defaultOneControlsText.text;
            }
            else
            {
                pOneControlsText.text = "Ready!";
            }
            pOneReady = !pOneReady;
        }

        if (!gameStarted && Input.GetButtonDown("Fire1"))
        {
            if (pTwoReady)
            {
                pTwoControlsText.text = defaultTwoControlsText.text;
            }
            else
            {
                pTwoControlsText.text = "Ready!";
            }
            pTwoReady = !pTwoReady;
        }

        if (!gameStarted && pOneReady && pTwoReady)
        {
            pOneControlsText.gameObject.SetActive(false);
            pTwoControlsText.gameObject.SetActive(false);
            countdown.gameObject.SetActive(true);
            count -= Time.deltaTime;
            countdown.text = Mathf.RoundToInt(count).ToString();
            if(count<=0.5f)
            {
                OnGameStart.Invoke();
                gameStarted = true;
                countdown.gameObject.SetActive(false);
            }
        }

        if (gameStarted)
        {
            if(gameTime >0)
            {
                gameTime -= Time.deltaTime;
            }
            else
            {
                gameTime = 0f;
                if(pOnePoints > pTwoPoints)
                {
                    OnGameEnd.Invoke("The winner is Player One!", playerColor);
                }
                else if (pOnePoints < pTwoPoints)
                {
                    OnGameEnd.Invoke("The winner is Player Two!", playerColor);
                }
                else
                {
                    OnGameEnd.Invoke("Tie!", Color.white);
                }
                gameEnd = true;
            }
            updateTimer(gameTime);
        }

        if (gameEnd && (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2")))
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

    }

    public void AddPoints(Color tileColor, string player, Color pColor)
    {
        if (tileColor == Color.white)
        {
            if (player == "PlayerOne")
            {
                pOnePoints++;
            }
            else if (player == "PlayerTwo")
            {
                pTwoPoints++;
            }
        }
        else
        {
            if (player == "PlayerOne")
            {
                pOnePoints++;
                pTwoPoints--;
            }
            else if (player == "PlayerTwo")
            {
                pTwoPoints++;
                pOnePoints--;
            }
        }

        playerColor = pColor;
        pOnePointsText.text = pOnePoints.ToString();
        pTwoPointsText.text = pTwoPoints.ToString();

    }

    private void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);

    }

}
