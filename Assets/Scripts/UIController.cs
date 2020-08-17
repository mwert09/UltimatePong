using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public int player1score = 0;
    public int player2score = 0;
    public TextMeshProUGUI player1scoretext;
    public TextMeshProUGUI player2scoretext;

    public GameObject EndGamePanel;
    public TextMeshProUGUI playerwintext;

    public static UIController instance;

    private void Awake()
    {
        instance = this;
        EndGamePanel.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(player1score == 10 || player2score == 10)
        {
            // GameStateController.instance.EndGame();
            if(player1score == 10)
            {
                playerwintext.text = "Player 1 Won!";
            }
            else if(player2score == 10)
            {
                playerwintext.text = "Player 2 Won!";
            }
            EndGamePanel.SetActive(true);
        }
    }

    public void IncreasePlayer1Score()
    {
        player1score++;
        player1scoretext.text = "Score: " + player1score;
    }

    public void IncreasePlayer2Score()
    {
        player2score++;
        player2scoretext.text = "Score: " + player2score;
    }

    public void Restart()
    {
        player1score = 0;
        player2score = 0;
        player1scoretext.text = "Score: " + player1score;
        player2scoretext.text = "Score: " + player2score;
        BallMovement.instance.ResetBall();
        EndGamePanel.SetActive(false);
    }

    public void LoadMainMenu()
    {
        LevelLoader.instance.LoadScene(0);
    }

}
