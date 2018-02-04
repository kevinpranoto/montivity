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

	public CanvasGroup friendsPopUp;
	public Button showFriendsButton;

	void Start()
	{
		Button btnUpdateStatus = updateStatus.GetComponent<Button> ();
		btnUpdateStatus.onClick.AddListener (ShowStatusOnClick);

		Button btnShowInbox = showInboxButton.GetComponent<Button> ();
		btnShowInbox.onClick.AddListener (ShowInbox);

		Button btnFortuneCookie = fortuneCookie.GetComponent<Button> ();
		btnFortuneCookie.onClick.AddListener (ShowFortunePopUpOnClick);

		Button btnFriends = showFriendsButton.GetComponent<Button> ();
		btnFriends.onClick.AddListener (ShowFriends);
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

		Debug.Log ("inboxPopUp toggled");
	}

	void ShowFriends()
	{
		if (friendsPopUp.alpha == 1)
			friendsPopUp.alpha = 0;
		else
			friendsPopUp.alpha = 1;

		Debug.Log ("friendsPopUp toggled");
	}
}
