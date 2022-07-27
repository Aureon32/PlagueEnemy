using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findobject : MonoBehaviour
{ 
    
    void Update()
    {
        
    }
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ingridient")
        {
            Destroy(other.gameObject);
        }
    }
}
