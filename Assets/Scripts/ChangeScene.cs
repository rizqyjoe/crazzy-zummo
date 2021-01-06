using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void btn_change(string name){
		SceneManager.LoadScene(name);
	}

	public void OnPlay()
    {
		SceneManager.LoadScene(3);
    }

	public void Level2()
	{
		SceneManager.LoadScene(4);
	}

	public void Level3()
	{
		SceneManager.LoadScene(5);
	}
}