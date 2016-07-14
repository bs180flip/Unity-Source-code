using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[ExecuteInEditMode()]
public class MessageConsole : MonoBehaviour {
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
		TextAsset txt = (TextAsset)Resources.Load("messages");
		messages = txt.text.Split('\n');
		
		textLoader = new TextLoader("strings");
		
		StartCoroutine("blinkTimer");

		mojistyle = new GUIStyle ();

		mozicolor = new GUIStyleState ();
//		mozicolor.textColor = Color.white;
//		mojistyle.normal = mozicolor;

		GameObject panel = GameObject.Find ("Panel");
		Image kakusu = panel.GetComponent<Image> ();
		kakusu.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown){
			linenum++;
			if(linenum>=messages.Length){
				StartCoroutine("changescene");
				linenum = 0;
			}
		}
		
	}
	
	void OnGUI(){
		mojistyle.fontSize = 50;
		mozicolor.textColor = Color.white;
		mojistyle.normal = mozicolor;
		GUI.Box(new Rect(30, Screen.height-250, Screen.width-100, 300), "");
		GUI.Label(new Rect(40, Screen.height-220, Screen.width-40, 150), messages[linenum],mojistyle);
		if((linenum+1)<messages.Length){
			if(blinkFlg){
				mojistyle.fontSize = 30;
				mozicolor.textColor = Color.blue;
				mojistyle.normal = mozicolor;
				GUI.Label (new Rect(50, Screen.height-100, 100, 100), textLoader.getString("next"),mojistyle);

			}
		}
	}
				
	IEnumerator blinkTimer(){
		while(linenum<10){
			blinkFlg = !blinkFlg;
			yield return new WaitForSeconds(1.0f);
		}
	}


     IEnumerator changescene() {

		GameObject camera =GameObject.Find ("Main Camera");
		BGM =camera.gameObject.GetComponent<AudioSource> ();
		BGM.Stop ();
	    
		GameObject panel = GameObject.Find ("Panel");
		kakusu = panel.GetComponent<Image> ();
		kakusu.enabled = true;

		yield return new WaitForSeconds(0.5f);
		GameObject Yado =GameObject.Find ("haikei");
		yadoya =Yado.gameObject.GetComponent<AudioSource> ();
		yadoya.Play ();

		yield return new WaitForSeconds(2.5f);
		Application.LoadLevel ("Field");

	}

}
