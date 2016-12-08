using Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas
{
    public partial class telaProc : Form
    {
        private Caso casoP;
        private Caso casoS;

        public telaProc(Caso casoProb)
        {
            InitializeComponent();
            Pegador proc = new Pegador();
            Calculador calc = new Calculador();
            List<Caso> casos = calc.calculoSimilaridadeGlobal(casoProb);
            casoP = casoProb;
            casoS = proc.getCasoMaiorSimilaridade(casos);
            casoP.caso = casos.Count() + 1;
            casoP.doenca = casoS.doenca;

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Hide();
            telaEntrada te = new telaEntrada();
            te.ShowDialog();
            
        }

        private void bNxt_Click(object sender, EventArgs e)
        {
            Hide();
            telaFinal tf = new telaFinal(casoP, casoS);
            tf.ShowDialog();
        }
    }
}
