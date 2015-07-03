using UnityEngine;
using System.Collections;

public class DragColor : MonoBehaviour {
	
	private bool drag;
	public GameObject MyBlock;
	void Start () {
		drag = false;
	}
	
	void OnMouseDown()
	{
		MyBlock = gameObject;
		drag = true;
	}
	void Update () 
	{
		if(drag)
		{
			MyBlock.transform.position = Input.mousePosition;
		}
	}
}
