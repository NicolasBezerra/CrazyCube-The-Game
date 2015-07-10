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
			renderer.material = CatchColor.Mycolor;
		}
	
	}
	void Update () 
	{
		switch(ActualColor)
		{
			case 1:
				gameObject.renderer.material = Resources.Load ("CubeBlue", typeof(Material)) as Material;
				break;
			case 2:
				gameObject.renderer.material = Resources.Load ("CubeGreen", typeof(Material)) as Material;;
				break;
			case 3:
				gameObject.renderer.material = Resources.Load ("CubeYellow", typeof(Material)) as Material;;
				break;
			case 4:
				gameObject.renderer.material = Resources.Load ("CubeRed", typeof(Material)) as Material;;
				break;
			case 5:
				gameObject.renderer.material = Resources.Load ("CubeWhite", typeof(Material)) as Material;;
				break;
			case 6:
				gameObject.renderer.material = Resources.Load ("CubeOrange", typeof(Material)) as Material;;
				break;
		}
	}
}
