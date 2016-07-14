using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[ExecuteInEditMode()]
public class MessageConsoleEnd : MonoBehaviour {
	private string[] messages;
	private int linenum=0;
	private TextLoader textLoader;
	private bool blinkFlg;
	private GUIStyle mojistyle;
	private GUIStyleState mozicolor;
	public AudioSource yadoya;
	public AudioSource BGM;
	private Image kakusu;

	// Use this for initialization
	void Start () {
		TextAsset txt = (TextAsset)Resources.Load("End_Message");
		messages = txt.text.Split('\n');
		
		//textLoader = new TextLoader("strings");
		
		StartCoroutine("blinkTimer");

		mojistyle = new GUIStyle ();

		mozicolor = new GUIStyleState ();
//		mozicolor.textColor = Color.white;
//		mojistyle.normal = mozicolor;

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown){
			linenum++;
			if(linenum>=messages.Length){
				linenum = 0;
			
			}
		}
		
	}
	
	void OnGUI(){
		mojistyle.fontSize =60;
		mozicolor.textColor = Color.white;
		mojistyle.normal = mozicolor;
		GUI.Box(new Rect(100, Screen.height-250, Screen.width-100, 300), "");
		GUI.Label(new Rect(400, Screen.height-240, Screen.width-200, 50), messages[linenum],mojistyle);
//		if((linenum+1)<messages.Length){
//			if(blinkFlg){
//				mojistyle.fontSize = 30;
//				mozicolor.textColor = Color.blue;
//				mojistyle.normal = mozicolor;
//				GUI.Label (new Rect(50, Screen.height-100, 100, 100), textLoader.getString("next"),mojistyle);
//
//			}
//		}
	}
				
	IEnumerator blinkTimer(){
		while(linenum<10){
			blinkFlg = !blinkFlg;
			yield return new WaitForSeconds(1.0f);
		}
	}
		

}
