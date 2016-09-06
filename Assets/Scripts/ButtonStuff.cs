using UnityEngine;
using System.Collections;

public class ButtonStuff : MonoBehaviour {

	public void GameStart () {
		Application.LoadLevel (1);

	}

	public void GameEnd () {
		Application.Quit();
	}
}