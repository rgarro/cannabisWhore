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

    //This gun is an ordinary 76mm but we add this piece of pipe onto it, and the Krauts think, like, maybe it's a 90mm
    public GameObject barrelPipe;
    public float maxBarrelElevation = 3.00f;
    public float minBarrelElevation = -2.00f;

    private float barrelsElevationY;//Z rotation elevation
    public float elevationSteps = 0.37f;

    public GameObject roundObject;
    public int shoots = 0;
    public float correctionDegrees = -1.0f;
    public float yRoundRotationCorrectionDegrees = -1.0f;



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
        this.tetha = this.oddBallSpot.transform.rotation.z + (this.rotationSteps*Time.deltaTime);
         this.oddBallSpot.transform.Rotate(0,0,this.tetha);
    }
    private void rightArrowAction(){
        //Debug.Log("right turret action ...");
        this.playServoSoundOn();
        this.tetha = this.oddBallSpot.transform.rotation.z - (this.rotationSteps*Time.deltaTime);
        this.oddBallSpot.transform.Rotate(0,0,this.tetha);
        
    }

    private void shoot(){
        //Debug.Log("test shoot ...");
        Vector3 spawnPosition = new Vector3 (this.oddBallSpot.transform.position.x,this.oddBallSpot.transform.position.y,this.oddBallSpot.transform.position.z);
        Quaternion spawnRotation = Quaternion.Euler(this.barrelPipe.transform.localEulerAngles.y,this.oddBallSpot.transform.localEulerAngles.z-this.correctionDegrees,0);
        Instantiate (roundObject, spawnPosition, spawnRotation);
    }

    private void elevateBarrel(String elevation = "UP"){
        //Debug.Log("barrel elev:"+elevation);//up yours baby ...
        if(elevation == "UP"){
            this.barrelsElevationY = Mathf.Abs(this.barrelsElevationY) + this.elevationSteps;
            if(this.maxBarrelElevation > this.barrelsElevationY){
                this.playServoSoundOn();
                this.barrelPipe.transform.Rotate(0,0,this.barrelsElevationY);
            }
        }
        if(elevation == "DOWN"){
            this.barrelsElevationY = (Mathf.Abs(this.barrelsElevationY) + this.elevationSteps)*-1;
            if(this.minBarrelElevation < this.barrelsElevationY){
                this.playServoSoundOn();
                this.barrelPipe.transform.Rotate(0,0,this.barrelsElevationY);
            }
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
