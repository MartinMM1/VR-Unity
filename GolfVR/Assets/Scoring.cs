using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text element displaying the score
    public int score = 0; // The score value
    private WinUI winUI; // Reference to the WinUI script
    
    void Start()
    {
        // Find the GameObject with the WinUI script
        GameObject winUIGameObject = GameObject.Find("GameWall (5)");

        // Get the WinUI component from the GameObject
        winUI = winUIGameObject.GetComponent<WinUI>();

        // Update the hitsNeededText
        if (winUI != null)
        {
            winUI.UpdateHitsNeededText(score); // Pass the number of hits needed
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object that triggered the collider is the player or any other object you want to give points
        if (other.CompareTag("BallTrigger"))
        {
            // Increase the score
            score++;

            // Update the UI score text
            UpdateScoreUI();
        }
    }

    void UpdateScoreUI()
    {
        // Update the UI Text element with the new score value
        scoreText.text = "Hit Count: " + score.ToString();
    }
}