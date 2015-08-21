using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TimeScript : MonoBehaviour 
{
    private float Seconds;
    public int TotalTime;
    public Text TimeCounter;
	private LevelControl Can;
    public GameObject Botton;
    public char D;
    public char U;
    public char C;
	void Start () 
    {
    	if(Application.loadedLevel != 7)
    	{
	        Seconds = 0;
	        TotalTime = 0;
	        
	        TimeCounter = GameObject.Find("Time").GetComponent<Text>();
	    }
	}
	
	void Update () 
    {
        if (Botton.transform.localScale != new Vector3((Screen.width / 13333.3f) * 2.2f, (Screen.height / 15000f) * 3.3f, transform.localScale.z))
        {
            Botton.transform.localScale = new Vector3((Screen.width / 13333.3f) * 2.2f, (Screen.height / 15000f) * 3.3f, transform.localScale.z);
        }
		if(Application.loadedLevel != 7)
		{
	    	if(Can == null)
	    	{
				Can = GameObject.Find("LevelController").GetComponent<LevelControl>();
			}
	    	if(Can != null && Can.CanPlay)
	    	{
				Seconds += Time.deltaTime;
				if (Seconds >= 1) 
				{
					Seconds = 0;
					TotalTime += 1;
				}
	            if(TotalTime < 10)
	            {
	                TimeCounter.text = TotalTime.ToString();
	            }
		        else if(TotalTime < 100)
	            {
	                string Blood = TotalTime.ToString();
	                U = Blood[1];
	                D = Blood[0];
	                TimeCounter.text = D + " " + U;
	            }
	            else
	            {
	                string Blood = TotalTime.ToString();
	                U = Blood[2];
	                D = Blood[1];
	                C = Blood[0];
	                TimeCounter.text = C + " " + D + " " + U;
	            }
	    	}
    	}
    }
}
