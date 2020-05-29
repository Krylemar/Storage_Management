using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Product
    {
		[Key]
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string brand;

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		private int quantity;

		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		private string importer;

		public string Importer
		{
			get { return importer; }
			set { importer = value; }
		}

		private bool isAvailable;

		public bool IsAvailable
		{
			get { return isAvailable; }
			set { isAvailable = value; }
		}

		private int storage_id;
		public int Storage_id
		{
			get { return storage_id; }
			set { storage_id = value; }
		}

	}
}
