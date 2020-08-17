using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{

    public static GameStateController instance;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        if(UIController.instance.player1score == 10)
        {

        }
        else if(UIController.instance.player2score == 10)
        {

        }
    }
}
