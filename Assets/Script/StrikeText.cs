using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeText : MonoBehaviour
{
  public GameObject oneStrike;
  public GameObject twoStrike;
  public GameObject threeStrike;
    // Start is called before the first frame update
    void Start()
    {
      oneStrike.SetActive(false);
      twoStrike.SetActive(false);
      threeStrike.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if(OutCount.strikeCount==1){
        oneStrike.SetActive(true);
      }else if(OutCount.strikeCount==2){
        twoStrike.SetActive(true);
      }else if(OutCount.strikeCount==3){
        threeStrike.SetActive(true);
      }else if(OutCount.strikeCount==0){
        oneStrike.SetActive(false);
        twoStrike.SetActive(false);
        threeStrike.SetActive(false);
      }
    }
}
