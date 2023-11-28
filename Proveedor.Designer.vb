<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedor))
        Me.BtnEliminarProveedor = New System.Windows.Forms.Button()
        Me.BtnActualizarProveedor = New System.Windows.Forms.Button()
        Me.BtnAgregarProveedor = New System.Windows.Forms.Button()
        Me.TxtTelefonoProveedor = New System.Windows.Forms.TextBox()
        Me.TxtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCorreoProveedor = New System.Windows.Forms.TextBox()
        Me.CmbxSucursal = New System.Windows.Forms.ComboBox()
        Me.SucursalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Floreria20DataSet1 = New PFR_Floreria.Floreria20DataSet1()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbxTipo = New System.Windows.Forms.ComboBox()
        Me.TipoProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreempresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdsucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtipoproveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.ProveedorTableAdapter()
        Me.SucursalTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.SucursalTableAdapter()
        Me.Tipo_ProveedorTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.Tipo_ProveedorTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.SucursalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminarProveedor
        '
        Me.BtnEliminarProveedor.BackColor = System.Drawing.Color.Black
        Me.BtnEliminarProveedor.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarProveedor.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarProveedor.Location = New System.Drawing.Point(655, 335)
        Me.BtnEliminarProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminarProveedor.Name = "BtnEliminarProveedor"
        Me.BtnEliminarProveedor.Size = New System.Drawing.Size(102, 40)
        Me.BtnEliminarProveedor.TabIndex = 17
        Me.BtnEliminarProveedor.Text = "ELIMINAR"
        Me.BtnEliminarProveedor.UseVisualStyleBackColor = False
        '
        'BtnActualizarProveedor
        '
        Me.BtnActualizarProveedor.BackColor = System.Drawing.Color.Black
        Me.BtnActualizarProveedor.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarProveedor.ForeColor = System.Drawing.Color.White
        Me.BtnActualizarProveedor.Location = New System.Drawing.Point(517, 335)
        Me.BtnActualizarProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnActualizarProveedor.Name = "BtnActualizarProveedor"
        Me.BtnActualizarProveedor.Size = New System.Drawing.Size(120, 40)
        Me.BtnActualizarProveedor.TabIndex = 16
        Me.BtnActualizarProveedor.Text = "ACTUALIZAR"
        Me.BtnActualizarProveedor.UseVisualStyleBackColor = False
        '
        'BtnAgregarProveedor
        '
        Me.BtnAgregarProveedor.BackColor = System.Drawing.Color.Black
        Me.BtnAgregarProveedor.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarProveedor.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarProveedor.Location = New System.Drawing.Point(401, 335)
        Me.BtnAgregarProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarProveedor.Name = "BtnAgregarProveedor"
        Me.BtnAgregarProveedor.Size = New System.Drawing.Size(98, 40)
        Me.BtnAgregarProveedor.TabIndex = 15
        Me.BtnAgregarProveedor.Text = "AGREGAR"
        Me.BtnAgregarProveedor.UseVisualStyleBackColor = False
        '
        'TxtTelefonoProveedor
        '
        Me.TxtTelefonoProveedor.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefonoProveedor.Location = New System.Drawing.Point(500, 188)
        Me.TxtTelefonoProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTelefonoProveedor.Name = "TxtTelefonoProveedor"
        Me.TxtTelefonoProveedor.Size = New System.Drawing.Size(239, 31)
        Me.TxtTelefonoProveedor.TabIndex = 31
        '
        'TxtNombreProveedor
        '
        Me.TxtNombreProveedor.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreProveedor.Location = New System.Drawing.Point(500, 104)
        Me.TxtNombreProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombreProveedor.Name = "TxtNombreProveedor"
        Me.TxtNombreProveedor.Size = New System.Drawing.Size(239, 31)
        Me.TxtNombreProveedor.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(398, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(398, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Empresa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Correo"
        '
        'TxtCorreoProveedor
        '
        Me.TxtCorreoProveedor.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreoProveedor.Location = New System.Drawing.Point(500, 147)
        Me.TxtCorreoProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCorreoProveedor.Name = "TxtCorreoProveedor"
        Me.TxtCorreoProveedor.Size = New System.Drawing.Size(239, 31)
        Me.TxtCorreoProveedor.TabIndex = 34
        '
        'CmbxSucursal
        '
        Me.CmbxSucursal.DataSource = Me.SucursalBindingSource
        Me.CmbxSucursal.DisplayMember = "direccion"
        Me.CmbxSucursal.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxSucursal.FormattingEnabled = True
        Me.CmbxSucursal.Location = New System.Drawing.Point(500, 236)
        Me.CmbxSucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxSucursal.Name = "CmbxSucursal"
        Me.CmbxSucursal.Size = New System.Drawing.Size(239, 26)
        Me.CmbxSucursal.TabIndex = 36
        Me.CmbxSucursal.ValueMember = "id"
        '
        'SucursalBindingSource
        '
        Me.SucursalBindingSource.DataMember = "Sucursal"
        Me.SucursalBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'Floreria20DataSet1
        '
        Me.Floreria20DataSet1.DataSetName = "Floreria20DataSet1"
        Me.Floreria20DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(398, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 18)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Sucursal"
        '
        'CmbxTipo
        '
        Me.CmbxTipo.DataSource = Me.TipoProveedorBindingSource
        Me.CmbxTipo.DisplayMember = "descripcion"
        Me.CmbxTipo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxTipo.FormattingEnabled = True
        Me.CmbxTipo.Location = New System.Drawing.Point(500, 277)
        Me.CmbxTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxTipo.Name = "CmbxTipo"
        Me.CmbxTipo.Size = New System.Drawing.Size(239, 26)
        Me.CmbxTipo.TabIndex = 37
        Me.CmbxTipo.ValueMember = "id"
        '
        'TipoProveedorBindingSource
        '
        Me.TipoProveedorBindingSource.DataMember = "Tipo_Proveedor"
        Me.TipoProveedorBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(398, 285)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(42, 18)
        Me.lbl.TabIndex = 38
        Me.lbl.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("212 Orion Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(511, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 25)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "PROVEEDORES"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreempresaDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.IdsucursalDataGridViewTextBoxColumn, Me.IdtipoproveedorDataGridViewTextBoxColumn, Me.EmpleadocreaDataGridViewTextBoxColumn, Me.EmpleadoactualizaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProveedorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(357, 271)
        Me.DataGridView1.TabIndex = 40
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
        'NombreempresaDataGridViewTextBoxColumn
        '
        Me.NombreempresaDataGridViewTextBoxColumn.DataPropertyName = "nombre_empresa"
        Me.NombreempresaDataGridViewTextBoxColumn.HeaderText = "nombre_empresa"
        Me.NombreempresaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreempresaDataGridViewTextBoxColumn.Name = "NombreempresaDataGridViewTextBoxColumn"
        Me.NombreempresaDataGridViewTextBoxColumn.Width = 125
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "correo"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.Width = 125
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "celular"
        Me.CelularDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.Width = 125
        '
        'IdsucursalDataGridViewTextBoxColumn
        '
        Me.IdsucursalDataGridViewTextBoxColumn.DataPropertyName = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.HeaderText = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdsucursalDataGridViewTextBoxColumn.Name = "IdsucursalDataGridViewTextBoxColumn"
        Me.IdsucursalDataGridViewTextBoxColumn.Width = 125
        '
        'IdtipoproveedorDataGridViewTextBoxColumn
        '
        Me.IdtipoproveedorDataGridViewTextBoxColumn.DataPropertyName = "id_tipo_proveedor"
        Me.IdtipoproveedorDataGridViewTextBoxColumn.HeaderText = "id_tipo_proveedor"
        Me.IdtipoproveedorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdtipoproveedorDataGridViewTextBoxColumn.Name = "IdtipoproveedorDataGridViewTextBoxColumn"
        Me.IdtipoproveedorDataGridViewTextBoxColumn.Width = 125
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
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'SucursalTableAdapter
        '
        Me.SucursalTableAdapter.ClearBeforeFill = True
        '
        'Tipo_ProveedorTableAdapter
        '
        Me.Tipo_ProveedorTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.pictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 49)
        Me.Panel1.TabIndex = 54
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(701, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(61, 49)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 70
        Me.pictureBox1.TabStop = False
        '
        'Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 396)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.CmbxTipo)
        Me.Controls.Add(Me.CmbxSucursal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtCorreoProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTelefonoProveedor)
        Me.Controls.Add(Me.TxtNombreProveedor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEliminarProveedor)
        Me.Controls.Add(Me.BtnActualizarProveedor)
        Me.Controls.Add(Me.BtnAgregarProveedor)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Proveedor"
        Me.Text = "Proveedor"
        CType(Me.SucursalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEliminarProveedor As Button
    Friend WithEvents BtnActualizarProveedor As Button
    Friend WithEvents BtnAgregarProveedor As Button
    Friend WithEvents TxtTelefonoProveedor As TextBox
    Friend WithEvents TxtNombreProveedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCorreoProveedor As TextBox
    Friend WithEvents CmbxSucursal As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CmbxTipo As ComboBox
    Friend WithEvents lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Floreria20DataSet1 As Floreria20DataSet1
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As Floreria20DataSet1TableAdapters.ProveedorTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreempresaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdsucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdtipoproveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SucursalBindingSource As BindingSource
    Friend WithEvents SucursalTableAdapter As Floreria20DataSet1TableAdapters.SucursalTableAdapter
    Friend WithEvents TipoProveedorBindingSource As BindingSource
    Friend WithEvents Tipo_ProveedorTableAdapter As Floreria20DataSet1TableAdapters.Tipo_ProveedorTableAdapter
    Friend WithEvents Panel1 As Panel
    Private WithEvents pictureBox1 As PictureBox
End Class
