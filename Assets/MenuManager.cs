using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject Swimsuit_Panel;
    public GameObject Dress_Panel;
    public GameObject Jacket_Panel;
    public GameObject Fem_Panel;
    public GameObject Male_Panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Settings_s()
    {
        Swimsuit_Panel.GetComponent<Animator>().SetTrigger("Pop_s");
    }

    public void Settings_d()
    {
        Dress_Panel.GetComponent<Animator>().SetTrigger("Pop_d");
    }

    public void Settings_j()
    {
        Jacket_Panel.GetComponent<Animator>().SetTrigger("Pop_j");
    }

    public void Activate_fem()
    {
        Fem_Panel.GetComponent<Animator>().SetTrigger("Pop_fem");
    }

    public void Activate_male()
    {
        Male_Panel.GetComponent<Animator>().SetTrigger("Pop_male");
    }
}
