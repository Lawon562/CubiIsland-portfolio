using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private int second = 0;
    private int minute = 0;
    public static bool isTimerOn = false;
    public TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        second = 0;
        minute = 0;
        isTimerOn = true;
        text.text = "00:00";
    }

    // Update is called once per frame
    void Update()
    {
        if(!isTimerOn)
        {
            StartCoroutine(SetTime());
        }
    }


    private IEnumerator SetTime()
    {
        isTimerOn = true;
        
        yield return new WaitForSeconds(1f);
        
        second += 1;
        Calculate();

        text.text = $"{minute:00}:{second:00}";

        isTimerOn = false;
    }

    private void Calculate()
    {
        if(60 == second)
        {
            second = 0;
            minute += 1;
        }
    }
}
