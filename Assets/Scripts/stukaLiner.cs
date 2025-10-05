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
//Debug.Log("sadam hussein hanging on sad hill ...");
		yield return new WaitForSeconds (startWait);
		while(true){
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (this.rangeValueLeft,rangeValueRight), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				spawnRotation.z = this.zRotation;
				Instantiate (hazard, spawnPosition, spawnRotation);
				
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}
