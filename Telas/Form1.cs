using Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas
{
    public partial class telaEntrada : Form
    {
        public telaEntrada()
        {
            InitializeComponent();
            MessageBox.Show("ATENÇÃO: Você está prestes a testemunhar um trabalho muito empírico, não seja mente fechada, use a criatividade.");

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bConfirm_Click_1(object sender, EventArgs e)
        {
            string areadamaged = boxad.SelectedItem.ToString();
            string cankerlesion = bcl.SelectedItem.ToString();
            string crophist = bch.SelectedItem.ToString();
            string date = bda.SelectedItem.ToString();
            string externaldecay = bed.SelectedItem.ToString();
            string fruitspots = bfs.SelectedItem.ToString();
            string fruitingbodies = bfb.SelectedItem.ToString();
            string fruitpods = bfp.SelectedItem.ToString();
            string germination = bge.SelectedItem.ToString();
            string hail = bha.SelectedItem.ToString();
            string intdiscolor = bid.SelectedItem.ToString();
            string leafmalf = blm.SelectedItem.ToString();
            string leafmild = blmi.SelectedItem.ToString();
            string leafshread = bls.SelectedItem.ToString();
            string leafspotshalo = blph.SelectedItem.ToString();
            string leafspotsize = blps.SelectedItem.ToString();
            string leafspotsmarg = blpm.SelectedItem.ToString();
            string leaves = ble.SelectedItem.ToString();
            string lodging = blo.SelectedItem.ToString();
            string moldgrowth = bmg.SelectedItem.ToString();
            string mycelium = bmy.SelectedItem.ToString();
            string plantgrowth = bpg.SelectedItem.ToString();
            string plantstand = bps.SelectedItem.ToString();
            string precip = bpre.SelectedItem.ToString();
            string roots = broo.SelectedItem.ToString();
            string sclerotia = bsc.SelectedItem.ToString();
            string seed = bsee.SelectedItem.ToString();
            string seeddiscolor = bsd.SelectedItem.ToString();
            string seedsize = bss.SelectedItem.ToString();
            string seedtmt = bst.SelectedItem.ToString();
            string severity = bsv.SelectedItem.ToString();
            string shriveling = bsh.SelectedItem.ToString();
            string stem = bste.SelectedItem.ToString();
            string stemcankers = bstc.SelectedItem.ToString();
            string temp = btp.SelectedItem.ToString();

            Caso c = new Caso();
            c.area_damaged = areadamaged;
            c.canker_lesion = cankerlesion;
            c.crop_hist = crophist;
            c.date = date;
            c.external_decay = externaldecay;
            c.fruiting_bodies = fruitingbodies;
            c.fruit_pods = fruitpods;
            c.fruit_spots = fruitspots;
            c.germination = germination;
            c.hail = hail;
            c.int_discolor = intdiscolor;
            c.leafspots_halo = leafspotshalo;
            c.leafspots_marg = leafspotsmarg;
            c.leafspot_size = leafspotsize;
            c.leaf_malf = leafmalf;
            c.leaf_mild = leafmild;
            c.leaf_shread = leafshread;
            c.leaves = leaves;
            c.lodging = lodging;
            c.mold_growth = moldgrowth;
            c.mycelium = mycelium;
            c.plant_growth = plantgrowth;
            c.plant_stand = plantstand;
            c.precip = precip;
            c.roots = roots;
            c.sclerotia = sclerotia;
            c.seed = seed;
            c.seed_discolor = seeddiscolor;
            c.seed_size = seedsize;
            c.seed_tmt = seedtmt;
            c.severity = severity;
            c.shriveling = shriveling;
            c.stem = stem;
            c.stem_cankers = stemcankers;
            c.temp = temp;

            Hide();
            telaProc telaProc = new telaProc(c);
            telaProc.ShowDialog();          

        }
    }
}
