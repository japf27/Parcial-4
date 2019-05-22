using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using System.Data;

namespace CAPA_NEGOCIOS
{
    class ManttDoctor
    {
        bdConex test = new bdConex();
        private String codDoctor, codHospital, Apellido, Especialidad;
        public DataTable dt = new DataTable();//**

        public bdConex Test
        {
            get { return test; }
            set { test = value; }
        }
        
        public String Apellido1
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        public String CodHospital
        {
            get { return codHospital; }
            set { codHospital = value; }
        }
                     

        public String CodDoctor
        {
            get { return codDoctor; }
            set { codDoctor = value; }
        }

        public void insertVendor()
        {
            try
            {
                String insert = "INSERT INTO VENDEDOR(VENDEDOR,NOMBRE)VALUES('" + codDoctor + "','" + nombreVendor + "')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }


        public void updateVendor()
        {
            try
            {
                String update = "update VENDEDOR set NOMBRE='"
                                 + nombreVendor + "' where vendedor='"
                                 + codVendor + "'";
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void deletVendor()
        {
            try
            {
                String delete = "delete from VENDEDOR where vendedor='"
                                 + codVendor + "'";
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {

            }
        }


        public String prueba()
        {
            String mensaje;
            if (test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }
            else
            {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;

        }

        public void mostrarVendor()
        {
            try
            {
                String consulta = "select VENDEDOR as CODVendor,NOMBRE as NomVendor from [dbo].[VENDEDOR]";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }
        }
    }
}
