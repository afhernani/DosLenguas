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
        public enum  eFuncion
        {
            Sustantivo,
            Pronombre,
            Adjetivo,
            Verbo,
            Adverbio,
            Preposicion,
            Conjuncion,
            Locacion,
            Interjeccion,
            Oracion
        }
        eFuncion funcion = eFuncion.Sustantivo;
        public eFuncion Funcion { get; set; }
		public Word()
		{
		}
		public string Esp{ get; set; }
		public string Ing{ get; set; }
		public string Commen{get; set;}
        public string Sound { get; set; }
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
			return string.Format("[{0}, {1}, {2}, {3}, {4}, {5}]", Esp, Ing, Commen, funcion, Sound, _id);
		}
	}
}
