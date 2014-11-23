using UnityEngine;
using System.Collections;

public class UneFemmeCaParleTropScript : MonoBehaviour {

  public GameObject fille;
  public AudioClip[] clips;
  private int[] reponses = {-1,1,1,1,-1};
  public int currentI = 0;

  private float timer =0;
  private float timerAns =0;
  private bool questionAsked = false;
  private bool hasAnswered = false;
  private bool isRight = false;
  private bool firstQ = true;
	
  void Update(){
    timer += Time.deltaTime;
    Debug.Log(timer);
    timerAns += Time.deltaTime;
    
    if ((questionAsked && hasAnswered) || (timerAns > 8.0f && firstQ == true)) {
      checkWinner();
      firstQ = false;
      timerAns=0;
    }
    if (timer >= 10){
      LaFilleElleParle();
      timer = 0;
    }

    checkAnswer();
  }

  void LaFilleElleParle(){
    questionAsked = true;
    timerAns = 0;
    if (currentI <= 4) {
      fille.audio.clip = clips[currentI];
      Debug.Log(currentI + " : " + clips[currentI]);
    }
    fille.audio.Play();
    currentI++;
  }

  void checkAnswer(){
    int j;
    if (currentI != 0) j = currentI - 1;
    else j = 0;

    int answer = YesNoListener.finalNod;
    Debug.Log("Réponse : " + answer);
    if (reponses[j] == answer) //vertical
    {
      //jauge augmente
      isRight = true;
      hasAnswered = true;
    }
    else if (answer == 0){
      //jauge descend
      hasAnswered = false;
    }
    else if (reponses[j] != answer ){
      //jauge descendù
      hasAnswered = true;
      isRight = false;
    }
  }

  void checkWinner(){
    if(isRight) {
      //jauge augmente
      Debug.Log("Gagné");
      //incrementHealth(30);

    }
    else {
      Debug.Log("Perdu");
      //jauge descend
    }

    isRight = false;
  }
}
