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
 *  cinematic hoovercraft style tank movement controller
 * 
 *
 *
 *@author Rolando <rgarro@gmail.com>
 */
public class Moriarty : MonoBehaviour
{
    public GameObject rightTracks;
    public GameObject leftTracks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void moveForward(){

    }

    void moveBackward(){

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
             this.yawLeft();
         }
        if (Input.GetKey("right")){
            this.yawRight();
         }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //this.doRestart();
        }
    }
}
