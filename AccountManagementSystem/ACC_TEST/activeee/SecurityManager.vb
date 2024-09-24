Imports System.Management

Class SecurityManager
    Public Function GetSerial() As Double
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" & _
            "{impersonationLevel=impersonate}!\\" & _
            computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from Win32_Processor")
        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids = cpu_ids.Substring(2)
        '-----------------------------------------------------------------------------

        Dim sum As Long = 0

        Dim index As Integer = 1

        For Each ch As Char In cpu_ids
            If Char.IsDigit(ch) Then
                sum += sum + Integer.Parse(ch) * (index * 230)
            ElseIf Char.IsLetter(ch) Then
                Select Case ch.ToString.ToUpper
                    Case "A"
                        sum += sum + 10 * (index * 25)
                    Case "B"
                        sum += sum + 11 * (index * 25)
                    Case "C"
                        sum += sum + 12 * (index * 25)
                    Case "D"
                        sum += sum + 13 * (index * 25)
                    Case "E"
                        sum += sum + 14 * (index * 25)
                    Case "F"
                        sum += sum + 15 * (index * 25)
                    Case "G"
                        sum += sum + 16 * (index * 25)
                    Case "H"
                        sum += sum + 17 * (index * 25)
                    Case "I"
                        sum += sum + 18 * (index * 25)
                    Case "J"
                        sum += sum + 19 * (index * 25)
                    Case "K"
                        sum += sum + 20 * (index * 25)
                    Case "L"
                        sum += sum + 21 * (index * 25)
                    Case "M"
                        sum += sum + 22 * (index * 25)
                    Case "N"
                        sum += sum + 23 * (index * 25)
                    Case "O"
                        sum += sum + 24 * (index * 25)
                    Case "P"
                        sum += sum + 25 * (index * 25)
                    Case "Q"
                        sum += sum + 26 * (index * 25)
                    Case "R"
                        sum += sum + 27 * (index * 25)
                    Case "S"
                        sum += sum + 28 * (index * 25)
                    Case "T"
                        sum += sum + 29 * (index * 25)
                    Case "U"
                        sum += sum + 30 * (index * 25)
                    Case "V"
                        sum += sum + 31 * (index * 25)
                    Case "W"
                        sum += sum + 32 * (index * 25)
                    Case "X"
                        sum += sum + 33 * (index * 25)
                    Case "Y"
                        sum += sum + 34 * (index * 25)
                    Case "Z"
                        sum += sum + 35 * (index * 25)
                End Select
            End If
            index += 1
        Next
        Return sum
    End Function

    Public Function CheckKey(sreial As Double) As Double
        Dim x As Long = sreial
        Dim y As Long = x * 25 + 53 / x * (x / 4) * 123658

        Return y
    End Function

End Class