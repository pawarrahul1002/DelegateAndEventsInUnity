using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;

    private void OnTriggerEnter(Collider other)
    {
        // DoorWayTriggerEnter(int id);
        GameEvents.current.DoorWayTriggerEnter(id);
    }
    private void OnTriggerExit(Collider other)
    {
        GameEvents.current.DoorWayTriggerExit(id);
    }
}
