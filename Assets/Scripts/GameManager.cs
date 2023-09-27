using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private int pOnePoints;
    private int pTwoPoints;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints(Color tileColor, string player)
    {
        if (tileColor == Color.white)
        {
            if (player == "PlayerOne")
            {
                pOnePoints++;
            }
            else if (player == "PlayerTwo")
            {
                pTwoPoints++;
            }
        }
        else
        {
            if (player == "PlayerOne")
            {
                pOnePoints++;
                pTwoPoints--;
            }
            else if (player == "PlayerTwo")
            {
                pTwoPoints++;
                pOnePoints--;
            }
        }
        Debug.Log(pOnePoints + "/" + pTwoPoints);

    }

}
