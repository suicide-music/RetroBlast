using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerNameDisplay : MonoBehaviour

{
    public TextMeshProUGUI playerNameText;


    // Start is called before the first frame update
    void Awake()
    {
        if (playerNameText != null)
        {
            playerNameText.text = "Player: " + DataTransfer.playerName;
        }
        else
        {
            Debug.LogWarning("PlayerNameText variable is not assigned in the Inspector.");
        }

    }

    // Update is called once per frame
    void Update()
    {
    
    }


}
