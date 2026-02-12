using UnityEngine;

public class HatController_Keyboard : MonoBehaviour
{
    public float speed = 20f;
    private float direction;
    private Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        rigidbody.linearVelocity = new Vector2(direction*speed, rigidbody.linearVelocity.y);

    }
}
