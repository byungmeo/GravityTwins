using UnityEngine;
using System.Collections;

public class csWallButton : MonoBehaviour {

	public GameObject Door;
	bool Active=false;
	public float ButtonMaxHeight; //0.8
	public float ButtonMinHeight; //0.1

	public float WallMaxWeight; //13
	public float WallMinWeight; //8

	void Update ()
	{
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

	void OnCollisionStay (Collision col)
	{
		if (col.gameObject.tag == "Red" || col.gameObject.tag == "Blue") {
			Active = true;
		}

	}

	void OnCollisionExit (Collision col)
	{
		StartCoroutine ("unActive");

	}

	IEnumerator unActive ()
	{
		yield return new WaitForSeconds (2.0f);
		Active = false;
		StopCoroutine ("unActive");
	}
}
