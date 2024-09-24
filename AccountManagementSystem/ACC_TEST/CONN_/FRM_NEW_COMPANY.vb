Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class FRM_NEW_COMPANY
    Public ISOK As Boolean = False
    Dim CLS_CONN_SERVER_ As New CLS_CONN_SERVER
    Dim CLS_CON_CONFIG_ As New CLS_CON_CONFIG
    Dim STR____ As String
    Private Sub FRM_NEW_COMPANY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        Try
            If TXT_NEWDATA.Text = Nothing Then
                MessageBox.Show(" يجب ادخال اسم data", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            '--------------------------------------------------------------------
            If TXT_COMPANY.Text = Nothing Then
                MessageBox.Show("  يجب ادخال اسم الشركة الجديدة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            '--------------------------------------------------------------------
           
            CONN_SERVER()
            '--------------------------------------------------------------------
          
            CREATE_TB_NEWDATAG()
            '--------------------------------------------------------------------
            If TXT_CON___CONFIG = Nothing Then
                CREATE_TB_NEWDAT_CONFIG()
           
            End If
            ADD_DATA_CONFIG()
            '--------------------------------------------------------------------
            ISOK = True
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("يجب التاكد من اعدادات الاتصال ب sql للاستفسار yosefhadad0@gmail.com")
        End Try

    End Sub
    Sub CONN_SERVER()

        Dim STR_Con_SERVER As String
        If chkWindowsAuthentication.Checked = False Then
            STR_Con_SERVER = "Data Source=" & Trim(TXT_server.Text) & ";User ID=" & Trim(txtLogin.Text) & ";password=" & Trim(txtPassword.Text) & ";Integrated Security=false"

        Else
            STR_Con_SERVER = " Data Source=" & Trim(TXT_server.Text) & ";Integrated Security=True"
        End If

        File.WriteAllText("c:\CONN\CONN_SERVER.TXT", STR_Con_SERVER)
    End Sub
    Sub CREATE_TB_NEWDATAG()
        CLS_CONN_SERVER_.ADD_DATABASE(TXT_NEWDATA.Text)
        CLS_CONN_SERVER_.ADD_DATABASE_SINGLE_USER(TXT_NEWDATA.Text)
        CLS_CONN_SERVER_.DATABASE_Arabic1(TXT_NEWDATA.Text)
        CLS_CONN_SERVER_.DATABASE_Arabic2(TXT_NEWDATA.Text)
        Dim CON_____ As String
        If (chkWindowsAuthentication.Checked = True) Then
            CON_____ = " Data Source=" + (TXT_server.Text) + ";Initial Catalog=" + (TXT_NEWDATA.Text) + ";Integrated Security=True"
        Else
            CON_____ = "Data Source=" + (TXT_server.Text) + ";Initial Catalog=" + (TXT_NEWDATA.Text) + ";User ID=" + (txtLogin.Text) + ";password=" + (txtPassword.Text) + ";Integrated Security=false"
        End If
        STR____ = CON_____
        File.WriteAllText("c:\CONN\conn.TXT", CON_____)
        Dim Con_1 As New SqlConnection(File.ReadAllText("c:\CONN\conn.TXT"))

        If (Con_1.State = ConnectionState.Open) Then
            Con_1.Close()
        End If

        Con_1.Open()
        Dim script As String = File.ReadAllText("c:\CONN\DATA.sql")
        Dim commandStrings As IEnumerable(Of String) = Regex.Split(script, "^\s*GO\s*$", (RegexOptions.Multiline Or RegexOptions.IgnoreCase))
        For Each commandString As String In commandStrings
            If (commandString.Trim <> "") Then
                Dim command = New SqlCommand(commandString, Con_1)
                command.ExecuteNonQuery()
            End If

        Next

        Con_1.Close()



    End Sub
   
    Sub CREATE_TB_NEWDAT_CONFIG()
        Dim NAME_DATABASE As String = "A_CONFIG"
        CLS_CONN_SERVER_.ADD_DATABASE(NAME_DATABASE)
        CLS_CONN_SERVER_.ADD_DATABASE_SINGLE_USER(NAME_DATABASE)
        CLS_CONN_SERVER_.DATABASE_Arabic1(NAME_DATABASE)
        CLS_CONN_SERVER_.DATABASE_Arabic2(NAME_DATABASE)
        Dim CON_____ As String
        If (chkWindowsAuthentication.Checked = True) Then
            CON_____ = " Data Source=" + (TXT_server.Text) + ";Initial Catalog=" + (NAME_DATABASE) + ";Integrated Security=True"
        Else
            CON_____ = "Data Source=" + (TXT_server.Text) + ";Initial Catalog=" + (NAME_DATABASE) + ";User ID=" + (txtLogin.Text) + ";password=" + (txtPassword.Text) + ";Integrated Security=false"
        End If
        File.WriteAllText("c:\CONN\CONFIG.TXT", CON_____)

        '--------------------------------------------------------------------------------------

        Dim Con_1 As New SqlConnection(File.ReadAllText("c:\CONN\CONFIG.TXT"))

        If (Con_1.State = ConnectionState.Open) Then
            Con_1.Close()
        End If

        Con_1.Open()
        Dim script As String = File.ReadAllText("c:\CONN\DATA_CONFIG.sql")
        Dim commandStrings As IEnumerable(Of String) = Regex.Split(script, "^\s*GO\s*$", (RegexOptions.Multiline Or RegexOptions.IgnoreCase))
        For Each commandString As String In commandStrings
            If (commandString.Trim <> "") Then
                Dim command = New SqlCommand(commandString, Con_1)
                command.ExecuteNonQuery()
            End If

        Next

        Con_1.Close()



    End Sub
    Sub ADD_DATA_CONFIG()
        Dim Con_1 As New SqlConnection(File.ReadAllText("c:\CONN\CONFIG.TXT"))

        If (Con_1.State = ConnectionState.Open) Then
            Con_1.Close()
        End If

        Con_1.Open()

        Dim TXT_ As String = File.ReadAllText("c:\CONN\CONFIG.TXT")
        '"INSERT INTO STORE(NAME,guid_user,PARENT_GUID)VALUES('" & NAME & "','" & guid_user & "','" & PARENT_GUID & "')"

        Dim INSERT__ As String = "INSERT INTO COMPANY(Name,DataBasee,CONN)values('" & TXT_COMPANY.Text & "','" & TXT_NEWDATA.Text & "','" & STR____ & "')"

        'Dim INSERT__ As String = "insert into COMPANY(Name,DataBasee,CONN)values('" & TXT_COMPANY.Text & "','" & TXT_NEWDATA.Text & "','" & TXT_ & "')"
        Dim cmd As New SqlCommand(INSERT__, Con_1)
        cmd.ExecuteNonQuery()

        Con_1.Close()


        'CLS_CON_CONFIG_.ADD_(TXT_COMPANY.Text, TXT_NEWDATA.Text, TXT_)
        ''
        'Dim TXT_ As String = "T"
        ''"INSERT INTO STORE(NAME,guid_user,PARENT_GUID)VALUES('" & NAME & "','" & guid_user & "','" & PARENT_GUID & "')"

        'Dim INSERT__ As String = "INSERT INTO COMPANY(Name,DataBasee,CONN)values('" & TXT_COMPANY.Text & "','" & TXT_NEWDATA.Text & "','" & TXT_ & "')"

        ''Dim INSERT__ As String = "insert into COMPANY(Name,DataBasee,CONN)values('" & TXT_COMPANY.Text & "','" & TXT_NEWDATA.Text & "','" & TXT_ & "')"

        'If CON_CONFIG.State = ConnectionState.Open Then
        '    CON_CONFIG.Close()
        'End If
        'CON_CONFIG.Open()

        'Dim cmd As New SqlCommand(INSERT__, CON_CONFIG)

        'cmd.ExecuteNonQuery()
        'CON_CONFIG.Close()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Close()
    End Sub
End Class