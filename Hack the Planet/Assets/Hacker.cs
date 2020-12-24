using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    string currentScreen = "MainMenu";
    string[] lvl1Password = {"Car","Cat","Dog","Cup","Ball"};
    string[] lvl2Password = { "Monitor", "Studio", "Internet", "Festival", "Tyler1" };
    string Password;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Greetings");

    }
    void ShowMainMenu(string firstLine)
    {
        Terminal.WriteLine(firstLine);
        Terminal.WriteLine("type 1 if u avrage");
        Terminal.WriteLine("type 2 if u good");

    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            Terminal.ClearScreen();
            ShowMainMenu("welcome back");
            currentScreen = "MainMenu";
        }
        else if (currentScreen == "MainMenu")
        {
            SetLevel(input);
            ShowPassword(level);
        }
        else if (currentScreen == "Password")
        {
            CheckPassword(input);


        }

    }

    void CheckPassword(string inp)
    {
        if (inp == Password)
        {
            Terminal.WriteLine("You Won!!\nType menu to play more.");

        }
        else {
            Terminal.WriteLine("Wrong!!\nTry Again or type menu to play more.");

        }

    }
    void ShowPassword(int lvl) {
        if (lvl == 1)
        {
            Password = lvl1Password[Random.Range(0, lvl1Password.Length)];
            
                Terminal.WriteLine(Password.Anagram());
        }
        else {
            Password = lvl2Password[Random.Range(0, lvl1Password.Length)];
            Terminal.WriteLine(Password.Anagram());
        }
    }

    void SetLevel(string SelectedLevel)
    {
        if (SelectedLevel == "1")
        {
            level = 1;
            
           currentScreen = "Password";
        }
        else if (SelectedLevel == "2")
        {
            level = 2;
            
            currentScreen = "Password";
        }
        else
            Terminal.WriteLine("invalid input");

        print(level);
    }







}
