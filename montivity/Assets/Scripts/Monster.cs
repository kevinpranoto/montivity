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
	public InputField supportInputField1; // multiple instances on different friends screen
	public InputField supportInputField2; 
	public Button submitSupportButton1;
	public Button submitSupportButton2;

	public Text selfName1;
	public Text selfStat1;

	public Text selfName2;
	public Text selfStat2;

	public List<Monster> friends;
	public List<string> feelsLog;

	void Start()
	{
		Button btnSubmitNewMessage = submitNewMessageButton.GetComponent<Button> ();
		btnSubmitNewMessage.onClick.AddListener (setMessage);

		Button btnSubmitSupport1 = submitSupportButton1.GetComponent<Button> ();
		btnSubmitSupport1.onClick.AddListener (receiveSupport);

		Button btnSubmitSupport2 = submitSupportButton2.GetComponent<Button> ();
		btnSubmitSupport2.onClick.AddListener (receiveSupport);
	}

	void Update()
	{
		selfName1.text = name;
		selfStat1.text = message;

		selfName2.text = name;
		selfStat2.text = message;
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
		if (supportInputField1.text != "") {
			incomingSupportText.text += supportInputField1.text + "\n";
			inboxList.Add (supportInputField1.text);
		}
		if (supportInputField2.text != "") {
			incomingSupportText.text += supportInputField2.text + "\n";
			inboxList.Add (supportInputField2.text);
		}
	}

}
