using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    private float dirX;
    private float dirY;

    [SerializeField]
    private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "PlayerOne")
        {
            dirX = Input.GetAxisRaw("Horizontal2") * moveSpeed;
            dirY = Input.GetAxisRaw("Vertical2") * moveSpeed;
        }
        else if (tag == "PlayerTwo")
        {
            dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
            dirY = Input.GetAxisRaw("Vertical") * moveSpeed;
        }

        

        if (Input.GetButtonDown("Fire2") && tag == "PlayerOne")
        {
            Debug.Log("Color Player One");
        }

        if (Input.GetButtonDown("Fire1") && tag == "PlayerTwo")
        {
            Debug.Log("Color Player Two");
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }
}
