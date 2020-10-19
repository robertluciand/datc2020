
using System;
	using Microsoft.WindowsAzure.Storage.Table;

	namespace Models
	{
	    public class Studententity : TableEntity
	    {
	        public Studententity(string uni, string Cnp)
	        {
	            this.PartitionKey = uni;
	            this.RowKey = cnp;
	        }
	        public Studententity() {}

	        public string Nume {get; set;}
	        public string Prenume {get; set;}
	        public string Facultate {get; set;}
	        public int An {get; set;}


	    }
	}