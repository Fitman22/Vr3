using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActiveEvents : MonoBehaviour
{
   [SerializeField] UnityEvent events = new UnityEvent();

    public void callEvents(){
        if(events==null)return;
            events.Invoke();
            events=null;
    }
}
