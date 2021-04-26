using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeWriteEffect : MonoBehaviour
{

    [SerializeField]public float typeWriterSpeed = 50f;

    public void Run(string textToType,TMP_Text textLabel)
    {
        StartCoroutine(routine: TypeText(textToType,textLabel));
    }

    private IEnumerator TypeText(string textToType, TMP_Text textLabel)
    {

        yield return new WaitForSeconds(0.5f);

        float t = 0;
        int charIndex = 0;

        while (charIndex < textToType.Length)
        {
            t += Time.deltaTime * typeWriterSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(value: charIndex, min: 0, max: textToType.Length);

            textLabel.text = textToType.Substring(startIndex: 0, length: charIndex);
            
            
            yield return null;
        }

        textLabel.text = textToType;
        
    }
}
