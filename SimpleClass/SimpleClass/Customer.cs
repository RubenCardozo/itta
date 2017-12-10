using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Customer
    {
        #region Propriétés de la classe Customer
        private string firstName;
        private string lastName;
        private DateTime birthDay;

        /// <summary>
        /// Prénom de mon client
        /// </summary>
        public string Firstname
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        /// <summary>
        /// Nom de mon client
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        /// <summary>
        /// Date de naissance
        /// </summary>
        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                birthDay = value;
            }
        }
        /// <summary>
        /// Ville du client
        /// </summary>
        public string City { get; set; }


        /// <summary>
        /// Méthode qui retourne les données complète du client
        /// </summary>
        public String GetCompleteName()
        {
            return String.Format("Mon client: {0} {1} Ville:{2}", Firstname, LastName, City);

        }

    }

}
