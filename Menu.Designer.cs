﻿namespace Tarea3
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InventariomenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estructuraDeUnaTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poligonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estucturaDelDueñoDeLaMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enumeracionDeNeumaticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diseñoDelInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escuelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poligonoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InventariomenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // InventariomenuStrip1
            // 
            this.InventariomenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estructuraDeUnaTiendaToolStripMenuItem,
            this.estucturaDelDueñoDeLaMascotaToolStripMenuItem,
            this.enumeracionDeNeumaticoToolStripMenuItem,
            this.diseñoDelInventarioToolStripMenuItem,
            this.escuelaToolStripMenuItem,
            this.poligonoToolStripMenuItem1});
            this.InventariomenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.InventariomenuStrip1.Name = "InventariomenuStrip1";
            this.InventariomenuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.InventariomenuStrip1.TabIndex = 1;
            this.InventariomenuStrip1.Text = "Inventario";
            // 
            // estructuraDeUnaTiendaToolStripMenuItem
            // 
            this.estructuraDeUnaTiendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poligonoToolStripMenuItem});
            this.estructuraDeUnaTiendaToolStripMenuItem.Name = "estructuraDeUnaTiendaToolStripMenuItem";
            this.estructuraDeUnaTiendaToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.estructuraDeUnaTiendaToolStripMenuItem.Text = "Estructura de una Tienda";
            this.estructuraDeUnaTiendaToolStripMenuItem.Click += new System.EventHandler(this.EstructuraDeUnaTiendaToolStripMenuItem_Click);
            // 
            // poligonoToolStripMenuItem
            // 
            this.poligonoToolStripMenuItem.Name = "poligonoToolStripMenuItem";
            this.poligonoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.poligonoToolStripMenuItem.Text = "Poligono";
            // estucturaDelDueñoDeLaMascotaToolStripMenuItem
            // 
            this.estucturaDelDueñoDeLaMascotaToolStripMenuItem.Name = "estucturaDelDueñoDeLaMascotaToolStripMenuItem";
            this.estucturaDelDueñoDeLaMascotaToolStripMenuItem.Size = new System.Drawing.Size(200, 20);
            this.estucturaDelDueñoDeLaMascotaToolStripMenuItem.Text = "Estuctura del dueño de la Mascota";
            this.estucturaDelDueñoDeLaMascotaToolStripMenuItem.Click += new System.EventHandler(this.EstucturaDelDueñoDeLaMascotaToolStripMenuItem_Click);
            // 
            // enumeracionDeNeumaticoToolStripMenuItem
            // 
            this.enumeracionDeNeumaticoToolStripMenuItem.Name = "enumeracionDeNeumaticoToolStripMenuItem";
            this.enumeracionDeNeumaticoToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.enumeracionDeNeumaticoToolStripMenuItem.Text = "Enumeracion de Neumatico";
            this.enumeracionDeNeumaticoToolStripMenuItem.Click += new System.EventHandler(this.EnumeracionDeNeumaticoToolStripMenuItem_Click);
            // 
            // diseñoDelInventarioToolStripMenuItem
            // 
            this.diseñoDelInventarioToolStripMenuItem.Name = "diseñoDelInventarioToolStripMenuItem";
            this.diseñoDelInventarioToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.diseñoDelInventarioToolStripMenuItem.Text = "Diseño del Inventario";
            this.diseñoDelInventarioToolStripMenuItem.Click += new System.EventHandler(this.DiseñoDelInventarioToolStripMenuItem_Click);
            // 
            // escuelaToolStripMenuItem
            // 
            this.escuelaToolStripMenuItem.Name = "escuelaToolStripMenuItem";
            this.escuelaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.escuelaToolStripMenuItem.Text = "Escuela";
            this.escuelaToolStripMenuItem.Click += new System.EventHandler(this.EscuelaToolStripMenuItem_Click);
            // 
            // poligonoToolStripMenuItem1
            // 
            this.poligonoToolStripMenuItem1.Name = "poligonoToolStripMenuItem1";
            this.poligonoToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.poligonoToolStripMenuItem1.Text = "Poligono";
            this.poligonoToolStripMenuItem1.Click += new System.EventHandler(this.PoligonoToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.InventariomenuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.InventariomenuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.InventariomenuStrip1.ResumeLayout(false);
            this.InventariomenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip InventariomenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructuraDeUnaTiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estucturaDelDueñoDeLaMascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enumeracionDeNeumaticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diseñoDelInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escuelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poligonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poligonoToolStripMenuItem1;
    }
}

