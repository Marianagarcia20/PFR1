<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_Proveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tipo_Proveedor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEliminarTipoP = New System.Windows.Forms.Button()
        Me.BtnActualizarTipoP = New System.Windows.Forms.Button()
        Me.BtnAgregarTipoP = New System.Windows.Forms.Button()
        Me.TxtDescripcionTP = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmpleadocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Floreria20DataSet1 = New PFR_Floreria.Floreria20DataSet1()
        Me.Tipo_ProveedorTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.Tipo_ProveedorTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("212 Orion Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(624, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TIPOS DE PROVEEDOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(525, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripcion"
        '
        'BtnEliminarTipoP
        '
        Me.BtnEliminarTipoP.BackColor = System.Drawing.Color.Black
        Me.BtnEliminarTipoP.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarTipoP.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarTipoP.Location = New System.Drawing.Point(794, 194)
        Me.BtnEliminarTipoP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminarTipoP.Name = "BtnEliminarTipoP"
        Me.BtnEliminarTipoP.Size = New System.Drawing.Size(99, 42)
        Me.BtnEliminarTipoP.TabIndex = 17
        Me.BtnEliminarTipoP.Text = "ELIMINAR"
        Me.BtnEliminarTipoP.UseVisualStyleBackColor = False
        '
        'BtnActualizarTipoP
        '
        Me.BtnActualizarTipoP.BackColor = System.Drawing.Color.Black
        Me.BtnActualizarTipoP.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarTipoP.ForeColor = System.Drawing.Color.White
        Me.BtnActualizarTipoP.Location = New System.Drawing.Point(646, 194)
        Me.BtnActualizarTipoP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnActualizarTipoP.Name = "BtnActualizarTipoP"
        Me.BtnActualizarTipoP.Size = New System.Drawing.Size(134, 40)
        Me.BtnActualizarTipoP.TabIndex = 16
        Me.BtnActualizarTipoP.Text = "ACTUALIZAR"
        Me.BtnActualizarTipoP.UseVisualStyleBackColor = False
        '
        'BtnAgregarTipoP
        '
        Me.BtnAgregarTipoP.BackColor = System.Drawing.Color.Black
        Me.BtnAgregarTipoP.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarTipoP.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarTipoP.Location = New System.Drawing.Point(528, 192)
        Me.BtnAgregarTipoP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarTipoP.Name = "BtnAgregarTipoP"
        Me.BtnAgregarTipoP.Size = New System.Drawing.Size(103, 42)
        Me.BtnAgregarTipoP.TabIndex = 15
        Me.BtnAgregarTipoP.Text = "AGREGAR"
        Me.BtnAgregarTipoP.UseVisualStyleBackColor = False
        '
        'TxtDescripcionTP
        '
        Me.TxtDescripcionTP.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcionTP.Location = New System.Drawing.Point(528, 136)
        Me.TxtDescripcionTP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDescripcionTP.Name = "TxtDescripcionTP"
        Me.TxtDescripcionTP.Size = New System.Drawing.Size(365, 31)
        Me.TxtDescripcionTP.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.EmpleadocreaDataGridViewTextBoxColumn, Me.EmpleadoactualizaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TipoProveedorBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(483, 273)
        Me.DataGridView1.TabIndex = 19
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.Width = 125
        '
        'EmpleadocreaDataGridViewTextBoxColumn
        '
        Me.EmpleadocreaDataGridViewTextBoxColumn.DataPropertyName = "empleado_crea"
        Me.EmpleadocreaDataGridViewTextBoxColumn.HeaderText = "empleado_crea"
        Me.EmpleadocreaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmpleadocreaDataGridViewTextBoxColumn.Name = "EmpleadocreaDataGridViewTextBoxColumn"
        Me.EmpleadocreaDataGridViewTextBoxColumn.Width = 125
        '
        'EmpleadoactualizaDataGridViewTextBoxColumn
        '
        Me.EmpleadoactualizaDataGridViewTextBoxColumn.DataPropertyName = "empleado_actualiza"
        Me.EmpleadoactualizaDataGridViewTextBoxColumn.HeaderText = "empleado_actualiza"
        Me.EmpleadoactualizaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmpleadoactualizaDataGridViewTextBoxColumn.Name = "EmpleadoactualizaDataGridViewTextBoxColumn"
        Me.EmpleadoactualizaDataGridViewTextBoxColumn.Width = 125
        '
        'TipoProveedorBindingSource
        '
        Me.TipoProveedorBindingSource.DataMember = "Tipo_Proveedor"
        Me.TipoProveedorBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'Floreria20DataSet1
        '
        Me.Floreria20DataSet1.DataSetName = "Floreria20DataSet1"
        Me.Floreria20DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tipo_ProveedorTableAdapter
        '
        Me.Tipo_ProveedorTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.pictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(909, 49)
        Me.Panel1.TabIndex = 55
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(844, 1)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(61, 49)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 70
        Me.pictureBox1.TabStop = False
        '
        'Tipo_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(905, 402)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtDescripcionTP)
        Me.Controls.Add(Me.BtnEliminarTipoP)
        Me.Controls.Add(Me.BtnActualizarTipoP)
        Me.Controls.Add(Me.BtnAgregarTipoP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Tipo_Proveedor"
        Me.Text = "Tipo_Proveedor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEliminarTipoP As Button
    Friend WithEvents BtnActualizarTipoP As Button
    Friend WithEvents BtnAgregarTipoP As Button
    Friend WithEvents TxtDescripcionTP As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Floreria20DataSet1 As Floreria20DataSet1
    Friend WithEvents TipoProveedorBindingSource As BindingSource
    Friend WithEvents Tipo_ProveedorTableAdapter As Floreria20DataSet1TableAdapters.Tipo_ProveedorTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EmpleadocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Private WithEvents pictureBox1 As PictureBox
End Class
