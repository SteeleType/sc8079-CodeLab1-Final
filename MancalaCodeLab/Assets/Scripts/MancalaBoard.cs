using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MancalaBoard : MonoBehaviour
{
    public int boardSize;
    public int startingMarbles;
    public int[,] boardPits;

    public GameObject marbles;
    public GameObject pits;
    public GameObject mancalaPitA;
    public GameObject mancalaPitB;

    public Transform marblesTransform;
    public Transform mancalaBoardTransform;

    
    //here we have the property for marbles to update the total on the game
    public int StartingMarbles
    {
        set
        {
            startingMarbles = value;
            UpdateTotal();
        }
        get
        {
            return startingMarbles;
        }
    }

    public int BoardSize
    {
        set
        {
            boardSize = value;
            UpdateTotal();
        }
        get
        {
            return boardSize;
        }
    }

    //creates newgame at start
    public void Start()
    {
        NewGame();
    }
    
    //starts a new game of mancala
    public void NewGame()
    {
        //destroys when called newgame
        foreach (Transform child in mancalaBoardTransform)
        {
            Destroy(child.gameObject);
        }

        boardPits = new int[boardSize, boardSize];

        //bulds the board pits
        for (int i = 0; i < boardSize; i++)
        {
            //pit totals are set equal to the amount of starting marbles
            int pitA = startingMarbles;
            int pitB = startingMarbles;
            boardPits[i, 0] = pitA;
            boardPits[i, 1] = pitB;

            Vector3 posA = new Vector3((i - 1) * 2, -1, 1);
            GameObject pitAA = Instantiate(pits, posA, Quaternion.identity, mancalaBoardTransform);

            Vector3 posB = new Vector3((i - 1) * 2, 1, 1);
            GameObject pitBB = Instantiate(pits, posB, Quaternion.identity, mancalaBoardTransform);
        }

        //create mancala pits
        Vector3 mancalaPosA = new Vector3((boardSize - 1) * 2, 0f, 1);
        GameObject mancalaPitsA = Instantiate(mancalaPitA, mancalaPosA, Quaternion.identity, mancalaBoardTransform);

        Vector3 mancalaPosB = new Vector3(-4f, 0f, 1);
        GameObject mancalaPitsB = Instantiate(mancalaPitB, mancalaPosB, Quaternion.identity, mancalaBoardTransform);

        UpdateTotal();
    }

    public void UpdateTotal()
    {
        //here we are clearing out the marbles that were already instatiated
        foreach (Transform child in marblesTransform)
        {
            Destroy(child.gameObject);
        }
        
        //here we are placing marbles based on the values of each indivual board pits
        for (int i = 0; i < boardPits.GetLength(0); i++)
        {
            int pitA = boardPits[i, 0];
            int pitB = boardPits[i, 1];
            
            Debug.Log(pitA + ", " + pitB);
            
            for (int a = 0; a < pitB; a++)
            {
                //here is where we manipulate the positioning of the first row of marbles
                GameObject newMarbleA = Instantiate(marbles, marblesTransform);
                Transform rtA = newMarbleA.GetComponent<Transform>();
                
                if (rtA != null)
                {
                    rtA.position = new Vector2((a - 1) * 2, 2f);
                }
            }
      
            
            for (int b = 0; b < pitA; b++)
            {
                //here is where we manipulate the positioning of the second row of marbles
                GameObject newMarbleB = Instantiate(marbles, marblesTransform);
                Transform rtB = newMarbleB.GetComponent<Transform>();
                
                if (rtB != null)
                {
                    rtB.position = new Vector2((b - 1) * 2, 0f);
                }
            }
        }
    }

    public void NextGame()
    {
        BoardSize++;
        StartingMarbles++;
        NewGame();
    }
    
    public void PreviousGame()
    {
        if (boardSize > 2)
        {
            BoardSize--;
            StartingMarbles--;
            NewGame();
        }
        else
        {
            return;
        }
    }
}
