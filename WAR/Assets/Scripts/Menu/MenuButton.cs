using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {
	public string redirectSceneName;
	public void changeSceneOnClick(){
		SceneManager.LoadScene(redirectSceneName);
	}
}
