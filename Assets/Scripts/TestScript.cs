using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	public GenerateWorld gw;

	void Awake(){
		
	}

	void Start(){
		//gw.GenerateNewMap();
	}
	public void G(){
		gw.GenerateNewMap();
	}
}
