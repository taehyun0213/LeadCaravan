using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This should be a per player UI and score controller
//I would rename this script to TeamController, or maybe just move my code edits to a TeamController and attach that to a team prefab

public class GameUI : MonoBehaviour
{

    private Scoring Scoring;

    /*list of producers // team 1 */
    [SerializeField] private Text Current_People;
    [SerializeField] private Text Current_Food;
    [SerializeField] private Text Current_Pollution;
    [SerializeField] private Text Current_Gold;
    [SerializeField] private Text Current_Metal;
    [SerializeField] private Text Current_Cotton;
    [SerializeField] private Text Current_Factory1;
    [SerializeField] private Text Current_Factory2;
    [SerializeField] private Text Current_Factory3;
    [SerializeField] private Text Current_Farm1;
    [SerializeField] private Text Current_Farm2;
    [SerializeField] private Text Current_Farm3;
    [SerializeField] private Text Current_Park1;
    [SerializeField] private Text Current_Park2;
    [SerializeField] private Text Current_Park3;

    /*list of producers // team 2 */
    [SerializeField] private Text Current_People_2;
    [SerializeField] private Text Current_Food_2;
    [SerializeField] private Text Current_Pollution_2;
    [SerializeField] private Text Current_Gold_2;
    [SerializeField] private Text Current_Metal_2;
    [SerializeField] private Text Current_Cotton_2;
    [SerializeField] private Text Current_Factory1_2;
    [SerializeField] private Text Current_Factory2_2;
    [SerializeField] private Text Current_Factory3_2;
    [SerializeField] private Text Current_Farm1_2;
    [SerializeField] private Text Current_Farm2_2;
    [SerializeField] private Text Current_Farm3_2;
    [SerializeField] private Text Current_Park1_2;
    [SerializeField] private Text Current_Park2_2;
    [SerializeField] private Text Current_Park3_2;

    // Trading System
    [SerializeField] private InputField offerTxT_Gold;
    [SerializeField] private InputField offerTxT_Metal;
    [SerializeField] private InputField offerTxT_Cotton;
    [SerializeField] private InputField offerTxT_Food;

    [SerializeField] private InputField returnTxT_Gold;
    [SerializeField] private InputField returnTxT_Metal;
    [SerializeField] private InputField returnTxT_Cotton;
    [SerializeField] private InputField returnTxT_Food;


    //private Dictionary<string, int> teamResources;

    //List<Producer> producersOwned;
    // team1
    private int Gold_InitialScore = 10;
    private int Metal_InitialScore = 10;
    private int People_InitialScore = 3;
    private int Food_InitialScore = 5;
    private int Cotton_InitialScore = 5;
    private int Pollution_InitialScore = 1;
    private int Factory1_InitialScore = 0;
    private int Factory2_InitialScore = 0;
    private int Factory3_InitialScore = 0;
    private int Farm1_InitialScore = 0;
    private int Farm2_InitialScore = 0;
    private int Farm3_InitialScore = 0;
    private int Park1_InitialScore = 0;
    private int Park2_InitialScore = 0;
    private int Park3_InitialScore = 0;

    // team2
    private int Gold_InitialScore_2 = 10;
    private int Metal_InitialScore_2 = 10;
    private int People_InitialScore_2 = 3;
    private int Food_InitialScore_2 = 5;
    private int Cotton_InitialScore_2 = 5;
    private int Pollution_InitialScore_2 = 1;
    private int Factory1_InitialScore_2 = 0;
    private int Factory2_InitialScore_2 = 0;
    private int Factory3_InitialScore_2 = 0;
    private int Farm1_InitialScore_2 = 0;
    private int Farm2_InitialScore_2 = 0;
    private int Farm3_InitialScore_2 = 0;
    private int Park1_InitialScore_2 = 0;
    private int Park2_InitialScore_2 = 0;
    private int Park3_InitialScore_2 = 0;

    //Make most references to the values of resources at the dictionary level rather than individual variables
    void Start()
    {

        People_DispScore(0);
        Food_DispScore(0);
        Pollution_DispScore(0);
        Gold_DispScore(0);
        Metal_DispScore(0);
        Cotton_DispScore(0);
        Factory1_DispScore(0);
        Factory2_DispScore(0);
        Factory3_DispScore(0);
        Farm1_DispScore(0);
        Farm2_DispScore(0);
        Farm3_DispScore(0);
        Park1_DispScore(0);
        Park2_DispScore(0);
        Park3_DispScore(0);

        People_DispScore_2(0);
        Food_DispScore_2(0);
        Pollution_DispScore_2(0);
        Gold_DispScore_2(0);
        Metal_DispScore_2(0);
        Cotton_DispScore_2(0);
        Factory1_DispScore_2(0);
        Factory2_DispScore_2(0);
        Factory3_DispScore_2(0);
        Farm1_DispScore_2(0);
        Farm2_DispScore_2(0);
        Farm3_DispScore_2(0);
        Park1_DispScore_2(0);
        Park2_DispScore_2(0);
        Park3_DispScore_2(0);

        /*teamResources = new Dictionary<string, int>()
        {
            {"gold", 10},
            {"metal", 10},
            {"food", 5},
            {"cotton", 5}
        };*/
    }


