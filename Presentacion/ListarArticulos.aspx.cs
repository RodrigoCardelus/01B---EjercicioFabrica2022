using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using EntidadesCompartidas;
using Persistencia;
using Logica;


public partial class ListarArticulos : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //la variable referencia para guardar el objeto que me fabrico la logica,
            //debe ser el tipo inteface (pq no veo la clase de trabajo y porque el objeto
            //lo devolvi en nombre de la interface
            ILogicaArticulo LArticulo = FabricaLogica.getLogicaArticulo();
            //puede usar el objeto, solo con lo que me expone publicamente la interface el resto del contenido
            //que pueda tener el objeto NO LO SE
            List<Articulo> _lista = LArticulo.ListarArticulo();

            gvListado.DataSource = _lista;
            gvListado.DataBind();

        }
        catch(Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }

}
