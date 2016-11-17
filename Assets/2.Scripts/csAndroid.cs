using UnityEngine;
using System.Collections;

public class csAndroid : MonoBehaviour {
	float TouchCount = 0f;
	private float time=3f;
	public static csAndroid instance = null;

	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);
	}

	void Update () {
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKeyDown (KeyCode.Escape)) { //돌아가기 버튼
				if (TouchCount == 2f) { //2번 누르면
					Application.Quit (); //게임 종료
				}

				TouchCount += 1f; //돌아가기 버튼을 누른 횟수
				TimeCheck ();
			}
		}
	}

	void TimeCheck () { //일정 시간이 지나면 돌아가기 버튼을 누른 횟수 초기화
		time -= Time.deltaTime;
		if(time <= 0)
		{
			TouchCount = 0f;
			time = 3f;
		}
	}
}