/*
 * Created by SharpDevelop.
 * User: LAB-02
 * Date: 4/10/2021
 * Time: 20:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio_8
{
	partial class form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_Tierra;
		private System.Windows.Forms.PictureBox pic_Tierra;
		private System.Windows.Forms.PictureBox pic_Urano;
		private System.Windows.Forms.Label lbl_Urano;
		private System.Windows.Forms.Label lbl_Neptuno;
		private System.Windows.Forms.PictureBox pic_Neptuno;
		private System.Windows.Forms.Label lbl_Jupiter;
		private System.Windows.Forms.PictureBox pic_Jupiter;
		private System.Windows.Forms.PictureBox pic_Mercurio;
		private System.Windows.Forms.PictureBox pic_Saturno;
		private System.Windows.Forms.PictureBox pic_Venus;
		private System.Windows.Forms.PictureBox pic_imagencentro;
		private System.Windows.Forms.Label lbl_Marte;
		private System.Windows.Forms.Label lbl_Mercurio;
		private System.Windows.Forms.Label lbl_Saturno;
		private System.Windows.Forms.Label lbl_Venus;
		private System.Windows.Forms.Label lbl_mostrarnom;
		private System.Windows.Forms.Label lbl_mostrarnompl;
		private System.Windows.Forms.Label lbl_mostrardesc;
		private System.Windows.Forms.Label lbl_mostrardescplaneta;
		private System.Windows.Forms.PictureBox pic_Marte;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_Tierra = new System.Windows.Forms.Label();
			this.pic_Tierra = new System.Windows.Forms.PictureBox();
			this.pic_Urano = new System.Windows.Forms.PictureBox();
			this.lbl_Urano = new System.Windows.Forms.Label();
			this.lbl_Neptuno = new System.Windows.Forms.Label();
			this.pic_Neptuno = new System.Windows.Forms.PictureBox();
			this.lbl_Jupiter = new System.Windows.Forms.Label();
			this.pic_Jupiter = new System.Windows.Forms.PictureBox();
			this.pic_Mercurio = new System.Windows.Forms.PictureBox();
			this.pic_Saturno = new System.Windows.Forms.PictureBox();
			this.pic_Venus = new System.Windows.Forms.PictureBox();
			this.pic_imagencentro = new System.Windows.Forms.PictureBox();
			this.lbl_Marte = new System.Windows.Forms.Label();
			this.lbl_Mercurio = new System.Windows.Forms.Label();
			this.lbl_Saturno = new System.Windows.Forms.Label();
			this.lbl_Venus = new System.Windows.Forms.Label();
			this.lbl_mostrarnom = new System.Windows.Forms.Label();
			this.lbl_mostrarnompl = new System.Windows.Forms.Label();
			this.lbl_mostrardesc = new System.Windows.Forms.Label();
			this.lbl_mostrardescplaneta = new System.Windows.Forms.Label();
			this.pic_Marte = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_Tierra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Urano)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Neptuno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Jupiter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Mercurio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Saturno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Venus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagencentro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Marte)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Tierra
			// 
			this.lbl_Tierra.Location = new System.Drawing.Point(12, 9);
			this.lbl_Tierra.Name = "lbl_Tierra";
			this.lbl_Tierra.Size = new System.Drawing.Size(100, 23);
			this.lbl_Tierra.TabIndex = 0;
			this.lbl_Tierra.Text = "Tierra";
			// 
			// pic_Tierra
			// 
			this.pic_Tierra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pic_Tierra.Location = new System.Drawing.Point(12, 35);
			this.pic_Tierra.Name = "pic_Tierra";
			this.pic_Tierra.Size = new System.Drawing.Size(100, 50);
			this.pic_Tierra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Tierra.TabIndex = 1;
			this.pic_Tierra.TabStop = false;
			this.pic_Tierra.Tag = "0";
			this.pic_Tierra.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// pic_Urano
			// 
			this.pic_Urano.Location = new System.Drawing.Point(12, 114);
			this.pic_Urano.Name = "pic_Urano";
			this.pic_Urano.Size = new System.Drawing.Size(100, 50);
			this.pic_Urano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Urano.TabIndex = 2;
			this.pic_Urano.TabStop = false;
			this.pic_Urano.Tag = "1";
			this.pic_Urano.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// lbl_Urano
			// 
			this.lbl_Urano.Location = new System.Drawing.Point(12, 88);
			this.lbl_Urano.Name = "lbl_Urano";
			this.lbl_Urano.Size = new System.Drawing.Size(100, 23);
			this.lbl_Urano.TabIndex = 3;
			this.lbl_Urano.Text = "Urano";
			// 
			// lbl_Neptuno
			// 
			this.lbl_Neptuno.Location = new System.Drawing.Point(12, 167);
			this.lbl_Neptuno.Name = "lbl_Neptuno";
			this.lbl_Neptuno.Size = new System.Drawing.Size(100, 23);
			this.lbl_Neptuno.TabIndex = 4;
			this.lbl_Neptuno.Text = "Neptuno";
			// 
			// pic_Neptuno
			// 
			this.pic_Neptuno.Location = new System.Drawing.Point(12, 193);
			this.pic_Neptuno.Name = "pic_Neptuno";
			this.pic_Neptuno.Size = new System.Drawing.Size(100, 50);
			this.pic_Neptuno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Neptuno.TabIndex = 5;
			this.pic_Neptuno.TabStop = false;
			this.pic_Neptuno.Tag = "2";
			this.pic_Neptuno.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// lbl_Jupiter
			// 
			this.lbl_Jupiter.Location = new System.Drawing.Point(12, 246);
			this.lbl_Jupiter.Name = "lbl_Jupiter";
			this.lbl_Jupiter.Size = new System.Drawing.Size(100, 23);
			this.lbl_Jupiter.TabIndex = 6;
			this.lbl_Jupiter.Text = "Jupiter";
			// 
			// pic_Jupiter
			// 
			this.pic_Jupiter.Location = new System.Drawing.Point(12, 264);
			this.pic_Jupiter.Name = "pic_Jupiter";
			this.pic_Jupiter.Size = new System.Drawing.Size(100, 50);
			this.pic_Jupiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Jupiter.TabIndex = 7;
			this.pic_Jupiter.TabStop = false;
			this.pic_Jupiter.Tag = "3";
			this.pic_Jupiter.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// pic_Mercurio
			// 
			this.pic_Mercurio.Location = new System.Drawing.Point(794, 114);
			this.pic_Mercurio.Name = "pic_Mercurio";
			this.pic_Mercurio.Size = new System.Drawing.Size(100, 50);
			this.pic_Mercurio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Mercurio.TabIndex = 9;
			this.pic_Mercurio.TabStop = false;
			this.pic_Mercurio.Tag = "5";
			this.pic_Mercurio.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// pic_Saturno
			// 
			this.pic_Saturno.Location = new System.Drawing.Point(794, 193);
			this.pic_Saturno.Name = "pic_Saturno";
			this.pic_Saturno.Size = new System.Drawing.Size(100, 50);
			this.pic_Saturno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Saturno.TabIndex = 10;
			this.pic_Saturno.TabStop = false;
			this.pic_Saturno.Tag = "6";
			this.pic_Saturno.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// pic_Venus
			// 
			this.pic_Venus.Location = new System.Drawing.Point(794, 264);
			this.pic_Venus.Name = "pic_Venus";
			this.pic_Venus.Size = new System.Drawing.Size(100, 50);
			this.pic_Venus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Venus.TabIndex = 11;
			this.pic_Venus.TabStop = false;
			this.pic_Venus.Tag = "7";
			this.pic_Venus.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// pic_imagencentro
			// 
			this.pic_imagencentro.Location = new System.Drawing.Point(119, 35);
			this.pic_imagencentro.Name = "pic_imagencentro";
			this.pic_imagencentro.Size = new System.Drawing.Size(670, 279);
			this.pic_imagencentro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_imagencentro.TabIndex = 12;
			this.pic_imagencentro.TabStop = false;
			this.pic_imagencentro.Tag = "8";
			this.pic_imagencentro.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// lbl_Marte
			// 
			this.lbl_Marte.Location = new System.Drawing.Point(794, 9);
			this.lbl_Marte.Name = "lbl_Marte";
			this.lbl_Marte.Size = new System.Drawing.Size(100, 23);
			this.lbl_Marte.TabIndex = 13;
			this.lbl_Marte.Text = "Marte";
			// 
			// lbl_Mercurio
			// 
			this.lbl_Mercurio.Location = new System.Drawing.Point(794, 88);
			this.lbl_Mercurio.Name = "lbl_Mercurio";
			this.lbl_Mercurio.Size = new System.Drawing.Size(100, 23);
			this.lbl_Mercurio.TabIndex = 14;
			this.lbl_Mercurio.Text = "Mercurio";
			// 
			// lbl_Saturno
			// 
			this.lbl_Saturno.Location = new System.Drawing.Point(794, 167);
			this.lbl_Saturno.Name = "lbl_Saturno";
			this.lbl_Saturno.Size = new System.Drawing.Size(100, 23);
			this.lbl_Saturno.TabIndex = 15;
			this.lbl_Saturno.Text = "Saturno";
			// 
			// lbl_Venus
			// 
			this.lbl_Venus.Location = new System.Drawing.Point(794, 246);
			this.lbl_Venus.Name = "lbl_Venus";
			this.lbl_Venus.Size = new System.Drawing.Size(100, 23);
			this.lbl_Venus.TabIndex = 16;
			this.lbl_Venus.Text = "Venus";
			// 
			// lbl_mostrarnom
			// 
			this.lbl_mostrarnom.Location = new System.Drawing.Point(119, 9);
			this.lbl_mostrarnom.Name = "lbl_mostrarnom";
			this.lbl_mostrarnom.Size = new System.Drawing.Size(100, 23);
			this.lbl_mostrarnom.TabIndex = 17;
			this.lbl_mostrarnom.Text = "Nombre:";
			// 
			// lbl_mostrarnompl
			// 
			this.lbl_mostrarnompl.Location = new System.Drawing.Point(225, 9);
			this.lbl_mostrarnompl.Name = "lbl_mostrarnompl";
			this.lbl_mostrarnompl.Size = new System.Drawing.Size(564, 23);
			this.lbl_mostrarnompl.TabIndex = 18;
			// 
			// lbl_mostrardesc
			// 
			this.lbl_mostrardesc.Location = new System.Drawing.Point(119, 321);
			this.lbl_mostrardesc.Name = "lbl_mostrardesc";
			this.lbl_mostrardesc.Size = new System.Drawing.Size(100, 23);
			this.lbl_mostrardesc.TabIndex = 19;
			this.lbl_mostrardesc.Text = "Descripcion:";
			// 
			// lbl_mostrardescplaneta
			// 
			this.lbl_mostrardescplaneta.Location = new System.Drawing.Point(239, 321);
			this.lbl_mostrardescplaneta.Name = "lbl_mostrardescplaneta";
			this.lbl_mostrardescplaneta.Size = new System.Drawing.Size(550, 173);
			this.lbl_mostrardescplaneta.TabIndex = 20;
			// 
			// pic_Marte
			// 
			this.pic_Marte.Location = new System.Drawing.Point(794, 35);
			this.pic_Marte.Name = "pic_Marte";
			this.pic_Marte.Size = new System.Drawing.Size(100, 50);
			this.pic_Marte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Marte.TabIndex = 21;
			this.pic_Marte.TabStop = false;
			this.pic_Marte.Tag = "4";
			this.pic_Marte.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1196, 564);
			this.Controls.Add(this.pic_Marte);
			this.Controls.Add(this.lbl_mostrardescplaneta);
			this.Controls.Add(this.lbl_mostrardesc);
			this.Controls.Add(this.lbl_mostrarnompl);
			this.Controls.Add(this.lbl_mostrarnom);
			this.Controls.Add(this.lbl_Venus);
			this.Controls.Add(this.lbl_Saturno);
			this.Controls.Add(this.lbl_Mercurio);
			this.Controls.Add(this.lbl_Marte);
			this.Controls.Add(this.pic_imagencentro);
			this.Controls.Add(this.pic_Venus);
			this.Controls.Add(this.pic_Saturno);
			this.Controls.Add(this.pic_Mercurio);
			this.Controls.Add(this.pic_Jupiter);
			this.Controls.Add(this.lbl_Jupiter);
			this.Controls.Add(this.pic_Neptuno);
			this.Controls.Add(this.lbl_Neptuno);
			this.Controls.Add(this.lbl_Urano);
			this.Controls.Add(this.pic_Urano);
			this.Controls.Add(this.pic_Tierra);
			this.Controls.Add(this.lbl_Tierra);
			this.Name = "form";
			this.Text = "Ejercicio 8";
			this.Load += new System.EventHandler(this.FormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic_Tierra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Urano)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Neptuno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Jupiter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Mercurio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Saturno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Venus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagencentro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Marte)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
