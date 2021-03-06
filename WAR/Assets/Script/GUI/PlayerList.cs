﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerList : MonoBehaviour {

    private readonly float step = 50;
	RectTransform addPlayerTransform;

	// Use this for initialization
	void Start () {
		GameObject addPlayer = GameObject.Find("AddPlayer");
		addPlayerTransform = addPlayer.GetComponent<RectTransform>();
		reorganizeList();
	}

	public void reorganizeList(){
		for(int i = 0; i < this.transform.childCount; i++){
			Transform child = this.transform.GetChild(i);
			child.GetComponent<RectTransform>().localPosition = myLocalPosition() + Vector3.down * step * i;
		}
		addPlayerTransform.localPosition = myLocalPosition() + Vector3.down * step * this.transform.childCount;
		testAndActivateAddPlayer();
	}	

	private void testAndActivateAddPlayer(){
		if(transform.childCount != 6)
			addPlayerTransform.gameObject.SetActive(true);
		else
			addPlayerTransform.gameObject.SetActive(false);
	}

	private Vector3 myLocalPosition(){
		return this.transform.GetComponent<RectTransform>().localPosition;
	}
}
