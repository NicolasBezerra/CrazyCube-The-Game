using UnityEngine;
using System.Collections;

public class catchBlock : MonoBehaviour {

	private Vector3 screenPoint ;
	private Vector3 scanPos;
	private Vector3 offset;
	private GameObject eu;


	void Update (){
		scanPos = transform.position;
		transform.position = new Vector3 (transform.position.x,transform.position.y, transform.position.z);
	}
	void OnMouseDown() { 
		screenPoint = Camera.main.WorldToScreenPoint(scanPos);
		offset = scanPos - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}
	void OnMouseDrag() {
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
		transform.position = curPosition;
		this.transform.gameObject.tag = "blocoUsing";
	}
	void OnMouseUp() {
		this.transform.gameObject.tag = "blocoUsing";
	}
}


