using System.Collections;
using UnityEngine;
//ONLY INCLUDE ONE CAT MANAGER IN THE SCENE AT ALL TIMES
public class CatManagerScript : MonoBehaviour
{
    //the cat gameobject
    [SerializeField]
    GameObject cat;
    //max cat number
    [SerializeField]
    int maxCats;
    //how long to wait between cat spawning
    [SerializeField]
    float waitTime = 60;
    int totalCats = 0;
    //where the cat is spawned, set to this
    //gameObject's position by default
    [SerializeField]
    Vector3 catPosition;
    bool spawningCat = false;
    private void Start()
    {
        catPosition = this.gameObject.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        //gets number of cats in the scene
        totalCats = GameObject.FindGameObjectsWithTag("Cat").Length;
        //if there is not maximum cats in the scene, start spawning another cat 
        if (totalCats != maxCats && !spawningCat)
        {
            StartCoroutine(SpawnCat());
        }
    }
    IEnumerator SpawnCat()
    {
        //set spawning cat to true so it only spawns one
        //cat at a time
        spawningCat = true;
        //wait for waitTime amount of seconds
        yield return new WaitForSeconds(waitTime);
        //instantiates the cat at catPosition with no rotation and sets
        //its parent to null so it is its own object with its own transforms
        //rather than a parent's transforms
        var inscat = Instantiate(cat, catPosition, new Quaternion(0, 0, 0, 0), null);
        //set spawning cat to false so it can
        //spawn another cat if it needs
        spawningCat = false;
    }
}
