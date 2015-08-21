using UnityEngine;
using System.Collections;

public class LevelControl : MonoBehaviour 
{
    public int Level;
    private int CounterToPrint;
    private ColorDefault FacesBig;
    private ColorDefault FacesMini;
    private int MyRandom;
	public bool CanPlay;
	void Start () 
    {
    	try
    	{
    		CanPlay = false;
	    	if(PlayerPrefs.GetInt("Level") == null || PlayerPrefs.GetInt("Level") == 0)
	    	{
	    		Level = 1;
	    	}
	    	else
	    	{
	    		Level = PlayerPrefs.GetInt("Level");
	    	}
	        MyRandom = Mathf.FloorToInt(Random.Range(0, 54));
	        FacesBig = GameObject.Find("CubeM").GetComponent<ColorDefault>();
	        FacesMini = GameObject.Find("MiniCube").GetComponent<ColorDefault>();
	        CounterToPrint = 0;
	    }
	    catch
	    {
	    
	    }
	}
	
	void Update () 
    {
		if(Application.loadedLevel == 7)
		{
			Level = 5;
		}
        if (PlayerPrefs.GetInt("Level") > PlayerPrefs.GetInt("LevelMax"))
        {
            PlayerPrefs.SetInt("LevelMax", PlayerPrefs.GetInt("Level"));
        }
        if (CounterToPrint < 54 - Level)
        {
            if (FacesBig.Faces[MyRandom].renderer.material.mainTexture == FacesMini.Faces[MyRandom].renderer.material.mainTexture)
            {
                MyRandom = Mathf.FloorToInt(Random.Range(0, 54));
            }
            else
            {
                FacesBig.Faces[MyRandom].renderer.material = FacesMini.Faces[MyRandom].renderer.material;
                CounterToPrint++;
            }
        }
		else
        {
        	CanPlay = true;
        }
	}
}
