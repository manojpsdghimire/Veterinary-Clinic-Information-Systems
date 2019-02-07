Public Class PatientRegistrationForm
    'validation function
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'this function makes sure that the user has entered all the data required , if found empty box, the small error icon will display and blink at the end of the box.
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then 'checking if the Textbox is empty
                ErrorProvider.SetError(ctl(i), ctl(i).tag) 'throwing an error message using error provider which will blink on the side of the textbox if found empty and displays tags  when mouse moved ove it
                Return False ' return false
                Exit Function
            End If
        Next
        Return True
    End Function

    'GetRandomID function
    Protected Function GetRandomID() As String
        'This function generates random Patient ID which will include all the Block letters and the numbers 0 - 9 of length 6
        Dim ID As String = String.Empty
        Dim Chars() As String = {"ABCDEFGHJKLMNPQRSTWXYZ", "0123456789"}
        Dim rnd = New Random()
        While ID.Length < 6 'gentrating the ID 
            Dim rndSet As Integer = rnd.Next(0, Chars.Length)
            ID &= Chars(rndSet).Substring(rnd.Next(0, Chars(rndSet).Length), 1)
        End While
        Return ID 'returning the randomly generated Patient ID 
    End Function

    Private Sub PatientInformationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PatientInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatientInformationDataSet)

    End Sub

    'As this form loads, this function make sure all the boxes are clear except the patient ID as it will call the Patient ID generating function to set its value.
    'this function also opens the database 
    Private Sub PatientRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientInformationDataSet.PatientInformation' table. You can move, or remove it, as needed.
        ' Me.PatientInformationTableAdapter.Fill(Me.PatientInformationDataSet.PatientInformation)
        ConnectPatientDB()
        Patient_IDTextBox.Text = GetRandomID()

        ' Dim TodayDate As Date = DateTime.Now.ToString("MM/dd/yyyy ")
        ''clear all the textboxes
        Animal_NameTextBox.Clear()
        Animal_KindTextBox.Clear()
        BreedTextBox.Clear()
        NumberTextBox.Clear()
        Area_CodeTextBox.Clear()
        Weight__In__Lbs_TextBox.Clear()
        The_OwnerTextBox.Clear()
        AddressTextBox.Clear()
        Date_of_BirthDateTimePicker.Value = DateTime.Now.ToShortDateString
    End Sub

    'this fumction submits the patient registered application by validating all the data entered
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        'calling the function to make sure that all the input is provided
        If vld(Animal_NameTextBox, Animal_KindTextBox, BreedTextBox, Weight__In__Lbs_TextBox, The_OwnerTextBox, AddressTextBox, Area_CodeTextBox, NumberTextBox) = False Then
            Exit Sub
        Else
            If Area_CodeTextBox.Text.Trim.Length = 3 And IsNumeric(Area_CodeTextBox.Text) Then ' checking if the area code eneted is of correct length and is numeric
                If NumberTextBox.Text.Trim.Length = 7 And IsNumeric(NumberTextBox.Text) Then ' checking if the phone number entered is of correct length and is numeric
                    Dim Taskperform As Boolean = False
                    Dim Patient_ID, Animal_Name, Breed, Animal_kind, Owner_Name, Address As String
                    Dim Contact_Number, area_code As Integer
                    Dim DOB As Date
                    Dim Animal_Weight As Decimal
                    Dim PatientID As String = Patient_IDTextBox.Text
                    Try
                        If IsNumeric(Weight__In__Lbs_TextBox.Text) Then ' checking if the weight is numeric
                            Contact_Number = NumberTextBox.Text
                            area_code = Area_CodeTextBox.Text
                            Animal_Weight = Decimal.Parse(Weight__In__Lbs_TextBox.Text)
                            Patient_ID = Patient_IDTextBox.Text
                            Animal_Name = Animal_NameTextBox.Text
                            Breed = BreedTextBox.Text
                            Animal_kind = Animal_KindTextBox.Text
                            Owner_Name = The_OwnerTextBox.Text
                            Address = AddressTextBox.Text
                            DOB = Date_of_BirthDateTimePicker.Text
                            Address = AddressTextBox.Text
                            'adding information to the Patient Table
                            Dim PatientInsertCmd As New SqlClient.SqlCommand("INSERT INTO [PatientInformation] ([Patient ID], [Animal Name], [Animal Kind], [Breed], [Weight (In. Lbs)], [Date Of Birth], [The Owner], [Address],[Area Code] ,[Number]) VALUES ('" & Patient_ID & "' , '" & Animal_Name & "' ,'" & Breed & "','" & Animal_kind & "','" & Animal_Weight & "','" & DOB & "','" & Owner_Name & "','" & Address & "','" & area_code & "','" & Contact_Number & "');", PatientSQLConnection)
                            PatientInsertCmd.ExecuteNonQuery()
                            Taskperform = True
                        Else
                            MsgBox("Patient Weight Error!!")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error Occured while saving the Information!", "Information Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    Patient_IDTextBox.Clear() ' clearing the patient_ID text Box
                    If Taskperform = True Then
                        Dim message As DialogResult = MessageBox.Show("Would you like to Schedule as Appointment?", "Schedule an Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If message = DialogResult.Yes Then
                            AppointmentForm.PatientSearchComboBox.Text = PatientID
                            clear()
                            GetRandomID()
                            AppointmentForm.Show()
                            clear()
                            Me.Hide()
                        Else
                            clear()
                            Me.Close()
                            MainForm.Show() ' showing main form 
                            Patient_IDTextBox.Text = GetRandomID()
                        End If
                    Else
                        MessageBox.Show("Please make sure your database is connected and try again later.", "Try Later.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        clear()
                        Me.Hide()
                        MainForm.Show()
                    End If
                Else
                    MessageBox.Show("Number must only consist of only 7 digits and should be numeric. ", "Phone Number Enrty Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Area Code must only consist of only 3 digits and should be numeric. ", "Area Code Enrty Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    'this function closes this form
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        'clear all the textboxes
        clear()
        Me.Close()
    End Sub

    'this function clears all the textboxes
    Private Sub clear()
        'clear all the textboxes when called this function
        Patient_IDTextBox.Clear()
        Animal_NameTextBox.Clear()
        Animal_KindTextBox.Clear()
        BreedTextBox.Clear()
        Area_CodeTextBox.Clear()
        NumberTextBox.Clear()
        Weight__In__Lbs_TextBox.Clear()
        The_OwnerTextBox.Clear()
        AddressTextBox.Clear()
        Patient_IDTextBox.Text = GetRandomID()
    End Sub

    Private Sub PatientInformationBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PatientInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatientInformationDataSet)
    End Sub
End Class