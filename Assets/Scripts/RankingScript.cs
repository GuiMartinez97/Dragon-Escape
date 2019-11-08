using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingScript : MonoBehaviour
{
    public List<string> TextToBeIterated { get; set; }
    [SerializeField]
    private GameObject TextName;
    public double Position { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        //TextToBeIterated = BuildTextFromDictionary(RankingStaticClass.RankingDictionary);
        //foreach (var item in TextToBeIterated)
        //{
        //    Instantiate(this.TextName, this.transform.position, Quaternion.identity);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private List<string> BuildTextFromDictionary(Dictionary<string, double> _rankingDictionary)
    {
        var listToBeReturned = new List<string>();
        var i = 1;
        foreach (var ranking in _rankingDictionary)
        {
            listToBeReturned.Add(i.ToString() + "____" + ranking.Value.ToString());
        }
        return listToBeReturned;
    }
}
