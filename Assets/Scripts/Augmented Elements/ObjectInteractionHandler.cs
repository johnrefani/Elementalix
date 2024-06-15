using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectInteractionHandler : MonoBehaviour
{
    public GameObject InformationPanel;
    public TMP_Text ElementName, Information, Description;
    private string StartingPage = "StartingPage";

    void Start()
    {
        ClosePanel();
    }

    private void SetElementInfo(string name, string symbol, int atomicNumber, double atomicMass, double meltingPoint, double boilingPoint, string description)
    {
        ElementName.text = name;
        Information.text = $"Symbol: {symbol}\n" +
                           $"Atomic Number: {atomicNumber}\n" +
                           $"Atomic mass: {atomicMass:F2} u\n" +
                           $"Melting point: {meltingPoint:F2}°C ({meltingPoint + 273.15:F2} K)\n" +
                           $"Boiling point: {boilingPoint:F2}°C ({boilingPoint + 273.15:F2} K)\n";
        Description.text = $"\n{description}";
    }


    //Element 1 - 10
    public void Hydrogen()
    {

        SetElementInfo("Hydrogen", "H", 1, 1.0078, -259.16, -252.87,
            "Hydrogen, discovered in the late 18th century, belongs to the first group of the periodic table. It is the lightest and most abundant chemical element in the universe, a colorless, odorless gas that is an essential component of water (H2O). Hydrogen plays a crucial role in various industrial processes and holds great promise as a clean and renewable energy source, particularly in hydrogen fuel cells, due to its potential for generating electricity with minimal environmental impact.");

        InformationPanel.SetActive(true);
    }

    public void Helium()
    {
 
        SetElementInfo("Helium", "He", 2, 4.0026, -272.20, -268.93,
            "Helium is a colorless, odorless, and tasteless noble gas. It is the second-lightest and second-most abundant element in the observable universe, mainly produced through nuclear fusion in stars. Helium is known for its low density and is commonly used to fill balloons and airships, as well as in cryogenic applications and helium-neon lasers.");
        InformationPanel.SetActive(true);
    }

    public void Lithium()
    {
        SetElementInfo("Lithium", "Li", 3, 6.941, 180.54, 1342.0, 
            "Lithium is a soft, silvery-white alkali metal. It is highly reactive and flammable, often stored under oil to prevent oxidation. Lithium compounds are used in batteries, ceramics, and psychiatric medication.");

        InformationPanel.SetActive(true);
    }

    public void Beryllium()
    {
        SetElementInfo("Beryllium", "Be", 4, 9.0122, 1287.0, 2470.0, 
            "Beryllium is a light, brittle, steel-gray alkaline earth metal. It is known for its high melting point, stiffness, and low density. Beryllium and its compounds are used in aerospace applications and as a moderator in nuclear reactors.");

        InformationPanel.SetActive(true);
    }

    public void Boron()
    {
        SetElementInfo("Boron", "B", 5, 10.81, 2075.0, 4000.0,
            "Boron is a non-metallic element. It exists in several allotropic forms, the most common of which is amorphous boron, a dark powder. Boron compounds are used in a variety of applications, including as a component in borosilicate glass and in semiconductors.");

        InformationPanel.SetActive(true);
    }

    public void Carbon()
    {
        SetElementInfo("Carbon", "C", 6, 12.011, 3915.0, 3915.0,
            "Carbon is a non-metallic element that can exist in various forms, including graphite, diamond, and amorphous carbon. It is the fundamental building block of organic compounds and plays a crucial role in the chemistry of life.");

        InformationPanel.SetActive(true);
    }

    public void Nitrogen()
    {
        SetElementInfo("Nitrogen", "N", 7, 14.007, -210.0, -195.8,
            "Nitrogen is a colorless, odorless, and tasteless diatomic gas. It is the most abundant element in Earth's atmosphere and is vital for life as a key component of amino acids, DNA, and RNA.");

        InformationPanel.SetActive(true);
    }

    public void Oxygen()
    {
        SetElementInfo("Oxygen", "O", 8, 15.999, -218.8, -182.9,
            "Oxygen is a diatomic gas essential for respiration in most living organisms. It is also used in various industrial processes, including steel production and medical applications.");

        InformationPanel.SetActive(true);
    }

    public void Fluorine()
    {
        SetElementInfo("Fluorine", "F", 9, 18.998, -219.67, -188.12,
            "Fluorine is a highly reactive, pale yellow diatomic gas. It is the most electronegative element and is used in the production of uranium hexafluoride for nuclear fuel.");

        InformationPanel.SetActive(true);
    }

    public void Neon()
    {
        SetElementInfo("Neon", "Ne", 10, 20.180, -248.59, -246.08,
            "Neon is a noble gas known for its bright, colorful glow when used in signs and lighting. It is chemically inert and does not readily form compounds with other elements.");

        InformationPanel.SetActive(true);
    }

    //Element 11 - 20
    public void Sodium()
    {
        SetElementInfo("Sodium", "Na", 11, 22.990, 97.72, 882.94,
            "Sodium is a soft, silvery-white alkali metal. It is highly reactive and reacts vigorously with water, producing sodium hydroxide and hydrogen gas. Sodium compounds are used in various applications, including in the food industry.");

        InformationPanel.SetActive(true);
    }

    public void Magnesium()
    {
        SetElementInfo("Magnesium", "Mg", 12, 24.305, 650.0, 1090.0,
            "Magnesium is a light, silvery-white alkaline earth metal. It is commonly used in alloys and is an essential element in chlorophyll, the molecule responsible for photosynthesis in plants.");

        InformationPanel.SetActive(true);
    }

    public void Aluminum()
    {
        SetElementInfo("Aluminum", "Al", 13, 26.982, 660.32, 2467.0,
            "Aluminum is a lightweight, silvery-white metal. It is the third most abundant element in Earth's crust and has a wide range of applications, including in the aerospace, automotive, and construction industries.");

        InformationPanel.SetActive(true);
    }

    public void Silicon()
    {
        SetElementInfo("Silicon", "Si", 14, 28.085, 1414.0, 3265.0,
            "Silicon is a non-metallic element with a crystalline structure. It is a key component of semiconductors and plays a crucial role in the electronics industry.");

        InformationPanel.SetActive(true);
    }

    public void Phosphorus()
    {
        SetElementInfo("Phosphorus", "P", 15, 30.974, 44.15, 280.5,
            "Phosphorus exists in several allotropic forms, including white, red, and black phosphorus. It is an essential element in living organisms and is a key component of DNA, RNA, and ATP.");

        InformationPanel.SetActive(true);
    }

    public void Sulfur()
    {
        SetElementInfo("Sulfur", "S", 16, 32.06, 115.21, 444.6,
            "Sulfur is a non-metallic element with a distinct odor. It is used in the production of sulfuric acid and is a key component of various amino acids and vitamins.");

        InformationPanel.SetActive(true);
    }

    public void Chlorine()
    {
        SetElementInfo("Chlorine", "Cl", 17, 35.453, -101.5, -34.04,
            "Chlorine is a pale green diatomic gas. It is used as a disinfectant and in the production of various chemicals, including PVC and chlorinated solvents.");

        InformationPanel.SetActive(true);
    }

    public void Argon()
    {
        SetElementInfo("Argon", "Ar", 18, 39.948, -189.35, -185.85,
            "Argon is a noble gas and is the third most abundant gas in Earth's atmosphere. It is used in welding and as a protective atmosphere in various industrial processes.");

        InformationPanel.SetActive(true);
    }

    public void Potassium()
    {
        SetElementInfo("Potassium", "K", 19, 39.098, 63.38, 774.0,
            "Potassium is a soft, silvery-white alkali metal. It is essential for the functioning of cells and is commonly found in potassium-rich foods like bananas.");

        InformationPanel.SetActive(true);
    }

    public void Calcium()
    {
        SetElementInfo("Calcium", "Ca", 20, 40.078, 842.0, 1484.0,
            "Calcium is a silvery-white alkaline earth metal. It is essential for bone health and is used in various applications, including in the production of cement and as a reducing agent in the extraction of metals.");

        InformationPanel.SetActive(true);
    }

    //Element 21 - 30
    public void Scandium()
    {
        SetElementInfo("Scandium", "Sc", 21, 44.956, 1539.0, 2836.0,
            "Scandium is a silvery-white transition metal. It is relatively rare and is primarily used in aerospace and high-performance sports equipment.");

        InformationPanel.SetActive(true);
    }

    public void Titanium()
    {
        SetElementInfo("Titanium", "Ti", 22, 47.867, 1668.0, 3287.0,
            "Titanium is a strong, corrosion-resistant transition metal. It is commonly used in aerospace, medical implants, and the production of lightweight alloys.");

        InformationPanel.SetActive(true);
    }

    public void Vanadium()
    {
        SetElementInfo("Vanadium", "V", 23, 50.942, 1910.0, 3407.0,
            "Vanadium is a hard, silvery-gray transition metal. It is used in the production of steel alloys and is important in the development of certain catalysts.");

        InformationPanel.SetActive(true);
    }

    public void Chromium()
    {
        SetElementInfo("Chromium", "Cr", 24, 51.996, 1907.0, 2672.0,
            "Chromium is a hard, shiny transition metal. It is known for its corrosion resistance and is used in the production of stainless steel and chrome plating.");

        InformationPanel.SetActive(true);
    }

    public void Manganese()
    {
        SetElementInfo("Manganese", "Mn", 25, 54.938, 1246.0, 2061.0,
            "Manganese is a gray-white transition metal. It is essential in steel production and is used in batteries and the production of various alloys.");

        InformationPanel.SetActive(true);
    }

    public void Iron()
    {
        SetElementInfo("Iron", "Fe", 26, 55.845, 1538.0, 2862.0,
            "Iron is a lustrous, silvery-gray transition metal. It is the most commonly used metal and is essential for the production of steel and in various industrial processes.");

        InformationPanel.SetActive(true);
    }

    public void Cobalt()
    {
        SetElementInfo("Cobalt", "Co", 27, 58.933, 1495.0, 2927.0,
            "Cobalt is a hard, silvery-gray transition metal. It is used in the production of rechargeable batteries, magnetic materials, and in some medical applications.");

        InformationPanel.SetActive(true);
    }

    public void Nickel()
    {
        SetElementInfo("Nickel", "Ni", 28, 58.693, 1453.0, 2732.0,
            "Nickel is a silvery-white transition metal. It is used in the production of stainless steel, coins, and various alloys.");

        InformationPanel.SetActive(true);
    }

    public void Copper()
    {
        SetElementInfo("Copper", "Cu", 29, 63.546, 1084.6, 2562.0,
            "Copper is a reddish-brown transition metal. It is an excellent conductor of electricity and is used in electrical wiring, plumbing, and various other applications.");

        InformationPanel.SetActive(true);
    }

    public void Zinc()
    {
        SetElementInfo("Zinc", "Zn", 30, 65.38, 419.5, 907.0,
            "Zinc is a bluish-white transition metal. It is used in galvanization, as a dietary supplement, and in the production of various alloys.");

        InformationPanel.SetActive(true);
    }

    //Element 31 - 40
    public void Gallium()
    {
        SetElementInfo("Gallium", "Ga", 31, 69.723, 29.76, 2204.0,
            "Gallium is a soft, silvery-white metal with a low melting point. It is used in semiconductors, LEDs, and as a non-toxic alternative to mercury in thermometers.");

        InformationPanel.SetActive(true);
    }

    public void Germanium()
    {
        SetElementInfo("Germanium", "Ge", 32, 72.630, 938.3, 2833.0,
            "Germanium is a lustrous, gray-white metalloid. It is used in the production of semiconductors and optical fibers.");

        InformationPanel.SetActive(true);
    }

    public void Arsenic()
    {
        SetElementInfo("Arsenic", "As", 33, 74.922, 817.0, 613.0,
            "Arsenic is a metalloid that can exist in various allotropes. It is toxic and has been used historically as a poison. Arsenic compounds have applications in semiconductor manufacturing.");

        InformationPanel.SetActive(true);
    }

    public void Selenium()
    {
        SetElementInfo("Selenium", "Se", 34, 78.971, 217.0, 685.0,
            "Selenium is a non-metallic element. It is used in the electronics industry and as a dietary supplement.");

        InformationPanel.SetActive(true);
    }

    public void Bromine()
    {
        SetElementInfo("Bromine", "Br", 35, 79.904, -7.3, 58.8,
            "Bromine is a dark red-brown liquid at room temperature. It is the only non-metallic element that is liquid under normal conditions and is used in flame retardants.");

        InformationPanel.SetActive(true);
    }

    public void Krypton()
    {
        SetElementInfo("Krypton", "Kr", 36, 83.798, -157.36, -153.22,
            "Krypton is a noble gas that is chemically inert. It is used in some types of photographic flash lamps and as a filling gas in energy-saving fluorescent lights.");

        InformationPanel.SetActive(true);
    }

    public void Rubidium()
    {
        SetElementInfo("Rubidium", "Rb", 37, 85.468, 38.89, 688.0,
            "Rubidium is a soft, silvery-white alkali metal. It is used in atomic clocks and has some applications in the field of electronics.");

        InformationPanel.SetActive(true);
    }

    public void Strontium()
    {
        SetElementInfo("Strontium", "Sr", 38, 87.62, 769.0, 1384.0,
            "Strontium is a soft, silvery alkaline earth metal. It is used in the production of fireworks and as a component in some toothpaste formulations.");

        InformationPanel.SetActive(true);
    }

    public void Yttrium()
    {
        SetElementInfo("Yttrium", "Y", 39, 88.906, 1523.0, 3337.0,
            "Yttrium is a silvery transition metal. It is used in the production of phosphors for color television tubes and LEDs.");

        InformationPanel.SetActive(true);
    }

    public void Zirconium()
    {
        SetElementInfo("Zirconium", "Zr", 40, 91.224, 1855.0, 4409.0,
            "Zirconium is a strong, corrosion-resistant transition metal. It is used in nuclear reactors, the aerospace industry, and in the production of high-temperature ceramics.");

        InformationPanel.SetActive(true);
    }

    //Element 41 - 50

    public void Niobium()
    {
        SetElementInfo("Niobium", "Nb", 41, 92.906, 2477.0, 4744.0,
            "Niobium is a soft, gray transition metal. It is used in the production of superalloys, superconductors, and in the aerospace industry.");

        InformationPanel.SetActive(true);
    }

    public void Molybdenum()
    {
        SetElementInfo("Molybdenum", "Mo", 42, 95.950, 2623.0, 4639.0,
            "Molybdenum is a silvery-white transition metal. It is used in the production of steel alloys, electrical contacts, and as a lubricant additive.");

        InformationPanel.SetActive(true);
    }

    public void Technetium()
    {
        SetElementInfo("Technetium", "Tc", 43, 98.000, 2157.0, 4265.0,
            "Technetium is a synthetic element that does not have stable isotopes. It is used in nuclear medicine for diagnostic imaging.");

        InformationPanel.SetActive(true);
    }

    public void Ruthenium()
    {
        SetElementInfo("Ruthenium", "Ru", 44, 101.07, 2334.0, 4150.0,
            "Ruthenium is a hard, white transition metal. It is used in the production of electrical contacts and as a catalyst in chemical reactions.");

        InformationPanel.SetActive(true);
    }

    public void Rhodium()
    {
        SetElementInfo("Rhodium", "Rh", 45, 102.91, 1966.0, 3727.0,
            "Rhodium is a rare, silvery-white transition metal. It is used in catalytic converters for automobiles and in the production of jewelry.");

        InformationPanel.SetActive(true);
    }

    public void Palladium()
    {
        SetElementInfo("Palladium", "Pd", 46, 106.42, 1554.9, 2927.0,
            "Palladium is a silvery-white transition metal. It is used in catalytic converters, electronics, and in the purification of hydrogen.");

        InformationPanel.SetActive(true);
    }

    public void Silver()
    {
        SetElementInfo("Silver", "Ag", 47, 107.87, 961.8, 2162.0,
            "Silver is a lustrous, white metal known for its conductivity. It is used in coins, jewelry, electrical contacts, and photography.");

        InformationPanel.SetActive(true);
    }

    public void Cadmium()
    {
        SetElementInfo("Cadmium", "Cd", 48, 112.41, 321.07, 767.0,
            "Cadmium is a soft, bluish-white transition metal. It is used in rechargeable batteries, pigments, and as a corrosion-resistant plating for steel.");

        InformationPanel.SetActive(true);
    }

    public void Indium()
    {
        SetElementInfo("Indium", "In", 49, 114.82, 156.60, 2072.0,
            "Indium is a soft, silvery-white metal. It is used in the production of semiconductors, soldering, and as a transparent electrode in some electronic devices.");

        InformationPanel.SetActive(true);
    }

    public void Tin()
    {
        SetElementInfo("Tin", "Sn", 50, 118.71, 231.93, 2602.0,
            "Tin is a silvery-white metal. It is used in the production of solder, alloys, and as a protective coating for other metals.");

        InformationPanel.SetActive(true);
    }

    //Element 51 - 60
    public void Antimony()
    {
        SetElementInfo("Antimony", "Sb", 51, 121.76, 630.63, 1950.0,
            "Antimony is a brittle, silvery-white metalloid. It is used in flame retardants, alloys, and as a semiconductor in some electronic devices.");

        InformationPanel.SetActive(true);
    }

    public void Tellurium()
    {
        SetElementInfo("Tellurium", "Te", 52, 127.60, 449.51, 989.8,
            "Tellurium is a brittle, silvery-white metalloid. It is used in alloys, solar panels, and as a semiconductor in electronic devices.");

        InformationPanel.SetActive(true);
    }

    public void Iodine()
    {
        SetElementInfo("Iodine", "I", 53, 126.90, 113.7, 184.4,
            "Iodine is a purple-black, lustrous non-metallic element. It is used in medicine, photography, and as a disinfectant.");

        InformationPanel.SetActive(true);
    }

    public void Xenon()
    {
        SetElementInfo("Xenon", "Xe", 54, 131.29, -111.9, -108.1,
            "Xenon is a noble gas that is chemically inert. It is used in various lighting applications, including in high-intensity discharge lamps.");

        InformationPanel.SetActive(true);
    }

    public void Cesium()
    {
        SetElementInfo("Cesium", "Cs", 55, 132.91, 28.44, 671.0,
            "Cesium is a soft, silvery-gold alkali metal. It is used in atomic clocks, drilling fluids, and in some photoelectric cells.");

        InformationPanel.SetActive(true);
    }

    public void Barium()
    {
        SetElementInfo("Barium", "Ba", 56, 137.33, 727.0, 1870.0,
            "Barium is a soft, silvery alkaline earth metal. It is used in the production of x-ray contrast agents, fireworks, and as a getter in vacuum tubes.");

        InformationPanel.SetActive(true);
    }

    public void Lanthanum()
    {
        SetElementInfo("Lanthanum", "La", 57, 138.90, 920.0, 3464.0,
            "Lanthanum is a soft, silvery-white rare earth metal. It is used in the production of carbon arc lamps, catalysts, and in some hybrid car batteries.");

        InformationPanel.SetActive(true);
    }

    public void Cerium()
    {
        SetElementInfo("Cerium", "Ce", 58, 140.12, 798.0, 3360.0,
            "Cerium is a soft, silvery-white rare earth metal. It is used in the production of catalytic converters, glass polishing, and as a fuel additive.");

        InformationPanel.SetActive(true);
    }

    public void Praseodymium()
    {
        SetElementInfo("Praseodymium", "Pr", 59, 140.91, 931.0, 3290.0,
            "Praseodymium is a soft, silvery-white rare earth metal. It is used in rare earth magnets, carbon arc lamps, and as an alloying agent in some metals.");

        InformationPanel.SetActive(true);
    }

    public void Neodymium()
    {
        SetElementInfo("Neodymium", "Nd", 60, 144.24, 1021.0, 3100.0,
            "Neodymium is a soft, silvery-white rare earth metal. It is used in strong permanent magnets, lasers, and in some glass and ceramics.");

        InformationPanel.SetActive(true);
    }

    //Elemen 61 - 70
    public void Promethium()
    {
        SetElementInfo("Promethium", "Pm", 61, 145.00, 1042.0, 3000.0,
            "Promethium is a radioactive rare earth element. It is used in nuclear batteries and as a source of beta radiation in certain devices.");

        InformationPanel.SetActive(true);
    }

    public void Samarium()
    {
        SetElementInfo("Samarium", "Sm", 62, 150.36, 1072.0, 1900.0,
            "Samarium is a silvery-white rare earth metal. It is used in magnets, control rods in nuclear reactors, and as a catalyst in certain reactions.");

        InformationPanel.SetActive(true);
    }

    public void Europium()
    {
        SetElementInfo("Europium", "Eu", 63, 152.00, 822.0, 1597.0,
            "Europium is a silvery-white rare earth metal. It is used in phosphors for color television tubes and in some security features on banknotes.");

        InformationPanel.SetActive(true);
    }

    public void Gadolinium()
    {
        SetElementInfo("Gadolinium", "Gd", 64, 157.25, 1311.0, 3233.0,
            "Gadolinium is a silvery-white rare earth metal. It is used in contrast agents for magnetic resonance imaging (MRI) and in control rods for nuclear reactors.");

        InformationPanel.SetActive(true);
    }

    public void Terbium()
    {
        SetElementInfo("Terbium", "Tb", 65, 158.93, 1369.0, 3041.0,
            "Terbium is a silvery-white rare earth metal. It is used in phosphors for fluorescent lamps, in some electronic devices, and as a component in alloys.");

        InformationPanel.SetActive(true);
    }

    public void Dysprosium()
    {
        SetElementInfo("Dysprosium", "Dy", 66, 162.50, 1412.0, 2567.0,
            "Dysprosium is a silvery-white rare earth metal. It is used in high-strength magnets and in control rods for nuclear reactors.");

        InformationPanel.SetActive(true);
    }

    public void Holmium()
    {
        SetElementInfo("Holmium", "Ho", 67, 164.93, 1470.0, 2720.0,
            "Holmium is a silvery-white rare earth metal. It is used in some types of laser and as a component in nuclear control rods.");

        InformationPanel.SetActive(true);
    }

    public void Erbium()
    {
        SetElementInfo("Erbium", "Er", 68, 167.26, 1529.0, 2868.0,
            "Erbium is a silvery-white rare earth metal. It is used in optical amplifiers, as a colorant in glass, and in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Thulium()
    {
        SetElementInfo("Thulium", "Tm", 69, 168.93, 1545.0, 1950.0,
            "Thulium is a silvery-white rare earth metal. It is used in portable X-ray devices and as a radiation source for cancer treatment.");

        InformationPanel.SetActive(true);
    }

    public void Ytterbium()
    {
        SetElementInfo("Ytterbium", "Yb", 70, 173.05, 824.0, 1196.0,
            "Ytterbium is a silvery-white rare earth metal. It is used in laser systems, certain alloys, and as a doping agent in fiber optics.");

        InformationPanel.SetActive(true);
    }

    //Element 71 - 80
    public void Lutetium()
    {
        SetElementInfo("Lutetium", "Lu", 71, 175.00, 1652.0, 3315.0,
            "Lutetium is a silvery-white rare earth metal. It is used in certain catalysts, in some types of LED lighting, and in nuclear medicine.");

        InformationPanel.SetActive(true);
    }

    public void Hafnium()
    {
        SetElementInfo("Hafnium", "Hf", 72, 178.49, 2233.0, 4603.0,
            "Hafnium is a corrosion-resistant transition metal. It is used in nuclear reactors, as a control rod material, and in some superalloys.");

        InformationPanel.SetActive(true);
    }

    public void Tantalum()
    {
        SetElementInfo("Tantalum", "Ta", 73, 180.95, 3017.0, 5458.0,
            "Tantalum is a rare, blue-gray transition metal. It is used in electronics, as a component in superalloys, and in surgical implants.");

        InformationPanel.SetActive(true);
    }

    public void Tungsten()
    {
        SetElementInfo("Tungsten", "W", 74, 183.84, 3422.0, 5555.0,
            "Tungsten is a dense, gray-white transition metal. It is used in high-temperature applications, including in the filaments of incandescent bulbs.");

        InformationPanel.SetActive(true);
    }

    public void Rhenium()
    {
        SetElementInfo("Rhenium", "Re", 75, 186.21, 3186.0, 5596.0,
            "Rhenium is a silvery-white transition metal. It is used in high-temperature superalloys, as a catalyst, and in X-ray tubes.");

        InformationPanel.SetActive(true);
    }

    public void Osmium()
    {
        SetElementInfo("Osmium", "Os", 76, 190.23, 3306.0, 5285.0,
            "Osmium is a hard, bluish-white transition metal. It is the densest naturally occurring element and is used in some electrical contacts and fountain pen tips.");

        InformationPanel.SetActive(true);
    }

    public void Iridium()
    {
        SetElementInfo("Iridium", "Ir", 77, 192.22, 2446.0, 4428.0,
            "Iridium is a dense, silvery-white transition metal. It is used in electrical contacts, spark plugs, and in some types of compasses.");

        InformationPanel.SetActive(true);
    }

    public void Platinum()
    {
        SetElementInfo("Platinum", "Pt", 78, 195.08, 1768.0, 3825.0,
            "Platinum is a dense, grayish-white transition metal. It is used in jewelry, catalytic converters, and in various chemical and electrical applications.");

        InformationPanel.SetActive(true);
    }

    public void Gold()
    {
        SetElementInfo("Gold", "Au", 79, 196.97, 1064.0, 2807.0,
            "Gold is a dense, yellow precious metal. It is valued for its rarity and is used in jewelry, coins, and as a store of value.");

        InformationPanel.SetActive(true);
    }

    public void Mercury()
    {
        SetElementInfo("Mercury", "Hg", 80, 200.59, -38.83, 356.73,
            "Mercury is a dense, silvery-white transition metal. It is the only metal that is liquid at room temperature and is used in thermometers and dental amalgams.");

        InformationPanel.SetActive(true);
    }

    //Element 81 - 90
    public void Thallium()
    {
        SetElementInfo("Thallium", "Tl", 81, 204.38, 304.0, 1473.0,
            "Thallium is a soft, bluish-white metal. It is used in some types of infrared detectors and as a rodent poison.");

        InformationPanel.SetActive(true);
    }

    public void Lead()
    {
        SetElementInfo("Lead", "Pb", 82, 207.2, 327.5, 1749.0,
            "Lead is a dense, bluish-gray metal. It has been used historically in pipes, batteries, and as a radiation shield. However, due to its toxicity, its use is now restricted in many applications.");

        InformationPanel.SetActive(true);
    }

    public void Bismuth()
    {
        SetElementInfo("Bismuth", "Bi", 83, 208.98, 271.4, 1564.0,
            "Bismuth is a pinkish-white, brittle metal. It is used in some medicines, cosmetics, and as an ingredient in low-melting alloys.");

        InformationPanel.SetActive(true);
    }

    public void Polonium()
    {
        SetElementInfo("Polonium", "Po", 84, 209.98, 254.0, 962.0,
            "Polonium is a highly radioactive element. It is used in some nuclear reactors and as a heat source in some satellites.");

        InformationPanel.SetActive(true);
    }

    public void Astatine()
    {
        SetElementInfo("Astatine", "At", 85, 210.00, 302.0, 337.0,
            "Astatine is a rare, radioactive halogen. It has no significant commercial applications due to its scarcity and radioactivity.");

        InformationPanel.SetActive(true);
    }

    public void Radon()
    {
        SetElementInfo("Radon", "Rn", 86, 222.00, -71.0, -61.7,
            "Radon is a radioactive noble gas. It is used in some radiographic and radiation therapy procedures.");

        InformationPanel.SetActive(true);
    }

    public void Francium()
    {
        SetElementInfo("Francium", "Fr", 87, 223.00, -1.0, 677.0,
            "Francium is a highly radioactive alkali metal. It is extremely rare and has no significant commercial applications due to its scarcity and radioactivity.");

        InformationPanel.SetActive(true);
    }

    public void Radium()
    {
        SetElementInfo("Radium", "Ra", 88, 226.00, 700.0, 1737.0,
            "Radium is a highly radioactive alkaline earth metal. It was historically used in self-luminous paints, but its use has been largely discontinued due to its radioactivity.");

        InformationPanel.SetActive(true);
    }

    public void Actinium()
    {
        SetElementInfo("Actinium", "Ac", 89, 227.00, 1050.0, 3200.0,
            "Actinium is a radioactive rare earth metal. It is used in some neutron sources and as a neutron absorber in some nuclear reactors.");

        InformationPanel.SetActive(true);
    }

    public void Thorium()
    {
        SetElementInfo("Thorium", "Th", 90, 232.04, 1750.0, 4790.0,
            "Thorium is a radioactive rare earth metal. It is used in some nuclear reactors, as a catalyst, and as a component in some high-temperature alloys.");

        InformationPanel.SetActive(true);
    }

    //Element 91 - 100
    public void Protactinium()
    {
        SetElementInfo("Protactinium", "Pa", 91, 231.04, 1568.0, 4027.0,
            "Protactinium is a radioactive rare earth metal. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Uranium()
    {
        SetElementInfo("Uranium", "U", 92, 238.03, 1132.0, 4131.0,
            "Uranium is a radioactive heavy metal. It is used as a fuel in nuclear reactors and as a source of fissile material for nuclear weapons.");

        InformationPanel.SetActive(true);
    }

    public void Neptunium()
    {
        SetElementInfo("Neptunium", "Np", 93, 237.00, 640.0, 3902.0,
            "Neptunium is a radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Plutonium()
    {
        SetElementInfo("Plutonium", "Pu", 94, 244.00, 639.4, 3228.0,
            "Plutonium is a highly radioactive synthetic element. It is used as a fuel in nuclear reactors and in the production of nuclear weapons.");

        InformationPanel.SetActive(true);
    }

    public void Americium()
    {
        SetElementInfo("Americium", "Am", 95, 243.00, 994.0, 2607.0,
            "Americium is a radioactive synthetic element. It is used in some smoke detectors and as a neutron source.");

        InformationPanel.SetActive(true);
    }

    public void Curium()
    {
        SetElementInfo("Curium", "Cm", 96, 247.00, 1340.0, 3110.0,
            "Curium is a radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Berkelium()
    {
        SetElementInfo("Berkelium", "Bk", 97, 247.00, 986.0, 2627.0,
            "Berkelium is a radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Californium()
    {
        SetElementInfo("Californium", "Cf", 98, 251.00, 900.0, 1472.0,
            "Californium is a radioactive synthetic element. It is used in some nuclear applications, including as a neutron source.");

        InformationPanel.SetActive(true);
    }

    public void Einsteinium()
    {
        SetElementInfo("Einsteinium", "Es", 99, 252.00, 0, 0,
            "Einsteinium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Fermium()
    {
        SetElementInfo("Fermium", "Fm", 100, 257.00, 0, 0,
            "Fermium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    //Element 101 - 110
    public void Mendelevium()
    {
        SetElementInfo("Mendelevium", "Md", 101, 258.00, 0, 0,
            "Mendelevium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Nobelium()
    {
        SetElementInfo("Nobelium", "No", 102, 259.00, 0, 0,
            "Nobelium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Lawrencium()
    {
        SetElementInfo("Lawrencium", "Lr", 103, 262.00, 0, 0,
            "Lawrencium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Rutherfordium()
    {
        SetElementInfo("Rutherfordium", "Rf", 104, 267.00, 0, 0,
            "Rutherfordium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Dubnium()
    {
        SetElementInfo("Dubnium", "Db", 105, 270.00, 0, 0,
            "Dubnium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Seaborgium()
    {
        SetElementInfo("Seaborgium", "Sg", 106, 271.00, 0, 0,
            "Seaborgium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Bohrium()
    {
        SetElementInfo("Bohrium", "Bh", 107, 270.00, 0, 0,
            "Bohrium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Hassium()
    {
        SetElementInfo("Hassium", "Hs", 108, 277.00, 0, 0,
            "Hassium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Meitnerium()
    {
        SetElementInfo("Meitnerium", "Mt", 109, 278.00, 0, 0,
            "Meitnerium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Darmstadtium()
    {
        SetElementInfo("Darmstadtium", "Ds", 110, 281.00, 0, 0,
            "Darmstadtium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    //Element 111 - 118
    public void Roentgenium()
    {
        SetElementInfo("Roentgenium", "Rg", 111, 280.00, 0, 0,
            "Roentgenium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Copernicium()
    {
        SetElementInfo("Copernicium", "Cn", 112, 285.00, 0, 0,
            "Copernicium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Nihonium()
    {
        SetElementInfo("Nihonium", "Nh", 113, 284.00, 0, 0,
            "Nihonium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Flerovium()
    {
        SetElementInfo("Flerovium", "Fl", 114, 289.00, 0, 0,
            "Flerovium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Moscovium()
    {
        SetElementInfo("Moscovium", "Mc", 115, 288.00, 0, 0,
            "Moscovium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Livermorium()
    {
        SetElementInfo("Livermorium", "Lv", 116, 293.00, 0, 0,
            "Livermorium is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Tennessine()
    {
        SetElementInfo("Tennessine", "Ts", 117, 294.00, 0, 0,
            "Tennessine is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }

    public void Oganesson()
    {
        SetElementInfo("Oganesson", "Og", 118, 294.00, 0, 0,
            "Oganesson is a highly radioactive synthetic element. It has limited use, primarily in some nuclear applications.");

        InformationPanel.SetActive(true);
    }



    public void ClosePanel()
    {
        InformationPanel.SetActive(false);
    }

    public void Exit()
    {
        SceneManager.LoadScene(StartingPage);
    }
}
