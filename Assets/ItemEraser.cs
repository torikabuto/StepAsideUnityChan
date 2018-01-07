using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEraser : MonoBehaviour {

	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//Unityちゃんとカメラの距離
	private float difference;

	// Use this for initialization
	void Start () {
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
		//Unityちゃんとカメラの位置（Z座標）の差を求める
		this.difference = unitychan.transform.position.z - this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		//Unityちゃんの位置に合わせてカメラの位置を移動
		this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z-difference);
		
	}
     //ItemEraserと障害物が接触した際障害物を破棄
      void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficCornTag") {
			Destroy (other.gameObject);
		} else if (other.gameObject.tag == "CoinTag") {
			Destroy (other.gameObject);
		}
		
}
}