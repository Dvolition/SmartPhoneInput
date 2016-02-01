using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	//使うUIを関連付け
	public Slider _slider;
	public Image _image01;
	public Image _image02;
	public Image _image03;
	public Image _image04;
	public Dropdown _dropdown;
	public Text _text;

	// Update is called once per frame
	void Update () {
		//Dropdownは上からの順でint型で選んでいるセルの番号を取得
		if(_dropdown.value == 0){
			//タイマー作動中
			_slider.value -= Time.deltaTime;
		}
		_text.text = _slider.value.ToString("F1");
		//imageのパーセンテージを削る
		_image01.fillAmount = _slider.value /_slider.maxValue;
		_image02.fillAmount = _slider.value /_slider.maxValue;
		_image03.fillAmount = _slider.value /_slider.maxValue;
		_image04.fillAmount = _slider.value /_slider.maxValue;

	
	}
}
