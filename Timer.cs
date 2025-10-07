using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //conversão de minutos para segundos
    //duração * 60 (duração de 1min)
    int initial = 3 * 60;

    TextMeshProUGUI timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<TextMeshProUGUI>();

        TimeSpan time = TimeSpan.FromSeconds(initial);

        //formatação em mm:ss
        timer.text = time.ToString(@"mm\:ss");

        //mesmológica para outras formatações
        //(@"hh\:mm") -> hh:mm

        StartCoroutine(FlowTime());
    }

    IEnumerator FlowTime()
    {
        while(initial >= 0)
        {
            initial -= 1;
            TimeSpan time = TimeSpan.FromSeconds(initial);
            timer.text = time.ToString(@"mm\:ss");
            yield return new WaitForSeconds(1f);
         
        }
    }
}
