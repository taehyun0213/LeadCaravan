using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTestScript : MonoBehaviour
{
    private int park_t1;
    private int factory_t1;
    private int farm_t1;

    private int park_t2;
    private int factory_t2;
    private int farm_t2;

    void Start()
    {
        park_t1 = Random.Range(1, 4);
        factory_t1 = Random.Range(1, 4);
        farm_t1 = Random.Range(1, 4);

        park_t2 = Random.Range(1, 4);
        factory_t2 = Random.Range(1, 4);
        farm_t2 = Random.Range(1, 4);

        RandomMaking();
    }

    void RandomMaking()
    {
        if (park_t1 == 1)
        {
            var park = GameObject.Find("Button_T1Park1");
            park.SetActive(true);
        }
        else if (park_t1 == 2)
        {
            var park = GameObject.Find("Button_T1Park2");
            park.SetActive(true);
        }
        else if (park_t1 == 3)
        {
            var park = GameObject.Find("Button_T1Park3");
            park.SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
