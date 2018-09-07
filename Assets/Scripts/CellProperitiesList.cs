using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellProperitiesList : MonoBehaviour {

public List<CellProperities> properitiesList;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}
	public void AddNewDataToList(CellProperities properities){
		properitiesList.Add(properities);
	}
}
