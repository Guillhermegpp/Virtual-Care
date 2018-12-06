using System;
using System.Collections;
using System.Collections.Generic;

namespace DataBaseApp.Models
{
    [Serializable()]
    public class Patient
    {
        private string _id;
        public string Id
        {
            get => _id; set
            {
                _id = Guid.NewGuid().ToString();
            }
        }
        public string Nome { get; set; }
        public string dataNascimento { get; set; }
        public string tipoSangue { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }

        public List<Remedy> Remedios = new List<Remedy>();

    }
}