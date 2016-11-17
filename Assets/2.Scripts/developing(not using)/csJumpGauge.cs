using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class csJumpGauge : MonoBehaviour {
	public Scrollbar JumpGauge;
	public float GaugeValue;

	// Update is called once per frame
	void Update () {
		if (Application.isEditor) 
		{
			if (Input.GetKey ("z")) 
			{
				if (GaugeValue < 0)
				{
					GaugeValue = 0;
				}

				GaugeValue -= 3;
				JumpGauge.size = GaugeValue * 0.01f;
			} 
			else
			{
				GaugeValue += 2;
				if (GaugeValue > 100) 
				{
					GaugeValue = 100;
				}
				JumpGauge.size = GaugeValue * 0.01f;
			}
		} else {
			if (Input.GetButton ("Fire1")) 
			{
				if (GaugeValue < 0) 
				{
					GaugeValue = 0;
				}

				GaugeValue -= 3;
				JumpGauge.size = GaugeValue * 0.01f;
			} 
			else 
			{
				GaugeValue += 2;
				if (GaugeValue > 100) 
				{
					GaugeValue = 100;
				}
				JumpGauge.size = GaugeValue * 0.01f;
			}
		}
	}
}
