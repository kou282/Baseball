using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
  public static int RunnerStatus=0;
    // Start is called before the first frame update
    void Start()
    {
        RunnerStatus=0;
        Score.score=0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Single") {
      switch(RunnerStatus){
        case 0://ランナーなし
         RunnerStatus=1;
         break;
        case 1://ランナー１塁
         RunnerStatus=3;
         break;
        case 2://ランナー２塁
         RunnerStatus=5;
         break;
        case 3://ランナー１、２塁
         RunnerStatus=7;
        break;
        case 4://ランナー３塁
         Score.score+=1;
         RunnerStatus=1;
         break;
        case 5://ランナー１、３塁
         Score.score+=1;
         RunnerStatus=3;
         break;
        case 6://ランナー２、３塁
         Score.score+=1;
         RunnerStatus=5;
         break;
        case 7://ランナー満塁
         Score.score+=1;
         RunnerStatus=7;
         break;
      }
    }else if (collision.gameObject.tag == "Double") {
      switch(RunnerStatus){
        case 0://ランナーなし
         RunnerStatus=2;
         break;
        case 1://ランナー１塁
         RunnerStatus=6;
         break;
        case 2://ランナー２塁
         Score.score+=1;
         RunnerStatus=2;
         break;
        case 3://ランナー１、２塁
         Score.score+=1;
         RunnerStatus=6;
        break;
        case 4://ランナー３塁
         Score.score+=1;
         RunnerStatus=2;
         break;
        case 5://ランナー１、３塁
         Score.score+=1;
         RunnerStatus=6;
         break;
        case 6://ランナー２、３塁
         Score.score+=2;
         RunnerStatus=2;
         break;
        case 7://ランナー満塁
         Score.score+=2;
         RunnerStatus=6;
         break;
       }
      }else if (collision.gameObject.tag == "Triple") {
        switch(RunnerStatus){
          case 0://ランナーなし
           RunnerStatus=4;
           break;
          case 1://ランナー１塁
           Score.score+=1;
           RunnerStatus=4;
           break;
          case 2://ランナー２塁
           Score.score+=1;
           RunnerStatus=4;
           break;
          case 3://ランナー１、２塁
           Score.score+=2;
           RunnerStatus=4;
          break;
          case 4://ランナー３塁
           Score.score+=1;
           RunnerStatus=4;
           break;
          case 5://ランナー１、３塁
           Score.score+=2;
           RunnerStatus=4;
           break;
          case 6://ランナー２、３塁
           Score.score+=2;
           RunnerStatus=4;
           break;
          case 7://ランナー満塁
           Score.score+=3;
           RunnerStatus=4;
           break;
         }
    }
    else if (collision.gameObject.tag == "Homerun") {
      switch(RunnerStatus){
        case 0://ランナーなし
         Score.score+=1;
         RunnerStatus=0;
         break;
        case 1://ランナー１塁
         Score.score+=2;
         RunnerStatus=0;
         break;
        case 2://ランナー２塁
         Score.score+=2;
         RunnerStatus=0;
         break;
        case 3://ランナー１、２塁
         Score.score+=3;
         RunnerStatus=0;
        break;
        case 4://ランナー３塁
         Score.score+=2;
         RunnerStatus=0;
         break;
        case 5://ランナー１、３塁
         Score.score+=3;
         RunnerStatus=0;
         break;
        case 6://ランナー２、３塁
         Score.score+=3;
         RunnerStatus=0;
         break;
        case 7://ランナー満塁
         Score.score+=4;
         RunnerStatus=0;
         break;
       }
     }
   }
 }
