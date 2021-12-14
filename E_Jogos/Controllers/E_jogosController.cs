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

        //actionresult e responsavel pelo retorno do http
        // GET: E_jogos
        public IActionResult Index()
        {
            //View = responsavel pela exibiçao do front
            //Viewbag = armazena as informacoes do backend para serem acessadas no frontend
            //Controlles para a View

            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }

        public IActionResult Cadastrar(FormCollection form)
        {
            Equipe nova_equipe = new Equipe();
            nova_equipe.IdEquipe = int.Parse(form["IdEquipe"]);
            nova_equipe.Nome = new form["Nome"];
            nova_equipe.Imagem = new form["Imagem"];

            equipeModel.Create(nova_equipe);

            ViewBag.Equipes = new equipeModel.ReadAll();

            return LocalRedirect("~/Equipe");

        }
    }
}