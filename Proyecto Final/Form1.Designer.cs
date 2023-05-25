
namespace ArreglosRegistro
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreDelProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPrecioDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porExistenciaDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLosProductosConExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLaSumaYPromedioDelPrecioDeLosProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(41)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDatosToolStripMenuItem,
            this.mostrarDatosToolStripMenuItem,
            this.eliminarDatosToolStripMenuItem,
            this.modificarDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Main Menu ";
            // 
            // agregarDatosToolStripMenuItem
            // 
            this.agregarDatosToolStripMenuItem.Name = "agregarDatosToolStripMenuItem";
            this.agregarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarDatosToolStripMenuItem.Text = "Add Products";
            this.agregarDatosToolStripMenuItem.Click += new System.EventHandler(this.agregarDatosToolStripMenuItem_Click);
            // 
            // mostrarDatosToolStripMenuItem
            // 
            this.mostrarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosDatosToolStripMenuItem,
            this.porNombreDelProductosToolStripMenuItem,
            this.porPrecioDeProductoToolStripMenuItem,
            this.porExistenciaDeProductoToolStripMenuItem});
            this.mostrarDatosToolStripMenuItem.Name = "mostrarDatosToolStripMenuItem";
            this.mostrarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarDatosToolStripMenuItem.Text = "Show Products";
            // 
            // todosLosDatosToolStripMenuItem
            // 
            this.todosLosDatosToolStripMenuItem.Name = "todosLosDatosToolStripMenuItem";
            this.todosLosDatosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.todosLosDatosToolStripMenuItem.Text = "All Data";
            this.todosLosDatosToolStripMenuItem.Click += new System.EventHandler(this.todosLosDatosToolStripMenuItem_Click);
            // 
            // porNombreDelProductosToolStripMenuItem
            // 
            this.porNombreDelProductosToolStripMenuItem.Name = "porNombreDelProductosToolStripMenuItem";
            this.porNombreDelProductosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.porNombreDelProductosToolStripMenuItem.Text = "By product name";
            this.porNombreDelProductosToolStripMenuItem.Click += new System.EventHandler(this.porNombreDelProductosToolStripMenuItem_Click);
            // 
            // porPrecioDeProductoToolStripMenuItem
            // 
            this.porPrecioDeProductoToolStripMenuItem.Name = "porPrecioDeProductoToolStripMenuItem";
            this.porPrecioDeProductoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.porPrecioDeProductoToolStripMenuItem.Text = "By product price";
            this.porPrecioDeProductoToolStripMenuItem.Click += new System.EventHandler(this.porPrecioDeProductoToolStripMenuItem_Click);
            // 
            // porExistenciaDeProductoToolStripMenuItem
            // 
            this.porExistenciaDeProductoToolStripMenuItem.Name = "porExistenciaDeProductoToolStripMenuItem";
            this.porExistenciaDeProductoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.porExistenciaDeProductoToolStripMenuItem.Text = "By product existence";
            this.porExistenciaDeProductoToolStripMenuItem.Click += new System.EventHandler(this.porExistenciaDeProductoToolStripMenuItem_Click);
            // 
            // eliminarDatosToolStripMenuItem
            // 
            this.eliminarDatosToolStripMenuItem.Name = "eliminarDatosToolStripMenuItem";
            this.eliminarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarDatosToolStripMenuItem.Text = "Delete Products";
            this.eliminarDatosToolStripMenuItem.Click += new System.EventHandler(this.eliminarDatosToolStripMenuItem_Click);
            // 
            // modificarDatosToolStripMenuItem
            // 
            this.modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            this.modificarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarDatosToolStripMenuItem.Text = "Modify  Products";
            this.modificarDatosToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Exit";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarLosProductosConExistenciaToolStripMenuItem,
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem,
            this.mostrarLaSumaYPromedioDelPrecioDeLosProdutosToolStripMenuItem,
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem,
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem});
            this.operacionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.operacionesToolStripMenuItem.Text = "Operations";
            // 
            // mostrarLosProductosConExistenciaToolStripMenuItem
            // 
            this.mostrarLosProductosConExistenciaToolStripMenuItem.Name = "mostrarLosProductosConExistenciaToolStripMenuItem";
            this.mostrarLosProductosConExistenciaToolStripMenuItem.Size = new System.Drawing.Size(381, 22);
            this.mostrarLosProductosConExistenciaToolStripMenuItem.Text = "Show the products with even stock";
            this.mostrarLosProductosConExistenciaToolStripMenuItem.Click += new System.EventHandler(this.mostrarLosProductosConExistenciaToolStripMenuItem_Click);
            // 
            // mostrarLosProductosConExistenciaImparToolStripMenuItem
            // 
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Name = "mostrarLosProductosConExistenciaImparToolStripMenuItem";
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Size = new System.Drawing.Size(381, 22);
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Text = "Show the products with odd stock";
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Click += new System.EventHandler(this.mostrarLosProductosConExistenciaImparToolStripMenuItem_Click);
            // 
            // mostrarLaSumaYPromedioDelPrecioDeLosProdutosToolStripMenuItem
            // 
            this.mostrarLaSumaYPromedioDelPrecioDeLosProdutosToolStripMenuItem.Name = "mostrarLaSumaYPromedioDelPrecioDeLosProdutosToolStripMenuItem";
            this.mostrarLaSumaYPromedioDelPrecioDeLosProdutosToolStripMenuItem.Size = new System.Drawing.Size(381, 22);
            this.mostrarLaSumaYPromedioDelPrecioDeLosProdutosToolStripMenuItem.Text = "Show the sum and average of the price of the products";
            this.mostrarLaSumaYPromedioDelPrecioDeLosProdutosToolStripMenuItem.Click += new System.EventHandler(this.mostrarLaSumaYPromedioDelPrecioDeLosProdutosToolStripMenuItem_Click);
            // 
            // mostrarElProductoDeMayorExistenciaToolStripMenuItem
            // 
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Name = "mostrarElProductoDeMayorExistenciaToolStripMenuItem";
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Size = new System.Drawing.Size(381, 22);
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Text = "Show the most existing product";
            // 
            // mostrarElProductoDeMenorExistenciaToolStripMenuItem
            // 
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem.Name = "mostrarElProductoDeMenorExistenciaToolStripMenuItem";
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem.Size = new System.Drawing.Size(381, 22);
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem.Text = "Show  the lowest stock product";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(41)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 33);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(521, 225);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name Product";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price of the product";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product Stock";
            this.columnHeader4.Width = 166;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(675, 294);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Systems";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreDelProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPrecioDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porExistenciaDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLosProductosConExistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLosProductosConExistenciaImparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLaSumaYPromedioDelPrecioDeLosProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoDeMayorExistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoDeMenorExistenciaToolStripMenuItem;
    }
}

