using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeColor : MonoBehaviour
{
    public Color[] haircolors;
    public Material hair;

    public Color[] bodycolors;
    public Material body;

    public Color[] topscolors;
    public Material tops;


    public Color[] shoescolors;
    public Material shoes;

    public Color[] hatcolors;
    public Material hat;

    public Color[] glovescolors;
    public Material gloves;


    public Color[] bottomcolors;
    public Material bottom;

    public Color[] glassescolors;
    public Material glasses;


    public void ChangeHairColor(int colorIndex)
        
    {
        hair.color = haircolors[colorIndex];

    }


    public void ChangeBodyColor(int colorIndex)

    {
        body.color = bodycolors[colorIndex];

    }


    public void ChangeTopsColor(int colorIndex)

    {
        tops.color = topscolors[colorIndex];

    }


    public void ChangeShoesColor(int colorIndex)

    {
        shoes.color = shoescolors[colorIndex];

    }

    public void ChangeHatColor(int colorIndex)

    {
        hat.color = hatcolors[colorIndex];

    }

    public void ChangeGlovesColor(int colorIndex)

    {
        gloves.color = glovescolors[colorIndex];

    }

    public void ChangeBottomColor(int colorIndex)

    {
        bottom.color = bottomcolors[colorIndex];

    }


    public void ChangeGlassesColor(int colorIndex)

    {
        glasses.color = glassescolors[colorIndex];

    }
}
