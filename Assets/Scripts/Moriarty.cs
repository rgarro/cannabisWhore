using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *    [ O ]
 *      \ \      p
 *       \ \  \o/
 *        \ \--'---_
 *        /\ \   / ~~\_
 *  ./---/__|=/_/------//~~~\
 * /___________________/O   O \
 * (===(\_________(===(Oo o o O)          
 *  \~~~\____/     \---\Oo__o--
 *    ~~~~~~~       ~~~~~~~~~~
 *  Operation Market Garden
 *  XXX Armored Group 
 *  Cinematic Hoovercraft style Tank movement controller
 * 
 *
 *
 *@author Rolando <rgarro@gmail.com>
 */
public class Moriarty : MonoBehaviour
{
    public GameObject rightTracks;
    public GameObject leftTracks;

    private AudioSource servoSoundPlayer;
	public AudioClip servoSoundClip;
    public AudioClip engineSoundClip;

    public GameObject Chaffee;//see you in StarBucks homebrew snake Houston Preston ..

    public float tankForwardSpeed = 2.00f;
    private float tetha = 0.00f;//the angle
     public float rotationSteps = 3.014f;
     public string expectedTargetTag = "stukaTarget";
     public GameObject explosion;
     private GameObject scoreUpdater;

    // Start is called before the first frame update
    void Start()
    {
        this.servoSoundPlayer = GetComponent<AudioSource>();
        this.scoreUpdater = GameObject.FindWithTag("BatComputer");
    }

    private void OnTriggerEnter(Collider other){//crashed the stuka ..
        if(this.expectedTargetTag == other.gameObject.tag){
            GameObject e = Instantiate(this.explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            scoreDisplay tmpObj = this.scoreUpdater.GetComponent(typeof(scoreDisplay)) as scoreDisplay;
            tmpObj.addScore(10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.joystickControls();
    }

    void playServoSoundOn(){

    }

    private void playEngineSoundOn(){
        this.servoSoundPlayer.clip = this.engineSoundClip;
        if (!this.servoSoundPlayer.isPlaying) {
            this.servoSoundPlayer.Play ();
        }
    }

    void moveForward(){
        //Debug.Log("moving forward ");
        this.playEngineSoundOn();
        this.Chaffee.transform.Translate(Vector3.forward * this.tankForwardSpeed * Time.deltaTime);
    }

    void moveBackward(){
         //Debug.Log("moving backward ");
         this.playEngineSoundOn();
        //transform.Translate(Vector3.backward * Time.deltaTime);
        this.Chaffee.transform.Translate(-Vector3.forward * this.tankForwardSpeed * Time.deltaTime);
    }

    void turnLeft(){
        this.playServoSoundOn();
        this.tetha = this.Chaffee.transform.rotation.y - this.rotationSteps;
         this.Chaffee.transform.Rotate(0,this.tetha,0);
    }

    void turnRight(){
        this.playServoSoundOn();
        this.tetha = this.Chaffee.transform.rotation.y + this.rotationSteps;
         this.Chaffee.transform.Rotate(0,this.tetha,0);
    }

    void yawLeft(){

    }

    void yawRight(){

    }

     void joystickControls(){
        if (Input.GetKey("up"))
        {
            this.moveForward();
        }

        if (Input.GetKey("down"))
        {
            this.moveBackward();
        }
         if (Input.GetKey("left")){
             //this.yawLeft();
             this.turnLeft();
         }
        if (Input.GetKey("right")){
            //this.yawRight();
            this.turnRight();
         }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //this.doRestart();
        }
    }
}
