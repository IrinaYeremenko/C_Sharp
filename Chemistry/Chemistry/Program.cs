using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemistry
{
    class ChemicalSubstance

    {
        public string type;
        public string metals;
        public string nonMetals;
        public string nobelGases;
        public string oxides;
        public string salts;
        public string hydroxides;
        public string acids;
        public string amphotericHydroxides;
    }

    class Organic : ChemicalSubstance
    {
        public void TypificationOfSubstances()
        {
            Console.WriteLine("Первый вид химических веществ это {0} вещества", type);
        }
    }

    class Inorganic : ChemicalSubstance
    {
        public void TypificationOfSubstances()
        {
            Console.WriteLine("Второй вид химических веществ это {0} вещества", type);
        }
    }

    class Hydrocarbons : Organic
    {
        public void HydrogenCarbon()
        {
            Console.WriteLine("Все органические вещества - это {0}", type);
        }
    }

    class Сyclic : Hydrocarbons
    {
        public void FormOfHydrocarbon()
        {
            Console.WriteLine("Углеводороды по строению углеродной цепи могут быть {0}", type);
        }
    }

    class Acyclic : Hydrocarbons
    {
        public void FormOfHydrocarbon()
        {
            Console.WriteLine("Также углеводороды по строению углеродной цепи могут быть {0}", type);
        }
    }

    class Simple : Inorganic
    {
        public void InorganicTypification()
        {
            Console.WriteLine("Неорганические вещества бывают {0}", type);
        }
    }

    class Complex : Inorganic
    {
        public void InorganicTypification()
        {
            Console.WriteLine("Также неорганические вещества бывают {0}", type);
        }
    }

    class TypeOfSimple : Simple
    {
        public void SimpleTypification()
        {
            Console.WriteLine("Простые вещества делятся на {0}, {1}, {2}", metals, nonMetals, nobelGases);
        }
    }
    class TypeOfComplex : Complex
    {
        public void ComplexTypification()
        {
            Console.WriteLine("Сложные вещества делятся на {0}, {1}, {2}, {3}, {4}", oxides, salts, hydroxides, acids, amphotericHydroxides);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Organic org = new Organic();
            org.type = "ОРГАНИЧЕСКИЕ";
            org.TypificationOfSubstances();

            Inorganic inorg = new Inorganic();
            inorg.type = "НЕОРГАНИЧЕСКИЕ";
            inorg.TypificationOfSubstances();

            Hydrocarbons hyd = new Hydrocarbons();
            hyd.type = "УГЛЕВОДОРОДЫ";
            hyd.HydrogenCarbon();

            Сyclic cyc = new Сyclic();
            cyc.type = "ЦИКЛИЧЕСКИЕ";
            cyc.FormOfHydrocarbon();

            Acyclic acyc = new Acyclic();
            acyc.type = "АЦИКЛИЧЕСКИЕ";
            acyc.FormOfHydrocarbon();

            Simple s = new Simple();
            s.type = "ПРОСТЫЕ";
            s.InorganicTypification();

            Complex c = new Complex();
            c.type = "СЛОЖНЫЕ";
            c.InorganicTypification();

            TypeOfSimple tos = new TypeOfSimple();
            tos.metals = "МЕТАЛЛЫ";
            tos.nonMetals = "НЕМЕТАЛЛЫ";
            tos.nobelGases = "БЛАГОРОДНЫЕ ГАЗЫ";
            tos.SimpleTypification();

            TypeOfComplex toc = new TypeOfComplex();
            toc.oxides = "ОКСИДЫ";
            toc.salts = "СОЛИ";
            toc.hydroxides = "ОСНОВАНИЯ";
            toc.acids = "КИСЛОТЫ";
            toc.amphotericHydroxides = "АМФОТЕРНЫЕ ГИДРОКСИДЫ";
            toc.ComplexTypification();
    }
    }
}
