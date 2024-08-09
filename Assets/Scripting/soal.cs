using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class soal : MonoBehaviour
{
    public GameObject panelgameselesai;
    public GameObject soalpanel;
    void Start()
    {

    }
    

    void Update()
    {
        
    }

    public void InfoButton()
    {
        panelgameselesai.SetActive(true);
        soalpanel.SetActive(false);
    }
    
}