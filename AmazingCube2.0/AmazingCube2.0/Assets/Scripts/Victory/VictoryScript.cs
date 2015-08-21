using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class VictoryScript : MonoBehaviour 
{
    public Text MyText;
    public SpriteRenderer MySprite;
	void Start () 
    {
        if (MyText != null)
        {
            MyText.text = "Seu Tempo: " + PlayerPrefs.GetInt("LastTime") + " segundos! Parabéns!";
        }
        MySprite = GameObject.Find("Estrelas_0").GetComponent<SpriteRenderer>();
        MySprite.sprite = Resources.Load("Sprites/Estrelas_" + PlayerPrefs.GetInt("LastStar"), typeof(Sprite)) as Sprite;
	}
	
	void Update () 
    {
	
	}
}
