using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public static int buttonValue = 0;

    public void buttonClick()
    {
        Debug.Log(buttonValue);
        
    }

    public void Update()
    {
        buttonValue = buttonValue + 1;
    }
}
