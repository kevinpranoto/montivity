using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	public CanvasGroup newStatusBox;
	public Button updateStatus;

	void Start()
	{
		Button btn = updateStatus.GetComponent<Button> ();
		btn.onClick.AddListener (ShowStatusOnClick);
	}


	void ShowStatusOnClick()
	{
		Debug.Log ("pressed");
		if (newStatusBox.alpha == 1)
			newStatusBox.alpha = 0;
		else
			newStatusBox.alpha = 1;
	}
}
