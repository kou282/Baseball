using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runnershow : MonoBehaviour
{
  public GameObject FirstRunner;
  public GameObject SecondRunner;
  public GameObject ThirdRunner;
    // Start is called before the first frame update
    void Start()
    {
      FirstRunner.SetActive(false);
      SecondRunner.SetActive(false);
      ThirdRunner.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      switch(Runner.RunnerStatus){
        case 0:
         FirstRunner.SetActive(false);
         SecondRunner.SetActive(false);
         ThirdRunner.SetActive(false);
         break;
        case 1:
         FirstRunner.SetActive(true);
         SecondRunner.SetActive(false);
         ThirdRunner.SetActive(false);
         break;
        case 2:
         FirstRunner.SetActive(false);
         SecondRunner.SetActive(true);
         ThirdRunner.SetActive(false);
         break;
        case 3:
         FirstRunner.SetActive(true);
         SecondRunner.SetActive(true);
         ThirdRunner.SetActive(false);
         break;
        case 4:
         FirstRunner.SetActive(false);
         SecondRunner.SetActive(false);
         ThirdRunner.SetActive(true);
         break;
        case 5:
         FirstRunner.SetActive(true);
         SecondRunner.SetActive(false);
         ThirdRunner.SetActive(true);
         break;
        case 6:
         FirstRunner.SetActive(false);
         SecondRunner.SetActive(true);
         ThirdRunner.SetActive(true);
         break;
        case 7:
         FirstRunner.SetActive(true);
         SecondRunner.SetActive(true);
         ThirdRunner.SetActive(true);
         break;
      }
    }
}
