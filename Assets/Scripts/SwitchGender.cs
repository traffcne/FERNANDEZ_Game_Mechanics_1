using UnityEngine;

public class SwitchGender : MonoBehaviour
{
    public GameObject Liam;
    public GameObject Kira;
   
    public void SwitchtoFem()
    {  
            Liam.SetActive(false);
            Kira.SetActive(true);
    }
    public void SwitchtoMasc()
    {  
            Liam.SetActive(true);
            Kira.SetActive(false);
    }
}
