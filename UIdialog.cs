using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIdialog : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private int sdeathcount;

    private int countSentence;

    public string[] sentence;
    private void Start()
    {
        GetComponent<TypeWriteEffect>().Run(textToType: "Hello,my name is Shenyuan.Nice to meet you!\n(Tap 'space' to continue)", textLabel);
    }

    public void Update()
    {
        //sdeathcount = GameObject.Find("restartscene").GetComponent<restarts>().deathcount;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<TypeWriteEffect>().Run(textToType: sentence[countSentence], textLabel);
            countSentence++;
        }
    }
}
