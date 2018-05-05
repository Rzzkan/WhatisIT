using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchNum : MonoBehaviour {
    public GameObject[] angka;
    public Text soal;
    public Button next;
    public int kes = 0;
    public int ang = 0;
    public string pertanyaan;
    int index;
    int lvl = 0;

    // Use this for initialization
    void Start () {
        soal = GameObject.Find("Soal").GetComponent<Text>();
        angka = GameObject.FindGameObjectsWithTag("Angka");
        Satu();



    }
	
	// Update is called once per frame
	void Update () {
    }


    void hide(){
        for (int i = 0; i == 5; i++){
            angka[i].GetComponentInChildren<Text>().text = "";
        }
    }

    public void Satu(){
        lvl = 1;
        kes = 6;
        int[] levelSatu = { 1, 2, 3, 4, 5, 6 };
        index = Random.Range(0, levelSatu.Length);
        ang = levelSatu[index];

        pertanyaan = "Dari 6 kotak, Carilah kotak yang bernilai " + ang.ToString() + ". Kotak sudah dalam keadaan terurut. Anda memiliki " + kes.ToString() + " kesempatan untuk menemukannya";
        soal.text = pertanyaan;
       
        int posisi = 0;
        foreach (GameObject isiAngka in angka){
            //if (isiAngka.GetComponentInChildren<Text>().text.Length == 0){
                isiAngka.GetComponentInChildren<Text>().text = levelSatu[posisi].ToString();
                posisi++;         
            //}
        }
    }

    public void Dua()
    {
        lvl = 2;
        kes = 6;
        int[] levelDua = { 1, 3, 5, 7, 9, 11 };
        index = Random.Range(0, levelDua.Length);
        ang = levelDua[index];

        pertanyaan = "Dari 6 kotak, Carilah kotak yang bernilai " + ang.ToString() + ". Kotak sudah dalam keadaan terurut. Anda memiliki " + kes.ToString() + " kesempatan untuk menemukannya";
        soal.text = pertanyaan;

        int posisi = 0;
        foreach (GameObject isiAngka in angka)
        {
                isiAngka.GetComponentInChildren<Text>().text = levelDua[posisi].ToString();
                posisi++;
        }
    }

    public void Tiga()
    {
        lvl = 3;
        kes = 6;
        int[] levelTiga = { 10, 8, 6, 4, 2, 0 };
        index = Random.Range(0, levelTiga.Length);
        ang = levelTiga[index];

        pertanyaan = "Dari 6 kotak, Carilah kotak yang bernilai " + ang.ToString() + ". Kotak sudah dalam keadaan terurut. Anda memiliki " + kes.ToString() + " kesempatan untuk menemukannya";
        soal.text = pertanyaan;

        int posisi = 0;
        foreach (GameObject isiAngka in angka)
        {
                isiAngka.GetComponentInChildren<Text>().text = levelTiga[posisi].ToString();
                posisi++;
        }
    }

    public void Empat()
    {
        lvl = 4;
        kes = 6;
        int[] levelEmpat = { 10, 15, 20, 25, 30, 35 };
        index = Random.Range(0, levelEmpat.Length);
        ang = levelEmpat[index];

        pertanyaan = "Dari 6 kotak, Carilah kotak yang bernilai " + ang.ToString() + ". Kotak sudah dalam keadaan terurut. Anda memiliki " + kes.ToString() + " kesempatan untuk menemukannya";
        soal.text = pertanyaan;

        int posisi = 0;
        foreach (GameObject isiAngka in angka)
        {
                isiAngka.GetComponentInChildren<Text>().text = levelEmpat[posisi].ToString();
                posisi++;
        }
    }

    public void Lima()
    {
        lvl = 5;
        kes = 6;
        int[] levelLima = { 2, 4, 16, 32, 64, 128 };
        index = Random.Range(0, levelLima.Length);
        ang = levelLima[index];

        pertanyaan = "Dari 6 kotak, Carilah kotak yang bernilai " + ang.ToString() + ". Kotak sudah dalam keadaan terurut. Anda memiliki " + kes.ToString() + " kesempatan untuk menemukannya";
        soal.text = pertanyaan;

        int posisi = 0;
        foreach (GameObject isiAngka in angka)
        {
                isiAngka.GetComponentInChildren<Text>().text = levelLima[posisi].ToString();
                posisi++;
        }
    }

    public void level(){
        if (lvl==1) {
            Dua();
            Debug.Log("dua");
        }
        else if (lvl == 2){
            Tiga();
            Debug.Log("tiga");
        }
        else if (lvl == 3)
        {
            Empat();
            Debug.Log("empat");
        }
        else if (lvl == 4)
        {
            Lima();
            Debug.Log("lima");
        }
        else if (lvl == 5)
        {

        }

    }

    public void bandingkan(int indek){
        if (angka[indek].GetComponentInChildren<Text>().text.Equals(ang.ToString())) {
            Debug.Log(angka[indek].GetComponentInChildren<Text>().text);
            Debug.Log("Benar "+index);
        }
        else
        {
            kes -= 1;
            Debug.Log(kes);
            pertanyaan = "Dari 6 kotak, Carilah kotak yang bernilai " + ang.ToString() + ". Kotak sudah dalam keadaan terurut. Anda memiliki " + kes.ToString() + " kesempatan untuk menemukannya";
            soal.text = pertanyaan;
            if (kes == 0)
            {
                Debug.Log("Kalah");
            }
            //Debug.Log(pertanyaan);

        }

    }
}