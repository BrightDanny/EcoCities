using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //StartValues
    public int starterMoney;
    public int starterEnergy;
    public int starterPopulation;
    //integers
    public int population;
    public int money;
    public int energyValue;
    public int energyCost;
    public int planetPoints;
    public int peoplePoints;
    public int productionPoints;

    //UI elements
    public Text pop;
    public Text mon;

    public Text planetP;
    public Text peopleP;
    public Text productionP;

    void Start()
    {
        //initialize starter values
        money = starterMoney;
        energyValue = starterEnergy;
        population = starterPopulation;

        //search for gameobjects
        pop = GameObject.Find("UI/Canvas/Population/Amount").GetComponent<Text>();
        mon = GameObject.Find("UI/Canvas/Money/Amount").GetComponent<Text>();
        planetP = GameObject.Find("UI/Canvas/Planet/Amount").GetComponent<Text>();
        peopleP = GameObject.Find("UI/Canvas/People/Amount").GetComponent<Text>();
        productionP = GameObject.Find("UI/Canvas/Production/Amount").GetComponent<Text>();

        //Set starter values
        mon.text = money.ToString();
        pop.text = starterPopulation.ToString();
    }

    public void UpdateScore(int eCost, int eValue, int plaPoints, int peoPoints, int proPoints, int mCost)
    {
        //update values
        energyValue += eValue;
        energyCost += eCost;
        planetPoints += plaPoints;
        peoplePoints += peoPoints;
        productionPoints += proPoints;
        money -= mCost;
        //update text/score
        mon.text = money.ToString();
        planetP.text = planetPoints.ToString();
        productionP.text = productionPoints.ToString();
        peopleP.text = peoplePoints.ToString();

        //update Population

        List<int> points = new List<int>() {peoplePoints, planetPoints, productionPoints};

        points.Sort();


        if (Mathf.Abs(points[0] - points[2]) < 5)
        {
            population = (planetPoints + peoplePoints + productionPoints) * 20;
            pop.text = population.ToString();
        }
        else
        {
            population = (planetPoints + peoplePoints + productionPoints) * 10;
            pop.text = population.ToString();
        }


    }
}
