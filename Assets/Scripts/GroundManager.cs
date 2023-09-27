using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField]
    private GameObject squarePrefab;
    
    private Vector2[] squarePositions = new Vector2[50];

    [SerializeField]
    private Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    squarePositions[i] = new Vector2(startPos.x + j * 0.15f, startPos.y - k * 0.15f);
                    i++;

            }
        }

/*        #region squarePosition array element declarations
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
*/      for (i = 0; i < squarePositions.Length; i++)
        {
            Instantiate(squarePrefab, squarePositions[i], Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
