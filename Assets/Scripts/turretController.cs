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
* La Tanqueta tenia un pioneer subia la moral ...
* Panteras mas malparidos
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
    
    // Start is called before the first frame update
    void Start()
    {
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
        //Quaternion rotation = Quaternion.Euler(this.barrelsObj.transform.localRotation.x,this.barrelsObj.transform.localRotation.y,this.barrelsObj.transform.localRotation.z);
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
