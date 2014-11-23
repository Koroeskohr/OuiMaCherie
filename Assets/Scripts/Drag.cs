using UnityEngine;

using System.Collections;

public class Drag : MonoBehaviour { 

  public float power = 500;

  void OnMouseDown() {
    rigidbody.AddForce(Vector3.right * power);
  }
 
} 
