using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int id;
    private void Start()
    {
        GameEvents.current.onDoorwayTriggerEnter += OnDoorOpen;
        GameEvents.current.onDoorwayTriggerExit += OnDoorClose;
    }

    private void OnDoorOpen(int id)
    {
        if (id == this.id)
        {
            Debug.Log("Open");
            Vector3 Pos = transform.position;
            Pos.y = 15.67f;
            transform.position = Pos;
        }
    }
    private void OnDoorClose(int id)
    {
        if (id == this.id)
        {
            Debug.Log("Close");
            Vector3 Pos = transform.position;
            Pos.y = 5.67f;
            transform.position = Pos;
        }
    }

    private void OnDestroy()
    {
        GameEvents.current.onDoorwayTriggerEnter -= OnDoorOpen;
        GameEvents.current.onDoorwayTriggerExit -= OnDoorClose;
    }

}
