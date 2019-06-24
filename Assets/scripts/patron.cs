using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class patron : MonoBehaviour
{
    // This is the script for the customer1  and its Health slider(The time for which customer waits)

    public string orderedMeat = "hamburger";

    public Slider slider;
    public float maxTime = 20f;
    public float timeLeft;
    //public GameObject timesUpText;

    //public Transform canvas;
    public Transform sliider;
    //public Transform b2;


    // Start is called before the first frame update
    void Start()
    {

        //canvas = this.gameObject.transform.GetChild(0);
        sliider = this.gameObject.transform.GetChild(0);
        //timesUpText.SetActive(false);
        
        //slider = GetComponent<Slider>();
        timeLeft = maxTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            //slider.value = timeLeft / maxTime;
        }
        else
        {
            //timesUpText.SetActive(false);
            
            Destroy(gameObject);
        }
    }

    private void OnMouseOver()
    {
            if ((gamePlay.deletefood == "y") && (gamePlay.currentMeat == orderedMeat))
            {

            /*
            movetoppings.mousecontrolled = "n";
            cookfood.mousecontrolled = "n";
            movesandwich.mousecontrolled = "n";
            */

                Destroy(gameObject);
                gamePlay.deletefood = "n";
                gamePlay.score1 += 10;
            }

            if ((gamePlay.deletefood == "y") && (gamePlay.currentMeat != orderedMeat))
            {
                Destroy(gameObject);
                gamePlay.deletefood = "n";
                gamePlay.score1 -= 2;
            }
        


        Debug.Log(gamePlay.deletefood);
    }
}
