using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Multiply : MonoBehaviour
{
    /*
    public Button[] buttons; // Assign your 4 buttons in the Inspector
    private int number1;
    private int number2;
    private int correctAnswer;

    void Start()
    {
        GenerateRandomNumbers();
        AssignNumbersToButtons();
    }

    void GenerateRandomNumbers()
    {
        number1 = Random.Range(1, 11);
        number2 = Random.Range(1, 11);
        correctAnswer = number1 * number2;
    }

    void AssignNumbersToButtons()
    {
        List<int> numbers = new List<int> { correctAnswer };
        while (numbers.Count < 4)
        {
            int newNumber = Random.Range(1, 101);
            if (!numbers.Contains(newNumber))
            {
                numbers.Add(newNumber);
            }
        }
        Shuffle(numbers);

        for (int i = 0; i < buttons.Length; i++)
        {
            int buttonValue = numbers[i];
            buttons[i].GetComponentInChildren<Text>().text = buttonValue.ToString();
            buttons[i].onClick.AddListener(() => CheckAnswer(buttonValue));
        }

        Debug.Log($"Solve: {number1} * {number2} = ?");
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
    */
}