using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
   float _baseSpeed = 10.0f;

   CharacterController characterController;
   
   void Start() {
       characterController = GetComponent<CharacterController>();
   }

   void Update() {
       float x = Input.GetAxis("Horizontal");
       float z = Input.GetAxis("Vertical");

       Vector3 direction = new Vector3(x, 0, z);

       characterController.Move(direction * _baseSpeed * Time.deltaTime);
   }
}
