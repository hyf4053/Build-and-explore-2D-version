using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grids2D;

public class GenerateWorld : MonoBehaviour {

	Grid2D grid;
	public static GenerateWorld instance = null;
	public GameObject go;
	public Texture2D noiseTex;
	public Texture2D[] colorRamp;
	public CellProperities setProperities;
	public SetTileToGrids sttg;
	public List<GameObject> tilesList;
	//public Ce
	Color[] noise;
	[Range(0,0.99f)]
	public float waterLevel = 0.99f;
	// Use this for initialization
	void Start () {
		grid = Grid2D.instance;
		noise = noiseTex.GetPixels();
		instance = this;
		GenerateNewMap();
		//GenerateNewMap();
		
		//colorRamp = new List<Texture2D>(10);
		//Color[] ramp = colorRamp.GetPixels();
	}

	void Awake(){
		go = GameObject.Find("WorldDataInit");
		//go.GetComponent<WorldDataInit>().generateWorld = this;
	}

	public void GenerateNewMap(){
		if(go.GetComponent<WorldDataInit>().isNewGame){
			int width = noiseTex.width;
			int height = noiseTex.height;
			int cellCount = grid.cells.Count;

			for(int i=0;i<cellCount;i++){
				Vector2 center = grid.cells[i].center;
				int tw = (int)((center.x+0.5f)*width);
				int th = (int)((center.y + 0.5f) * height);
				float elevation = noise[th * width + tw].g;
				if (elevation<waterLevel) {
					// water
					grid.cells[i].visible = false;
				} else {
					grid.cells[i].visible = true;
					sttg.SetTileToCell(tilesList[0],grid.CellGetPosition(i));
					
					//grid.CellToggle(i,true,colorRamp[0]);

					///int pos = (int)(colorRamp.width * (elevation - waterLevel) / (1f - waterLevel));
					//Color color = ramp[pos];
					//grid.CellToggle(i, true, color);
				}
			}
			go.GetComponent<WorldDataInit>().isNewGame=false;
		}else{
			Debug.Log("GameLoaded");
		}
		
	}


}
