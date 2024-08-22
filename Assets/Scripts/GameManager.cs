using System.Transactions;
using UnityEngine;
using Zenject;

// TODO rename 
public class GameManager : IInitializable
{
    // start game 
    
    // show window 

    private readonly IWindowController _windowController;

    public GameManager(IWindowController windowController)
    {
        _windowController = windowController;
        
        
    }

    public void Initialize()
    {
        // TODO subscribe if needed
        
        StartGame();
    }

    private void StartGame()
    {
        _windowController.OpenWindow(EWindowType.Main);
    }
}
