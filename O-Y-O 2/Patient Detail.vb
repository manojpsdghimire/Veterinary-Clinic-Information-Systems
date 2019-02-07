Public Class Patient_Detail
    Private Sub PatientInformationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.PatientInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatientInformationDataSet)

    End Sub

    Private Sub Patient_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientInformationDataSet.PatientInformation' table. You can move, or remove it, as needed.
        Me.PatientInformationTableAdapter.Fill(Me.PatientInformationDataSet.PatientInformation)
        ConnectPatientDB()
    End Sub
End Class