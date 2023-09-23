using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    bool redPainted = false;
    bool bluePainted = false;

    [SerializeField]
    private GameObject squarePrefab;
    Vector2[] squarePositions = new Vector2[36];



    // Start is called before the first frame update
    void Start()
    {
        
        #region squarePosition array element declarations
        squarePositions[0] = new Vector2(-2.5f, 2.5f);
        squarePositions[1] = new Vector2(-1.5f, 2.5f);
        squarePositions[2] = new Vector2(-0.5f, 2.5f);
        squarePositions[3] = new Vector2(0.5f, 2.5f);
        squarePositions[4] = new Vector2(1.5f, 2.5f);
        squarePositions[5] = new Vector2(2.5f, 2.5f);
        squarePositions[6] = new Vector2(-2.5f, 1.5f);
        squarePositions[7] = new Vector2(-1.5f, 1.5f);
        squarePositions[8] = new Vector2(-0.5f, 1.5f);
        squarePositions[9] = new Vector2(0.5f, 1.5f);
        squarePositions[10] = new Vector2(1.5f, 1.5f);
        squarePositions[11] = new Vector2(2.5f, 1.5f);
        squarePositions[12] = new Vector2(-2.5f, 0.5f);
        squarePositions[13] = new Vector2(-1.5f, 0.5f);
        squarePositions[14] = new Vector2(-0.5f, 0.5f);
        squarePositions[15] = new Vector2(0.5f, 0.5f);
        squarePositions[16] = new Vector2(1.5f, 0.5f);
        squarePositions[17] = new Vector2(2.5f, 0.5f);
        squarePositions[18] = new Vector2(-2.5f, -0.5f);
        squarePositions[19] = new Vector2(-1.5f, -0.5f);
        squarePositions[20] = new Vector2(-0.5f, -0.5f);
        squarePositions[21] = new Vector2(0.5f, -0.5f);
        squarePositions[22] = new Vector2(1.5f, -0.5f);
        squarePositions[23] = new Vector2(2.5f, -0.5f);
        squarePositions[24] = new Vector2(-2.5f, -1.5f);
        squarePositions[25] = new Vector2(-1.5f, -1.5f);
        squarePositions[26] = new Vector2(-0.5f, -1.5f);
        squarePositions[27] = new Vector2(0.5f, -1.5f);
        squarePositions[28] = new Vector2(1.5f, -1.5f);
        squarePositions[29] = new Vector2(2.5f, -1.5f);
        squarePositions[30] = new Vector2(-2.5f, -2.5f);
        squarePositions[31] = new Vector2(-1.5f, -2.5f);
        squarePositions[32] = new Vector2(-0.5f, -2.5f);
        squarePositions[33] = new Vector2(0.5f, -2.5f);
        squarePositions[34] = new Vector2(1.5f, -2.5f);
        squarePositions[35] = new Vector2(2.5f, -2.5f);
        #endregion
        for (int i = 0; i < squarePositions.Length; i++)
        {
            Debug.Log("Loop" + i);

            Instantiate(squarePrefab, squarePositions[i], Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
