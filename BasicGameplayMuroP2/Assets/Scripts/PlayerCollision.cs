using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    private ScoreManager scoreManager;

    void Start()
    {
        // Find the ScoreManager in the scene and get its component
        GameObject scoreManagerObject = GameObject.Find("GameManager");

        if (scoreManagerObject != null)
        {
            scoreManager = scoreManagerObject.GetComponent<ScoreManager>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("obstacles"))
        {
            if (scoreManager != null)
            {
                scoreManager.DecreaseLives(1);
            }

        }
    }
}

