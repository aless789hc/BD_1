using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace BD_1
{
    
    internal class Conexion
    {
        private readonly string _walletPath = @"C:\Users\emili\source\repos\BD_1\BD_1\Wallet\Wallet_TBDEJ2026 (1)\";
        // El service name que viste en tnsnames.ora 
        private readonly string _serviceName = "tbdej2026_medium";

        private string BuildConnectionString()
        {
            return
                $"User Id=foto_app;" +
                $"Password=Contraseña1234.;" +
                $"Data Source={_serviceName};" +
                $"Connection Timeout=30;";

        }
        public void ConfigurarWallet()
        {
            OracleConfiguration.TnsAdmin = _walletPath;
            OracleConfiguration.WalletLocation = _walletPath;
        }

        private OracleConnection GetConnection()
        {
            return new OracleConnection(BuildConnectionString());
        }
        // ── SELECT ───────────────────────────────────────────────────
        public DataTable Select(string query, OracleParameter[]? parametros = null)
        {
            using var conn = GetConnection();
            using var cmd = new OracleCommand(query, conn);

            if (parametros != null)
                cmd.Parameters.AddRange(parametros);

            conn.Open();
            var tabla = new DataTable();
            using var adapter = new OracleDataAdapter(cmd);
            adapter.Fill(tabla);
            return tabla;
        }

        // ── INSERT / UPDATE / DELETE ─────────────────────────────────
        public int Ejecutar(string query, OracleParameter[]? parametros = null)
        {
            using var conn = GetConnection();
            using var cmd = new OracleCommand(query, conn);

            if (parametros != null)
                cmd.Parameters.AddRange(parametros);

            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public bool ProbarConexion(out string mensaje)
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();
                using var cmd = new OracleCommand("SELECT 'OK' FROM dual", conn);
                cmd.ExecuteScalar();
                mensaje = $" Conexión exitosa — Oracle {conn.ServerVersion}";
                return true;
            }
            catch (OracleException ex)
            {
                mensaje = $" Error Oracle ({ex.Number}): {ex.Message}";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = $"Error general: {ex.Message}";
                return false;
            }
        }
    }
}
