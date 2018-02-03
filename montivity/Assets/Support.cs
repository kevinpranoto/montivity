using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Support : MonoBehaviour {
	public string message;
	// emote object here;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	Support(string newMessage)
	{
		message = newMessage;
	}

	string getMessage()
	{
		return message;
	}
}
