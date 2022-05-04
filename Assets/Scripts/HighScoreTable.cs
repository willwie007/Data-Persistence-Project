using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreTable : MonoBehaviour
{
    private Transform entryTemplate;
    private Transform entryContainer;


    void Awake()
    {
        entryContainer = transform.Find("HighsscoreEntryContainer");
        entryTemplate = entryContainer.Find("HighscoreEntryTemp");

        entryTemplate.gameObject.SetActive(false);
    }
}
