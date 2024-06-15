using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CompoundObjectInteractionHandler : MonoBehaviour
{
    public GameObject InformationPanel;
    public TMP_Text ElementName, Information, Description;
    private string StartingPage = "StartingPage";
    

    private void SetElementInfo(string name, string symbol, double atomicMass, double meltingPoint, double boilingPoint, string description)
    {
        ElementName.text = name;
        Information.text = $"Symbol: {symbol}\n" +
                           $"Atomic mass: {atomicMass:F2} u\n" +
                           $"Melting point: {meltingPoint:F2}°C ({meltingPoint + 273.15:F2} K)\n" +
                           $"Boiling point: {boilingPoint:F2}°C ({boilingPoint + 273.15:F2} K)\n";
        Description.text = $"\n{description}";
    }


    public void ArcZone()
    {

    }


    public void ZArc()
    {

    }


    public void ZEnd()
    {

    }



    public void HydrogenDimer()
    {
        SetElementInfo("Hydrogen Dimer", "H2", 2.016, 14, 20,
            "Hydrogen dimer, or diatomic hydrogen, is a molecule consisting of two hydrogen atoms bonded together. It is a colorless, odorless gas at room temperature and is the most abundant element in the universe.");

        InformationPanel.SetActive(true);
    }

    public void HydrogenTrimer()
    {
        SetElementInfo("Hydrogen Trimer", "H3", 0, 0, 0,
            "Hydrogen trimer is a hypothetical molecule consisting of three hydrogen atoms bonded together. While diatomic hydrogen (H2) is common, the existence of H3 is not observed under normal conditions.");

        InformationPanel.SetActive(true);
    }

    public void OxygenDimer()
    {
        SetElementInfo("Oxygen Dimer", "O2", 32, 54.36, 90.2,
            "Oxygen dimer, or diatomic oxygen, is a molecule consisting of two oxygen atoms bonded together. It is a colorless, odorless gas at room temperature and is essential for aerobic respiration in living organisms.");

        InformationPanel.SetActive(true);
    }

    public void Ozone()
    {
        SetElementInfo("Ozone", "O3", 48, 80.4, 161,
            "Ozone is a molecule consisting of three oxygen atoms bonded together. It is a pale blue gas with a distinct, sharp smell. Ozone plays a crucial role in the Earth's atmosphere, protecting life on the surface by absorbing the majority of the sun's harmful ultraviolet radiation.");

        InformationPanel.SetActive(true);
    }

    public void CarbonDimer()
    {
        SetElementInfo("Carbon Dimer", "C2", 28.02, 63.15, 77.3,
            "Carbon dimer, or diatomic carbon, is a molecule consisting of two carbon atoms bonded together. It is a colorless, odorless gas at room temperature and makes up the majority of Earth's atmosphere.");

        InformationPanel.SetActive(true);
    }

    public void NitrogenDimer()
    {
        SetElementInfo("Nitrogen Dimer", "N2", 28.02, 63.15, 77.3,
            "Nitrogen dimer, or diatomic nitrogen, is a molecule consisting of two nitrogen atoms bonded together. It is a colorless, odorless gas at room temperature and makes up the majority of Earth's atmosphere.");

        InformationPanel.SetActive(true);
    }

    public void BromineDimer()
    {
        SetElementInfo("Bromine Dimer", "Br2", 159.808, -7.2, 58.8,
            "Bromine dimer, or diatomic bromine, is a molecule consisting of two bromine atoms bonded together. It is a red-brown liquid at room temperature and is part of the halogen group.");

        InformationPanel.SetActive(true);
    }

    public void BromineTrimer()
    {
        SetElementInfo("Bromine Trimer", "Br3", 0, 0, 0,
            "Bromine trimer is a hypothetical molecule consisting of three bromine atoms bonded together. While diatomic bromine (Br2) is common, the existence of Br3 is not observed under normal conditions.");

        InformationPanel.SetActive(true);
    }

    public void ChlorineDimer()
    {
        SetElementInfo("Chlorine Dimer", "Cl2", 70.906, -34.04, -101.5,
            "Chlorine dimer, or diatomic chlorine, is a molecule consisting of two chlorine atoms bonded together. It is a yellow-green gas at room temperature and is a member of the halogen group.");

        InformationPanel.SetActive(true);
    }

    public void ChlorineTrimer()
    {
        SetElementInfo("Chlorine Trimer", "Cl3", 0, 0, 0,
            "Chlorine trimer is a hypothetical molecule consisting of three chlorine atoms bonded together. While diatomic chlorine (Cl2) is common, the existence of Cl3 is not observed under normal conditions.");

        InformationPanel.SetActive(true);
    }

    public void FluorineDimer()
    {
        SetElementInfo("Fluorine Dimer", "F2", 37.996, -187.11, -188.12,
            "Fluorine dimer, or diatomic fluorine, is a molecule consisting of two fluorine atoms bonded together. It is a pale yellow gas at room temperature and is the most electronegative element.");

        InformationPanel.SetActive(true);
    }

    public void FluorineTrimer()
    {
        SetElementInfo("Fluorine Trimer", "F3", 0, 0, 0,
            "Fluorine trimer is a hypothetical molecule consisting of three fluorine atoms bonded together. While diatomic fluorine (F2) is common, the existence of F3 is not observed under normal conditions.");

        InformationPanel.SetActive(true);
    }

    public void SulfurDimer()
    {
        SetElementInfo("Sulfur Dimer", "S2", 32.06, 115.21, 444.6,
            "Sulfur dimer, or diatomic sulfur, is a molecule consisting of two sulfur atoms bonded together. It is a yellow solid at room temperature and is involved in various chemical and biological processes.");

        InformationPanel.SetActive(true);
    }

    public void SulfurTrimer()
    {
        SetElementInfo("Sulfur Trimer", "S3", 0, 0, 0,
            "Sulfur trimer is a hypothetical molecule consisting of three sulfur atoms bonded together. While diatomic sulfur (S2) is common, the existence of S3 is not observed under normal conditions.");

        InformationPanel.SetActive(true);
    }

    public void IodineDimer()
    {
        SetElementInfo("Iodine Dimer", "I2", 253.808, 113.7, 184,
            "Iodine dimer, or diatomic iodine, is a molecule consisting of two iodine atoms bonded together. It is a dark purple solid at room temperature and is a member of the halogen group.");

        InformationPanel.SetActive(true);
    }

    public void IodineTrimer()
    {
        SetElementInfo("Iodine Trimer", "I3", 0, 0, 0,
            "Iodine trimer is a hypothetical molecule consisting of three iodine atoms bonded together. While diatomic iodine (I2) is common, the existence of I3 is not observed under normal conditions.");

        InformationPanel.SetActive(true);
    }

    public void PotassiumDimer()
    {
        SetElementInfo("Potassium Dimer", "K2", 78.04, 63.25, 774,
            "Potassium dimer, or diatomic potassium, is a molecule consisting of two potassium atoms bonded together. It is a reactive metal that quickly tarnishes in air.");

        InformationPanel.SetActive(true);
    }

    public void CopperDimer()
    {
        SetElementInfo("Copper Dimer", "Cu2", 0, 0, 0,
            "Copper dimer is a hypothetical molecule consisting of two copper atoms bonded together. While copper forms various compounds, the existence of a diatomic copper molecule is not observed under normal conditions.");

        InformationPanel.SetActive(true);
    }

    public void CopperTrimer()
    {
        SetElementInfo("Copper Trimer", "Cu3", 0, 0, 0,
            "Copper trimer is a hypothetical molecule consisting of three copper atoms bonded together. While copper forms various compounds, the existence of a triatomic copper molecule is not observed under normal conditions.");

        InformationPanel.SetActive(true);
    }


}
