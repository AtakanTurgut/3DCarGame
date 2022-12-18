/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitView : MonoBehaviour
{
    public WheelCollider sagOn, solOn, sagArka, solArka;

    public float motorHizi, donmeHizi;

    void Start()
    {
        
    }
 
    void Update()
    {
        sagArka.motorTorque = motorHizi * Input.GetAxis("Vertical");
        solArka.motorTorque = motorHizi * Input.GetAxis("Vertical");

        sagOn.steerAngle = donmeHizi * Input.GetAxis("Horizontal");
        solOn.steerAngle = donmeHizi * Input.GetAxis("Horizontal");
    }

    public Collider target;
    void OnTriggerEnter(Collider carTrigger)     
    {
        if (carTrigger == target)
        {
            print("Bump!");                 
            motorHizi = 0;
        }

    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitView : MonoBehaviour
{
    void Start()
    {

    }

    public float hiz = 0.0F;
    public float donusHizi = 0.0F;
    public float yukselme = 0.0F;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * hiz);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * hiz);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, donusHizi * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -donusHizi * Time.deltaTime, 0);
        }

    }

    public Collider target;  // Terrain ve Triggerden ötürü olmuyor 
    void OnTriggerEnter(Collider carTrigger)
    {
        if (carTrigger == target)
        {
            print("Bump!");
            hiz = 0;
        }

    }
}
