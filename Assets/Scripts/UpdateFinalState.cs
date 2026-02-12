using UnityEngine;
using TMPro;

public class UpdateFinalState : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI finalTimeLeftText;

    void Start()
    {
        finalScoreText.text = "Final Score: " + StatusController.finalScore.ToString();
        finalTimeLeftText.text = "Timer Left: " + StatusController.finalTimeLeft.ToString();
    }
}
