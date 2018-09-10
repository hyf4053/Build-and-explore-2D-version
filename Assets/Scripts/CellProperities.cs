using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grids2D;
public class CellProperities : MonoBehaviour {

	public CELLTYPE cellType;
	public BUILDINGTYPE buildType;
	public Cell cell;
	public CellInfo vally,grassLand,sea,dirt,relic,temple,corrputLand,sand;

	void Start(){
		//GenerateGrassData();
	}

	public void SetTileToDataCollection(Cell cell){
		switch(cellType){
			case CELLTYPE.VALLY:
				GenerateVallyData(cell);
				cell.info = this.vally;
				Debug.Log("Vally Data Generated");
				//cell.SetCellInfo(vally);
			break;
			case CELLTYPE.GRASS:
				GenerateGrassData(cell);
				cell.info = this.grassLand;
				Debug.Log("Grass Data Generated");
			break;
			case CELLTYPE.SEA:
				GenerateSeaData(cell);
				cell.info = this.sea;
			break;
            case CELLTYPE.SAND:
                GenerateSandData(cell);
                cell.info = this.sand;
            break;
		}
	}

	public void GenerateVallyData(Cell cell){
		vally = new CellInfo(){
            isVisible = false,
            isOccupied = true,
            cellType = CELLTYPE.VALLY,
            buildType = BUILDINGTYPE.Normal,
            movePunish = 0,
            visionFieldPunish = 0,
            cellOfGrid = cell
        };
		
	}
	public void GenerateSeaData(Cell cell){
        sea = new CellInfo()
        {
            isVisible = false,
            isOccupied = true,
            cellType = CELLTYPE.SEA,
            buildType = BUILDINGTYPE.Special,
            movePunish = 0,
            visionFieldPunish = 0,
            cellOfGrid = cell
        };
	}
    public void GenerateSandData(Cell cell)
    {
        sand = new CellInfo()
        {
            isVisible = false,
            isOccupied = true,
            cellType = CELLTYPE.SAND,
            buildType = BUILDINGTYPE.Special,
            movePunish = 0,
            visionFieldPunish = 0,
            cellOfGrid = cell
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

		//SetInfoToCell(cell,info);
	}


}
