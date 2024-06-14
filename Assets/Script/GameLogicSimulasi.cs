using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicSimulasi : MonoBehaviour
{



    public GameObject menumotordc;
    public GameObject menuroda;
    public GameObject drivermotor;
    public GameObject pasangdrivermotor;
    public GameObject modulir;
    public GameObject pasangmodulir;
    public GameObject sambung;
    public GameObject baterai;
    public GameObject kabel;
    public GameObject kabels;

    // Use this for initialization
    void Start()
    {
 

    }




    public void MotorDC()
    {

        menumotordc.SetActive(true);
        menuroda.SetActive(false);
        drivermotor.SetActive(false);
        pasangdrivermotor.SetActive(false);
        modulir.SetActive(false);
        pasangmodulir.SetActive(false);
        sambung.SetActive(false);
        baterai.SetActive(false);
        kabel.SetActive(false);
        kabels.SetActive(false);

    }

    public void Roda()
    {

        menumotordc.SetActive(false);
        menuroda.SetActive(true);
        drivermotor.SetActive(false);
        pasangdrivermotor.SetActive(false);
        modulir.SetActive(false);
        pasangmodulir.SetActive(false);
        sambung.SetActive(false);
        baterai.SetActive(false);
        kabel.SetActive(false);
        kabels.SetActive(false);

    }

    public void dmotor()
    {

        menumotordc.SetActive(false);
        menuroda.SetActive(false);
        drivermotor.SetActive(true);
        pasangdrivermotor.SetActive(false);
        modulir.SetActive(false);
        pasangmodulir.SetActive(false);
        sambung.SetActive(false);
        baterai.SetActive(false);
        kabel.SetActive(false);
        kabels.SetActive(false);

    }

    public void cmotor()
    {

        menumotordc.SetActive(false);
        menuroda.SetActive(false);
        drivermotor.SetActive(false);
        pasangdrivermotor.SetActive(true);
        modulir.SetActive(false);
        pasangmodulir.SetActive(false);
        sambung.SetActive(false);
        baterai.SetActive(false);
        kabel.SetActive(false);
        kabels.SetActive(false);
    }

    public void modullir()
    {

        menumotordc.SetActive(false);
        menuroda.SetActive(false);
        drivermotor.SetActive(false);
        pasangdrivermotor.SetActive(false);
        modulir.SetActive(true);
        pasangmodulir.SetActive(false);
        sambung.SetActive(false);
        baterai.SetActive(false);
        kabel.SetActive(false);
        kabels.SetActive(false);
    }
    public void pmodullir()
    {

        menumotordc.SetActive(false);
        menuroda.SetActive(false);
        drivermotor.SetActive(false);
        pasangdrivermotor.SetActive(false);
        modulir.SetActive(false);
        pasangmodulir.SetActive(true);
        sambung.SetActive(false);
        baterai.SetActive(false);
        kabel.SetActive(false);
        kabels.SetActive(false);
    }

    public void menyambung()
    {

        menumotordc.SetActive(false);
        menuroda.SetActive(false);
        drivermotor.SetActive(false);
        pasangdrivermotor.SetActive(false);
        modulir.SetActive(false);
        pasangmodulir.SetActive(false);
        sambung.SetActive(true);
        baterai.SetActive(false);
        kabel.SetActive(false);
        kabels.SetActive(false);
    }

    public void betre()
    {

        menumotordc.SetActive(false);
        menuroda.SetActive(false);
        drivermotor.SetActive(false);
        pasangdrivermotor.SetActive(false);
        modulir.SetActive(false);
        pasangmodulir.SetActive(false);
        sambung.SetActive(false);
        baterai.SetActive(true);
        kabel.SetActive(false);
        kabels.SetActive(false);
    }

    public void kkabel()
    {

        menumotordc.SetActive(false);
        menuroda.SetActive(false);
        drivermotor.SetActive(false);
        pasangdrivermotor.SetActive(false);
        modulir.SetActive(false);
        pasangmodulir.SetActive(false);
        sambung.SetActive(false);
        baterai.SetActive(false);
        kabel.SetActive(true);
        kabels.SetActive(false);
    }

    public void kkkabel()
    {

        menumotordc.SetActive(false);
        menuroda.SetActive(false);
        drivermotor.SetActive(false);
        pasangdrivermotor.SetActive(false);
        modulir.SetActive(false);
        pasangmodulir.SetActive(false);
        sambung.SetActive(false);
        baterai.SetActive(false);
        kabel.SetActive(false);
        kabels.SetActive(true);
    }


}