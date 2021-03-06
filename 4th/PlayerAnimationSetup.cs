using UnityEngine;
using System.Collections;

public class PlayerAnimationSetup : MonoBehaviour {
	// スライディング実行時間  
	public float slidingTime = 1F;
    
    // Animatorコンポーネント
	Animator animator;
	// キャラクターコントローラー
	CharacterController character;
	// スライディング実行時間残
	float slidingTimeLeft = 0F;
	// キャラクターコントローラーのコライダーの中心位置
	Vector3 colliderCenter;
	// キャラクターコントローラーのコライダーの高さ
	float colliderHeight;
	
	void Start () {
		// キャラクターコントローラーの取得
		character = GetComponent<CharacterController>();
		// キャラクターコントローラーのコライダーの中心位置を取得
		colliderCenter = character.center;
		// キャラクターコントローラーのコライダーの高さを取得
		colliderHeight = character.height;
		// Animatorコンポーネントの取得
		animator = GetComponent<Animator>();
		// 1番のレイヤー（Sub Layer）のウェイト値を0.8にする
		animator.SetLayerWeight(1, 0.8F);
	}
	
	void Update () {
		// キー入力の取得		
		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis ("Horizontal");
		bool isJump = Input.GetKey(KeyCode.Space);
		bool isSliding = Input.GetKey(KeyCode.C);
		
		// TreasureControllerのParametersにパラメーターをセット
		animator.SetBool("IsGround", character.isGrounded); 
		animator.SetBool("IsJumpStart", false); 
		animator.SetBool ("IsSlidingStart", false);
		
		// スライディング実行時間残を減少させる
		if (slidingTimeLeft > 0) {
			slidingTimeLeft -= Time.deltaTime;
		}
		
		animator.SetFloat("SlidingTime", slidingTimeLeft);

		// 現在のアニメーションの状態を取得
		AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
		// アニメーションの状態がスライディング状態かどうかチェック
		if (state.nameHash == Animator.StringToHash("Base Layer.Sliding")) {
			// スライディング状態のときは中心位置の下方向に、高さを半分にする
			Vector3 newColliderCenter = colliderCenter;
			newColliderCenter.y *= 0.5F;
			character.center = newColliderCenter;
			character.height = colliderHeight * 0.5F;
		} else {
			// スライディング状態でない場合は中心位置と高さを初期位置にする
			character.center = colliderCenter;
			character.height = colliderHeight;
		}
		
		if (character.isGrounded) {
			
			animator.SetFloat("Speed", v);
			animator.SetFloat("Direction", h); // 横方向の入力をParametersのDirectionにセットする
			
			if (isJump) {
				animator.SetBool("IsJumpStart", true);
			}
			
			if (isSliding) {
				animator.SetBool("IsSlidingStart", true);
				slidingTimeLeft = slidingTime;
				animator.SetFloat("SlidingTime", slidingTime);
			}
		}
		
	}
	
}