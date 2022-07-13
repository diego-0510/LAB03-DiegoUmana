﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class conexionBD
    {
        private static NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost; Database=LAB03; User Id=postgres; Password=sancarlos2015");
        public static void conectarPostgresSQL()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conectado");
            }
            catch (Exception)
            {
                MessageBox.Show("Conexion Interrumpida...", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void desconectarPostgresSQL()
        {
            conexion.Close();
            Console.WriteLine("Desonectado");
        }

        public static string insertarDatos(string tabla, dynamic[] datos)
        {
            try
            {
                conectarPostgresSQL();
                string campos = "(";
                for (int i = 0; i < datos.Length; i++)
                {
                    campos += "'" + datos[i] + "'";
                    if (i != datos.Length - 1)
                    {
                        campos += ",";
                    }
                }
                campos += ")";
                string insert_sql = "Insert into \"" + tabla + "\"values" + campos;
                NpgsqlCommand ejecutar = new NpgsqlCommand(insert_sql, conexion);
                ejecutar.ExecuteNonQuery();//No se inserta la informacion hasta ejecutar este comando
                desconectarPostgresSQL();
            }
            catch (Exception)
            {
                return "error";

            }
            return "ok";
        }

    }
}