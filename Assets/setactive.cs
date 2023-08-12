using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setactive : MonoBehaviour
{
    private int index;

    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;
    public GameObject camera6;
    public GameObject camera7;
    public GameObject camera8;
    public GameObject camera9;
    public GameObject freelook2;
    public GameObject freelook3;
    public GameObject freelook4;
    public GameObject freelook5;
    public GameObject freelook6;
    public GameObject freelook7;
    public GameObject freelook8;
    public GameObject freelook9;



    public GameObject canvas;


    // Start is called before the first frame update
    void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");
        freelook2.SetActive(false);
        freelook3.SetActive(false);
        freelook4.SetActive(false);
        freelook5.SetActive(false);
        freelook6.SetActive(false);
        freelook7.SetActive(false);
        freelook8.SetActive(false);
        freelook9.SetActive(false);
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onclickStart()
    {
        if(index==1)
        {
            freelook2.SetActive(true);
            camera2.SetActive(true);
            camera3.SetActive(false);
            camera4.SetActive(false);
            camera5.SetActive(false);
            camera6.SetActive(false);
            camera7.SetActive(false);
            camera8.SetActive(false);
            camera9.SetActive(false);
            
        }
        else if (index == 2)
        {
            freelook3.SetActive(true);
            camera3.SetActive(true);
            camera2.SetActive(false);
            camera4.SetActive(false);
            camera5.SetActive(false);
            camera6.SetActive(false);
            camera7.SetActive(false);
            camera8.SetActive(false);
            camera9.SetActive(false);


        }
        else if (index == 3)
        {
            freelook4.SetActive(true);
            camera4.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera5.SetActive(false);
            camera6.SetActive(false);
            camera7.SetActive(false);
            camera8.SetActive(false);
            camera9.SetActive(false);

        }
        else if(index==4)
        {
            freelook5.SetActive(true);
            camera5.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
            camera6.SetActive(false);
            camera7.SetActive(false);
            camera8.SetActive(false);
            camera9.SetActive(false);

        }
        else if (index == 5)
        {
            freelook6.SetActive(true);
            camera6.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera5.SetActive(false);
            camera4.SetActive(false);
            camera7.SetActive(false);
            camera8.SetActive(false);
            camera9.SetActive(false);

        }
        else if (index == 6)
        {
            freelook7.SetActive(true);
            camera7.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera5.SetActive(false);
            camera6.SetActive(false);
            camera4.SetActive(false);
            camera8.SetActive(false);
            camera9.SetActive(false);

        }
        else if (index == 7)
        {
            freelook8.SetActive(true);
            camera8.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera5.SetActive(false);
            camera6.SetActive(false);
            camera4.SetActive(false);
            camera8.SetActive(false);
            camera9.SetActive(false);

        }
        else if (index == 8)
        {
            freelook9.SetActive(true);
            camera9.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera5.SetActive(false);
            camera6.SetActive(false);
            camera7.SetActive(false);
            camera4.SetActive(false);
            camera9.SetActive(false);

        }

        canvas.SetActive(false);
    }
}
