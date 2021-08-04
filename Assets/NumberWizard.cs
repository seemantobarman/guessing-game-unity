using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    int max = 1000;
    int min = 1;
    int guess = 500;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome Mate!");
        Debug.Log("Pick a number.");
        Debug.Log($"Highest number: {max}");
        Debug.Log($"Lowest number: {min}");
        Debug.Log($"Tell if the number is higher or lower than {guess}");
        Debug.Log("Push Up =  Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log($"Is it higher of lower than {guess}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess;
            NextGuess();
            Debug.Log(guess);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)){
            max = guess;
            NextGuess();
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Yeeee!");
            StartGame();
        }
    }
}
