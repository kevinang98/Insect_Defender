using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeMenu : MonoBehaviour
{

    public Transform canvas;

    public void OnMouseDown ()
    {
        transform.localScale *= 0.9F;
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}