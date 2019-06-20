using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookfood : MonoBehaviour
{
    // This script control the inner pattie of the burger and the hotdog
    //This script is used to cook the food and also to place the objects instantiated in
    //bincontrol into places

    public float cookingTime = 0;
    public int occupiedSlot = 100;
    public string mousecontrolled = "n";
    public string toppingStatus;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cookingTime += Time.deltaTime;
        if ((cookingTime > 5 && cookingTime < 10) && (transform.position.y < -3) )
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 0);
        }

        if ((cookingTime > 10) && (transform.position.y < -3))  
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        }

        if (occupiedSlot == gamePlay.selectedSandwich)
        {
            mousecontrolled = "y";
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector2(objPosition.x,objPosition.y - 0.1f);
            if (gameObject.name == "burger patty(Clone)")
            {
                gamePlay.currentMeat = "hamburger";
            }

            if (gameObject.name == "hotdog(Clone)")
            {
                gamePlay.currentMeat = "hotdog";
            }

        }

        if ((gamePlay.deletefood == "y") && (mousecontrolled == "y"))
        {
            Destroy(gameObject);


            //test
            gamePlay.selectedSandwich = 0;
            
            
        }
    }

    void OnMouseOver()
    {
        float posX = transform.position.x;
        if (Input.GetMouseButtonDown(0) && posX < 0)
        {
            if ((gamePlay.cuttingbords1 == "justbun") && (toppingStatus != "placed"))
            {
                GetComponent<Transform>().position = new Vector2(-4.2f, -1f);
                gamePlay.cuttingbords1 = "fullbun";
                if (gamePlay.grills1 == "empty")
                {
                    gamePlay.grills2 = "empty";
                }
                else
                {
                    gamePlay.grills1 = "empty";
                }
                occupiedSlot = 1;
                toppingStatus = "placed";

                //test
                gamePlay.selectedSlot = 1;
            }

            else if ((gamePlay.cuttingbords2 == "justbun") && (toppingStatus != "placed"))
            {
                GetComponent<Transform>().position = new Vector2(-2.6f, -1f);
                gamePlay.cuttingbords2 = "fullbun";
                if (gamePlay.grills2 == "empty")
                {
                    gamePlay.grills1 = "empty";
                }
                else
                {
                    gamePlay.grills2 = "empty";
                }
                occupiedSlot = 2;
                toppingStatus = "placed";

                //test
                gamePlay.selectedSlot = 2;
            }

            else if ((gamePlay.cuttingbords1 == "justroll") && (toppingStatus != "placed"))
            {
                GetComponent<Transform>().position = new Vector2(-4.2f, -1f);
                gamePlay.cuttingbords1 = "fullroll";
                if (gamePlay.grills2 == "empty")
                {
                    gamePlay.grills1 = "empty";
                }
                else
                {
                    gamePlay.grills2 = "empty";
                }
                occupiedSlot = 1;
                toppingStatus = "placed";

                //test
                gamePlay.selectedSlot = 1;
            }

            else if ((gamePlay.cuttingbords2 == "justroll") && (toppingStatus != "placed"))
            {
                GetComponent<Transform>().position = new Vector2(-2.6f, -1f);
                gamePlay.cuttingbords2 = "fullroll";
                if (gamePlay.grills2 == "empty")
                {
                    gamePlay.grills1 = "empty";
                }
                else
                {
                    gamePlay.grills2 = "empty";
                }
                occupiedSlot = 2;
                toppingStatus = "placed";

                //test
                gamePlay.selectedSlot = 2;
            }
        }


        if (Input.GetMouseButtonDown(1) && posX > 0)
        {
            if ((gamePlay.cuttingbords3 == "justbun") && (toppingStatus != "placed"))
            {
                GetComponent<Transform>().position = new Vector2(2.6f, -1f);
                gamePlay.cuttingbords3 = "fullbun";
                if (gamePlay.grills3 == "empty")
                {
                    gamePlay.grills4 = "empty";
                }
                else
                {
                    gamePlay.grills3 = "empty";
                }
                occupiedSlot = 3;
                toppingStatus = "placed";

                //test
                gamePlay.selectedSlot = 3;
            }

            else if ((gamePlay.cuttingbords4 == "justbun") && (toppingStatus != "placed"))
            {
                GetComponent<Transform>().position = new Vector2(4.6f, -1f);
                gamePlay.cuttingbords4 = "fullbun";
                if (gamePlay.grills4 == "empty")
                {
                    gamePlay.grills3 = "empty";
                }
                else
                {
                    gamePlay.grills4 = "empty";
                }
                occupiedSlot = 4;
                toppingStatus = "placed";

                //test
                gamePlay.selectedSlot = 4;
            }

            else if ((gamePlay.cuttingbords3 == "justroll") && (toppingStatus != "placed"))
            {
                GetComponent<Transform>().position = new Vector2(2.6f, -1f);
                gamePlay.cuttingbords3 = "fullroll";
                if (gamePlay.grills4 == "empty")
                {
                    gamePlay.grills3 = "empty";
                }
                else
                {
                    gamePlay.grills4 = "empty";
                }
                occupiedSlot = 3;
                toppingStatus = "placed";

                //test
                gamePlay.selectedSlot = 3;
            }

            else if ((gamePlay.cuttingbords4 == "justroll") && (toppingStatus != "placed"))
            {
                GetComponent<Transform>().position = new Vector2(4.6f, -1f);
                gamePlay.cuttingbords4 = "fullroll";
                if (gamePlay.grills4 == "empty")
                {
                    gamePlay.grills3 = "empty";
                }
                else
                {
                    gamePlay.grills4 = "empty";
                }
                occupiedSlot = 4;
                toppingStatus = "placed";

                //test
                gamePlay.selectedSlot = 4;
            }
        }

    }


}
