using UnityEngine;

public class TriggerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameEvents.instance.OpenTriggerDoor();
    }
}
