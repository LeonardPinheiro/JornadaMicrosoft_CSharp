using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Jogos.Models;

namespace E_Jogos.Controllers
{
    public class E_jogosController : Controller
    {

        Equipe equipeModel = new Equipe();

        public Equipe EquipeModel { get => EquipeModel1; set => EquipeModel1 = value; }
        public Equipe EquipeModel1 { get => EquipeModel2; set => EquipeModel2 = value; }
        public Equipe EquipeModel2 { get => EquipeModel3; set => EquipeModel3 = value; }
        public Equipe EquipeModel3 { get => EquipeModel4; set => EquipeModel4 = value; }
        public Equipe EquipeModel4 { get => EquipeModel5; set => EquipeModel5 = value; }
        public Equipe EquipeModel5 { get => equipeModel; set => equipeModel = value; }

        //actionresult e responsavel pelo retorno do http
        // GET: E_jogos
        public IActionResult Index()
        {
            //View = responsavel pela exibiçao do front
            //Viewbag = armazena as informacoes do backend para serem acessadas no frontend
            //Controlles para a View

            ViewBag.Equipes = EquipeModel.ReadAll();

            return View();
        }

        public IActionResult Cadastrar(FormCollection form)
        {
            Equipe nova_equipe = new Equipe();
            nova_equipe.IdEquipe = int.Parse(form["IdEquipe"]);
            nova_equipe.Nome = new form["Nome"];
            nova_equipe.Imagem = new form["Imagem"];

            EquipeModel.Create(nova_equipe);

            ViewBag.Equipes = new equipeModel.ReadAll();

            return LocalRedirect("~/Equipe");

        }
    }
}