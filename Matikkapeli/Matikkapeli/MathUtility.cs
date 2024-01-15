using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matikkapeli
{
    public class MathUtility
    {

        int _aika;
        List<int> _ajatPlus;
        List<int> _ajatMiinus;
        List<int> _ajatKerto;
        List<int> _ajatJako;

        public MathUtility()
        {
            _ajatPlus = new List<int>();
            _ajatMiinus = new List<int>();
            _ajatKerto = new List<int>();
            _ajatJako = new List<int>();
        }

        public  List<int> LataaAjatPlus()
        {

            string tiedostonimi1 = "Parhaat_ajat.txt1";
            if (File.Exists(tiedostonimi1))
            {
                _ajatPlus = File.ReadLines(tiedostonimi1)
                            .Select(line => int.Parse(line))
                            .ToList();
            }
            return _ajatPlus;
        }

        public List<int> LataaAjatMiinus()
        {

            string tiedostonimi2 = "Parhaat_ajat.txt2";
            if (File.Exists(tiedostonimi2))
            {
                _ajatMiinus = File.ReadLines(tiedostonimi2)
                            .Select(line => int.Parse(line))
                            .ToList();
            }
            return _ajatMiinus;
        }

        public List<int> LataaAjatKerto()
        {

            string tiedostonimi3 = "Parhaat_ajat.txt3";
            if (File.Exists(tiedostonimi3))
            {
                _ajatKerto = File.ReadLines(tiedostonimi3)
                            .Select(line => int.Parse(line))
                            .ToList();
            }
            return _ajatKerto;
        }

        public List<int> LataaAjatJako()
        {

            string tiedostonimi4 = "Parhaat_ajat.txt4";
            if (File.Exists(tiedostonimi4))
            {
                _ajatJako = File.ReadLines(tiedostonimi4)
                            .Select(line => int.Parse(line))
                            .ToList();
            }
            return _ajatJako;
        }

        public void TallennaAikaPlus(int _aika)
        {


            _ajatPlus.Add(_aika);

            int pieninAika = _ajatPlus.Min();
            int minuutit = pieninAika / 60;
            int sekuntit = pieninAika % 60;
           

            string tiedostonimi = "Parhaat_ajat.txt1";
            using (StreamWriter sw = new StreamWriter(tiedostonimi))
            {
                foreach (int aika in _ajatPlus)
                {
                    sw.WriteLine(aika);
                }
            }
        }

        public void TallennaAikaMiinus(int _aika)
        {


            _ajatMiinus.Add(_aika);

            int pieninAika = _ajatMiinus.Min();
            int minuutit = pieninAika / 60;
            int sekuntit = pieninAika % 60;


            string tiedostonimi2 = "Parhaat_ajat.txt2";
            using (StreamWriter sw = new StreamWriter(tiedostonimi2))
            {
                foreach (int aika in _ajatMiinus)
                {
                    sw.WriteLine(aika);
                }
            }
        }

        public void TallennaAikaJako(int _aika)
        {


            _ajatJako.Add(_aika);

            int pieninAika = _ajatJako.Min();
            int minuutit = pieninAika / 60;
            int sekuntit = pieninAika % 60;


            string tiedostonimi4 = "Parhaat_ajat.txt4";
            using (StreamWriter sw = new StreamWriter(tiedostonimi4))
            {
                foreach (int aika in _ajatJako)
                {
                    sw.WriteLine(aika);
                }
            }
        }

        public void TallennaAikaKerto(int _aika)
        {


            _ajatKerto.Add(_aika);

            int pieninAika = _ajatKerto.Min();
            int minuutit = pieninAika / 60;
            int sekuntit = pieninAika % 60;


            string tiedostonimi3 = "Parhaat_ajat.txt3";
            using (StreamWriter sw = new StreamWriter(tiedostonimi3))
            {
                foreach (int aika in _ajatKerto)
                {
                    sw.WriteLine(aika);
                }
            }
        }
    }
}
