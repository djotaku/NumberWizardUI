using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // text mesh pro

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max; // allows you to set in the inspector
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher() // will be called by buttons
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower() // will be called by buttons
    {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}