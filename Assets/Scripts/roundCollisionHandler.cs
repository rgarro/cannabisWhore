using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *     _.-^^---....,,--       
 * _--                  --_  
 *<                        >)
 *|                         | 
 * \._                   _./  
 *    ```--. . , ; .--'''       
 *          | |   |             
 *       .-=||  | |=-.   
 *       `-=#$%&%$#=-'   
 *          | ;  :|     
 * _____.,-#%&$@%#&#~,._____
 *
 * === Will remove collided and trigger blast or visual effect ===
 *   Includes Score Counter
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class roundCollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/
    
    private void OnTriggerEnter(Collider other)
    {
         Debug.Log("Collision detected+++  ");
         Debug.Log("Collision detected  "+other.gameObject.name);
    }
    

    /*void OnCollisionEnter(Collision collision){
        Debug.Log("Collision detected with: " + collision.gameObject.name);
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("Still colliding with: " + collision.gameObject.name);
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Stopped colliding with: " + collision.gameObject.name);
    }*/

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
