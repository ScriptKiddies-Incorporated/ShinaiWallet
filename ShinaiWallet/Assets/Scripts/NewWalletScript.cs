using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewWalletScript : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Wordscene");
    }
}
