using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour
{
    public GameObject Background;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Background.active = false;
        }

    }
}
