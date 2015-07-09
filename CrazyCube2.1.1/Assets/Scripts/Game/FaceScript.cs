using UnityEngine;
using System.Collections;

public class FaceScript : MonoBehaviour 
{
	private CreatorBlocks CatchColor;
	public int ActualColor;
	void Start () 
	{
        CatchColor = GameObject.Find("Creator").GetComponent<CreatorBlocks>();
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
				gameObject.renderer.material = Resources.Load ("Materials/CubeBlue", typeof(Material)) as Material;
				break;
			case 2:
				gameObject.renderer.material = Resources.Load ("Materials/CubeGreen", typeof(Material)) as Material;;
				break;
			case 3:
				gameObject.renderer.material = Resources.Load ("Materials/CubeYellow", typeof(Material)) as Material;;
				break;
			case 4:
				gameObject.renderer.material = Resources.Load ("Materials/CubeRed", typeof(Material)) as Material;;
				break;
			case 5:
				gameObject.renderer.material = Resources.Load ("Materials/CubeWhite", typeof(Material)) as Material;;
				break;
			case 6:
				gameObject.renderer.material = Resources.Load ("Materials/CubeOrange", typeof(Material)) as Material;;
				break;
		}
	}
}
