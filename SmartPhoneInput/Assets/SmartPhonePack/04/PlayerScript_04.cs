using UnityEngine;
using System.Collections;

public class PlayerScript_04 : MonoBehaviour {

	public Vector3 fromPos;
	public Vector3 toPos;
	public Light _light;
	public float speed = 4f;
	public bool flag = false;
	public float timer = 0f;

	
	// Update is called once per frame
	void Update () {
		if(flag){
			//向いてる方向に進む
			transform.position += transform.up * speed * Time.deltaTime;
			timer += Time.deltaTime;
			if(timer > 0.7f){
				flag = false;
				_light.intensity = 0f;
				timer = 0f;
			}
		}
		//手を画面に触れた時に座標を保存
		if(Input.GetMouseButtonDown(0)){
			fromPos = Input.mousePosition;
		}
		if(Input.GetMouseButton(0)){
			toPos = Input.mousePosition;
			//dx,dyをtoPos - fromPosで計算
			float dx = toPos.x - fromPos.x;
			float dy = toPos.y - fromPos.y;
			//距離を中２で習う三平方で算出
			float distance = Mathf.Sqrt( dx * dx + dy * dy );
			//dx、dyを使った三角比からアークタンジェントをつかい角度を算出
			float direction = ( Mathf.Atan2 (dy ,dx) / Mathf.PI * -180f );
			//使っている画像に合わせて角度を変える　（今回のPlayerは０度の時上を向いているのと　ドラッグした反対の方向に向くようにしているのでちょっと複雑）
			transform.eulerAngles = new Vector3(0,0,(360f - direction) -90f + 180f);
			//ドラッグした距離で光の光量を変える
			_light.intensity = 8.0f * (distance / 100f);
		}
		//手を画面からを離した時に引っ張りアクション
		if(Input.GetMouseButtonUp(0)){
			speed = (_light.intensity / 8.0f) * 4f;
			_light.intensity = 0f;
			flag = true;
		}
	}
}
