using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grids2D;
public class CellProperities : MonoBehaviour {

	public CELLTYPE cellType;
	public BUILDINGTYPE buildType;
	public Cell cell;
	public CellInfo vally,grassLand,sea,dirt,relic,temple,corrputLand;

	void Start(){

	}

	public void SetTileToDataCollection(Cell cell){
		switch(cellType){
			case CELLTYPE.VALLY:
				GenerateVallyData(cell);
				Debug.Log("Vally Data Generated");
				//cell.SetCellInfo(vally);
			break;
			case CELLTYPE.GRASS:
				GenerateGrassData(cell);
				Debug.Log("Grass Data Generated");
			break;
		}
	}

	public void GenerateVallyData(Cell cell){
		vally = new CellInfo(){
			
		};
		
	}
	public void GenerateGrassData(Cell cell){
		grassLand = new CellInfo(){
			isVisible = false,
			isOccupied = true,
			cellType = CELLTYPE.GRASS,
			buildType = BUILDINGTYPE.Normal,
			movePunish = 0,
			visionFieldPunish = 0,
			cellOfGrid = cell
		};
		
	}

}
