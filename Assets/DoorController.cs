using UnityEngine;
using DG.Tweening;

public class DoorController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameEvents.instance.onDoorTriggerEnter += OpenDoor;
    }

    private void OnDisable()
    {
        GameEvents.instance.onDoorTriggerEnter -= OpenDoor;
    }

    private void OnDestroy()
    {
        GameEvents.instance.onDoorTriggerEnter -= OpenDoor;
    }

    void OpenDoor()
    {
        //transform.Translate(new Vector3(0, 2, 0));
        transform.DOMoveY(3, 2);
    }
}
