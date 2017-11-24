using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryList{
	private static CountryList instance = new CountryList();
	Dictionary<string,Country> countries;
	private CountryList(){
		GameObject[] countriesGO = GameObject.FindGameObjectsWithTag("territories");
		foreach(GameObject go in countriesGO){
			countries.Add(go.name, go.GetComponent<Country>());
		}
	}

	public static CountryList getInstance(){
		return instance;
	}

	public Country getCountry(string countryName){
		return countries[countryName];
	}

	public void setTroopToCountry(string countryName, short count){
		getCountry(countryName).TroopsCount = count;
	}
}
