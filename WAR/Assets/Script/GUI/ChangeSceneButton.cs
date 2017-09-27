using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour {
	public string redirectSceneName;
	public void changeSceneOnClick(){
		SceneManager.LoadScene(redirectSceneName);
	}
}
