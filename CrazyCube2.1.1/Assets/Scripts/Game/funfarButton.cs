using UnityEngine;
using System.Collections;

public class funfarButton : MonoBehaviour {

	public void indoParaOjogo(){

		Application.LoadLevel (1);

	}

	public void indoParaOmenu(){
		
		Application.LoadLevel (0);
		
	}

	public void indoParaOcreditos(){
		
		Application.LoadLevel (2);
		
	}

}
