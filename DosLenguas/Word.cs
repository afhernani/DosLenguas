/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 07/07/2017
 * Hora: 12:13
 * Clase: Word
 */
using System;
using MongoDB.Bson;

namespace DosLenguas
{
	/// <summary>
	/// Description of Word.
	/// </summary>
	public class Word
	{
		
		public Word()
		{
		}
		public string Esp{ get; set; }
		public string Ing{ get; set; }
		public string Commen{get; set;}
		public ObjectId _id{ get; set; }
		public Word(string esp, string ing){
			this.Esp = esp;
			this.Ing = ing;
			this.Commen = "";
		}
		public Word(string esp, string ing, string commen):this(esp,ing)
		{
			this.Commen = commen;
		}
		
		public override string ToString()
		{
			return string.Format("[Palabra Es={0}, In={1}, Commen = {2}, Id={3}]", Esp, Ing, Commen, _id);
		}
	}
}
