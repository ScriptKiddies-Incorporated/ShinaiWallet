using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoneButtonScript : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Pincodeconfirmscene");
    }
}
