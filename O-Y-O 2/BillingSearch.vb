Imports System.Data.SqlClient
Public Class BillingSearch
    Private Sub BillingSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectPatientDB() ' connecting Patient Database
        LoadintoSearchID() 'loading the combobox
    End Sub

    'loadintosearch function
    Private Sub LoadintoSearchID()
        'this function loads all the patients ID registered within the system
        Dim cmd As New SqlCommand
        Dim sqlreader As SqlDataReader
        Try
            cmd.Connection = PatientSQLConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * From PatientInformation"
            sqlreader = cmd.ExecuteReader
            sqlreader.Read()
            'reading the rows
            If sqlreader.HasRows Then
                'loading the combobox with all the available Patient ID
                Do While sqlreader.Read()
                    PatientSearchComboBox.Items.Add(sqlreader.GetString(0))
                Loop
                sqlreader.Close()
            Else
                MessageBox.Show("Error Found! Please check your connection to dataset!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                MainForm.Show()
                sqlreader.Close()
            End If
            sqlreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'shows the patient Detail
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Patient_Detail.Show()
    End Sub

    'searching if the patient is pre-registered or not
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        Dim sqlreader As SqlDataReader
        Dim searchId As String = PatientSearchComboBox.Text
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = PatientSQLConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * From PatientInformation Where [Patient ID]='" & searchId & "'"
            sqlreader = cmd.ExecuteReader
            sqlreader.Read()
            'reading the rows
            If sqlreader.HasRows Then
                sqlreader.Close()
                patientInformation(searchId) ' calling patientInformation function
                AppointmentInformation(searchId) ' calling appointmentInformation function
                BillingForm.Show() ' showing the billing form
            ElseIf PatientSearchComboBox.Text.Trim.Length = 0 Then
                MessageBox.Show("Please Enter the Patient ID to search!", "Search ID Empty!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                sqlreader.Close()
            Else
                MessageBox.Show("Patient does not exist! Please register patient first", "Patient not found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                sqlreader.Close()
                Me.Close()
                MainForm.Show()
            End If
            sqlreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Close()
        End Try
    End Sub

    'patientInformation function
    Private Sub patientInformation(searchID As String)
        'searching into patient information to print the bill
        Dim sqlreader As SqlDataReader
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = PatientSQLConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * From PatientInformation Where [Patient ID]='" & searchID & "'"
            sqlreader = cmd.ExecuteReader
            sqlreader.Read()
            'reading rows from the PatientInformation table
            If sqlreader.HasRows Then
                'if the patient exists, pass patients ID, name, owne, address and contact number to the billing form
                BillingForm.Patient_IDTextBox.Text = sqlreader.GetString(0)
                BillingForm.Animal_NameTextBox.Text = sqlreader.GetString(1)
                BillingForm.The_OwnerTextBox.Text = sqlreader.GetString(6)
                BillingForm.AddressTextBox.Text = sqlreader.GetString(7)
                BillingForm.Contact_NumberTextBox.Text = "(" + sqlreader.GetString(8) + ") - " + sqlreader.GetString(9)
                sqlreader.Close()
            Else
                sqlreader.Close()
                MessageBox.Show("Error Found! Please check your connection to dataset!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
        End Try

    End Sub

    'AppointmentInformation function
    Private Sub AppointmentInformation(searchID As String)
        'searching appointment Information speciallt time and date of the appointment to print in the bill
        Dim sqlreader As SqlDataReader
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = PatientSQLConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * From Appointment Where [Patient ID]='" & searchId & "'"
            sqlreader = cmd.ExecuteReader
            sqlreader.Read()
            'reading the rows
            If sqlreader.HasRows Then
                'if patient ID found, passing the patient appointment date and time for the billing purpose
                BillingForm.DateLabel.Text = sqlreader.GetString(3)
                BillingForm.TimeLabel.Text = sqlreader.GetString(4)
                sqlreader.Close()
            Else
                'if not found passinf "n/a" to both the time and date because the patient might be registered but not have anny appointment date
                BillingForm.DateLabel.Text = "N/A"
                BillingForm.TimeLabel.Text = "N/A"
                sqlreader.Close()
            End If
            sqlreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class