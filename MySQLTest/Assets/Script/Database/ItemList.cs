using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    public string[] items;

    /* Begin Play Function */
    IEnumerator Start()
    {
        WWW itemsData = new WWW("https://shiplightsstudio.000webhostapp.com/items_data.php");
        yield return itemsData;
        string itemsDatainString = itemsData.text;
        print(itemsDatainString);
        items = itemsDatainString.Split(';');
        print(GetDataValue("Type:", items[0]));
    }


    /* Function to Get data value from database with selected parameter and type*/
    string GetDataValue(string Name, string IndexData)
    {
        string value = IndexData.Substring(IndexData.IndexOf(Name) + Name.Length);
        value = value.Remove(value.IndexOf("|"));
        return value;
    }

}
