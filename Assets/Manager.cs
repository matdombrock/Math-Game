using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	public MathGen MG;
	public Control CTRL;
	public UIMan UIMan;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(CTRL.curSum>MG.number){
			print("LOSE");
			UIMan.ShowLose();
			if(Input.anyKey){
				Invoke( "restart", 4.0f );
			}
		}
		if(CTRL.curSum==MG.number){
			print("WIN");
			UIMan.ShowWin();
			if(Input.anyKey){
				Invoke( "restart", 4.0f );
			}
		}
	}
	void restart(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
