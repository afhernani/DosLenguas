/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 03/07/2017
 * Hora: 23:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace DosLenguas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form, IForm
	{
		MongoClient mc;
		static MongoServer mongo;
		MongoDatabase db;
		const string basedatos = "dic";
		const string tabla = "bocablos";
		MongoCollection colectionBocablos;
		bool engToEsp = true;

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtStartClick(object sender, EventArgs e)
		{
			if (btStart.Text.Equals("Disc")) {
				mc = null;
				mongo = null;
				db = null;
				btStart.BackColor = Color.Red;
				//btStart.Enabled = true;
				btStart.Text = "Conect";
			} else {	
				mc = new MongoClient("mongodb://localhost");
				mongo = mc.GetServer();
				db = mongo.GetDatabase(basedatos);
				colectionBocablos = db.GetCollection("bocablos");
				btStart.BackColor = Color.Green;
				//btStart.Enabled = true;
				btStart.Text = "Disc";
			}
		}
		
		void TextEspTextChanged(object sender, EventArgs e)
		{
			Debug.WriteLine(textEsp.Text);
			//if (textEsp.Text.Equals(""))
			//	textIng.Text = "";
			if (colectionBocablos == null)
				return;
			richTextBox.Clear();
			richTextCom.Clear();
			if (rdAdd.Checked)
				return;
			if (!String.IsNullOrEmpty(textEsp.Text)) {
				colectionBocablos = db.GetCollection("bocablos");
				var Palabras = colectionBocablos.AsQueryable<Word>();
				var res = from c in Palabras
				          where c.Esp.ToUpper() == textEsp.Text.ToUpper() //|| c.Esp.ToLower().StartsWith(textEsp.Text.ToLower())
				          select c;
				//pasamos los resultados a la lista
				
				foreach (Word element in res) {
					Debug.WriteLine(element.ToJson());
					richTextBox.Text += element.ToJson();
				}
				if (engToEsp == false) {
					textIng.Text = "";
					if (res.Count() >= 1) {
						
						textIng.Text = res.First().Ing;
						richTextCom.Text = res.First().Commen;
					}
				}
			}
		}
		void TextIngTextChanged(object sender, EventArgs e)
		{
			Debug.WriteLine(textIng.Text);
			//if (textIng.Text.Equals(""))
			//	textEsp.Text = "";
			if (colectionBocablos == null)
				return;
			richTextBox.Clear();
			richTextCom.Clear();
			if (rdAdd.Checked)
				return;
			if (!String.IsNullOrEmpty(textIng.Text)) {
				colectionBocablos = db.GetCollection("bocablos");
				var Palabras = colectionBocablos.AsQueryable<Word>();
				var res = from c in Palabras
				          where c.Ing.ToUpper() == textIng.Text.ToUpper()
				          select c;
				//pasamos los resultados a la lista
				
				foreach (Word element in res) {
					Debug.WriteLine(element.ToJson());
					richTextBox.Text += element.ToJson();
				}
				if (engToEsp) {
					textEsp.Text = "";
					if (res.Count() >= 1) {
						
						textEsp.Text = res.First().Esp;
						richTextCom.Text = res.First().Commen;
					}
				}
				
			}
		}
		void BtnInglesClick(object sender, EventArgs e)
		{
			
			if (db == null)
				return; //no esta inicializada la db mongo.
			colectionBocablos = db.GetCollection("bocablos");
			if (!String.IsNullOrEmpty(textIng.Text) && !String.IsNullOrEmpty(textEsp.Text)) {
				Word wd = new Word(textEsp.Text, textIng.Text, richTextCom.Text);
				var writeresult =colectionBocablos.Insert(wd);
				richTextBox.Clear();
				richTextBox.Text = writeresult.ToJson().ToString();
			}
			textIng.Clear();
			textEsp.Clear();
		}
		void RdIngCheckedChanged(object sender, EventArgs e)
		{
			engToEsp = true;
			textEsp.ReadOnly = true;
			textIng.ReadOnly = false;
			btnIngles.Enabled = false;
			btnFormFile.Enabled = false;
		}
		void RdEspCheckedChanged(object sender, EventArgs e)
		{
			engToEsp = false;
			textIng.ReadOnly = true;
			textEsp.ReadOnly = false;
			btnIngles.Enabled = false;
			btnFormFile.Enabled = false;
		}
		void RdAddCheckedChanged(object sender, EventArgs e)
		{
			textIng.ReadOnly = false;
			textEsp.ReadOnly = false;
			btnIngles.Enabled = true;
			btnFormFile.Enabled = true;
		}
				
		void BtnFormFileClick(object sender, EventArgs e)
		{
			FormFileAdd f = new FormFileAdd();
			//esto es una de las claves.
			//lanzarlo con el this como base.
			//puede ser modal o unico con la misma condicion
			//planteada aqui abajo.
			f.Show(this); 
		}
		
		#region IForm implementation
		public void AddWordFromFile(Word nword)
		{
			//TODO: aqui recibimos la palabra, comprobamos que existe en
			//el diccionario y si no existe la añadimos si no, no.
			Debug.WriteLine("Procesamos en el " +
			"formulario principal " +
			"la palabra " + nword.ToJson());
			//comprobar si la base de datos está activa.
			if (db != null) {
				if (!IsExist(nword)) {
					//No existe, adicionamos al diccionario
					colectionBocablos = db.GetCollection("bocablos");
					colectionBocablos.Insert(nword);
					Debug.WriteLine("Adicionada al diccionario " +
					"la palabra " + nword.ToJson());
				}
			}
			//comprobar si la palabra ya existe en el la base de datos
			
			//si existe no la añadimos.
			
			//si no existe añadirla
			
			//fin.
		}
		#endregion
		public bool IsExist(Word nword)
		{
			
			colectionBocablos = db.GetCollection("bocablos");
			var Palabras = colectionBocablos.AsQueryable<Word>();
			var res = from c in Palabras
			          where c.Esp.ToUpper() == nword.Esp.ToUpper() && c.Ing.ToUpper() == nword.Ing.ToUpper()
			          select c;
			//pasamos los resultados a la lista
			if (res.Count() >= 1) {
				foreach (Word element in res) {
					richTextBox.Text="primer valor encontrado: " + res.First().ToJson();
					richTextBox.Text+="IsExist diccionario :" + element.ToJson();
				}
				return true;
			}
			return false;
		}
		/// <summary>
		/// hay que analizar esto con más atención puede
		/// que este dando lugar a intercruzamiento entre
		/// los registros.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnModifClick(object sender, EventArgs e)
		{
			if (rdAdd.Checked && db != null) {
				colectionBocablos = db.GetCollection("bocablos");
				var Palabras = colectionBocablos.AsQueryable<Word>();
				var res = from c in Palabras
				         where c.Ing.ToUpper() == textIng.Text.ToUpper()
				         select c;
				//pasamos los resultados a la lista
				if (res.Count() >= 1) {
					foreach (Word element in res) {
						richTextBox.Text=("primer valor encontrado: " + res.First().ToJson());
						richTextBox.Text+=("IsExist diccionario :" + element.ToJson());
					}
					Word d = res.First();
					d.Esp = textEsp.Text; //modificamos el registro
					d.Commen = richTextCom.Text;
					colectionBocablos.Save(d); //y guardamos el registro
					richTextBox.Text=("registro modificado con éxito: " + d.ToJson());
				}
				var resing = from c in Palabras
				         where c.Esp.ToUpper() == textEsp.Text.ToUpper()
				         select c;
				if (resing.Count() >= 1) {
					foreach (Word element in resing) {
						richTextBox.Text=("primer valor encontrado: " + resing.First().ToJson());
						richTextBox.Text+=("IsExist diccionario :" + element.ToJson());
					}
					Word d = resing.First();
					d.Ing = textIng.Text; //modificamos el registro
					d.Commen = richTextCom.Text;
					colectionBocablos.Save(d); //y guardamos el registro
					richTextBox.Text=("registro modificado con éxito: " + d.ToJson());
				}
				
			}
		}
		void BtnpracticaverbosClick(object sender, EventArgs e)
		{
			FormVerbos fv = new FormVerbos();
			fv.Show(this);
		}
	}
	
}
