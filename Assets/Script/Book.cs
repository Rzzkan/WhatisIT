using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour {
    public Text konten;
	// Use this for initialization
	void Start () {
        konten = GameObject.Find("TextMateri").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
    
		
	}

    public void AlgoSearch(){
        konten.text = "Mencari kata kunci, nilai, atau bagian data tertentu adalah dasar dari banyak aplikasi komputasi, entah itu mencari saldo rekening bank, menggunakan mesin pencari internet, atau mencari file di laptop Anda. Komputer berurusan dengan banyak informasi sehingga kami membutuhkan algoritma yang efisien untuk mencari. Kita dapat menerapkan strategi pencarian ini sendiri ketika kita mencari untuk menemukan satu hal. Setiap kali kita bermain game seperti 'tebak nomor saya' kita dapat menerapkan pencarian biner ke dalamnya.Demikian juga jika kami mencari buku di perpustakaan yang belum dikembalikan ke tempat yang benar, kami harus melakukan pencarian berurutan untuk menemukannya.Pencarian ada di mana-mana dalam hidup kita, dari mencari alamat seseorang sampai mencari nomor telepon di buku telepon.Kami dapat menerapkan metode pencarian biner atau sekuensial tergantung pada bagaimana data telah diatur untuk memulai.";

    }

    public void AlgoSort(){
        konten.text = "Penggunaan computer semakin banyak dan jumlah data yang digunakan meningkat. Untuk memproses informasi secara cepat diperlukan penyortitan. Sorting digunakan untuk megurutkan nilai dalam suatu urutan dengan membandingkan nilai.";
    }

    public void biner(){
        konten.text = "";
    }

    public void detek(){
        konten.text = "";
    }

}
