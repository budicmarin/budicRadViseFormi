using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budicRadViseFormi
{
    public partial class UnosNovogStudenta : Form
    {
        List<Student> studenti = new List<Student>();
        public UnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            
            Student temp = new Student(textBoxIme.Text,textBoxPrezime.Text,Convert.ToString(comboBoxSmjer.SelectedItem),
                Convert.ToInt32(textBoxBrojIndeksa.Text),dateTimePickerDatumRodjenja.Value);
            studenti.Add(temp);
        }
    }
}
