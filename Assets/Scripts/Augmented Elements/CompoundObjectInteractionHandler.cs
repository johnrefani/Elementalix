using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DiatomicObjectInteractionHandler : MonoBehaviour
{
    public GameObject InformationPanel;
    public TMP_Text ElementName, Information, Description;
    

    private void SetElementInfo(string name, string symbol, double atomicMass, double meltingPoint, double boilingPoint, string description)
    {
        ElementName.text = name;
        Information.text = $"Symbol: {symbol}\n" +
                           $"Atomic mass: {atomicMass:F2} u\n" +
                           $"Melting point: {meltingPoint:F2}°C ({meltingPoint + 273.15:F2} K)\n" +
                           $"Boiling point: {boilingPoint:F2}°C ({boilingPoint + 273.15:F2} K)\n";
        Description.text = $"\n{description}";
    }


    public void Water()
    {
        SetElementInfo("Water", "H2O", 18.01528, 0, 100,
            "Water is a simple compound consisting of two hydrogen atoms bonded to one oxygen atom. It is a colorless, odorless liquid at room temperature and is essential for life. Water has a melting point of 0°C and a boiling point of 100°C at standard atmospheric pressure. It is a universal solvent and plays a crucial role in various biological and chemical processes.");

        InformationPanel.SetActive(true);
    }

    public void Phosphine()
    {
        SetElementInfo("Phosphine", "PH3", 34.02, -87.7, -66.8,
            "Phosphine is a compound composed of one phosphorus atom bonded to three hydrogen atoms. It is a colorless, flammable gas with a distinct, unpleasant odor. Phosphine is commonly used in the semiconductor industry and as a reducing agent in chemical processes.");

        InformationPanel.SetActive(true);
    }

    public void HydrogenPeroxide()
    {
        SetElementInfo("Hydrogen Peroxide", "H2O2", 34.0147, -0.43, 150.2,
            "Hydrogen peroxide is a chemical compound with two hydrogen and two oxygen atoms. It is a pale blue liquid, which appears colorless in a dilute solution, and is a powerful oxidizer. Hydrogen peroxide is often used as a disinfectant and bleaching agent.");

        InformationPanel.SetActive(true);
    }

    public void LithiumFluoride()
    {
        SetElementInfo("Lithium Fluoride", "LiF", 25.94, 845, 1681,
            "Lithium fluoride is a compound composed of one lithium atom bonded to one fluorine atom. It is a white, crystalline solid with a high melting point. Lithium fluoride is used in various applications, including nuclear reactors and as a flux in ceramics.");

        InformationPanel.SetActive(true);
    }

    public void BerylliumFluoride()
    {
        SetElementInfo("Beryllium Fluoride", "BeF2", 47.01, 870, 2348,
            "Beryllium fluoride is a compound consisting of one beryllium atom bonded to two fluorine atoms. It is a white, crystalline solid with a high melting point. Beryllium fluoride is used in the production of beryllium and as a component in certain types of optical glasses.");

        InformationPanel.SetActive(true);
    }

    public void BerylliumChloride()
    {
        SetElementInfo("Beryllium Chloride", "BeCl2", 79.92, 405, 520,
            "Beryllium chloride is a compound composed of one beryllium atom bonded to two chlorine atoms. It is a white, crystalline solid with a low melting point. Beryllium chloride is used in the production of beryllium metal and as a catalyst in organic synthesis.");

        InformationPanel.SetActive(true);
    }

    public void BerylliumIodide()
    {
        SetElementInfo("Beryllium Iodide", "BeI2", 151.84, 537, 920,
            "Beryllium iodide is a compound composed of one beryllium atom bonded to two iodine atoms. It is a white, crystalline solid with a moderate melting point. Beryllium iodide is used in the preparation of beryllium and as a catalyst in organic synthesis.");

        InformationPanel.SetActive(true);
    }

    public void BoronTrihydride()
    {
        SetElementInfo("Boron Trihydride", "BH3", 13.83, -92, -80.1,
            "Boron trihydride, also known as borane, is a compound consisting of one boron atom bonded to three hydrogen atoms. It is a colorless, highly reactive gas. Boron trihydride is used in organic synthesis as a reducing agent and in the production of boron-containing compounds.");

        InformationPanel.SetActive(true);
    }

    public void BoronTrichloride()
    {
        SetElementInfo("Boron Trichloride", "BCl3", 117.17, -107.4, 12.5,
            "Boron trichloride is a compound composed of one boron atom bonded to three chlorine atoms. It is a colorless gas with a pungent odor. Boron trichloride is used as a catalyst in various chemical reactions, including the production of polymers.");

        InformationPanel.SetActive(true);
    }

    public void BoronTribromide()
    {
        SetElementInfo("Boron Tribromide", "BBr3", 191.63, -46, 91,
            "Boron tribromide is a compound consisting of one boron atom bonded to three bromine atoms. It is a colorless liquid with a pungent odor. Boron tribromide is used as a catalyst in organic synthesis and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void BoronTriiodide()
    {
        SetElementInfo("Boron Triiodide", "BI3", 391.63, 62, 217,
            "Boron triiodide is a compound composed of one boron atom bonded to three iodine atoms. It is a red-brown solid. Boron triiodide is used as a reagent in organic synthesis, particularly in the synthesis of certain types of compounds.");

        InformationPanel.SetActive(true);
    }


    public void CarbonDioxide()
    {
        SetElementInfo("Carbon Dioxide", "CO2", 44.01, -78.5, -56.6,
            "Carbon dioxide is a compound consisting of one carbon atom bonded to two oxygen atoms. It is a colorless, odorless gas at room temperature. Carbon dioxide is a significant component of Earth's atmosphere and is produced during combustion and respiration.");

        InformationPanel.SetActive(true);
    }

    public void Acetylene()
    {
        SetElementInfo("Acetylene", "C2H2", 26.04, -80.8, -84,
            "Acetylene is a hydrocarbon compound consisting of two carbon atoms bonded to two hydrogen atoms. It is a colorless gas with a distinct odor. Acetylene is widely used in welding and cutting processes and as a starting material for various organic syntheses.");

        InformationPanel.SetActive(true);
    }

    public void NitrousOxide()
    {
        SetElementInfo("Nitrous Oxide", "N2O", 44.02, -90.9, -88.5,
            "Nitrous oxide is a compound consisting of two nitrogen atoms bonded to one oxygen atom. It is a colorless, sweet-smelling gas. Nitrous oxide is commonly known as laughing gas and is used in medical and dental anesthesia.");

        InformationPanel.SetActive(true);
    }

    public void Ammonia()
    {
        SetElementInfo("Ammonia", "NH3", 17.03, -77.7, -33.4,
            "Ammonia is a compound consisting of one nitrogen atom bonded to three hydrogen atoms. It is a colorless gas with a pungent odor. Ammonia is widely used in the production of fertilizers and as a refrigerant in various applications.");

        InformationPanel.SetActive(true);
    }

    public void NitrogenTrifluoride()
    {
        SetElementInfo("Nitrogen Trifluoride", "NF3", 71.00, -129, -129.5,
            "Nitrogen trifluoride is a compound consisting of one nitrogen atom bonded to three fluorine atoms. It is a colorless gas with a faint sweet odor. Nitrogen trifluoride is used in the semiconductor industry as a plasma etchant.");

        InformationPanel.SetActive(true);
    }

    public void NitrogenTriiodide()
    {
        SetElementInfo("Nitrogen Triiodide", "NI3", 394.71, 0, 0,
            "Nitrogen triiodide is a compound consisting of one nitrogen atom bonded to three iodine atoms. It is an extremely sensitive and explosive material, often prepared for educational demonstrations rather than practical use. Nitrogen triiodide is known for its instability and tendency to explode upon contact.");

        InformationPanel.SetActive(true);
    }

    public void SodiumChloride()
    {
        SetElementInfo("Sodium Chloride", "NaCl", 58.44, 801, 1465,
            "Sodium chloride, commonly known as table salt, is a compound consisting of one sodium atom bonded to one chlorine atom. It is a white crystalline solid. Sodium chloride is widely used as a seasoning and preservative in food and for various industrial applications.");

        InformationPanel.SetActive(true);
    }

    public void SodiumFluoride()
    {
        SetElementInfo("Sodium Fluoride", "NaF", 41.99, 988, 1704,
            "Sodium fluoride is a compound consisting of one sodium atom bonded to one fluorine atom. It is a white crystalline solid. Sodium fluoride is used in toothpaste and water fluoridation to prevent tooth decay and in some chemical processes.");

        InformationPanel.SetActive(true);
    }

    public void MagnesiumChloride()
    {
        SetElementInfo("Magnesium Chloride", "MgCl2", 95.21, 714, 1412,
            "Magnesium chloride is a compound consisting of one magnesium atom bonded to two chlorine atoms. It is a white crystalline solid. Magnesium chloride is used in various applications, including as a de-icing agent, in the production of magnesium metal, and in the preparation of tofu.");

        InformationPanel.SetActive(true);
    }

    public void MagnesiumBromide()
    {
        SetElementInfo("Magnesium Bromide", "MgBr2", 184.12, 678, 1380,
            "Magnesium bromide is a compound consisting of one magnesium atom bonded to two bromine atoms. It is a white crystalline solid. Magnesium bromide is used in the preparation of certain medications and in the production of magnesium metal.");

        InformationPanel.SetActive(true);
    }

    public void MagnesiumIodide()
    {
        SetElementInfo("Magnesium Iodide", "MgI2", 278.11, 637, 1100,
            "Magnesium iodide is a compound consisting of one magnesium atom bonded to two iodine atoms. It is a white crystalline solid. Magnesium iodide is used in the preparation of Grignard reagents and in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void AluminumTrichloride()
    {
        SetElementInfo("Aluminum Trichloride", "AlCl3", 133.34, 192, 180,
            "Aluminum trichloride is a compound consisting of one aluminum atom bonded to three chlorine atoms. It is a white to pale yellow solid. Aluminum trichloride is used as a catalyst in various chemical reactions, including the Friedel-Crafts alkylation and acylation reactions.");

        InformationPanel.SetActive(true);
    }

    public void AluminumTribromide()
    {
        SetElementInfo("Aluminum Tribromide", "AlBr3", 266.69, 97, 265,
            "Aluminum tribromide is a compound consisting of one aluminum atom bonded to three bromine atoms. It is a dark brown solid. Aluminum tribromide is used as a catalyst in organic synthesis, particularly in the synthesis of aromatic compounds.");

        InformationPanel.SetActive(true);
    }

    public void AluminumTriiodide()
    {
        SetElementInfo("Aluminum Triiodide", "AlI3", 407.7, 120, 305,
            "Aluminum triiodide is a compound consisting of one aluminum atom bonded to three iodine atoms. It is a dark violet solid. Aluminum triiodide is used in organic synthesis as a reagent for introducing iodine into organic compounds.");

        InformationPanel.SetActive(true);
    }

    public void SiliconDioxide()
    {
        SetElementInfo("Silicon Dioxide", "SiO2", 60.08, 1713, 2230,
            "Silicon dioxide, also known as silica, is a compound consisting of one silicon atom bonded to two oxygen atoms. It is a crystalline solid and the main component of sand and quartz. Silicon dioxide is widely used in the production of glass, ceramics, and as a semiconductor material.");

        InformationPanel.SetActive(true);
    }

    public void PhosphorusTrichloride()
    {
        SetElementInfo("Phosphorus Trichloride", "PCl3", 137.33, -112.1, 76,
            "Phosphorus trichloride is a compound consisting of one phosphorus atom bonded to three chlorine atoms. It is a colorless liquid with a pungent odor. Phosphorus trichloride is used in the production of herbicides, insecticides, and as a reagent in organic synthesis.");

        InformationPanel.SetActive(true);
    }


    public void HydrogenSulfide()
    {
        SetElementInfo("Hydrogen Sulfide", "H2S", 34.08, -85.5, -60.7,
            "Hydrogen sulfide is a compound consisting of two hydrogen atoms bonded to one sulfur atom. It is a colorless gas with a characteristic rotten egg odor. Hydrogen sulfide is produced by natural processes and is also a byproduct of certain industrial activities.");

        InformationPanel.SetActive(true);
    }

    public void SulfurDichloride()
    {
        SetElementInfo("Sulfur Dichloride", "SCl2", 102.97, -57.5, 53.5,
            "Sulfur dichloride is a compound consisting of one sulfur atom bonded to two chlorine atoms. It is a yellowish liquid with a pungent odor. Sulfur dichloride is used as a chlorinating agent in organic synthesis and as a precursor to sulfur hexafluoride.");

        InformationPanel.SetActive(true);
    }

    public void SulfurDibromide()
    {
        SetElementInfo("Sulfur Dibromide", "SBr2", 159.86, -38, 153,
            "Sulfur dibromide is a compound consisting of one sulfur atom bonded to two bromine atoms. It is a red-brown liquid. Sulfur dibromide is used in organic synthesis as a brominating agent and in the preparation of certain sulfur-containing compounds.");

        InformationPanel.SetActive(true);
    }

    public void HydrochloricAcid()
    {
        SetElementInfo("Hydrochloric Acid", "HCl", 36.46, -85.1, -34.6,
            "Hydrochloric acid is a compound consisting of one hydrogen atom bonded to one chlorine atom. It is a colorless, corrosive liquid with a pungent odor. Hydrochloric acid is widely used in various industrial processes, including the production of chemicals and the pickling of steel.");

        InformationPanel.SetActive(true);
    }

    public void PotassiumChloride()
    {
        SetElementInfo("Potassium Chloride", "KCl", 74.55, 776, 1500,
            "Potassium chloride is a compound consisting of one potassium atom bonded to one chlorine atom. It is a white crystalline solid. Potassium chloride is used as a fertilizer, in the preparation of certain medicines, and as a salt substitute.");

        InformationPanel.SetActive(true);
    }

    public void CalciumChloride()
    {
        SetElementInfo("Calcium Chloride", "CaCl2", 110.98, 772, 1935,
            "Calcium chloride is a compound consisting of one calcium atom bonded to two chlorine atoms. It is a white crystalline solid. Calcium chloride is used as a de-icing agent, in the preparation of calcium metal, and in the food industry for various applications.");

        InformationPanel.SetActive(true);
    }


    public void ZincChloride()
    {
        SetElementInfo("Zinc Chloride", "ZnCl2", 136.29, 275, 732,
            "Zinc chloride is a compound consisting of one zinc atom bonded to two chlorine atoms. It is a white crystalline solid. Zinc chloride is used in the production of batteries, as a flux in soldering, and as a wood preservative.");

        InformationPanel.SetActive(true);
    }

    public void CalciumOxide()
    {
        SetElementInfo("Calcium Oxide", "CaO", 56.08, 2570, 2852,
            "Calcium oxide, also known as quicklime, is a compound consisting of one calcium atom bonded to one oxygen atom. It is a white crystalline solid. Calcium oxide is used in the production of cement, as a desiccant, and in various industrial processes.");

        InformationPanel.SetActive(true);
    }

    public void CalciumBromide()
    {
        SetElementInfo("Calcium Bromide", "CaBr2", 199.89, 730, 1935,
            "Calcium bromide is a compound consisting of one calcium atom bonded to two bromine atoms. It is a white crystalline solid. Calcium bromide is used in the oil and gas industry as a drilling fluid and in the production of certain medications.");

        InformationPanel.SetActive(true);
    }

    public void CalciumIodide()
    {
        SetElementInfo("Calcium Iodide", "CaI2", 293.89, 752, 1600,
            "Calcium iodide is a compound consisting of one calcium atom bonded to two iodine atoms. It is a white crystalline solid. Calcium iodide is used in the preparation of certain medications and in the analysis of minerals.");

        InformationPanel.SetActive(true);
    }

    public void ScandiumTrichloride()
    {
        SetElementInfo("Scandium Trichloride", "ScCl3", 137.29, 695, 1581,
            "Scandium trichloride is a compound consisting of one scandium atom bonded to three chlorine atoms. It is a white crystalline solid. Scandium trichloride is used in the synthesis of organometallic compounds and as a catalyst in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void ScandiumTribromide()
    {
        SetElementInfo("Scandium Tribromide", "ScBr3", 228.63, 708, 1466,
            "Scandium tribromide is a compound consisting of one scandium atom bonded to three bromine atoms. It is a white to yellowish solid. Scandium tribromide is used in the synthesis of organometallic compounds and as a catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }

    public void ScandiumTriiodide()
    {
        SetElementInfo("Scandium Triiodide", "ScI3", 325.63, 730, 1427,
            "Scandium triiodide is a compound consisting of one scandium atom bonded to three iodine atoms. It is a dark red solid. Scandium triiodide is used in the synthesis of organometallic compounds and as a catalyst in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void ManganeseChloride()
    {
        SetElementInfo("Manganese Chloride", "MnCl2", 125.84, 650, 1190,
            "Manganese chloride is a compound consisting of one manganese ion bonded to two chlorine atoms. It is a pink solid. Manganese chloride is used in the production of manganese metal and as a catalyst in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void ManganeseBromide()
    {
        SetElementInfo("Manganese Bromide", "MnBr2", 216.74, 591, 1190,
            "Manganese bromide is a compound consisting of one manganese ion bonded to two bromine atoms. It is a brown solid. Manganese bromide is used in the synthesis of organic compounds and as a catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }

    public void ManganeseIodide()
    {
        SetElementInfo("Manganese Iodide", "MnI2", 303.74, 582, 1190,
            "Manganese iodide is a compound consisting of one manganese ion bonded to two iodine atoms. It is a brown solid. Manganese iodide is used in the synthesis of organic compounds and as a catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }

    public void IronOxide()
    {
        SetElementInfo("Iron Oxide", "FeO", 71.85, 1597, 2861,
            "Iron oxide, also known as ferrous oxide, is a compound consisting of one iron ion bonded to one oxygen atom. It is a black solid. Iron oxide is used as a pigment and in the production of steel.");

        InformationPanel.SetActive(true);
    }

    public void IronChloride()
    {
        SetElementInfo("Iron Chloride", "FeCl3", 162.21, 306, 1186,
            "Iron chloride, also known as ferric chloride, is a compound consisting of one iron ion bonded to three chlorine atoms. It is a brownish-yellow solid. Iron chloride is used as a catalyst in certain chemical reactions and in the etching of printed circuit boards.");

        InformationPanel.SetActive(true);
    }

    public void IronBromide()
    {
        SetElementInfo("Iron Bromide", "FeBr2", 215.63, 1, 1673,
            "Iron bromide, also known as ferrous bromide, is a compound consisting of one iron ion bonded to two bromine atoms. It is a brown solid. Iron bromide is used in the synthesis of organic compounds and as a catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }

    public void CobaltOxide()
    {
        SetElementInfo("Cobalt Oxide", "CoO", 74.93, 1935, 3800,
            "Cobalt oxide is a compound consisting of one cobalt ion bonded to one oxygen atom. It is a black solid. Cobalt oxide is used in the production of ceramics, as a coloring agent in glass, and in certain electronic applications.");

        InformationPanel.SetActive(true);
    }

    public void CobaltChloride()
    {
        SetElementInfo("Cobalt Chloride", "CoCl2", 129.84, 677, 1049,
            "Cobalt chloride is a compound consisting of one cobalt ion bonded to two chlorine atoms. It is a blue solid. Cobalt chloride is used as a drying agent for gases and in the production of catalysts.");

        InformationPanel.SetActive(true);
    }

    public void CobaltBromide()
    {
        SetElementInfo("Cobalt Bromide", "CoBr2", 218.74, 678, 1300,
            "Cobalt bromide is a compound consisting of one cobalt ion bonded to two bromine atoms. It is a red-brown solid. Cobalt bromide is used in the synthesis of organic compounds and as a catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }

    public void NickelOxide()
    {
        SetElementInfo("Nickel Oxide", "NiO", 74.71, 1650, 1956,
            "Nickel oxide is a compound consisting of one nickel ion bonded to one oxygen atom. It is a green solid. Nickel oxide is used in the production of ceramics, as a catalyst, and in certain battery applications.");

        InformationPanel.SetActive(true);
    }

    public void CopperBromide()
    {
        SetElementInfo("Copper Bromide", "CuBr2", 223.36, 498, 900,
            "Copper bromide is a compound consisting of one copper ion bonded to two bromine atoms. It is a brown solid. Copper bromide is used in the synthesis of organic compounds and as a catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }

    public void CopperIodide()
    {
        SetElementInfo("Copper Iodide", "CuI", 190.45, 606, 1290,
            "Copper iodide is a compound consisting of one copper ion bonded to one iodine atom. It is a white to yellow solid. Copper iodide is used in the synthesis of organic compounds and as a catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }

    public void ZincOxide()
    {
        SetElementInfo("Zinc Oxide", "ZnO", 81.38, 1975, 2360,
            "Zinc oxide is a compound consisting of one zinc atom bonded to one oxygen atom. It is a white powder. Zinc oxide is used in the production of rubber, plastics, ceramics, and as a sunscreen ingredient.");

        InformationPanel.SetActive(true);
    }

    public void ZincBromide()
    {
        SetElementInfo("Zinc Bromide", "ZnBr2", 225.15, 394, 697,
            "Zinc bromide is a compound consisting of one zinc atom bonded to two bromine atoms. It is a white crystalline solid. Zinc bromide is used in the oil and gas industry as a drilling fluid and in certain chemical processes.");

        InformationPanel.SetActive(true);
    }

    public void GalliumTrichloride()
    {
        SetElementInfo("Gallium Trichloride", "GaCl3", 176.04, 78, 201,
            "Gallium trichloride is a compound consisting of one gallium atom bonded to three chlorine atoms. It is a white crystalline solid. Gallium trichloride is used in the production of semiconductors and as a catalyst in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void GermaniumDioxide()
    {
        SetElementInfo("Germanium Dioxide", "GeO2", 104.63, 1100, 1580,
            "Germanium dioxide is a compound consisting of one germanium atom bonded to two oxygen atoms. It is a white powder. Germanium dioxide is used in the production of optical fibers, infrared devices, and as a catalyst in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void Arsine()
    {
        SetElementInfo("Arsine", "AsH3", 77.95, -62.5, -54,
            "Arsine is a compound consisting of one arsenic atom bonded to three hydrogen atoms. It is a colorless, flammable gas. Arsine is used in the production of semiconductors and as a dopant in certain electronic devices.");

        InformationPanel.SetActive(true);
    }

    public void HydrogenSelenide()
    {
        SetElementInfo("Hydrogen Selenide", "H2Se", 81.96, -65, -41.25,
            "Hydrogen selenide is a compound consisting of two hydrogen atoms bonded to one selenium atom. It is a colorless, flammable gas with a characteristic foul odor. Hydrogen selenide is used in the production of semiconductors and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void SeleniumDichloride()
    {
        SetElementInfo("Selenium Dichloride", "SeCl2", 145.84, -26.5, 212,
            "Selenium dichloride is a compound consisting of one selenium atom bonded to two chlorine atoms. It is a yellowish liquid. Selenium dichloride is used as a precursor in the synthesis of certain selenium compounds.");

        InformationPanel.SetActive(true);
    }

    public void HydrogenBromide()
    {
        SetElementInfo("Hydrogen Bromide", "HBr", 80.91, -86.9, -66.8,
            "Hydrogen bromide is a compound consisting of one hydrogen atom bonded to one bromine atom. It is a colorless gas with a sharp, unpleasant odor. Hydrogen bromide is used in the production of chemicals and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void LithiumBromide()
    {
        SetElementInfo("Lithium Bromide", "LiBr", 86.85, 553, 1360,
            "Lithium bromide is a compound consisting of one lithium atom bonded to one bromine atom. It is a white crystalline solid. Lithium bromide is used in air conditioning systems as a desiccant and in certain chemical processes.");

        InformationPanel.SetActive(true);
    }

    public void CadmiumOxide()
    {
        SetElementInfo("Cadmium Oxide", "CdO", 128.41, 1405, 1606,
            "Cadmium oxide is a compound consisting of one cadmium atom bonded to one oxygen atom. It is a brown crystalline solid. Cadmium oxide is used in the production of pigments, glass, and as a catalyst in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void CadmiumChloride()
    {
        SetElementInfo("Cadmium Chloride", "CdCl2", 183.32, 568, 960,
            "Cadmium chloride is a compound consisting of one cadmium atom bonded to two chlorine atoms. It is a white crystalline solid. Cadmium chloride is used in the production of batteries, as a precursor in the synthesis of cadmium compounds, and in certain chemical processes.");

        InformationPanel.SetActive(true);
    }

    public void CadmiumBromide()
    {
        SetElementInfo("Cadmium Bromide", "CdBr2", 235.22, 568, 869,
            "Cadmium bromide is a compound consisting of one cadmium atom bonded to two bromine atoms. It is a white crystalline solid. Cadmium bromide is used in the synthesis of organic compounds and as a catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }

    public void CadmiumIodide()
    {
        SetElementInfo("Cadmium Iodide", "CdI2", 351.22, 555, 730,
            "Cadmium iodide is a compound consisting of one cadmium atom bonded to two iodine atoms. It is a white crystalline solid. Cadmium iodide is used in the synthesis of organic compounds and as a catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }

    public void IndiumTrichloride()
    {
        SetElementInfo("Indium Trichloride", "InCl3", 221.18, 547, 732,
            "Indium trichloride is a compound consisting of one indium atom bonded to three chlorine atoms. It is a white crystalline solid. Indium trichloride is used in the production of certain electronic devices and as a catalyst in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void IndiumTriiodide()
    {
        SetElementInfo("Indium Triiodide", "InI3", 332.53, 547, 732,
            "Indium triiodide is a chemical compound of indium and iodine with the formula InI3. It is a pale yellow, very hygroscopic monoclinic solid. Indium triiodide is used as a catalyst in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void TinDioxide()
    {
        SetElementInfo("Tin Dioxide", "SnO2", 150.71, 1630, 1800,
            "Tin dioxide, also known as stannic oxide, is a compound consisting of one tin atom bonded to two oxygen atoms. It is a white powder. Tin dioxide is used as a polishing agent, in the production of glass, and as a catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }

    public void AntimonyBromide()
    {
        SetElementInfo("Antimony Bromide", "SbBr3", 361.44, 96, 260,
            "Antimony bromide is a compound consisting of one antimony ion bonded to three bromine atoms. It is a yellow crystalline solid. Antimony bromide is used in the synthesis of certain organic compounds.");

        InformationPanel.SetActive(true);
    }

    public void HydrogenTelluride()
    {
        SetElementInfo("Hydrogen Telluride", "H2Te", 129.61, -49, -2,
            "Hydrogen telluride is a compound consisting of two hydrogen atoms bonded to one tellurium atom. It is a colorless gas with a foul odor. Hydrogen telluride is used in the production of semiconductors and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void HydroiodicAcid()
    {
        SetElementInfo("Hydroiodic Acid", "HI", 127.91, -51.6, -35.4,
            "Hydroiodic acid is a compound consisting of one hydrogen atom bonded to one iodine atom. It is a colorless gas with a sharp, pungent odor. Hydroiodic acid is used in the production of certain chemicals and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void LithiumIodide()
    {
        SetElementInfo("Lithium Iodide", "LiI", 133.84, 449, 1035,
            "Lithium iodide is a compound consisting of one lithium atom bonded to one iodine atom. It is a white crystalline solid. Lithium iodide is used in air conditioning systems as a desiccant and in certain chemical processes.");

        InformationPanel.SetActive(true);
    }

    public void CesiumChloride()
    {
        SetElementInfo("Cesium Chloride", "CsCl", 168.36, 645, 1673,
            "Cesium chloride is a compound consisting of one cesium atom bonded to one chlorine atom. It is a white crystalline solid. Cesium chloride is used in the production of certain optical devices, in the preparation of certain chemicals, and in certain medical applications.");

        InformationPanel.SetActive(true);
    }

    public void CesiumFluoride()
    {
        SetElementInfo("Cesium Fluoride", "CsF", 151.01, 682, 1781,
            "Cesium fluoride is a compound consisting of one cesium atom bonded to one fluorine atom. It is a white crystalline solid. Cesium fluoride is used in the production of certain optical devices, in the preparation of certain chemicals, and in certain medical applications.");

        InformationPanel.SetActive(true);
    }

    public void BariumOxide()
    {
        SetElementInfo("Barium Oxide", "BaO", 153.33, 1918, 3200,
            "Barium oxide is a compound consisting of one barium atom bonded to one oxygen atom. It is a white powder. Barium oxide is used in the production of certain optical glasses, as a dehydrating agent, and in the synthesis of certain chemicals.");

        InformationPanel.SetActive(true);
    }

    public void LanthanumTrichloride()
    {
        SetElementInfo("Lanthanum Trichloride", "LaCl3", 245.26, 858, 1780,
            "Lanthanum trichloride is a compound consisting of one lanthanum atom bonded to three chlorine atoms. It is a white crystalline solid. Lanthanum trichloride is used in the production of certain catalysts and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void CeriumDioxide()
    {
        SetElementInfo("Cerium Dioxide", "CeO2", 172.11, 2400, 2800,
            "Cerium dioxide, also known as ceria, is a compound consisting of one cerium atom bonded to two oxygen atoms. It is a white powder. Cerium dioxide is used in the production of catalysts, as a polishing agent, and in certain electronic applications.");

        InformationPanel.SetActive(true);
    }

    public void CeriumTrichloride()
    {
        SetElementInfo("Cerium Trichloride", "CeCl3", 246.39, 824, 1410,
            "Cerium trichloride is a compound consisting of one cerium atom bonded to three chlorine atoms. It is a yellow crystalline solid. Cerium trichloride is used in the production of certain catalysts and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void PraseodymiumTrichloride()
    {
        SetElementInfo("Praseodymium Trichloride", "PrCl3", 196.47, 816, 1100,
            "Praseodymium trichloride is a compound consisting of one praseodymium atom bonded to three chlorine atoms. It is a yellow-green crystalline solid. Praseodymium trichloride is used in the production of certain catalysts and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void NeodymiumTrichloride()
    {
        SetElementInfo("Neodymium Trichloride", "NdCl3", 233.80, 753, 1100,
            "Neodymium trichloride is a compound consisting of one neodymium atom bonded to three chlorine atoms. It is a purple crystalline solid. Neodymium trichloride is used in the production of certain catalysts and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void SamariumTrichloride()
    {
        SetElementInfo("Samarium Trichloride", "SmCl3", 248.36, 738, 1100,
            "Samarium trichloride is a compound consisting of one samarium atom bonded to three chlorine atoms. It is a pink crystalline solid. Samarium trichloride is used in the production of certain catalysts and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void EuropiumTrichloride()
    {
        SetElementInfo("Europium Trichloride", "EuCl3", 248.86, 830, 1100,
            "Europium trichloride is a compound consisting of one europium atom bonded to three chlorine atoms. It is a white crystalline solid. Europium trichloride is used in the production of certain phosphors for fluorescent lighting and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void GadoliniumTrichloride()
    {
        SetElementInfo("Gadolinium Trichloride", "GdCl3", 263.00, 722, 1100,
            "Gadolinium trichloride is a compound consisting of one gadolinium atom bonded to three chlorine atoms. It is a white crystalline solid. Gadolinium trichloride is used in the production of certain catalysts and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void DysprosiumTrichloride()
    {
        SetElementInfo("Dysprosium Trichloride", "DyCl3", 323.27, 738, 1100,
            "Dysprosium trichloride is a compound consisting of one dysprosium atom bonded to three chlorine atoms. It is a pink crystalline solid. Dysprosium trichloride is used in the production of certain catalysts and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void HolmiumTrichloride()
    {
        SetElementInfo("Holmium Trichloride", "HoCl3", 323.31, 770, 1100,
            "Holmium trichloride is a compound consisting of one holmium atom bonded to three chlorine atoms. It is a pink crystalline solid. Holmium trichloride is used in the production of certain catalysts and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void ErbiumTrichloride()
    {
        SetElementInfo("Erbium Trichloride", "ErCl3", 329.77, 782, 1100,
            "Erbium trichloride is a compound consisting of one erbium atom bonded to three chlorine atoms. It is a pink crystalline solid. Erbium trichloride is used in the production of certain catalysts and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void ThuliumTrichloride()
    {
        SetElementInfo("Thulium Trichloride", "TmCl3", 331.93, 780, 1100,
            "Thulium trichloride is a compound consisting of one thulium atom bonded to three chlorine atoms. It is a pink crystalline solid. Thulium trichloride is used in the production of certain catalysts and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void YtterbiumTrichloride()
    {
        SetElementInfo("Ytterbium Trichloride", "YbCl3", 344.04, 700, 1100,
            "Ytterbium trichloride is a compound consisting of one ytterbium atom bonded to three chlorine atoms. It is a white crystalline solid. Ytterbium trichloride is used in the production of certain catalysts and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void LutetiumTrichloride()
    {
        SetElementInfo("Lutetium Trichloride", "LuCl3", 267.28, 770, 1100,
            "Lutetium trichloride is a compound consisting of one lutetium atom bonded to three chlorine atoms. It is a white crystalline solid. Lutetium trichloride is used in the production of certain catalysts and as a reagent in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void HafniumDioxide()
    {
        SetElementInfo("Hafnium Dioxide", "HfO2", 210.49, 2812, 6000,
            "Hafnium dioxide is a compound consisting of one hafnium atom bonded to two oxygen atoms. It is a white crystalline solid. Hafnium dioxide is used in the production of certain electronic devices, as a high-k dielectric material, and in certain ceramic applications.");

        InformationPanel.SetActive(true);
    }

    public void BismuthTrichloride()
    {
        SetElementInfo("Bismuth Trichloride", "BiCl3", 315.34, 225, 447,
            "Bismuth trichloride is a compound consisting of one bismuth atom bonded to three chlorine atoms. It is a yellow crystalline solid. Bismuth trichloride is used in the synthesis of certain organic compounds and as a Lewis acid catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }

    public void BismuthTribromide()
    {
        SetElementInfo("Bismuth Tribromide", "BiBr3", 391.70, 189, 384,
            "Bismuth tribromide is a compound consisting of one bismuth atom bonded to three bromine atoms. It is a yellow crystalline solid. Bismuth tribromide is used in the synthesis of certain organic compounds and as a Lewis acid catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }
    public void ThoriumDioxide()
    {
        SetElementInfo("Thorium Dioxide", "ThO2", 264.04, 3300, 4820,
            "Thorium dioxide is a compound consisting of one thorium atom bonded to two oxygen atoms. It is a white crystalline solid. Thorium dioxide is used in the production of certain electronic devices, as a nuclear fuel, and in certain ceramic applications.");

        InformationPanel.SetActive(true);
    }

    public void UraniumDioxide()
    {
        SetElementInfo("Uranium Dioxide", "UO2", 270.03, 2865, 5982,
            "Uranium dioxide is a compound consisting of one uranium atom bonded to two oxygen atoms. It is a black crystalline solid. Uranium dioxide is used as nuclear fuel in nuclear reactors.");

        InformationPanel.SetActive(true);
    }

    public void UraniumTrichloride()
    {
        SetElementInfo("Uranium Trichloride", "UCl3", 344.46, 733, 1575,
            "Uranium trichloride is a compound consisting of one uranium atom bonded to three chlorine atoms. It is a green crystalline solid. Uranium trichloride is used as a precursor in the synthesis of other uranium compounds.");

        InformationPanel.SetActive(true);
    }

    public void PlutoniumDioxide()
    {
        SetElementInfo("Plutonium Dioxide", "PuO2", 239.05, 1986, 3505,
            "Plutonium dioxide is a compound consisting of one plutonium atom bonded to two oxygen atoms. It is a dark brown to black solid. Plutonium dioxide is used as nuclear fuel in nuclear reactors.");

        InformationPanel.SetActive(true);
    }

    public void TungstenTrioxide()
    {
        SetElementInfo("Tungsten Trioxide", "WO3", 231.84, 1473, 0,
            "Tungsten trioxide is a compound consisting of one tungsten atom bonded to three oxygen atoms. It is a yellow crystalline solid. Tungsten trioxide is used in the production of certain pigments and as a catalyst in certain chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void TungstenChloride()
    {
        SetElementInfo("Tungsten Chloride", "WCl2", 0, 0, 0,
            "Tungsten chloride is a compound consisting of one tungsten atom bonded to two chlorine atoms. Tungsten chloride is not commonly encountered, and its properties may vary depending on the specific form or oxidation state.");

        InformationPanel.SetActive(true);
    }



    public void RheniumTrioxide()
    {
        SetElementInfo("Rhenium Trioxide", "ReO3", 264.23, 0, 0,
            "Rhenium trioxide is a compound consisting of one rhenium atom bonded to three oxygen atoms. It is a yellow crystalline solid. Rhenium trioxide is used in the production of certain catalysts and as a precursor in the synthesis of other rhenium compounds.");

        InformationPanel.SetActive(true);
    }

    public void RheniumChloride()
    {
        SetElementInfo("Rhenium Chloride", "ReCl2", 0, 0, 0,
            "Rhenium chloride is a compound consisting of one rhenium atom bonded to two chlorine atoms. Rhenium chloride is not commonly encountered, and its properties may vary depending on the specific form or oxidation state.");

        InformationPanel.SetActive(true);
    }



    public void IridiumDioxide()
    {
        SetElementInfo("Iridium Dioxide", "IrO2", 0, 0, 0,
            "Iridium dioxide is a compound consisting of one iridium atom bonded to two oxygen atoms. Iridium is a dense, corrosion-resistant metal, and its compounds are not commonly encountered outside of research and specialized applications.");

        InformationPanel.SetActive(true);
    }

    public void IridiumChloride()
    {
        SetElementInfo("Iridium Chloride", "IrCl2", 0, 0, 0,
            "Iridium chloride is a compound consisting of one iridium atom bonded to two chlorine atoms. Iridium chloride is not commonly encountered, and its properties may vary depending on the specific form or oxidation state.");

        InformationPanel.SetActive(true);
    }


    public void PlatinumDioxide()
    {
        SetElementInfo("Platinum Dioxide", "PtO2", 0, 0, 0,
            "Platinum dioxide is a compound consisting of one platinum atom bonded to two oxygen atoms. Platinum is a precious metal, and its compounds are not commonly encountered outside of research and specialized applications.");

        InformationPanel.SetActive(true);
    }

    public void PlatinumChloride()
    {
        SetElementInfo("Platinum Chloride", "PtCl2", 0, 0, 0,
            "Platinum chloride is a compound consisting of one platinum atom bonded to two chlorine atoms. Platinum chloride is not commonly encountered, and its properties may vary depending on the specific form or oxidation state.");

        InformationPanel.SetActive(true);
    }

    public void GoldChloride()
    {
        SetElementInfo("Gold Chloride", "AuCl", 232.50, 0, 0,
            "Gold chloride is a compound consisting of one gold atom bonded to one chlorine atom. It is a yellow crystalline solid. Gold chloride is used in the synthesis of certain organic compounds.");

        InformationPanel.SetActive(true);
    }

    public void MercuryChloride()
    {
        SetElementInfo("Mercury Chloride", "HgCl2", 271.52, 277, 302,
            "Mercury chloride, also known as mercuric chloride, is a compound consisting of one mercury ion bonded to two chlorine atoms. It is a white crystalline solid. Mercury chloride is used in the production of certain chemicals and as a disinfectant.");

        InformationPanel.SetActive(true);
    }

    public void MercuryBromide()
    {
        SetElementInfo("Mercury Bromide", "HgBr2", 360.42, 235, 268,
            "Mercury bromide is a compound consisting of one mercury ion bonded to two bromine atoms. It is a white crystalline solid. Mercury bromide is used in the production of certain chemicals and as a photographic intensifier.");

        InformationPanel.SetActive(true);
    }

    public void MercuryIodide()
    {
        SetElementInfo("Mercury Iodide", "HgI2", 454.40, 235, 303,
            "Mercury iodide is a compound consisting of one mercury ion bonded to two iodine atoms. It is a red crystalline solid. Mercury iodide is used in the production of certain chemicals and as a photographic intensifier.");

        InformationPanel.SetActive(true);
    }


    public void SilverChloride()
    {
        SetElementInfo("Silver Chloride", "AgCl", 143.32, 455, 566,
            "Silver chloride is a chemical compound of silver and chlorine with the formula AgCl. It is a white, odorless, light-sensitive powder or crystalline solid. Silver chloride is used in photography and in the production of certain dyes and plastics.");

        InformationPanel.SetActive(true);
    }

    public void SilverBromide()
    {
        SetElementInfo("Silver Bromide", "AgBr", 187.8, 480, 728,
            "Silver bromide is a chemical compound of silver and bromine with the formula AgBr. It is a pale yellow, odorless, light-sensitive powder or crystalline solid. Silver bromide is used in photography and in the production of certain dyes and plastics.");

        InformationPanel.SetActive(true);
    }

    public void SilverIodide()
    {
        SetElementInfo("Silver Iodide", "AgI", 234.87, 459, 621,
            "Silver iodide is a chemical compound of silver and iodine with the formula AgI. It is a pale yellow, odorless, light-sensitive powder or crystalline solid. Silver iodide is used in photography and in the production of certain dyes and plastics.");

        InformationPanel.SetActive(true);
    }


    public void ZArc()
    {

    }


    public void ZEnd()
    {

    }
}
