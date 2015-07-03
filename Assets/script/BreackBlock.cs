using UnityEngine;
using System.Collections;

public class BreackBlock : MonoBehaviour {

	public Vector3 position;
	private GameObject breackBlock;
	public bool activeRotation;
	public static bool Move;
	public GameObject puzzle;

	// Use this for initialization

	void Start() {

		Move = true;
		breackBlock = GameObject.FindGameObjectWithTag("breack");
		puzzle = GameObject.FindGameObjectWithTag("largou");
		position = breackBlock.transform.position;
		activeRotation = true;
	}

	void OnTriggerStay(Collider collider){
		if (collider.gameObject.tag.Equals("breack")) {
			activeRotation = false;
			transform.position = collider.transform.position;
			transform.rotation = Quaternion.identity;
		}
		if (collider.gameObject.tag.Equals("lixo")) {
			Destroy(this.gameObject);

		}
	}

	void OnTriggerExit(Collider collider){
		if (breackBlock.collider) {
			activeRotation = true;
		}
	}

	  

	public void Rotation(){
		transform.Rotate (Vector3.right);
		transform.Rotate (Vector3.up, Space.World);
	}

	void Update(){
		if(activeRotation){
			Rotation();
		}
	
		if(Move && this.gameObject.tag.Equals("blocoMove"))this.transform.position -= new Vector3 (0.09f ,0f,0f );
		if (this.transform.position.x < -11) {
			Destroy(this.gameObject);

		}
	}
}