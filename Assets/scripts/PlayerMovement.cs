using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 0.1f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Vector2 moveDir = Vector2.up * Input.GetAxisRaw("Vertical") + Vector2.right * Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(moveDir.x,moveDir.y,0) * speed;
    }
}
