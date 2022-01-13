using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public HingeJoint joint_R;
    public HingeJoint joint_L;

    public GameObject motor_R;
    public GameObject motor_L;

    public Button button_R;
    public Button button_L;

    JointMotor speed_R;
    JointMotor speed_L;
    bool bl;


    void Start()
    {

    }


    void Update()
    {

        //Debug.Log(motor_R.transform.rotation.y);
        if (motor_R.transform.rotation == new Quaternion(0.3f, 0.5f, 0.2f, 0.8f))
        {
            speed_R = joint_R.motor;
            speed_R.targetVelocity = 200;
            joint_R.motor = speed_R;
            joint_R.axis = new Vector3(0, -1, 0);
        }


        //Debug.Log(motor_L.transform.rotation);
        if (motor_L.transform.rotation == new Quaternion(0.2f, 0.8f, 0.3f, 0.5f))
        {
            speed_L = joint_L.motor;
            speed_L.targetVelocity = 200;
            joint_L.motor = speed_L;
            joint_L.axis = new Vector3(0, 1, 0);
        }


    }


    public void Button_R_Click()
    {
        speed_R = joint_R.motor;
        speed_R.targetVelocity = 500;
        joint_R.motor = speed_R;
        joint_R.axis = new Vector3(0, 1, 0);
        joint_R.useMotor = true;
    }

    public void Button_L_Click()
    {
        speed_L = joint_L.motor;
        speed_L.targetVelocity = 500;
        joint_L.motor = speed_L;
        joint_L.axis = new Vector3(0, -1, 0);
        joint_L.useMotor = true;
    }
}
