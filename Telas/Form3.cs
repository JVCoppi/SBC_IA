using MongoDB.Driver;
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
    public partial class telaFinal : Form
    {
        private Caso cP;
        private Caso cS;
        public telaFinal(Caso casoProb, Caso casoSelect)
        {
            InitializeComponent();
            cP = casoProb;
            cS = casoSelect; 
        }

        private void bFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bReter_Click(object sender, EventArgs e)
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("sbc_IA");
            MongoCollection<Caso> coll = database.GetCollection<Caso>("casos");
            if (cS.SimilaridadeGlobal < 1)
            {
                coll.Insert(cP);
                MessageBox.Show($"Caso adicionado na Base de Conhecimento com sucesso!\nNúmero do caso: {cP.caso}\nDoença: {cP.doenca}");
            }
            else
            {
                MessageBox.Show($"Este caso já existe na Base de Conhecimento!\nNúmero do caso: {cS.caso}\nDoença: {cS.doenca}");
            }
        }
    }
}
