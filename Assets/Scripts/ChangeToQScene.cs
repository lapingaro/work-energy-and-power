using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToQScene : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScenes()
    {
        SceneManager.LoadScene(7);
    }
	
	public void ChangeScenesToSimulation()
    {
        SceneManager.LoadScene(5);
    }
	
	
	public void ChangeScenesToMenu()
    {
        SceneManager.LoadScene(2);
    }
	
		public void changeToQuestion()
    {
        SceneManager.LoadScene(6);
		

    }
	
	public void restartSimulation()
    {
        SceneManager.LoadScene(6);
		

    }


	
	public void changeToSimulation()
    {
        SceneManager.LoadScene(6);
		

    }
}