    /*public void BuyProducer(Dictionary<string, int> prodCost)
    {
        foreach (string key in prodCost.Keys)
        {
            teamResources[key] = teamResources[key] - prodCost[key];
        }
    }

    public void EndRound()
    {
        foreach (Producer prod in producersOwned)
        {
            foreach (string key in prod.runCost.Keys)
            {
                teamResources[key] = teamResources[key] - prod.runCost[key];
            }
            foreach (string key in prod.runProduction.Keys)
            {
                teamResources[key] = teamResources[key] + prod.runProduction[key];
            }
        }
    }*/

    // team 1
    public void People_DispScore(int PeopleScore)
    {
        People_InitialScore += PeopleScore;
        Current_People.text = "<color=#ffffff>" + People_InitialScore.ToString() + "</color>";
    }

    public void Food_DispScore(int FoodScore)
    {
        Food_InitialScore += FoodScore;
        Current_Food.text = "<color=#ffffff>" + Food_InitialScore.ToString() + "</color>";
    }

    public void Pollution_DispScore(int PollutionScore)
    {
        Pollution_InitialScore += PollutionScore;
        Current_Pollution.text = "<color=#ffffff>" + Pollution_InitialScore.ToString() + "</color>";
    }

    public void Gold_DispScore(int GoldScore)
    {
            Gold_InitialScore += GoldScore;
            Current_Gold.text = "<color=#ffffff>" + Gold_InitialScore.ToString() + "</color>";
    }

    public void Metal_DispScore(int MetalScore)
    {
        Metal_InitialScore += MetalScore;
        Current_Metal.text = "<color=#ffffff>" + Metal_InitialScore.ToString() + "</color>";
    }

    public void Cotton_DispScore(int CottonScore)
    {
        Cotton_InitialScore += CottonScore;
        Current_Cotton.text = "<color=#ffffff>" + Cotton_InitialScore.ToString() + "</color>";
    }

    public void Factory1_DispScore(int FactoryScore)
    {
        Factory1_InitialScore += FactoryScore;
        Current_Factory1.text = "<color=#ffffff>" + Factory1_InitialScore.ToString() + "</color>";
    }

    public void Factory2_DispScore(int FactoryScore)
    {
        Factory2_InitialScore += FactoryScore;
        Current_Factory2.text = "<color=#ffffff>" + Factory2_InitialScore.ToString() + "</color>";
    }

    public void Factory3_DispScore(int FactoryScore)
    {
        Factory3_InitialScore += FactoryScore;
        Current_Factory3.text = "<color=#ffffff>" + Factory3_InitialScore.ToString() + "</color>";
    }

    public void Farm1_DispScore(int FarmScore)
    {
        Farm1_InitialScore += FarmScore;
        Current_Farm1.text = "<color=#ffffff>" + Farm1_InitialScore.ToString() + "</color>";
    }

    public void Farm2_DispScore(int FarmScore)
    {
        Farm2_InitialScore += FarmScore;
        Current_Farm2.text = "<color=#ffffff>" + Farm2_InitialScore.ToString() + "</color>";
    }

    public void Farm3_DispScore(int FarmScore)
    {
        Farm3_InitialScore += FarmScore;
        Current_Farm3.text = "<color=#ffffff>" + Farm3_InitialScore.ToString() + "</color>";
    }

    public void Park1_DispScore(int ParkScore)
    {
        Park1_InitialScore += ParkScore;
        Current_Park1.text = "<color=#ffffff>" + Park1_InitialScore.ToString() + "</color>";
    }

    public void Park2_DispScore(int ParkScore)
    {
        Park2_InitialScore += ParkScore;
        Current_Park2.text = "<color=#ffffff>" + Park2_InitialScore.ToString() + "</color>";
    }

    public void Park3_DispScore(int ParkScore)
    {
        Park3_InitialScore += ParkScore;
        Current_Park3.text = "<color=#ffffff>" + Park3_InitialScore.ToString() + "</color>";
    }

