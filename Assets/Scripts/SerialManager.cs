using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;

public class SerialManager : MonoBehaviour
{
    private string chaine = "COM6";
    SerialPort serialPort;

    private float[] fingersRotations = new float[45];


    // Start is called before the first frame update
    void Start()
    {
        serialPort = new SerialPort(chaine, 115200);
        serialPort.Parity = Parity.None;
        serialPort.DataBits = 8;
        serialPort.StopBits = StopBits.One;
        serialPort.Open();
        serialPort.ReadTimeout = 15;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (serialPort.IsOpen)
        {
            try
            {               
                string[] rotations = serialPort.ReadLine().Split(null);

                for(int i = 0; i<rotations.Length; i++)
                {
                    fingersRotations[i] = float.Parse(rotations[i].Replace(".",","));
                }
                
            }
            catch (System.Exception)
            {
                Debug.Log("something");
            }
        }
    }

    private void OnDestroy()
    {
        serialPort.Close();
    }

    public float[] GetFingersRotation()
    {
        return fingersRotations;

    }    
}
