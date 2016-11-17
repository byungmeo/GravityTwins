using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class csPrintScore : MonoBehaviour {
	private float lastScore;
	public Text printScore;

	void Awake () {
		lastScore = FindObjectOfType<csTimer> ().time;

	}
	// Use this for initialization
	void Start () {
		printScore.text = lastScore.ToString ("F1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