    public void Producing()
    {
        Pollution_InitialScore -= 1 * Park1_InitialScore;
        Current_Pollution.text = "<color=#ffffff>" + Pollution_InitialScore.ToString() + "</color>";
        Pollution_InitialScore -= 2 * Park2_InitialScore;
        Current_Pollution.text = "<color=#ffffff>" + Pollution_InitialScore.ToString() + "</color>";
        Pollution_InitialScore -= 3 * Park3_InitialScore;
        Current_Pollution.text = "<color=#ffffff>" + Pollution_InitialScore.ToString() + "</color>";

        Pollution_InitialScore += 1 * Factory1_InitialScore;
        Current_Pollution.text = "<color=#ffffff>" + Pollution_InitialScore.ToString() + "</color>";
        Pollution_InitialScore += 2 * Factory2_InitialScore;
        Current_Pollution.text = "<color=#ffffff>" + Pollution_InitialScore.ToString() + "</color>";
        Pollution_InitialScore += 3 * Factory3_InitialScore;
        Current_Pollution.text = "<color=#ffffff>" + Pollution_InitialScore.ToString() + "</color>";

        People_InitialScore += 2 * Park1_InitialScore;
        Current_People.text = "<color=#ffffff>" + People_InitialScore.ToString() + "</color>";
        People_InitialScore += 3 * Park2_InitialScore;
        Current_People.text = "<color=#ffffff>" + People_InitialScore.ToString() + "</color>";
        People_InitialScore += 4 * Park3_InitialScore;
        Current_People.text = "<color=#ffffff>" + People_InitialScore.ToString() + "</color>";

        Gold_InitialScore += 2 * Factory1_InitialScore;
        Current_Gold.text = "<color=#ffffff>" + Gold_InitialScore.ToString() + "</color>";
        Gold_InitialScore += 2 * Factory2_InitialScore;
        Current_Gold.text = "<color=#ffffff>" + Gold_InitialScore.ToString() + "</color>";
        Gold_InitialScore += 4 * Factory3_InitialScore;
        Current_Gold.text = "<color=#ffffff>" + Gold_InitialScore.ToString() + "</color>";

        Metal_InitialScore += 2 * Factory1_InitialScore;
        Current_Metal.text = "<color=#ffffff>" + Metal_InitialScore.ToString() + "</color>";
        Metal_InitialScore += 3 * Factory2_InitialScore;
        Current_Metal.text = "<color=#ffffff>" + Metal_InitialScore.ToString() + "</color>";
        Metal_InitialScore += 4 * Factory3_InitialScore;
        Current_Metal.text = "<color=#ffffff>" + Metal_InitialScore.ToString() + "</color>";

        Food_InitialScore += 2 * Farm1_InitialScore;
        Current_Food.text = "<color=#ffffff>" + Food_InitialScore.ToString() + "</color>";
        Food_InitialScore += 3 * Farm2_InitialScore;
        Current_Food.text = "<color=#ffffff>" + Food_InitialScore.ToString() + "</color>";
        Food_InitialScore += 4 * Farm3_InitialScore;
        Current_Food.text = "<color=#ffffff>" + Food_InitialScore.ToString() + "</color>";


    }


    // team2
    public void People_DispScore_2(int PeopleScore_2)
    {
        People_InitialScore_2 += PeopleScore_2;
        Current_People_2.text = "<color=#ffffff>" + People_InitialScore_2.ToString() + "</color>";
    }

    public void Food_DispScore_2(int FoodScore_2)
    {
        Food_InitialScore_2 += FoodScore_2;
        Current_Food_2.text = "<color=#ffffff>" + Food_InitialScore_2.ToString() + "</color>";
    }

    public void Pollution_DispScore_2(int PollutionScore_2)
    {
        Pollution_InitialScore_2 += PollutionScore_2;
        Current_Pollution_2.text = "<color=#ffffff>" + Pollution_InitialScore_2.ToString() + "</color>";
    }

    public void Gold_DispScore_2(int GoldScore_2)
    {
        Gold_InitialScore_2 += GoldScore_2;
        Current_Gold_2.text = "<color=#ffffff>" + Gold_InitialScore_2.ToString() + "</color>";
    }

    public void Metal_DispScore_2(int MetalScore)
    {
        Metal_InitialScore_2 += MetalScore;
        Current_Metal_2.text = "<color=#ffffff>" + Metal_InitialScore_2.ToString() + "</color>";
    }

    public void Cotton_DispScore_2(int CottonScore)
    {
        Cotton_InitialScore_2 += CottonScore;
        Current_Cotton_2.text = "<color=#ffffff>" + Cotton_InitialScore_2.ToString() + "</color>";
    }

