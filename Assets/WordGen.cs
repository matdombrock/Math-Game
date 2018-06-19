using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGen : MonoBehaviour {
	public string[] word_list;
	public GameObject[] enemies;
	// Use this for initialization
	void Start () {
		int index = Random.Range(0,word_list.Length);
		string word = word_list[index];
		print(word);
		enemies = GameObject.FindGameObjectsWithTag("Enemy");
		int i = 0;
		foreach (GameObject enemy in enemies){
			GameObject letter = enemy.transform.Find("Letter").gameObject;
			letter.GetComponent<TextMesh>().text = word[i].ToString();
			i=i+1;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
