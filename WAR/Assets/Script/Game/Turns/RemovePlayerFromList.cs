using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePlayerFromList : MonoBehaviour {

	public void remove(){
		this.transform.parent.parent = null;
		reorganizeChilds();
		destroyMe();
	}

    private void reorganizeChilds(){
		GameObject playerList = GameObject.Find("PlayersList");
		playerList.GetComponent<PlayerList>().reorganizeList();
    }

    private void destroyMe(){
		Destroy(this.transform.parent.gameObject);
	}
}
