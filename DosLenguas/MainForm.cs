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
using System.Runtime.InteropServices;
using System.Text;

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
        Word selectedworld= new Word();
		bool engToEsp = true;
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand,
            StringBuilder strReturn, int iReturnLength,
            IntPtr hwndCallback);
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
            if (!rdEsp.Checked) return;
			//if (textEsp.Text.Equals(""))
			//	textIng.Text = "";
			if (colectionBocablos == null)
				return;
            listBox.Items.Clear();
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
                    //Debug.WriteLine(element.ToJson());
                    listBox.Items.Add(element);//.ToJson());
				}
				if (engToEsp == false) {
					textIng.Text = "";
					if (res.Count() >= 1) {
						
						textIng.Text = res.First().Ing;
                        OnlyNamefile = res.First().Sound;
                        richTextCom.Text = res.First().Commen;
                        selectedworld = res.First();
                        comboBoxFuncion.SelectedIndex = (int)selectedworld.Funcion;
					}
				}
			}
		}
		void TextIngTextChanged(object sender, EventArgs e)
		{
			Debug.WriteLine(textIng.Text);
            if (!rdIng.Checked) return;
			//if (textIng.Text.Equals(""))
			//	textEsp.Text = "";
			if (colectionBocablos == null)
				return;
            listBox.Items.Clear();
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
                    //Debug.WriteLine(element.ToJson());
                    listBox.Items.Add(element);//.ToJson());
				}
				if (engToEsp) {
					textEsp.Text = "";
					if (res.Count() >= 1) {
						
						textEsp.Text = res.First().Esp;
						richTextCom.Text = res.First().Commen;
                        OnlyNamefile = res.First().Sound;
                        selectedworld = res.First();
                        comboBoxFuncion.SelectedIndex = (int)selectedworld.Funcion;
                    }
				}
				
			}
		}
        /// <summary>
        /// adicionar un registro nuevo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		void BtnInglesClick(object sender, EventArgs e)
		{
			
			if (db == null)
				return; //no esta inicializada la db mongo.
			colectionBocablos = db.GetCollection("bocablos");
			if (!String.IsNullOrEmpty(textIng.Text) && !String.IsNullOrEmpty(textEsp.Text)) {
				Word wd = new Word(textEsp.Text, textIng.Text, richTextCom.Text);
                if(!string.IsNullOrEmpty(OnlyNamefile)) wd.Sound = OnlyNamefile;
                //adicionamos el tipo de función que es el vocablo
                wd.Funcion = (Word.eFuncion)Enum.Parse(typeof(Word.eFuncion), funcion[comboBoxFuncion.SelectedIndex]);

                var writeresult =colectionBocablos.Insert(wd); //insertamos en nuevo registro
                //listBox.Items.Clear();
			}
            LimpiaRegistros();
            //listBox.Items.Add(writeresult.ToJson().ToString());
            rdIng.Checked = true;
        }
		void RdIngCheckedChanged(object sender, EventArgs e)
		{
			engToEsp = true;
			textEsp.ReadOnly = true;
			textIng.ReadOnly = false;
			btnIngles.Enabled = false;
			btnFormFile.Enabled = false;
            btnModif.Enabled = false;
            textIng.Focus();
        }
		void RdEspCheckedChanged(object sender, EventArgs e)
		{
			engToEsp = false;
			textIng.ReadOnly = true;
			textEsp.ReadOnly = false;
			btnIngles.Enabled = false;
			btnFormFile.Enabled = false;
            btnModif.Enabled = false;
            textEsp.Focus();
        }
		void RdAddCheckedChanged(object sender, EventArgs e)
		{
			textIng.ReadOnly = false;
			textEsp.ReadOnly = false;
			btnIngles.Enabled = true;
			btnFormFile.Enabled = true;
            btnModif.Enabled = true;
            textEsp.Focus();
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
                    listBox.Items.Add( "primer valor encontrado: " + res.First().ToJson());
                    listBox.Items.Add("IsExist diccionario :" + element.ToJson());
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
                {
                    selectedworld.Esp = textEsp.Text;
                    selectedworld.Ing = textIng.Text;
                    selectedworld.Commen = richTextCom.Text;
                    selectedworld.Sound = OnlyNamefile;
                    selectedworld.Funcion = (Word.eFuncion)Enum.Parse(typeof(Word.eFuncion), funcion[comboBoxFuncion.SelectedIndex]);
                }
				colectionBocablos = db.GetCollection("bocablos");
                colectionBocablos.Save(selectedworld);
                LimpiaRegistros();
                rdIng.Checked = true;
			}
		}
        /// <summary>
        /// 
        /// </summary>
        void MakeNewRegister()
        {

        }
        /// <summary>
        /// establece los valores de los registros a una posicion inicial
        /// </summary>
        private void LimpiaRegistros()
        {
            textEsp.Text = "";
            textIng.Text = "";
            richTextCom.Text = "";
            OnlyNamefile = "";
            listBox.Items.Clear();
            comboBoxFuncion.SelectedIndex = 0;
        }
		void BtnpracticaverbosClick(object sender, EventArgs e)
		{
			FormVerbos fv = new FormVerbos();
			fv.Show(this);
		}

        private void btnPractica_Click(object sender, EventArgs e)
        {
            Practice practice = new Practice();
            practice.Show(this);
        }
        
        string OnlyNamefile = string.Empty;
        private void btnAsociar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio Files (.mp3)|*.mp3|Audio Files (.wav)|*.wav";
            dialog.InitialDirectory = propiedades.Default.dirsound;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                OnlyNamefile = System.IO.Path.GetFileName(path);
            }
        }

        private void btbPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OnlyNamefile)) return;
            PlayMP3(System.IO.Path.Combine(propiedades.Default.dirsound, OnlyNamefile));
        }
        public void PlayMP3(string rutaArchivo)
        {
            string comandoMCI = string.Empty;
            comandoMCI = "close miMP3";
            mciSendString(comandoMCI, null, 0, IntPtr.Zero);
            //Abrir el dispositivo MCI
            comandoMCI = string.Format("open \"{0}\" type mpegvideo alias miMP3", rutaArchivo);
            mciSendString(comandoMCI, null, 0, IntPtr.Zero);
            //Reproducir el archivo abierto
            comandoMCI = "play miMP3";
            mciSendString(comandoMCI, null, 0, IntPtr.Zero);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.ShowDialog();
        }

        string[] funcion ={
                "Sustantivo",
                "Pronombre",
                "Adjetivo",
                "Verbo",
                "Adverbio",
                "Preposicion",
                "Conjuncion",
                "Locacion",
                "Interjeccion",
                "Oracion"
            };

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            comboBoxFuncion.Items.AddRange(funcion);
            comboBoxFuncion.SelectedIndex = 0;
        }

        private void comboBoxFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedworld.Funcion = (Word.eFuncion)Enum.Parse(typeof(Word.eFuncion), funcion[comboBoxFuncion.SelectedIndex]);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox.SelectedIndex != -1)
            {
                selectedworld = (Word)listBox.SelectedItem;
                ActualizarSelectedWord();
            }
        }
        private void ActualizarSelectedWord()
        {
            textEsp.Text = selectedworld.Esp;
            textIng.Text = selectedworld.Ing;
            richTextCom.Text = selectedworld.Commen;
            OnlyNamefile = selectedworld.Sound;
            comboBoxFuncion.SelectedIndex = (int)selectedworld.Funcion;
            btndelate.Enabled = true;
        }

        private void btndelate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea borrar el registro", 
                "Aviso", MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) 
                == DialogResult.OK)
            {
                colectionBocablos = db.GetCollection("bocablos");
                var querya = Query<Word>.EQ(r => r._id, selectedworld._id);
                colectionBocablos.Remove(querya);
                btndelate.Enabled = false;
            }
        }
    }
	
}
