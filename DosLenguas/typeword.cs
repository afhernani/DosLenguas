/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 01/08/2017
 * Hora: 17:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace DosLenguas
{
	/// <summary>
	/// clasificacion de las palabras
	/// </summary>
	public enum typeword
	{
		sustantivo,
		pronombre,
		verbo,
		adjetivo
	}
	/// <summary>
	/// Description of typeword.
	/// </summary>
	public struct Typeword : IEquatable<Typeword>
	{
		string member; // this is just an example member, replace it with your own struct members!
		public static Typeword Empty;
		#region Equals and GetHashCode implementation
		// The code in this region is useful if you want to use this structure in collections.
		// If you don't need it, you can just remove the region and the ": IEquatable<typeword>" declaration.
		static Typeword(){
			Empty = new Typeword();
			Empty.member = String.Empty;
		}
		public Typeword(string cad){
			member=cad;
		}
		public bool IsEmpty{
			get{
				return(String.IsNullOrEmpty(member));
			}
		}
		public override string ToString()
		{
			return string.Format("[{0}]", member);
		}

		public override bool Equals(object obj)
		{
			if (obj is Typeword)
				return Equals((Typeword)obj); // use Equals method below
			else
				return false;
		}
		
		public bool Equals(Typeword other)
		{
			// add comparisions for all members here
			return this.member.Equals(other);// == other.member;
		}
		
		public override int GetHashCode()
		{
			// combine the hash codes of all members here (e.g. with XOR operator ^)
			return member.GetHashCode();
		}
		
		public static bool operator ==(Typeword left, Typeword right)
		{
			return left.Equals(right);
		}
		
		public static bool operator !=(Typeword left, Typeword right)
		{
			return !left.Equals(right);
		}
		#endregion
	}
}
