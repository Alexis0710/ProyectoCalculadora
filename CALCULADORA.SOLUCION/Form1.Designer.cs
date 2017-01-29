namespace CALCULADORA.SOLUCION
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnborrar = new System.Windows.Forms.Button();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.btnsqrt = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnresultado = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnsumar = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnborrar.Location = new System.Drawing.Point(14, 50);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(343, 43);
            this.btnborrar.TabIndex = 72;
            this.btnborrar.Text = "CE";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // txtExpresion
            // 
            this.txtExpresion.BackColor = System.Drawing.SystemColors.Info;
            this.txtExpresion.Font = new System.Drawing.Font("Futura Bk BT", 12F);
            this.txtExpresion.Location = new System.Drawing.Point(14, 14);
            this.txtExpresion.Margin = new System.Windows.Forms.Padding(5);
            this.txtExpresion.Multiline = true;
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.ReadOnly = true;
            this.txtExpresion.Size = new System.Drawing.Size(343, 26);
            this.txtExpresion.TabIndex = 62;
            this.txtExpresion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnsqrt
            // 
            this.btnsqrt.BackColor = System.Drawing.Color.DarkGray;
            this.btnsqrt.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsqrt.Location = new System.Drawing.Point(279, 149);
            this.btnsqrt.Margin = new System.Windows.Forms.Padding(5);
            this.btnsqrt.Name = "btnsqrt";
            this.btnsqrt.Size = new System.Drawing.Size(78, 41);
            this.btnsqrt.TabIndex = 89;
            this.btnsqrt.Text = "Sqrt";
            this.btnsqrt.UseVisualStyleBackColor = false;
            this.btnsqrt.Click += new System.EventHandler(this.btnsqrt_Click);
            // 
            // btndivision
            // 
            this.btndivision.BackColor = System.Drawing.Color.DarkGray;
            this.btndivision.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivision.Location = new System.Drawing.Point(279, 103);
            this.btndivision.Margin = new System.Windows.Forms.Padding(5);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(78, 43);
            this.btndivision.TabIndex = 88;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = false;
            this.btndivision.Click += new System.EventHandler(this.btndivision_Click);
            // 
            // btnresultado
            // 
            this.btnresultado.BackColor = System.Drawing.Color.DimGray;
            this.btnresultado.Location = new System.Drawing.Point(279, 195);
            this.btnresultado.Margin = new System.Windows.Forms.Padding(5);
            this.btnresultado.Name = "btnresultado";
            this.btnresultado.Size = new System.Drawing.Size(78, 145);
            this.btnresultado.TabIndex = 87;
            this.btnresultado.Text = "=";
            this.btnresultado.UseVisualStyleBackColor = false;
            this.btnresultado.Click += new System.EventHandler(this.btnresultado_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn0.Font = new System.Drawing.Font("Futura Bk BT", 9F);
            this.btn0.Location = new System.Drawing.Point(14, 297);
            this.btn0.Margin = new System.Windows.Forms.Padding(5);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(173, 43);
            this.btn0.TabIndex = 86;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.BackColor = System.Drawing.Color.DarkGray;
            this.btnpunto.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpunto.Location = new System.Drawing.Point(190, 297);
            this.btnpunto.Margin = new System.Windows.Forms.Padding(5);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(86, 43);
            this.btnpunto.TabIndex = 85;
            this.btnpunto.Text = ".";
            this.btnpunto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnpunto.UseVisualStyleBackColor = false;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn3.Font = new System.Drawing.Font("Futura Bk BT", 9F);
            this.btn3.Location = new System.Drawing.Point(190, 246);
            this.btn3.Margin = new System.Windows.Forms.Padding(5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(86, 43);
            this.btn3.TabIndex = 84;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn6.Font = new System.Drawing.Font("Futura Bk BT", 9F);
            this.btn6.Location = new System.Drawing.Point(190, 195);
            this.btn6.Margin = new System.Windows.Forms.Padding(5);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(86, 43);
            this.btn6.TabIndex = 83;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn9.Font = new System.Drawing.Font("Futura Bk BT", 9F);
            this.btn9.Location = new System.Drawing.Point(190, 149);
            this.btn9.Margin = new System.Windows.Forms.Padding(5);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(86, 43);
            this.btn9.TabIndex = 82;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.BackColor = System.Drawing.Color.DarkGray;
            this.btnmultiplicacion.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicacion.Location = new System.Drawing.Point(190, 103);
            this.btnmultiplicacion.Margin = new System.Windows.Forms.Padding(5);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(86, 39);
            this.btnmultiplicacion.TabIndex = 81;
            this.btnmultiplicacion.Text = "*";
            this.btnmultiplicacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmultiplicacion.UseVisualStyleBackColor = false;
            this.btnmultiplicacion.Click += new System.EventHandler(this.btnmultiplicacion_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2.Font = new System.Drawing.Font("Futura Bk BT", 9F);
            this.btn2.Location = new System.Drawing.Point(104, 246);
            this.btn2.Margin = new System.Windows.Forms.Padding(5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(83, 43);
            this.btn2.TabIndex = 80;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn5.Font = new System.Drawing.Font("Futura Bk BT", 9F);
            this.btn5.Location = new System.Drawing.Point(104, 195);
            this.btn5.Margin = new System.Windows.Forms.Padding(5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(83, 43);
            this.btn5.TabIndex = 79;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn8.Font = new System.Drawing.Font("Futura Bk BT", 9F);
            this.btn8.Location = new System.Drawing.Point(104, 149);
            this.btn8.Margin = new System.Windows.Forms.Padding(5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(83, 43);
            this.btn8.TabIndex = 78;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnrestar
            // 
            this.btnrestar.BackColor = System.Drawing.Color.DarkGray;
            this.btnrestar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestar.Location = new System.Drawing.Point(104, 103);
            this.btnrestar.Margin = new System.Windows.Forms.Padding(5);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(83, 39);
            this.btnrestar.TabIndex = 77;
            this.btnrestar.Text = "-";
            this.btnrestar.UseVisualStyleBackColor = false;
            this.btnrestar.Click += new System.EventHandler(this.btnrestar_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1.Font = new System.Drawing.Font("Futura Bk BT", 9F);
            this.btn1.Location = new System.Drawing.Point(14, 246);
            this.btn1.Margin = new System.Windows.Forms.Padding(5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(87, 43);
            this.btn1.TabIndex = 76;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn4.Font = new System.Drawing.Font("Futura Bk BT", 9F);
            this.btn4.Location = new System.Drawing.Point(14, 197);
            this.btn4.Margin = new System.Windows.Forms.Padding(5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(87, 39);
            this.btn4.TabIndex = 75;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn7.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(14, 149);
            this.btn7.Margin = new System.Windows.Forms.Padding(5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(87, 39);
            this.btn7.TabIndex = 74;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnsumar
            // 
            this.btnsumar.BackColor = System.Drawing.Color.DarkGray;
            this.btnsumar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsumar.Location = new System.Drawing.Point(14, 103);
            this.btnsumar.Margin = new System.Windows.Forms.Padding(5);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(87, 39);
            this.btnsumar.TabIndex = 73;
            this.btnsumar.Text = "+";
            this.btnsumar.UseVisualStyleBackColor = false;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.DarkGray;
            this.btnSin.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(14, 350);
            this.btnSin.Margin = new System.Windows.Forms.Padding(5);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(102, 39);
            this.btnSin.TabIndex = 90;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.DarkGray;
            this.btnCos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(126, 350);
            this.btnCos.Margin = new System.Windows.Forms.Padding(5);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(109, 39);
            this.btnCos.TabIndex = 91;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.DarkGray;
            this.btnTan.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(245, 350);
            this.btnTan.Margin = new System.Windows.Forms.Padding(5);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(112, 39);
            this.btnTan.TabIndex = 92;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 396);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnsqrt);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnresultado);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.txtExpresion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Button btnsqrt;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnresultado;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;

    }
}

