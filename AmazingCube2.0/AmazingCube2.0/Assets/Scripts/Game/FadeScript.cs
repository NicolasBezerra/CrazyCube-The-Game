using UnityEngine;
using System.Collections;

public class FadeScript : MonoBehaviour 
{
	private byte R;
	private byte G;
	private byte B;
	private byte A;
	public bool FadeIn;
	public bool FadeOut;
    public string scene;
	public GameObject MyBlock;
	private GerenciatorCanvas CanvasS;
	
	void Start () 
	{
		R = 0;
		G = 0;
		B = 0;
		A = 255;
		FadeIn = false;
		FadeOut = true;
	}
	
	void Update () 
	{
		if(CanvasS == null)
		{
			try
			{
				CanvasS = GameObject.Find("Canvas").GetComponent<GerenciatorCanvas>();
			}
			catch
			{
			
			}
		}
		MyBlock.renderer.material.color = new Color32(R,G,B,A);
		if(FadeOut && A > 0)
		{
			A -= 17;
		}
		else
		{
            MyBlock.SetActive(false);
			FadeOut = false;
		}
        if(scene != null)
        {
            MyBlock.SetActive(true);
        }
		//if(CanvasS != null)
		{
			if(FadeIn && A < 255)
			{
				A += 17;
			}
			else if(scene != null)
			{
				FadeIn = false;
				switch(scene)
				{
					case "Menu":
						Application.LoadLevel (0);
                        scene = null;
					break;
					
					case "Jogo":
						Application.LoadLevel (1);
                        scene = null;
                    break;
					
					case "Creditos":
						Application.LoadLevel (2);
                        scene = null;
					break;
                    case "SelectStage":
                        Application.LoadLevel(3);
                        scene = null;
                    break;
                    case "SelectStage2":
                        Application.LoadLevel(8);
                        scene = null;
                    break;
                    case "SelectStage3":
                        Application.LoadLevel(9);
                        scene = null;
                    break;
                    case "SelectStage4":
                        Application.LoadLevel(10);
                        scene = null;
                    break;
                    case "SelectStage5":
                        Application.LoadLevel(11);
                        scene = null;
                    break;
                    case "SelectStage6":
                        Application.LoadLevel(12);
                        scene = null;
                    break;
                    case "SelectStage7":
                        Application.LoadLevel(13);
                        scene = null;
                    break;
                    case "SelectStage8":
                        Application.LoadLevel(14);
                        scene = null;
                    break;
                    case "SelectStage9":
                        Application.LoadLevel(15);
                        scene = null;
                    break;
                    case "Lost":
                        Application.LoadLevel(4);
                        scene = null;
                    break;
                    case "Victory":
                        Application.LoadLevel(5);
                        scene = null;
                    break;
                    case "Manutencao":
                        Application.LoadLevel(6);
                        scene = null;
                    break;
                    case "Intro":
                    	Application.LoadLevel(7);
                        scene = null;
                    break;
                    case "Sair":
                    	Application.Quit();
                        scene = null;
                    break;
				}
			}
		}
	}
}
