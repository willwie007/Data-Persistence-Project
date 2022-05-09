using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PlayerDataManager : MonoBehaviour
{
    // singleton to load one instance of player name
    // and pass onto main scene
    public static PlayerDataManager Instance;
    MainManager mainManager;

    public string PlayerName;
    public int Score;
    //public Text bestPlayerName;


    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
     
        }
    }

}
