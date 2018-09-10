using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grids2D;

public class GenerateWorld : MonoBehaviour {

	Grid2D grid;
	public static GenerateWorld instance = null;
	public GameObject go;
	public Texture2D noiseTex;
	//public Texture2D[] colorRamp;
	public CellProperities setProperities;
	public SetTileToGrids sttg;
	//public List<GameObject> tilesList;
	public List<float> elevationList;
	public float maxPosition;
	//public Ce
	Color[] noise;
	[Range(0,0.99f)]
	public float waterLevel = 0.99f;
	// Use this for initialization
	void Start () {
		grid = Grid2D.instance;
		noise = noiseTex.GetPixels();
		instance = this;
		elevationList = new List<float>();
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
				//Debug.Log(elevation);
				elevationList.Add(elevation);
				/* 
				if (elevation<waterLevel) {
					// water
					grid.cells[i].visible = false;
					sttg.SetTileToCell(sttg.collection.spriteCollection[4],grid.CellGetPosition(i));
				} else {
					grid.cells[i].visible = true;
					sttg.SetTileToCell(sttg.collection.spriteCollection[0],grid.CellGetPosition(i));
					//grid.CellSetSprite(i,Color.white,sttg.collection.sc[0]);
					
					//grid.CellToggle(i,true,colorRamp[0]);

					///int pos = (int)(colorRamp.width * (elevation - waterLevel) / (1f - waterLevel));
					//Color color = ramp[pos];
					//grid.CellToggle(i, true, color);
				}
				*/
			}

			BiomeGenerate();
			go.GetComponent<WorldDataInit>().isNewGame=false;
		}else{
			Debug.Log("GameLoaded");
		}
		
	}

	public void BiomeGenerate(){

		GetHighestPositon();
        int highestPositon = elevationList.IndexOf(maxPosition);
        grid.cells[highestPositon].visible = true;
        sttg.SetTileToCell(sttg.collection.spriteCollection[1], grid.CellGetPosition(highestPositon), grid.cells[highestPositon]);


		for(int i = 0; i<elevationList.Count;i++){
			if (elevationList[i]<waterLevel) {
                    //海拔低于海平面且单元格信息为null
					// water
					grid.cells[i].visible = false;
					sttg.SetTileToCell(sttg.collection.spriteCollection[4],grid.CellGetPosition(i),grid.cells[i]);
				} else if(elevationList[i] > waterLevel&&grid.cells[i].info==null) {
                //海拔高于海平面且单元格信息为null
                if (GenerateRandom.floatRandom(0.6f,Random.Range(0,1f)))
                {
                    grid.cells[i].visible = true;
                    sttg.SetTileToCell(sttg.collection.spriteCollection[6], grid.CellGetPosition(i), grid.cells[i]);
          
                }
               
                else
                {
                    grid.cells[i].visible = true;
                    sttg.SetTileToCell(sttg.collection.spriteCollection[0], grid.CellGetPosition(i), grid.cells[i]);
                }
                   
				} else if(elevationList[i] > waterLevel && grid.cells[i].info != null) {
                    Debug.Log("Is City");
                //海报高于海平面且单元格信息不为null
                } else if (elevationList[i] == waterLevel) {
                grid.cells[i].visible = true;
                sttg.SetTileToCell(sttg.collection.spriteCollection[0], grid.CellGetPosition(i), grid.cells[i]);
            }
		}
	}

    

	public void GetHighestPositon(){
        maxPosition = Mathf.Max(elevationList.ToArray());
        
        int n = 0;
        for (int i = 0;i<elevationList.Count;i++)
        {
            if (elevationList[i]== maxPosition)
            {
                n++;
            }
        }
		
		Debug.Log("Max float: "+maxPosition+"Number of max float: "+n);
	}
}
