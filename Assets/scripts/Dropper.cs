using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
     void Update()
    {
        int timer = 3;

        if (Time.time > timer)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }   
           
            
     }
    
        
}
