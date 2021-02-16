using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicRadViseFormi
{
    class Student
    {
        string ime;
        string prezime;
        string smjer;
        int brojIndeksa;
        DateTime datumRodj;

        public Student(string ime, string prezime, string smjer, int brojIndeksa, DateTime datumRodj)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.smjer = smjer;
            this.brojIndeksa = brojIndeksa;
            this.datumRodj = datumRodj;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public int BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value; }
        public DateTime DatumRodj { get => datumRodj; set => datumRodj = value; }
    }
}
