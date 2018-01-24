using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz : MonoBehaviour {
	public int quiz1 = 0;

	private int quiz3_1 = 0;
	private int quiz3_2 = 1;

	// Use this for initialization
	void Start () {
		/*
		//quiz 1
		for(int i = 2; i < 500; i+= 2){
			quiz1 += i;
		}

		//quiz 2
		for(int i = 1; i <= 100; i++){
			if(i % 3 == 0|| i % 5 == 0){
				print ("Programming is Awesome!");
			} else {
				print (i);
			}

		}
		*/
		//quiz 3
		for(int i = 0; i < 20; i++){
			if (i == 0) {
				print (quiz3_1);
			} else if (i == 1) {
				print (quiz3_2);
			} else {
				if (quiz3_1 < quiz3_2) {
					quiz3_1 += quiz3_2;
				} else {
					quiz3_2 += quiz3_1;
				}
				print (quiz3_1 + quiz3_2);


			}
		}

	}
}
