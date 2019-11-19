using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutText : MonoBehaviour
{
  public GameObject oneOut;
  public GameObject twoOut;
  public GameObject threeOut;
    // Start is called before the first frame update
    void Start()
    {
      oneOut.SetActive(false);
      twoOut.SetActive(false);
      threeOut.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if(OutCount.outCount==1){
        oneOut.SetActive(true);
      }else if(OutCount.outCount==2){
        twoOut.SetActive(true);
      }else if(OutCount.outCount==3){
        threeOut.SetActive(true);
      }
    }
}
