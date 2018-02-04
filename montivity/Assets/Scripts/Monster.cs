using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour {
	public string name;
	public string message;

	public Text displayMesssageText;
	public InputField newMessageInputField;
	public Button submitNewMessageButton;

	public Text incomingSupportText;
	public List<string> inboxList;
	public InputField supportInputField; // multiple instances on different friends screen

	public Text friendName1;
	public Text friendStat1;

	public Text friendName2;
	public Text friendStat2;

	public Text friendName3;
	public Text friendStat3;

	public Text friendName4;
	public Text friendStat4;

	public List<Monster> friends;
	public List<string> feelsLog;

	void Start()
	{
		Button btnSubmitNewMessage = submitNewMessageButton.GetComponent<Button> ();
		btnSubmitNewMessage.onClick.AddListener (setMessage);
	}

	void Update()
	{
		if (friends.Capacity != 0) 
		{
			friendName1.text = friends [0].name;
			friendStat1.text = friends [0].message;
		}
	}

	Monster()
	{
		name = "";
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

	public void receiveSupport()
	{
		incomingSupportText.text += supportInputField.text + "\n";
		inboxList.Add (supportInputField.text);
	}

}
