using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour {
	public Canvas canvas;
	GameObject territoryNameGO, countTextGO;

	void Start(){
		countTextGO = GameObject.Find("Count");
		territoryNameGO = GameObject.Find("Name");
	}

	public void updateUI(string name, int count){
		updateTerritoryName(name);
		updateTroopCount(count);
	}
	public void updateUI(int count){
		updateTroopCount(count);
	}

	public void updateUI(string name){
		updateTerritoryName(name);
	}

	private void updateTerritoryName(string territoryName){
		territoryNameGO.GetComponent<Text>().text = territoryName;
	}
	private void updateTroopCount(int count){
		countTextGO.GetComponent<Text>().text = count.ToString();
	}
}
