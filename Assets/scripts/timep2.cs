using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timep2 : MonoBehaviour
{

    public float maxTime = 50f;
    public static float timeLeft;
    public  float value = 0;
    public Text timel;
    //public GameObject timesUpText;

    //    public Transform canvas;
    //    public Transform sliider;
    //public Transform b2;

    // Start is called before the first frame update
    void Start()
    {
        //    canvas = this.gameObject.transform.GetChild(0);
        //    sliider = canvas.gameObject.transform.GetChild(0);
        //timesUpText.SetActive(false);
        //    slider = sliider.GetComponent<UnityEngine.UI.Slider>();
        //slider = GetComponent<Slider>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timel.text = timeLeft.ToString("0");
            value = timeLeft / maxTime;
        }
        else
        {
            //timesUpText.SetActive(false);
            timeLeft = 0;
        }
    }
}
