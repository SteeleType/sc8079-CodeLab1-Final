using TMPro;
using UnityEngine;

public class MancalaPitCountB : MonoBehaviour
{
    public int pitCountB;
    public TextMeshPro numberText;

    public void OnTriggerEnter2D(Collider2D other)
    {
        pitCountB++;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        pitCountB--;
    }

    // Update is called once per frame
    void Update()
    {
        numberText.text = pitCountB.ToString();
    }
}