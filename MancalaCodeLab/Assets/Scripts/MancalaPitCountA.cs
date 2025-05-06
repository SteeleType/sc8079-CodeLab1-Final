using TMPro;
using UnityEngine;

public class MancalaPitCountA : MonoBehaviour
{
    public int pitCountA;
    public TextMeshPro numberText;

    public void OnTriggerEnter2D(Collider2D other)
    {
        pitCountA++;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        pitCountA--;
    }

    // Update is called once per frame
    void Update()
    {
        numberText.text = pitCountA.ToString();
    }
}
