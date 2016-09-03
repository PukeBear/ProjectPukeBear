using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Scoreboard : MonoBehaviour {

	public Text uiText;
	public int count = 0;
	// Use this for initialization
	void Start () {

		uiText = GameObject.Find ("ScoreText").GetComponent<Text>();



		Debug.Log (uiText.text);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GameObject loaderr = GameObject.Find("LevelLoader");
		LevelLoader scriptt = loaderr.GetComponent<LevelLoader>();
		count = scriptt.counter; 
		Debug.Log(count);
		uiText.text = count.ToString();
}

}
