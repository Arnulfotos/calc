namespace testWindowsForms
{
    partial class Calculadora
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
            this.Operacion = new MaterialSkin.Controls.MaterialTextBox();
            this.Boton7 = new MaterialSkin.Controls.MaterialButton();
            this.Boton8 = new MaterialSkin.Controls.MaterialButton();
            this.Suma = new MaterialSkin.Controls.MaterialButton();
            this.Boton4 = new MaterialSkin.Controls.MaterialButton();
            this.Boton5 = new MaterialSkin.Controls.MaterialButton();
            this.Resta = new MaterialSkin.Controls.MaterialButton();
            this.Boton1 = new MaterialSkin.Controls.MaterialButton();
            this.Boton2 = new MaterialSkin.Controls.MaterialButton();
            this.Multiplicacion = new MaterialSkin.Controls.MaterialButton();
            this.Boton0 = new MaterialSkin.Controls.MaterialButton();
            this.Enter = new MaterialSkin.Controls.MaterialButton();
            this.PuntoDecimal = new MaterialSkin.Controls.MaterialButton();
            this.BotonBorrado = new MaterialSkin.Controls.MaterialButton();
            this.Division = new MaterialSkin.Controls.MaterialButton();
            this.Boton9 = new MaterialSkin.Controls.MaterialButton();
            this.Boton6 = new MaterialSkin.Controls.MaterialButton();
            this.Boton3 = new MaterialSkin.Controls.MaterialButton();
            this.ContenedorBotones = new MaterialSkin.Controls.MaterialCard();
            this.Resultado = new MaterialSkin.Controls.MaterialTextBox2();
            this.ContenedorBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Operacion
            // 
            this.Operacion.AnimateReadOnly = false;
            this.Operacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Operacion.Depth = 0;
            this.Operacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Operacion.Hint = "0";
            this.Operacion.LeadingIcon = null;
            this.Operacion.Location = new System.Drawing.Point(17, 20);
            this.Operacion.MaxLength = 50;
            this.Operacion.MouseState = MaterialSkin.MouseState.OUT;
            this.Operacion.Multiline = false;
            this.Operacion.Name = "Operacion";
            this.Operacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Operacion.Size = new System.Drawing.Size(209, 36);
            this.Operacion.TabIndex = 0;
            this.Operacion.Text = "";
            this.Operacion.TrailingIcon = null;
            this.Operacion.UseTallSize = false;
            // 
            // Boton7
            // 
            this.Boton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Boton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Boton7.Depth = 0;
            this.Boton7.HighEmphasis = true;
            this.Boton7.Icon = null;
            this.Boton7.Location = new System.Drawing.Point(18, 68);
            this.Boton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Boton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.Boton7.Name = "Boton7";
            this.Boton7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Boton7.Size = new System.Drawing.Size(64, 36);
            this.Boton7.TabIndex = 0;
            this.Boton7.Text = "7";
            this.Boton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Boton7.UseAccentColor = false;
            this.Boton7.UseVisualStyleBackColor = true;
            this.Boton7.Click += new System.EventHandler(this.Button_Click);
            // 
            // Boton8
            // 
            this.Boton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Boton8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Boton8.Depth = 0;
            this.Boton8.HighEmphasis = true;
            this.Boton8.Icon = null;
            this.Boton8.Location = new System.Drawing.Point(90, 68);
            this.Boton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Boton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.Boton8.Name = "Boton8";
            this.Boton8.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Boton8.Size = new System.Drawing.Size(64, 36);
            this.Boton8.TabIndex = 1;
            this.Boton8.Text = "8";
            this.Boton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Boton8.UseAccentColor = false;
            this.Boton8.UseVisualStyleBackColor = true;
            this.Boton8.Click += new System.EventHandler(this.Button_Click);
            // 
            // Suma
            // 
            this.Suma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Suma.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Suma.Depth = 0;
            this.Suma.HighEmphasis = true;
            this.Suma.Icon = null;
            this.Suma.Location = new System.Drawing.Point(275, 68);
            this.Suma.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Suma.MouseState = MaterialSkin.MouseState.HOVER;
            this.Suma.Name = "Suma";
            this.Suma.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Suma.Size = new System.Drawing.Size(64, 36);
            this.Suma.TabIndex = 1;
            this.Suma.Text = "+";
            this.Suma.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Suma.UseAccentColor = false;
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.OperationCalc);
            // 
            // Boton4
            // 
            this.Boton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Boton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Boton4.Depth = 0;
            this.Boton4.HighEmphasis = true;
            this.Boton4.Icon = null;
            this.Boton4.Location = new System.Drawing.Point(18, 116);
            this.Boton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Boton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.Boton4.Name = "Boton4";
            this.Boton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Boton4.Size = new System.Drawing.Size(64, 36);
            this.Boton4.TabIndex = 0;
            this.Boton4.Text = "4";
            this.Boton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Boton4.UseAccentColor = false;
            this.Boton4.UseVisualStyleBackColor = true;
            this.Boton4.Click += new System.EventHandler(this.Button_Click);
            // 
            // Boton5
            // 
            this.Boton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Boton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Boton5.Depth = 0;
            this.Boton5.HighEmphasis = true;
            this.Boton5.Icon = null;
            this.Boton5.Location = new System.Drawing.Point(90, 116);
            this.Boton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Boton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.Boton5.Name = "Boton5";
            this.Boton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Boton5.Size = new System.Drawing.Size(64, 36);
            this.Boton5.TabIndex = 1;
            this.Boton5.Text = "5";
            this.Boton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Boton5.UseAccentColor = false;
            this.Boton5.UseVisualStyleBackColor = true;
            this.Boton5.Click += new System.EventHandler(this.Button_Click);
            // 
            // Resta
            // 
            this.Resta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Resta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Resta.Depth = 0;
            this.Resta.HighEmphasis = true;
            this.Resta.Icon = null;
            this.Resta.Location = new System.Drawing.Point(275, 116);
            this.Resta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Resta.MouseState = MaterialSkin.MouseState.HOVER;
            this.Resta.Name = "Resta";
            this.Resta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Resta.Size = new System.Drawing.Size(64, 36);
            this.Resta.TabIndex = 1;
            this.Resta.Text = "-";
            this.Resta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Resta.UseAccentColor = false;
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.OperationCalc);
            // 
            // Boton1
            // 
            this.Boton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Boton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Boton1.Depth = 0;
            this.Boton1.HighEmphasis = true;
            this.Boton1.Icon = null;
            this.Boton1.Location = new System.Drawing.Point(18, 164);
            this.Boton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Boton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Boton1.Name = "Boton1";
            this.Boton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Boton1.Size = new System.Drawing.Size(64, 36);
            this.Boton1.TabIndex = 0;
            this.Boton1.Text = "1";
            this.Boton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Boton1.UseAccentColor = false;
            this.Boton1.UseVisualStyleBackColor = true;
            this.Boton1.Click += new System.EventHandler(this.Button_Click);
            // 
            // Boton2
            // 
            this.Boton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Boton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Boton2.Depth = 0;
            this.Boton2.HighEmphasis = true;
            this.Boton2.Icon = null;
            this.Boton2.Location = new System.Drawing.Point(90, 164);
            this.Boton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Boton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Boton2.Name = "Boton2";
            this.Boton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Boton2.Size = new System.Drawing.Size(64, 36);
            this.Boton2.TabIndex = 1;
            this.Boton2.Text = "2";
            this.Boton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Boton2.UseAccentColor = false;
            this.Boton2.UseVisualStyleBackColor = true;
            this.Boton2.Click += new System.EventHandler(this.Button_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Multiplicacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Multiplicacion.Depth = 0;
            this.Multiplicacion.HighEmphasis = true;
            this.Multiplicacion.Icon = null;
            this.Multiplicacion.Location = new System.Drawing.Point(275, 164);
            this.Multiplicacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Multiplicacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Multiplicacion.Size = new System.Drawing.Size(64, 36);
            this.Multiplicacion.TabIndex = 1;
            this.Multiplicacion.Text = "*";
            this.Multiplicacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Multiplicacion.UseAccentColor = false;
            this.Multiplicacion.UseVisualStyleBackColor = true;
            this.Multiplicacion.Click += new System.EventHandler(this.OperationCalc);
            // 
            // Boton0
            // 
            this.Boton0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Boton0.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Boton0.Depth = 0;
            this.Boton0.HighEmphasis = true;
            this.Boton0.Icon = null;
            this.Boton0.Location = new System.Drawing.Point(90, 212);
            this.Boton0.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Boton0.MouseState = MaterialSkin.MouseState.HOVER;
            this.Boton0.Name = "Boton0";
            this.Boton0.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Boton0.Size = new System.Drawing.Size(64, 36);
            this.Boton0.TabIndex = 1;
            this.Boton0.Text = "0";
            this.Boton0.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Boton0.UseAccentColor = false;
            this.Boton0.UseVisualStyleBackColor = true;
            this.Boton0.Click += new System.EventHandler(this.Button_Click);
            // 
            // Enter
            // 
            this.Enter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Enter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Enter.Depth = 0;
            this.Enter.HighEmphasis = false;
            this.Enter.Icon = null;
            this.Enter.Location = new System.Drawing.Point(162, 212);
            this.Enter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Enter.MouseState = MaterialSkin.MouseState.HOVER;
            this.Enter.Name = "Enter";
            this.Enter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Enter.Size = new System.Drawing.Size(64, 36);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "=";
            this.Enter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Enter.UseAccentColor = true;
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Result);
            // 
            // PuntoDecimal
            // 
            this.PuntoDecimal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PuntoDecimal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.PuntoDecimal.Depth = 0;
            this.PuntoDecimal.HighEmphasis = true;
            this.PuntoDecimal.Icon = null;
            this.PuntoDecimal.Location = new System.Drawing.Point(18, 212);
            this.PuntoDecimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PuntoDecimal.MouseState = MaterialSkin.MouseState.HOVER;
            this.PuntoDecimal.Name = "PuntoDecimal";
            this.PuntoDecimal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PuntoDecimal.Size = new System.Drawing.Size(64, 36);
            this.PuntoDecimal.TabIndex = 1;
            this.PuntoDecimal.Text = ".";
            this.PuntoDecimal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PuntoDecimal.UseAccentColor = false;
            this.PuntoDecimal.UseVisualStyleBackColor = true;
            this.PuntoDecimal.Click += new System.EventHandler(this.Button_Click);
            // 
            // BotonBorrado
            // 
            this.BotonBorrado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonBorrado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BotonBorrado.Depth = 0;
            this.BotonBorrado.HighEmphasis = true;
            this.BotonBorrado.Icon = null;
            this.BotonBorrado.Location = new System.Drawing.Point(275, 20);
            this.BotonBorrado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BotonBorrado.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonBorrado.Name = "BotonBorrado";
            this.BotonBorrado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BotonBorrado.Size = new System.Drawing.Size(64, 36);
            this.BotonBorrado.TabIndex = 1;
            this.BotonBorrado.Text = "C";
            this.BotonBorrado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BotonBorrado.UseAccentColor = true;
            this.BotonBorrado.UseVisualStyleBackColor = true;
            this.BotonBorrado.Click += new System.EventHandler(this.ClearOperation);
            // 
            // Division
            // 
            this.Division.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Division.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Division.Depth = 0;
            this.Division.HighEmphasis = true;
            this.Division.Icon = null;
            this.Division.Location = new System.Drawing.Point(275, 212);
            this.Division.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Division.MouseState = MaterialSkin.MouseState.HOVER;
            this.Division.Name = "Division";
            this.Division.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Division.Size = new System.Drawing.Size(64, 36);
            this.Division.TabIndex = 1;
            this.Division.Text = "/";
            this.Division.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Division.UseAccentColor = false;
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.OperationCalc);
            // 
            // Boton9
            // 
            this.Boton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Boton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Boton9.Depth = 0;
            this.Boton9.HighEmphasis = true;
            this.Boton9.Icon = null;
            this.Boton9.Location = new System.Drawing.Point(162, 68);
            this.Boton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Boton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.Boton9.Name = "Boton9";
            this.Boton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Boton9.Size = new System.Drawing.Size(64, 36);
            this.Boton9.TabIndex = 1;
            this.Boton9.Text = "9";
            this.Boton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Boton9.UseAccentColor = false;
            this.Boton9.UseVisualStyleBackColor = true;
            this.Boton9.Click += new System.EventHandler(this.Button_Click);
            // 
            // Boton6
            // 
            this.Boton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Boton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Boton6.Depth = 0;
            this.Boton6.HighEmphasis = true;
            this.Boton6.Icon = null;
            this.Boton6.Location = new System.Drawing.Point(162, 116);
            this.Boton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Boton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.Boton6.Name = "Boton6";
            this.Boton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Boton6.Size = new System.Drawing.Size(64, 36);
            this.Boton6.TabIndex = 1;
            this.Boton6.Text = "6";
            this.Boton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Boton6.UseAccentColor = false;
            this.Boton6.UseVisualStyleBackColor = true;
            this.Boton6.Click += new System.EventHandler(this.Button_Click);
            // 
            // Boton3
            // 
            this.Boton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Boton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Boton3.Depth = 0;
            this.Boton3.HighEmphasis = true;
            this.Boton3.Icon = null;
            this.Boton3.Location = new System.Drawing.Point(162, 164);
            this.Boton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Boton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Boton3.Name = "Boton3";
            this.Boton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Boton3.Size = new System.Drawing.Size(64, 36);
            this.Boton3.TabIndex = 1;
            this.Boton3.Text = "3";
            this.Boton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Boton3.UseAccentColor = false;
            this.Boton3.UseVisualStyleBackColor = true;
            this.Boton3.Click += new System.EventHandler(this.Button_Click);
            // 
            // ContenedorBotones
            // 
            this.ContenedorBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ContenedorBotones.Controls.Add(this.Boton3);
            this.ContenedorBotones.Controls.Add(this.Boton6);
            this.ContenedorBotones.Controls.Add(this.Operacion);
            this.ContenedorBotones.Controls.Add(this.Boton9);
            this.ContenedorBotones.Controls.Add(this.Division);
            this.ContenedorBotones.Controls.Add(this.BotonBorrado);
            this.ContenedorBotones.Controls.Add(this.PuntoDecimal);
            this.ContenedorBotones.Controls.Add(this.Enter);
            this.ContenedorBotones.Controls.Add(this.Boton0);
            this.ContenedorBotones.Controls.Add(this.Multiplicacion);
            this.ContenedorBotones.Controls.Add(this.Boton2);
            this.ContenedorBotones.Controls.Add(this.Boton1);
            this.ContenedorBotones.Controls.Add(this.Resta);
            this.ContenedorBotones.Controls.Add(this.Boton5);
            this.ContenedorBotones.Controls.Add(this.Boton4);
            this.ContenedorBotones.Controls.Add(this.Suma);
            this.ContenedorBotones.Controls.Add(this.Boton8);
            this.ContenedorBotones.Controls.Add(this.Boton7);
            this.ContenedorBotones.Depth = 0;
            this.ContenedorBotones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContenedorBotones.Location = new System.Drawing.Point(16, 150);
            this.ContenedorBotones.Margin = new System.Windows.Forms.Padding(14);
            this.ContenedorBotones.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContenedorBotones.Name = "ContenedorBotones";
            this.ContenedorBotones.Padding = new System.Windows.Forms.Padding(14);
            this.ContenedorBotones.Size = new System.Drawing.Size(357, 274);
            this.ContenedorBotones.TabIndex = 1;
            // 
            // Resultado
            // 
            this.Resultado.AnimateReadOnly = true;
            this.Resultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Resultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Resultado.Depth = 0;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Resultado.HideSelection = true;
            this.Resultado.LeadingIcon = null;
            this.Resultado.Location = new System.Drawing.Point(16, 85);
            this.Resultado.MaxLength = 32767;
            this.Resultado.MouseState = MaterialSkin.MouseState.OUT;
            this.Resultado.Name = "Resultado";
            this.Resultado.PasswordChar = '\0';
            this.Resultado.PrefixSuffixText = null;
            this.Resultado.ReadOnly = true;
            this.Resultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Resultado.SelectedText = "";
            this.Resultado.SelectionLength = 0;
            this.Resultado.SelectionStart = 0;
            this.Resultado.ShortcutsEnabled = true;
            this.Resultado.Size = new System.Drawing.Size(357, 48);
            this.Resultado.TabIndex = 2;
            this.Resultado.TabStop = false;
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Resultado.TrailingIcon = null;
            this.Resultado.UseSystemPasswordChar = false;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 446);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.ContenedorBotones);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ContenedorBotones.ResumeLayout(false);
            this.ContenedorBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox Operacion;
        private MaterialSkin.Controls.MaterialButton Boton7;
        private MaterialSkin.Controls.MaterialButton Boton8;
        private MaterialSkin.Controls.MaterialButton Suma;
        private MaterialSkin.Controls.MaterialButton Boton4;
        private MaterialSkin.Controls.MaterialButton Boton5;
        private MaterialSkin.Controls.MaterialButton Resta;
        private MaterialSkin.Controls.MaterialButton Boton1;
        private MaterialSkin.Controls.MaterialButton Boton2;
        private MaterialSkin.Controls.MaterialButton Multiplicacion;
        private MaterialSkin.Controls.MaterialButton Boton0;
        private MaterialSkin.Controls.MaterialButton Enter;
        private MaterialSkin.Controls.MaterialButton PuntoDecimal;
        private MaterialSkin.Controls.MaterialButton BotonBorrado;
        private MaterialSkin.Controls.MaterialButton Division;
        private MaterialSkin.Controls.MaterialButton Boton9;
        private MaterialSkin.Controls.MaterialButton Boton6;
        private MaterialSkin.Controls.MaterialButton Boton3;
        private MaterialSkin.Controls.MaterialCard ContenedorBotones;
        private MaterialSkin.Controls.MaterialTextBox2 Resultado;
    }
}

