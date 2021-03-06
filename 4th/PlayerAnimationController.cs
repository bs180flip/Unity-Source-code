using UnityEngine;
using System.Collections;

public class PlayerAnimationController : MonoBehaviour {

	public float forwardSpeed = 5F;
	public float backwardSpeed = 2F;
	public float rotateSpeed = 2F;
	public float jumpSpeed = 8F;
	public float gravity = 20F;
	public float slidingTime = 1F;

	Animator animator;
	CharacterController character;
	float slidingTimeLeft = 0F;
	Vector3 colliderCenter;
	float colliderHeight;
	Vector3 velocity;

	void Start () {
		character = GetComponent<CharacterController>();
		colliderCenter = character.center;
		colliderHeight = character.height;
		animator = GetComponent<Animator>();
		animator.SetLayerWeight(1, 0.8F);
	}

	
	
	void Update () {
		float v = InputState.v;
		float h = InputState.h;
		bool isJump = InputState.isJump;
		bool isSliding = InputState.isSliding;
		
		animator.SetBool("IsGround", character.isGrounded);
		animator.SetBool("IsJumpStart", false);
		animator.SetBool ("IsSlidingStart", false);
		if (slidingTimeLeft > 0) {
			slidingTimeLeft -= Time.deltaTime;
		}
		
		animator.SetFloat("SlidingTime", slidingTimeLeft);
		
		AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
		if (state.nameHash == Animator.StringToHash("Base Layer.Sliding")) {
			Vector3 newColliderCenter = colliderCenter;
			newColliderCenter.y *= 0.5F;
			character.center = newColliderCenter;
			character.height = colliderHeight * 0.5F;
		} else {
			character.center = colliderCenter;
			character.height = colliderHeight;
		}

		if (character.isGrounded) {
			velocity = new Vector3(0, 0, v);
			velocity = transform.TransformDirection(velocity);
			animator.SetFloat("Speed", v);
			animator.SetFloat("Direction", h);
			if (v > 0) {
				velocity *= forwardSpeed;
			} else if (v < 0) {
				velocity *= backwardSpeed;
			}
			if (isJump) {
				animator.SetBool("IsJumpStart", true);
				velocity.y = jumpSpeed;	
			}
			if (isSliding) {
				animator.SetBool("IsSlidingStart", true);
				slidingTimeLeft = slidingTime;
				animator.SetFloat("SlidingTime", slidingTime);
			}
		}

		velocity.y -= gravity * Time.deltaTime;
		character.Move(velocity * Time.deltaTime);
		transform.Rotate(0, h * rotateSpeed, 0);
	}
	
}
