using TMPro;
using UnityEngine;

public class CountManager : MonoBehaviour
{   
    public MancalaBoard mancalaBoard;
    public int totalCount;
    public int winPitCountA;
    public int winPitCountB;
    public int allMarbles;
    public MancalaPitCountA mancalaPitCountA;
    public MancalaPitCountB mancalaPitCountB;
    public TextMeshProUGUI countText;

    public int boardSizeChecker;

    public void Start()
    {
        boardSizeChecker = mancalaBoard.boardSize;
    }

    public void Update()
    {
        mancalaPitCountA = FindObjectOfType<MancalaPitCountA>();
        mancalaPitCountB = FindObjectOfType<MancalaPitCountB>();
        
        winPitCountA = mancalaPitCountA.pitCountA;
        winPitCountB = mancalaPitCountB.pitCountB;
        totalCount = winPitCountA + winPitCountB;
        
        boardSizeChecker = mancalaBoard.boardSize;
        //counts total marbles there are by squaring the number and multiplying it by 2
        allMarbles = ((boardSizeChecker * boardSizeChecker) * 2);
        
        //checks to see who won!
        if (totalCount >= allMarbles)
        {
            Debug.Log("WINNER!");
            if (winPitCountA > winPitCountB)
            {
                countText.text = "Player 1 Wins!";
            }

            if (winPitCountB > winPitCountA)
            {
                countText.text = "Player 2 Wins!";
            }
            if (winPitCountB == winPitCountA)
            {
                countText.text = "It's a Draw!";
            }
        }
        else
        {
            countText.text = "";
        }
    }

    public void EndState()
    {
        if (winPitCountA > winPitCountB)
        {
            countText.text = "Player 1 Wins!";
        }

        if (winPitCountB > winPitCountA)
        {
            countText.text = "Player 2 Wins!";
        }

        else
        {
            countText.text = "It's a Draw!";
        }
    }

}
