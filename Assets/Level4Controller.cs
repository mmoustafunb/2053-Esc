﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level4Controller : MonoBehaviour
{
    public GameObject key4, paper;
    public Text puzzText;
    // Start is called before the first frame update
    void Start()
    {
        if (GameController.key4)
        {
            Destroy(key4.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (GameController.key4)
        {
            paper.SetActive(true);
            puzzText.text = "9   I";
        }
        else
        {
            paper.SetActive(false);
            puzzText.text = "";
        }
    }
}
