/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 01/08/2017
 * Hora: 21:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace DosLenguas
{
	/// <summary>
	/// Description of FormVerbos.
	/// </summary>
	public partial class FormVerbos : Form
	{
		string[] verbosIregulares = {"surgir", "despertar(se)", "soportar", "golpear", "convertirse en", 
			"empezar", "doblar (se)", "apostar", "pujar", "encuadernar", "morder", 
			"sangrar", "soplar", "romper", "criar", "traer", "construir", "quemar (se)", "estallar",
			"comprar", "tirar", "coger", "elegir", "aferrarse", "venir", "costar", "arrastrar", "cortar", 
			"tratar", "cavar", "hacer", "dibujar", "soñar", "beber", "conducir", "comer", "caer", 
			"alimentar", "sentirse", "pelearse", "encontrar", "huir", "volar", "prohibir", "olvidar (se)",
			"perdonar", "helar", "conseguir", "dar", "irse", "moler", "crecer", "colgar", "tener", 
			"escuchar", "esconder (se)", "golpear", "agarrar (se)", "daño", "guardar", "arrodillarse", 
			"conocer", "poner", "llevar", "apoyarse", "brincar", "aprender", "dejar", "prestar", 
			"permitir", "echarse", "encender(se)", "perder", "hacer", "significar", 
			"encontrar", "vencer (se)", "pagar", "poner", "leer", "montar", "sonar", 
			"levantarse", "correr", "serrar", "decir", "ver", "buscar", "vender",
			"enviar", "poner", "coser", "agitar", "esquilar", "brillar", "disparar", "mostrar", 
			"encoger(se)", "cerrar(se)", "cantar"
		};
		Random valor;
		MongoClient mc;
		static MongoServer mongo;
		MongoDatabase db;
		const string basedatos = "dic";
		const string tabla = "bocablos";
		MongoCollection colectionBocablos;
		public FormVerbos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int total;
		int p;
		void FormVerbosLoad(object sender, EventArgs e)
		{
			valor = new Random();
			total = verbosIregulares.Length;
			p = valor.Next(1, total);
			lbvocablo.Text = verbosIregulares[p];
			mc = new MongoClient("mongodb://localhost");
			mongo = mc.GetServer();
			db = mongo.GetDatabase(basedatos);
			colectionBocablos = db.GetCollection(tabla);
		}
		
		void BtnOkClick(object sender, EventArgs e)
		{
			bool bien = false;
			var Palabras = colectionBocablos.AsQueryable<Word>();
			var res = from c in Palabras
				where c.Esp.ToUpper() == verbosIregulares[p].ToUpper()
			           select c;
			//pasamos los resultados a la lista
			if (res.Count() >= 1) {
				foreach (Word element in res) {
					richTextBox.Text = ("verbo: " + res.First().ToJson());
				}
				Word d = res.First();
				string[] conjverbal = d.Commen.Split(" ".ToCharArray());
				if (conjverbal.Length < 3)
					return;
				if (textBoxinfinitvo.Text.Equals(conjverbal[0]))
					bien = true;
				else
					bien = false;
				if (textBoxPasado.Text.Equals(conjverbal[1]))
					bien = true;
				else
					bien = false;
				if (textBoxparticipio.Text.Equals(conjverbal[2]))
					bien = true;
				else
					bien = false;
				if (bien)
					richTextBox.Text += "\nAcertaste!!";
				else
					richTextBox.Text += "\nFallaste!!!";
			}
		}
		void BtnNextClick(object sender, EventArgs e)
		{
			textBoxinfinitvo.Clear();
			textBoxPasado.Clear();
			textBoxparticipio.Clear();
			p = valor.Next(1, total);
			lbvocablo.Text = verbosIregulares[p];
		}
	}
}
