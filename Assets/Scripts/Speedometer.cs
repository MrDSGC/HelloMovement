using UnityEngine;
using TMPro;

public class Speedometer : MonoBehaviour
{
    public TMP_Text speedText; // Reference to the Text component for displaying the speed

    // Method to update the speed value
    public void SetSpeed(float speed)
    {
        speedText.text = speed.ToString("0") + " km/h"; // Update the text with the speed value
    }
}
