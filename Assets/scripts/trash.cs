using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class trash : MonoBehaviour
{
    public GameObject gameoverpanel;
    public Text gameOverText;

    //public GameObject restartbutton;
    public Button restartbutton;
    public Text restarttext;
   

    // Start is called before the first frame update
    void Start()
    {
        restartbutton.gameObject.SetActive(false);
        gameoverpanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((timep1.timeLeft <= 0) && (timep2.timeLeft <= 0) && (gamePlay.score1 >gamePlay.score2))
        {
            gameoverpanel.SetActive(true);
            gameOverText.text = "Player 1 Wins";
            restartbutton.gameObject.SetActive(true);
        }

        if ((timep1.timeLeft <= 0) && (timep2.timeLeft <= 0) && (gamePlay.score1 < gamePlay.score2))
        {
            gameoverpanel.SetActive(true);
            gameOverText.text = "Player 2 Wins";
            restartbutton.gameObject.SetActive(true);
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

    public void restart()
    {
        gamePlay.score1 = 0;
        gamePlay.score2 = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
