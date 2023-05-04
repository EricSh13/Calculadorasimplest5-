using System;

namespace Calculadora_simples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btnIgual = new System.Windows.Forms.Button();
            this.bnt_virgula = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btnSom = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttons, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 455);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textDisplay
            // 
            this.textDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDisplay.Location = new System.Drawing.Point(3, 3);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.Size = new System.Drawing.Size(284, 85);
            this.textDisplay.TabIndex = 0;
            // 
            // buttons
            // 
            this.buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttons.ColumnCount = 4;
            this.buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttons.Controls.Add(this.btnIgual, 3, 4);
            this.buttons.Controls.Add(this.bnt_virgula, 2, 4);
            this.buttons.Controls.Add(this.btnZero, 1, 4);
            this.buttons.Controls.Add(this.button17, 0, 4);
            this.buttons.Controls.Add(this.btnSom, 3, 3);
            this.buttons.Controls.Add(this.btnThree, 2, 3);
            this.buttons.Controls.Add(this.btnTwo, 1, 3);
            this.buttons.Controls.Add(this.btnOne, 0, 3);
            this.buttons.Controls.Add(this.btnMul, 3, 2);
            this.buttons.Controls.Add(this.btnSix, 2, 2);
            this.buttons.Controls.Add(this.btnFive, 1, 2);
            this.buttons.Controls.Add(this.btnFour, 0, 2);
            this.buttons.Controls.Add(this.btnDiv, 3, 1);
            this.buttons.Controls.Add(this.btnNine, 2, 1);
            this.buttons.Controls.Add(this.btnEight, 1, 1);
            this.buttons.Controls.Add(this.btnSeven, 0, 1);
            this.buttons.Controls.Add(this.btnSub, 3, 0);
            this.buttons.Controls.Add(this.btnReset, 2, 0);
            this.buttons.Controls.Add(this.btnCop, 1, 0);
            this.buttons.Controls.Add(this.btnClear, 0, 0);
            this.buttons.Location = new System.Drawing.Point(3, 94);
            this.buttons.Name = "buttons";
            this.buttons.RowCount = 5;
            this.buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttons.Size = new System.Drawing.Size(284, 358);
            this.buttons.TabIndex = 1;
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(216, 287);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(65, 65);
            this.btnIgual.TabIndex = 40;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.button20_Click);
            // 
            // bnt_virgula
            // 
            this.bnt_virgula.Location = new System.Drawing.Point(145, 287);
            this.bnt_virgula.Name = "bnt_virgula";
            this.bnt_virgula.Size = new System.Drawing.Size(65, 65);
            this.bnt_virgula.TabIndex = 39;
            this.bnt_virgula.Text = ",";
            this.bnt_virgula.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZero.Location = new System.Drawing.Point(74, 287);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(65, 68);
            this.btnZero.TabIndex = 38;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnNum);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(3, 287);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(65, 65);
            this.button17.TabIndex = 37;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // btnSom
            // 
            this.btnSom.Location = new System.Drawing.Point(216, 216);
            this.btnSom.Name = "btnSom";
            this.btnSom.Size = new System.Drawing.Size(65, 65);
            this.btnSom.TabIndex = 36;
            this.btnSom.Text = "+";
            this.btnSom.UseVisualStyleBackColor = true;
 //           this.btnSom.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnThree
            // 
            this.btnThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThree.Location = new System.Drawing.Point(145, 216);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(65, 65);
            this.btnThree.TabIndex = 35;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnNum);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(74, 216);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(65, 65);
            this.btnTwo.TabIndex = 34;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnNum);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(3, 216);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(65, 65);
            this.btnOne.TabIndex = 33;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnNum);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(216, 145);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(65, 65);
            this.btnMul.TabIndex = 32;
            this.btnMul.Text = "X";
            this.btnMul.UseVisualStyleBackColor = true;
  //          this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(145, 145);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(65, 65);
            this.btnSix.TabIndex = 31;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnNum);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(74, 145);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(65, 65);
            this.btnFive.TabIndex = 30;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnNum);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(3, 145);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(65, 65);
            this.btnFour.TabIndex = 29;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnNum);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(216, 74);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(65, 65);
            this.btnDiv.TabIndex = 28;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(145, 74);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(65, 65);
            this.btnNine.TabIndex = 27;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNum);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(74, 74);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(65, 65);
            this.btnEight.TabIndex = 26;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnNum);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(3, 74);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(65, 65);
            this.btnSeven.TabIndex = 25;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnNum);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(216, 3);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(65, 65);
            this.btnSub.TabIndex = 24;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(145, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(65, 65);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "limpar ";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button20_Click);
            // 
            // btnCop
            // 
            this.btnCop.Location = new System.Drawing.Point(74, 3);
            this.btnCop.Name = "btnCop";
            this.btnCop.Size = new System.Drawing.Size(65, 65);
            this.btnCop.TabIndex = 22;
            this.btnCop.Text = "cópia ";
            this.btnCop.UseVisualStyleBackColor = true;
            this.btnCop.Click += new System.EventHandler(this.btnCop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 65);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "apagar ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Calculadora ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.TableLayoutPanel buttons;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button bnt_virgula;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btnSom;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCop;
        private System.Windows.Forms.Button btnClear;
    }
}

