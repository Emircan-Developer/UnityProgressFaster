using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameException
{
    public static void Building(TextMeshProUGUI text)
    {
         
            text.text = "You Cannot Build Here";
            Debug.Log("Exception Runned");
      
    }

}
