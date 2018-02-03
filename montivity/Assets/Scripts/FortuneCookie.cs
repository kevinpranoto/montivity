using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortuneCookie : MonoBehaviour {

	public Text showQuote;
	public Button generateFortune;

	private List<string> quoteList;

	// Use this for initialization
	FortuneCookie()
	{
		quoteList = new List<string>();

		quoteList.Add ("Reach for joy and all else will follow.");
		quoteList.Add ("Move in the direction of your dreams.");
		quoteList.Add ("Bloom where you are planted.");
		quoteList.Add ("A journey of a thousand miles begins with a single step.");
		quoteList.Add ("Get your mind set… confidence will lead you on.");
		quoteList.Add ("Love is like wildflowers…it is often found in the most unlikely places.");
		quoteList.Add ("When one door closes, another opens.");
		quoteList.Add ("In dreams and in love there are no impossibilities.");
		quoteList.Add ("Don’t give up.");
		quoteList.Add ("You will become great if you believe in yourself.");
		quoteList.Add ("You can make your own happiness.");
		quoteList.Add ("If winter comes, can spring be far behind?");
		quoteList.Add ("You will conquer obstacles to achieve success.");
		quoteList.Add ("Every day is a new day.");
		quoteList.Add ("Find a peaceful place where you can make plans for the future.");


	}

	void Start()
	{
		Button btnGenerateFortune = generateFortune.GetComponent<Button> ();
		btnGenerateFortune.onClick.AddListener (showFortuneOnClick);
	}

	public void showFortuneOnClick()
	{
		showQuote.text = quoteList [Random.Range (0, (quoteList.Capacity) - 1)];
	}
}
