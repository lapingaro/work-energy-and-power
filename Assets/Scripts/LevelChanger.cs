using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

	public Animator animator;

	private int levelToLoad;




	public void switchScene(){
       FadeToNextLevel();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FadeToNextLevel ()
	{
		//FadeToLevel(SceneManager.GetActiveScene().buildIndex +1);
	}
	public void playScene(string game){
		SceneManager.LoadScene(game);
		FadeToLevel();
	}

	public void FadeToLevel()
	{
		//levelToLoad = levelIndex;
		animator.SetTrigger("FadeOut");
	}

	public void OnFadeComplete ()
	{
		SceneManager.LoadScene(levelToLoad);
	}
}
