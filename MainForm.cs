using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_8
{
	
	public partial class form : Form
	{
		string[] imagenes;
		string[] Descripcion;
		string[] nombres;
		public form()
		{
			
			InitializeComponent();
			
		}

		void FormLoad(object sender, EventArgs e)
		{

			imagenes = new string [8];
			string dir= "C:\\Users\\IPPESSI\\Downloads\\Lautaro Ruiz Diaz\\Planetas\\";
			imagenes[0]= dir + "tierra.jpg";
			imagenes[1]= dir + "urano.jpg";
			imagenes[2]= dir + "neptuno.jpg";
			imagenes[3]= dir + "jupiter.jpg";
			imagenes[4]= dir + "marte.jpg";
			imagenes[5]= dir + "mercurio.jpg";
			imagenes[6]= dir + "saturno.jpg";
			imagenes[7]= dir + "venus.jpg";
			
			Descripcion = new string[8];
			Descripcion[0]= "La Tierra es el quinto planeta del Sistema Solar en cuanto a tamaño, y el único capaz de albergar vida";
			Descripcion[1]= "Urano es el séptimo planeta del sistema solar, el tercero de mayor tamaño, y el cuarto más masivo. Se llama así en honor de la divinidad griega del cielo";
			Descripcion[2]= "Neptuno es el octavo planeta en distancia respecto al Sol y el más lejano del sistema solar. Forma parte de los denominados planetas exteriores";
			Descripcion[3]= "Júpiter es el planeta más grande de nuestro sistema solar. Es parecido a una estrella, pero nunca llegó a ser lo suficientemente masiva como para empezar a arder";
			Descripcion[4]= "Marte es el planeta interior más alejado del Sol. Es un planeta telúrico con una atmósfera delgada de dióxido de carbono, y tiene dos satélites pequeños";
			Descripcion[5]= "Mercurio es uno de los cuatro planetas rocosos o sólidos; es decir, tiene un cuerpo rocoso, como la Tierra. Este planeta es el más pequeño de los cuatro";
			Descripcion[6]= "Saturno es el sexto planeta del sistema solar contando desde el Sol, el segundo en tamaño y masa después de Júpiter y el único con un sistema de anillos .";
			Descripcion[7]= "Venus es el segundo planeta del sistema solar en orden de proximidad al Sol y el tercero en cuanto a tamaño en orden ascendente después de Mercurio y Marte.";
			
			nombres = new string[8];
			nombres[0]= "Tierra";
			nombres[1]= "Urano";
			nombres[2]= "Neptuno";
			nombres[3]= "Jupiter";
			nombres[4]= "Marte";
			nombres[5]= "Mercurio";
			nombres[6]= "Saturno";
			nombres[7]= "Venus";
			
			pic_Tierra.Image = Image.FromFile (imagenes[0]);
			pic_Urano.Image = Image.FromFile (imagenes[1]);
			pic_Neptuno.Image = Image.FromFile (imagenes[2]);
			pic_Jupiter.Image = Image.FromFile (imagenes[3]);
			pic_Marte.Image = Image.FromFile (imagenes[4]);
			pic_Mercurio.Image = Image.FromFile (imagenes[5]);
			pic_Saturno.Image = Image.FromFile (imagenes[6]);
			pic_Venus.Image = Image.FromFile (imagenes[7]);
			pic_imagencentro.Image = Image.FromFile (imagenes[0]);
			lbl_mostrardescplaneta.Text = Descripcion[0];
			lbl_mostrarnompl.Text = nombres[0];
			
		}
		void Pic_imagen1Click(object sender, EventArgs e)
		{
			PictureBox auxpic = (PictureBox)sender;
			pic_imagencentro.Image = auxpic.Image;
			int txtnom = Convert.ToInt32(auxpic.Tag);
			lbl_mostrarnompl.Text = nombres[txtnom];
			int txtdesc = Convert.ToInt32(auxpic.Tag);
			lbl_mostrardescplaneta.Text = Descripcion[txtdesc];
			
		}

	}
}
