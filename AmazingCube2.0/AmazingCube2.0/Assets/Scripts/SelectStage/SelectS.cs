using UnityEngine;
using System.Collections;

public class SelectS : MonoBehaviour 
{
    private FadeScript CamS;
	void Start () 
    {
        CamS = GameObject.Find("Camera").GetComponent<FadeScript>();
	}
    void OnMouseDown()
    {
        if (CamS.FadeIn == false && CamS.FadeOut == false && GameObject.Find("L" + gameObject.name) == null && gameObject.name == "6")
        {
            CamS.FadeIn = true;
            CamS.scene = "Manutencao";
        }
        else if (CamS.FadeIn == false && CamS.FadeOut == false && GameObject.Find("L" + gameObject.name) == null)
        {
            PlayerPrefs.SetInt("Level", int.Parse(gameObject.name));
            CamS.FadeIn = true;
            CamS.scene = "Jogo";
        }
    }
	void Update () 
    {
	
	}
}
