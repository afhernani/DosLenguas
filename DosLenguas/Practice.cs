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
                //validacion a false
                valida = false;
            }
        }
    }
}
