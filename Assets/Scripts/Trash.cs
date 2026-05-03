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

        if (other.CompareTag("Obstacle") || other.CompareTag("Clouds"))
        {
            Destroy(other.gameObject);
            if(other.CompareTag("Obstacle")) {
            score.score += 1;
            HighScore.TRY_SET_HIGH_SCORE(score.score);
            // Debug.Log("cleaned");
            }
            // Debug.Log("clouds");
        }
    }


}
