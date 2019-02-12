Imports CrystalDecisions.CrystalReports.Engine
Public Class ExportData

    Private Sub SearchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExportData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportDocument
        rpt.Load("C:\Users\MARZO\Desktop\soft eng\Bgry_Information_System\Bgry_Information_System\CrystalReport4.rpt")
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.RefreshReport()

    End Sub

End Class