using UnityEngine;
using System.Collections;

public class csWallButtons : MonoBehaviour { //버튼이 2개일 때 적용되는 스크립트
	public GameObject Door; //버튼을 누르면 작동할 오브젝트
	bool Active=false; //버튼의 활성화 여부
	public float ButtonMaxHeight; //버튼 기본 높이 0.8 defaulle
	public float ButtonMinHeight; //버튼을 누를 시 최저 높이 0.1 defaulte

	public float WallMaxWeight; 
	public float WallMinWeight;

	public csWallButtons otherButton; //같은 기능을 하는 다른 버튼

	void Update ()
	{
		if (otherButton.Active == true) {
			if (Door.transform.position.x <= WallMaxWeight) {
				Door.gameObject.transform.Translate (Vector3.right * 1.8f * Time.deltaTime);
			}
		}



			if (Active == true) {
				if (this.transform.position.y >= ButtonMinHeight) {
					this.transform.Translate (Vector3.up * -0.4f * Time.deltaTime);
				}

				if (Door.transform.position.x <= WallMaxWeight) {
					Door.gameObject.transform.Translate (Vector3.right * 1.8f * Time.deltaTime);
				}
			} else {
				if (this.transform.position.y <= ButtonMaxHeight) {
					this.transform.Translate (Vector3.up * 0.4f * Time.deltaTime);
				}

				if (Door.transform.position.x >= WallMinWeight) {
					Door.gameObject.transform.Translate (Vector3.left * 1.8f * Time.deltaTime);
				}
			}
	}

	void OnCollisionStay (Collision col) //충돌 하는동안 호출
	{
		if (col.gameObject.tag == "Red" || col.gameObject.tag == "Blue") { //행성과 충돌할 경우만
			Active = true; //버튼 활성화
		}
		
	}

	void OnCollisionExit (Collision col) //충돌이 끝나면 한번 호출
	{
		StartCoroutine ("unActive");

	}
		
	IEnumerator unActive () //충돌이 끝난 후 시간차로 버튼 비활성화
	{
		yield return new WaitForSeconds (2.0f); //2초후
		Active = false; //비활성화
		StopCoroutine ("unActive");
	}
}
