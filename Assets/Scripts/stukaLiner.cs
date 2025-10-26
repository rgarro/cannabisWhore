using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
 *  ------
 *  | | # \                                      |
 *  | ____ \_________|----^"|"""""|"\___________ |
 *    \___\   FO + 94 >>    `""""""""     =====  "|D
 *         ^^-------____--""""""""""+""--_  __--"|
 *                     `""|"-->####)+---|`""     |
 *                                \  \
 *                               <- O -)
 *                                `"'
 *    Will Spawn enemies on a horizontal rect to travel vertically
 *   
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class stukaLiner : MonoBehaviour
{
    public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	//public float distanceFromSpanwnX = 100; 
	public GUISkin btnSkin;
	public float rangeValueLeft = -6f;
	public float rangeValueRight = 6f;
	public float zRotation = 0.0f;
	public float rangeValueTop = -6f;
	public float rangeValueBottom = 6f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("starting coroutine");
		StartCoroutine(spawnWaves());

    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    IEnumerator spawnWaves(){
Debug.Log("starting wave spawner ...");
		yield return new WaitForSeconds (this.startWait);
		//while(true){
			for (int i = 0; i < this.hazardCount; i++) {
Debug.Log("stuka#"+i);				
				//Vector3 spawnPosition = new Vector3 (Random.Range (this.rangeValueLeft,rangeValueRight), spawnValues.y, spawnValues.z);
				Vector3 spawnPosition = new Vector3 (Random.Range (this.rangeValueLeft,this.rangeValueRight), this.spawnValues.y,Random.Range (this.rangeValueTop,this.rangeValueBottom));
				Quaternion spawnRotation = Quaternion.identity;
				spawnRotation.z = this.zRotation;
				Instantiate (this.hazard, spawnPosition, spawnRotation);
				
				yield return new WaitForSeconds (this.spawnWait);
			}
			yield return new WaitForSeconds (this.waveWait);//axis foil yelling in the downwind ...
		//}
	}
}
