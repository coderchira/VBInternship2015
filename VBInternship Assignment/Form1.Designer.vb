<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lstBoxProductNames = New System.Windows.Forms.ListBox()
        Me.lstBxProdDetails = New System.Windows.Forms.ListBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.fltrByBrand = New System.Windows.Forms.ComboBox()
        Me.fltrByColor = New System.Windows.Forms.ComboBox()
        Me.btnRemoveFltr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtSearch.Location = New System.Drawing.Point(12, 44)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(218, 20)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = "Enter a Product Name, Brand or color here"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSearch.Location = New System.Drawing.Point(236, 42)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 51)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseMnemonic = False
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lstBoxProductNames
        '
        Me.lstBoxProductNames.BackColor = System.Drawing.SystemColors.Window
        Me.lstBoxProductNames.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lstBoxProductNames.FormattingEnabled = True
        Me.lstBoxProductNames.Location = New System.Drawing.Point(12, 97)
        Me.lstBoxProductNames.Name = "lstBoxProductNames"
        Me.lstBoxProductNames.Size = New System.Drawing.Size(218, 199)
        Me.lstBoxProductNames.TabIndex = 2
        '
        'lstBxProdDetails
        '
        Me.lstBxProdDetails.BackColor = System.Drawing.SystemColors.Window
        Me.lstBxProdDetails.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lstBxProdDetails.FormattingEnabled = True
        Me.lstBxProdDetails.Location = New System.Drawing.Point(12, 302)
        Me.lstBxProdDetails.Name = "lstBxProdDetails"
        Me.lstBxProdDetails.Size = New System.Drawing.Size(218, 82)
        Me.lstBxProdDetails.TabIndex = 3
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(12, 28)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 4
        '
        'fltrByBrand
        '
        Me.fltrByBrand.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.fltrByBrand.FormattingEnabled = True
        Me.fltrByBrand.Location = New System.Drawing.Point(12, 72)
        Me.fltrByBrand.Name = "fltrByBrand"
        Me.fltrByBrand.Size = New System.Drawing.Size(112, 21)
        Me.fltrByBrand.TabIndex = 5
        Me.fltrByBrand.Text = "Filter by Brand"
        '
        'fltrByColor
        '
        Me.fltrByColor.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.fltrByColor.FormattingEnabled = True
        Me.fltrByColor.Location = New System.Drawing.Point(130, 72)
        Me.fltrByColor.Name = "fltrByColor"
        Me.fltrByColor.Size = New System.Drawing.Size(100, 21)
        Me.fltrByColor.TabIndex = 6
        Me.fltrByColor.Text = "Filter by Color"
        '
        'btnRemoveFltr
        '
        Me.btnRemoveFltr.BackColor = System.Drawing.SystemColors.Menu
        Me.btnRemoveFltr.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnRemoveFltr.Location = New System.Drawing.Point(237, 109)
        Me.btnRemoveFltr.Name = "btnRemoveFltr"
        Me.btnRemoveFltr.Size = New System.Drawing.Size(75, 53)
        Me.btnRemoveFltr.TabIndex = 7
        Me.btnRemoveFltr.Text = "Remove Filters"
        Me.btnRemoveFltr.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(323, 406)
        Me.Controls.Add(Me.btnRemoveFltr)
        Me.Controls.Add(Me.fltrByColor)
        Me.Controls.Add(Me.fltrByBrand)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lstBxProdDetails)
        Me.Controls.Add(Me.lstBoxProductNames)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Name = "Form1"
        Me.Text = "View Products"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lstBoxProductNames As System.Windows.Forms.ListBox
    Friend WithEvents lstBxProdDetails As System.Windows.Forms.ListBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents fltrByBrand As System.Windows.Forms.ComboBox
    Friend WithEvents fltrByColor As System.Windows.Forms.ComboBox
    Friend WithEvents btnRemoveFltr As System.Windows.Forms.Button

End Class
