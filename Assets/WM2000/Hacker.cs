using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Gamestate
    int level;

    enum Screen
    {
        MainMenu,
        Password,
        Win
    };
    Screen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Do not react. Do not blink. Just follow the instructions.");
        Terminal.WriteLine("We can hack a footbal team, the higher the league the harder it will be.");
        Terminal.WriteLine("So pick...Quick!");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for a Division One team");
        Terminal.WriteLine("Press 2 for a Championship Team");
        Terminal.WriteLine("Enter your selection: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu") // we can always go direct to Main menu
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "1966")
        {
            Terminal.WriteLine("It's coming home baby!");
        }
        else
        {
            Terminal.WriteLine("Stop trying to be funny");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
