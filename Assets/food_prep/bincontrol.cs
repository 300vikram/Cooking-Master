using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bincontrol : MonoBehaviour
{
    // This script instantiate the different kind of food supplies on the 
    // cuttingboard and grill
    // There are 2 Food items Burger and Hotdod
    // Burger = bottombunObj + topbunObj + burgerObj
    // Hotdog = backrollObj + frontrollObj + hotdogObj

    public Transform bottombunObj;
    public Transform topbunObj;
    public Transform burgerObj;
    public Transform backrollObj;
    public Transform frontrollObj;
    public Transform hotdogObj;

    // Start is called before the first frame 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (gameObject.name == "bun bin")
            {
 
                if (gamePlay.cuttingbords1 == "empty")
                {
                    
                    Instantiate(bottombunObj, new Vector2(-4.2f, -1f), bottombunObj.rotation);
                    Transform g1 = Instantiate(topbunObj, new Vector3(-4.2f, -0.5f , -1f), topbunObj.rotation);
                    g1.gameObject.name = "b1";
                    gamePlay.cuttingbords1 = "justbun";
                    gamePlay.selectedSlot = 1;
                }


                else if (gamePlay.cuttingbords2 == "empty")
                {
                    Instantiate(bottombunObj, new Vector2(-2.6f, -1f), bottombunObj.rotation);
                    Transform g1 = Instantiate(topbunObj, new Vector3(-2.6f, -0.5f , 1f), topbunObj.rotation);
                    g1.gameObject.name = "b2";
                    gamePlay.cuttingbords2 = "justbun";
                    gamePlay.selectedSlot = 2;
                }
            }



            if (gameObject.name == "roll bin")
            {

                if (gamePlay.cuttingbords1 == "empty")
                {

                    Instantiate(backrollObj, new Vector2(-4.2f, -1f), backrollObj.rotation);
                    Transform g1 = Instantiate(frontrollObj, new Vector2(-4.2f, -0.5f), frontrollObj.rotation);
                    g1.gameObject.name = "b1";
                    gamePlay.cuttingbords1 = "justroll";
                    gamePlay.selectedSlot = 1;
                }


                else if (gamePlay.cuttingbords2 == "empty")
                {
                    Instantiate(backrollObj, new Vector2(-2.6f, -1f), backrollObj.rotation);
                    Transform g1 = Instantiate(frontrollObj, new Vector2(-2.6f, -0.5f), frontrollObj.rotation);
                    g1.gameObject.name = "b2";
                    gamePlay.cuttingbords2 = "justroll";
                    gamePlay.selectedSlot = 2;
                }
            }



            if (gameObject.name == "hamburgers")
            {
                if (gamePlay.grills1 == "empty")
                {
                        Instantiate(burgerObj, new Vector2(-4.2f, -4f), burgerObj.rotation);
                        gamePlay.grills1 = "full";
                }

                else if(gamePlay.grills2 == "empty")
                {
                    Instantiate(burgerObj, new Vector2(-2.6f, -4f), burgerObj.rotation);
                    gamePlay.grills2 = "full";
                }
            }

            if (gameObject.name == "hotdog bin")
            {
                if (gamePlay.grills1 == "empty")
                {
                    Instantiate(hotdogObj, new Vector2(-4.2f, -4f), hotdogObj.rotation);
                    gamePlay.grills1 = "full";
                }

                else if (gamePlay.grills2 == "empty")
                {
                    Instantiate(hotdogObj, new Vector2(-2.6f, -4f), hotdogObj.rotation);
                    gamePlay.grills2 = "full";
                }
            }
            Debug.Log("Pressed primary button.");
            gamePlay.selectedplayer = 1;
        }


        if (Input.GetMouseButtonDown(1))
        {
            if (gameObject.name == "bun bin")
            {

                if (gamePlay.cuttingbords3 == "empty")
                {

                    Instantiate(bottombunObj, new Vector2(2.6f, -1f), bottombunObj.rotation);
                    Transform g1 = Instantiate(topbunObj, new Vector2(2.6f, -0.5f), topbunObj.rotation);
                    g1.gameObject.name = "b3";
                    gamePlay.cuttingbords3 = "justbun";
                    gamePlay.selectedSlot = 3;
                }


                else if (gamePlay.cuttingbords4 == "empty")
                {
                    Instantiate(bottombunObj, new Vector2(4.6f, -1f), bottombunObj.rotation);
                    Transform g1 = Instantiate(topbunObj, new Vector2(4.6f, -0.5f), topbunObj.rotation);
                    g1.gameObject.name = "b2";
                    gamePlay.cuttingbords4 = "justbun";
                    gamePlay.selectedSlot = 4;
                }
            }



            if (gameObject.name == "roll bin")
            {

                if (gamePlay.cuttingbords3 == "empty")
                {

                    Instantiate(backrollObj, new Vector2(2.6f, -1f), backrollObj.rotation);
                    Transform g1 = Instantiate(frontrollObj, new Vector2(2.6f, -0.5f), frontrollObj.rotation);
                    g1.gameObject.name = "b3";
                    gamePlay.cuttingbords3 = "justroll";
                    gamePlay.selectedSlot = 3;
                }


                else if (gamePlay.cuttingbords4 == "empty")
                {
                    Instantiate(backrollObj, new Vector2(4.6f, -1f), backrollObj.rotation);
                    Transform g1 = Instantiate(frontrollObj, new Vector2(4.6f, -0.5f), frontrollObj.rotation);
                    g1.gameObject.name = "b4";
                    gamePlay.cuttingbords4 = "justroll";
                    gamePlay.selectedSlot = 4;
                }
            }



            if (gameObject.name == "hamburgers")
            {
                if (gamePlay.grills3 == "empty")
                {
                    Instantiate(burgerObj, new Vector2(2.6f, -4f), burgerObj.rotation);
                    gamePlay.grills3 = "full";
                }

                else if (gamePlay.grills4 == "empty")
                {
                    Instantiate(burgerObj, new Vector2(4.6f, -4f), burgerObj.rotation);
                    gamePlay.grills4 = "full";
                }
            }

            if (gameObject.name == "hotdog bin")
            {
                if (gamePlay.grills3 == "empty")
                {
                    Instantiate(hotdogObj, new Vector2(2.6f, -4f), hotdogObj.rotation);
                    gamePlay.grills3 = "full";
                }

                else if (gamePlay.grills4 == "empty")
                {
                    Instantiate(hotdogObj, new Vector2(4.6f, -4f), hotdogObj.rotation);
                    gamePlay.grills4 = "full";
                }
            }
            Debug.Log("Pressed primary button.");
            gamePlay.selectedplayer = 2;
        }
    }
}
