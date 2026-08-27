using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents instance;

    public event Action onDoorTriggerEnter;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
   
    public void OpenTriggerDoor()
    {
        onDoorTriggerEnter();
    }
}
