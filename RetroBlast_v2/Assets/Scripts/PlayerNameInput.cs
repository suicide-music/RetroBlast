using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameInput : MonoBehaviour
{
    public string playerName;
    public GameObject inputField;
    public GameObject textDisplay;
    
    public void StoreName()
    {
        playerName = inputField.GetComponent<TextMeshProUGUI>().text;
        textDisplay.GetComponent<TextMeshProUGUI>().text = "Hi "+ playerName + "!";

    }


}
