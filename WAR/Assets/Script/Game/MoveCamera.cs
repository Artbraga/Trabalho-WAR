using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public GameObject backgroundMap;
	Vector2 cameraSize;
	Vector2 bgSize;

    private bool moving;
    private float speed;

    void Start(){
		cameraSize = new Vector2(getCameraWidth(),getCameraHeight());
		bgSize = backgroundMap.GetComponent<SpriteRenderer>().bounds.size/2;
		speed = 1;
	}

	void Update () {
		moving = false;
		if(	Input.mousePosition.x > Screen.width * 0.9f && 
			this.transform.position.x + cameraSize.x < backgroundMap.transform.position.x + bgSize.x){
				move(Vector3.right);
		}

		else if(Input.mousePosition.x < Screen.width *0.1f && 
			this.transform.position.x - cameraSize.x > backgroundMap.transform.position.x - bgSize.x){
				move(Vector3.left);
		}

		if(Input.mousePosition.y > Screen.height *0.9f && 
			this.transform.position.y + cameraSize.y < backgroundMap.transform.position.y + bgSize.y){
				move(Vector3.up);
		}

		else if(Input.mousePosition.y < Screen.height *0.1f && 
			this.transform.position.y - cameraSize.y > backgroundMap.transform.position.y - bgSize.y){
				move(Vector3.down);
		}
		increaseMoveSpeedIfMoving();
	}

	float getCameraWidth(){
		return this.GetComponent<Camera>().orthographicSize  * this.GetComponent<Camera>().aspect;
	}

	float getCameraHeight(){
		return this.GetComponent<Camera>().orthographicSize;
	}

	void move(Vector3 direction){
		this.transform.position += direction.normalized * Time.deltaTime * speed;
		moving = true;
	}

	void increaseMoveSpeedIfMoving(){
		if(moving){
			speed += 0.02f;
			return;
		}
		speed = 1;
	}
}
