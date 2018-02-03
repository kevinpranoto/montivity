using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	public CanvasGroup newStatusBox;
	public Button updateStatus;

	public CanvasGroup fortuneCookiePopUp;
	public Button fortuneCookie;

	public CanvasGroup inboxPopUp;
	public Button showInboxButton;

	void Start()
	{
		Button btnUpdateStatus = updateStatus.GetComponent<Button> ();
		btnUpdateStatus.onClick.AddListener (ShowStatusOnClick);

		Button btnFortuneCookie = fortuneCookie.GetComponent<Button> ();
		btnFortuneCookie.onClick.AddListener (ShowFortunePopUpOnClick);

		Button btnShowInbox = showInboxButton.GetComponent<Button> ();
		btnShowInbox.onClick.AddListener (ShowInbox);
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

	void ShowInbox()
	{
		if (inboxPopUp.alpha == 1)
			inboxPopUp.alpha = 0;
		else
			inboxPopUp.alpha = 1;
	}
}
