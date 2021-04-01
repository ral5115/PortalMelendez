using MelendezFront3.Data;
using MelendezFront3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MelendezFront3.Controllers
{
    public class LoginController : Controller
    {
        clsServicios service = new clsServicios();
        DataSet dsOrigen = new DataSet();
        wsGTR.wsGenerarPlanoSoapClient wsGT = new wsGTR.wsGenerarPlanoSoapClient();
        string resultado = string.Empty;
        string path = @"C:\Users\Public\Documents\";
        
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Login data)
        {
            if (ModelState.IsValid)
            {

                var resultado = service.sp_Validar_Usuario(data.User, data.Pass);
                if (resultado.Equals("1"))
                {

                    Home home = new Home();
                    home.Empresa = DataComboBox(1);
                    ViewBag.showSuccessAlert = false;


                    return View("Home", home);
                }
            }
            return View();
        }


        [HttpPost]
        public ActionResult Home(Home data)
        {
            //resultado ws siesa
            var resWs = "";

            //arreglo para compañias
            string[] selectedList;

            data.Empresa = new List<Empresa>();

            if (data.InterfazId == null)
            {
                ModelState.AddModelError("", "Debe Seleccionar una interfaz");
                data.Empresa = DataComboBox(1);
                ViewBag.showSuccessAlert = false;
                return View(data);
            }

            if (data.FechaIni > data.FechaFin)
            {
                ModelState.AddModelError("", "La fecha inicial debe ser menor o igual a la final");
                data.Empresa = DataComboBox(1);
                ViewBag.showSuccessAlert = false;
                return View(data);

            }

            var intf = service.sp_Interfaz(data.InterfazId);

            if (data.InterfazId != "16" && data.InterfazId != "18" && data.InterfazId != "19" && data.InterfazId != "10" && data.InterfazId != "11" && data.InterfazId != "12" && data.InterfazId != "20")
            {
                if (data.Lote == null)
                    data.Lote = "";

                    //if (data.Lote == null)
                    //{
                    //    ModelState.AddModelError("", "Debe Seleccionar un lote");
                    //    data.Empresa = DataComboBox(1);
                    //    ViewBag.showSuccessAlert = false;
                    //    return View(data);
                    //}


                    var selected = Request.Form["EmpresaIds"];
                if (selected == null)
                {
                    ModelState.AddModelError("", "Debe Seleccionar almenos una empresa");
                    data.Empresa = DataComboBox(1);
                    ViewBag.showSuccessAlert = false;
                    return View(data);
                }

                if (selected.Contains("Todas"))
                {
                    selected = "CM,GE,AH,JG,VV,PA,BA,IL,NO,AR,VL,CC,ME,ER,LC";
                }

                selectedList = selected.Split(',');


                foreach (var temp in selectedList)
                {

                    data.Empresa.Add(new Empresa { Text = temp, Value = temp });

                    try
                    {
                        dsOrigen = service.sp_Fuente_datos(data);
                        if (dsOrigen.Tables[0].Rows.Count > 0)
                        {

                            resWs = wsGT.ImportarDatosDS(57823, intf.Tables[0].Rows[0]["Nombre"].ToString(), 2, dsOrigen.Tables[0].Rows[0]["F_CIA"].ToString(), "gt", "gt", dsOrigen, ref path);


                        }
                        else
                        {
                            resWs = "No hay registros para enviar";
                        }
                        
                        data.Empresa.Clear();
                    }
                    catch (Exception e)
                    {
                        ViewBag.showSuccessAlert = true;
                        ViewBag.Message = e.Message;
                        data.Empresa = DataComboBox(1);
                        return View(data);

                    }


                }

            }
            else
            {
                try
                {
                    data.Empresa.Add(new Empresa { Text = "", Value = "" });
                    data.Lote = "";
                    dsOrigen = service.sp_Fuente_datos(data);
                    
                    if (dsOrigen.Tables[0].Rows.Count > 0)
                    {
                        if (data.InterfazId == "16")
                        {

                            resWs = wsGT.ImportarDatosDS(81081, intf.Tables[0].Rows[0]["Nombre"].ToString(), 2, "1", "gt", "gt", dsOrigen, ref path);

                        }
                        else if(data.InterfazId == "20")
                        {
                            resWs = wsGT.ImportarDatosDS(57233, intf.Tables[0].Rows[0]["Nombre"].ToString(), 2, "1", "gt", "gt", dsOrigen, ref path);

                        }
                        else 
                        {
                            resWs = wsGT.ImportarDatosDS(57823, intf.Tables[0].Rows[0]["Nombre"].ToString(), 2, dsOrigen.Tables[0].Rows[0]["F_CIA"].ToString(), "gt", "gt", dsOrigen, ref path);

                        }



                    }
                    else
                    {
                        resWs = "No hay registros para enviar";
                    }

                }
                catch (Exception e)
                {
                    ViewBag.showSuccessAlert = true;
                    
                    ViewBag.Message = e.Message;
                    data.Empresa = DataComboBox(1);
                    return View(data);

                }
            }

            if (resWs == "0")
            {
                ViewBag.showSuccessAlert = true;
                ViewBag.Message = "Registros Cargados a siesa correctamente";
                data.Empresa = DataComboBox(1);
                return View(data);
            }
            else
            {
                ViewBag.showSuccessAlert = true;
                ViewBag.Message = resWs;
                data.Empresa = DataComboBox(1);
                return View(data);
            }


        }

        public List<Empresa> DataComboBox(int permiso)
        {
            List<Interfaz> list = new List<Interfaz>();
            list.Add(new Interfaz { Id = "20", Name = "RECIBOS DE CAJA", sp = "" });
            list.Add(new Interfaz { Id = "1", Name = "DEVOLUCION DE RESERVAS", sp = "" });
            list.Add(new Interfaz { Id = "2", Name = "PLANILLAS DE MANO DE OBRA", sp = "" });
            list.Add(new Interfaz { Id = "3", Name = "ANTICIPOS DE CONTRATOS", sp = "" });
            list.Add(new Interfaz { Id = "4", Name = "CONTRATOS Y ORDENES DE SERVICIO", sp = "" });
            list.Add(new Interfaz { Id = "5", Name = "CXP POR LEGALIZAR CM", sp = "" });
            list.Add(new Interfaz { Id = "6", Name = "ENTRADAS DE ALMACEN CM", sp = "" });
            list.Add(new Interfaz { Id = "7", Name = "CONSUMO DE RECURSOS CM", sp = "" });
            list.Add(new Interfaz { Id = "8", Name = "TRANSFERENCIAS", sp = "" });
            list.Add(new Interfaz { Id = "9", Name = "CAJAS MENORES", sp = "" });
            list.Add(new Interfaz { Id = "10", Name = "CXP POR LEGALIZAR ME", sp = "" });
            list.Add(new Interfaz { Id = "11", Name = "ENTRADAS DE ALMACEN ME", sp = "" });
            list.Add(new Interfaz { Id = "12", Name = "CONSUMO DE ALMACEN ME", sp = "" });
            list.Add(new Interfaz { Id = "13", Name = "ANTICIPO ORDENES DE COMPRAS", sp = "" });
            list.Add(new Interfaz { Id = "14", Name = "DISTRIBUCION DE FACTURAS", sp = "" });
            list.Add(new Interfaz { Id = "15", Name = "DEVOLUCION PROVEEDOR CM", sp = "" });
            list.Add(new Interfaz { Id = "16", Name = "ESCRITURACION INMUEBLE FACTURAS DE VENTA", sp = "" });
            //list.Add(new Interfaz { Id = "17", Name = "ND Y NC DE CARTERA", sp = "" });
            list.Add(new Interfaz { Id = "18", Name = "REVERSION LIBRO 2 FACTURAS DE VENTA", sp = "" });
            list.Add(new Interfaz { Id = "19", Name = "ENTREGA INMUEBLE FACTURAS DE VENTA", sp = "" });
            list.Add(new Interfaz { Id = "21", Name = "DISTRIBUCION DE EQUIPOS", sp = "" });


            ViewBag.Interfaces = list;



            List<Empresa> Empresa = new List<Empresa>();
            Empresa.Add(new Empresa { Value = "CM", Text = "CM" });
            Empresa.Add(new Empresa { Value = "GE", Text = "GE" });
            Empresa.Add(new Empresa { Value = "AH", Text = "AH" });
            Empresa.Add(new Empresa { Value = "JG", Text = "JG" });
            Empresa.Add(new Empresa { Value = "VV", Text = "VV" });
            Empresa.Add(new Empresa { Value = "PA", Text = "PA" });
            Empresa.Add(new Empresa { Value = "BA", Text = "BA" });
            Empresa.Add(new Empresa { Value = "IL", Text = "IL" });
            Empresa.Add(new Empresa { Value = "NO", Text = "NO" });
            Empresa.Add(new Empresa { Value = "AR", Text = "AR" });
            Empresa.Add(new Empresa { Value = "VL", Text = "VL" });
            Empresa.Add(new Empresa { Value = "CC", Text = "CC" });
            Empresa.Add(new Empresa { Value = "ME", Text = "ME" });
            Empresa.Add(new Empresa { Value = "ER", Text = "ER" });
            Empresa.Add(new Empresa { Value = "LC", Text = "LC" });
            Empresa.Add(new Empresa { Value = "T", Text = "Todas" });
            return Empresa;
        }

        public void Enviar(string tipo, Home data, string[] selectedList)
        {
            clsServicios service = new clsServicios();
            DataSet dsOrigen = new DataSet();
            wsGT.wsGenerarPlanoSoapClient wsGT = new wsGT.wsGenerarPlanoSoapClient();
            string resultado = string.Empty;
            string path = @"C:\inetpub\wwwroot\GTIntegration\Planos\";
            data.Empresa = new List<Empresa>();

            foreach (var temp in selectedList)
            {

                data.Empresa.Add(new Empresa { Text = temp, Value = temp });
                dsOrigen = service.sp_Fuente_datos(data);
                if (dsOrigen.Tables.Count > 0)
                {
                    var resGen = wsGT.GenerarPlanoXML(57823, "Docto Contable Libros", 2, dsOrigen.Tables[0].Rows[0]["F_CIA"].ToString(), "gt", "gt", dsOrigen, ref path, ref resultado);
                    path = @"C:\inetpub\wwwroot\GTIntegration\Planos\";
                    var resWs = wsGT.ImportarDatosDS(57823, "Docto Contable Libros", 2, dsOrigen.Tables[0].Rows[0]["F_CIA"].ToString(), "gt", "gt", dsOrigen, ref path);


                }
                data.Empresa.Clear();

            }

        }
    }
}