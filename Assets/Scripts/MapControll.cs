using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grids2D;

public class MapControll : MonoBehaviour {
	Grid2D grid;
	// Use this for initialization
	void Start () {
		grid = Grid2D.instance;
	}
	
	// Update is called once per frame
	void Update () {
		if(grid.cellHighlighted!=null){
			if(Input.GetMouseButtonDown(0)&&grid.cellHighlighted.info.cellType==CELLTYPE.VALLY){
				Debug.Log("Vally is clicked!");
				//Game UI pop up
			}else if(Input.GetMouseButtonDown(0)&&grid.cellHighlighted.info.cellType!=CELLTYPE.VALLY){
				//Game UI hide
			}
		}
	}
}
