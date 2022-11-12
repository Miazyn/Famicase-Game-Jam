using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemDatabase", menuName = "Database/ItemDatabase")]
public class SO_ItemDatabase : ScriptableObject
{
    public List<SO_Items> allItems;
}
