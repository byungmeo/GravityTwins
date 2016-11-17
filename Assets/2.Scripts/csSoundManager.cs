using UnityEngine;
using System.Collections;

public class csSoundManager : MonoBehaviour {
	public AudioSource musicSource;
	public static csSoundManager instance = null;

	void Awake () { //싱글턴
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);
	}


}
