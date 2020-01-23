using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;

public class SerialManager : MonoBehaviour
{
    [SerializeField] string chaine = "COM6";

    SerialPort serialPort;

    private float[] fingersRotations = new float[45];
    private int[] servoEnable = new int[5];
    private string data;


    // Start is called before the first frame update
    void Start()
    {
        serialPort = new SerialPort(chaine, 115200);
        serialPort.Parity = Parity.None;
        serialPort.DataBits = 8;
        serialPort.StopBits = StopBits.One;
        serialPort.Open();
        serialPort.ReadTimeout = 15;

        for(int i=0; i<5; i++)
        {
            servoEnable[i] = 0;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (serialPort.IsOpen)
        {
            try
            {
                data = "data";
                data += " " + servoEnable[0] + " " + servoEnable[1] + " " + servoEnable[2] + " " + servoEnable[3] + " " + servoEnable[4];
                serialPort.Write(data);
                string[] rotations = serialPort.ReadLine().Split(null);

                for(int i = 0; i<rotations.Length; i++)
                {
                    fingersRotations[i] = float.Parse(rotations[i].Replace(".",","));
                }
                
            }
            catch (System.Exception)
            {
                //Debug.Log("something");
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

    public void SetServoEnable(int index, int etat) 
    {
        servoEnable[index] = etat;
    }
}
