
'Project: O-Y-O 2: Extending the Initial VET-Clinic System

'Date: Monday, November 28, 2016

'Programmer: Manoj Ghimire

'Description: This programs allows the user to register new patient into the system
'schedule an appointment and re-schedule if needed by updating the existing appointment time and date
'stores all the patient details and appointment schedule on the database
'for data handling and error checking, only the patient who are registered will benefit the services
' Patient must be, first  rgistered, then only can schedule an appointment or be provided with other services
'Billing is done based on the service provides that can be printed

'Folder: O-Y-O Choice A- Part 2

Public Class MainForm
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        PatientRegistrationForm.Show()

    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As EventArgs) Handles Me.FormClosed
        'closing the database while closing the form
        Try
            If PatientConnectionOpen Then DisconnectDB()
        Catch ex As Exception
            MessageBox.Show("The Database cannot be closed!.", "SQL COSING ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'show appointment form
    Private Sub AppointmentButton_Click(sender As Object, e As EventArgs) Handles AppointmentButton.Click
        AppointmentForm.Show()
    End Sub

    'this function will ask if the user want to bill the existing customer if yes then it will ask to search the patient in the database
    'Else the information for the patient and the owner is passed as N/A meaning that they are not registered!
    Private Sub BillingButton_Click(sender As Object, e As EventArgs) Handles BillingButton.Click

        Dim message As DialogResult = MessageBox.Show("All the Patients must be registered in order to benefit from our service! Would you like to bill Pre-Existing User?", "Billing", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If message = DialogResult.Yes Then
            BillingSearch.Show()
        Else
            'patient needed to be registered
            MessageBox.Show("All the new patients must be registered first in order to benefit from our service!", "Patient Registration Required!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            PatientRegistrationForm.Show()

        End If

    End Sub
    'exit the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'show about form
    Private Sub About_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        About.Show()
    End Sub

    'connect to database
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectPatientDB()
    End Sub
End Class