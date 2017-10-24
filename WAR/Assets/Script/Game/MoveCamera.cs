using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.mousePosition.x > Screen.width *0.9f){
			this.transform.position += Vector3.right * Time.deltaTime;
		}

		if(Input.mousePosition.x < Screen.width *0.1f){
			this.transform.position += Vector3.left * Time.deltaTime;
		}
	}
}
