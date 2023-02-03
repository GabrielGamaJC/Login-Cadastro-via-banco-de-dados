'import MySql.Data.dll
Imports MySql.Data.MySqlClient

Module ModCon
    'MySQL Connection
    'Variale con, dr and cmd
    Public con As New MySqlConnection("Data source= localhost;userid = root;password=;database=tutorial_login")
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand


    Private ico As Icon
    Private customCursor As Cursor
    ''' <summary>
    ''' 1=load, 2=save, 3=wait, 4=compute
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <param name="cursorType"></param>
    ''' <remarks></remarks>
    Public Sub customCursorLOGIN(frm As Form, cursorType As Integer)
        'Create the custom cursor from a bitmap:

        Select Case cursorType
            Case 1
                Dim bmp As New Bitmap(My.Resources.LOADING)
                ico = Icon.FromHandle(bmp.GetHicon)
                'Case 2
                '    Dim bmp As New Bitmap(My.Resources.LoadCursor)
                '    ico = Icon.FromHandle(bmp.GetHicon)
                'Case 3
                '    Dim bmp As New Bitmap(My.Resources.DTRWait_Cursor)
                '    ico = Icon.FromHandle(bmp.GetHicon)
                'Case 4
                '    Dim bmp As New Bitmap(My.Resources.DTRCompute_Cursor)
                '    ico = Icon.FromHandle(bmp.GetHicon)
        End Select

        customCursor = New Cursor(ico.Handle)
        frm.Cursor = customCursor
    End Sub
End Module
