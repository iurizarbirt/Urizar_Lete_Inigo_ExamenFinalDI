using BusinessLogicLayer;
using ObjetosTransferencia.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica.UC
{
    public partial class ListaPedidosUC : UserControl
    {
        private List<PedidoDTO> listaPedidos;

        public ListaPedidosUC(String nombreCliente)
        {
            InitializeComponent();
            // TODO: haz la peticion de los clientes y asociala a la lista y cargalo en el DataGridView
            listaPedidos = ControladorBLL.ListarPedidosCliente(nombreCliente);
            BindingSource bs = new BindingSource();
            foreach(PedidoDTO p in listaPedidos)
            {
                bs.Add(p);
            }
            dGV_Pedidos.DataSource = bs;
            dGV_Pedidos.AutoGenerateColumns = true;

         
        }

        public List<PedidoDTO> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }


    }
}
