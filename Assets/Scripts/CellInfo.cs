using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grids2D;

public enum CELLTYPE{
		GRASS,DIRT,SEA,VALLY,RELIC,TEMPLE,CORRPUTLAND
	}
	public enum BUILDINGTYPE{
		Normal,Special
	}
public class CellInfo{
	public bool isVisible{get;set;}
	public bool isOccupied{get;set;}
	public CELLTYPE cellType{get;set;}
	public BUILDINGTYPE buildType{get;set;}
	public int movePunish{get;set;}
	public int visionFieldPunish{get;set;}
	public Cell cellOfGrid{get;set;}

}
