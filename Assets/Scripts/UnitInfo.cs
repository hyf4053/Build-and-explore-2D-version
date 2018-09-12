using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grids2D;

public enum UNITTYPE{
	A,B,C,D,E,F,G,H
}
public enum DEBUFF{
	I,J,K
}
public enum BUFF{
	L,M,N
}

public class UnitInfo{
	public int isBattle{get;set;}
	public int moveActionPoint{get;set;}
	public int visionRange{get;set;}
	public int sanity{get;set;}//hp
	public int supply{get;set;}
	public List<int> debuff{get;set;}
	public List<int> buff{get;set;}   
	public int unitType{get;set;}
	public int isFrendly{get;set;}
	public Cell cellYouNowOn{get;set;}
}
