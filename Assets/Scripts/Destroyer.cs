using UnityEngine;

public class Destroyer : MonoBehaviour
{    
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        Destroy(gameObject);
    }
}
