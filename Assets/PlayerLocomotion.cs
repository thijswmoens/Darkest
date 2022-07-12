using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TM
{
    public class PlayerLocomotion : MonoBehaviour
    {
        Transform cameraObject;
        InputHandler inputHandler;
        Vector3 moveDirection;

        [HideInInspector]
        public Transform myTransform;

        public new Rigidbody rigidbody;
        public GameObject normalCamera;

        [Header ("Stats")]

        void Start()
        {

        }
    }
}