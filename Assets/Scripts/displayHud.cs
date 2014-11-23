using UnityEngine;
using System.Collections;

public class displayHud : MonoBehaviour{
	public GameObject cylindre;
	public GameObject scoreBoard;

	public float health;
	public static float maxHealth = 100f;
	public float healthWidth;
	public float healthMaxWidth = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		float newScale = health*healthMaxWidth/maxHealth;
		Debug.Log(health/healthMaxWidth);
		cylindre.transform.localScale = new Vector3(newScale,cylindre.transform.localScale.y,cylindre.transform.localScale.z);
	}

	/*void OnGUI(){
		
		if (GUI.Button (new Rect (40,100,200,20), "Increment healths")) {
                incrementHealth(-5);
        }

	}*/

	//adds or remove some health --> if health < 0 after test, returns 0
	// use this returns 0 to switch to a gameover screen

	
	public int incrementHealth(int value){
			
			float tempDiff;
			
			if ((health+value) <= maxHealth && ((health+value) >= 0)){
			
				health += value;
			}
			else if ((health+value) >= maxHealth){
			
				tempDiff = (health+value)-maxHealth;
	
				//health += tempDiff;
			}
			else if ((health+value) < 0){
				
				return 1;
			}
			return 0;
			

	}
}
