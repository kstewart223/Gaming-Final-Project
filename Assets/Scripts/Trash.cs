using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public ScoreCounter score;

    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        score = scoreGO.GetComponent<ScoreCounter>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject);
            score.score += 1;
            HighScore.TRY_SET_HIGH_SCORE(score.score);
            Debug.Log("Obstacle cleaned up!");
        }
    }


}
