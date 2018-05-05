using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tombol : MonoBehaviour {

    // Use this for initialization
    public void ketujuan(string tujuan)
    {
        Application.LoadLevel(tujuan);
    }
}