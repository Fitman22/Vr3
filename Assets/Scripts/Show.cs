using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Show: MonoBehaviour
{
   [SerializeField]string message;
   [SerializeField] float speedShow;
   public void startText()=>StartCoroutine(writeText(0));
   public void startImage()=>StartCoroutine(showImage(0));
   IEnumerator writeText(int i){
    GetComponent<TextMeshProUGUI>().text+= message.ToCharArray()[i];
    i++;
    yield return new WaitForSeconds(speedShow);
   if(i<message.ToCharArray().Length) StartCoroutine(writeText(i));
   }
    IEnumerator showImage(float i){
    GetComponent<RawImage>().color= new Color(255f,255f,255f,i/255);
    i+=2;
    yield return new WaitForSeconds(speedShow);
   if(i<255) StartCoroutine(showImage(i));
   }
}
