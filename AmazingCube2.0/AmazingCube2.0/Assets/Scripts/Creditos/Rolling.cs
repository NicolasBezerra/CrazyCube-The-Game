using UnityEngine;
using System.Collections;

public class Rolling : MonoBehaviour 
{
    private float Counter;
    private FadeScript CamS;
	void Start () 
    {
        Counter = 0;
        CamS = GameObject.Find("Camera").GetComponent<FadeScript>();
	}	
	void Update () 
    {
        
        if(gameObject.transform.position.y < 20)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 0.03f, transform.position.z);
        }
        else
        {
            Counter += Time.deltaTime;
            if(Counter > 2)
            {
                CamS.FadeIn = true;
                CamS.scene = "Menu";
            }
        }
	}
}
