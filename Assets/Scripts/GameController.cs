using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject[] fallingObjects;
    public GameObject spawningObject;
    public float maxTime = 10f;
    public static float timeLeft;
    public TextMeshProUGUI timerText;

    void Start()
    {
        timeLeft = maxTime;
        StartCoroutine(SpawnBall());
    }

    IEnumerator SpawnBall()
    {
        yield return new WaitForSeconds(1f);
        while (timeLeft > 0)
        {
            float randomX = Random.Range(-10f, 10f);
            Vector2 position = new Vector2(randomX, spawningObject.transform.position.y);
            GameObject fallingObject = fallingObjects[Random.Range(0, fallingObjects.Length)];
            GameObject ballinstance = Instantiate(fallingObject, position, Quaternion.identity);

            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("GameOverScene");
    }

    void FixedUpdate()
    {
        if (timeLeft <= 0)
        {
            Debug.Log("Game Over!");
            timeLeft = 0;
        } 
        else
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time Left: " + Mathf.RoundToInt(timeLeft).ToString();
        }
    }
}
