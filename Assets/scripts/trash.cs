using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trash : MonoBehaviour
{
    public GameObject gameoverpanel;
    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {

        gameoverpanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if ((timep1.timeLeft <= 0) && (timep2.timeLeft <= 0) && (gamePlay.score1 >gamePlay.score2))
        {
            gameoverpanel.SetActive(true);
            gameOverText.text = "Player 1 Wins";
        }

        if ((timep1.timeLeft <= 0) && (timep2.timeLeft <= 0) && (gamePlay.score1 < gamePlay.score2))
        {
            gameoverpanel.SetActive(true);
            gameOverText.text = "Player 2 Wins";
        }

    }

    private void OnMouseOver()
    {
        if ((gamePlay.deletefood == "y"))
        {
            //Destroy(gameObject);
            gamePlay.deletefood = "n";
        }

        Debug.Log(gamePlay.deletefood);
    }
}
