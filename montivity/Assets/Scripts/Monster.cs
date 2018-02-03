using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour {
	public string name;
	public string message;

	public InputField newMessageInputField;
	public Text displayMesssageText;

	public Text incomingSupportText;
	public InputField supportInputField;

	public Text friendName;
	public Text friendStat;

	public List<Monster> friends;
	public List<string> feelsLog;

	void Update()
	{
		friendName.text = friends [0].name;
		friendStat.text = friends [0].message;
	}

	Monster()
	{
		name = "foo";
		message = "";
	}

	public void setMessage()
	{
		displayMesssageText.text = newMessageInputField.text;
		message = displayMesssageText.text;
		feelsLog.Add (message);
		for (int i = 0; i < feelsLog.Count; ++i) 
		{
			Debug.Log (feelsLog [i]);
		}
	}

	public void sendSupport()
	{
		incomingSupportText.text += supportInputField.text + "\n";
	}
}
