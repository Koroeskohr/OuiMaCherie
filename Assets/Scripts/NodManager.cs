using UnityEngine;
using System.Collections;


public class NodManager : MonoBehaviour {
	public GameObject cameraRig;
	static public int nod;
	private float lastRotationX, lastRotationY, rotationX, rotationY;
	private int firstRotationX, firstRotationY, secondRotationX, secondRotationY;
	private char[] pattern;
	private int i;

	void Start () {
		firstRotationX = secondRotationX = firstRotationY = secondRotationY = nod = 0;
		pattern = new char[3];
		i = 0;
	}

	void Update () {
		rotationX = cameraRig.transform.eulerAngles.x - lastRotationX;
		rotationY = cameraRig.transform.eulerAngles.y - lastRotationY;

		int treshold = 5;

		if (rotationX > treshold && rotationX < 200 && Mathf.Abs(rotationX) > Mathf.Abs(rotationY)) {
			
			pattern[i] = 'd';
			if(i > 0 && pattern[i-1] == 'd') { }
			else
			{
				i++;
			}

		} 
		else if (rotationX < -treshold && Mathf.Abs(rotationX) > Mathf.Abs(rotationY)) {
			pattern[i] = 'u';
			if(i > 0 && pattern[i-1] == 'u') {	}
			else
			{
				i++;
			}

		}
		if (rotationY > treshold && rotationX < 200 && Mathf.Abs(rotationY) > Mathf.Abs(rotationX)) {
			
			pattern[i] = 'r';
			if(i > 0 && pattern[i-1] == 'r') {	}
			else
			{
				i++;
			}

		} else if (rotationY < -treshold && Mathf.Abs(rotationY) > Mathf.Abs(rotationX)) {
			
			pattern[i] = 'l';
			if(i > 0 && pattern[i-1] == 'l') {	}
			else
			{
				i++;
			}
		}
		
		if(i == 3) {
			if((pattern[0] == 'u' && pattern[1] == 'd' && pattern[2] == 'u')
			|| (pattern[0] == 'd' && pattern[1] == 'u' && pattern[2] == 'd'))
			{
				i = 0;
				Debug.Log("YES");
				nod = 1;
			}
			else if((pattern[0] == 'l' && pattern[1] == 'r' && pattern[2] == 'l')
			|| (pattern[0] == 'r' && pattern[1] == 'l' && pattern[2] == 'r'))
			{
				i = 0;
				Debug.Log("NO");
				nod = 1;
			}
			else
			{
				pattern[0] = pattern[1];
				pattern[1] = pattern[2];
				i--;
			}
		}

		lastRotationX = cameraRig.transform.eulerAngles.x;
		lastRotationY = cameraRig.transform.eulerAngles.y;
	}
}
