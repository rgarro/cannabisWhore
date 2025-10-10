using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
*       '\
*        _\______
*       /        \========
*  ____|__________\_____
* / ___________________ \
* \/ _===============_ \/
*   "-===============-"
* Operation Market Garden
*    XXX Armored Group 
* La Tanqueta tenia un pioneer, subia la moral ...
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
    
	public AudioClip servoSoundClip;
   
    private float tetha = 0.00f;//the angle

    public GameObject barrelPipe;//This gun is an ordinary 76mm but we add this piece of pipe onto it, and the Krauts think, like, maybe it's a 90mm
    public float maxBarrelElevation = -76.00f;
    public float minBarrelElevation = -92.00f;

    private float barrelsElevationY;
    public float elevationSteps = 0.37f;

    // Start is called before the first frame update
    void Start()
    {
        this.barrelsElevationY = this.barrelPipe.transform.rotation.y;
        this.servoSoundPlayer = GetComponent<AudioSource>();
        this.tetha = this.oddBallSpot.transform.rotation.z;
    }

 private void playServoSoundOn(){
        this.servoSoundPlayer.clip = this.servoSoundClip;
        if (!this.servoSoundPlayer.isPlaying) {
            this.servoSoundPlayer.Play ();
        }
    }

     private void leftArrowAction(){
        //Debug.Log("left turret action ...");
        this.playServoSoundOn();
        this.tetha = this.oddBallSpot.transform.rotation.z + this.rotationSteps;
         this.oddBallSpot.transform.Rotate(0,0,this.tetha);
    }
    private void rightArrowAction(){
        //Debug.Log("right turret action ...");
        this.playServoSoundOn();
        this.tetha = this.oddBallSpot.transform.rotation.z - this.rotationSteps;
        this.oddBallSpot.transform.Rotate(0,0,this.tetha);
        
    }

    private void shoot(){
        Debug.Log("fusible del disparador, lleva relay remoto desde el control command vehicle ");
        //Crazy... I mean like, so many positive waves... maybe we can't lose, you're on!
    }

    private void elevateBarrel(String elevation = "UP"){//up yours baby ...
    Debug.Log("barrel elev:"+elevation);
        //Quaternion rotation = Quaternion.Euler(this.barrelsObj.transform.localRotation.x,this.barrelsObj.transform.localRotation.y,this.barrelsObj.transform.localRotation.z);
        if(elevation == "UP"){
            this.playServoSoundOn();
            Debug.Log("barrelY:"+this.barrelsElevationY);
            this.barrelsElevationY = Mathf.Abs(this.barrelsElevationY) + this.elevationSteps;
		    this.barrelPipe.transform.Rotate(0,0,this.barrelsElevationY);
        }
        if(elevation == "DOWN"){
            Debug.Log("barrelY:"+this.barrelsElevationY);
            this.barrelsElevationY = (Mathf.Abs(this.barrelsElevationY) + this.elevationSteps)*-1;
            this.barrelPipe.transform.Rotate(0,0,this.barrelsElevationY);
        }
    }

    private void keyListeners(){
        if (Input.GetKeyDown(KeyCode.G))
        {
            this.rightArrowAction();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            this.leftArrowAction();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.elevateBarrel("UP");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            this.elevateBarrel("DOWN");
        }
         if (Input.GetKeyDown(KeyCode.Space))
        {
            this.shoot();
        }
    }
    // Update is called once per frame
    void Update()
    {
        this.keyListeners();
    }
}
