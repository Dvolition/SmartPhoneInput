using UnityEngine;
using System.Collections;

public class PlayerScript_01 : MonoBehaviour {

	public float moveRange = 10f;

	// Update is called once per frame
	void Update () {
		//画面を触ってる間
		if(Input.GetMouseButton(0)){
			//触ってるX座標を取得し画面の横幅で割　１００％表記　で出す
			float posX =   Input.mousePosition.x / Screen.width;
			//moveRangeを元に動かす　（注意：Playerが座標0,0にいることを想定してる！！　移動してる場合はOffSetなど設定すること！！）
			posX = posX * moveRange - moveRange / 2.0f;
			//計算した座標をtransform.positionに入れる
			transform.position = new Vector3(posX, 0.0f, 0.0f);
		}
	}
}
