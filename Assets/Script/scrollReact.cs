using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollReact : MonoBehaviour {

	public RectTransform panel,center;
	public Button[] bttn;
	public int startButton=1,nextButton;

	private float[] distance;
	private bool dragging = false;
	private int bttnDistances ,minButtonNum ;

	void Start(){
		int bttnlenght = bttn.Length;
		distance = new float[bttnlenght];

		bttnDistances = (int)Mathf.Abs (bttn[1].GetComponent<RectTransform>().anchoredPosition.x - bttn[0].GetComponent<RectTransform>().anchoredPosition.x);
		panel.anchoredPosition = new Vector2 ((startButton - 1) * -755, 0f);

	}

	void Update(){
		for(int i=0 ; i<bttn.Length;i++){
			distance [i] = Mathf.Abs (center.transform.position.x - bttn [i].transform.position.x);	
		}
		float minDistances = Mathf.Min (distance);

		for (int a = 0; a < bttn.Length; a++) {
			if (minDistances == distance [a]) {
				minButtonNum = a;
			}
		}
		if (!dragging) {
			LerpToButton (minButtonNum * -bttnDistances);
		}

	}

	void LerpToButton(int position){
		float newX = Mathf.Lerp (panel.anchoredPosition.x, position, Time.deltaTime * 30f);
		Vector2 newPos = new Vector2 (newX, panel.anchoredPosition.y);

		panel.anchoredPosition = newPos;
	}

	public void StartDrag(){
		dragging = true;
	}

	public void EndDrag(){
		dragging = false;
	}

	public void BtNext(){
		panel.anchoredPosition = new Vector2 (panel.anchoredPosition.x - 800, 0f);

	}

	public void BtPrev(){
		panel.anchoredPosition = new Vector2 (panel.anchoredPosition.x + 800, 0f);

	}
}



