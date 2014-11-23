using UnityEngine;
using System.Collections;

public class PakpakGetOut : MonoBehaviour {
  public GameObject ovr;

	void OnTriggerEnter(Collider other) {
    if(other.gameObject.tag == "pakpak") {

      Destroy(other.gameObject);
      ovr.audio.Play();


    }
  }
}
