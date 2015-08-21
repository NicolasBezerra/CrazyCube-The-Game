using UnityEngine;
using System.Collections;

public class GerenciatorCanvas : MonoBehaviour 
{
	private FadeScript CamS;
	void Start()
	{
		CamS = GameObject.Find("Camera").GetComponent<FadeScript>();
	}

    void OnMouseDown()
    {
        Menu();
        Jogo();
        Creditos();
        Sair();
    }

	public void Menu()
	{
		if(CamS.FadeIn == false && CamS.FadeOut == false && gameObject.name == "Menu")
		{
			CamS.scene = "Menu";
			CamS.FadeIn = true;
		}
	}
	public void Jogo()
	{
        if (CamS.FadeIn == false && CamS.FadeOut == false && gameObject.name == "Jogo" && PlayerPrefs.GetInt("LevelMax") < 1)
		{
			CamS.FadeIn = true;
            CamS.scene = "Intro";
		}
        else if(CamS.FadeIn == false && CamS.FadeOut == false && gameObject.name == "Jogo")
        {
            CamS.FadeIn = true;
            CamS.scene = "SelectStage";
        }
	}
	public void Creditos()
	{
        if (CamS.FadeIn == false && CamS.FadeOut == false && gameObject.name == "Creditos")
		{
			CamS.FadeIn = true;
            CamS.scene = "Creditos";
		}
	}
    public void Sair()
    {
        if(gameObject.name == "Saida")
        {
			CamS.FadeIn = true;
			CamS.scene = "Sair";
        }
    }
}
