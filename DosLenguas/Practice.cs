using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace DosLenguas
{
    public partial class Practice : Form
    {
        Random valor;
        MongoClient mc;
        static MongoServer mongo;
        MongoDatabase db;
        const string basedatos = "dic";
        const string tabla = "bocablos";
        MongoCollection colectionBocablos;

        public Practice()
        {
            InitializeComponent();
        }
        int p = 0;
        private void Practice_Load(object sender, EventArgs e)
        {
            valor = new Random();
            //total = verbosIregulares.Length;
            //p = valor.Next(1, total);
            //lbvocablo.Text = verbosIregulares[p];
            mc = new MongoClient("mongodb://localhost");
            mongo = mc.GetServer();
            db = mongo.GetDatabase(basedatos);
            colectionBocablos = db.GetCollection(tabla);
            //Todo: averiguar cuantos elementos hay en la base de datos
            // o seleccinar un elemento aleatorio en la base de datos ¿?
            findword = AleatoryWorld();
            richTextBoxExtrae.Text = findword.Ing;
            //var randomDoc = db.collection.find({ DomainClass: "aClass"}).skip(random).limit(1);
            //var res = from c in Palabras
            //          where c..Esp.ToUpper() == verbosIregulares[p].ToUpper()
            ////          select c;
            //pasamos los resultados a la lista
        }
        Word findword = new Word();
        public Word AleatoryWorld()
        {
            var Palabras = colectionBocablos.AsQueryable<Word>();
            var count = Palabras.Count<Word>();
            p = valor.Next(1, count);
            Word[] d = new Word[count];
            int i = 0;
            foreach (var item in Palabras)
            {
                d[i] = item;
                i++;
            }
            Word r = d[p];
            return r;
        }

        //valida la respuesta.
        bool valida = false;
        private void btnAction_Click(object sender, EventArgs e)
        {
            //Todo: valida la respuesta y pasa a la siguiente pregunta
            //si ha sido evaludad.
            if (!valida)
            {
                //Operaciones de validacion y errores de la respuesta.
                //codigo....
                if (string.IsNullOrEmpty(textBoxRes.Text)) return;
                richTextBoxExtrae.AppendText( "\n" + findword.Esp +"\n" +findword.Commen);
                //ultima linea fin validacion
                valida = true;
            }
            else
            {
                // siguiente pregunata.
                //borra ambos richtext
                //busca un nuevo registro aleatorio en la base de datos
                //y lo presenta para ser evaluado.
                //codigo ...
                findword = AleatoryWorld();
                richTextBoxExtrae.Text = findword.Ing;
                textBoxRes.Text = "";
                //validacion a false
                valida = false;
            }
        }

        private void Practice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //todo: aqui vamos a establecer el escape de busqueda.
                e.SuppressKeyPress = true;
                btnAction_Click(this, new EventArgs());
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                this.Close();
            }
        }

        private void textBoxRes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //todo: aqui vamos a establecer el escape de busqueda.
                e.SuppressKeyPress = true;
                btnAction_Click(this, new EventArgs());
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                this.Close();
            }
        }
    }
}
