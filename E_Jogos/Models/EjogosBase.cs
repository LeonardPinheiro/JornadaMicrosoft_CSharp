using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace E_Jogos.Models
{
    public class EjogosBase
    {
        //Criar uma funcao para criar a pasta  o arquivo

        //string path e o paramtro da funcao, que tera o caminho para analise
        public void CreateFolderAndFile(string path)
        {
            //pasta / arquivo.csv

            string folder = path.Split('/')[0]; //recebe o nome da pasta
            string file = path.Split('/')[1]; //recebe o nome do arquivo

            //se nao xistir cria a pasta
            if (Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }

    }
}