﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SortNum : MonoBehaviour {
    public GameObject[] tempat, urutan, angka;
    public GameObject banding1, banding2;

	// Use this for initialization
	void Start () {
        tempat = GameObject.FindGameObjectsWithTag("Tempat");
        urutan = GameObject.FindGameObjectsWithTag("Urutan");
        angka = GameObject.FindGameObjectsWithTag("Angka");
        banding1 = GameObject.Find("banding1");
        banding2 = GameObject.Find("banding2");

        satu();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void satu(){
        int[] levelSatu = { 1, 5, 7};
        int posisi = 0;
        foreach (GameObject isiAngka in angka)
        {
            isiAngka.GetComponent<Text>().text = levelSatu[posisi].ToString();
            isiAngka.GetComponent<Text>().enabled = false;
            posisi++;
        }
        Debug.Log(angka[1].GetComponent<Text>().text);
    }
    public void banding(){
       
        try{
            string angka1 = banding1.GetComponentInChildren<Image>().GetComponentInChildren<Text>().text;
            string angka2 = banding2.GetComponentInChildren<Image>().GetComponentInChildren<Text>().text;
            Debug.Log(angka1);
            Debug.Log(angka2);

            if (Convert.ToInt32(angka1) > Convert.ToInt32(angka2))
            {
                Debug.Log("besar angka1");
            }

            else if (Convert.ToInt32(angka1) < Convert.ToInt32(angka2))
            {
                Debug.Log("besar angka2");
            }
            else
            {
                Debug.Log("Error");
            }
        }

        catch (NullReferenceException ex)
        {
            Debug.Log("Error");
        }
        
    }
    public void cek(int lv){
        try{
            string angka1 = urutan[2].GetComponentInChildren<Image>().GetComponentInChildren<Text>().text;
            string angka2 = urutan[1].GetComponentInChildren<Image>().GetComponentInChildren<Text>().text;
            string angka3 = urutan[0].GetComponentInChildren<Image>().GetComponentInChildren<Text>().text;

            int ang1 = Convert.ToInt32(angka1);
            int ang2 = Convert.ToInt32(angka2);
            int ang3 = Convert.ToInt32(angka3);

            if (lv == 1)
            {
                if (ang1 < ang2 & ang2 < ang3)
                {
                    Debug.Log("Benar");
                }
                else
                {
                    Debug.Log("Masih Salah");
                }
            }

        }

        catch (NullReferenceException ex)
        {
            Debug.Log("Error");
        }

    }
}
