<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HorarioEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HorarioEmpleado))
        Me.BtnEliminarHorario = New System.Windows.Forms.Button()
        Me.BtnActualizarHorario = New System.Windows.Forms.Button()
        Me.BtnAgregarHorario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtHrS = New System.Windows.Forms.TextBox()
        Me.TxtHrE = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraentradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HorarioEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Floreria20DataSet1 = New PFR_Floreria.Floreria20DataSet1()
        Me.Horario_EmpleadoTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.Horario_EmpleadoTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminarHorario
        '
        Me.BtnEliminarHorario.BackColor = System.Drawing.Color.Black
        Me.BtnEliminarHorario.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarHorario.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarHorario.Location = New System.Drawing.Point(709, 222)
        Me.BtnEliminarHorario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminarHorario.Name = "BtnEliminarHorario"
        Me.BtnEliminarHorario.Size = New System.Drawing.Size(100, 45)
        Me.BtnEliminarHorario.TabIndex = 8
        Me.BtnEliminarHorario.Text = "ELIMINAR"
        Me.BtnEliminarHorario.UseVisualStyleBackColor = False
        '
        'BtnActualizarHorario
        '
        Me.BtnActualizarHorario.BackColor = System.Drawing.Color.Black
        Me.BtnActualizarHorario.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarHorario.ForeColor = System.Drawing.Color.White
        Me.BtnActualizarHorario.Location = New System.Drawing.Point(588, 223)
        Me.BtnActualizarHorario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnActualizarHorario.Name = "BtnActualizarHorario"
        Me.BtnActualizarHorario.Size = New System.Drawing.Size(115, 44)
        Me.BtnActualizarHorario.TabIndex = 7
        Me.BtnActualizarHorario.Text = "ACTUALIZAR"
        Me.BtnActualizarHorario.UseVisualStyleBackColor = False
        '
        'BtnAgregarHorario
        '
        Me.BtnAgregarHorario.BackColor = System.Drawing.Color.Black
        Me.BtnAgregarHorario.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarHorario.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarHorario.Location = New System.Drawing.Point(472, 222)
        Me.BtnAgregarHorario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarHorario.Name = "BtnAgregarHorario"
        Me.BtnAgregarHorario.Size = New System.Drawing.Size(110, 45)
        Me.BtnAgregarHorario.TabIndex = 6
        Me.BtnAgregarHorario.Text = "AGREGAR"
        Me.BtnAgregarHorario.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("212 Orion Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(553, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "HORARIO EMPLEADO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(469, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hora de entrada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(469, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Hora de salida"
        '
        'TxtHrS
        '
        Me.TxtHrS.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHrS.Location = New System.Drawing.Point(608, 159)
        Me.TxtHrS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtHrS.Name = "TxtHrS"
        Me.TxtHrS.Size = New System.Drawing.Size(195, 31)
        Me.TxtHrS.TabIndex = 14
        '
        'TxtHrE
        '
        Me.TxtHrE.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHrE.Location = New System.Drawing.Point(608, 116)
        Me.TxtHrE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtHrE.Name = "TxtHrE"
        Me.TxtHrE.Size = New System.Drawing.Size(195, 31)
        Me.TxtHrE.TabIndex = 15
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.HoraentradaDataGridViewTextBoxColumn, Me.HorasalidaDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.HorarioEmpleadoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(21, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(401, 257)
        Me.DataGridView1.TabIndex = 16
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
        'HoraentradaDataGridViewTextBoxColumn
        '
        Me.HoraentradaDataGridViewTextBoxColumn.DataPropertyName = "hora_entrada"
        Me.HoraentradaDataGridViewTextBoxColumn.HeaderText = "hora_entrada"
        Me.HoraentradaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoraentradaDataGridViewTextBoxColumn.Name = "HoraentradaDataGridViewTextBoxColumn"
        Me.HoraentradaDataGridViewTextBoxColumn.Width = 125
        '
        'HorasalidaDataGridViewTextBoxColumn
        '
        Me.HorasalidaDataGridViewTextBoxColumn.DataPropertyName = "hora_salida"
        Me.HorasalidaDataGridViewTextBoxColumn.HeaderText = "hora_salida"
        Me.HorasalidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HorasalidaDataGridViewTextBoxColumn.Name = "HorasalidaDataGridViewTextBoxColumn"
        Me.HorasalidaDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.Width = 125
        '
        'HorarioEmpleadoBindingSource
        '
        Me.HorarioEmpleadoBindingSource.DataMember = "Horario_Empleado"
        Me.HorarioEmpleadoBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'Floreria20DataSet1
        '
        Me.Floreria20DataSet1.DataSetName = "Floreria20DataSet1"
        Me.Floreria20DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Horario_EmpleadoTableAdapter
        '
        Me.Horario_EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.pictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-79, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(911, 49)
        Me.Panel1.TabIndex = 54
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(827, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(61, 49)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 70
        Me.pictureBox1.TabStop = False
        '
        'HorarioEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(815, 377)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtHrE)
        Me.Controls.Add(Me.TxtHrS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEliminarHorario)
        Me.Controls.Add(Me.BtnActualizarHorario)
        Me.Controls.Add(Me.BtnAgregarHorario)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "HorarioEmpleado"
        Me.Text = "HorarioEmpleado"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEliminarHorario As Button
    Friend WithEvents BtnActualizarHorario As Button
    Friend WithEvents BtnAgregarHorario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtHrS As TextBox
    Friend WithEvents TxtHrE As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Floreria20DataSet1 As Floreria20DataSet1
    Friend WithEvents HorarioEmpleadoBindingSource As BindingSource
    Friend WithEvents Horario_EmpleadoTableAdapter As Floreria20DataSet1TableAdapters.Horario_EmpleadoTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraentradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorasalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Panel1 As Panel
    Private WithEvents pictureBox1 As PictureBox
End Class
