using System;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    public event Action<int> onDoorwayTriggerEnter;
    public event Action<int> onDoorwayTriggerExit;

    private void Awake()
    {
        current = this;
    }

    public void DoorWayTriggerEnter(int id)
    {
        // OnDoorwayTriggerEnter?.Invoke(id);
        if (onDoorwayTriggerEnter != null)
        {
            onDoorwayTriggerEnter(id);
        }
    }
    public void DoorWayTriggerExit(int id)
    {
        // OnDoorwayTriggerExit?.Invoke(id);
        if (onDoorwayTriggerExit != null)
        {
            onDoorwayTriggerExit(id);
        }
    }

}
