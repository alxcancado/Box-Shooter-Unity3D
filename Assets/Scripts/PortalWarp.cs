using UnityEngine;
using System.Collections;

public class PortalWarp : MonoBehaviour {

	public float height = 50f;
	public Transform target;

	void Awake(){

		//transform.LookAt(target);

	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "CheckPoint") {

			if (GameManager.gm) {
				if (!GameManager.gm.gameIsOver) {
					this.transform.position = new Vector3(transform.position.x, height, transform.position.z);
				} else {

					this.transform.position = new Vector3(transform.position.x, 2f, transform.position.z);
					other.gameObject.GetComponent<BoxCollider>().isTrigger = false;

				}
			}


		}

	}

}
