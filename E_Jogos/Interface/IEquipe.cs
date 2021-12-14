using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Jogos.Models;

namespace E_Jogos.Interface
{

    //Responsavel por determinar quais metodos uma classe tera
    //é o contrato da classe
    interface IEquipe
    {
        //Create

        //Readall

        //Update

        //Delete


        void Create(Equipe nova_equipe);

        List<Equipe> ReadAll();

        void Update(Equipe equipe);

        void Delete(int idEquipe);
    }
}
