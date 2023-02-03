'import MySql.Data.dll
Imports MySql.Data.MySqlClient
Imports Mysqlx

Module ModCon
    'MySQL Connection
    'Variale con, dr and cmd
    Public con As New MySqlConnection("Data source=db4free.net;userid=userbancodedados;password=senhabancodedados;database=tabela")
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
    Public objconn As New MySqlConnection
    Public objcmd As New MySqlCommand




End Module
