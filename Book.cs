using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Proyecto1
{
    public class Book
    {
        //private string _author;
        public string author { get; set; }

        public string title { get; set; }
        private string isbn { get; set; }
        private bool estado { get; set; }
        private int id { get; set; }

        /*
        public string GetTitulo()
        {
            return Title;
        }

        public void SetTitulo(string value)
        {
            Title = value;
        }

        public string Autor
        {
            get{
                return this._author;
            }
            set{
                if(value.Length < 5)
                {
                    Console.WriteLine("Nombre inválido");
                };
                this._author = value;
            }
        }

        public string Titulo { get; set; }

        */

        public Book(string author, string title, string isbn)
        {
            this.author = author;
            this.title = title;
            this.isbn = isbn;
            this.estado = false;
            this.id += id;
        }

        public Book()
        {
            this.author = "";
            this.title = "";
            this.isbn = "";
            this.id = 0;
        }


        /*
        public Book() 
        {
            this._author = "Default author";
            this.SetTitulo("Default title");

        }
        */

        public string getIsbn()
        {
            return this.isbn;
        }

        public bool getEstado()
        {
            return this.estado;
        }

        public void setEstado(bool estadoAux) { this.estado = estadoAux; }
    }
}
