Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module PatientInformationModule
    'connecting the database
    Public PatientSQLConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CSC 205\CSC 205\O-Y-O Choice A- Part 2\O-Y-O 2\PatientInformation.mdf;Integrated Security=True")
    Public PatientSQLCommand As SqlCommand
    Public PatientConnectionOpen As Boolean = False

    Sub ConnectPatientDB()
        Try
            'checking whether the database is open and ready to be executed or not.
            PatientSQLConnection.Open()
            PatientConnectionOpen = True
        Catch ex As Exception
            ' MessageBox.Show("The Database used to store the Patient's Detail is not available.", "SQL CONNECTION ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub DisconnectDB()
        If PatientConnectionOpen Then PatientSQLConnection.Close()
    End Sub
End Module
