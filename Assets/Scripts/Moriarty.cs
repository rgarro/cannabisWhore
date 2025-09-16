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

    //private AudioSource servoSoundPlayer;
	//public AudioClip servoSoundClip;
    public AudioClip engineSoundClip;

    public GameObject Chaffee;//see you in StarBucks homebrew snake Houston Preston ..

    public float tankForwardSpeed = 2.00f;

    // Start is called before the first frame update
    void Start()
    {
        //this.servoSoundPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        this.joystickControls();
    }

    void moveForward(){
        Debug.Log("moving forward ");
        this.Chaffee.transform.Translate(Vector3.forward * this.tankForwardSpeed * Time.deltaTime);
    }

    void moveBackward(){
         Debug.Log("moving backward ");
        //transform.Translate(Vector3.backward * Time.deltaTime);
        this.Chaffee.transform.Translate(-Vector3.forward * this.tankForwardSpeed * Time.deltaTime);
    }

    void turnLeft(){

    }

    void turnRight(){

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
