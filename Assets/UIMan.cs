using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIMan : MonoBehaviour {
	public Text GoalText;
	public Text CurSumText;
	public MathGen MG;
	public Control CTRL;
	public CanvasGroup win;
	public CanvasGroup lose;
	public CanvasGroup start;
	// Use this for initialization
	void Start () {
		GoalText.text = MG.number.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
		CurSumText.text = CTRL.curSum.ToString();
		if(Input.anyKey){
			start.alpha = 0;
		}
	}
	public void ShowWin(){
		win.alpha = 1.0f;
	}
	public void ShowLose(){
		lose.alpha = 1.0f;
	}
}
