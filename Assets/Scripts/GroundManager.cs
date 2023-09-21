using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    bool redPainted = false;
    bool bluePainted = false;

    public GameObject squarePrefab;
    Vector3[] squarePositions = new Vector3[36];



    // Start is called before the first frame update
    void Start()
    {
        #region squarePosition array element declarations
        squarePositions[0] = new Vector3(-2.5f, 2.5f, 0);
        squarePositions[1] = new Vector3(-1.5f, 2.5f, 0);
        squarePositions[2] = new Vector3(-0.5f, 2.5f, 0);
        squarePositions[3] = new Vector3(0.5f, 2.5f, 0);
        squarePositions[4] = new Vector3(1.5f, 2.5f, 0);
        squarePositions[5] = new Vector3(2.5f, 2.5f, 0);
        squarePositions[6] = new Vector3(-2.5f, 1.5f, 0);
        squarePositions[7] = new Vector3(-1.5f, 1.5f, 0);
        squarePositions[8] = new Vector3(-0.5f, 1.5f, 0);
        squarePositions[9] = new Vector3(0.5f, 1.5f, 0);
        squarePositions[10] = new Vector3(1.5f, 1.5f, 0);
        squarePositions[11] = new Vector3(2.5f, 1.5f, 0);
        squarePositions[12] = new Vector3(-2.5f, 0.5f, 0);
        squarePositions[13] = new Vector3(-1.5f, 0.5f, 0);
        squarePositions[14] = new Vector3(-0.5f, 0.5f, 0);
        squarePositions[15] = new Vector3(0.5f, 0.5f, 0);
        squarePositions[16] = new Vector3(1.5f, 0.5f, 0);
        squarePositions[17] = new Vector3(2.5f, 0.5f, 0);
        squarePositions[18] = new Vector3(-2.5f, -0.5f, 0);
        squarePositions[19] = new Vector3(-1.5f, -0.5f, 0);
        squarePositions[20] = new Vector3(-0.5f, -0.5f, 0);
        squarePositions[21] = new Vector3(0.5f, -0.5f, 0);
        squarePositions[22] = new Vector3(1.5f, -0.5f, 0);
        squarePositions[23] = new Vector3(2.5f, -0.5f, 0);
        squarePositions[24] = new Vector3(-2.5f, -1.5f, 0);
        squarePositions[25] = new Vector3(-1.5f, -1.5f, 0);
        squarePositions[26] = new Vector3(-0.5f, -1.5f, 0);
        squarePositions[27] = new Vector3(0.5f, -1.5f, 0);
        squarePositions[28] = new Vector3(1.5f, -1.5f, 0);
        squarePositions[29] = new Vector3(2.5f, -1.5f, 0);
        squarePositions[30] = new Vector3(-2.5f, -2.5f, 0);
        squarePositions[31] = new Vector3(-1.5f, -2.5f, 0);
        squarePositions[32] = new Vector3(-0.5f, -2.5f, 0);
        squarePositions[33] = new Vector3(0.5f, -2.5f, 0);
        squarePositions[34] = new Vector3(1.5f, -2.5f, 0);
        squarePositions[35] = new Vector3(2.5f, -2.5f, 0);
        #endregion
        for (int i = 0; i < squarePositions.Length; i++)
        {
            GameObject instantiateSquare = Instantiate(squarePrefab, squarePositions[i], Quaternion.identity);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
