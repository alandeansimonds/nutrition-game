using UnityEngine;
using System.Collections;

public class AdverseEffectsHover : MonoBehaviour {

    public GameObject MethotrexateHoverGameOject;
    public GameObject SulfasalazineHoverGameOject;
    public GameObject OxycodoneHoverGameOject;
    public GameObject InfliximabHoverGameOject;
    public GameObject FolicAcidHoverGameOject;
    public GameObject CaltrateHoverGameOject;
    public GameObject CitalopramHoverGameOject;

    void Start() {
        MethotrexateHoverGameOject.SetActive(false);
        SulfasalazineHoverGameOject.SetActive(false);
        OxycodoneHoverGameOject.SetActive(false);
        InfliximabHoverGameOject.SetActive(false);
        FolicAcidHoverGameOject.SetActive(false);
        CaltrateHoverGameOject.SetActive(false);
        CitalopramHoverGameOject.SetActive(false);
    }

    public void MethotrexateHoverToggleOn() {
        MethotrexateHoverGameOject.SetActive(true);
    }

    public void MethotrexateHoverToggleOff()
    {
        MethotrexateHoverGameOject.SetActive(false);
    }

    public void SulfasalazineHoverToggleOn()
    {
        SulfasalazineHoverGameOject.SetActive(true);
    }

    public void SulfasalazineHoverToggleOff()
    {
        SulfasalazineHoverGameOject.SetActive(false);
    }

    public void OxycodoneHoverToggleOn()
    {
        OxycodoneHoverGameOject.SetActive(true);
    }

    public void OxycodoneHoverToggleOff()
    {
        OxycodoneHoverGameOject.SetActive(false);
    }

    public void InfliximabHoverToggleOn()
    {
        InfliximabHoverGameOject.SetActive(true);
    }

    public void InfliximabHoverToggleOff()
    {
        InfliximabHoverGameOject.SetActive(false);
    }

    public void FolicAcidHoverToggleOn()
    {
        FolicAcidHoverGameOject.SetActive(true);
    }

    public void FolicAcidHoverToggleOff()
    {
        FolicAcidHoverGameOject.SetActive(false);
    }

    public void CaltrateHoverToggleOn()
    {
        CaltrateHoverGameOject.SetActive(true);
    }

    public void CaltrateHoverToggleOff()
    {
        CaltrateHoverGameOject.SetActive(false);
    }

    public void CitalopramHoverToggleOn()
    {
        CitalopramHoverGameOject.SetActive(true);
    }

    public void CitalopramHoverToggleOff()
    {
        CitalopramHoverGameOject.SetActive(false);
    }
}
