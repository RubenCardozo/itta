using MvcApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcNov17.Models
{
    public class Client : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ClientsDAO.GetAllClients().Count(c => c.Id == Id) > 0)
            {
                yield return new ValidationResult(Id + " existe déjà", new[] { "Id" });
            }
           
        }

        String _id;
        [DisplayName("Identifiant")]
        [Required(ErrorMessage = "Identifiant Obligatoire")]
        public String Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != null)
                    _id = value;
                else
                    throw new Exception("id ne peut pas être null");
            }
        }

        [DisplayName("Nom Client")]
        [Required(ErrorMessage ="Nom Obligatoire")]
        [RegularExpression(@"[A-Z]{1,30}", ErrorMessage = "nom en majuscule")]
        public String Nom { get; set; }

        [DisplayName("Prenom Client")]
        [DataType(DataType.MultilineText)]
        [StringLength(20, MinimumLength =1, ErrorMessage ="Prenom entre 1 et 20 cars")]
        [AntiChuck(ErrorMessage ="Il n'y a qu'un Chuck")]
        public String Prenom { get; set; }

        [DisplayName("Date Naissance")]
        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateNaissance { get;  set; }

        [Range(0,150, ErrorMessage = "Age entre 0 et 150")]
        public int Age { get; set; }

        public Client()
        {
        }
        public Client(String id, String nom, String prenom)
        {
            this.Id = id;
            Console.WriteLine(Id + " créé");
            this.Nom = nom;
            this.Prenom = prenom;
        }
        public Client(String id, String nom, String prenom, DateTime DateNaissance) 
            : this( id,  nom,  prenom)
        {
            this.DateNaissance = DateNaissance;
        }

        
    }
}