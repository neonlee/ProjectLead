using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConnectLead.Controllers
{
    public class ConnectLeadController : Controller
    {
        private int[] lista = { 1, 2, 3, 4, 5, 2, 3, 4, 5, 2, 4 };
        int[] Listanova = new int[11];
        // GET: ConnectLead
        public ActionResult Index()
        {
            return View();
        }

        public double Media()
        {
            return Media(lista, lista.Length - 1, 0);
        }

        public int Elementos()
        {
            return Elementos(Media(), lista, lista.Length - 1, 0);
        }

        public int[] reverso()
        {
            return Inverso(lista,lista.Length - 1, Listanova, 0);
        }

        public double Media(int[] list, int tamanho, float soma)
        {
            if (tamanho >= 0)
            {
                soma = soma + list[tamanho];
                return Media(list, tamanho - 1, soma);
            }
            return soma / list.Length;
        }

        public int Elementos(double Media, int[] lista, int tamanho, int soma)
        {
            if (tamanho >= 0 && lista[tamanho] > Media)
            {
                soma++;
                return Elementos(Media, lista, tamanho - 1, soma);
            }
            else
            {
                return soma;
            }
        }

        public int[] Inverso(int[] lista, int tamanho, int[] novaLista, int i)
        {
            if (tamanho >= 0)
            {
                novaLista[i] = lista[tamanho];
                return Inverso(lista, tamanho - 1, novaLista, i + 1);
            }
            return novaLista;
        }
    }
}