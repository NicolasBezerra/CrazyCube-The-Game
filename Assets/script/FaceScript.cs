using UnityEngine;
using System.Collections;

public class FaceScript : MonoBehaviour 
{
	
	private Vector3 screenPoint ;
	public catchBlock BlockS;
	public Instanciador CatchColor;
	private Vector3 scanPos;
	public int ActualColor;
	//private bool alreadyColored = false;

	void Start () 
	{
		
		CatchColor = GameObject.Find("GameObject").GetComponent<Instanciador>();
	}
	
	void OnMouseOver() 
	{
		if (CatchColor.Catching && CatchColor.coloca) 
		{
			CatchColor.coloca = false;
			CatchColor.Catching = false;
			gameObject.renderer.material.color = CatchColor.Mycolor;
		}
	
	}
	void Update () 
	{
		switch(ActualColor)
		{
			case 1:
				gameObject.renderer.material.color = Color.blue;
				break;
			case 2:
				gameObject.renderer.material.color = Color.green;
				break;
			case 3:
				gameObject.renderer.material.color = Color.yellow;
				break;
			case 4:
				gameObject.renderer.material.color = Color.red;
				break;
		}
	}
}
