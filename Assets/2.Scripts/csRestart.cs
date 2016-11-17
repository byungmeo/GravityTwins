using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class csRestart : MonoBehaviour {
	public string restartScene;
	// Use this for initialization
	public void restart () {
		SceneManager.LoadScene (restartScene);
	}

	public void GoFirst () {
		DestroyObject(FindObjectOfType<csTimer> ());
		SceneManager.LoadScene ("01-Tutorial1");
	}
}
