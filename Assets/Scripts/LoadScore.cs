using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class LoadScore : MonoBehaviour
{
    public Text BestPlayerName;
    public int BestScore;
    public string BestPlayer;

    MainManager mainManager;


    // Start is called before the first frame update
    void Start()
    {
        SetBestPlayer();
    }

    // Update is called once per frame
    void Awake()
    {
        LoadGameData();
    }

    private void SetBestPlayer()
    {
        if (BestPlayer == null && BestScore == 0)
        {
            BestPlayerName.text = "";
        }
        else
        {
            BestPlayerName.text = $"Best Score : {BestPlayer} : {BestScore}";
        }
    }

    private void LoadGameData()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            BestPlayer = data.TheBestPlayer;
            BestScore = data.HighestScore;
        }
    }

    [System.Serializable]
    class SaveData
    {
        public string TheBestPlayer;
        public int HighestScore;
    }
}
