using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour {

	//mudar de acordo com a representação do jogador
	private string player;
	public string Player{
		get{
			return this.player;
		}
		set{
			this.player = value;
			this.gameObject.name =  value;
		}
	}

	private short troopsCount;
	public short TroopsCount{
		get{
			return troopsCount;
		} 
		set{
			if(value > 0){
				troopsCount = value;
			}
			troopsCount = 1;
		}
	}

	void Start(){
		TroopsCount = 0;
		Player = "Alysson";
	}
	void OnMouseDown(){
		showTerritoryInfo();
	}	

	private void showTerritoryInfo(){
		//chamar GUI
		//atualizar informações da gui
		//mudar estado da GUI
		Camera.main.GetComponent<GameUIController>().updateUI(Player,TroopsCount);
	}
}
