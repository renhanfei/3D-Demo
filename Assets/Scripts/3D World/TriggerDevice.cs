﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TriggerDevice : MonoBehaviour {

	public Room thisRoom;

	public void Operate() {
		Debug.Log("Operating the trigger..!!");
		SceneManager.LoadScene("Block Builder Scene");
		thisRoom.OnCompleteRoomObjective();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}