using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_FireStore.Models
{
    [FirestoreData]
    public class Pessoa
    {
        public string PessoaId { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
    }
}
