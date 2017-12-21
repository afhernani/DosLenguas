using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace DosLenguas
{
	/// <summary>
	/// Description of IForm.
	/// </summary>
	public partial class FormFileAdd: Form
	{
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

        public FormFileAdd()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string filename = string.Empty;
		string name_Only;
		
		void BtnOpenFileClick(object sender, EventArgs e){
			List<string> lineas = new List<string>();
			OpenFileDialog openfile =new OpenFileDialog()
			{
				Filter = "Txt file(*.txt*)|*.txt",
				Title = @"Open file to load",
				//InitialDirectory = Environment.CurrentDirectory,
				//RestoreDirectory = true
			};
			
			if(openfile.ShowDialog()==DialogResult.OK){
				filename = openfile.FileName;
				name_Only = openfile.SafeFileName;
				if(Path.GetExtension(filename).ToUpper().Equals(".TXT"))
				{
					using(StreamReader f = new StreamReader(filename)){
						string line;
						do{
							line = f.ReadLine();
							if(line!=null){
								lineas.Add(line);
							}
						} while(line != null);
					}
					richTextBox.Clear();
					richTextBox.Lines = lineas.ToArray();
					lin = 0;
				}
			}
		}
		int lin = 0;
		void BtnNextClick(object sender, EventArgs e){
			if(richTextBox.Lines.Length>0){
				string cadena = richTextBox.Lines[lin];
				int pos =richTextBox.Find(cadena);
				if(pos != -1){	
					richTextBox.SelectionStart =pos;
					richTextBox.SelectionLength = cadena.Length;
					richTextBox.SelectionBackColor = System.Drawing.Color.Yellow;
				}
				
				ProcesarCadena(cadena);
				
				lin++;
			}
			if(lin==richTextBox.Lines.Length){
				lin = 0;
			}
			
		}
		void ProcesarCadena(string cadena){
			
			if(!String.IsNullOrEmpty(cadena)){
                //string esp, ing, comt;
                obtenida = null;
				string[] fillout = cadena.Split('|');
                fillout = fillout.Where(x => !String.IsNullOrEmpty(x)).ToArray();
                //la estructura valor{ ingles, español, comentario, funcion, sonido}
                //eliminamos espacios en blanco o signo de puntuacion
                for (int i = 0; i < fillout.Length; i++)
                {
                    fillout[i] = fillout[i].Trim('.', ' ');
                }
                
                switch (fillout.Length)
                {
                    case 2:
                        //hacer el primero es ingles el segundo es
                        obtenida = new Word(fillout[1], fillout[0]);
                        obtenida.Commen = "";
                        obtenida.Funcion= (Word.eFuncion)Enum.Parse(typeof(Word.eFuncion), "Sustantivo");
                        obtenida.Sound = "";
                        break;
                    case 3:
                        //hacer el tercer parametro commentarios
                        obtenida = new Word(fillout[1], fillout[0], fillout[2]);
                        obtenida.Funcion = (Word.eFuncion)Enum.Parse(typeof(Word.eFuncion), "Sustantivo");
                        obtenida.Sound = "";
                        break;
                    case 4:
                        //hacer el cuarto la función que es un múmero.
                        obtenida = new Word(fillout[1], fillout[0], fillout[2]);
                        //int ValorFunc = int.Parse(fillout[3]);
                        obtenida.Funcion = (Word.eFuncion)Enum.Parse(typeof(Word.eFuncion), fillout[3]);
                        obtenida.Sound = "";
                        break;
                    case 5:
                        //hacer
                        obtenida = new Word(fillout[1], fillout[0], fillout[2]);
                        //int ValorFunc = int.Parse(fillout[3]);
                        obtenida.Funcion = (Word.eFuncion)Enum.Parse(typeof(Word.eFuncion), fillout[3]);
                        obtenida.Sound = fillout[4];
                        break;
                    default:
                        MessageBox.Show("No existe paridad en " +
                                    "el texto de cadena " + cadena);
                        break;
                }
                //            if(fillout.Length>=2){
                //	esp = fillout[1];
                //	ing = fillout[0];

                //	ing = ing.Trim('.');
                //	ing = ing.Trim(' ');

                //	esp = esp.Trim('.');
                //	esp = esp.Trim(' ');
                //	if(fillout.Length==3){
                //		comt = fillout[2];
                //		comt = comt.Trim('.');
                //		comt = comt.Trim(' ');
                //			LunchWord(esp, ing, comt);
                //	}
                //	if(fillout.Length==2)
                //		LunchWord(esp, ing);
                //}else{
                //	MessageBox.Show("No existe paridad en " +
                //	                "el texto de cadena " + cadena);
                //}
                if (obtenida != null) LunchWord();
			}
		}
        //a nivel demodulo.
        Word obtenida;
		//void LunchWord(string esp, string ing){
		//	//hacemos un castin y transformamos el formulario en una
		//	//interfaz.
		//	IForm forminterfas = this.Owner as IForm;
		//	if (forminterfas != null)
		//		forminterfas.AddWordFromFile(new Word(esp, ing));
		//}
		//void LunchWord(string esp, string ing, string comt){
		//	//hacemos un castin y transformamos el formulario en una
		//	//interfaz.
		//	IForm forminterfas = this.Owner as IForm;
		//	if (forminterfas != null)
		//		forminterfas.AddWordFromFile(new Word(esp, ing, comt));
		//}
        /// <summary>
        /// Lanzamos la palabra al editor
        /// </summary>
        void LunchWord()
        {
            //hacemos un castin y transformamos el formulario en una
            //interfaz.
            IForm forminterfas = this.Owner as IForm;
            if (forminterfas != null)
                forminterfas.AddWordFromFile(obtenida);
        }
        /// <summary>
        /// out data from db.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeListdb_Click(object sender, EventArgs e)
        {
            //Do: dar salida a los valores almacenados en la base de datos
            //en forma de fichero de texto.
            MongoClient mc;
            MongoServer mongo;
            MongoDatabase db;
            const string basedatos = "dic";
            const string tabla = "bocablos";
            MongoCollection colectionBocablos;

            mc = new MongoClient("mongodb://localhost");
            mongo = mc.GetServer();
            db = mongo.GetDatabase(basedatos);
            colectionBocablos = db.GetCollection(tabla);

            var Palabras = colectionBocablos.AsQueryable<Word>();

            foreach (Word element in Palabras)
            {
                string dato = string.Format("{1} | {0} | {2} | {3} | {4} \n", element.Ing,
                    element.Esp, element.Commen, funcion[(int)element.Funcion], element.Sound);
                richTextBox.AppendText(element.ToJson() + "\n" );
            }
        }
    }
}