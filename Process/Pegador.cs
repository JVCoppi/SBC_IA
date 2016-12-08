using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Process;

namespace Process
{
    public class Pegador
    {

        static string connectionString = "mongodb://localhost:27017";
        static MongoClient client = new MongoClient(connectionString);
        static MongoServer server = client.GetServer();
        static MongoDatabase database = server.GetDatabase("sbc_IA");
        MongoCollection<Caso> coll = database.GetCollection<Caso>("casos");
        MongoCollection<Propriedade> coll2 = database.GetCollection<Propriedade>("propriedades");

        public List<Caso> listarTodosCasos()
        {
            MongoCursor<Caso> result = coll.FindAll();
            List<Caso> casos = new List<Caso>();
            foreach (Caso r in result)
            {
                casos.Add(r);
            }

            return casos;
        }


        public List<Propriedade> listarTodosProp()
        {
            MongoCursor<Propriedade> result = coll2.FindAll();
            List<Propriedade> props = new List<Propriedade>();
            foreach (Propriedade p in result)
            {
                props.Add(p);
            }

            return props;
        }

        public int getValor(string a, string c)
        {
            int valor = 0;
            var query = Query.And(Query<Propriedade>.EQ(e => e.atributo, a), Query<Propriedade>.EQ(e => e.classe, c));
            Propriedade p = coll2.FindOne(query);
            valor = p.valor;
            return valor;
        }

        public int getPeso(string c)
        {
            var query = Query<Propriedade>.EQ(e => e.classe, c);
            Propriedade p = coll2.FindOne(query);
            int peso = p.peso;
            return peso;
        }

        public int verificaIgual(string a, string b)
        {
            if(a == "Desconhecido" || b == "Desconhecido")
            {
                return 0;
            }
            else
            {
                if (a == b)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public string getSimilaridade(string c)
        {
            var query = Query<Propriedade>.EQ(e => e.classe, c);
            Propriedade p = coll2.FindOne(query);
            string simi = p.similaridade;
            return simi;

        }

        public int getMaior(string c)
        {
            int maior = 0;
            var query = Query<Propriedade>.EQ(e => e.classe, c);
            var props = coll2.Find(query);
            foreach(var v in props)
            {
                if (maior < v.valor)
                    maior = v.valor;
            }
            return maior;
        }

        public int getMenor()
        {
            return 0;
        }
       
        public Caso getCasoMaiorSimilaridade(List<Caso> casos)
        {
            Caso aux = new Caso();
            double simi = 0;
            foreach(Caso c in casos)
            {
                if (c.SimilaridadeGlobal > simi)
                {
                    simi = c.SimilaridadeGlobal;
                    aux = c;
                }
            }
            return aux;
        }

        public void insereCaso(Caso c)
        {

        }

    }
}
