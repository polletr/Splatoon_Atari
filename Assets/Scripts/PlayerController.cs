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

    //variables implemented to available the stun mechanic
    private float speedReductionTime = 0f;
    private bool isSpeedReduced = false;

    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private Color playerColor;

    [SerializeField]
    private Color paintColor;

    private Color tileColor;

    private SpriteRenderer _spriteRenderer;

    private GameObject selectedSquare;

    private int colorAmmo = 0;

    public UnityEvent<Color, string, Color> onPaintingTile;

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
                    tileColor = selectedSquare.GetComponent<SpriteRenderer>().color;
                    // Now 'selectedSquare' will contain the square we want to iterate with
                }
            }
        }
        else
        {
            selectedSquare = null;
        }

        //Painting the selected square
        if (((Input.GetButtonDown("Fire2") && tag == "PlayerOne") || (Input.GetButtonDown("Fire1") && tag == "PlayerTwo")) && colorAmmo > 0 && tileColor != paintColor)
        {
            onPaintingTile.Invoke(tileColor, this.tag, playerColor);

            selectedSquare.GetComponent<SpriteRenderer>().color = paintColor;
            colorAmmo -= 1;

        }
        //Implementing the stun on the moveSpeed variable
        if (speedReductionTime > 0)
        {
            speedReductionTime -= Time.deltaTime;
            if (speedReductionTime <= 0)
            {
                moveSpeed = 0.5f;
                isSpeedReduced = false;
            }
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
        //Checking if the player collided with a laser beam
        if (other.CompareTag("Laser"))
        {
            speedReductionTime = 2.0f;
            moveSpeed = 0.1f;
            isSpeedReduced = true;
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
