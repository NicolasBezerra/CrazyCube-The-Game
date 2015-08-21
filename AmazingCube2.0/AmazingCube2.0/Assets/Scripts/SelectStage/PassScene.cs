using UnityEngine;
using System.Collections;

public class PassScene : MonoBehaviour 
{
    private FadeScript CamS;
	void Start () 
    {
        CamS = GameObject.Find("Camera").GetComponent<FadeScript>();
	}
	void Update () 
    {

	}
    void OnMouseDown()
    {
        switch(Application.loadedLevel)
        {
            case 3:

            break;
        }
        if(Application.loadedLevel == 3 && CamS.FadeIn == false && CamS.FadeOut == false)
        {
            CamS.FadeIn = true;
            CamS.scene = "SelectStage2";
        }
        else if (Application.loadedLevel == 8 && CamS.FadeIn == false && CamS.FadeOut == false)
        {
            if (gameObject.name == "Back")
            {
                CamS.scene = "SelectStage";
            }
            else
            {
                CamS.scene = "SelectStage3";
            }
            CamS.FadeIn = true;
            
        }
        else if (Application.loadedLevel == 9 && CamS.FadeIn == false && CamS.FadeOut == false)
        {
            if (gameObject.name == "Back")
            {
                CamS.scene = "SelectStage2";
            }
            else
            {
                CamS.scene = "SelectStage4";
            }
            CamS.FadeIn = true;
        }
        else if (Application.loadedLevel == 10 && CamS.FadeIn == false && CamS.FadeOut == false)
        {
            if (gameObject.name == "Back")
            {
                CamS.scene = "SelectStage3";
            }
            else
            {
                CamS.scene = "SelectStage5";
            }
            CamS.FadeIn = true;
        }
        else if (Application.loadedLevel == 11 && CamS.FadeIn == false && CamS.FadeOut == false)
        {
            if (gameObject.name == "Back")
            {
                CamS.scene = "SelectStage4";
            }
            else
            {
                CamS.scene = "SelectStage6";
            }
            CamS.FadeIn = true;
        }
        else if (Application.loadedLevel == 12 && CamS.FadeIn == false && CamS.FadeOut == false)
        {
            if (gameObject.name == "Back")
            {
                CamS.scene = "SelectStage5";
            }
            else
            {
                CamS.scene = "SelectStage7";
            }
            CamS.FadeIn = true;
        }
        else if (Application.loadedLevel == 13 && CamS.FadeIn == false && CamS.FadeOut == false)
        {
            if (gameObject.name == "Back")
            {
                CamS.scene = "SelectStage6";
            }
            else
            {
                CamS.scene = "SelectStage8";
            }
            CamS.FadeIn = true;
        }
        else if (Application.loadedLevel == 14 && CamS.FadeIn == false && CamS.FadeOut == false)
        {
            if (gameObject.name == "Back")
            {
                CamS.scene = "SelectStage7";
            }
            else
            {
                CamS.scene = "SelectStage9";
            }
            CamS.FadeIn = true;
        }
        else if (Application.loadedLevel == 15 && CamS.FadeIn == false && CamS.FadeOut == false)
        {
            if (gameObject.name == "Back")
            {
                CamS.scene = "SelectStage8";
            }
            CamS.FadeIn = true;
        }
    }
}
