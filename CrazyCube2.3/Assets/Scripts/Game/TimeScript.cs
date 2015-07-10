using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour 
{
    private float Seconds;
    private int TotalTime;
    private Text TimeCounter;

	void Start () 
    {
        Seconds = 0;
        TotalTime = 0;
        TimeCounter = GameObject.Find("Time").GetComponent<Text>();
       // MyPos = GameObject.Find("Time").GetComponent<RectTransform>();
	}
	
	void Update () 
    {
        Seconds += Time.deltaTime;
        if(Seconds >= 1)
        {
            Seconds = 0;
            TotalTime += 1;
        }
        if (TotalTime > 99)
        {
          // MyPos.rect.left = -156;
        }
        else if(TotalTime > 9)
        {
            GameObject.Find("Time").transform.position = new Vector3(GameObject.Find("Time").transform.position.x - 2, GameObject.Find("Time").transform.position.y, GameObject.Find("Time").transform.position.z);
        }
        TimeCounter.text = TotalTime.ToString();
    }
}
