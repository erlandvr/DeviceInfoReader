using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SQLite;

namespace VHVEMatrix.SQliteDB.Create
{
	class Program
	{
		static void Main(string[] args)
		{
			var db = new SQLiteConnection("/Users/erland/Downloads/Fedpol/SQLiteDB/VHVEMatrix2");
			db.CreateTable<VHVEMatrix.Models.VHVEMatrix>();
			
			List<VHVEMatrix.Models.VHVEMatrix> values = File.ReadAllLines("/Users/erland/Downloads/Fedpol/DeviceInfoReader/Bordertask Annex 2.1 Transversal Features Annex no. 1.csv")
				.Skip(1)
				.Select(v => VHVEMatrix.Models.VHVEMatrix.FromCsv(v))
				.ToList();

			foreach (VHVEMatrix.Models.VHVEMatrix value in values)
			{
				db.InsertOrReplace(value);
				Console.WriteLine($"{value.CoulcaoCode} inserted");
			}
			
			var table = db.Query<VHVEMatrix.Models.VHVEMatrix>("SELECT * FROM VHVEMatrix");
			foreach (var line in table)
			{
				Console.WriteLine(line.CouTextBE);
			}
			db.Close();
		}
	}
}