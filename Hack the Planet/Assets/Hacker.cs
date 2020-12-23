using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    string currentScreen = "MainMenu";
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("hello");

    }
    void ShowMainMenu(string firstLine)
    {
        Terminal.WriteLine(firstLine);
        Terminal.WriteLine("type 1 to hack to ");
        Terminal.WriteLine("type 2 to hack to ");

    }

    void OnUserInput(string input)
    {
        if (currentScreen == "MainMenu")
        {
            SetLevel(input);
        }
        else if (currentScreen == "Password")
        {
            //Password part
        }
        print(level);
    }
    void SetLevel(string SelectedLevel)
    {
        if (SelectedLevel == "1")
            level = 1;
        else if (SelectedLevel == "2")
            level = 2;
        else
            Terminal.WriteLine("invalid input");

    }







}
