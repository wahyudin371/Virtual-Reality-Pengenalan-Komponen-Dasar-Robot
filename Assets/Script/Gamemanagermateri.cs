using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanagermateri : MonoBehaviour
{

    public GameObject materibaterai;
    public GameObject materidrivermotor;
    public GameObject materimotordc;
    public GameObject materimodulir;
    public GameObject materiICL293D;
    public GameObject materiRegulator7805;
    public GameObject materiSwitch;
    public GameObject materipinheader;
    public GameObject materipcb;
    public GameObject materiphotodioda;
    public GameObject materiresistor;
    public GameObject materipotensiometer;
    public GameObject materiICLM358;
    public GameObject materiPCB1;
    public GameObject materiPinHeader1;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bateraimateri()
    {
        materibaterai.SetActive(true);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);

    }

    public void drivermotormateri()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(true);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);
    }

    public void motordcmateri()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(true);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);
    }

    public void modulirmateri()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(true);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);
    }

    public void ICLmateri()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(true);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);
    }

    public void regulatormateri()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(true);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);
    }

    public void switchmateri()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(true);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);
    }

    public void pinheadermateri()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(true);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);
    }

    public void pcbmateri()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(true);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);
    }

    public void potodiodamateri()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(true);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);
    }

    public void resistordamateri()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(true);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);
    }

    public void potensiodamateri()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(true);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);
    }

    public void ICM()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(true);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(false);
    }


    public void pcbone()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(true);
        materiPinHeader1.SetActive(false);
    }

    public void pinhederone()
    {
        materibaterai.SetActive(false);
        materidrivermotor.SetActive(false);
        materimotordc.SetActive(false);
        materimodulir.SetActive(false);
        materiICL293D.SetActive(false);
        materiRegulator7805.SetActive(false);
        materiSwitch.SetActive(false);
        materipinheader.SetActive(false);
        materipcb.SetActive(false);
        materiphotodioda.SetActive(false);
        materiresistor.SetActive(false);
        materipotensiometer.SetActive(false);
        materiICLM358.SetActive(false);
        materiPCB1.SetActive(false);
        materiPinHeader1.SetActive(true);
    }






    public void pindahsceneberanda()
    {
        Application.LoadLevel(0);
    }
}
