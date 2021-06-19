
namespace Cliente_Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultadosR = new System.Windows.Forms.RadioButton();
            this.PganadasR = new System.Windows.Forms.RadioButton();
            this.MostrarJR = new System.Windows.Forms.RadioButton();
            this.nombreG = new System.Windows.Forms.TextBox();
            this.ConectarB = new System.Windows.Forms.Button();
            this.DesconectarB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IniciarSB = new System.Windows.Forms.Button();
            this.RegistrarB = new System.Windows.Forms.Button();
            this.EnviarB = new System.Windows.Forms.Button();
            this.cont = new System.Windows.Forms.Label();
            this.service = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TablaConectados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.amarillolbl = new System.Windows.Forms.Label();
            this.azullbl = new System.Windows.Forms.Label();
            this.rojolbl = new System.Windows.Forms.Label();
            this.tablero = new System.Windows.Forms.Panel();
            this.verdelbl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaConectados)).BeginInit();
            this.tablero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultadosR
            // 
            this.ResultadosR.AutoSize = true;
            this.ResultadosR.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ResultadosR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadosR.Location = new System.Drawing.Point(61, 234);
            this.ResultadosR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultadosR.Name = "ResultadosR";
            this.ResultadosR.Size = new System.Drawing.Size(203, 22);
            this.ResultadosR.TabIndex = 0;
            this.ResultadosR.TabStop = true;
            this.ResultadosR.Text = "Resultados de las partidas";
            this.ResultadosR.UseVisualStyleBackColor = false;
            // 
            // PganadasR
            // 
            this.PganadasR.AutoSize = true;
            this.PganadasR.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PganadasR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PganadasR.Location = new System.Drawing.Point(61, 263);
            this.PganadasR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PganadasR.Name = "PganadasR";
            this.PganadasR.Size = new System.Drawing.Size(173, 22);
            this.PganadasR.TabIndex = 1;
            this.PganadasR.TabStop = true;
            this.PganadasR.Text = "Partidas ganadas por:";
            this.PganadasR.UseVisualStyleBackColor = false;
            // 
            // MostrarJR
            // 
            this.MostrarJR.AutoSize = true;
            this.MostrarJR.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MostrarJR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarJR.Location = new System.Drawing.Point(61, 292);
            this.MostrarJR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MostrarJR.Name = "MostrarJR";
            this.MostrarJR.Size = new System.Drawing.Size(216, 22);
            this.MostrarJR.TabIndex = 3;
            this.MostrarJR.TabStop = true;
            this.MostrarJR.Text = "Mostrar todos los jugadores";
            this.MostrarJR.UseVisualStyleBackColor = false;
            // 
            // nombreG
            // 
            this.nombreG.Location = new System.Drawing.Point(260, 262);
            this.nombreG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreG.Name = "nombreG";
            this.nombreG.Size = new System.Drawing.Size(112, 22);
            this.nombreG.TabIndex = 4;
            // 
            // ConectarB
            // 
            this.ConectarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConectarB.Location = new System.Drawing.Point(51, 331);
            this.ConectarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConectarB.Name = "ConectarB";
            this.ConectarB.Size = new System.Drawing.Size(105, 32);
            this.ConectarB.TabIndex = 5;
            this.ConectarB.Text = "Conectar";
            this.ConectarB.UseVisualStyleBackColor = true;
            this.ConectarB.Click += new System.EventHandler(this.ConectarB_Click);
            // 
            // DesconectarB
            // 
            this.DesconectarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesconectarB.Location = new System.Drawing.Point(161, 331);
            this.DesconectarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DesconectarB.Name = "DesconectarB";
            this.DesconectarB.Size = new System.Drawing.Size(129, 32);
            this.DesconectarB.TabIndex = 6;
            this.DesconectarB.Text = "Desconectar";
            this.DesconectarB.UseVisualStyleBackColor = true;
            this.DesconectarB.Click += new System.EventHandler(this.DesconectarB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menú";
            // 
            // IniciarSB
            // 
            this.IniciarSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSB.Location = new System.Drawing.Point(232, 114);
            this.IniciarSB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IniciarSB.Name = "IniciarSB";
            this.IniciarSB.Size = new System.Drawing.Size(176, 37);
            this.IniciarSB.TabIndex = 8;
            this.IniciarSB.Text = "Iniciar sesión";
            this.IniciarSB.UseVisualStyleBackColor = true;
            this.IniciarSB.Click += new System.EventHandler(this.IniciarSB_Click);
            // 
            // RegistrarB
            // 
            this.RegistrarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarB.Location = new System.Drawing.Point(51, 114);
            this.RegistrarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrarB.Name = "RegistrarB";
            this.RegistrarB.Size = new System.Drawing.Size(176, 37);
            this.RegistrarB.TabIndex = 9;
            this.RegistrarB.Text = "Registrarse";
            this.RegistrarB.UseVisualStyleBackColor = true;
            this.RegistrarB.Click += new System.EventHandler(this.RegistrarB_Click);
            // 
            // EnviarB
            // 
            this.EnviarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnviarB.Location = new System.Drawing.Point(296, 331);
            this.EnviarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnviarB.Name = "EnviarB";
            this.EnviarB.Size = new System.Drawing.Size(141, 32);
            this.EnviarB.TabIndex = 10;
            this.EnviarB.Text = "Enviar petición";
            this.EnviarB.UseVisualStyleBackColor = true;
            this.EnviarB.Click += new System.EventHandler(this.EnviarB_Click);
            // 
            // cont
            // 
            this.cont.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont.Location = new System.Drawing.Point(51, 366);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(387, 44);
            this.cont.TabIndex = 12;
            // 
            // service
            // 
            this.service.AutoSize = true;
            this.service.Location = new System.Drawing.Point(773, 121);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(0, 17);
            this.service.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 913);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "&Roll!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TablaConectados
            // 
            this.TablaConectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaConectados.Location = new System.Drawing.Point(51, 463);
            this.TablaConectados.Margin = new System.Windows.Forms.Padding(4);
            this.TablaConectados.Name = "TablaConectados";
            this.TablaConectados.RowHeadersWidth = 51;
            this.TablaConectados.Size = new System.Drawing.Size(392, 210);
            this.TablaConectados.TabIndex = 44;
            this.TablaConectados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaConectados_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(467, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "USUARIOS CONECTADOS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(413, 116);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(176, 36);
            this.Eliminar.TabIndex = 46;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(627, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "label4";
            // 
            // amarillolbl
            // 
            this.amarillolbl.BackColor = System.Drawing.Color.Yellow;
            this.amarillolbl.ForeColor = System.Drawing.Color.Yellow;
            this.amarillolbl.Location = new System.Drawing.Point(744, 615);
            this.amarillolbl.Name = "amarillolbl";
            this.amarillolbl.Size = new System.Drawing.Size(19, 21);
            this.amarillolbl.TabIndex = 48;
            // 
            // azullbl
            // 
            this.azullbl.BackColor = System.Drawing.Color.SteelBlue;
            this.azullbl.Location = new System.Drawing.Point(149, 619);
            this.azullbl.Name = "azullbl";
            this.azullbl.Size = new System.Drawing.Size(21, 17);
            this.azullbl.TabIndex = 49;
            // 
            // rojolbl
            // 
            this.rojolbl.BackColor = System.Drawing.Color.Red;
            this.rojolbl.Location = new System.Drawing.Point(149, 119);
            this.rojolbl.Name = "rojolbl";
            this.rojolbl.Size = new System.Drawing.Size(19, 18);
            this.rojolbl.TabIndex = 50;
            // 
            // tablero
            // 
            this.tablero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tablero.BackgroundImage = global::Cliente_Proyecto.Properties.Resources.tablero1;
            this.tablero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tablero.Controls.Add(this.verdelbl);
            this.tablero.Controls.Add(this.amarillolbl);
            this.tablero.Controls.Add(this.azullbl);
            this.tablero.Controls.Add(this.rojolbl);
            this.tablero.Location = new System.Drawing.Point(696, 171);
            this.tablero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablero.Name = "tablero";
            this.tablero.Size = new System.Drawing.Size(913, 766);
            this.tablero.TabIndex = 51;
            this.tablero.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tablero_MouseMove);
            // 
            // verdelbl
            // 
            this.verdelbl.BackColor = System.Drawing.Color.DarkGreen;
            this.verdelbl.Location = new System.Drawing.Point(744, 121);
            this.verdelbl.Name = "verdelbl";
            this.verdelbl.Size = new System.Drawing.Size(20, 17);
            this.verdelbl.TabIndex = 51;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(108, 694);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(277, 201);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Cliente_Proyecto.Properties.Resources._6;
            this.pictureBox5.Location = new System.Drawing.Point(1141, -30);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Cliente_Proyecto.Properties.Resources._5;
            this.pictureBox6.Location = new System.Drawing.Point(1048, -30);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(89, 76);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Cliente_Proyecto.Properties.Resources._4;
            this.pictureBox7.Location = new System.Drawing.Point(953, -30);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(89, 76);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 36;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Cliente_Proyecto.Properties.Resources._3;
            this.pictureBox8.Location = new System.Drawing.Point(859, -30);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(89, 76);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 35;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Cliente_Proyecto.Properties.Resources._2;
            this.pictureBox9.Location = new System.Drawing.Point(765, -30);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(89, 76);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 34;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Cliente_Proyecto.Properties.Resources._1;
            this.pictureBox10.Location = new System.Drawing.Point(671, -30);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(89, 76);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 33;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 972);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Turno:";
            this.label2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 972);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 1045);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TablaConectados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.service);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.EnviarB);
            this.Controls.Add(this.RegistrarB);
            this.Controls.Add(this.IniciarSB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DesconectarB);
            this.Controls.Add(this.ConectarB);
            this.Controls.Add(this.nombreG);
            this.Controls.Add(this.MostrarJR);
            this.Controls.Add(this.PganadasR);
            this.Controls.Add(this.ResultadosR);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "¡Bienvenido a Parchís Online 2.0!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaConectados)).EndInit();
            this.tablero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ResultadosR;
        private System.Windows.Forms.RadioButton PganadasR;
        private System.Windows.Forms.RadioButton MostrarJR;
        private System.Windows.Forms.TextBox nombreG;
        private System.Windows.Forms.Button ConectarB;
        private System.Windows.Forms.Button DesconectarB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IniciarSB;
        private System.Windows.Forms.Button RegistrarB;
        private System.Windows.Forms.Button EnviarB;
        private System.Windows.Forms.Label cont;
        private System.Windows.Forms.Label service;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.DataGridView TablaConectados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label azullbl;
        private System.Windows.Forms.Label amarillolbl;
        private System.Windows.Forms.Label rojolbl;
        private System.Windows.Forms.Panel tablero;
        private System.Windows.Forms.Label verdelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

