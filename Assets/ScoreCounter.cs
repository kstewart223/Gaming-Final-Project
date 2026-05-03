using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance;
    public int score = 0;
    private Text uiText;

    void Awake() 
    {
        // Link this specific object to the bridge
        if (Instance == null) Instance = this;
    }
    
    void Start()
    {
        uiText = GetComponent<Text>();
    }

    void Update()
    {
        uiText.text = score.ToString("#,0");
    }
}
