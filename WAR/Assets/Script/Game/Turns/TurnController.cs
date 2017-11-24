using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour {

	private Queue<Player> players;
	private long turn;
	private short playerCount;
	void Start () {
		this.playerCount = (short)players.Count;
		turn = 0;
	}
	
	void Update () {
	}

	public void nextPlayerTurn(){
		players.Enqueue(players.Dequeue());
	}

	public Queue<Player> getPlayers(){
		return players;
	}

	public Player getActualPlayer(){
		return players.Peek();
	}
}
