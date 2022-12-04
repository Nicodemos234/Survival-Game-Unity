using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocity = 3.5f;

    private Rigidbody2D rb;
    private Vector2 mov = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        mov = new Vector2(horizontal * velocity, vertical * velocity);
    }

    private void FixedUpdate() {
        rb.MovePosition(rb.position + mov * Time.fixedDeltaTime);
    }
}
