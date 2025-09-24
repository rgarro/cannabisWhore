using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* '\
*        _\______
*       /        \========
*  ____|__________\_____
* / ___________________ \
* \/ _===============_ \/
*   "-===============-"
*Operation Market Garden
*  XXX Armored Group 
* La Tanqueta tenia un pioneer subia la moral ...
*
*
*
*@author Rolando <rgarro@gmail.com>
*/
public class turretController : MonoBehaviour
{

    public GameObject oddBallSpot;
    private AudioSource servoSoundPlayer;

    public float rotationSteps = 3.014f;
    //public GameObject TheTurret;
    //private AudioSource servoSoundPlayer;
	public AudioClip servoSoundClip;
    private float tetha = 0.00f;//the angle
    
    // Start is called before the first frame update
    void Start()
    {
        this.servoSoundPlayer = GetComponent<AudioSource>();
        this.tetha = this.oddBallSpot.transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
