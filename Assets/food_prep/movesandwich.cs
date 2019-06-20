using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movesandwich : MonoBehaviour
{
    // This Script controls the Top bun of the burger and the hotdog object
    // This is the main script for the movement of the sandwich as cookfood and movetoppings use the 
    // variable values set by this script to move their gameobject
    
    public int occupiedSlot = 0;

    private string mousecontrolled = "n";

    // Start is called before the first frame update
    void Start()
    {
        occupiedSlot = gamePlay.selectedSlot;
        Debug.Log(occupiedSlot);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mousecontrolled == "y")
        {
            Vector2 pos = gameObject.transform.position;
           // Debug.Log(gameObject.name);
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            pos -= objPosition;
           // if( pos.magnitude < 0.36)
                transform.position = objPosition;

        }

       

        if ((gamePlay.deletefood == "y") && (mousecontrolled == "y"))
        {
            /*
            // test part
            if (gamePlay.selectedSlot == 1)
            {
                gamePlay.cuttingbords1 = "empty";

            }
            if (gamePlay.selectedSlot == 2)
            {
                gamePlay.cuttingbords2 = "empty";

            }
            Debug.Log("In test");
            */

           

            gamePlay.selectedSandwich = 0;
            Destroy(gameObject);
            mousecontrolled = "n";

            
            
            

            //test part2
            //gamePlay.deletefood = "n"


        }
    }

    void OnMouseOver()
    {

        float posX = transform.position.x;
        
        if (((Input.GetMouseButtonDown(0)) && posX < 0))
        {
            mousecontrolled = "y";
            gamePlay.selectedSandwich = occupiedSlot;
            Debug.Log("Selected sandwich");
            Debug.Log(gamePlay.selectedSandwich);


            //Test
            if (gamePlay.selectedSandwich == 1)
            {
                gamePlay.cuttingbords1 = "empty";
                Debug.Log("inside cutting bord 1 TEST");
                Debug.Log(gamePlay.cuttingbords1);
            }
            if (gamePlay.selectedSandwich == 2)
            {
                gamePlay.cuttingbords2 = "empty";
                Debug.Log("inside cutting bord 2 TEST");
                Debug.Log(gamePlay.cuttingbords2);
            }
        }

        if (((Input.GetMouseButtonDown(1)) && posX > 0))
        {
            mousecontrolled = "y";
            gamePlay.selectedSandwich = occupiedSlot;
            Debug.Log("Selected sandwich");
            Debug.Log(gamePlay.selectedSandwich);


            //Test
            if (gamePlay.selectedSandwich == 3)
            {
                gamePlay.cuttingbords3 = "empty";
                Debug.Log("inside cutting bord 1 TEST");
                Debug.Log(gamePlay.cuttingbords1);
            }
            if (gamePlay.selectedSandwich == 4)
            {
                gamePlay.cuttingbords4 = "empty";
                Debug.Log("inside cutting bord 2 TEST");
                Debug.Log(gamePlay.cuttingbords2);
            }
        }
    }


}
