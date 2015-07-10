using UnityEngine;
using System.Collections;

public class catchBlock : MonoBehaviour {

	private Vector3 screenPoint ;
	public Vector3 curPosition;
	private Vector3 scanPos;
	private Vector3 offset;
	private GameObject eu;
	private Instanciador CatchColor;

	void Start()
	{
		CatchColor = GameObject.Find("GameObject").GetComponent<Instanciador>();
	}
	void Update (){
		scanPos = transform.position;
		transform.position = new Vector3 (transform.position.x,transform.position.y, transform.position.z);
	}
	void OnMouseDown() { 
		screenPoint = Camera.main.WorldToScreenPoint(scanPos);

		offset = scanPos - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}
	void OnMouseDrag() {
		CatchColor.Catching = true;
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
		transform.position = curPosition;
		this.transform.gameObject.tag = "blocoUsing";
		
	}
	void OnMouseUp() 
	{
		CatchColor.Mycolor = gameObject.renderer.material;
		CatchColor.coloca = true;
		this.transform.gameObject.tag = "blocoExit";
	}
}


