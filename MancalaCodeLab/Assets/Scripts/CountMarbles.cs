using System;
using TMPro;
using UnityEngine;

public class CountMarbles : MonoBehaviour
{

    public int countMarbles;
    public TextMeshPro numberText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        countMarbles++;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        countMarbles--;
    }

    // Update is called once per frame
    void Update()
    {
        numberText.text = countMarbles.ToString();
    }
}
