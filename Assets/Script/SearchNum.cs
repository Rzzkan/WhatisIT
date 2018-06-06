using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SearchNum : MonoBehaviour {
    public GameObject[] angka;
    public Text soal;
    public Button next;
    public int kes = 0;
    public int ang = 0;
    public string pertanyaan;
    public GameObject[] button;
    public RectTransform panel;
    public Text textPanel;
    public Text kondisi;
    public Text levelText;
    int index;
    int lvl = 0;

    // Use this for initialization
    void Start () {
        soal = GameObject.Find("Soal").GetComponent<Text>();
        angka = GameObject.FindGameObjectsWithTag("Angka");
        button = GameObject.FindGameObjectsWithTag("Pilihan");
        textPanel = GameObject.Find("isiPanel").GetComponent<Text>();
        kondisi = GameObject.Find("Kondisi").GetComponent<Text>();
        next = GameObject.Find("Next").GetComponent<Button>();
        levelText = GameObject.Find("level").GetComponent<Text>();

        Satu();
        



    }
	
	// Update is called once per frame
	void Update () {
    }


    public void Satu(){
        levelText.text = "Tingkat 1";
        frameOut();
        for (int i =0; i<6; i++)
        {
            button[i].SetActive(true);
        }

        lvl = 1;
        kes = 6;
        int[] levelSatu = { 1, 2, 3, 4, 5, 6 };
        index = Random.Range(0, levelSatu.Length);
        ang = levelSatu[index];

        pertanyaan = "Dari 6 kotak, Carilah kotak yang bernilai " + ang.ToString() + ". Kotak sudah dalam keadaan terurut. Anda memiliki " + kes.ToString() + " kesempatan untuk menemukannya";
        soal.text = pertanyaan;
       
        int posisi = 0;
        foreach (GameObject isiAngka in angka){
                isiAngka.GetComponent<Text>().text = levelSatu[posisi].ToString();
                posisi++;         
        }
    }

    public void Dua()
    {
        levelText.text = "Tingkat 2";
        frameOut();
        for (int i = 0; i < 6; i++)
        {
            button[i].SetActive(true);
        }

        lvl = 2;
        kes = 5;
        int[] levelDua = { 1, 3, 5, 7, 9, 11 };
        index = Random.Range(0, levelDua.Length);
        ang = levelDua[index];

        pertanyaan = "Dari 6 kotak, Carilah kotak yang bernilai " + ang.ToString() + ". Kotak sudah dalam keadaan terurut. Anda memiliki " + kes.ToString() + " kesempatan untuk menemukannya";
        soal.text = pertanyaan;

        int posisi = 0;
        foreach (GameObject isiAngka in angka)
        {
                isiAngka.GetComponent<Text>().text = levelDua[posisi].ToString();
                posisi++;
        }
    }

    public void Tiga()
    {
        levelText.text = "Tingkat 3";
        frameOut();
        for (int i = 0; i < 6; i++)
        {
            button[i].SetActive(true);
        }

        lvl = 3;
        kes = 4;
        int[] levelTiga = { 10, 8, 6, 4, 2, 0 };
        index = Random.Range(0, levelTiga.Length);
        ang = levelTiga[index];

        pertanyaan = "Dari 6 kotak, Carilah kotak yang bernilai " + ang.ToString() + ". Kotak sudah dalam keadaan terurut. Anda memiliki " + kes.ToString() + " kesempatan untuk menemukannya";
        soal.text = pertanyaan;

        int posisi = 0;
        foreach (GameObject isiAngka in angka)
        {
                isiAngka.GetComponent<Text>().text = levelTiga[posisi].ToString();
                posisi++;
        }
    }

    public void Empat()
    {
        levelText.text = "Tingkat 4";
        frameOut();
        for (int i = 0; i < 6; i++)
        {
            button[i].SetActive(true);
        }

        lvl = 4;
        kes = 3;
        int[] levelEmpat = { 10, 15, 20, 25, 30, 35 };
        index = Random.Range(0, levelEmpat.Length);
        ang = levelEmpat[index];

        pertanyaan = "Dari 6 kotak, Carilah kotak yang bernilai " + ang.ToString() + ". Kotak sudah dalam keadaan terurut. Anda memiliki " + kes.ToString() + " kesempatan untuk menemukannya";
        soal.text = pertanyaan;

        int posisi = 0;
        foreach (GameObject isiAngka in angka)
        {
                isiAngka.GetComponent<Text>().text = levelEmpat[posisi].ToString();
                posisi++;
        }
    }

    public void Lima()
    {
        levelText.text = "Tingkat 5";
        frameOut();
        for (int i = 0; i < 6; i++)
        {
            button[i].SetActive(true);
        }

        lvl = 5;
        kes = 3;
        int[] levelLima = { 2, 4, 16, 32, 64, 128 };
        index = Random.Range(0, levelLima.Length);
        ang = levelLima[index];

        pertanyaan = "Dari 6 kotak, Carilah kotak yang bernilai " + ang.ToString() + ". Kotak sudah dalam keadaan terurut. Anda memiliki " + kes.ToString() + " kesempatan untuk menemukannya";
        soal.text = pertanyaan;

        int posisi = 0;
        foreach (GameObject isiAngka in angka)
        {
                isiAngka.GetComponent<Text>().text = levelLima[posisi].ToString();
                posisi++;
        }
    }

    public void level(){
        if (kes == 0)
        {
            //next.GetComponentInChildren<Text>().text = "Ulangi";
            if (lvl == 1)
            {
                Satu();
            }
            else if (lvl == 2)
            {
                Dua();
            }
            else if (lvl == 3)
            {
                Tiga();
            }
            else if (lvl == 4)
            {
                Empat();
            }
            else if (lvl == 5)
            {
                Lima();
            }

        }
        else if (lvl == 5)
        {
             SceneManager.LoadScene("Category");
        }
        else
        {
            //next.GetComponentInChildren<Text>().text = "Berikutnya";
            if (lvl == 1)
            {
                Dua();
                Debug.Log("dua");
            }
            else if (lvl == 2)
            {
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

        }
        

    }

    public void bandingkan(int indek){
        button[indek].SetActive(false);
        if (angka[indek].GetComponent<Text>().text.Equals(ang.ToString())) {
            Debug.Log(angka[indek].GetComponent<Text>().text);
            Debug.Log("Benar "+index);
            endWin();
        }
        else
        {
            Debug.Log("salah");
            kes -= 1;
            Debug.Log(kes);
            pertanyaan = "Dari 6 kotak, Carilah kotak yang bernilai " + ang.ToString() + ". Kotak sudah dalam keadaan terurut. Anda memiliki " + kes.ToString() + " kesempatan untuk menemukannya";
            soal.text = pertanyaan;

            if (kes == 0)
            {
                endLose();
            }
          

        }

    }

    public void endWin()
    {
        if (lvl == 5)
        {
            next.GetComponentInChildren<Text>().text = "Kategori";
        }
        else
        {
            next.GetComponentInChildren<Text>().text = "Berikutnya";
        }
        
        string isi = "Berhasil menemukan angka dengan sisa kesempatan " + kes.ToString(); 
        textPanel.text = isi;
        kondisi.text = "Ditemukan";
        frameIn();
    }

    public void endLose()
    {
        next.GetComponentInChildren<Text>().text = "Ulangi";
        string isi = "Gagal Menemukan Angka";
        textPanel.text = isi;
        kondisi.text = "Gagal";
        frameIn();
    }
  
    public void frameIn()
    {
        Vector2 pos = new Vector2(10f, 60f);
        panel.anchoredPosition = pos;
    }

    public void frameOut()
    {
        Vector2 pos = new Vector2(10f, 1000f);
        panel.anchoredPosition = pos;
    }

}