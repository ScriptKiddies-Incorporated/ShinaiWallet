using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PINCodeTextScript : MonoBehaviour
{
    public static Text pinCode;
    public static string pinCodeString;
    
    public void TextInput()
    {
        
        pinCode.text = pinCodeString;
       // pinCodeString.Replace(pinCodeString,"1");
    }
}
