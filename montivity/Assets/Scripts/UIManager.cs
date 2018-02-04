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
		newStatusBox.transform.SetAsLastSibling ();
		Debug.Log ("pressed");
		if (newStatusBox.alpha == 1) {
			newStatusBox.alpha = 0;
			newStatusBox.interactable = false;
			newStatusBox.blocksRaycasts = false;
		} else {
			
			newStatusBox.alpha = 1;
			newStatusBox.interactable = true;
			newStatusBox.blocksRaycasts = true;
		}
	}

	void ShowFortunePopUpOnClick()
	{
		fortuneCookiePopUp.transform.SetAsLastSibling ();
		if (fortuneCookiePopUp.alpha == 1) {
			fortuneCookiePopUp.alpha = 0;
			fortuneCookiePopUp.interactable = false;
			fortuneCookiePopUp.blocksRaycasts = false;
		} else {
			fortuneCookiePopUp.alpha = 1;
			fortuneCookiePopUp.interactable = true;
			fortuneCookiePopUp.blocksRaycasts = true;
		}
	}

	void ShowInbox()
	{

		inboxPopUp.transform.SetAsLastSibling ();
		if (inboxPopUp.alpha == 1) {
			inboxPopUp.alpha = 0;
			inboxPopUp.interactable = false;
			inboxPopUp.blocksRaycasts = false;
		} else {
			inboxPopUp.alpha = 1;
			inboxPopUp.interactable = true;
			inboxPopUp.blocksRaycasts = true;
		}

		Debug.Log ("inboxPopUp toggled");
	}

	void ShowFriends()
	{

		friendsPopUp.transform.SetAsLastSibling ();
		if (friendsPopUp.alpha == 1) {
			friendsPopUp.alpha = 0;
			friendsPopUp.interactable = false;
			friendsPopUp.blocksRaycasts = false;
		} else {
			friendsPopUp.alpha = 1;
			friendsPopUp.interactable = true;
			friendsPopUp.blocksRaycasts = true;
		}

		Debug.Log ("friendsPopUp toggled");
	}
}
