using UnityEngine;
using System.Collections;

public class PlayerScript_03 : MonoBehaviour {

	public Rigidbody2D _rigidbody;
	public float jumpPower = 8.0f;

	// Use this for initialization
	void Start () {
		//Rigidbody2Dゲット！！
		_rigidbody = transform.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)){
			Jump(); //メソッド呼び出し！！
		}
	}

	//ジャンプするメソッド
	void Jump(){
		_rigidbody.velocity = Vector3.up * jumpPower;
	}
}
