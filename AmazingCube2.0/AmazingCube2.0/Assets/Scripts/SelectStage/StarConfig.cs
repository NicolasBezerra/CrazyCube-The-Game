using UnityEngine;
using System.Collections;

public class StarConfig : MonoBehaviour 
{
    public GameObject[] Stars;
    public SpriteRenderer[] ImageStars;
    public int[] ID;
	void Start () 
    {
        ID = new int[6];
	}	
	void Update () 
    {
        for (int i = 0; i < ID.Length; i++)
        {
            switch(Application.loadedLevel)
            {
                case 3:
                    if (PlayerPrefs.GetInt("Points" + i) != null)
                    {
                        ID[i] = PlayerPrefs.GetInt("Points" + i);
                        ImageStars[i].sprite = Resources.Load("Sprites/Estrelas_" + ID[i], typeof(Sprite)) as Sprite;
                    }
                    break;
                case 8:
                    if (PlayerPrefs.GetInt("Pointss" + i) != null)
                    {
                        ID[i] = PlayerPrefs.GetInt("Pointss" + i);
                        ImageStars[i].sprite = Resources.Load("Sprites/Estrelas_" + ID[i], typeof(Sprite)) as Sprite;
                    }
                    break;
                case 9:
                    if (PlayerPrefs.GetInt("Pointsss" + i) != null)
                    {
                        ID[i] = PlayerPrefs.GetInt("Pointsss" + i);
                        ImageStars[i].sprite = Resources.Load("Sprites/Estrelas_" + ID[i], typeof(Sprite)) as Sprite;
                    }
                    break;
                case 10:
                    if (PlayerPrefs.GetInt("Pointssss" + i) != null)
                    {
                        ID[i] = PlayerPrefs.GetInt("Pointssss" + i);
                        ImageStars[i].sprite = Resources.Load("Sprites/Estrelas_" + ID[i], typeof(Sprite)) as Sprite;
                    }
                    break;
                case 11:
                    if (PlayerPrefs.GetInt("Pointsssss" + i) != null)
                    {
                        ID[i] = PlayerPrefs.GetInt("Pointsssss" + i);
                        ImageStars[i].sprite = Resources.Load("Sprites/Estrelas_" + ID[i], typeof(Sprite)) as Sprite;
                    }
                    break;
                case 12:
                    if (PlayerPrefs.GetInt("Pointssssss" + i) != null)
                    {
                        ID[i] = PlayerPrefs.GetInt("Pointssssss" + i);
                        ImageStars[i].sprite = Resources.Load("Sprites/Estrelas_" + ID[i], typeof(Sprite)) as Sprite;
                    }
                    break;
                case 13:
                    if (PlayerPrefs.GetInt("Pointsssssss" + i) != null)
                    {
                        ID[i] = PlayerPrefs.GetInt("Pointsssssss" + i);
                        ImageStars[i].sprite = Resources.Load("Sprites/Estrelas_" + ID[i], typeof(Sprite)) as Sprite;
                    }
                    break;
                case 14:
                    if (PlayerPrefs.GetInt("Pointssssssss" + i) != null)
                    {
                        ID[i] = PlayerPrefs.GetInt("Pointssssssss" + i);
                        ImageStars[i].sprite = Resources.Load("Sprites/Estrelas_" + ID[i], typeof(Sprite)) as Sprite;
                    }
                    break;
                case 15:
                    if (PlayerPrefs.GetInt("Pointsssssssss" + i) != null)
                    {
                        ID[i] = PlayerPrefs.GetInt("Pointsssssssss" + i);
                        ImageStars[i].sprite = Resources.Load("Sprites/Estrelas_" + ID[i], typeof(Sprite)) as Sprite;
                    }
                    break;
            }
        }
         
	}
}
