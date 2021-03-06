using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

        private void Update()
        {
            float h = Input.acceleration.x;
            Debug.Log(h);
            m_Car.Move(h, 1, 0, 0);
        }

        /*
        private void FixedUpdate()
        {
            // pass the input to the car!
            // hの値を顔の傾きによって変化させられるようにしたい
            // float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, 1, 0, handbrake);
#else
            float h = Input.acceleration.x;
            Debug.Log(h);
            m_Car.Move(h, 1, 0, 0f);
#endif
        }
        */
    }
}
