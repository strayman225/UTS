Imports System
Imports System.Data
Imports Npgsql
Module DbConnection
    Public con As New NpgsqlConnection
    Public da As New NpgsqlDataAdapter
    Public cmd As New NpgsqlCommand


    Sub doConnect()

        con.ConnectionString = "Host=arjuna.db.elephantsql.com;Database=jdkqojor;Username=jdkqojor;Password=eJBm3clawOsDBIda92Iwx3ORApGox6fG"
        cmd.Connection = con
    End Sub
End Module
