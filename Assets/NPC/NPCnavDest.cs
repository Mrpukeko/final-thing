using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCnavDest : MonoBehaviour
{
    public int pivotPoint;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            if(pivotPoint == 30)
            {
                pivotPoint = 0;
            }

            if(pivotPoint == 29)
            {
                this.gameObject.transform.position = new Vector3(434, 1, 30);
                pivotPoint = 30;
            }

            if(pivotPoint == 28)
            {
                this.gameObject.transform.position = new Vector3(434, 1, 36);
                pivotPoint = 29;
            }

            if(pivotPoint == 27)
            {
                this.gameObject.transform.position = new Vector3(422, 1, 38);
                pivotPoint = 28;
            }

            if(pivotPoint == 26)
            {
                this.gameObject.transform.position = new Vector3(431, 1, 39);
                pivotPoint = 27;
            }

            if(pivotPoint == 25)
            {
                this.gameObject.transform.position = new Vector3(426, 1, 39);
                pivotPoint = 26;
            }

            if(pivotPoint == 24)
            {
                this.gameObject.transform.position = new Vector3(416, 1, 39);
                pivotPoint = 25;
            }

            if(pivotPoint == 23)
            {
                this.gameObject.transform.position = new Vector3(401 ,1, 20);
                pivotPoint = 24;
            }

            if(pivotPoint == 22)
            {
                this.gameObject.transform.position = new Vector3(412, 1, -58);
                pivotPoint = 23;
            }

            if(pivotPoint == 21)
            {
                this.gameObject.transform.position = new Vector3(377, 1, -58);
                pivotPoint = 22;
            }

            if(pivotPoint == 20)
            {
                this.gameObject.transform.position = new Vector3(343, 1, -54);
                pivotPoint = 21;
            }

            if(pivotPoint == 19)
            {
                this.gameObject.transform.position = new Vector3(309, 1, -44);
                pivotPoint = 20;
            }

            if(pivotPoint == 18)
            {
                this.gameObject.transform.position = new Vector3(281, 1, -31);
                pivotPoint = 19;
            }

            if(pivotPoint == 17)
            {
                this.gameObject.transform.position = new Vector3(251, 1, -22);
                pivotPoint = 18;
            }

            if(pivotPoint == 16)
            {
                this.gameObject.transform.position = new Vector3(219, 1, -17);
                pivotPoint = 17;
            }

            if(pivotPoint == 15)
            {
                this.gameObject.transform.position = new Vector3(101, 1, -15);
                pivotPoint = 16;
            }

            if(pivotPoint == 14)
            {
                this.gameObject.transform.position = new Vector3(64, 1, -13);
                pivotPoint = 15;
            }

            if(pivotPoint == 13)
            {
                this.gameObject.transform.position = new Vector3(45, 1, -12);
                pivotPoint = 14;
            }

            if(pivotPoint == 12)
            {
                this.gameObject.transform.position = new Vector3(54, 1, 30);
                pivotPoint = 13;
            }

            if(pivotPoint == 11)
            {
                this.gameObject.transform.position = new Vector3(54, 1,219);
                pivotPoint = 12;
            }

            if(pivotPoint == 10)
            {
                this.gameObject.transform.position = new Vector3(145, 1, 204);
                pivotPoint = 11;
            }

            if(pivotPoint == 9)
            {
                this.gameObject.transform.position = new Vector3(186, 1, 120);
                pivotPoint = 10;
            }

            if(pivotPoint == 8)
            {
                this.gameObject.transform.position = new Vector3(200, 1, 101);
                pivotPoint = 9;
            }

            if(pivotPoint == 7)
            {
                this.gameObject.transform.position = new Vector3(281, 1, 106);
                pivotPoint = 8;
            }

            if(pivotPoint == 6)
            {
                this.gameObject.transform.position = new Vector3(390, 1, 98);
                pivotPoint = 7;
            }

            if(pivotPoint == 5)
            {
                this.gameObject.transform.position = new Vector3(398, 1, 48);
                pivotPoint = 6;
            }

            if(pivotPoint == 4)
            {
                this.gameObject.transform.position = new Vector3(416, 1, 39);
                pivotPoint = 5;
            }

            if(pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(426, 1, 39);
                pivotPoint = 4;
            }

            if(pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(431, 1, 39);
                pivotPoint = 3;                  
                
            }

            if(pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(433, 1, 38);
                pivotPoint = 2;
            }

            if(pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(434, 1, 36);
                pivotPoint = 1;              
            }
        }
    }
}