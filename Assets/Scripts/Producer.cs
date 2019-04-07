using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Producer : MonoBehaviour
{
    public string kind;     //kind can be factory, farm, park
    //one time costs at the start
    public int peopleEmployed;
    public Dictionary<string, int> startCost;

    //per round costs
    public Dictionary<string, int> runCost;
    public Dictionary<string, int> runProduction;
    public int pollutionMade;

    public void Stuff(string kd, int gre, int roc)
    {
        this.kind = kd;
        this.startCost.Add("cotton", 0);
        this.startCost.Add("food", 0);
        this.startCost.Add("metal", 0);
        this.startCost.Add("gold", 0);
        this.peopleEmployed = 1;
    }

    public void defineCost()
    {
        //* TODOS *//
        // for a given kind, assign some pre defined values for starting costs, 

        //as well as production costs 

        //and outputs


        //assign pollution values
        if (this.kind == "factory")
        {
            pollutionMade = 2;
        }
        else if (this.kind == "farm")
        {
            pollutionMade = 1;
        }
        if (this.kind == "park")
        {
            pollutionMade = -1;
        }


    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
