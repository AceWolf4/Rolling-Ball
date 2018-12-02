using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {


	public GameObject player;

	public Text score;
	
	// Update is called once per frame
	void Update () {
		score.text = player.GetComponent<PlayerController> ().score.ToString();
	}
}
