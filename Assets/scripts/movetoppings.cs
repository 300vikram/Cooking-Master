using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetoppings : MonoBehaviour
{
    //Movetoppings is used for the movement and deletion of the Bottombun

    public int occupiedSlot = 99;
    public string mousecontrolled = "n";
    // Start is called before the first frame update
    void Start()
    {
        occupiedSlot = gamePlay.selectedSlot;
    }

    // Update is called once per frame
    void Update()
    {
        if (occupiedSlot == gamePlay.selectedSandwich)
        {
            mousecontrolled = "y";
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector2(objPosition.x, objPosition.y - 0.2f);
        }

        if ((gamePlay.deletefood == "y") && (mousecontrolled == "y"))
        {
            Destroy(gameObject);

            //test
            gamePlay.selectedSandwich = 0;



            //test code DELETABLE
            //gamePlay.deletefood = "n";
            //mousecontrolled = "n";
        }

        

    }

    
}
