using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToInstructionAndBack : MonoBehaviour
{
    public void ToIstructions()
    {
        SceneManager.LoadScene(3);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(2);
    }
}
