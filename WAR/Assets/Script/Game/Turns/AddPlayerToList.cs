using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPlayerToList : MonoBehaviour {

	// Use this for initialization
	public GameObject playerPrefab;
	private Canvas canvas;
	public Transform playerList;
    private readonly float step = 10;

	void Start(){
		GameObject canvasGO = GameObject.Find("Canvas");
		canvas = canvasGO.GetComponent<Canvas>();
	}

    public void addPlayer(){
		string newPlayerName = getNewPlayerName();
		changePrefabPlayerName(newPlayerName);
		Instantiate(playerPrefab, playerList);
		reposition();
	}

	private string getNewPlayerName(){
		GameObject playerNameGO = GameObject.Find("PlayerName");
		return playerNameGO.GetComponent<Text>().text;
	}

	void changePrefabPlayerName(string name){
		Transform input = playerPrefab.transform.GetChild(0);
		Text playerName = input.GetComponentInChildren<Text>();
		playerName.text = name;
	}

	void reposition(){
		RectTransform parentTransform = getParentTransform();
		RectTransform lastPlayerAddedTransform = getLastPlayerAdded();
		RectTransform lastPlayerParentTransform = lastPlayerAddedTransform.parent.GetComponent<RectTransform>();
		parentTransform.localPosition = lastPlayerParentTransform.localPosition + lastPlayerAddedTransform.localPosition + Vector3.down * 50;
	}

    private RectTransform getParentTransform(){
		Transform parent = this.transform.parent;
		return parent.GetComponent<RectTransform>();
    }

    private RectTransform getLastPlayerAdded(){
		Transform lastItem = playerList.GetChild(playerList.childCount - 1);
		return lastItem.GetComponent<RectTransform>();
    }	
}
