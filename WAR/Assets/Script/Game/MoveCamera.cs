using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public Transform backgroundMap;
	Vector2 cameraSize;

	void Start(){
		cameraSize = new Vector2(getCameraWidth(),getCameraHeight());
	}

	void Update () {
		if(	Input.mousePosition.x > Screen.width * 0.9f && 
			this.transform.position.x + cameraSize.x/2 < backgroundMap.position.x + backgroundMap.localScale.x * 2){
			this.transform.position += Vector3.right * Time.deltaTime;
		}

		else if(Input.mousePosition.x < Screen.width *0.1f && 
			this.transform.position.x - cameraSize.x/2 > backgroundMap.position.x - backgroundMap.localScale.x * 2){
			this.transform.position += Vector3.left * Time.deltaTime;
		}

		if(Input.mousePosition.y > Screen.height *0.9f && 
			this.transform.position.y + cameraSize.y/2 < backgroundMap.position.y + backgroundMap.localScale.y * 4.4f){
			this.transform.position += Vector3.up * Time.deltaTime;
		}

		if(Input.mousePosition.y < Screen.height *0.1f && 
			this.transform.position.y - cameraSize.y/2 > backgroundMap.position.y - backgroundMap.localScale.y * 4.4f){
			this.transform.position += Vector3.down * Time.deltaTime;
		}
	}

	float getCameraWidth(){
		return this.GetComponent<Camera>().orthographicSize * this.GetComponent<Camera>().aspect;
	}

	float getCameraHeight(){
		return this.GetComponent<Camera>().orthographicSize;
	}
}
