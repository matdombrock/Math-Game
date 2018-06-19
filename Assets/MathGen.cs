using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathGen : MonoBehaviour {
	public GameObject[] enemies;
	public int[] numbers;
	public int number;
	// Use this for initialization
	void Start () {
		enemies = GameObject.FindGameObjectsWithTag("Enemy");
		number = Random.Range(3,9);
		print(number);
		numbers = new int[number];
		for(int i=0;i<number;i++){
			numbers[i]=i;
		}
		int ii = 0;
		foreach (GameObject enemy in enemies){
			if(ii>=number){
				ii=0;
			}
			GameObject letter = enemy.transform.Find("Letter").gameObject;
			print("ii:"+ii.ToString());
			print(numbers[ii]);
			letter.GetComponent<TextMesh>().text = numbers[ii].ToString();
			ii=ii+1;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
