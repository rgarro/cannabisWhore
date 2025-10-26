using System.Globalization;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *  ________________________
 * |.----------------------.|
 * ||                      ||
 * ||                      ||
 * ||     .-"````"-.       ||
 * ||    /  _.._    `\     ||
 * ||   / /`    `-.   ; . .||
 * ||   | |__  __  \   |   ||
 * ||.-.| | e`/e`  |   |   ||
 * ||   | |  |     |   |'--||
 * ||   | |  '-    |   |   ||
 * ||   |  \ --'  /|   |   ||
 * ||   |   `;---'\|   |   ||
 * ||   |    |     |   |   ||
 * ||   |  .-'     |   |   ||
 * ||'--|/`        |   |--.||
 * ||   ;    .     ;  _.\  ||
 * ||    `-.;_    /.-'     ||
 * ||         ````         ||
 * ||jgs___________________||
 * '------------------------'
 * Boundary Wall Behavior will reposition to return val on trigger origin tag
 * 
 *
 *@author Rolando <rgarro@gmail.com>
 */
public class boundaryBehavior : MonoBehaviour
{
    public string originTag = "m4a";
    public float returnX = 716.5f;
    public float returnY = 6.5f;
    public float returnZ = 72.6f;

    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

     private void OnTriggerEnter(Collider other){
        //Debug.Log("Checking boundary collision:"+other.gameObject.tag);
        if(other.gameObject.tag == this.originTag){
            Vector3 targetPosition = new Vector3(this.returnX,this.returnY,this.returnZ);
            other.gameObject.transform.position = targetPosition;
            //Debug.Log("teleporteo a reurn");
        }
     }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
