using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;  //speed that it moves
	public float gravityScale;  //Change the force of gravity
	public float jumpForce;  //how high it can jump
	public CharacterController controller; //Using a component as a float so it can be edited

	private Vector3 moveDirection; // direção dos vetores e o seu movimento


	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> (); //It detects when it starts playing that this is a componnent
	}
	
	// Update is called once per frame
	void Update () {

		moveDirection = new Vector3 (Input.GetAxis ("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis ("Vertical") * moveSpeed); 
		// utiliza-se o move direction.y para não acontecer teleportes no ar
		// está a detectar os eixos e a aplicá-los a butões feitos no unity



		if (controller.isGrounded) //  Ver se o player está no chão e só assim pode saltar
		{
		 if (Input.GetButtonDown ("Jump")) //butão para saltar
		    {
				moveDirection.y = jumpForce; // mudar a força do salto
		    }
		 }

		moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime); //ter acesso à gravidade e conseguir alerá-la
		//Usar o physics.gravity.y para detectar para onde vai a gravidade


		controller.Move (moveDirection * Time.deltaTime); //acesso à gravidade e usar o deltaTime para não haver delay em PC com menos FPS

	}
}