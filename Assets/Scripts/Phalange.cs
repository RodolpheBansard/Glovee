using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phalange : MonoBehaviour
{
    private enum PhalangeObject
    {
        thumb1,
        thumb2,
        thumb3,
        index1,
        index2,
        index3,
        middle1,
        middle2,
        middle3,
        ring1,
        ring2,
        ring3,
        pinky1,
        pinky2,
        pinky3,
    };
    [SerializeField] PhalangeObject phalange = PhalangeObject.index1;

    private SerialManager serialManager;
    private float[] fingersRotations;
    

    private void Start()
    {
        serialManager = FindObjectOfType<SerialManager>();
        StartCoroutine(readRotation());   
    }
    IEnumerator readRotation()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.02f);
            fingersRotations = serialManager.GetFingersRotation();

            if (phalange == PhalangeObject.thumb1)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[0],fingersRotations[1],fingersRotations[2]);
                //Debug.Log(transform.localEulerAngles);
            }
            else if (phalange == PhalangeObject.thumb2)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[3], fingersRotations[4], fingersRotations[5]);
            }
            else if (phalange == PhalangeObject.thumb3)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[6], fingersRotations[7], fingersRotations[8]);
            }
            else if (phalange == PhalangeObject.index1)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[9], fingersRotations[10], fingersRotations[11]);
            }
            else if (phalange == PhalangeObject.index2)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[12], fingersRotations[13], fingersRotations[14]);
            }
            else if (phalange == PhalangeObject.index3)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[15], fingersRotations[16], fingersRotations[17]);
            }
            else if (phalange == PhalangeObject.middle1)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[18], fingersRotations[19], fingersRotations[20]);
            }
            else if (phalange == PhalangeObject.middle2)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[21], fingersRotations[22], fingersRotations[23]);
            }
            else if (phalange == PhalangeObject.middle3)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[24], fingersRotations[25], fingersRotations[26]);
            }
            else if (phalange == PhalangeObject.ring1)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[27], fingersRotations[28], fingersRotations[29]);
            }
            else if (phalange == PhalangeObject.ring2)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[30], fingersRotations[31], fingersRotations[32]);
            }
            else if (phalange == PhalangeObject.ring3)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[33], fingersRotations[34], fingersRotations[35]);
            }
            else if (phalange == PhalangeObject.pinky1)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[36], fingersRotations[37], fingersRotations[38]);
            }
            else if (phalange == PhalangeObject.pinky2)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[39], fingersRotations[40], fingersRotations[41]);
            }
            else if (phalange == PhalangeObject.pinky3)
            {
                transform.localEulerAngles = new Vector3(fingersRotations[42], fingersRotations[43], fingersRotations[44]);
            }


        }
        
    }
}
