using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player{

	private short id;
	private Color color;
	private List<Country> conqueredTerritories;

	public Color Color { 
		get{ return this.color; }
	}

	public Player(short id, Color color){
		this.id = id;
		this.color = color;
        conqueredTerritories = new List<Country>();

    }

	public void addCountry(Country country){
		conqueredTerritories.Add(country);
	}

	public void removeTerritory(Country country){
        conqueredTerritories.Remove(country);
	}

    public List<Country> territories()
    {
        return conqueredTerritories;
    }
}
