using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour
{
  public float txtimer = 0.0f;
  private int resultFlg = 0;
  public GameObject resultObject;
  public Text resultText;
  // Start is called before the first frame update
  void Start()
  {
    resultObject.SetActive(false);
  }

  // Update is called once per frame
  void Update()
  {
    if (resultFlg==1 & txtimer <= 0.1f){
      resultObject.SetActive(false);
      txtimer = 1.0f;
      resultFlg = 0;
    } else if (txtimer > 0.1f){
      txtimer -= Time.deltaTime;
    }
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Single") {
      resultText.color =Color.green;
      resultText.text="　　　ヒット！";
      resultObject.SetActive(true);
      resultFlg=1;
      txtimer=1.0f;
      }else if (collision.gameObject.tag == "Double") {
        resultText.color =Color.blue;
        resultText.text="　 ツーベース！";
        resultObject.SetActive(true);
        resultFlg=1;
        txtimer=1.0f;
        }else if (collision.gameObject.tag == "Triple") {
          resultText.color =Color.magenta;
          resultText.text="　スリーベース！!";
          resultObject.SetActive(true);
          resultFlg=1;
          txtimer=1.0f;
          }else if (collision.gameObject.tag == "Homerun") {
            resultText.color =Color.cyan;
            resultText.text="　ホームラン！！！";
            resultObject.SetActive(true);
            resultFlg=1;
            txtimer=1.0f;
            }else if (collision.gameObject.tag == "Fineplay") {
              resultText.color =Color.red;
              resultText.text="ファインプレー！！";
              resultObject.SetActive(true);
              resultFlg=1;
              txtimer=1.0f;
              }else if (collision.gameObject.tag == "Defense") {
                resultText.color =Color.red;
                resultText.text="　    アウト！";
                resultObject.SetActive(true);
                resultFlg=1;
                txtimer=1.0f;
                }else if (collision.gameObject.tag == "Foul") {
                  if(OutCount.strikeOut==1){
                    resultText.color =Color.red;
                    resultText.text="　    三振！";
                    resultObject.SetActive(true);
                    resultFlg=1;
                    txtimer=1.0f;
                  }else{
                    resultText.color =Color.yellow;
                    resultText.text="　　　ファール！";
                    resultObject.SetActive(true);
                    resultFlg=1;
                    txtimer=1.0f;
                  }
                }
              }
            }
