using UnityEngine;
using System.Collections;

public class VerifyColor : MonoBehaviour 
{
    private ColorDefault FacesMini;
    private ColorDefault FacesBig;
    private GameObject[] FacesToMini;
    private GameObject[] FacesToBig;
    private float counter;
    private float counterToWin;
    private int i;
    private int j;
    private int ToWin;
    private int Star;
    private LevelControl MainLevel;
    private FadeScript FadeS;
    private TimeScript TempoS;
    void Start() 
    {
        Star = 0;
        TempoS = GameObject.Find("Canvas").GetComponent<TimeScript>();
    	try
    	{
	    	MainLevel = GameObject.Find("LevelController").GetComponent<LevelControl>();
	        counterToWin = 0;
	        counter = 0;
	        j = 0;
	        i = 0;
	        ToWin = 0;
	        FacesMini = GameObject.Find("MiniCube").GetComponent<ColorDefault>();
	        FacesBig = GameObject.Find("CubeM").GetComponent<ColorDefault>();
	        FacesToMini = FacesMini.Faces;
	        FacesToBig = FacesBig.Faces;
	     }
	     catch
	     {
	     
	     }
	}
	void Update () 
    {
		if (Application.loadedLevel != 7) {
			switch (MainLevel.Level) {
			case 1:
				if (TempoS.TotalTime >= 10) {
					TempoS.TimeCounter.color = new Color32 (255, 0, 0, 255);
				}
				if (TempoS.TotalTime == 15) {
					PlayerPrefs.SetInt ("Limite", 15);
					FadeS.FadeIn = true;
					FadeS.FadeOut = false;
					FadeS.scene = "Lost";
				}
				break;
			case 2:
				if (TempoS.TotalTime >= 15) {
					TempoS.TimeCounter.color = new Color32 (255, 0, 0, 255);
				}
				if (TempoS.TotalTime == 20) {
					PlayerPrefs.SetInt ("Limite", 20);
					FadeS.FadeIn = true;
					FadeS.FadeOut = false;
					FadeS.scene = "Lost";
				}
				break;
			case 3:
				if (TempoS.TotalTime >= 20) {
					TempoS.TimeCounter.color = new Color32 (255, 0, 0, 255);
				}
				if (TempoS.TotalTime == 25) {
					PlayerPrefs.SetInt ("Limite", 25);
					FadeS.FadeIn = true;
					FadeS.FadeOut = false;
					FadeS.scene = "Lost";
				}
				break;
			case 4:
				if (TempoS.TotalTime >= 25) {
					TempoS.TimeCounter.color = new Color32 (255, 0, 0, 255);
				}
				if (TempoS.TotalTime == 30) {
					PlayerPrefs.SetInt ("Limite", 30);
					FadeS.FadeIn = true;
					FadeS.FadeOut = false;
					FadeS.scene = "Lost";
				}
				break;
			case 5:
				if (TempoS.TotalTime >= 30) {
					TempoS.TimeCounter.color = new Color32 (255, 0, 0, 255);
				}
				if (TempoS.TotalTime == 35) {
					PlayerPrefs.SetInt ("Limite", 35);
					FadeS.FadeIn = true;
					FadeS.FadeOut = false;
					FadeS.scene = "Lost";
				}
				break;
			}
		}
        if(FadeS == null)
        {
            FadeS = GameObject.Find("Camera").GetComponent<FadeScript>();
        }
        if(counter > 2f)
        {
            if(FacesToBig[i].renderer.material.mainTexture == FacesToMini[i].renderer.material.mainTexture)
            {
                if(i < 53)
                {
                    i++;
                }
                else
                {
                    counterToWin += Time.deltaTime;
                    for (int l = 0; l < 54; l++)
                    {
                        if (FacesToBig[l].renderer.material.mainTexture == FacesToMini[l].renderer.material.mainTexture)
                        {
                            j++;
                            if(j == 53 && l == 53)
                            {
                                ToWin = 0;
                                i = 0;
                                j = 0;
                            }
                            else if(counterToWin > 0.5f)
                            {
                                ToWin += 1;
                                i = 0;
                                j = 0;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            counter += Time.deltaTime;
        }
        if(ToWin >= 1)
        {
            PlayerPrefs.SetInt("LastTime", TempoS.TotalTime);
            MainLevel.CanPlay = false;
			if(Application.loadedLevel != 7)
			{
	            switch(MainLevel.Level)
	            {
	                case 1:
	                    
	                    if (TempoS.TotalTime <= (5*MainLevel.Level))
	                    {
	                        Star = 3;
	                    }
	                    else if (TempoS.TotalTime > (5 * MainLevel.Level) && TempoS.TotalTime <= (5 * MainLevel.Level * 2))
	                    {
	                        Star = 2;
	                    }
	                    else
	                    {
	                        Star = 1;
	                    }
	                break;
	                case 2:
	                    if (TempoS.TotalTime <= (5 * MainLevel.Level))
	                    {
	                        Star = 3;
	                    }
	                    else if (TempoS.TotalTime > (5 * MainLevel.Level) && TempoS.TotalTime <= (5 * MainLevel.Level * 1.5f))
	                    {
	                        Star = 2;
	                    }
	                    else
	                    {
	                        Star = 1;
	                    }
	                break;
	                case 3:
	                    if (TempoS.TotalTime <= (5 * MainLevel.Level))
	                    {
	                        Star = 3;
	                    }
	                    else if (TempoS.TotalTime > (5 * MainLevel.Level) && TempoS.TotalTime <= (5 * MainLevel.Level * 1.5f))
	                    {
	                        Star = 2;
	                    }
	                    else
	                    {
	                        Star = 1;
	                    }
	                break;
	                case 4:
	                    if (TempoS.TotalTime <= (5 * MainLevel.Level))
	                    {
	                        Star = 3;
	                    }
	                    else if (TempoS.TotalTime > (5 * MainLevel.Level) && TempoS.TotalTime <= (5 * MainLevel.Level * 1.5f))
	                    {
	                        Star = 2;
	                    }
	                    else
	                    {
	                        Star = 1;
	                    }
	                break;
	                case 5:
	                    if (TempoS.TotalTime <= (5 * MainLevel.Level))
	                    {
	                        Star = 3;
	                    }
	                    else if (TempoS.TotalTime > (5 * MainLevel.Level) && TempoS.TotalTime <= (5 * MainLevel.Level * 1.5f))
	                    {
	                        Star = 2;
	                    }
	                    else
	                    {
	                        Star = 1;
	                    }
	                break;
	            }
			}
			if (PlayerPrefs.GetInt("Points" + (MainLevel.Level - 1)) < Star && Application.loadedLevel != 7)
            {
                PlayerPrefs.SetInt("Points" + (MainLevel.Level -1), Star);
            }
            PlayerPrefs.SetInt("LastStar", Star);
            
        	PlayerPrefs.SetInt("Level",MainLevel.Level+1);
            if(PlayerPrefs.GetInt("Level") > PlayerPrefs.GetInt("LevelMax") && Application.loadedLevel != 7)
            {
                PlayerPrefs.SetInt("LevelMax", PlayerPrefs.GetInt("Level"));
            }
            FadeS.FadeIn = true;
            FadeS.FadeOut = false;
			if(Application.loadedLevel != 7)
			{
            	FadeS.scene = "Victory";
			}
			else
			{
				PlayerPrefs.SetInt("Level", 1);
				PlayerPrefs.SetInt("LevelMax", 1);
				for (int l = 0; l < 6; l++ )
				{
				    PlayerPrefs.SetInt("Points"+l, 0);
				}
				FadeS.scene = "SelectStage";
			}
			ToWin = 0;
            i = 0;
            j = 0;
            counterToWin = 0;
        }
	}
}
