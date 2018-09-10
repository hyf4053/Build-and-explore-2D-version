using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grids2D;

public class SetTileToGrids : MonoBehaviour {
	Grid2D grid;
	//public Texture2D tex2D;
	//public GameObject tile;
	public CellProperitiesList properitiesList;
	public CellProperities properities;
	public SpriteCollection collection;
	//public SetTileToGrids sttg;
	Vector3 v3;
	
	public Cell lastCell = null;
	// Use this for initialization
	void Start () {
		grid = Grid2D.instance;
	}
	
	// Update is called once per frame
	void Update () {
		if(grid.cellHighlighted!=null){
			if(Input.GetMouseButtonDown(0)&&grid.cellHighlighted.info==null){
				SetTileToCell(collection.spriteCollection[0]);
			}else if(Input.GetMouseButtonDown(0)&&grid.cellHighlighted.info!=null){
				if(grid.cellHighlighted.info.isOccupied){
					Debug.Log("Cell is already occupied!");
				}else{
					SetTileToCell(collection.spriteCollection[0]);
				}
			}
		}
	}
	//Assign texture to variable tex2D from other class
	public void AssignTexture(/*Texture2D tex*/GameObject obj){
		//tile = obj;
		//tex2D = tex;
	}
	//Once LMB pressed, check texture if it is null and assign it to cell
	public void SetTileToCell(/*Texture2D tex*/GameObject obj){
		if(obj!=null){
			lastCell = grid.cellHighlighted;
			v3 = grid.CellGetPosition(grid.CellGetIndex(lastCell));
			//grid.CellSetSprite(grid.CellGetIndex(lastCell),Color.white,collection.spriteCollection[0]);
			//
			
			GameObject instance = Instantiate(obj);
			properities = instance.GetComponent<CellProperities>();
			properities.SetTileToDataCollection(lastCell);
			//properities.SetToCellInfo(lastCell);
			properitiesList.AddNewDataToList(properities);
			instance.transform.localPosition = v3;
			obj = null;
			//grid.CellSetTexture(grid.CellGetIndex(lastCell),tex2D);
			//tex2D = null; 
		}else{
			Debug.Log("Need to assign texture to variable first!");
		}
	}
    public void SetTileToCell(GameObject obj, Vector3 v3, Cell cell){
		if(obj!=null){
			//lastCell = cell;
			//v3 = grid.CellGetPosition(index);
			
			//
			
			GameObject instance = Instantiate(obj);
			properities = instance.GetComponent<CellProperities>();
			properities.SetTileToDataCollection(cell);
			//properities.cell
			//properities.SetToCellInfo(lastCell);
			properitiesList.AddNewDataToList(properities);
			instance.transform.localPosition = v3;
			obj = null;
			//grid.CellSetTexture(grid.CellGetIndex(lastCell),tex2D);
			//tex2D = null;
		}else{
			Debug.Log("Need to assign texture to variable first!");
		}
	}


}
