using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosRegistro
{
    class Producto
    {
        //Declaraion de propiedades 
        public int Id;
        public string NombreProducto;
        public double PrecioProducto;
        public int ExistenciaProducto;

        //delcaracion de metodos get-set
        public int id
        {
            set { value = Id; }
            get { return (Id); }

        }

        public string nombreproducto
        {
            set { value = NombreProducto; }
            get { return (NombreProducto); }
        }

        public double precioproducto
        {
            set { value = PrecioProducto; }
            get { return (PrecioProducto); }

        }

        public int existenciaproducto
        {
            set { value = ExistenciaProducto; }
            get { return (ExistenciaProducto); }
        }

        //declaracion del constructor
        public Producto()
        {
            Id = 0;
            NombreProducto = "";
            PrecioProducto = 0;
            ExistenciaProducto = 0;
        }

        //Declaracion del metodos definidos por el usuario

        public Producto[] AgregarDatos(Producto[] A, int i)
        {
            DiagolBoxCaptura captura = new DiagolBoxCaptura();
            if (captura.ShowDialog() == DialogResult.OK)
            {
                A[i].Id = int.Parse(captura.id);
                A[i].NombreProducto = captura.nombreproducto;
                A[i].PrecioProducto = double.Parse(captura.precioproducto);
                A[i].ExistenciaProducto = int.Parse(captura.existenciaproducto);

                MessageBox.Show("Los Productos FueronGuardados En El Sistema.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return (A);
        }
        public void MostrarTodos(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < 50; i++)
            {
                if (A[i].Id != 0)
                {
                    ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                    lista.SubItems.Add(A[i].NombreProducto);
                    lista.SubItems.Add(A[i].PrecioProducto.ToString());
                    lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                    caja.Items.Add(lista);
                }
            }
        }



        public void MostrarNombreProducto(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = false;
            DiagolBoxBuscarNombre busca = new DiagolBoxBuscarNombre();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].NombreProducto.ToUpper() == busca.nombreproducto.ToUpper())
                    {
                        sw = true;
                        ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);

                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("No se encontro el nombre del producto en el arreglo", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        public void MostrarPrecioProducto(Producto[] A, ListView caja)
        {
            bool sw = true;
            caja.Items.Clear();
            DiagolBoxBuscarPrecioProducto busca = new DiagolBoxBuscarPrecioProducto();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < 50; i++)
                {
                    if (A[i].PrecioProducto == double.Parse(busca.precioproducto))
                    {
                        sw = false;
                        ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
                if (sw == true)
                {
                    MessageBox.Show("No se encontro el precio del producto en el arreglo", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }
        public void MostrarExistenciaProducto(Producto[] A, ListView caja)
        {
            bool sw = true;
            caja.Items.Clear();
            DiagolBoxBuscarExistencia busca = new DiagolBoxBuscarExistencia();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < 50; i++)
                {
                    if (A[i].ExistenciaProducto == double.Parse(busca.existenciaproducto))
                    {
                        sw = false;
                        ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
                if (sw == true)
                {
                    MessageBox.Show("No se encontro la existencia del producto en el arreglo", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        public Producto[] EliminarDatos(Producto[] A)
        {
            bool sw = false;
            DiagolBoxBuscarNombre busca = new DiagolBoxBuscarNombre();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].NombreProducto.ToUpper() == busca.nombreproducto.ToUpper())
                    {
                        sw = true;
                        A[i].Id = 0;
                        A[i].NombreProducto = "";
                        A[i].PrecioProducto = 0;
                        A[i].ExistenciaProducto = 0;
                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("El dato que se quiere borrar no existe", "Areglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("El producto fue eliminado del sistema.", "Arreglo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            return (A);
        }

        public Producto[] ModificarProducto(Producto[] A)
        {
            bool sw = true;
            DiagolBoxBuscarNombre buscar = new DiagolBoxBuscarNombre();
            DiagolBoxCaptura captura = new DiagolBoxCaptura();
            if (buscar.ShowDialog() == DialogResult.OK)
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].NombreProducto.ToUpper() == buscar.nombreproducto.ToUpper())
                    {
                        sw = false;
                        if (captura.ShowDialog() == DialogResult.OK)
                        {
                            A[i].Id = int.Parse(captura.id);
                            A[i].NombreProducto = captura.nombreproducto;
                            A[i].PrecioProducto = double.Parse(captura.precioproducto);
                            A[i].ExistenciaProducto = int.Parse(captura.existenciaproducto);
                        }
                    }
                }
            if (sw == true)
            {
                MessageBox.Show("El producto que deseas modificar no existe", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("El Producto Fue Modificado.", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (A);
        }

        public void MostrarExistenciaPar(Producto[] A,ListView caja)
        {
            bool sw = true;
            caja.Items.Clear();
                for (int i = 0; i < 50; i++)
                {
                    if (A[i].ExistenciaProducto != 0)
                    {


                        if (A[i].ExistenciaProducto % 2 == 0)
                        {
                            sw = false;
                            ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                            lista.SubItems.Add(A[i].NombreProducto);
                            lista.SubItems.Add(A[i].PrecioProducto.ToString());
                            lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                             caja.Items.Add(lista);

                        }
                    }
                }
                if (sw == true)
                {
                    MessageBox.Show("No se encontro la existencia par", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            

        
        public void MostrarExistenciaImpar(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = true;
            for (int i = 0; i < 50; i++)
            {
                if (A[i].ExistenciaProducto != 0)
                {


                    if (A[i].ExistenciaProducto % 1 == 0)
                    {
                        sw = false;
                        ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);


                    }
                }
            }
            if (sw == true)
            {
                MessageBox.Show("No se encontro la existencia impar", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        public void MostraMayorPrecio(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = true;
            int cont=0;
            string resultado = "";
            for (int i = 0; i < 50; i++)
            {
                if (A[i].Id != 0)
                {
                    resultado = resultado + A[i].PrecioProducto;
                    cont++;
                   
                }
            }
            if (sw == true)
            {
                MessageBox.Show("El precio mayor es :" + resultado, "Precio Mayor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void MostrarPromedioPrecio (Producto[]A, ListView caja)
        {
            int cont = 0;
            double prom = 0;
            double suma = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i].Id !=0)
                {
                    suma = suma + A[i].PrecioProducto;
                    cont++;
                }
            }
            prom = suma / cont;
            MessageBox.Show("La suma de los numeros del arreglo es:" + suma + "\n" + "El promedio de los numeros de los precios es :" + prom, "Promedio de los precios", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
    
