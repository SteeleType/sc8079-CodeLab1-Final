using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public MancalaBoard mancalaBoard;
    public GameObject marbles;
    
    void OnMouseDown()
    {
        for (int i = 0; i < mancalaBoard.boardPits.Length; i++)
        {
            int pitA = mancalaBoard.boardPits[i, 0];
            int pitB = mancalaBoard.boardPits[i, 1];

            for (int j = 0; j < mancalaBoard.boardPits[i, 0]; j++)
            {
                GameObject newMarbleA = Instantiate(marbles); 
            }
        }
        
    }
}
