using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gamePlay : MonoBehaviour
{
    public Text scorep1;
    public Text scorep2;

    public static string cuttingbords1 = "empty";               // Dividing the board into 4 parts -> 2 for player 1 and 2 for player 2
    public static string cuttingbords2 = "empty";
    public static string cuttingbords3 = "empty";
    public static string cuttingbords4 = "empty";

    public static string grills1 = "empty";                     // Dividing the board into 4 parts -> 2 for player 1 and 2 for player 2
    public static string grills2 = "empty";
    public static string grills3 = "empty";
    public static string grills4 = "empty";

    public static int selectedSlot = 0;                         // just explains what cuttingboed slot the bun is in
    public static int selectedSandwich = 0;

    public static int selectedplayer = 0;                       // which player is selected currently

    public static string deletefood = "n";
    public static string currentMeat;

    public static int score1 = 0;                               // Score of player 1
    public static int score2 = 0;                               // Score of player 2

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))                    // Only way to Destroy the object in the game "Space Key"
        {
            deletefood = "y";
            Debug.Log("SPACE button");
        }

        scorep1.text = score1.ToString("0");                    // updating the scores
        scorep2.text = score2.ToString("0");
        Debug.Log(scorep2.text);
    }

    
}
