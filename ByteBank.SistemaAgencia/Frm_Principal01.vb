Public Class Frm_Principal01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Banco ByteBank"


    End Sub

    Private Sub ContasCorrentesArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContasCorrentesArrayToolStripMenuItem.Click
        Dim F As New Frm_ContasCorrentesArray
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ContasCorrentesListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContasCorrentesListasToolStripMenuItem.Click
        Dim F As New Frm_ContasCorrentesListas
        F.MdiParent = Me
        F.Show()
    End Sub
End Class