using UnityEngine;
using System.Collections;

public class EventRoutine : MonoBehaviour {

  public GameObject[] events;
  public Transform[] eventsPosition;

  private Object[] activatedEvents;

  private float timer = 0;
  private int currentIndex= 0;

  static int DELAY = 7;


  void Update(){
    Debug.Log(timer);
    if ((timer += Time.deltaTime) > DELAY && currentIndex < events.Length) {
      timer = 0.0f;
      AddEvent();
      
      currentIndex++;
    }
  }
	
  private void AddEvent() {
    
      Debug.Log("New event");
      GameObject o = Instantiate(events[currentIndex], eventsPosition[currentIndex].position, eventsPosition[currentIndex].rotation) as GameObject;
      Debug.Log("Activé : " + currentIndex);

      if (o.tag == "pakpak") {
        o.audio.Play();
      }

      Destroy(o, 4); 
  }

}
