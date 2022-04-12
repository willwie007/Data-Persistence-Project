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

    public string PlayerName;
    public int Score;
    //public GameObject playerData;


    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;    
        }
        //playerData();

    }
}
