using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    private TextMeshProUGUI TheFinalCountDown;
    private float countRate = 1f;
    public int StartNumber = 10;

    // Start is called before the first frame update
    void Start()
    {
        TheFinalCountDown = GetComponent<TextMeshProUGUI>();
        StartCoroutine("CountDownFunction");
        TheFinalCountDown.text = "Cuenta Atras";
    }
    private IEnumerator CountDownFunction()
    {
        yield return new WaitForSeconds(countRate);

        for (int FinalOfCount = StartNumber; FinalOfCount >= 0; FinalOfCount -= 1)
        {
            yield return new WaitForSeconds(countRate);
           
            TheFinalCountDown.text = FinalOfCount.ToString();
        }
    }
}
