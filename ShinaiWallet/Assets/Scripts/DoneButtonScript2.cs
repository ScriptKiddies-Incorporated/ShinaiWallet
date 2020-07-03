using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoneButtonScript2 : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Pincodescene");
    }
}
