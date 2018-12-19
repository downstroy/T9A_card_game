using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Card : MonoBehaviour {

    public int life;
    public int damage;
    public int rank;


    public Text text;

	// Use this for initialization
	void Start () {
        text.text = life.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
