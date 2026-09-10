Public Class frmMenu
    Private Sub LoadFormInPanel(ByVal childForm As Form)
        ' Clear any existing controls/forms inside SplitContainer1.Panel2
        SplitContainer1.Panel2.Controls.Clear()

        ' Configure child form properties for embedding
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        ' Add child form to SplitContainer1.Panel2 and render it
        SplitContainer1.Panel2.Controls.Add(childForm)
        SplitContainer1.Panel2.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnDocumentManagement_Click(sender As Object, e As EventArgs) Handles btnDocumentManagement.Click

        LoadFormInPanel(New frmDocumentManagement())

    End Sub

    Private Sub btnDocumentRequest_Click(sender As Object, e As EventArgs) Handles btnDocumentRequest.Click

        LoadFormInPanel(New frmDocumentRequest())

    End Sub

    Private Sub btnRequestList_Click(sender As Object, e As EventArgs) Handles btnRequestList.Click

        LoadFormInPanel(New frmRequestList())

    End Sub

    Private Sub btnPaymentInformation_Click(sender As Object, e As EventArgs) Handles btnPaymentInformation.Click

        LoadFormInPanel(New frmPaymentInformation())

    End Sub
End Class