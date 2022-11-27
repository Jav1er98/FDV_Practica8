using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Cameras : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera vcamA;

    public CinemachineVirtualCamera vcamC;

    //public NoiseSettings noise;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad1))
        {
            vcamA.Priority = 1;
            vcamC.Priority = 0;
        }
        else if (Input.GetKey(KeyCode.Keypad2))
        {
            vcamA.Priority = 0;
            vcamC.Priority = 1;
        }
      /*  if (Input.GetKey(KeyCode.E))
        {
            vcamA.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_NoiseProfile = noise;
        }
        else { 
            vcamA.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_NoiseProfile = null;
        }*/
    }
}
