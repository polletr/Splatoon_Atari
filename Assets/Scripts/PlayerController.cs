using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{

    private List<GameObject> collidingSquares = new List<GameObject>();

    private Rigidbody2D rb;
    private float dirX;
    private float dirY;

    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private Color playerColor;

    [SerializeField]
    private Color paintColor;

    private SpriteRenderer _spriteRenderer;

    private GameObject selectedSquare;

    private int colorAmmo = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = playerColor;
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

        if (collidingSquares.Count > 0)
        {
            //Select the square closest to the player
            float minDistance = Mathf.Infinity;
            foreach (var square in collidingSquares)
            {
                float distance = Vector2.Distance(transform.position, square.transform.position);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    selectedSquare = square;
                    // Now 'selectedSquare' will contain the square we want to iterate with
                }
            }
        }
        else
        {
            selectedSquare = null;
        }

        //Painting the selected square
        if (((Input.GetButtonDown("Fire2") && tag == "PlayerOne") || (Input.GetButtonDown("Fire1") && tag == "PlayerTwo")) && colorAmmo > 0)
        {
            selectedSquare.GetComponent<SpriteRenderer>().color = paintColor;
            colorAmmo -= 1;
        }


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("FloorSquare"))
        {
            collidingSquares.Add(other.gameObject);
        }

        if (other.CompareTag("PaintBucket") && other.gameObject.GetComponent<SpriteRenderer>().color == playerColor)
        {
            colorAmmo += 1;
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("FloorSquare"))
        {
            collidingSquares.Remove(other.gameObject);
        }
    }

}
