using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using HighlightingSystem;
public class NewBehaviourScript : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler {

   public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("enter");
        GetComponent<Highlighter>().ConstantOn();
    }
  public  void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("exit");
        GetComponent<Highlighter>().ConstantOff();
    }
}
