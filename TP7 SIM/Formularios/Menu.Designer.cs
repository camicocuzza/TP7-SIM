namespace TP7_SIM.Formularios
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMinSim = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMediaCons = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMediaEnf = new System.Windows.Forms.TextBox();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndTiempoLlegadaCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoLlegadaCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxLlegadaCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndTiempoLlegadaEnf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoLlegadaEnf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxLlegadaEnf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndTipoEnf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndTiempoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finConsultaM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finConsultaM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndCalmante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calmante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoEnfermeria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoMedico1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoMedico2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoEnfermero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaEnfermero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acTiempoOcupacionEnf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadTotalPacientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCalmantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acTiempoPermanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.tbxDesde = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxHastaCM = new System.Windows.Forms.TextBox();
            this.tbxDesdeCM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDemoraCuracion = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDemoraVacuna = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblOE = new System.Windows.Forms.Label();
            this.lblPP = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblPA = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxDemoraCalmante = new System.Windows.Forms.TextBox();
            this.lblPromedioOcupacion = new System.Windows.Forms.Label();
            this.lblPromedioPermanencia = new System.Windows.Forms.Label();
            this.lblCantidadCalmantes = new System.Windows.Forms.Label();
            this.lblPacientesAtendidos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMinSim
            // 
            this.lblMinSim.AutoSize = true;
            this.lblMinSim.Location = new System.Drawing.Point(12, 27);
            this.lblMinSim.Name = "lblMinSim";
            this.lblMinSim.Size = new System.Drawing.Size(51, 26);
            this.lblMinSim.TabIndex = 0;
            this.lblMinSim.Text = "Minutos \r\na simular:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(15, 71);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxMediaCons);
            this.groupBox1.Location = new System.Drawing.Point(120, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llegada pacientes a consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Media";
            // 
            // tbxMediaCons
            // 
            this.tbxMediaCons.Location = new System.Drawing.Point(58, 37);
            this.tbxMediaCons.MaxLength = 4;
            this.tbxMediaCons.Name = "tbxMediaCons";
            this.tbxMediaCons.Size = new System.Drawing.Size(31, 20);
            this.tbxMediaCons.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxMediaEnf);
            this.groupBox2.Location = new System.Drawing.Point(235, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 72);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Llegada pacientes a enfermería";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Media";
            // 
            // tbxMediaEnf
            // 
            this.tbxMediaEnf.Location = new System.Drawing.Point(54, 37);
            this.tbxMediaEnf.MaxLength = 4;
            this.tbxMediaEnf.Name = "tbxMediaEnf";
            this.tbxMediaEnf.Size = new System.Drawing.Size(32, 20);
            this.tbxMediaEnf.TabIndex = 1;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_datos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evento,
            this.reloj,
            this.rndTiempoLlegadaCons,
            this.tiempoLlegadaCons,
            this.proxLlegadaCons,
            this.rndTiempoLlegadaEnf,
            this.tiempoLlegadaEnf,
            this.ProxLlegadaEnf,
            this.rndTipoEnf,
            this.tipoAtencion,
            this.rndTiempoConsulta,
            this.tiempoConsulta,
            this.finConsultaM1,
            this.finConsultaM2,
            this.rndCalmante,
            this.calmante,
            this.tiempoEnfermeria,
            this.estadoMedico1,
            this.estadoMedico2,
            this.colaConsulta,
            this.estadoEnfermero,
            this.colaEnfermero,
            this.acTiempoOcupacionEnf,
            this.cantidadTotalPacientes,
            this.cantidadCalmantes,
            this.acTiempoPermanencia});
            this.dgv_datos.Location = new System.Drawing.Point(11, 127);
            this.dgv_datos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.RowHeadersWidth = 51;
            this.dgv_datos.RowTemplate.Height = 24;
            this.dgv_datos.Size = new System.Drawing.Size(1252, 402);
            this.dgv_datos.TabIndex = 20;
            // 
            // evento
            // 
            this.evento.FillWeight = 211.7013F;
            this.evento.HeaderText = "Evento";
            this.evento.MinimumWidth = 6;
            this.evento.Name = "evento";
            this.evento.Width = 66;
            // 
            // reloj
            // 
            this.reloj.FillWeight = 192.9475F;
            this.reloj.HeaderText = "Reloj (min)";
            this.reloj.MinimumWidth = 6;
            this.reloj.Name = "reloj";
            this.reloj.Width = 81;
            // 
            // rndTiempoLlegadaCons
            // 
            this.rndTiempoLlegadaCons.FillWeight = 175.9983F;
            this.rndTiempoLlegadaCons.HeaderText = "RND";
            this.rndTiempoLlegadaCons.MinimumWidth = 6;
            this.rndTiempoLlegadaCons.Name = "rndTiempoLlegadaCons";
            this.rndTiempoLlegadaCons.Width = 56;
            // 
            // tiempoLlegadaCons
            // 
            this.tiempoLlegadaCons.FillWeight = 160.6802F;
            this.tiempoLlegadaCons.HeaderText = "T. entre llegadas cons.";
            this.tiempoLlegadaCons.MinimumWidth = 6;
            this.tiempoLlegadaCons.Name = "tiempoLlegadaCons";
            this.tiempoLlegadaCons.Width = 140;
            // 
            // proxLlegadaCons
            // 
            this.proxLlegadaCons.FillWeight = 176.2034F;
            this.proxLlegadaCons.HeaderText = "Próx. llegada cons.";
            this.proxLlegadaCons.MinimumWidth = 8;
            this.proxLlegadaCons.Name = "proxLlegadaCons";
            this.proxLlegadaCons.Width = 122;
            // 
            // rndTiempoLlegadaEnf
            // 
            this.rndTiempoLlegadaEnf.FillWeight = 157.7981F;
            this.rndTiempoLlegadaEnf.HeaderText = "RND";
            this.rndTiempoLlegadaEnf.MinimumWidth = 8;
            this.rndTiempoLlegadaEnf.Name = "rndTiempoLlegadaEnf";
            this.rndTiempoLlegadaEnf.Width = 56;
            // 
            // tiempoLlegadaEnf
            // 
            this.tiempoLlegadaEnf.FillWeight = 141.5182F;
            this.tiempoLlegadaEnf.HeaderText = "T. entre llegadas enf.";
            this.tiempoLlegadaEnf.MinimumWidth = 8;
            this.tiempoLlegadaEnf.Name = "tiempoLlegadaEnf";
            this.tiempoLlegadaEnf.Width = 132;
            // 
            // ProxLlegadaEnf
            // 
            this.ProxLlegadaEnf.HeaderText = "Próx. llegada enf.";
            this.ProxLlegadaEnf.Name = "ProxLlegadaEnf";
            this.ProxLlegadaEnf.Width = 114;
            // 
            // rndTipoEnf
            // 
            this.rndTipoEnf.FillWeight = 105.9319F;
            this.rndTipoEnf.HeaderText = "RND";
            this.rndTipoEnf.MinimumWidth = 6;
            this.rndTipoEnf.Name = "rndTipoEnf";
            this.rndTipoEnf.Width = 56;
            // 
            // tipoAtencion
            // 
            this.tipoAtencion.FillWeight = 97.35632F;
            this.tipoAtencion.HeaderText = "Atención";
            this.tipoAtencion.MinimumWidth = 6;
            this.tipoAtencion.Name = "tipoAtencion";
            this.tipoAtencion.Width = 74;
            // 
            // rndTiempoConsulta
            // 
            this.rndTiempoConsulta.HeaderText = "RND";
            this.rndTiempoConsulta.Name = "rndTiempoConsulta";
            this.rndTiempoConsulta.Width = 56;
            // 
            // tiempoConsulta
            // 
            this.tiempoConsulta.HeaderText = "Tiempo Consulta";
            this.tiempoConsulta.Name = "tiempoConsulta";
            this.tiempoConsulta.Width = 111;
            // 
            // finConsultaM1
            // 
            this.finConsultaM1.HeaderText = "Fin consulta M1";
            this.finConsultaM1.Name = "finConsultaM1";
            this.finConsultaM1.Width = 107;
            // 
            // finConsultaM2
            // 
            this.finConsultaM2.HeaderText = "Fin consulta M2";
            this.finConsultaM2.Name = "finConsultaM2";
            this.finConsultaM2.Width = 107;
            // 
            // rndCalmante
            // 
            this.rndCalmante.HeaderText = "RND";
            this.rndCalmante.Name = "rndCalmante";
            this.rndCalmante.Width = 56;
            // 
            // calmante
            // 
            this.calmante.HeaderText = "Calmante";
            this.calmante.Name = "calmante";
            this.calmante.Width = 76;
            // 
            // tiempoEnfermeria
            // 
            this.tiempoEnfermeria.HeaderText = "Fin at. Enf.";
            this.tiempoEnfermeria.Name = "tiempoEnfermeria";
            this.tiempoEnfermeria.Width = 83;
            // 
            // estadoMedico1
            // 
            this.estadoMedico1.HeaderText = "Estado M1";
            this.estadoMedico1.Name = "estadoMedico1";
            this.estadoMedico1.Width = 83;
            // 
            // estadoMedico2
            // 
            this.estadoMedico2.HeaderText = "Estado M2";
            this.estadoMedico2.Name = "estadoMedico2";
            this.estadoMedico2.Width = 83;
            // 
            // colaConsulta
            // 
            this.colaConsulta.HeaderText = "Cola Consulta";
            this.colaConsulta.Name = "colaConsulta";
            this.colaConsulta.Width = 97;
            // 
            // estadoEnfermero
            // 
            this.estadoEnfermero.HeaderText = "Estado Enf.";
            this.estadoEnfermero.Name = "estadoEnfermero";
            this.estadoEnfermero.Width = 87;
            // 
            // colaEnfermero
            // 
            this.colaEnfermero.HeaderText = "Cola Enf.";
            this.colaEnfermero.Name = "colaEnfermero";
            this.colaEnfermero.Width = 75;
            // 
            // acTiempoOcupacionEnf
            // 
            this.acTiempoOcupacionEnf.HeaderText = "AC tiempo ocup. enf.";
            this.acTiempoOcupacionEnf.Name = "acTiempoOcupacionEnf";
            this.acTiempoOcupacionEnf.Width = 131;
            // 
            // cantidadTotalPacientes
            // 
            this.cantidadTotalPacientes.HeaderText = "AC pacientes atendidos";
            this.cantidadTotalPacientes.Name = "cantidadTotalPacientes";
            this.cantidadTotalPacientes.Width = 144;
            // 
            // cantidadCalmantes
            // 
            this.cantidadCalmantes.HeaderText = "AC calmantes";
            this.cantidadCalmantes.Name = "cantidadCalmantes";
            this.cantidadCalmantes.Width = 97;
            // 
            // acTiempoPermanencia
            // 
            this.acTiempoPermanencia.HeaderText = "AC tiempo permanencia";
            this.acTiempoPermanencia.Name = "acTiempoPermanencia";
            this.acTiempoPermanencia.Width = 144;
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(69, 33);
            this.txtIteraciones.MaxLength = 4;
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(45, 20);
            this.txtIteraciones.TabIndex = 21;
            // 
            // tbxDesde
            // 
            this.tbxDesde.Location = new System.Drawing.Point(69, 71);
            this.tbxDesde.Name = "tbxDesde";
            this.tbxDesde.Size = new System.Drawing.Size(45, 20);
            this.tbxDesde.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxHastaCM);
            this.groupBox3.Controls.Add(this.tbxDesdeCM);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(350, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 95);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Demora consulta médica";
            // 
            // tbxHastaCM
            // 
            this.tbxHastaCM.Location = new System.Drawing.Point(57, 66);
            this.tbxHastaCM.MaxLength = 4;
            this.tbxHastaCM.Name = "tbxHastaCM";
            this.tbxHastaCM.Size = new System.Drawing.Size(33, 20);
            this.tbxHastaCM.TabIndex = 7;
            // 
            // tbxDesdeCM
            // 
            this.tbxDesdeCM.Location = new System.Drawing.Point(57, 34);
            this.tbxDesdeCM.MaxLength = 4;
            this.tbxDesdeCM.Name = "tbxDesdeCM";
            this.tbxDesdeCM.Size = new System.Drawing.Size(33, 20);
            this.tbxDesdeCM.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desde";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbxDemoraCuracion);
            this.groupBox4.Location = new System.Drawing.Point(555, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(94, 72);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Demora curación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cte =";
            // 
            // tbxDemoraCuracion
            // 
            this.tbxDemoraCuracion.Location = new System.Drawing.Point(54, 37);
            this.tbxDemoraCuracion.MaxLength = 4;
            this.tbxDemoraCuracion.Name = "tbxDemoraCuracion";
            this.tbxDemoraCuracion.Size = new System.Drawing.Size(34, 20);
            this.tbxDemoraCuracion.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tbxDemoraVacuna);
            this.groupBox5.Location = new System.Drawing.Point(454, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(95, 72);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Demora vacunación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cte =";
            // 
            // tbxDemoraVacuna
            // 
            this.tbxDemoraVacuna.Location = new System.Drawing.Point(54, 37);
            this.tbxDemoraVacuna.MaxLength = 4;
            this.tbxDemoraVacuna.Name = "tbxDemoraVacuna";
            this.tbxDemoraVacuna.Size = new System.Drawing.Size(33, 20);
            this.tbxDemoraVacuna.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(755, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(94, 72);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Demora spray antidolor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cte = 1.55\'";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(878, 74);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 25);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(878, 46);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(70, 24);
            this.btnGenerar.TabIndex = 27;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblOE
            // 
            this.lblOE.AutoSize = true;
            this.lblOE.Location = new System.Drawing.Point(381, 550);
            this.lblOE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOE.Name = "lblOE";
            this.lblOE.Size = new System.Drawing.Size(191, 13);
            this.lblOE.TabIndex = 29;
            this.lblOE.Text = "Promedio tiempo ocupación enfermero:";
            // 
            // lblPP
            // 
            this.lblPP.AutoSize = true;
            this.lblPP.Location = new System.Drawing.Point(381, 580);
            this.lblPP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(201, 13);
            this.lblPP.TabIndex = 30;
            this.lblPP.Text = "Promedio tiempo permanencia pacientes:";
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(15, 580);
            this.lblCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(166, 13);
            this.lblCC.TabIndex = 32;
            this.lblCC.Text = "Cantidad de calmantes aplicados:";
            // 
            // lblPA
            // 
            this.lblPA.AutoSize = true;
            this.lblPA.Location = new System.Drawing.Point(15, 550);
            this.lblPA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPA.Name = "lblPA";
            this.lblPA.Size = new System.Drawing.Size(188, 13);
            this.lblPA.TabIndex = 33;
            this.lblPA.Text = "Cantidad total de pacientes atendidos:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.tbxDemoraCalmante);
            this.groupBox7.Location = new System.Drawing.Point(655, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(94, 72);
            this.groupBox7.TabIndex = 34;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Demora calmante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cte =";
            // 
            // tbxDemoraCalmante
            // 
            this.tbxDemoraCalmante.Location = new System.Drawing.Point(54, 37);
            this.tbxDemoraCalmante.MaxLength = 4;
            this.tbxDemoraCalmante.Name = "tbxDemoraCalmante";
            this.tbxDemoraCalmante.Size = new System.Drawing.Size(34, 20);
            this.tbxDemoraCalmante.TabIndex = 1;
            // 
            // lblPromedioOcupacion
            // 
            this.lblPromedioOcupacion.AutoSize = true;
            this.lblPromedioOcupacion.Location = new System.Drawing.Point(587, 550);
            this.lblPromedioOcupacion.Name = "lblPromedioOcupacion";
            this.lblPromedioOcupacion.Size = new System.Drawing.Size(0, 13);
            this.lblPromedioOcupacion.TabIndex = 35;
            // 
            // lblPromedioPermanencia
            // 
            this.lblPromedioPermanencia.AutoSize = true;
            this.lblPromedioPermanencia.Location = new System.Drawing.Point(587, 580);
            this.lblPromedioPermanencia.Name = "lblPromedioPermanencia";
            this.lblPromedioPermanencia.Size = new System.Drawing.Size(0, 13);
            this.lblPromedioPermanencia.TabIndex = 36;
            // 
            // lblCantidadCalmantes
            // 
            this.lblCantidadCalmantes.AutoSize = true;
            this.lblCantidadCalmantes.Location = new System.Drawing.Point(208, 580);
            this.lblCantidadCalmantes.Name = "lblCantidadCalmantes";
            this.lblCantidadCalmantes.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadCalmantes.TabIndex = 37;
            // 
            // lblPacientesAtendidos
            // 
            this.lblPacientesAtendidos.AutoSize = true;
            this.lblPacientesAtendidos.Location = new System.Drawing.Point(208, 550);
            this.lblPacientesAtendidos.Name = "lblPacientesAtendidos";
            this.lblPacientesAtendidos.Size = new System.Drawing.Size(0, 13);
            this.lblPacientesAtendidos.TabIndex = 38;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 609);
            this.Controls.Add(this.lblPacientesAtendidos);
            this.Controls.Add(this.lblCantidadCalmantes);
            this.Controls.Add(this.lblPromedioPermanencia);
            this.Controls.Add(this.lblPromedioOcupacion);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.lblPA);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.lblOE);
            this.Controls.Add(this.lblPP);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tbxDesde);
            this.Controls.Add(this.txtIteraciones);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lblMinSim);
            this.Name = "Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinSim;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMediaCons;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMediaEnf;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.TextBox tbxDesde;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDemoraCuracion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDemoraVacuna;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox tbxHastaCM;
        private System.Windows.Forms.TextBox tbxDesdeCM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOE;
        private System.Windows.Forms.Label lblPP;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndTiempoLlegadaCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoLlegadaCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxLlegadaCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndTiempoLlegadaEnf;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoLlegadaEnf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxLlegadaEnf;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndTipoEnf;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndTiempoConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn finConsultaM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finConsultaM2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndCalmante;
        private System.Windows.Forms.DataGridViewTextBoxColumn calmante;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoEnfermeria;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoMedico1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoMedico2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoEnfermero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaEnfermero;
        private System.Windows.Forms.DataGridViewTextBoxColumn acTiempoOcupacionEnf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadTotalPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCalmantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn acTiempoPermanencia;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxDemoraCalmante;
        private System.Windows.Forms.Label lblPromedioOcupacion;
        private System.Windows.Forms.Label lblPromedioPermanencia;
        private System.Windows.Forms.Label lblCantidadCalmantes;
        private System.Windows.Forms.Label lblPacientesAtendidos;
    }
}