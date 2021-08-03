using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace RR
{
    public class ConectarEColonizar
    {
        private string sLocal = "Data Source = DESKTOP-EP24QQ1\\SQLEXPRESS; DataBase = DbEquipas; User Id = sa; Password = 123.abc;";
        private string sRemota = "Data Source=89.154.160.208,62444; database=DbLey; User ID=sa; Password=123.Abc.@;";

        private DataTable ExecutarConsulta(string strSQL)
        {
            //criar uma conexão:
            SqlConnection C = new SqlConnection(sLocal);
            C.Open();
            //criar comando SQL para extrair os dados pretendidos:
            SqlCommand command = C.CreateCommand();
            command.CommandText = strSQL;

            //trazer os dados da tabela especificada para uma "tabela" em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);

            //desligar a conexão:
            C.Close();
            return dt;
        }

        public void RecolonizarTabelaDeEquipas()
        {
            string strSQL = "delete from Equipas;" +
                "dbcc checkident(Equipas, reseed, 0);" +
                "USE [DbEquipas]; SET IDENTITY_INSERT[dbo].[Equipas] ON;" +
                "INSERT[dbo].[Equipas]([Id], [NomeEquipa]) VALUES(1, N'Falcões de Picoto');" +
                "INSERT[dbo].[Equipas]([Id], [NomeEquipa]) VALUES(2, N'Arsenal da Devesa');" +
                "INSERT[dbo].[Equipas]([Id], [NomeEquipa]) VALUES(3, N'Ases de Fraião');" +
                "INSERT[dbo].[Equipas]([Id], [NomeEquipa]) VALUES(4, N'Leões da Tecla');" +
                "INSERT[dbo].[Equipas]([Id], [NomeEquipa]) VALUES(5, N'Maximinense');" +
                "SET IDENTITY_INSERT[dbo].[Equipas] OFF;"
                ;
            ExecutarConsulta(strSQL);
        }
        public void RecolonizarTabelaDeMembros()
        {
            string strSQL = "delete from Membroes;" +
                "dbcc checkident(Membroes, reseed, 0);" +
                "SET IDENTITY_INSERT [dbo].[Membroes] ON;" +
                "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES(1, N'Carlinhos', 1);" +
                "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES(2, N'Afonsinho', 1);" +
                "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES(3, N'Abel', 2);" +
                "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES(4, N'Ana', 1);" +
                "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES(5, N'Arlindo', 4);" +
                "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES(6, N'Rosa', 1);" +
                "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES(7, N'Adriano', 4);" +
                "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES(8, N'António', 4);" +
                "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES(9, N'Alexandre', 4);" +
                "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES(10, N'Amélia', 4);" +
                "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES(11, N'Sandra', 5);" +
                "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES(12, N'Teresa', 4);" +
                "SET IDENTITY_INSERT[dbo].[Membroes] OFF;"
                ;
            ExecutarConsulta(strSQL);
        }
    }
}




