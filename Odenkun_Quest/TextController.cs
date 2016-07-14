//using UnityEngine;
//using System.Collections;
//using UnityEngine.UI;	// uGUIの機能を使うお約束
//
//public class TextController : MonoBehaviour {
//
//	public string[] scenarios; // シナリオを格納する
//	public Text uiText;	// uiTextへの参照を保つ
//
//	int currentLine = 0; // 現在の行番号
//
//	void Start()
//	{
//		TextUpdate();
//	}
//
//	void Update () 
//	{
//		// 現在の行番号がラストまで行ってない状態でクリックすると、テキストを更新する
//		if(currentLine < scenarios.Length && Input.GetMouseButtonDown(0))
//		{
//			TextUpdate();
//		}
//	}
//
//	// テキストを更新する
//	void TextUpdate()
//	{
//		// 現在の行のテキストをuiTextに流し込み、現在の行番号を一つ追加する
//		uiText.text = scenarios[currentLine];
//		currentLine ++;
//	}
//}
//	

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour 
{
	public string[] scenarios;
	[SerializeField] Text uiText;

	[SerializeField][Range(0.001f, 0.3f)]
	float intervalForCharacterDisplay = 0.55f;	// 1文字の表示にかかる時間

	private int currentLine = 0;
	private string currentText = string.Empty;	// 現在の文字列
	private float timeUntilDisplay = 0;		// 表示にかかる時間
	private float timeElapsed = 1;			// 文字列の表示を開始した時間
	private int lastUpdateCharacter = -1;		// 表示中の文字数



	void Start()
	{
		SetNextLine();
	}

	void Update () 
	{
		if(currentLine < scenarios.Length && Input.GetMouseButtonDown(0)){
			SetNextLine();
		}

		// クリックから経過した時間が想定表示時間の何%か確認し、表示文字数を出す
		int displayCharacterCount = (int)(Mathf.Clamp01((Time.time - timeElapsed) / timeUntilDisplay) * currentText.Length);

		// 表示文字数が前回の表示文字数と異なるならテキストを更新する
		if( displayCharacterCount != lastUpdateCharacter ){
			uiText.text = currentText.Substring(0, displayCharacterCount);
			lastUpdateCharacter = displayCharacterCount;
		}
	}


	void SetNextLine()
	{
		currentText = scenarios[currentLine];
		currentLine ++;

		// 想定表示時間と現在の時刻をキャッシュ
		timeUntilDisplay = currentText.Length * intervalForCharacterDisplay;
		timeElapsed = Time.time;

		// 文字カウントを初期化
		lastUpdateCharacter = -1;
	}
}