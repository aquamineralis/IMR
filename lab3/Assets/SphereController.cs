using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SphereController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private void Start()
    {
        UpdateScoreText();
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            float distance = Vector3.Distance(collision.transform.position, transform.position);
            score += (int) (100.0 * distance);
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
