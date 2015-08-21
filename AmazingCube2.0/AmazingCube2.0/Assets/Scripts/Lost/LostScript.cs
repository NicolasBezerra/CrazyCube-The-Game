using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LostScript : MonoBehaviour
{
    public Text Limit;
    private FadeScript CamS;
    void Start()
    {
        CamS = GameObject.Find("Camera").GetComponent<FadeScript>();
        if (Limit != null)
        {
            Limit.text = "Tempo Limite: " + PlayerPrefs.GetInt("Limite") + " segundos";
        }
    }
    void OnMouseDown()
    {
        if (gameObject.name == "SelecaoDeFases")
        {
            CamS.FadeIn = true;
            CamS.scene = "SelectStage";
        }
        else if (gameObject.name == "VoltarAoMenu")
        {
            CamS.FadeIn = true;
            CamS.scene = "Menu";
        }
    }
    void Update()
    {
        
    }
}
