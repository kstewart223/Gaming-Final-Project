using UnityEngine;
using UnityEngine.UI; 

public class StartGame : MonoBehaviour
{
    public static bool isGameStarted = false;
    public GameObject startText; 

    void Awake()
    {
        Time.timeScale = 0;
        isGameStarted = false;
        if (startText != null) startText.SetActive(true);
    }

    void Update()
    {
        // 2. Check for the Space bar input
        if (!isGameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            Blah();
        }
    }

    void Blah()
    {
        Time.timeScale = 1;
        isGameStarted = true;
        

        // Hide the "Press Space" message
        if (startText != null) startText.SetActive(false);
    }
}