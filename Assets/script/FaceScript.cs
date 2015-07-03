using UnityEngine;
using System.Collections;

public class FaceScript : MonoBehaviour 
{
	private Vector3 screenPoint ;
	public catchBlock BlockS;
	public Instanciador CatchColor;
	private Vector3 scanPos;
	void Start () 
	{
		CatchColor = GameObject.Find("GameObject").GetComponent<Instanciador>();
	}
	
	void OnMouseUp() 
	{
		
	}
	void Update () 
	{
		scanPos = transform.position;
		screenPoint = Camera.main.WorldToScreenPoint(scanPos);
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		if(curScreenPoint == transform.position && Input.GetMouseButtonUp(1) && CatchColor.Catching)
		{
			gameObject.renderer.material.color = CatchColor.Mycolor;
		}
		/*try
		{
			if(GameObject.FindGameObjectWithTag("blocoUsing") != null)
			{
				BlockS = GameObject.FindGameObjectWithTag("blocoUsing").GetComponent<catchBlock>();
			}
		}
		catch
		{
		
		
		}*/
	}
}
