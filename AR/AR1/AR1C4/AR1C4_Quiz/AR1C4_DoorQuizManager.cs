using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR1C4_DoorQuizManager : MonoBehaviour
{
    [SerializeField]
    AR2C4_Answers[] places;

    void Update()
    {
        if (((((places[0].names.objectName == "4" && places[1].names.objectName == "8")
            || (places[0].names.objectName == "8" && places[1].names.objectName == "4")) &&
            places[2].names.objectName == "3" && places[3].names.objectName == "2")


            ||

            (((places[0].names.objectName == "3" && places[1].names.objectName == "8")
            || (places[0].names.objectName == "8" && places[1].names.objectName == "3")) &&
            places[2].names.objectName == "2" && places[3].names.objectName == "4")) &&


            places[4].names.objectName == "1" && places[5].names.objectName == "2" &&
            places[6].names.objectName == "8" && places[7].names.objectName == "9" &&
            places[8].names.objectName == "6")
        {
            AR1C4_MoveManager.Instance.DoorCheck = true;
        }
        else if (((places[0].names.objectName == "9" && places[1].names.objectName == "2")
            || (places[0].names.objectName == "2" && places[1].names.objectName == "9")) &&

            (places[2].names.objectName == "1" && places[3].names.objectName == "8") &&
            (places[4].names.objectName == "3" && places[5].names.objectName == "4" &&
            places[6].names.objectName == "2" && places[7].names.objectName == "6" &&
            places[8].names.objectName == "8") 
            
            || (places[4].names.objectName == "4" && places[5].names.objectName == "3" &&
            places[6].names.objectName == "2" && places[7].names.objectName == "8" &&
            places[8].names.objectName == "6"))
        {
            AR1C4_MoveManager.Instance.DoorCheck = true;
        }
        else if (((((places[0].names.objectName == "9" && places[1].names.objectName == "4")
            || (places[0].names.objectName == "4" && places[1].names.objectName == "9")) &&
            places[2].names.objectName == "3" && places[3].names.objectName == "6")


            &&

            (places[4].names.objectName == "2" && places[5].names.objectName == "8"
             && places[6].names.objectName == "1" && places[7].names.objectName == "2" &&
            places[8].names.objectName == "8") || (places[4].names.objectName == "8" 
            && places[5].names.objectName == "2" && places[6].names.objectName == "1" &&
            places[7].names.objectName == "8" && places[8].names.objectName == "2")))
        {
            AR1C4_MoveManager.Instance.DoorCheck = true;
        }
        else
        {

        }
    }
}
