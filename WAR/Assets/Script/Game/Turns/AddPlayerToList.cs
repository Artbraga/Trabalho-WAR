using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPlayerToList : MonoBehaviour {

	// Use this for initialization
	public GameObject playerPrefab;
	public Transform playerList;
    private readonly float step = 50;

	void Start(){
	}

    public void addPlayer(){
		changePlayerName(getNewPlayerName());
		instantiateAndReorganizeList();
		testMaxPlayersAndSetInactive();
	}

    private void testMaxPlayersAndSetInactive(){
		if(playerList.childCount == 6){
			this.gameObject.transform.parent.gameObject.SetActive(false);
		}
	}

    private void instantiateAndReorganizeList(){
		Instantiate(playerPrefab, playerList);
		playerList.GetComponent<PlayerList>().reorganizeList();
    }

    private string getNewPlayerName(){
		GameObject playerNameGO = GameObject.Find("PlayerName");
		return playerNameGO.GetComponent<Text>().text;
	}


	void changePlayerName(string name){
		Transform input = playerPrefab.transform.GetChild(0);
		Text playerName = input.GetComponentInChildren<Text>();
		playerName.text = name;
	}	
}
