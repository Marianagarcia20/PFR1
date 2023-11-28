<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Empleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEliminarEmpleado = New System.Windows.Forms.Button()
        Me.BtnActualizarEmpleado = New System.Windows.Forms.Button()
        Me.BtnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtAPEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtAMEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtDireccionEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtTelefonoEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtContrasenia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbxSucursal = New System.Windows.Forms.ComboBox()
        Me.SucursalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Floreria20DataSet1 = New PFR_Floreria.Floreria20DataSet1()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmbxHorario = New System.Windows.Forms.ComboBox()
        Me.HorarioEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbxCargo = New System.Windows.Forms.ComboBox()
        Me.PuestoEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApmaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdsucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdpuestoempleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdhorarioempleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.EmpleadoTableAdapter()
        Me.SucursalTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.SucursalTableAdapter()
        Me.Horario_EmpleadoTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.Horario_EmpleadoTableAdapter()
        Me.Puesto_EmpleadoTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.Puesto_EmpleadoTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.SucursalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuestoEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("212 Orion Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(774, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLEADOS"
        '
        'BtnEliminarEmpleado
        '
        Me.BtnEliminarEmpleado.BackColor = System.Drawing.Color.Black
        Me.BtnEliminarEmpleado.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarEmpleado.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarEmpleado.Location = New System.Drawing.Point(881, 378)
        Me.BtnEliminarEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminarEmpleado.Name = "BtnEliminarEmpleado"
        Me.BtnEliminarEmpleado.Size = New System.Drawing.Size(108, 38)
        Me.BtnEliminarEmpleado.TabIndex = 14
        Me.BtnEliminarEmpleado.Text = "ELIMINAR"
        Me.BtnEliminarEmpleado.UseVisualStyleBackColor = False
        '
        'BtnActualizarEmpleado
        '
        Me.BtnActualizarEmpleado.BackColor = System.Drawing.Color.Black
        Me.BtnActualizarEmpleado.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarEmpleado.ForeColor = System.Drawing.Color.White
        Me.BtnActualizarEmpleado.Location = New System.Drawing.Point(734, 378)
        Me.BtnActualizarEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnActualizarEmpleado.Name = "BtnActualizarEmpleado"
        Me.BtnActualizarEmpleado.Size = New System.Drawing.Size(114, 38)
        Me.BtnActualizarEmpleado.TabIndex = 13
        Me.BtnActualizarEmpleado.Text = "ACTUALIZAR"
        Me.BtnActualizarEmpleado.UseVisualStyleBackColor = False
        '
        'BtnAgregarEmpleado
        '
        Me.BtnAgregarEmpleado.BackColor = System.Drawing.Color.Black
        Me.BtnAgregarEmpleado.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarEmpleado.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarEmpleado.Location = New System.Drawing.Point(605, 378)
        Me.BtnAgregarEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarEmpleado.Name = "BtnAgregarEmpleado"
        Me.BtnAgregarEmpleado.Size = New System.Drawing.Size(94, 38)
        Me.BtnAgregarEmpleado.TabIndex = 12
        Me.BtnAgregarEmpleado.Text = "AGREGAR"
        Me.BtnAgregarEmpleado.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(523, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(523, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Apellido Paterno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(523, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Apellido Materno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(523, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Direccion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(523, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Telefono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(523, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(850, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Contraseña"
        '
        'TxtNombreEmpleado
        '
        Me.TxtNombreEmpleado.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreEmpleado.Location = New System.Drawing.Point(661, 106)
        Me.TxtNombreEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombreEmpleado.Name = "TxtNombreEmpleado"
        Me.TxtNombreEmpleado.Size = New System.Drawing.Size(168, 31)
        Me.TxtNombreEmpleado.TabIndex = 23
        '
        'TxtAPEmpleado
        '
        Me.TxtAPEmpleado.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAPEmpleado.Location = New System.Drawing.Point(662, 147)
        Me.TxtAPEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAPEmpleado.Name = "TxtAPEmpleado"
        Me.TxtAPEmpleado.Size = New System.Drawing.Size(168, 31)
        Me.TxtAPEmpleado.TabIndex = 24
        '
        'TxtAMEmpleado
        '
        Me.TxtAMEmpleado.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAMEmpleado.Location = New System.Drawing.Point(662, 187)
        Me.TxtAMEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAMEmpleado.Name = "TxtAMEmpleado"
        Me.TxtAMEmpleado.Size = New System.Drawing.Size(168, 31)
        Me.TxtAMEmpleado.TabIndex = 25
        '
        'TxtDireccionEmpleado
        '
        Me.TxtDireccionEmpleado.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccionEmpleado.Location = New System.Drawing.Point(661, 232)
        Me.TxtDireccionEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDireccionEmpleado.Name = "TxtDireccionEmpleado"
        Me.TxtDireccionEmpleado.Size = New System.Drawing.Size(169, 31)
        Me.TxtDireccionEmpleado.TabIndex = 26
        '
        'TxtTelefonoEmpleado
        '
        Me.TxtTelefonoEmpleado.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefonoEmpleado.Location = New System.Drawing.Point(662, 278)
        Me.TxtTelefonoEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTelefonoEmpleado.MaxLength = 10
        Me.TxtTelefonoEmpleado.Name = "TxtTelefonoEmpleado"
        Me.TxtTelefonoEmpleado.Size = New System.Drawing.Size(168, 31)
        Me.TxtTelefonoEmpleado.TabIndex = 27
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(662, 321)
        Me.TxtUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(168, 31)
        Me.TxtUsuario.TabIndex = 28
        '
        'TxtContrasenia
        '
        Me.TxtContrasenia.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasenia.Location = New System.Drawing.Point(943, 106)
        Me.TxtContrasenia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtContrasenia.Name = "TxtContrasenia"
        Me.TxtContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContrasenia.Size = New System.Drawing.Size(168, 31)
        Me.TxtContrasenia.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(834, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 18)
        Me.Label9.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(850, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 18)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Sucursal"
        '
        'CmbxSucursal
        '
        Me.CmbxSucursal.DataSource = Me.SucursalBindingSource
        Me.CmbxSucursal.DisplayMember = "direccion"
        Me.CmbxSucursal.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxSucursal.FormattingEnabled = True
        Me.CmbxSucursal.Location = New System.Drawing.Point(943, 157)
        Me.CmbxSucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxSucursal.Name = "CmbxSucursal"
        Me.CmbxSucursal.Size = New System.Drawing.Size(168, 26)
        Me.CmbxSucursal.TabIndex = 32
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(850, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 18)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Horario"
        '
        'CmbxHorario
        '
        Me.CmbxHorario.DataSource = Me.HorarioEmpleadoBindingSource
        Me.CmbxHorario.DisplayMember = "hora_entrada"
        Me.CmbxHorario.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxHorario.FormattingEnabled = True
        Me.CmbxHorario.Location = New System.Drawing.Point(943, 192)
        Me.CmbxHorario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxHorario.Name = "CmbxHorario"
        Me.CmbxHorario.Size = New System.Drawing.Size(168, 26)
        Me.CmbxHorario.TabIndex = 34
        Me.CmbxHorario.ValueMember = "id"
        '
        'HorarioEmpleadoBindingSource
        '
        Me.HorarioEmpleadoBindingSource.DataMember = "Horario_Empleado"
        Me.HorarioEmpleadoBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(850, 245)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 18)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Cargo"
        '
        'CmbxCargo
        '
        Me.CmbxCargo.DataSource = Me.PuestoEmpleadoBindingSource
        Me.CmbxCargo.DisplayMember = "descripcion"
        Me.CmbxCargo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxCargo.FormattingEnabled = True
        Me.CmbxCargo.Location = New System.Drawing.Point(943, 237)
        Me.CmbxCargo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxCargo.Name = "CmbxCargo"
        Me.CmbxCargo.Size = New System.Drawing.Size(168, 26)
        Me.CmbxCargo.TabIndex = 38
        Me.CmbxCargo.ValueMember = "id"
        '
        'PuestoEmpleadoBindingSource
        '
        Me.PuestoEmpleadoBindingSource.DataMember = "Puesto_Empleado"
        Me.PuestoEmpleadoBindingSource.DataSource = Me.Floreria20DataSet1
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.AppaternoDataGridViewTextBoxColumn, Me.ApmaternoDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.ContraseniaDataGridViewTextBoxColumn, Me.IdsucursalDataGridViewTextBoxColumn, Me.IdpuestoempleadoDataGridViewTextBoxColumn, Me.IdhorarioempleadoDataGridViewTextBoxColumn, Me.EmpleadocreaDataGridViewTextBoxColumn, Me.EmpleadoactualizaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpleadoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(22, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(482, 303)
        Me.DataGridView1.TabIndex = 39
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
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'AppaternoDataGridViewTextBoxColumn
        '
        Me.AppaternoDataGridViewTextBoxColumn.DataPropertyName = "ap_paterno"
        Me.AppaternoDataGridViewTextBoxColumn.HeaderText = "ap_paterno"
        Me.AppaternoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AppaternoDataGridViewTextBoxColumn.Name = "AppaternoDataGridViewTextBoxColumn"
        Me.AppaternoDataGridViewTextBoxColumn.Width = 125
        '
        'ApmaternoDataGridViewTextBoxColumn
        '
        Me.ApmaternoDataGridViewTextBoxColumn.DataPropertyName = "ap_materno"
        Me.ApmaternoDataGridViewTextBoxColumn.HeaderText = "ap_materno"
        Me.ApmaternoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApmaternoDataGridViewTextBoxColumn.Name = "ApmaternoDataGridViewTextBoxColumn"
        Me.ApmaternoDataGridViewTextBoxColumn.Width = 125
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "celular"
        Me.CelularDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.Width = 125
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.Width = 125
        '
        'ContraseniaDataGridViewTextBoxColumn
        '
        Me.ContraseniaDataGridViewTextBoxColumn.DataPropertyName = "contrasenia"
        Me.ContraseniaDataGridViewTextBoxColumn.HeaderText = "contrasenia"
        Me.ContraseniaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContraseniaDataGridViewTextBoxColumn.Name = "ContraseniaDataGridViewTextBoxColumn"
        Me.ContraseniaDataGridViewTextBoxColumn.Width = 125
        '
        'IdsucursalDataGridViewTextBoxColumn
        '
        Me.IdsucursalDataGridViewTextBoxColumn.DataPropertyName = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.HeaderText = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdsucursalDataGridViewTextBoxColumn.Name = "IdsucursalDataGridViewTextBoxColumn"
        Me.IdsucursalDataGridViewTextBoxColumn.Width = 125
        '
        'IdpuestoempleadoDataGridViewTextBoxColumn
        '
        Me.IdpuestoempleadoDataGridViewTextBoxColumn.DataPropertyName = "id_puesto_empleado"
        Me.IdpuestoempleadoDataGridViewTextBoxColumn.HeaderText = "id_puesto_empleado"
        Me.IdpuestoempleadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdpuestoempleadoDataGridViewTextBoxColumn.Name = "IdpuestoempleadoDataGridViewTextBoxColumn"
        Me.IdpuestoempleadoDataGridViewTextBoxColumn.Width = 125
        '
        'IdhorarioempleadoDataGridViewTextBoxColumn
        '
        Me.IdhorarioempleadoDataGridViewTextBoxColumn.DataPropertyName = "id_horario_empleado"
        Me.IdhorarioempleadoDataGridViewTextBoxColumn.HeaderText = "id_horario_empleado"
        Me.IdhorarioempleadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdhorarioempleadoDataGridViewTextBoxColumn.Name = "IdhorarioempleadoDataGridViewTextBoxColumn"
        Me.IdhorarioempleadoDataGridViewTextBoxColumn.Width = 125
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
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'SucursalTableAdapter
        '
        Me.SucursalTableAdapter.ClearBeforeFill = True
        '
        'Horario_EmpleadoTableAdapter
        '
        Me.Horario_EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'Puesto_EmpleadoTableAdapter
        '
        Me.Puesto_EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.pictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 49)
        Me.Panel1.TabIndex = 51
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(1067, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(61, 49)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 70
        Me.pictureBox1.TabStop = False
        '
        'Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1132, 438)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbxCargo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CmbxHorario)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CmbxSucursal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtContrasenia)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.TxtTelefonoEmpleado)
        Me.Controls.Add(Me.TxtDireccionEmpleado)
        Me.Controls.Add(Me.TxtAMEmpleado)
        Me.Controls.Add(Me.TxtAPEmpleado)
        Me.Controls.Add(Me.TxtNombreEmpleado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEliminarEmpleado)
        Me.Controls.Add(Me.BtnActualizarEmpleado)
        Me.Controls.Add(Me.BtnAgregarEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Empleado"
        Me.Text = "Empleado"
        CType(Me.SucursalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuestoEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminarEmpleado As Button
    Friend WithEvents BtnActualizarEmpleado As Button
    Friend WithEvents BtnAgregarEmpleado As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNombreEmpleado As TextBox
    Friend WithEvents TxtAPEmpleado As TextBox
    Friend WithEvents TxtAMEmpleado As TextBox
    Friend WithEvents TxtDireccionEmpleado As TextBox
    Friend WithEvents TxtTelefonoEmpleado As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContrasenia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CmbxSucursal As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CmbxHorario As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CmbxCargo As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Floreria20DataSet1 As Floreria20DataSet1
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As Floreria20DataSet1TableAdapters.EmpleadoTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApmaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContraseniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdsucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdpuestoempleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdhorarioempleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SucursalBindingSource As BindingSource
    Friend WithEvents SucursalTableAdapter As Floreria20DataSet1TableAdapters.SucursalTableAdapter
    Friend WithEvents HorarioEmpleadoBindingSource As BindingSource
    Friend WithEvents Horario_EmpleadoTableAdapter As Floreria20DataSet1TableAdapters.Horario_EmpleadoTableAdapter
    Friend WithEvents PuestoEmpleadoBindingSource As BindingSource
    Friend WithEvents Puesto_EmpleadoTableAdapter As Floreria20DataSet1TableAdapters.Puesto_EmpleadoTableAdapter
    Friend WithEvents Panel1 As Panel
    Private WithEvents pictureBox1 As PictureBox
End Class
