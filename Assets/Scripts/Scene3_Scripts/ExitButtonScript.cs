using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void clickYes()
    {
        Application.Quit();
        Debug.Log("the app has closed");
    }
}
