using UnityEngine;
using System.Collections;

public class Hold : MonoBehaviour
{



	void OnTriggerStay(Collider other) {
				for (uint i = 0; i < 2; i++) {
						if (SixenseInput.Controllers [i].Trigger == 1.0f) {
								if (other.gameObject.tag == "fourchette")
										other.transform.position = transform.position;

						}
				}
		}
	 
}