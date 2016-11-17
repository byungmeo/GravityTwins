using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class csGameManager: MonoBehaviour {
	public csHole red;
	public csHole blue;
	public string scene;
	private csTimer var;

	void Start() {
		var = FindObjectOfType<csTimer> ();
		var.clearstate.text = "";
	}

	void Update ()
	{
		
		FallCheck ();
	}

	void FallCheck()
	{
		if (red.IsFallIn () && blue.IsFallIn ()) //게임 클리어 조건 달성 시
		{
			StartCoroutine (NextScene());
		}	
	}

	IEnumerator NextScene () //클리어 텍스트 활성화 후 3초 후 다음 스테이지로
	{
		
		var.clearstate.text = "Stage\r\nClear";
		yield return new WaitForSeconds (3.0f);
		var.clearstate.text = "";
		SceneManager.LoadScene (scene);
	}
}
