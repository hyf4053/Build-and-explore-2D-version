using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grids2D;
public class UnitProperities : MonoBehaviour {

	public UNITTYPE unitType;
	public Cell cell;
	public UnitInfo a,b,c,d,e,f,g,h;
	// Use this for initialization
	void Start(){

	}

	public void UnitDataGenerate(Cell cell){
		switch(unitType){
			case UNITTYPE.A:
			GenerateAData(cell);
			break;
		}
	}


	public void  GenerateAData(Cell cell){
		a = new UnitInfo(){
			isBattle = 0,
			moveActionPoint = 3,
			visionRange = 2,
			sanity = 100,
			supply = 100,
			debuff = new List<int>(),
			buff = new List<int>(),
			unitType = 0,
			isFrendly = 1,
			cellYouNowOn = cell
		};
	}
}
