using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Addition : MonoBehaviour
{

/*
{
    public Button[] buttons; // Assign your 4 buttons in the Inspector
    private int randomNumber1; // Random number within 10
    private int randomNumber2; // Random number within 10
    private int correctAnswer;

    void Start()
    {
        // Generate random numbers and correct answer
        GenerateRandomNumbers();
        
        // Assign numbers to buttons
        AssignNumbersToButtons();
    }

    void GenerateRandomNumbers()
    {
        randomNumber1 = Random.Range(1, 11);  // Random number between 1 and 10
        randomNumber2 = Random.Range(1, 11);  // Random number between 1 and 10
        correctAnswer = randomNumber1 + randomNumber2; // Calculate the correct answer
    }

    void AssignNumbersToButtons()
    {
        // Create an array to hold the numbers
        List<int> numbers = new List<int> { correctAnswer };

        // Generate random numbers for the other buttons
        while (numbers.Count < 4)
        {
            int newNumber = Random.Range(2, 21); // Random number between 2 and 20
            if (!numbers.Contains(newNumber)) // Ensure no duplicates
            {
                numbers.Add(newNumber);
            }
        }

        // Shuffle the list
        Shuffle(numbers);

        // Assign the numbers to buttons
        for (int i = 0; i < buttons.Length; i++)
        {
            int buttonValue = numbers[i];
            buttons[i].GetComponentInChildren<Text>().text = buttonValue.ToString(); // Set button text
            buttons[i].onClick.AddListener(() => CheckAnswer(buttonValue)); // Add listener
        }
    }

    void Shuffle(List<int> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            int temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }

    void CheckAnswer(int selectedValue)
    {
        if (selectedValue == correctAnswer)
        {
            Debug.Log("Correct Answer!");
        }
        else
        {
            Debug.Log("Wrong Answer. Try again!");
        }
    }
}*/

}