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
    void Start() 
    {
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
	void Update () 
    {
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
        if(ToWin >= 5)
        {
            Application.LoadLevel(0);
            ToWin = 0;
            i = 0;
            j = 0;
            counterToWin = 0;
        }
	}
}
