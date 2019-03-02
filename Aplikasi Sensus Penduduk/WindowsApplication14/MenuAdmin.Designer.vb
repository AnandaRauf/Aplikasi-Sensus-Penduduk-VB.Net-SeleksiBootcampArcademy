<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdmin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAdmin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxRegions = New System.Windows.Forms.GroupBox()
        Me.DelBut = New System.Windows.Forms.Button()
        Me.ShowBut = New System.Windows.Forms.Button()
        Me.QutBut = New System.Windows.Forms.Button()
        Me.SaveBut = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NmDrhBox = New System.Windows.Forms.TextBox()
        Me.NmDaerahLbl = New System.Windows.Forms.Label()
        Me.RegionsView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedbyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblregionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sensus_penduduk_bootcamp_arcademyDataSet = New WindowsApplication14.db_sensus_penduduk_bootcamp_arcademyDataSet()
        Me.Tbl_regionsTableAdapter = New WindowsApplication14.db_sensus_penduduk_bootcamp_arcademyDataSetTableAdapters.tbl_regionsTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBoxRegions.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.RegionsView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblregionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sensus_penduduk_bootcamp_arcademyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1300, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GroupBoxRegions
        '
        Me.GroupBoxRegions.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBoxRegions.Controls.Add(Me.DelBut)
        Me.GroupBoxRegions.Controls.Add(Me.ShowBut)
        Me.GroupBoxRegions.Controls.Add(Me.QutBut)
        Me.GroupBoxRegions.Controls.Add(Me.SaveBut)
        Me.GroupBoxRegions.Controls.Add(Me.StatusStrip1)
        Me.GroupBoxRegions.Controls.Add(Me.NmDrhBox)
        Me.GroupBoxRegions.Controls.Add(Me.NmDaerahLbl)
        Me.GroupBoxRegions.Location = New System.Drawing.Point(13, 37)
        Me.GroupBoxRegions.Name = "GroupBoxRegions"
        Me.GroupBoxRegions.Size = New System.Drawing.Size(479, 380)
        Me.GroupBoxRegions.TabIndex = 1
        Me.GroupBoxRegions.TabStop = False
        '
        'DelBut
        '
        Me.DelBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBut.Location = New System.Drawing.Point(263, 245)
        Me.DelBut.Name = "DelBut"
        Me.DelBut.Size = New System.Drawing.Size(78, 30)
        Me.DelBut.TabIndex = 12
        Me.DelBut.Text = "Delete"
        Me.DelBut.UseVisualStyleBackColor = True
        '
        'ShowBut
        '
        Me.ShowBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowBut.Location = New System.Drawing.Point(6, 241)
        Me.ShowBut.Name = "ShowBut"
        Me.ShowBut.Size = New System.Drawing.Size(113, 42)
        Me.ShowBut.TabIndex = 11
        Me.ShowBut.Text = "Show Data"
        Me.ShowBut.UseVisualStyleBackColor = True
        '
        'QutBut
        '
        Me.QutBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QutBut.Location = New System.Drawing.Point(373, 247)
        Me.QutBut.Name = "QutBut"
        Me.QutBut.Size = New System.Drawing.Size(78, 30)
        Me.QutBut.TabIndex = 10
        Me.QutBut.Text = "Quit"
        Me.QutBut.UseVisualStyleBackColor = True
        '
        'SaveBut
        '
        Me.SaveBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBut.Location = New System.Drawing.Point(158, 245)
        Me.SaveBut.Name = "SaveBut"
        Me.SaveBut.Size = New System.Drawing.Size(77, 34)
        Me.SaveBut.TabIndex = 9
        Me.SaveBut.Text = "Save"
        Me.SaveBut.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 355)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(473, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.LinkColor = System.Drawing.Color.SpringGreen
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(35, 17)
        Me.ToolStripStatusLabel1.Text = "Hijau"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.LinkColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(41, 17)
        Me.ToolStripStatusLabel2.Text = "Merah"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.LinkColor = System.Drawing.Color.Yellow
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel3.Text = "Kuning"
        '
        'NmDrhBox
        '
        Me.NmDrhBox.Location = New System.Drawing.Point(11, 44)
        Me.NmDrhBox.Multiline = True
        Me.NmDrhBox.Name = "NmDrhBox"
        Me.NmDrhBox.Size = New System.Drawing.Size(330, 94)
        Me.NmDrhBox.TabIndex = 1
        '
        'NmDaerahLbl
        '
        Me.NmDaerahLbl.AutoSize = True
        Me.NmDaerahLbl.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NmDaerahLbl.Location = New System.Drawing.Point(7, 20)
        Me.NmDaerahLbl.Name = "NmDaerahLbl"
        Me.NmDaerahLbl.Size = New System.Drawing.Size(145, 21)
        Me.NmDaerahLbl.TabIndex = 0
        Me.NmDaerahLbl.Text = "Nama Daerah :"
        '
        'RegionsView
        '
        Me.RegionsView.AutoGenerateColumns = False
        Me.RegionsView.BackgroundColor = System.Drawing.Color.LightGreen
        Me.RegionsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegionsView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.CreatedatDataGridViewTextBoxColumn, Me.CreatedbyDataGridViewTextBoxColumn, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.RegionsView.DataSource = Me.TblregionsBindingSource
        Me.RegionsView.Location = New System.Drawing.Point(524, 46)
        Me.RegionsView.Name = "RegionsView"
        Me.RegionsView.Size = New System.Drawing.Size(849, 129)
        Me.RegionsView.TabIndex = 2
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'CreatedatDataGridViewTextBoxColumn
        '
        Me.CreatedatDataGridViewTextBoxColumn.DataPropertyName = "created_at "
        Me.CreatedatDataGridViewTextBoxColumn.HeaderText = "created_at "
        Me.CreatedatDataGridViewTextBoxColumn.Name = "CreatedatDataGridViewTextBoxColumn"
        '
        'CreatedbyDataGridViewTextBoxColumn
        '
        Me.CreatedbyDataGridViewTextBoxColumn.DataPropertyName = "created_by "
        Me.CreatedbyDataGridViewTextBoxColumn.HeaderText = "created_by "
        Me.CreatedbyDataGridViewTextBoxColumn.Name = "CreatedbyDataGridViewTextBoxColumn"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Jumlah Penduduk"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Total Pendapatan"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Rata-rata Pendapatan"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Status"
        Me.Column4.Name = "Column4"
        '
        'TblregionsBindingSource
        '
        Me.TblregionsBindingSource.DataMember = "tbl_regions"
        Me.TblregionsBindingSource.DataSource = Me.Db_sensus_penduduk_bootcamp_arcademyDataSet
        '
        'Db_sensus_penduduk_bootcamp_arcademyDataSet
        '
        Me.Db_sensus_penduduk_bootcamp_arcademyDataSet.DataSetName = "db_sensus_penduduk_bootcamp_arcademyDataSet"
        Me.Db_sensus_penduduk_bootcamp_arcademyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_regionsTableAdapter
        '
        Me.Tbl_regionsTableAdapter.ClearBeforeFill = True
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 699)
        Me.Controls.Add(Me.RegionsView)
        Me.Controls.Add(Me.GroupBoxRegions)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuAdmin"
        Me.Text = "MenuAdmin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBoxRegions.ResumeLayout(False)
        Me.GroupBoxRegions.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.RegionsView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblregionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sensus_penduduk_bootcamp_arcademyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBoxRegions As GroupBox
    Friend WithEvents RegionsView As DataGridView
    Friend WithEvents NmDrhBox As TextBox
    Friend WithEvents NmDaerahLbl As Label
    Friend WithEvents Db_sensus_penduduk_bootcamp_arcademyDataSet As db_sensus_penduduk_bootcamp_arcademyDataSet
    Friend WithEvents TblregionsBindingSource As BindingSource
    Friend WithEvents Tbl_regionsTableAdapter As db_sensus_penduduk_bootcamp_arcademyDataSetTableAdapters.tbl_regionsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedbyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents SaveBut As Button
    Friend WithEvents QutBut As Button
    Friend WithEvents ShowBut As Button
    Friend WithEvents DelBut As Button
End Class
