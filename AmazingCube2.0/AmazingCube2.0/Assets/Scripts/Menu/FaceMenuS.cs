using UnityEngine;
using System.Collections;

public class FaceMenuS : MonoBehaviour 
{
    private CubeMScript cor;
	void Start () 
    {

        if (Application.loadedLevel == 0 || Application.loadedLevel == 4 || Application.loadedLevel == 5 || Application.loadedLevel == 6)
        {
            cor = GameObject.Find("CubeM").GetComponent<CubeMScript>();
        }
        else
        {
            gameObject.renderer.material = Resources.Load("Materials/CubeWhite", typeof(Material)) as Material;
        }
        
        switch (cor.color)
        {
            case 0:
                gameObject.renderer.material = Resources.Load("Materials/CubeGreen", typeof(Material)) as Material;
                break;
            case 1:
                gameObject.renderer.material = Resources.Load("Materials/CubeRed", typeof(Material)) as Material;
                break;
            case 2:
                gameObject.renderer.material = Resources.Load("Materials/CubeOrange", typeof(Material)) as Material;
                break;
            case 3:
                gameObject.renderer.material = Resources.Load("Materials/CubeYellow", typeof(Material)) as Material;
                break;
            case 4:
                gameObject.renderer.material = Resources.Load("Materials/CubeBlue", typeof(Material)) as Material;
                break;
            case 5:
                gameObject.renderer.material = Resources.Load("Materials/CubeWhite", typeof(Material)) as Material;
                break;
        }
    }
	
	void Update () 
    {
        
	}
}