    public void Factory1_DispScore_2(int FactoryScore)
    {
        Factory1_InitialScore_2 += FactoryScore;
        Current_Factory1_2.text = "<color=#ffffff>" + Factory1_InitialScore_2.ToString() + "</color>";
    }

    public void Factory2_DispScore_2(int FactoryScore)
    {
        Factory2_InitialScore_2 += FactoryScore;
        Current_Factory2_2.text = "<color=#ffffff>" + Factory2_InitialScore_2.ToString() + "</color>";
    }

    public void Factory3_DispScore_2(int FactoryScore)
    {
        Factory3_InitialScore_2 += FactoryScore;
        Current_Factory3_2.text = "<color=#ffffff>" + Factory3_InitialScore_2.ToString() + "</color>";
    }

    public void Farm1_DispScore_2(int FarmScore)
    {
        Farm1_InitialScore_2 += FarmScore;
        Current_Farm1_2.text = "<color=#ffffff>" + Farm1_InitialScore_2.ToString() + "</color>";
    }

    public void Farm2_DispScore_2(int FarmScore)
    {
        Farm2_InitialScore_2 += FarmScore;
        Current_Farm2_2.text = "<color=#ffffff>" + Farm2_InitialScore_2.ToString() + "</color>";
    }

    public void Farm3_DispScore_2(int FarmScore)
    {
        Farm3_InitialScore_2 += FarmScore;
        Current_Farm3_2.text = "<color=#ffffff>" + Farm3_InitialScore_2.ToString() + "</color>";
    }

    public void Park1_DispScore_2(int ParkScore)
    {
        Park1_InitialScore_2 += ParkScore;
        Current_Park1_2.text = "<color=#ffffff>" + Park1_InitialScore_2.ToString() + "</color>";
    }

    public void Park2_DispScore_2(int ParkScore)
    {
        Park2_InitialScore_2 += ParkScore;
        Current_Park2_2.text = "<color=#ffffff>" + Park2_InitialScore_2.ToString() + "</color>";
    }

    public void Park3_DispScore_2(int ParkScore)
    {
        Park3_InitialScore_2 += ParkScore;
        Current_Park3_2.text = "<color=#ffffff>" + Park3_InitialScore_2.ToString() + "</color>";
    }

    public void Producing_2()
    {
        Pollution_InitialScore_2 -= 1 * Park1_InitialScore_2;
        Current_Pollution_2.text = "<color=#ffffff>" + Pollution_InitialScore_2.ToString() + "</color>";
        Pollution_InitialScore_2 -= 2 * Park2_InitialScore_2;
        Current_Pollution_2.text = "<color=#ffffff>" + Pollution_InitialScore_2.ToString() + "</color>";
        Pollution_InitialScore_2 -= 3 * Park3_InitialScore_2;
        Current_Pollution_2.text = "<color=#ffffff>" + Pollution_InitialScore_2.ToString() + "</color>";

        Pollution_InitialScore_2 += 1 * Factory1_InitialScore_2;
        Current_Pollution_2.text = "<color=#ffffff>" + Pollution_InitialScore_2.ToString() + "</color>";
        Pollution_InitialScore_2 += 2 * Factory2_InitialScore_2;
        Current_Pollution_2.text = "<color=#ffffff>" + Pollution_InitialScore_2.ToString() + "</color>";
        Pollution_InitialScore_2 += 3 * Factory3_InitialScore_2;
        Current_Pollution_2.text = "<color=#ffffff>" + Pollution_InitialScore_2.ToString() + "</color>";

        People_InitialScore_2 += 2 * Park1_InitialScore_2;
        Current_People_2.text = "<color=#ffffff>" + People_InitialScore_2.ToString() + "</color>";
        People_InitialScore_2 += 3 * Park2_InitialScore_2;
        Current_People_2.text = "<color=#ffffff>" + People_InitialScore_2.ToString() + "</color>";
        People_InitialScore_2 += 4 * Park3_InitialScore_2;
        Current_People_2.text = "<color=#ffffff>" + People_InitialScore_2.ToString() + "</color>";

        Gold_InitialScore_2 += 2 * Factory1_InitialScore_2;
        Current_Gold_2.text = "<color=#ffffff>" + Gold_InitialScore_2.ToString() + "</color>";
        Gold_InitialScore_2 += 2 * Factory2_InitialScore_2;
        Current_Gold_2.text = "<color=#ffffff>" + Gold_InitialScore_2.ToString() + "</color>";
        Gold_InitialScore_2 += 4 * Factory3_InitialScore_2;
        Current_Gold_2.text = "<color=#ffffff>" + Gold_InitialScore_2.ToString() + "</color>";

        Metal_InitialScore_2 += 2 * Factory1_InitialScore_2;
        Current_Metal_2.text = "<color=#ffffff>" + Metal_InitialScore_2.ToString() + "</color>";
        Metal_InitialScore_2 += 3 * Factory2_InitialScore_2;
        Current_Metal_2.text = "<color=#ffffff>" + Metal_InitialScore_2.ToString() + "</color>";
        Metal_InitialScore_2 += 4 * Factory3_InitialScore_2;
        Current_Metal_2.text = "<color=#ffffff>" + Metal_InitialScore_2.ToString() + "</color>";

        Food_InitialScore_2 += 2 * Farm1_InitialScore_2;
        Current_Food_2.text = "<color=#ffffff>" + Food_InitialScore_2.ToString() + "</color>";
        Food_InitialScore_2 += 3 * Farm2_InitialScore_2;
        Current_Food_2.text = "<color=#ffffff>" + Food_InitialScore_2.ToString() + "</color>";
        Food_InitialScore_2 += 4 * Farm3_InitialScore_2;
        Current_Food_2.text = "<color=#ffffff>" + Food_InitialScore_2.ToString() + "</color>";
               
    }

