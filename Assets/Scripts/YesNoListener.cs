using UnityEngine;
using System.Collections;

public class YesNoListener : MonoBehaviour {

  public GameObject nodManager;
  static public int finalNod;
	private bool used = false;

	// Update is called once per frame
	void Update () {

	   int a = NodManager.nod;
     if (a == 1){
        finalNod = 1;
        used = true;
     }
     else if (a == -1)
     {
        finalNod = -1;
        used = true;
      }
      else {
        finalNod = 0;
        used = false;
      }
	}
}
