using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class WinnerText : MonoBehaviour
{

    private TMP_Text winText;

    // Start is called before the first frame update
    void Start()
    {
        winText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnWinning(string pText, Color playerColor)
    {
        winText.text = pText;
        winText.color = playerColor;
    }
}
