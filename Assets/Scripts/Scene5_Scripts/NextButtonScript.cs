using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonScript : MonoBehaviour
{
    public void changeToSelection()
    {
        SceneManager.LoadScene(5);
    }
}
