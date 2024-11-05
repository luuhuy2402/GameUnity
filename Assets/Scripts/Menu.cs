
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
	 public void Play()
	{
		SceneManager.LoadScene(1);
	}

	public void Home()
	{
		SceneManager.LoadScene(0);
	}

	public void Exit()
	{

	}
}
