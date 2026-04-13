using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Obstacle_1 : MonoBehaviour
{
    private Rigidbody rig;
    public float speed = 10f;
    Vector3 pos;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            // Trash scores = FindAnyObjectByType<Trash>();
            //scores.SaveHighest();
            SceneManager.LoadScene("AntsyRacer");
            //Debug.Log("Ow");
        }
    }
}
