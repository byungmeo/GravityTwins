using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class csGravityController : MonoBehaviour {
    //  중력 가속도
    const float Gravity = 9.81f;
	public float Speed;

    //  중력의 적용 상태
    public float gravityScale = 1.0f;

	void Update () {
        Vector3 vector = new Vector3();

        //  유니티 에디터와 실제 기기에서의 처리를 분리
        if (Application.isEditor)
        {
            //  키 입력을 검출하는 벡터를 설정
            vector.x = Input.GetAxis("Horizontal");
            vector.z = Input.GetAxis("Vertical");

            //  높이 방향의 판정은 z 키로 한다

            if (Input.GetKey("z"))
            {
				vector.y = Speed;
            }
            else
            {
				vector.y = -Speed;
            }
        }
        else
        {
            //  가속도 센서의 입력을 유니티 공간의 축에 매핑한다
         	vector.x = Input.acceleration.x;
            vector.z = Input.acceleration.y;
			if (Input.GetButton("Fire1"))
	        {
				vector.y = Speed;
	        }
	        else
	        {
				vector.y = -Speed;
	        }
        }
        //  씬의 중력을 입력 벡터의 방향에 맞추어 변화시킨다
        Physics.gravity = Gravity * vector.normalized * gravityScale;
	}
}
