using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveUI : MonoBehaviour {

    public Text wave;

    // Update is called once per frame
    void Update()
    {
        wave.text = PlayerStats.Rounds.ToString();
    }
}
