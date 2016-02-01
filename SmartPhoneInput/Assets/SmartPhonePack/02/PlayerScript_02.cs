using UnityEngine;
using System.Collections;

public class PlayerScript_02 : MonoBehaviour {

	public float moveRangeX = 10f;
	public float moveRangeY = 10f;

	// Update is called once per frame
	void Update () {
		//画面を触ってる間
		if(Input.GetMouseButton(0)){
			//触ってるX座標を取得し画面の横幅で割　１００％表記　で出す
			float posX =   Input.mousePosition.x / Screen.width;
			//触ってるY座標を取得し画面の縦幅で割　１００％表記　で出す
			float posY =   Input.mousePosition.y / Screen.height;
			//moveRangeを元に動かす　（注意：Playerが座標0,0にいることを想定してる！！　移動してる場合はOffSetなど設定すること！！）
			posX = posX * moveRangeX - moveRangeX / 2.0f;
			posY = posY * moveRangeY - moveRangeY / 2.0f;
			transform.position = new Vector3(posX, posY, 0.0f);
			//計算した座標をtransform.positionに入れる
		}
	}
}
