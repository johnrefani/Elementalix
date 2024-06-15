using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    private Dictionary<string, bool> elementStatus = new Dictionary<string, bool>();
    void Start()
    {
        elementStatus.Add("H", false);
        elementStatus.Add("H2", false);
        elementStatus.Add("H3", false);
        elementStatus.Add("H4", false);
        elementStatus.Add("He", false);
        elementStatus.Add("Li", false);
        elementStatus.Add("Be", false);
        elementStatus.Add("B", false);
        elementStatus.Add("C", false);
        elementStatus.Add("C2", false);
        elementStatus.Add("C3", false);
        elementStatus.Add("N", false);
        elementStatus.Add("N2", false);
        elementStatus.Add("O", false);
        elementStatus.Add("O2", false);
        elementStatus.Add("O3", false);
        elementStatus.Add("O4", false);
        elementStatus.Add("F", false);
        elementStatus.Add("F2", false);
        elementStatus.Add("F3", false);
        elementStatus.Add("F4", false);
        elementStatus.Add("F5", false);
        elementStatus.Add("F6", false);
        elementStatus.Add("Ne", false);
        elementStatus.Add("Na", false);
        elementStatus.Add("Mg", false);
        elementStatus.Add("Al", false);
        elementStatus.Add("Si", false);
        elementStatus.Add("P", false);
        elementStatus.Add("S", false);
        elementStatus.Add("S2", false);
        elementStatus.Add("Cl", false);
        elementStatus.Add("Cl2", false);
        elementStatus.Add("Cl3", false);
        elementStatus.Add("Cl4", false);
        elementStatus.Add("Ar", false);
        elementStatus.Add("K", false);
        elementStatus.Add("Ca", false);
        elementStatus.Add("Sc", false);
        elementStatus.Add("Sc2", false);
        elementStatus.Add("Ti", false);
        elementStatus.Add("V", false);
        elementStatus.Add("Cr", false);
        elementStatus.Add("Mn", false);
        elementStatus.Add("Fe", false);
        elementStatus.Add("Ni", false);
        elementStatus.Add("Co", false);
        elementStatus.Add("Cu", false);
        elementStatus.Add("Zn", false);
        elementStatus.Add("Ga", false);
        elementStatus.Add("Ge", false);
        elementStatus.Add("As", false);
        elementStatus.Add("Se", false);
        elementStatus.Add("Se2", false);
        elementStatus.Add("Br", false);
        elementStatus.Add("Br2", false);
        elementStatus.Add("Br3", false);
        elementStatus.Add("Kr", false);
        elementStatus.Add("Rb", false);
        elementStatus.Add("Sr", false);
        elementStatus.Add("Y", false);
        elementStatus.Add("Zr", false);
        elementStatus.Add("Nb", false);
        elementStatus.Add("Mo", false);
        elementStatus.Add("Tc", false);
        elementStatus.Add("Ru", false);
        elementStatus.Add("Rh", false);
        elementStatus.Add("Pd", false);
        elementStatus.Add("Ag", false);
        elementStatus.Add("Cd", false);
        elementStatus.Add("In", false);
        elementStatus.Add("Sn", false);
        elementStatus.Add("Sb", false);
        elementStatus.Add("Te", false);
        elementStatus.Add("I", false);
        elementStatus.Add("Xe", false);
        elementStatus.Add("Cs", false);
        elementStatus.Add("Ba", false);
        elementStatus.Add("La", false);
        elementStatus.Add("Ce", false);
        elementStatus.Add("Pr", false);
        elementStatus.Add("Nd", false);
        elementStatus.Add("Pm", false);
        elementStatus.Add("Sm", false);
        elementStatus.Add("Eu", false);
        elementStatus.Add("Gd", false);
        elementStatus.Add("Tb", false);
        elementStatus.Add("Dy", false);
        elementStatus.Add("Ho", false);
        elementStatus.Add("Er", false);
        elementStatus.Add("Tm", false);
        elementStatus.Add("Yb", false);
        elementStatus.Add("Lu", false);
        elementStatus.Add("Hf", false);
        elementStatus.Add("Ta", false);
        elementStatus.Add("W", false);
        elementStatus.Add("Re", false);
        elementStatus.Add("Os", false);
        elementStatus.Add("Ir", false);
        elementStatus.Add("Pt", false);
        elementStatus.Add("Au", false);
        elementStatus.Add("Hg", false);
        elementStatus.Add("Tl", false);
        elementStatus.Add("Pb", false);
        elementStatus.Add("Bi", false);
        elementStatus.Add("Po", false);
        elementStatus.Add("At", false);
        elementStatus.Add("Rn", false);
        elementStatus.Add("Fr", false);
        elementStatus.Add("Ra", false);
        elementStatus.Add("Ac", false);
        elementStatus.Add("Th", false);
        elementStatus.Add("Pa", false);
        elementStatus.Add("U", false);
        elementStatus.Add("Np", false);
        elementStatus.Add("Pu", false);
        elementStatus.Add("Am", false);
        elementStatus.Add("Cm", false);
        elementStatus.Add("Bk", false);
        elementStatus.Add("Cf", false);
        elementStatus.Add("Es", false);
        elementStatus.Add("Fm", false);
        elementStatus.Add("Md", false);
        elementStatus.Add("No", false);
        elementStatus.Add("Lr", false);

    }

    public void ElementActived(string name)
    {
        elementStatus[name] = true;

    }

    public void ElementDeactived(string name)
    {
        elementStatus[name] = false;

    }

    public bool isElementActive(string name)
    {
        return elementStatus[name] == true;
    }
}
