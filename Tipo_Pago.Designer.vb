﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_Pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tipo_Pago))
        Me.TxtDescripcionTipoPago = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEliminarTipoPago = New System.Windows.Forms.Button()
        Me.BtnActualizarTipoPago = New System.Windows.Forms.Button()
        Me.BtnAgregarTipoPago = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmpleadocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Floreria20DataSet1 = New PFR_Floreria.Floreria20DataSet1()
        Me.Tipo_PagoTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.Tipo_PagoTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDescripcionTipoPago
        '
        Me.TxtDescripcionTipoPago.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcionTipoPago.Location = New System.Drawing.Point(408, 139)
        Me.TxtDescripcionTipoPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDescripcionTipoPago.Name = "TxtDescripcionTipoPago"
        Me.TxtDescripcionTipoPago.Size = New System.Drawing.Size(332, 31)
        Me.TxtDescripcionTipoPago.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(405, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Descripcion"
        '
        'BtnEliminarTipoPago
        '
        Me.BtnEliminarTipoPago.BackColor = System.Drawing.Color.Black
        Me.BtnEliminarTipoPago.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarTipoPago.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarTipoPago.Location = New System.Drawing.Point(642, 194)
        Me.BtnEliminarTipoPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminarTipoPago.Name = "BtnEliminarTipoPago"
        Me.BtnEliminarTipoPago.Size = New System.Drawing.Size(98, 41)
        Me.BtnEliminarTipoPago.TabIndex = 46
        Me.BtnEliminarTipoPago.Text = "ELIMINAR"
        Me.BtnEliminarTipoPago.UseVisualStyleBackColor = False
        '
        'BtnActualizarTipoPago
        '
        Me.BtnActualizarTipoPago.BackColor = System.Drawing.Color.Black
        Me.BtnActualizarTipoPago.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarTipoPago.ForeColor = System.Drawing.Color.White
        Me.BtnActualizarTipoPago.Location = New System.Drawing.Point(510, 194)
        Me.BtnActualizarTipoPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnActualizarTipoPago.Name = "BtnActualizarTipoPago"
        Me.BtnActualizarTipoPago.Size = New System.Drawing.Size(115, 41)
        Me.BtnActualizarTipoPago.TabIndex = 45
        Me.BtnActualizarTipoPago.Text = "ACTUALIZAR"
        Me.BtnActualizarTipoPago.UseVisualStyleBackColor = False
        '
        'BtnAgregarTipoPago
        '
        Me.BtnAgregarTipoPago.BackColor = System.Drawing.Color.Black
        Me.BtnAgregarTipoPago.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarTipoPago.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarTipoPago.Location = New System.Drawing.Point(408, 194)
        Me.BtnAgregarTipoPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarTipoPago.Name = "BtnAgregarTipoPago"
        Me.BtnAgregarTipoPago.Size = New System.Drawing.Size(91, 41)
        Me.BtnAgregarTipoPago.TabIndex = 44
        Me.BtnAgregarTipoPago.Text = "AGREGAR"
        Me.BtnAgregarTipoPago.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("212 Orion Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(521, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "TIPOS DE PAGO"
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
        Me.DataGridView1.DataSource = Me.TipoPagoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(20, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(363, 268)
        Me.DataGridView1.TabIndex = 49
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
        'TipoPagoBindingSource
        '
        Me.TipoPagoBindingSource.DataMember = "Tipo_Pago"
        Me.TipoPagoBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'Floreria20DataSet1
        '
        Me.Floreria20DataSet1.DataSetName = "Floreria20DataSet1"
        Me.Floreria20DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tipo_PagoTableAdapter
        '
        Me.Tipo_PagoTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.pictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-27, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 49)
        Me.Panel1.TabIndex = 55
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(717, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(61, 49)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 70
        Me.pictureBox1.TabStop = False
        '
        'Tipo_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(752, 399)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtDescripcionTipoPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEliminarTipoPago)
        Me.Controls.Add(Me.BtnActualizarTipoPago)
        Me.Controls.Add(Me.BtnAgregarTipoPago)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Tipo_Pago"
        Me.Text = "Tipo_Pago"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDescripcionTipoPago As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEliminarTipoPago As Button
    Friend WithEvents BtnActualizarTipoPago As Button
    Friend WithEvents BtnAgregarTipoPago As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Floreria20DataSet1 As Floreria20DataSet1
    Friend WithEvents TipoPagoBindingSource As BindingSource
    Friend WithEvents Tipo_PagoTableAdapter As Floreria20DataSet1TableAdapters.Tipo_PagoTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EmpleadocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Private WithEvents pictureBox1 As PictureBox
End Class
