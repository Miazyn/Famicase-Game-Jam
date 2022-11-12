using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishing : MonoBehaviour
{
    string fishButton = "Fish";
    List<SO_ItemFish> allFish, possibleFishes;
    [SerializeField] SO_FishDatabase fishDatabase;

    private void Start()
    {
        allFish = fishDatabase.allFish;
    }
    private void Update()
    {
        if (Input.GetButtonDown(fishButton) || Input.GetMouseButtonDown(0))
        {
            Fish();
        }
    }

    private void Fish()
    {
        possibleFishes.Clear();
        for (int i = 0; i < allFish.Count; i++)
        {
            if (allFish[i].difficulty <= 10)
            {
                possibleFishes.Add(allFish[i]);
            }
        }
    }
}
