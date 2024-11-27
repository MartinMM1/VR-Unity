using UnityEngine;
using UnityEngine.UI;

public class WinUI : MonoBehaviour
{
    public Text winText;
    public Text hitsNeededText;

    private int hitsNeeded = 0; // Default value for hits needed

    public void UpdateHitsNeededText(int score)
    {
        hitsNeeded = score;

    }
    void OnTriggerEnter(Collider other)
    {
        // Check if the object that triggered the collider is the player or any other object you want to give points
        if (other.CompareTag("BallTrigger"))
        {
            UpdateScoreUI();
        }
        
    }
    void UpdateScoreUI()
    {
        // Update the UI Text element with the new score value
        hitsNeededText.text = "You win!";
        
    }

}
