using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoneButtonScript1 : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("MainWalletPage");
    }
}
