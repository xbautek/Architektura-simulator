﻿namespace Architektura___8086_simulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelAX = new System.Windows.Forms.Label();
            this.MOVAXBX = new System.Windows.Forms.Button();
            this.labelBX = new System.Windows.Forms.Label();
            this.labelCX = new System.Windows.Forms.Label();
            this.labelDX = new System.Windows.Forms.Label();
            this.textBoxAX = new System.Windows.Forms.TextBox();
            this.textBoxBX = new System.Windows.Forms.TextBox();
            this.textBoxCX = new System.Windows.Forms.TextBox();
            this.textBoxDX = new System.Windows.Forms.TextBox();
            this.MOVAXCX = new System.Windows.Forms.Button();
            this.MOVAXDX = new System.Windows.Forms.Button();
            this.MOVBXAX = new System.Windows.Forms.Button();
            this.MOVBXCX = new System.Windows.Forms.Button();
            this.MOVBXDX = new System.Windows.Forms.Button();
            this.MOVCXAX = new System.Windows.Forms.Button();
            this.MOVCXBX = new System.Windows.Forms.Button();
            this.MOVCXDX = new System.Windows.Forms.Button();
            this.MOVDXCX = new System.Windows.Forms.Button();
            this.MOVDXBX = new System.Windows.Forms.Button();
            this.MOVDXAX = new System.Windows.Forms.Button();
            this.MOVAXVAR = new System.Windows.Forms.Button();
            this.MOVBXVAR = new System.Windows.Forms.Button();
            this.MOVCXVAR = new System.Windows.Forms.Button();
            this.MOVDXVAR = new System.Windows.Forms.Button();
            this.VARIABLE = new System.Windows.Forms.TextBox();
            this.labelVAR = new System.Windows.Forms.Label();
            this.XCHGAXBX = new System.Windows.Forms.Button();
            this.XCHGBXCX = new System.Windows.Forms.Button();
            this.XCHGAXCX = new System.Windows.Forms.Button();
            this.XCHGBXDX = new System.Windows.Forms.Button();
            this.XCHGAXDX = new System.Windows.Forms.Button();
            this.XCHGCXDX = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAX
            // 
            this.labelAX.AutoSize = true;
            this.labelAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAX.Location = new System.Drawing.Point(37, 37);
            this.labelAX.Name = "labelAX";
            this.labelAX.Size = new System.Drawing.Size(42, 25);
            this.labelAX.TabIndex = 0;
            this.labelAX.Text = "AX";
            // 
            // MOVAXBX
            // 
            this.MOVAXBX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVAXBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVAXBX.Location = new System.Drawing.Point(271, 37);
            this.MOVAXBX.Name = "MOVAXBX";
            this.MOVAXBX.Size = new System.Drawing.Size(113, 38);
            this.MOVAXBX.TabIndex = 1;
            this.MOVAXBX.Text = "MOV AX BX";
            this.MOVAXBX.UseVisualStyleBackColor = true;
            this.MOVAXBX.Click += new System.EventHandler(this.MOVAXBX_Click);
            // 
            // labelBX
            // 
            this.labelBX.AutoSize = true;
            this.labelBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBX.Location = new System.Drawing.Point(37, 72);
            this.labelBX.Name = "labelBX";
            this.labelBX.Size = new System.Drawing.Size(41, 25);
            this.labelBX.TabIndex = 2;
            this.labelBX.Text = "BX";
            // 
            // labelCX
            // 
            this.labelCX.AutoSize = true;
            this.labelCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCX.Location = new System.Drawing.Point(37, 107);
            this.labelCX.Name = "labelCX";
            this.labelCX.Size = new System.Drawing.Size(43, 25);
            this.labelCX.TabIndex = 3;
            this.labelCX.Text = "CX";
            // 
            // labelDX
            // 
            this.labelDX.AutoSize = true;
            this.labelDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDX.Location = new System.Drawing.Point(37, 142);
            this.labelDX.Name = "labelDX";
            this.labelDX.Size = new System.Drawing.Size(42, 25);
            this.labelDX.TabIndex = 4;
            this.labelDX.Text = "DX";
            // 
            // textBoxAX
            // 
            this.textBoxAX.Location = new System.Drawing.Point(95, 37);
            this.textBoxAX.MaxLength = 5;
            this.textBoxAX.Multiline = true;
            this.textBoxAX.Name = "textBoxAX";
            this.textBoxAX.Size = new System.Drawing.Size(150, 25);
            this.textBoxAX.TabIndex = 5;
            this.textBoxAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAX_KeyPress);
            // 
            // textBoxBX
            // 
            this.textBoxBX.Location = new System.Drawing.Point(95, 72);
            this.textBoxBX.MaxLength = 5;
            this.textBoxBX.Multiline = true;
            this.textBoxBX.Name = "textBoxBX";
            this.textBoxBX.Size = new System.Drawing.Size(150, 25);
            this.textBoxBX.TabIndex = 6;
            // 
            // textBoxCX
            // 
            this.textBoxCX.Location = new System.Drawing.Point(95, 107);
            this.textBoxCX.MaxLength = 5;
            this.textBoxCX.Multiline = true;
            this.textBoxCX.Name = "textBoxCX";
            this.textBoxCX.Size = new System.Drawing.Size(150, 25);
            this.textBoxCX.TabIndex = 7;
            // 
            // textBoxDX
            // 
            this.textBoxDX.Location = new System.Drawing.Point(95, 142);
            this.textBoxDX.MaxLength = 5;
            this.textBoxDX.Multiline = true;
            this.textBoxDX.Name = "textBoxDX";
            this.textBoxDX.Size = new System.Drawing.Size(150, 25);
            this.textBoxDX.TabIndex = 8;
            // 
            // MOVAXCX
            // 
            this.MOVAXCX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVAXCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVAXCX.Location = new System.Drawing.Point(271, 84);
            this.MOVAXCX.Name = "MOVAXCX";
            this.MOVAXCX.Size = new System.Drawing.Size(113, 38);
            this.MOVAXCX.TabIndex = 10;
            this.MOVAXCX.Text = "MOV AX CX";
            this.MOVAXCX.UseVisualStyleBackColor = true;
            this.MOVAXCX.Click += new System.EventHandler(this.MOVAXCX_Click);
            // 
            // MOVAXDX
            // 
            this.MOVAXDX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVAXDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVAXDX.Location = new System.Drawing.Point(271, 131);
            this.MOVAXDX.Name = "MOVAXDX";
            this.MOVAXDX.Size = new System.Drawing.Size(113, 38);
            this.MOVAXDX.TabIndex = 11;
            this.MOVAXDX.Text = "MOV AX DX";
            this.MOVAXDX.UseVisualStyleBackColor = true;
            this.MOVAXDX.Click += new System.EventHandler(this.MOVAXDX_Click);
            // 
            // MOVBXAX
            // 
            this.MOVBXAX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVBXAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVBXAX.Location = new System.Drawing.Point(404, 37);
            this.MOVBXAX.Name = "MOVBXAX";
            this.MOVBXAX.Size = new System.Drawing.Size(113, 38);
            this.MOVBXAX.TabIndex = 12;
            this.MOVBXAX.Text = "MOV BX AX";
            this.MOVBXAX.UseVisualStyleBackColor = true;
            this.MOVBXAX.Click += new System.EventHandler(this.MOVBXAX_Click);
            // 
            // MOVBXCX
            // 
            this.MOVBXCX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVBXCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVBXCX.Location = new System.Drawing.Point(404, 84);
            this.MOVBXCX.Name = "MOVBXCX";
            this.MOVBXCX.Size = new System.Drawing.Size(113, 38);
            this.MOVBXCX.TabIndex = 13;
            this.MOVBXCX.Text = "MOV BX CX";
            this.MOVBXCX.UseVisualStyleBackColor = true;
            this.MOVBXCX.Click += new System.EventHandler(this.MOVBXCX_Click);
            // 
            // MOVBXDX
            // 
            this.MOVBXDX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVBXDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVBXDX.Location = new System.Drawing.Point(404, 131);
            this.MOVBXDX.Name = "MOVBXDX";
            this.MOVBXDX.Size = new System.Drawing.Size(113, 38);
            this.MOVBXDX.TabIndex = 14;
            this.MOVBXDX.Text = "MOV BX DX";
            this.MOVBXDX.UseVisualStyleBackColor = true;
            this.MOVBXDX.Click += new System.EventHandler(this.MOVBXDX_Click);
            // 
            // MOVCXAX
            // 
            this.MOVCXAX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVCXAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVCXAX.Location = new System.Drawing.Point(537, 37);
            this.MOVCXAX.Name = "MOVCXAX";
            this.MOVCXAX.Size = new System.Drawing.Size(113, 38);
            this.MOVCXAX.TabIndex = 15;
            this.MOVCXAX.Text = "MOV CX AX";
            this.MOVCXAX.UseVisualStyleBackColor = true;
            this.MOVCXAX.Click += new System.EventHandler(this.MOVCXAX_Click);
            // 
            // MOVCXBX
            // 
            this.MOVCXBX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVCXBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVCXBX.Location = new System.Drawing.Point(537, 84);
            this.MOVCXBX.Name = "MOVCXBX";
            this.MOVCXBX.Size = new System.Drawing.Size(113, 38);
            this.MOVCXBX.TabIndex = 16;
            this.MOVCXBX.Text = "MOV CX BX";
            this.MOVCXBX.UseVisualStyleBackColor = true;
            this.MOVCXBX.Click += new System.EventHandler(this.MOVCXBX_Click);
            // 
            // MOVCXDX
            // 
            this.MOVCXDX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVCXDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVCXDX.Location = new System.Drawing.Point(537, 131);
            this.MOVCXDX.Name = "MOVCXDX";
            this.MOVCXDX.Size = new System.Drawing.Size(113, 38);
            this.MOVCXDX.TabIndex = 17;
            this.MOVCXDX.Text = "MOV CX DX";
            this.MOVCXDX.UseVisualStyleBackColor = true;
            this.MOVCXDX.Click += new System.EventHandler(this.MOVCXDX_Click);
            // 
            // MOVDXCX
            // 
            this.MOVDXCX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVDXCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVDXCX.Location = new System.Drawing.Point(668, 131);
            this.MOVDXCX.Name = "MOVDXCX";
            this.MOVDXCX.Size = new System.Drawing.Size(113, 38);
            this.MOVDXCX.TabIndex = 20;
            this.MOVDXCX.Text = "MOV DX CX";
            this.MOVDXCX.UseVisualStyleBackColor = true;
            this.MOVDXCX.Click += new System.EventHandler(this.MOVDXCX_Click);
            // 
            // MOVDXBX
            // 
            this.MOVDXBX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVDXBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVDXBX.Location = new System.Drawing.Point(668, 84);
            this.MOVDXBX.Name = "MOVDXBX";
            this.MOVDXBX.Size = new System.Drawing.Size(113, 38);
            this.MOVDXBX.TabIndex = 19;
            this.MOVDXBX.Text = "MOV DX BX";
            this.MOVDXBX.UseVisualStyleBackColor = true;
            this.MOVDXBX.Click += new System.EventHandler(this.MOVDXBX_Click);
            // 
            // MOVDXAX
            // 
            this.MOVDXAX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVDXAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVDXAX.Location = new System.Drawing.Point(668, 37);
            this.MOVDXAX.Name = "MOVDXAX";
            this.MOVDXAX.Size = new System.Drawing.Size(113, 38);
            this.MOVDXAX.TabIndex = 18;
            this.MOVDXAX.Text = "MOV DX AX";
            this.MOVDXAX.UseVisualStyleBackColor = true;
            this.MOVDXAX.Click += new System.EventHandler(this.MOVDXAX_Click);
            // 
            // MOVAXVAR
            // 
            this.MOVAXVAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVAXVAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVAXVAR.Location = new System.Drawing.Point(271, 257);
            this.MOVAXVAR.Name = "MOVAXVAR";
            this.MOVAXVAR.Size = new System.Drawing.Size(113, 38);
            this.MOVAXVAR.TabIndex = 21;
            this.MOVAXVAR.Text = "MOV AX VAR";
            this.MOVAXVAR.UseVisualStyleBackColor = true;
            this.MOVAXVAR.Click += new System.EventHandler(this.MOVAXVAR_Click);
            // 
            // MOVBXVAR
            // 
            this.MOVBXVAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVBXVAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVBXVAR.Location = new System.Drawing.Point(404, 257);
            this.MOVBXVAR.Name = "MOVBXVAR";
            this.MOVBXVAR.Size = new System.Drawing.Size(113, 38);
            this.MOVBXVAR.TabIndex = 22;
            this.MOVBXVAR.Text = "MOV BX VAR";
            this.MOVBXVAR.UseVisualStyleBackColor = true;
            this.MOVBXVAR.Click += new System.EventHandler(this.MOVBXVAR_Click);
            // 
            // MOVCXVAR
            // 
            this.MOVCXVAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVCXVAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVCXVAR.Location = new System.Drawing.Point(537, 257);
            this.MOVCXVAR.Name = "MOVCXVAR";
            this.MOVCXVAR.Size = new System.Drawing.Size(113, 38);
            this.MOVCXVAR.TabIndex = 23;
            this.MOVCXVAR.Text = "MOV CX VAR";
            this.MOVCXVAR.UseVisualStyleBackColor = true;
            this.MOVCXVAR.Click += new System.EventHandler(this.MOVCXVAR_Click);
            // 
            // MOVDXVAR
            // 
            this.MOVDXVAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOVDXVAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOVDXVAR.Location = new System.Drawing.Point(668, 257);
            this.MOVDXVAR.Name = "MOVDXVAR";
            this.MOVDXVAR.Size = new System.Drawing.Size(113, 38);
            this.MOVDXVAR.TabIndex = 24;
            this.MOVDXVAR.Text = "MOV DX VAR";
            this.MOVDXVAR.UseVisualStyleBackColor = true;
            this.MOVDXVAR.Click += new System.EventHandler(this.MOVDXVAR_Click);
            // 
            // VARIABLE
            // 
            this.VARIABLE.Location = new System.Drawing.Point(486, 218);
            this.VARIABLE.MaxLength = 5;
            this.VARIABLE.Multiline = true;
            this.VARIABLE.Name = "VARIABLE";
            this.VARIABLE.Size = new System.Drawing.Size(164, 25);
            this.VARIABLE.TabIndex = 26;
            // 
            // labelVAR
            // 
            this.labelVAR.AutoSize = true;
            this.labelVAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVAR.Location = new System.Drawing.Point(407, 218);
            this.labelVAR.Name = "labelVAR";
            this.labelVAR.Size = new System.Drawing.Size(56, 25);
            this.labelVAR.TabIndex = 25;
            this.labelVAR.Text = "VAR";
            // 
            // XCHGAXBX
            // 
            this.XCHGAXBX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XCHGAXBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XCHGAXBX.Location = new System.Drawing.Point(271, 352);
            this.XCHGAXBX.Name = "XCHGAXBX";
            this.XCHGAXBX.Size = new System.Drawing.Size(246, 38);
            this.XCHGAXBX.TabIndex = 27;
            this.XCHGAXBX.Text = "XCHG AX BX";
            this.XCHGAXBX.UseVisualStyleBackColor = true;
            this.XCHGAXBX.Click += new System.EventHandler(this.XCHGAXBX_Click);
            // 
            // XCHGBXCX
            // 
            this.XCHGBXCX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XCHGBXCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XCHGBXCX.Location = new System.Drawing.Point(537, 352);
            this.XCHGBXCX.Name = "XCHGBXCX";
            this.XCHGBXCX.Size = new System.Drawing.Size(246, 38);
            this.XCHGBXCX.TabIndex = 28;
            this.XCHGBXCX.Text = "XCHG BX CX";
            this.XCHGBXCX.UseVisualStyleBackColor = true;
            this.XCHGBXCX.Click += new System.EventHandler(this.XCHGBXCX_Click);
            // 
            // XCHGAXCX
            // 
            this.XCHGAXCX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XCHGAXCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XCHGAXCX.Location = new System.Drawing.Point(271, 396);
            this.XCHGAXCX.Name = "XCHGAXCX";
            this.XCHGAXCX.Size = new System.Drawing.Size(246, 38);
            this.XCHGAXCX.TabIndex = 29;
            this.XCHGAXCX.Text = "XCHG AX CX";
            this.XCHGAXCX.UseVisualStyleBackColor = true;
            this.XCHGAXCX.Click += new System.EventHandler(this.XCHGAXCX_Click);
            // 
            // XCHGBXDX
            // 
            this.XCHGBXDX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XCHGBXDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XCHGBXDX.Location = new System.Drawing.Point(537, 396);
            this.XCHGBXDX.Name = "XCHGBXDX";
            this.XCHGBXDX.Size = new System.Drawing.Size(246, 38);
            this.XCHGBXDX.TabIndex = 30;
            this.XCHGBXDX.Text = "XCHG BX DX";
            this.XCHGBXDX.UseVisualStyleBackColor = true;
            this.XCHGBXDX.Click += new System.EventHandler(this.XCHGBXDX_Click);
            // 
            // XCHGAXDX
            // 
            this.XCHGAXDX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XCHGAXDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XCHGAXDX.Location = new System.Drawing.Point(271, 440);
            this.XCHGAXDX.Name = "XCHGAXDX";
            this.XCHGAXDX.Size = new System.Drawing.Size(246, 38);
            this.XCHGAXDX.TabIndex = 31;
            this.XCHGAXDX.Text = "XCHG AX DX";
            this.XCHGAXDX.UseVisualStyleBackColor = true;
            this.XCHGAXDX.Click += new System.EventHandler(this.XCHGAXDX_Click);
            // 
            // XCHGCXDX
            // 
            this.XCHGCXDX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XCHGCXDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XCHGCXDX.Location = new System.Drawing.Point(537, 440);
            this.XCHGCXDX.Name = "XCHGCXDX";
            this.XCHGCXDX.Size = new System.Drawing.Size(246, 38);
            this.XCHGCXDX.TabIndex = 32;
            this.XCHGCXDX.Text = "XCHG CX DX";
            this.XCHGCXDX.UseVisualStyleBackColor = true;
            this.XCHGCXDX.Click += new System.EventHandler(this.XCHGCXDX_Click);
            // 
            // RESET
            // 
            this.RESET.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RESET.Location = new System.Drawing.Point(42, 175);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(203, 33);
            this.RESET.TabIndex = 33;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(821, 506);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.XCHGCXDX);
            this.Controls.Add(this.XCHGAXDX);
            this.Controls.Add(this.XCHGBXDX);
            this.Controls.Add(this.XCHGAXCX);
            this.Controls.Add(this.XCHGBXCX);
            this.Controls.Add(this.XCHGAXBX);
            this.Controls.Add(this.VARIABLE);
            this.Controls.Add(this.labelVAR);
            this.Controls.Add(this.MOVDXVAR);
            this.Controls.Add(this.MOVCXVAR);
            this.Controls.Add(this.MOVBXVAR);
            this.Controls.Add(this.MOVAXVAR);
            this.Controls.Add(this.MOVDXCX);
            this.Controls.Add(this.MOVDXBX);
            this.Controls.Add(this.MOVDXAX);
            this.Controls.Add(this.MOVCXDX);
            this.Controls.Add(this.MOVCXBX);
            this.Controls.Add(this.MOVCXAX);
            this.Controls.Add(this.MOVBXDX);
            this.Controls.Add(this.MOVBXCX);
            this.Controls.Add(this.MOVBXAX);
            this.Controls.Add(this.MOVAXDX);
            this.Controls.Add(this.MOVAXCX);
            this.Controls.Add(this.textBoxDX);
            this.Controls.Add(this.textBoxCX);
            this.Controls.Add(this.textBoxBX);
            this.Controls.Add(this.textBoxAX);
            this.Controls.Add(this.labelDX);
            this.Controls.Add(this.labelCX);
            this.Controls.Add(this.labelBX);
            this.Controls.Add(this.MOVAXBX);
            this.Controls.Add(this.labelAX);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Intel 8086 simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAX;
        private System.Windows.Forms.Button MOVAXBX;
        private System.Windows.Forms.Label labelBX;
        private System.Windows.Forms.Label labelCX;
        private System.Windows.Forms.Label labelDX;
        private System.Windows.Forms.TextBox textBoxAX;
        private System.Windows.Forms.TextBox textBoxBX;
        private System.Windows.Forms.TextBox textBoxCX;
        private System.Windows.Forms.TextBox textBoxDX;
        private System.Windows.Forms.Button MOVAXCX;
        private System.Windows.Forms.Button MOVAXDX;
        private System.Windows.Forms.Button MOVBXAX;
        private System.Windows.Forms.Button MOVBXCX;
        private System.Windows.Forms.Button MOVBXDX;
        private System.Windows.Forms.Button MOVCXAX;
        private System.Windows.Forms.Button MOVCXBX;
        private System.Windows.Forms.Button MOVCXDX;
        private System.Windows.Forms.Button MOVDXCX;
        private System.Windows.Forms.Button MOVDXBX;
        private System.Windows.Forms.Button MOVDXAX;
        private System.Windows.Forms.Button MOVAXVAR;
        private System.Windows.Forms.Button MOVBXVAR;
        private System.Windows.Forms.Button MOVCXVAR;
        private System.Windows.Forms.Button MOVDXVAR;
        private System.Windows.Forms.TextBox VARIABLE;
        private System.Windows.Forms.Label labelVAR;
        private System.Windows.Forms.Button XCHGAXBX;
        private System.Windows.Forms.Button XCHGBXCX;
        private System.Windows.Forms.Button XCHGAXCX;
        private System.Windows.Forms.Button XCHGBXDX;
        private System.Windows.Forms.Button XCHGAXDX;
        private System.Windows.Forms.Button XCHGCXDX;
        private System.Windows.Forms.Button RESET;
    }
}
