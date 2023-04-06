using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    public GameObject instruction1;
    public GameObject instruction2;
     void Awake()
    {
        instruction1.SetActive(true); 
        instruction2.SetActive(false); 
    }

    private void OnTriggerEnter(Collider instruction)
    {
        if(instruction.gameObject.tag == "Player")
        {
            instruction1.SetActive(false);
            instruction2.SetActive(true);          
        }
    }

    
}
