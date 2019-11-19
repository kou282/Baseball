using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverText : MonoBehaviour
{
  public GameObject GameOver;
  public GameObject reStart;
  public GameObject EndGame;
    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
        reStart.SetActive(false);
        EndGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if(OutCount.outCount==3){
        GameOver.SetActive(true);
        reStart.SetActive(true);
        EndGame.SetActive(true);
      }
    }
}
