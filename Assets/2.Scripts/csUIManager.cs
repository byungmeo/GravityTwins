using UnityEngine;
using System.Collections;

public class csUIManager : MonoBehaviour {

	public Canvas uiCanvas;

	public static csUIManager instance = null;

	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject);
	}

	// Use this for initialization
	void Start () {
		uiCanvas.enabled = false;
	}

	public void Menu_Clicked ()
	{
		uiCanvas.enabled = true;
	}

	public void Resume_Clicked ()
	{
		uiCanvas.enabled = false;
	}
}