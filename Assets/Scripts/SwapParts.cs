using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class SwapParts : MonoBehaviour
{
    public GameObject[] LiamHair, KiraHair, LiamShirt, KiraShirt, LiamShoes, KiraShoes;
    public SwitchGender SG;
    private int i, j, k, l, m, n;

    public void SwapLiamHair()
    {
        if (SG.Liam.activeSelf == true)
        {
            i++;
            if (i < LiamHair.Length) 
            {
                LiamHair[i].SetActive(true);
                LiamHair[i-1].SetActive(false);
            }
            else if (i > LiamHair.Length || i > 6)
            {
                i = 0;
                LiamHair[i].SetActive(true);
                LiamHair[6].SetActive(false);
            }
            
        }
    }
    public void SwapLiamShirt() 
    {
        if (SG.Liam.activeSelf == true)
        {
            j++;
            if (j < LiamShirt.Length)
            {
                LiamShirt[j].SetActive(true);
                LiamShirt[j - 1].SetActive(false);
            }
            else if (j > LiamShirt.Length || j > 2)
            {
                j = 0;
                LiamShirt[j].SetActive(true);
                LiamShirt[2].SetActive(false);
            }

        }
    }

    public void SwapLiamShoes()
    {
        if (SG.Liam.activeSelf == true)
        {
            k++;
            if (k < LiamShoes.Length)
            {
                LiamShoes[k].SetActive(true);
                LiamShoes[k - 1].SetActive(false);
            }
            else if (j > LiamShoes.Length || k > 1)
            {
                k = 0;
                LiamShoes[k].SetActive(true);
                LiamShoes[1].SetActive(false);
            }

        }
    }

    public void SwapKiraHair()
    {
        if (SG.Kira.activeSelf == true)
        {
            l++;
            if (l < KiraHair.Length)
            {
                KiraHair[l].SetActive(true);
                KiraHair[l - 1].SetActive(false);
            }
            else if (l > KiraHair.Length || l > 4)
            {
                l = 0;
                KiraHair[l].SetActive(true);
                KiraHair[4].SetActive(false);
            }

        }
    }

    public void SwapKiraShirt()
    {
        if (SG.Kira.activeSelf == true)
        {
            m++;
            if (m < KiraShirt.Length)
            {
                KiraShirt[m].SetActive(true);
                KiraShirt[m - 1].SetActive(false);
            }
            else if (m > KiraShirt.Length || m > 1)
            {
                m = 0;
                KiraShirt[m].SetActive(true);
                KiraShirt[1].SetActive(false);
            }

        }
    }

    public void SwapKiraShoes()
    {
        if (SG.Kira.activeSelf == true)
        {
            n++;
            if (n < KiraShoes.Length)
            {
                KiraShoes[n].SetActive(true);
                KiraShoes[n - 1].SetActive(false);
            }
            else if (n > KiraShoes.Length || n > 1)
            {
                n = 0;
                KiraShoes[n].SetActive(true);
                KiraShoes[1].SetActive(false);
            }

        }
    }
}
