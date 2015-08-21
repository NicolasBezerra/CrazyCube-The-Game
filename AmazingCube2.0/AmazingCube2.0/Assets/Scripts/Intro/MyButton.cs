using UnityEngine;
using System.Collections;

public class MyButton : MonoBehaviour 
{
    private GerenciatorString MyS;
	void Start () 
    {
        MyS = GameObject.Find("Intro").GetComponent<GerenciatorString>();
	}
	void Update () 
    {
	}
    void OnMouseDown()
    {
        if (gameObject.name == "Back")
        {
            MyS.j += 1;
            if (MyS.j > 3)
            {
                MyS.j = 0;
            }
        }
        else
        {
            MyS.j -= 1;
            if (MyS.j < 0)
            {
                MyS.j = 3;
            }
        }
    }
}
