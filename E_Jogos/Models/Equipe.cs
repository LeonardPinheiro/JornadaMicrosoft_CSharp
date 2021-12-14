using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using E_Jogos.Interface;

namespace E_Jogos.Models
{

    // hranca -> jogosBase
    public class Equipe : EjogosBase, IEquipe
    {
        //Construtor CTOR

        //funcao que vai executar/iniciar assim que a classe for instanciada

        private const string path = "Database/equipe.csv";

        public Equipe()
        {
            CreateFolderAndFile(path);
        }

     

        public int IdEquipe { get; set; }

        public int Nome { get; set; }

        public int Imagem { get; set; }



        //funcao qu vai prepara/converter de string para o tipo equip

        public string Prepare(Equipe e)
        {
            return $"{e.IdEquipe}; {e.Imagem}";
        }

        public void Create(Equipe nova_equipe)
        {
            //receber um objeto de equip e gravar no csv

            string[] linha = { $"{nova_equipe.IdEquipe}; {nova_equipe.Nome}; {nova_equipe.Imagem}" };


            File.AppendAllLines(path, linha);

        }

        public void Delete(int idEquipe)
        {
            throw new NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(path);

            foreach(string item in linhas)
            {
                Equipe equipe = new Equipe();
                equipe.IdEquipe = int.Parse(item.Split(';')[0]);
                equipe.Nome = int.Parse(item.Split(';')[1]);
                equipe.Imagem = int.Parse(item.Split(';')[2]);

                equipes.Add(equipe);
            }
            return equipes;
        }

        public void Update(Equipe equipe)
        {
            throw new NotImplementedException();
        }
    }
}