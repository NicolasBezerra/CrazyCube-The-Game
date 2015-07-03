using UnityEngine;
using System.Collections;

public class FaceScript : MonoBehaviour 
{
	private Vector3 screenPoint ;
	public catchBlock BlockS;
	public Instanciador CatchColor;
	private Vector3 scanPos;
	private bool alreadyColored = false;

	void Start () 
	{
		CatchColor = GameObject.Find("GameObject").GetComponent<Instanciador>();
	}
	
	void OnMouseUp() 
	{
		if (CatchColor.Catching && !alreadyColored) {
			gameObject.renderer.material.color = CatchColor.Mycolor;
			CatchColor.Catching = false;
			alreadyColored = true;
		}
	}
	void Update () 
	{


	}
}
