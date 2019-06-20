using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderScript : MonoBehaviour
{
    public float maxTime = 10f;
    public float timeLeft;
    //public GameObject timesUpText;

    public Transform canvas; 
    public Transform slider;
    //public Transform b2;

    // Start is called before the first frame update
    void Start()
    {
        //canvas = this.gameObject.transform.GetChild(0);
        //sliider = canvas.gameObject.transform.GetChild(0);
        //timesUpText.SetActive(false);
        //slider = GetComponent<Slider>();
        slider = transform.GetChild(0);
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            float val = timeLeft / maxTime;
            slider.transform.localScale= new Vector3(val , 1 , 0);
        }
        else
        {
            //timesUpText.SetActive(false);
            
        }
    }
}
