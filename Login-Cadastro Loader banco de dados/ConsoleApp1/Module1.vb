Imports System.IO
Imports System.Security.Principal
Imports System.Net
'Imports System.IO.Compression
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Management
Imports Ionic
Imports Ionic.Zip
Imports System.Timers
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
'Creditos Gabriel Gama https://github.com/GabrielGamaJC/
Module Module1
    Public HDVIP As String


    Public Function incial()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("==============================================================================================================")
        Console.WriteLine("                                                                                     
                                                                                         
 ██████   █████  ███    ███  █████      ██       ██████   █████  ██████  ███████ ██████  
██       ██   ██ ████  ████ ██   ██     ██      ██    ██ ██   ██ ██   ██ ██      ██   ██ 
██   ███ ███████ ██ ████ ██ ███████     ██      ██    ██ ███████ ██   ██ █████   ██████  
██    ██ ██   ██ ██  ██  ██ ██   ██     ██      ██    ██ ██   ██ ██   ██ ██      ██   ██ 
 ██████  ██   ██ ██      ██ ██   ██     ███████  ██████  ██   ██ ██████  ███████ ██   ██ 
                                                                                         
                                                                                         ")
        Console.WriteLine("==============================================================================================================")
        Console.ForegroundColor = ConsoleColor.White
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("==== BEM VINDO AO GAMA LOADER ========")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(" Informações Da Maquina: {0}", Environment.MachineName)
        Console.WriteLine(" Informações Do Usuario: {0}", Environment.UserName)
        Console.Write(" HDWID PC: ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("{0}", HDVIP)
        'Console.WriteLine("AGJCFBFF111496D4")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write(" Status Loader: ")

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("ONLINE")
        Console.ForegroundColor = ConsoleColor.White

        '  Console.WriteLine(" Memoria disponivel: {0}", My.Computer.Info.AvailableVirtualMemory)

        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("=========================================")
        Console.ForegroundColor = ConsoleColor.White
    End Function

    Public Function funcao()
        '  Console.WriteLine()
        '  Console.WriteLine(" Carregando requisitos....")
        Console.WriteLine()
        ' Console.WriteLine(" Pressione qualquer tecla para continuar...")
        '  Console.ReadKey()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(" ")
        Console.Write(" Inicializando Loader - ")
        Console.Write(" ")
        Console.ForegroundColor = ConsoleColor.Green
        Using bar = New ProgressBar
            For i = 0 To 100
                bar.Report(i / 100)


                Thread.Sleep(40)
            Next
        End Using
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("==========")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write(" LOADER LIBERADO ")

        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("==========")
        Console.ForegroundColor = ConsoleColor.White

        'Console.Write(" Status Loader: ")
        'If stts = "ONLINE" Then
        '    Console.ForegroundColor = ConsoleColor.Green
        'Else
        '    Console.ForegroundColor = ConsoleColor.Red
        'End If
        'Console.WriteLine("{0}", stts)
        ' Console.ForegroundColor = ConsoleColor.White
        ' Console.ForegroundColor = ConsoleColor.Blue
        ' Console.WriteLine("=========================================")
        'Console.ForegroundColor = ConsoleColor.White
        Console.Clear()
        'incial()
    End Function


    Sub Main()

        Dim HWID As String = String.Empty
        Dim mcl As New ManagementClass("win32_processor")
        Dim MOBC As ManagementObjectCollection = mcl.GetInstances()

        For Each mob As ManagementObject In MOBC
            If HWID = "" Then
                HWID = mob.Properties("processorID").Value.ToString()
                Exit For
            End If

        Next
        HDVIP = HWID

        ' My.Computer.Info.AvailableVirtualMemory

        funcao()
        incial()
        menu(1, "Login")
        menu(2, "Cadastro")
        Console.Write(" Digite a opçao desejada: ")
        Dim op As String = Console.ReadLine()
        Try
            If op = 1 Then
                login()
                Console.ReadKey()
            ElseIf op = 2 Then
                cadastro()
                Console.ReadKey()
            Else
                Console.Write(" [OPÇÃO INVALIDA] ")
            End If

        Catch ex As Exception
            End
        End Try

        ' If 




    End Sub

    Public Function menu(ByVal numero As String, ByVal texto As String)
        Console.Write(" [ ")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write(numero)
        Console.ForegroundColor = ConsoleColor.White
        Console.Write(" ] - " + texto)
        Console.WriteLine("")
    End Function
    Public Function cadastro()
        Console.Write(" Usuario: ")
        Dim user As String = Console.ReadLine()
        ' Console.WriteLine("")
        Console.Write(" Senha: ")
        Console.ForegroundColor = ConsoleColor.Black
        Dim senha As String = Console.ReadLine()
        Console.WriteLine("")
        If Trim(User) = "" Or Trim(senha) = "" Then
            MsgBox("Informe as suas credenciais para cadastro!", vbExclamation, "Dados Inválidos !")
        Else
            objconn = New MySql.Data.MySqlClient.MySqlConnection
            objconn.ConnectionString = "server=db4free.net;" & "user id=idbancodedados;" & "password=senhabancodedados;" & "database=tabeladbd"
            objconn.Open()


            Try

                objcmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO usuarios(usuario, senha) VALUES (@field1, @field2)", objconn)
                With objcmd

                    .Parameters.AddWithValue("@field1", user)
                    .Parameters.AddWithValue("@field2", senha)



                End With
                objcmd.ExecuteNonQuery()
                objcmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)

            End Try

            Console.ForegroundColor = ConsoleColor.White
            WriteLine("Cadastro realizado com sucesso!")
            Console.ReadKey()
        End If
    End Function
    Public Function login()
        Console.Write(" Usuario: ")
        Dim user As String = Console.ReadLine()
        ' Console.WriteLine("")
        Console.Write(" Senha: ")
        Console.ForegroundColor = ConsoleColor.Black
        Dim senha As String = Console.ReadLine()
        Console.WriteLine("")
        If Trim(user) = "" Or Trim(senha) = "" Then
            MsgBox("Informe as suas credenciais para Login!", vbExclamation, "Dados Inválidos !")
        Else
            con.Open()
            Dim sql = "SELECT * FROM usuarios WHERE usuario = '" & user & "' AND senha = '" & senha & "'"
            Dim cmd = New MySqlCommand(sql, con)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            Try
                If dr.Read = False Then
                    WriteLine("Login Falhou!")
                    user = ""
                    senha = ""

                Else
                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine("Login realizado com Sucesso")
                    Console.ReadKey()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End If
    End Function

End Module
