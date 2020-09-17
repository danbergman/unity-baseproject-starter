using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventsSingleton : MonoBehaviour
{
    public static GameEventsSingleton current;

    private void Awake()
    {
        current = this;
    }

    public event Action OnDoorwayTriggerEnter;
    public event Action OnDoorwayTriggerExit;

    public void DoorwayTriggerEnter()
    {
        OnDoorwayTriggerEnter?.Invoke();
    }     

    public void DoorwayTriggerExit()
    {
        OnDoorwayTriggerExit?.Invoke();
    }
}
