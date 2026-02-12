using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score;
    // Animation
    public GameObject explotionObject;

    // Audios
    public AudioClip audioScoreBowling;
    public AudioClip explosionSound;
    private AudioSource audioSource;

    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
        audioSource = GetComponent<AudioSource>();
    }

    IEnumerator OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Boom"))
        {
            score --;
            Destroy(trigger.gameObject);
            scoreText.text = "Score: " + score.ToString();
            audioSource.PlayOneShot(explosionSound);

            Instantiate(explotionObject, trigger.transform.position, trigger.transform.rotation);
            
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("GameOverScene");
        } else
        {
            audioSource.PlayOneShot(audioScoreBowling);
            score++;
            scoreText.text = "Score: " + score.ToString();
        }

    }
    
    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        // if (collision.gameObject.tag == "Boom")
        if (collision.gameObject.CompareTag("Boom"))
        {
            score --;
            Destroy(collision.gameObject);
            scoreText.text = "Score: " + score.ToString();
            audioSource.PlayOneShot(explosionSound);

            Instantiate(explotionObject, collision.transform.position, collision.transform.rotation);
            
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
