using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objet : MonoBehaviour
{
    SerialManager serialManager;
    [SerializeField] int servo;


    void Start()
    {
        serialManager = FindObjectOfType<SerialManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        serialManager.SetServoEnable(servo, 1);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        serialManager.SetServoEnable(servo, 0);
    }
}
