using UnityEngine;

public class StatusController : MonoBehaviour
{
    public static int finalScore = 0;
    public static float finalTimeLeft = 0;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        finalScore = ScoreController.score;
        finalTimeLeft = GameController.timeLeft;
    }
}
