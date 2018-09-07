using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grids2D;
using UnityEngine.SceneManagement;
public class WorldDataInit : MonoBehaviour {
	Grid2D grid;
	//public GameObject go;
	public GenerateWorld generateWorld;
	public static WorldDataInit instance = null;
	//====VARIABLES====//
	public bool isNewGame;
	 void Awake()
    {
       if(instance == null){
		   instance = this;
	   }else if(instance != this){
		   Destroy(gameObject);
	   }
        DontDestroyOnLoad(this.gameObject);
		isNewGame=false;
    }


	void Start () {
		
		//access grid2d api
		//grid = Grid2D.instance;
		//GenerateWorld();
		//generateWorld.GenerateNewMap();
		//generateWorld.GenerateNewMap();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void NewGameStart(){
		isNewGame = true;
		SceneManager.LoadScene("MainGameScene");
		//GenerateWorld();
		Debug.Log("Start");
		//isNewGame = false;
	}
	public void AssginGenerator(){
		//go = GameObject.FindWithTag("Generator");
	}
	public void SetGrid(){
		grid = Grid2D.instance;
	}
	public void GenerateWorld(){
		//AssginGenerator();
		//generateWorld = go.GetComponent<GenerateWorld>();
		generateWorld.GenerateNewMap();
	}
	public void ScreenWord(){

	}
}
