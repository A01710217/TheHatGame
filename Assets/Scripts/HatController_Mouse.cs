using UnityEngine;

public class HatController_Mouse : MonoBehaviour
{
    private Camera cam;
    private Rigidbody2D rigidbody;

    void Start() 
    {
        cam = Camera.main;
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 targetPosition = new Vector2(rawPosition.x, 0f);
        rigidbody.MovePosition(targetPosition);
    }
}