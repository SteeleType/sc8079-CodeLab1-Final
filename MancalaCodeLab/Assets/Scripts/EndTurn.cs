using TMPro;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    public TextMeshProUGUI text;
    public bool isPlayer1Turn;
    
    
    public void EndTurns()
    {
        if (isPlayer1Turn)
        {
            text.text = "Player 2 Turn";
            isPlayer1Turn = false;
        }
        else
        {
            text.text = "Player 1 Turn";
            isPlayer1Turn = true;
        }
    }
}
