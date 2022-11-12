using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "FishDatabase", menuName = "Database/FishDatabase")]
public class SO_FishDatabase : ScriptableObject
{
    public List<SO_ItemFish> allFish;
}
