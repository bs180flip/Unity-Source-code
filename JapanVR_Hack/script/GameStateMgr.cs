using UnityEngine;
using System.Collections;

public class GameStateMgr : MonoBehaviour {

    public enum GameState
    {
        Title,
        OnRun,
        GameOver,
        GameClear,        
    };

    [SerializeField]
    GameState State = GameState.Title;

    [SerializeField, HeaderAttribute("タイトルリソース")]
    public Animator wood;
    int woodAnimToriggerId;

    /// <summary>
    /// スタート処理
    /// </summary>
    public void OnStart()
    {
        wood.SetTrigger(woodAnimToriggerId);

    }


    public void ChangeState(GameState _state)
    {
        Debug.Log(_state);
        State = _state;
    }

	// Use this for initialization
	void Start () {
        woodAnimToriggerId = Animator.StringToHash("OnStart");



    }
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.A))
        {
            //Debug.Log(100);
            OnStart();
        }
	}
}
