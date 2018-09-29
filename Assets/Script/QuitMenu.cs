using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMenu : MonoBehaviour {

    public void OnMouseDown()
    {
        transform.localScale *= 0.9F;
        Application.LoadLevel(0);
        Time.timeScale = 1;
    }
}
