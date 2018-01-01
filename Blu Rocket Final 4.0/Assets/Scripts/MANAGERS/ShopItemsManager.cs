using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemsManager : MonoBehaviour {
    

    public GameObject ship0body;
    public GameObject ship1body;
    public GameObject ship2body;

    int currnetItemNum = 1;
    
    Material[] set0= new Material[2];
    Material[] set1 = new Material[2];
    Material[] set2 = new Material[2];
    public static Object[] materials1;
    public static Object[] materials2;
    public static Object[] materials3;
    public static Object[] materials4;
    public static Object[] materials5;
    public static Object[] materials6;
    public static Object[] materials7;
    public static Object[] materials8;
    public static Object[] materials9;
    public static Object[] materials10;
    
    



    // Use this for initialization
    void Start () {


        setMatererialsFromResources();      

    }

    // Update is called once per frame
    void Update()
    {
        
   
        if (set0[0] != null && set1[1] != null && set2 != null)
        {
            ship0body.GetComponent<Renderer>().materials = set0;
            ship1body.GetComponent<Renderer>().materials = set1;
            ship2body.GetComponent<Renderer>().materials = set2;
        }
        
        
       
    }

    public void checkSwipe()
    {
        switch (currnetItemNum)
        {
          

            case 1:
                set0 = setTexture("rocket10");
                set1 = setTexture("rocket1");
                set2 = setTexture("rocket2");

                currnetItemNum++;

                break;

            case 2:
                set0 = setTexture("rocket1");
                set1 = setTexture("rocket2");
                set2 = setTexture("rocket3");

                currnetItemNum++;

                break;
            case 3:
                set0 = setTexture("rocket2");
                set1 = setTexture("rocket3");
                set2 = setTexture("rocket4");

                currnetItemNum++;

                break;
            case 4:
                set0 = setTexture("rocket3");
                set1 = setTexture("rocket4");
                set2 = setTexture("rocket5");

                currnetItemNum++;

                break;
            case 5:
                set0 = setTexture("rocket4");
                set1 = setTexture("rocket5");
                set2 = setTexture("rocket6");

                currnetItemNum++;

                break;
            case 6:
                
                set0 = setTexture("rocket5");
                set1 = setTexture("rocket6");
                set2 = setTexture("rocket7");

                currnetItemNum++;

                break;
            case 7:
                set0 = setTexture("rocket6");
                set1 = setTexture("rocket7");
                set2 = setTexture("rocket8");

                currnetItemNum++;

                break;
            case 8:
                set0 = setTexture("rocket7");
                set1 = setTexture("rocket8");
                set2 = setTexture("rocket9");

                currnetItemNum++;

                break;
            case 9:
                set0 = setTexture("rocket8");
                set1 = setTexture("rocket9");
                set2 = setTexture("rocket10");

                currnetItemNum++;
                break;
            case 10:
                set0 = setTexture("rocket9");
                set1 = setTexture("rocket10");
                set2 = setTexture("rocket1");

                currnetItemNum = 1;

                break;




        }
    }

    public Material[] setTexture(string name)
    {
        Material[] currentSet = new Material[2];
        switch (name)
        {
            case "rocket1":
                currentSet[0] = (Material) materials1[0];
                currentSet[1] = (Material)materials1[1]; 
                return currentSet;
                break;

            case "rocket2":
                currentSet[0] = (Material)materials2[0];
                currentSet[1] = (Material)materials2[1];
                return currentSet;
                break;

            case "rocket3":
                currentSet[0] = (Material)materials3[0];
                currentSet[1] = (Material)materials3[1];
                return currentSet;
                break;

            case "rocket4":
                currentSet[0] = (Material)materials4[0];
                currentSet[1] = (Material)materials4[1];
                return currentSet;
                break;

            case "rocket5":
                currentSet[0] = (Material)materials5[0];
                currentSet[1] = (Material)materials5[1];
                return currentSet;
                break;

            case "rocket6":
                currentSet[0] = (Material)materials6[0];
                currentSet[1] = (Material)materials6[1];
                return currentSet;
                break;

            case "rocket7":
                currentSet[0] = (Material)materials7[0];
                currentSet[1] = (Material)materials7[1];
                return currentSet;
                break;

            case "rocket8":
                currentSet[0] = (Material)materials8[0];
                currentSet[1] = (Material)materials8[1];
                return currentSet;
                break;

            case "rocket9":
                currentSet[0] = (Material)materials9[0];
                currentSet[1] = (Material)materials9[1];
                return currentSet;
                break;

            case "rocket10":
                currentSet[0] = (Material)materials10[0];
                currentSet[1] = (Material)materials10[1];
                return currentSet;
                break;




        }
        return currentSet;
    }

    public void setMatererialsFromResources()
    {
        materials1 = Resources.LoadAll("Material/Rocket_1", typeof(Material));
        materials2 = Resources.LoadAll("Material/Rocket_2", typeof(Material));
        materials3 = Resources.LoadAll("Material/Rocket_3", typeof(Material));
        materials4 = Resources.LoadAll("Material/Rocket_4", typeof(Material));
        materials5 = Resources.LoadAll("Material/Rocket_5", typeof(Material));
        materials6 = Resources.LoadAll("Material/Rocket_6", typeof(Material));
        materials7 = Resources.LoadAll("Material/Rocket_7", typeof(Material));
        materials8 = Resources.LoadAll("Material/Rocket_8", typeof(Material));
        materials9 = Resources.LoadAll("Material/Rocket_9", typeof(Material));
        materials10 = Resources.LoadAll("Material/Rocket_10", typeof(Material));
        

        
    }
   
    }
   