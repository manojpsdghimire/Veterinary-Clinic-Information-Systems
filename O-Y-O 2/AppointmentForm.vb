Imports System.Data.SqlClient
Public Class AppointmentForm
    'closing the form
    Private Sub CancelAppointmentButton_Click(sender As Object, e As EventArgs) Handles CancelAppointmentButton.Click
        'closing the form
        Me.Close()
    End Sub

    'this function will clear all the information when called
    Private Sub clear()
        'this function clears all the texboxes in this form
        Patient_IDTextBox.Clear()
        Animal_NameTextBox.Clear()
        The_OwnerTextBox.Clear()
        Appointment_DateMaskedTextBox.Clear()
        Appointment_TimeMaskedTextBox.Clear()
    End Sub

    Private Sub PatientInformationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PatientInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatientInformationDataSet)

    End Sub
    Private Sub AppointmentForm_FormClosed(sender As Object, e As EventArgs) Handles Me.FormClosed
        'closing the database while closing the form
        'Try
        '    If PatientConnectionOpen Then DisconnectDB() ' checking if the connection is open, if so closing the connection
        'Catch ex As Exception
        '    MessageBox.Show("The Database cannot be closed!.", "SQL COSING ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        clear() ' calling clear function
    End Sub

    Private Sub AppointmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientInformationDataSet1.Appointment' table. You can move, or remove it, as needed.
        ' Me.AppointmentTableAdapter.Fill(Me.PatientInformationDataSet1.Appointment)
        'ConnectPatientDB() ' connecting Patient Database
        LoadintoSearchID() 'calling the loadintosearch function to load the combobox box with all the Patient ID registered 
    End Sub

    'searchButton click function
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        'This function will check if the patient is registered to the system or not. If not, it will ask the user to register the patient before scheduling an appointment.
        Dim sqlreader As SqlDataReader
        Dim searchId As String = PatientSearchComboBox.Text
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = PatientSQLConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * From PatientInformation Where [Patient ID]='" & searchId & "'"
            sqlreader = cmd.ExecuteReader
            sqlreader.Read()
            'reading the rows of the table
            If sqlreader.HasRows Then
                sqlreader.Close()
                'calling checkappointmentlist function
                CheckAppointmentList(searchId)
            ElseIf searchID.Trim.Length = 0 Then 'checking if the value entered is nothing 
                MessageBox.Show("Please enter the patient ID", "Patient ID not Entered!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Patient does not exist! Please register patient first", "Patient not found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.Hide()
            End If
            sqlreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'Check AppointmentList FUnction
    Private Sub CheckAppointmentList(searchId As String)

        'this search for the patientId with in the Appointment Table
        'If the patient exists, the will through a message to aske the user if they want to reschedule or updade the current appointment
        'if Yes, updateappointment schedule function passing the patient Id, and If NO, closes the form
        'if the patientId is not found in the Appointment Table then calls the appointment function to schedule new appointment.

        Dim sqlreader As SqlDataReader
        Dim cmd As New SqlCommand

        Try
            cmd.Connection = PatientSQLConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * From Appointment Where [Patient ID]='" & searchId & "'"
            sqlreader = cmd.ExecuteReader
            sqlreader.Read()
            If sqlreader.HasRows Then
                sqlreader.Close()
                'if found ask if they want to update the appointment status
                Dim infoschedule As String = "This patient has already been scheduled. Would you like to reschedule or delete the appointment?"
                Dim message As DialogResult = MessageBox.Show(infoschedule, "Reschedule or Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If message = DialogResult.Yes Then
                    'MsgBox("update")
                    updateappointment(searchId)
                Else
                    Me.Hide()
                End If

            Else
                sqlreader.Close()
                'not found, schedule appointment
                Scheduleappointment(searchId)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'update appointment function
    Private Sub updateappointment(searchID As String)
        'this function will pass the patient appointment schedule from the appointment table so that it can be rescheduled.
        'loads all the data from the appointement Table if the patient ID exists in the table
        'enable delete and update button to visible status
        'MsgBox("scheduling appointment")
        Dim sqlreader As SqlDataReader
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = PatientSQLConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * From Appointment Where [Patient ID]='" & searchID & "'"
            sqlreader = cmd.ExecuteReader
            sqlreader.Read()
            If sqlreader.HasRows Then

                Patient_IDTextBox.Text = sqlreader.GetString(0)
                Animal_NameTextBox.Text = sqlreader.GetString(1)
                The_OwnerTextBox.Text = sqlreader.GetString(2)
                Appointment_DateMaskedTextBox.Text = sqlreader.GetString(4)
                Appointment_TimeMaskedTextBox.Text = sqlreader.GetString(3)
                UpdateButton.Visible = True
                DeleteButton.Visible = True
                AppointmentSubmitButton.Visible = False
                PatientSearchComboBox.Visible = False
                SearchButton.Visible = False
                GroupBox1.Visible = True
                searchPatientLabel.Visible = False
                LinkLabel1.Visible = False
                sqlreader.Close()
            Else
                sqlreader.Close()
                MessageBox.Show("Error Found! Please check your connection to dataset!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ' SearchPatientTextBox.Clear()
        End Try
    End Sub


    'scheduleappointment functions
    Private Sub Scheduleappointment(searchID As String)
        'This function will pass the patient information from the PatientInformation table for appointment scheduling purpose. 
        'if error occured, throws a message that the connection lost or not found
        ' MsgBox("scheduling appointment")
        Dim sqlreader As SqlDataReader
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = PatientSQLConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * From PatientInformation Where [Patient ID]='" & searchID & "'"
            sqlreader = cmd.ExecuteReader
            sqlreader.Read()
            If sqlreader.HasRows Then
                'loading the information to all the textboxes in the appointment schedule form based on the PatientID
                Patient_IDTextBox.Text = sqlreader.GetString(0)
                Animal_NameTextBox.Text = sqlreader.GetString(1)
                The_OwnerTextBox.Text = sqlreader.GetString(6)
                PatientSearchComboBox.Visible = False
                SearchButton.Visible = False
                GroupBox1.Visible = True
                AppointmentSubmitButton.Visible = True
                searchPatientLabel.Visible = False
                LinkLabel1.Visible = False
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

    'This function will schedule new appointment to the patients that are already registered and save the information into Appointment data table.
    Private Sub AppointmentSubmitButton_Click(sender As Object, e As EventArgs) Handles AppointmentSubmitButton.Click
        Dim clear As Boolean = False
        Try
            'adding information to the Appointment Table
            Dim patient_id, patient_name, the_owner, appointed_date, apponted_time As String
            patient_id = Patient_IDTextBox.Text
            patient_name = Animal_NameTextBox.Text
            the_owner = The_OwnerTextBox.Text
            appointed_date = Appointment_DateMaskedTextBox.Text
            apponted_time = Appointment_TimeMaskedTextBox.Text
            'inserting schedule information into the appointment table
            Dim PatientAppointmentCmd As New SqlCommand("INSERT INTO Appointment ([Patient ID], [Animal Name], [The Owner], [Appointment Date], [Appointment Time]) VALUES ('" & patient_id & "' , '" & patient_name & "' ,'" & the_owner & "','" & appointed_date & "','" & apponted_time & "');", PatientSQLConnection)
            Dim message As String = "The appointment for Patient ID " + Patient_IDTextBox.Text + " has been successfully appointed! " & Environment.NewLine & "Appointment!" & Environment.NewLine & "Appointment Date: " + Appointment_DateMaskedTextBox.Text & Environment.NewLine & "Appointment Time: " + Appointment_TimeMaskedTextBox.Text
            MessageBox.Show(message, "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PatientAppointmentCmd.ExecuteNonQuery()
            Me.Close()
            clear = True ' setting clear to true
        Catch ex As Exception
            MessageBox.Show("Make sure the Appointment date and time is not set to the current date and current time. ", "Date and Time appointment error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        If clear = True Then
            'clear all the textbox and close 
            Patient_IDTextBox.Clear()
            Animal_NameTextBox.Clear()
            The_OwnerTextBox.Clear()
            Me.Hide()
        End If

    End Sub

    Private Sub PatientInformationBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PatientInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatientInformationDataSet)

    End Sub

    'this function will update the scheduled patient schedule information
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'when clicked update button, the appointment schedule is updated
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = PatientSQLConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Update Appointment set [Animal Name]='" & Animal_NameTextBox.Text & "' , [Appointment Date ]='" & Appointment_DateMaskedTextBox.Text & "' , [Appointment Time]='" & Appointment_TimeMaskedTextBox.Text & "' where [Patient ID]='" & Patient_IDTextBox.Text & "'"
            Dim message As String = "The appointment for Patient ID " + Patient_IDTextBox.Text + " has been successfully Updated! " & Environment.NewLine & "New Appointment!" & Environment.NewLine & "Appointment Date: " + Appointment_DateMaskedTextBox.Text & Environment.NewLine & "Appointment Time: " + Appointment_TimeMaskedTextBox.Text
            MessageBox.Show(message, "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            clear()
            Me.Close()
        End Try
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Patient_Detail.Show()   'this is the link to the patient detail table for user to look into the patient registered database
    End Sub

    'this function loads all the patients ID registered within the system
    Private Sub LoadintoSearchID()
        'this function loads all the patient ID into the combo box when called 
        Dim cmd As New SqlCommand
        Dim sqlreader As SqlDataReader

        Try
            cmd.Connection = PatientSQLConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * From PatientInformation"
            sqlreader = cmd.ExecuteReader
            sqlreader.Read()
            'reading the rows and if it has rows loading up the patientID
            If sqlreader.HasRows Then
                'loading all the ID 
                Do While sqlreader.Read()
                    PatientSearchComboBox.Items.Add(sqlreader.GetString(0)) 'just getting the ID
                Loop
                sqlreader.Close()
            Else
                MessageBox.Show("Error Found! Please check your connection to dataset!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Hide()
                sqlreader.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'deleting the patient appointment 
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        'deletes the appointment scheduled date when clicked on the delete button
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = PatientSQLConnection
            cmd.CommandType = CommandType.Text
            'displaying the delete message
            Dim message As String = "The appointment for Patient ID " + Patient_IDTextBox.Text + " has been successfully deleted! "
            MessageBox.Show(message, "Delete successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'deleting the appointment scheduled
            cmd.CommandText = "Delete From Appointment where [Patient ID]='" & Patient_IDTextBox.Text & "'"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            clear()
            Me.Close()
        End Try
    End Sub
End Class
