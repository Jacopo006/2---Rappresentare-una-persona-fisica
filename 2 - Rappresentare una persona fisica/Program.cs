using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Rappresentare_una_persona_fisica
{
        class dati
        {
            public string codice;
            public string nome;
            public string cognome;
            public bool registrato;
            public dati(string codice, string cognome, string nome)
            {
                this.codice = codice;
                this.cognome = cognome;
                this.nome = nome;
                registrato = false;
            }
            public void Registra()
            {
                registrato = true;
                Console.WriteLine("Persona registrata con successo.");
            }
            public void Mostra()
            {
                Console.WriteLine("Codice: {0}", codice);
                Console.WriteLine("Cognome: {0}", cognome);
                Console.WriteLine("Nome: {0}", nome);
                Console.WriteLine("Registrato: {0}", registrato ? "Sì" : "No");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                dati persona = new dati("21323", "Rota", "Alessandro");

                Console.WriteLine("Dati Anagrafici prima della registrazione:");
                persona.Mostra();
                Console.WriteLine("Clicca un tasto per confermare la registrazione");
                Console.ReadLine();
                persona.Registra();

                Console.WriteLine("\nDati Anagrafici dopo la registrazione:");
                persona.Mostra();
            }
        }
    }

