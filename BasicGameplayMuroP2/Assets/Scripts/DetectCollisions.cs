using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
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
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else
        {

            Destroy(other.gameObject);

            // Increase the score
            if (gameObject.CompareTag("Food") && scoreManager != null)
            {
                scoreManager.IncreaseScore(1);
            }

            Destroy(gameObject);
        }
    }

}
