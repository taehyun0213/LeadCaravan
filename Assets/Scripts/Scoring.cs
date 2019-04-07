using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    private GameUI GameUI;

    private int park_t1;
    private int factory_t1;
    private int farm_t1;

    private int park_t2;
    private int factory_t2;
    private int farm_t2;

    public GameObject ParkCard1;
    public GameObject ParkCard2;
    public GameObject ParkCard3;
    public GameObject FactoryCard1;
    public GameObject FactoryCard2;
    public GameObject FactoryCard3;
    public GameObject FarmCard1;
    public GameObject FarmCard2;
    public GameObject FarmCard3;

    public GameObject ParkCard1_2;
    public GameObject ParkCard2_2;
    public GameObject ParkCard3_2;
    public GameObject FactoryCard1_2;
    public GameObject FactoryCard2_2;
    public GameObject FactoryCard3_2;
    public GameObject FarmCard1_2;
    public GameObject FarmCard2_2;
    public GameObject FarmCard3_2;

    void Start()
    {
        GameUI = GameObject.Find("GameUI").GetComponent<GameUI>();

        park_t1 = Random.Range(1, 4);
        factory_t1 = Random.Range(1, 4);
        farm_t1 = Random.Range(1, 4);

        park_t2 = Random.Range(1, 4);
        factory_t2 = Random.Range(1, 4);
        farm_t2 = Random.Range(1, 4);

        RandomParkMaking();
        RandomFactoryMaking();
        RandomFarmMaking();

        RandomParkMaking2();
        RandomFactoryMaking2();
        RandomFarmMaking2();
    }

    public void NextRound_Team1()
    {
        ParkCard1.gameObject.SetActive(false);
        ParkCard2.gameObject.SetActive(false);
        ParkCard3.gameObject.SetActive(false);
        FactoryCard1.gameObject.SetActive(false);
        FactoryCard1.gameObject.SetActive(false);
        FactoryCard1.gameObject.SetActive(false);
        FarmCard1.gameObject.SetActive(false);
        FarmCard2.gameObject.SetActive(false);
        FarmCard3.gameObject.SetActive(false);

        park_t1 = Random.Range(1, 4);
        factory_t1 = Random.Range(1, 4);
        farm_t1 = Random.Range(1, 4);
               
        RandomParkMaking();
        RandomFactoryMaking();
        RandomFarmMaking();
    }

    public void NextRound_Team2()
    {
        ParkCard1_2.gameObject.SetActive(false);
        ParkCard2_2.gameObject.SetActive(false);
        ParkCard3_2.gameObject.SetActive(false);
        FactoryCard1_2.gameObject.SetActive(false);
        FactoryCard2_2.gameObject.SetActive(false);
        FactoryCard3_2.gameObject.SetActive(false);
        FarmCard1_2.gameObject.SetActive(false);
        FarmCard2_2.gameObject.SetActive(false);
        FarmCard3_2.gameObject.SetActive(false);

        park_t2 = Random.Range(1, 4);
        factory_t2 = Random.Range(1, 4);
        farm_t2 = Random.Range(1, 4);

        RandomParkMaking2();
        RandomFactoryMaking2();
        RandomFarmMaking2();
    }



    void RandomParkMaking()
    {
        if (park_t1 == 1)
        {
            ParkCard1.gameObject.SetActive(true);
        }
        else if (park_t1 == 2)
        {
            ParkCard2.gameObject.SetActive(true);
        }
        else if (park_t1 == 3)
        {
            ParkCard3.gameObject.SetActive(true);
        }
    }

    void RandomFactoryMaking()
    {
        if (factory_t1 == 1)
        {
            FactoryCard1.gameObject.SetActive(true);
        }
        else if (factory_t1 == 2)
        {
            FactoryCard2.gameObject.SetActive(true);
        }
        else if (factory_t1 == 3)
        {
            FactoryCard3.gameObject.SetActive(true);
        }
    }

    void RandomFarmMaking()
    {
        if (farm_t1 == 1)
        {
            FarmCard1.gameObject.SetActive(true);
        }
        else if (farm_t1 == 2)
        {
            FarmCard2.gameObject.SetActive(true);
        }
        else if (farm_t1 == 3)
        {
            FarmCard3.gameObject.SetActive(true);
        }
    }

    void RandomParkMaking2()
    {
        if (park_t2 == 1)
        {
            ParkCard1_2.gameObject.SetActive(true);
        }
        else if (park_t2 == 2)
        {
            ParkCard2_2.gameObject.SetActive(true);
        }
        else if (park_t2 == 3)
        {
            ParkCard3_2.gameObject.SetActive(true);
        }
    }

    void RandomFactoryMaking2()
    {
        if (factory_t2 == 1)
        {
            FactoryCard1_2.gameObject.SetActive(true);
        }
        else if (factory_t2 == 2)
        {
            FactoryCard2_2.gameObject.SetActive(true);
        }
        else if (factory_t2 == 3)
        {
            FactoryCard3_2.gameObject.SetActive(true);
        }
    }

    void RandomFarmMaking2()
    {
        if (farm_t2 == 1)
        {
            FarmCard1_2.gameObject.SetActive(true);
        }
        else if (farm_t2 == 2)
        {
            FarmCard2_2.gameObject.SetActive(true);
        }
        else if (farm_t2 == 3)
        {
            FarmCard3_2.gameObject.SetActive(true);
        }
    }

    // team 1
    public void ParkScore()
    {     
        if (park_t1 == 1)
        {
            GameUI.Park1_DispScore(1);
            GameUI.Gold_DispScore(-2);
            GameUI.Metal_DispScore(-3);
        }
        else if (park_t1 == 2)
        {
            GameUI.Park2_DispScore(1);
            GameUI.Gold_DispScore(-4);
            GameUI.Metal_DispScore(-3);
        }
        else if (park_t1 == 3)
        {
            GameUI.Park3_DispScore(1);
            GameUI.Gold_DispScore(-5);
            GameUI.Metal_DispScore(-4);
        }
    }

    public void FactoryScore()
    {
        if (factory_t1 == 1)
        {
            GameUI.Factory1_DispScore(1);
            GameUI.Gold_DispScore(-2);
            GameUI.Metal_DispScore(-4);
        }
        else if (factory_t1 == 2)
        {
            GameUI.Factory2_DispScore(1);
            GameUI.Gold_DispScore(-3);
            GameUI.Metal_DispScore(-5);
        }
        else if (factory_t1 == 3)
        {
            GameUI.Factory3_DispScore(1);
            GameUI.Gold_DispScore(-4);
            GameUI.Metal_DispScore(-6);
        }

    }

    public void FarmScore()
    {
        if (farm_t1 == 1)
        {
            GameUI.Farm1_DispScore(1);
            GameUI.Gold_DispScore(-4);
            GameUI.Metal_DispScore(-1);
        }
        else if (farm_t1 == 2)
        {
            GameUI.Farm2_DispScore(1);
            GameUI.Gold_DispScore(-4);
            GameUI.Metal_DispScore(-2);
        }
        else if (farm_t1 == 3)
        {
            GameUI.Farm3_DispScore(1);
            GameUI.Gold_DispScore(-4);
            GameUI.Metal_DispScore(-4);
        }
    }
    
    
    // team 2
    public void ParkScore_2()
    {
        if (park_t2 == 1)
        {
            GameUI.Park1_DispScore_2(1);
            GameUI.Gold_DispScore_2(-2);
            GameUI.Metal_DispScore_2(-3);
        }
        else if (park_t2 == 2)
        {
            GameUI.Park2_DispScore_2(1);
            GameUI.Gold_DispScore_2(-4);
            GameUI.Metal_DispScore_2(-3);
        }
        else if (park_t2 == 3)
        {
            GameUI.Park3_DispScore_2(1);
            GameUI.Gold_DispScore_2(-5);
            GameUI.Metal_DispScore_2(-4);
        }
    }

    public void FactoryScore_2()
    {
        if (factory_t2 == 1)
        {
            GameUI.Factory1_DispScore_2(1);
            GameUI.Gold_DispScore_2(-2);
            GameUI.Metal_DispScore_2(-4);
        }
        else if (factory_t2 == 2)
        {
            GameUI.Factory2_DispScore_2(1);
            GameUI.Gold_DispScore_2(-3);
            GameUI.Metal_DispScore_2(-5);
        }
        else if (factory_t2 == 3)
        {
            GameUI.Factory3_DispScore_2(1);
            GameUI.Gold_DispScore_2(-4);
            GameUI.Metal_DispScore_2(-6);
        }
    }

    public void FarmScore_2()
    {
        if (farm_t2 == 1)
        {
            GameUI.Farm1_DispScore_2(1);
            GameUI.Gold_DispScore_2(-4);
            GameUI.Metal_DispScore_2(-1);
        }
        else if (farm_t2 == 2)
        {
            GameUI.Farm2_DispScore_2(1);
            GameUI.Gold_DispScore_2(-4);
            GameUI.Metal_DispScore_2(-2);
        }
        else if (farm_t2 == 3)
        {
            GameUI.Farm3_DispScore_2(1);
            GameUI.Gold_DispScore_2(-4);
            GameUI.Metal_DispScore_2(-4);
        }
    }



}
