Namespace CustomWizardExample.Wizard.Views
    Partial Public Class ChoosePersonsPageView
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.rgDataSourceType = New DevExpress.XtraEditors.RadioGroup()
            DirectCast(Me.panelBaseContent, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelBaseContent.SuspendLayout()
            DirectCast(Me.panelAdditionalButtons, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.rgDataSourceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' buttonNext
            ' 
            Me.buttonNext.Location = New System.Drawing.Point(313, 418)
            Me.buttonNext.Size = New System.Drawing.Size(59, 22)
            ' 
            ' buttonFinish
            ' 
            Me.buttonFinish.Location = New System.Drawing.Point(378, 418)
            Me.buttonFinish.Size = New System.Drawing.Size(58, 22)
            ' 
            ' separatorTop
            ' 
            Me.separatorTop.Size = New System.Drawing.Size(448, 6)
            ' 
            ' labelHeader
            ' 
            Me.labelHeader.Location = New System.Drawing.Point(50, 21)
            Me.labelHeader.Size = New System.Drawing.Size(396, 13)
            ' 
            ' buttonPrevious
            ' 
            Me.buttonPrevious.Size = New System.Drawing.Size(50, 30)
            ' 
            ' panelBaseContent
            ' 
            Me.panelBaseContent.Controls.Add(Me.rgDataSourceType)
            Me.panelBaseContent.Size = New System.Drawing.Size(444, 364)
            ' 
            ' panelAdditionalButtons
            ' 
            Me.panelAdditionalButtons.Location = New System.Drawing.Point(0, 416)
            Me.panelAdditionalButtons.Size = New System.Drawing.Size(311, 26)
            ' 
            ' rgDataSourceType
            ' 
            Me.rgDataSourceType.Dock = System.Windows.Forms.DockStyle.Top
            Me.rgDataSourceType.Location = New System.Drawing.Point(0, 0)
            Me.rgDataSourceType.Name = "rgDataSourceType"
            Me.rgDataSourceType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { _
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Load data from the xml file"), _
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Load data from the predefined list") _
            })
            Me.rgDataSourceType.Size = New System.Drawing.Size(444, 96)
            Me.rgDataSourceType.TabIndex = 3
            ' 
            ' ChoosePersonsPageView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "ChoosePersonsPageView"
            Me.Size = New System.Drawing.Size(448, 452)
            DirectCast(Me.panelBaseContent, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelBaseContent.ResumeLayout(False)
            DirectCast(Me.panelAdditionalButtons, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.rgDataSourceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private rgDataSourceType As DevExpress.XtraEditors.RadioGroup



    End Class
End Namespace
