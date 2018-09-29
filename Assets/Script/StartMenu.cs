using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {

	public void OnMouseDown ()
    {
        transform.localScale *= 0.9F;
        Application.LoadLevel(1);
    }
}
