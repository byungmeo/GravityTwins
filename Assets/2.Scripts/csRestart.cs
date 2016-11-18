using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class csRestart : MonoBehaviour {
	// Use this for initialization
	public void restart () {
		SceneManager.LoadScene ("00-Intro");
	}
}