    public void Trading()
    {
        //Team 1
        Gold_InitialScore -= int.Parse(offerTxT_Gold.text);
        Current_Gold.text = "<color=#ffffff>" + Gold_InitialScore.ToString() + "</color>";
        Metal_InitialScore -= int.Parse(offerTxT_Metal.text);
        Current_Metal.text = "<color=#ffffff>" + Metal_InitialScore.ToString() + "</color>";
        Cotton_InitialScore -= int.Parse(offerTxT_Cotton.text);
        Current_Cotton.text = "<color=#ffffff>" + Cotton_InitialScore.ToString() + "</color>";
        Food_InitialScore -= int.Parse(offerTxT_Food.text);
        Current_Food.text = "<color=#ffffff>" + Food_InitialScore.ToString() + "</color>";

        Gold_InitialScore += int.Parse(returnTxT_Gold.text);
        Current_Gold.text = "<color=#ffffff>" + Gold_InitialScore.ToString() + "</color>";
        Metal_InitialScore += int.Parse(returnTxT_Metal.text);
        Current_Metal.text = "<color=#ffffff>" + Metal_InitialScore.ToString() + "</color>";
        Cotton_InitialScore += int.Parse(returnTxT_Cotton.text);
        Current_Cotton.text = "<color=#ffffff>" + Cotton_InitialScore.ToString() + "</color>";
        Food_InitialScore += int.Parse(returnTxT_Food.text);
        Current_Food.text = "<color=#ffffff>" + Food_InitialScore.ToString() + "</color>";

        // Team 2
        Gold_InitialScore_2 += int.Parse(offerTxT_Gold.text);
        Current_Gold_2.text = "<color=#ffffff>" + Gold_InitialScore_2.ToString() + "</color>";
        Metal_InitialScore_2 += int.Parse(offerTxT_Metal.text);
        Current_Metal_2.text = "<color=#ffffff>" + Metal_InitialScore_2.ToString() + "</color>";
        Cotton_InitialScore_2 += int.Parse(offerTxT_Cotton.text);
        Current_Cotton_2.text = "<color=#ffffff>" + Cotton_InitialScore_2.ToString() + "</color>";
        Food_InitialScore_2 += int.Parse(offerTxT_Food.text);
        Current_Food_2.text = "<color=#ffffff>" + Food_InitialScore_2.ToString() + "</color>";

        Gold_InitialScore_2 -= int.Parse(returnTxT_Gold.text);
        Current_Gold_2.text = "<color=#ffffff>" + Gold_InitialScore_2.ToString() + "</color>";
        Metal_InitialScore_2 -= int.Parse(returnTxT_Metal.text);
        Current_Metal_2.text = "<color=#ffffff>" + Metal_InitialScore_2.ToString() + "</color>";
        Cotton_InitialScore_2 -= int.Parse(returnTxT_Cotton.text);
        Current_Cotton_2.text = "<color=#ffffff>" + Cotton_InitialScore_2.ToString() + "</color>";
        Food_InitialScore_2 -= int.Parse(returnTxT_Food.text);
        Current_Food_2.text = "<color=#ffffff>" + Food_InitialScore_2.ToString() + "</color>";              
    }

    void Update()
    {

    }
}
