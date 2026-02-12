using UnityEngine;
using UnityEngine.SceneManagement;

public class InitGame : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
