using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Cat Needs:
// grooming
// hunger
// thirst
// affection
public class CatBehaviorScript : MonoBehaviour
{

    int groomingNeed = 0;
    int hungerNeed = 0;
    int thirstNeed = 0;
    int affectionNeed = 0;

    int groomingLevel= 0;
    int hungerLevel = 0;
    int thirstLevel = 0;
    int affectionLevel = 0;

    public Image groomingBar;
    public Image hungerBar;
    public Image thirstBar;
    public Image affectionBar;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        groomingNeed = Random.Range(1, 10);
        hungerNeed = Random.Range(1, 10);
        thirstNeed = Random.Range(1, 10);
        affectionNeed = Random.Range(1, 10);

        groomingLevel = groomingNeed;
        hungerLevel = hungerNeed;
        thirstLevel = thirstNeed;
        affectionLevel = affectionNeed;

        StartCoroutine(Decrement());
        //Debug.Log(groomingNeed + ": " + groomingLevel);
        //Debug.Log(hungerNeed + ": " + hungerLevel);
        //Debug.Log(thirstNeed + ": " + thirstLevel);
        //Debug.Log(affectionNeed + ": " + affectionLevel);

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(groomingNeed + ": " + groomingLevel);
        //Debug.Log(hungerNeed + ": " + hungerLevel);
        //Debug.Log(thirstNeed + ": " + thirstLevel);
        //Debug.Log(affectionNeed + ": " + affectionLevel);
    }

    IEnumerator Decrement()
    {
        while (true)
        {
            if (groomingLevel != 0) groomingLevel -= 1;
            if (hungerLevel != 0) hungerLevel -= 1;
            if (thirstLevel != 0) thirstLevel -= 1;
            if (affectionLevel != 0) affectionLevel -= 1;

            groomingBar.fillAmount = (float)groomingLevel / groomingNeed;
            hungerBar.fillAmount = (float)hungerLevel / hungerNeed;
            thirstBar.fillAmount = (float)thirstLevel / thirstNeed;
            affectionBar.fillAmount = (float)affectionLevel / affectionNeed;

            Debug.Log(groomingNeed + ": " + groomingLevel);
            Debug.Log(hungerNeed + ": " + hungerLevel);
            Debug.Log(thirstNeed + ": " + thirstLevel);
            Debug.Log(affectionNeed + ": " + affectionLevel);

            yield return new WaitForSeconds(5.0f);
        }
    }
    public void Feed()
    {
        if (hungerLevel != hungerNeed)
        {
            hungerLevel = hungerNeed;
            hungerBar.fillAmount = 1f;
            Debug.Log(hungerNeed + ": " + hungerLevel);
        }
    }

    public void Water()
    {
        if (thirstLevel != thirstNeed)
        {
            thirstLevel = thirstNeed;
            thirstBar.fillAmount = 1f;
            Debug.Log(thirstNeed + ": " + thirstLevel);
        }
    }
    
    public void Groom()
    {
        if (groomingLevel != groomingNeed)
        {
            groomingLevel = groomingNeed;
            groomingBar.fillAmount = 1f; 
            Debug.Log(groomingNeed + ": " + groomingLevel);
        }
    }

    public void Love()
    {
        if (affectionLevel != affectionNeed)
        {
            affectionLevel = affectionNeed;
            affectionBar.fillAmount = 1f;
            Debug.Log(affectionNeed + ": " + affectionLevel);
        }
    }
}
