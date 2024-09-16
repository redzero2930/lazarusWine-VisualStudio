namespace LazarusWine
{
	partial class Login
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			labelTitle = new Label();
			labelUsuario = new Label();
			labelContraseña = new Label();
			textBoxUsuario = new TextBox();
			textBoxContraseña = new TextBox();
			buttonIniciarSesion = new Button();
			buttonSignup = new Button();
			SuspendLayout();
			// 
			// labelTitle
			// 
			labelTitle.AutoSize = true;
			labelTitle.Location = new Point(161, 27);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(76, 15);
			labelTitle.TabIndex = 0;
			labelTitle.Text = "Lazarus Wine";
			// 
			// labelUsuario
			// 
			labelUsuario.AutoSize = true;
			labelUsuario.Location = new Point(12, 65);
			labelUsuario.Name = "labelUsuario";
			labelUsuario.Size = new Size(47, 15);
			labelUsuario.TabIndex = 1;
			labelUsuario.Text = "Usuario";
			// 
			// labelContraseña
			// 
			labelContraseña.AutoSize = true;
			labelContraseña.Location = new Point(12, 118);
			labelContraseña.Name = "labelContraseña";
			labelContraseña.Size = new Size(67, 15);
			labelContraseña.TabIndex = 2;
			labelContraseña.Text = "Contraseña";
			// 
			// textBoxUsuario
			// 
			textBoxUsuario.Location = new Point(12, 83);
			textBoxUsuario.Name = "textBoxUsuario";
			textBoxUsuario.Size = new Size(385, 23);
			textBoxUsuario.TabIndex = 3;
			// 
			// textBoxContraseña
			// 
			textBoxContraseña.Location = new Point(12, 136);
			textBoxContraseña.Name = "textBoxContraseña";
			textBoxContraseña.Size = new Size(385, 23);
			textBoxContraseña.TabIndex = 4;
			// 
			// buttonIniciarSesion
			// 
			buttonIniciarSesion.Location = new Point(36, 182);
			buttonIniciarSesion.Name = "buttonIniciarSesion";
			buttonIniciarSesion.Size = new Size(75, 43);
			buttonIniciarSesion.TabIndex = 5;
			buttonIniciarSesion.Text = "Iniciar Sesion";
			buttonIniciarSesion.UseVisualStyleBackColor = true;
			buttonIniciarSesion.Click += buttonIniciarSesion_Click;
			// 
			// buttonSignup
			// 
			buttonSignup.Location = new Point(246, 182);
			buttonSignup.Name = "buttonSignup";
			buttonSignup.Size = new Size(75, 43);
			buttonSignup.TabIndex = 6;
			buttonSignup.Text = "Registrarse";
			buttonSignup.UseVisualStyleBackColor = true;
			buttonSignup.Click += buttonSignup_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(409, 237);
			Controls.Add(buttonSignup);
			Controls.Add(buttonIniciarSesion);
			Controls.Add(textBoxContraseña);
			Controls.Add(textBoxUsuario);
			Controls.Add(labelContraseña);
			Controls.Add(labelUsuario);
			Controls.Add(labelTitle);
			Name = "Login";
			Text = "Lazarus Wine";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelTitle;
		private Label labelUsuario;
		private Label labelContraseña;
		private TextBox textBoxUsuario;
		private TextBox textBoxContraseña;
		private Button buttonIniciarSesion;
		private Button buttonSignup;
	}
}
