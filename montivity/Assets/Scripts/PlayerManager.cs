﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
	public CanvasGroup[] Players;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.LeftArrow))
			switchToPlayer(0);
		else if (Input.GetKeyDown (KeyCode.UpArrow))
			switchToPlayer(1);
		else if (Input.GetKeyDown (KeyCode.RightArrow))
			switchToPlayer(2);
	}

	void switchToPlayer(int n)
	{
		for (int i = 0; i < Players.Length; ++i) 
		{
			Players [i].alpha = 0;
			Players [i].transform.SetAsFirstSibling ();
		}

		Players [n].alpha = 1;
		Players [n].transform.SetAsLastSibling ();
		Debug.Log (n);
	}
}
