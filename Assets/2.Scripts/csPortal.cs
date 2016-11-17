using UnityEngine;
using System.Collections;

public class csPortal : MonoBehaviour {
	public csPortal Destination;
	float disableTime=0;
	
	// Update is called once per frame
	void Update () 
	{
		if (disableTime > 0) 
		{
			disableTime -= Time.deltaTime;
		}
	}

	void OnTriggerEnter (Collider col)
	{
		if(disableTime<=0 && col.tag=="Red" || col.tag=="Blue" && disableTime <=0)
		{
			Destination.disableTime = 1;
			Vector3 coord = Destination.gameObject.transform.position;
			coord.y += 1;
			col.gameObject.transform.position=coord;
		}
	}
}
