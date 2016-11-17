using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class csStart : MonoBehaviour {

	public void introEnd () {
		SceneManager.LoadScene ("01-Tutorial1"); //듀토리얼로 이동
	}
}
