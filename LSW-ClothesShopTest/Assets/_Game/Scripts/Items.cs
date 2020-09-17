using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Items : MonoBehaviour
{   
    public int item;
    public LoadItems itemsList;
    public List<Sprite> myList = new List<Sprite>();

    // Start is called before the first frame update
    void Start()
    {
        item = 0;
        this.GetComponent<Image>().sprite = myList[item];
    }
 

    public void AddToList(int itemID)
    {
        myList.Add(itemsList.itemsArray[itemID]);
        
    }

    public void nextItem()
    {        
        if (item < myList.Count-1)
        {
            item += 1;            
        } else
        {
            item = 0;
        }        
        this.GetComponent<Image>().sprite = myList[item];
    }

    public void previousItem()
    {        
        if (item == 0)
        {
            item = myList.Count - 1;
        }
        else
        {
            item -= 1;
        }       
        this.GetComponent<Image>().sprite = myList[item];
    }
}
