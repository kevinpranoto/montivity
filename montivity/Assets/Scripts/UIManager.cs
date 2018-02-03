using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	public CanvasGroup newStatusBox;
	public Button updateStatus;

	public CanvasGroup fortuneCookiePopUp;
	public Button fortuneCookie;

	void Start()
	{
		Button btnUpdateStatus = updateStatus.GetComponent<Button> ();
		btnUpdateStatus.onClick.AddListener (ShowStatusOnClick);

		Button btnFortuneCookie = fortuneCookie.GetComponent<Button> ();
		btnFortuneCookie.onClick.AddListener (ShowFortunePopUpOnClick);
	}


	void ShowStatusOnClick()
	{
		Debug.Log ("pressed");
		if (newStatusBox.alpha == 1)
			newStatusBox.alpha = 0;
		else
			newStatusBox.alpha = 1;
	}

	void ShowFortunePopUpOnClick()
	{
		if (fortuneCookiePopUp.alpha == 1)
			fortuneCookiePopUp.alpha = 0;
		else
			fortuneCookiePopUp.alpha = 1;
	}
}
