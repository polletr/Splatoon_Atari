using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class WinnerText : MonoBehaviour
{

    private TMP_Text _winText;

    // Start is called before the first frame update
    void Start()
    {
        _winText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnWinning(string pText, Color playerColor)
    {
        _winText = GetComponent<TMP_Text>();

        _winText.text = pText;
        _winText.color = playerColor;
    }
}
