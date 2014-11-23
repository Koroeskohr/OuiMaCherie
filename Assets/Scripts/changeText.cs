using UnityEngine;
using System.Collections;



public class changeText : MonoBehaviour {
public GameObject subtitle;
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
	
		
	}

	void changeSubtitle(string newText){
		TextMesh t = (TextMesh)subtitle.GetComponent(typeof(TextMesh));
		t.text = newText;
	}

}
