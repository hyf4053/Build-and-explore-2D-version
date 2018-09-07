﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grids2D;

public class SetTileToGrids : MonoBehaviour {
	Grid2D grid;
	//public Texture2D tex2D;
	public GameObject tile;
	public CellProperities properities;
	Vector3 v3;
	
	public Cell lastCell = null;
	// Use this for initialization
	void Start () {
		grid = Grid2D.instance;
	}
	
	// Update is called once per frame
	void Update () {
		if(grid.cellHighlighted!=null){
			if(Input.GetMouseButtonDown(0)){
				SetTileToCell(tile);
			}
		}
	}
	//Assign texture to variable tex2D from other class
	public void AssignTexture(/*Texture2D tex*/GameObject obj){
		tile = obj;
		//tex2D = tex;
	}
	//Once LMB pressed, check texture if it is null and assign it to cell
	public void SetTileToCell(/*Texture2D tex*/GameObject obj){
		if(obj!=null){
			lastCell = grid.cellHighlighted;
			v3 = grid.CellGetPosition(grid.CellGetIndex(lastCell));
			
			//
			
			GameObject instance = Instantiate(tile);
			properities = instance.GetComponent<CellProperities>();
			properities.SetTileToDataCollection(lastCell);
			instance.transform.localPosition = v3;
			obj = null;
			//grid.CellSetTexture(grid.CellGetIndex(lastCell),tex2D);
			//tex2D = null;
		}else{
			Debug.Log("Need to assign texture to variable first!");
		}
	}

	public void SetTileToCell(GameObject obj,Vector3 v3){
		if(obj!=null){
			//lastCell = cell;
			//v3 = grid.CellGetPosition(index);
			
			//
			
			GameObject instance = Instantiate(tile);
			properities = instance.GetComponent<CellProperities>();
			//properities.SetTileToDataCollection(lastCell);
			instance.transform.localPosition = v3;
			obj = null;
			//grid.CellSetTexture(grid.CellGetIndex(lastCell),tex2D);
			//tex2D = null;
		}else{
			Debug.Log("Need to assign texture to variable first!");
		}
	}


}
