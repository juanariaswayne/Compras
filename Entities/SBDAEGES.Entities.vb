
Namespace Tables
    Public Class TBL_MENUS

        Private _id_menu As Int32
        Private _id_menupadre As Int32
        Private _descripcionmenu As String
        Private _posicionmenu As Int32
        Private _habilitadomenu As Boolean
        Private _urlmenu As String
        Private _formularioasociado As Boolean

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_MENU() As Int32
            Get
                Return Me._id_menu
            End Get
            Set(ByVal Value As Int32)
                Me._id_menu = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_MENUPADRE() As Int32
            Get
                Return Me._id_menupadre
            End Get
            Set(ByVal Value As Int32)
                Me._id_menupadre = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCIONMENU() As String
            Get
                Return Me._descripcionmenu
            End Get
            Set(ByVal Value As String)
                Me._descripcionmenu = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property POSICIONMENU() As Int32
            Get
                Return Me._posicionmenu
            End Get
            Set(ByVal Value As Int32)
                Me._posicionmenu = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property HABILITADOMENU() As Boolean
            Get
                Return Me._habilitadomenu
            End Get
            Set(ByVal Value As Boolean)
                Me._habilitadomenu = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property URLMENU() As String
            Get
                Return Me._urlmenu
            End Get
            Set(ByVal Value As String)
                Me._urlmenu = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property FORMULARIOASOCIADO() As Boolean
            Get
                Return Me._formularioasociado
            End Get
            Set(ByVal Value As Boolean)
                Me._formularioasociado = Value
            End Set
        End Property

    End Class 'TBL_MENUS
    Public Class TBL_PERFILES

        Private _id_perfil As Int32
        Private _nombreperfil As String
        Private _descripcionperfil As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_PERFIL() As Int32
            Get
                Return Me._id_perfil
            End Get
            Set(ByVal Value As Int32)
                Me._id_perfil = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property NOMBREPERFIL() As String
            Get
                Return Me._nombreperfil
            End Get
            Set(ByVal Value As String)
                Me._nombreperfil = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCIONPERFIL() As String
            Get
                Return Me._descripcionperfil
            End Get
            Set(ByVal Value As String)
                Me._descripcionperfil = Value
            End Set
        End Property

    End Class 'TBL_PERFILES
    Public Class TBL_PERFILESPERMISOS

        Private _id_perfilpermisos As Int32
        Private _id_perfil As Int32
        Private _id_menu As Int32
        Private _lectura As Boolean
        Private _escritura As Boolean
        Private _eliminacion As Boolean

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_PERFILPERMISOS() As Int32
            Get
                Return Me._id_perfilpermisos
            End Get
            Set(ByVal Value As Int32)
                Me._id_perfilpermisos = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_PERFIL() As Int32
            Get
                Return Me._id_perfil
            End Get
            Set(ByVal Value As Int32)
                Me._id_perfil = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_MENU() As Int32
            Get
                Return Me._id_menu
            End Get
            Set(ByVal Value As Int32)
                Me._id_menu = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property LECTURA() As Boolean
            Get
                Return Me._lectura
            End Get
            Set(ByVal Value As Boolean)
                Me._lectura = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property ESCRITURA() As Boolean
            Get
                Return Me._escritura
            End Get
            Set(ByVal Value As Boolean)
                Me._escritura = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property ELIMINACION() As Boolean
            Get
                Return Me._eliminacion
            End Get
            Set(ByVal Value As Boolean)
                Me._eliminacion = Value
            End Set
        End Property

    End Class 'TBL_PERFILESPERMISOS
    'Public Class TBL_USUARIOS

    '    Private _id_usuario As Int32
    '    Private _id_perfil As Int32
    '    Private _identificadorusuario As String
    '    Private _contraseniausuario As String
    '    Private _nombreusuario As String
    '    Private _inactivo As Boolean
    '    Private _sector_id As Int32
    '    Private _email As String

    '    Public Sub New()
    '        MyBase.New()
    '    End Sub

    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Int32</returns>
    '    ''' <remarks></remarks>
    '    Public Property ID_USUARIO() As Int32
    '        Get
    '            Return Me._id_usuario
    '        End Get
    '        Set(ByVal Value As Int32)
    '            Me._id_usuario = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Int32</returns>
    '    ''' <remarks></remarks>
    '    Public Property ID_PERFIL() As Int32
    '        Get
    '            Return Me._id_perfil
    '        End Get
    '        Set(ByVal Value As Int32)
    '            Me._id_perfil = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property IDENTIFICADORUSUARIO() As String
    '        Get
    '            Return Me._identificadorusuario
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._identificadorusuario = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property CONTRASENIAUSUARIO() As String
    '        Get
    '            Return Me._contraseniausuario
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._contraseniausuario = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property NOMBREUSUARIO() As String
    '        Get
    '            Return Me._nombreusuario
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._nombreusuario = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Boolean</returns>
    '    ''' <remarks></remarks>
    '    Public Property INACTIVO() As Boolean
    '        Get
    '            Return Me._inactivo
    '        End Get
    '        Set(ByVal Value As Boolean)
    '            Me._inactivo = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Int32</returns>
    '    ''' <remarks></remarks>
    '    Public Property SECTOR_ID() As Int32
    '        Get
    '            Return Me._sector_id
    '        End Get
    '        Set(ByVal Value As Int32)
    '            Me._sector_id = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property EMAIL() As String
    '        Get
    '            Return Me._email
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._email = Value
    '        End Set
    '    End Property

    'End Class 'TBL_USUARIOS
    Public Class TBL_USUARIOS

        Private _id_usuario As Int32
        Private _id_perfil As Int32
        Private _identificadorusuario As String
        Private _contraseniausuario As String
        Private _nombreusuario As String
        Private _inactivo As Boolean
        Private _sector_id As Int32
        Private _email As String
        Private _empresa As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_USUARIO() As Int32
            Get
                Return Me._id_usuario
            End Get
            Set(ByVal Value As Int32)
                Me._id_usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_PERFIL() As Int32
            Get
                Return Me._id_perfil
            End Get
            Set(ByVal Value As Int32)
                Me._id_perfil = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property IDENTIFICADORUSUARIO() As String
            Get
                Return Me._identificadorusuario
            End Get
            Set(ByVal Value As String)
                Me._identificadorusuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CONTRASENIAUSUARIO() As String
            Get
                Return Me._contraseniausuario
            End Get
            Set(ByVal Value As String)
                Me._contraseniausuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property NOMBREUSUARIO() As String
            Get
                Return Me._nombreusuario
            End Get
            Set(ByVal Value As String)
                Me._nombreusuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property INACTIVO() As Boolean
            Get
                Return Me._inactivo
            End Get
            Set(ByVal Value As Boolean)
                Me._inactivo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTOR_ID() As Int32
            Get
                Return Me._sector_id
            End Get
            Set(ByVal Value As Int32)
                Me._sector_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property EMAIL() As String
            Get
                Return Me._email
            End Get
            Set(ByVal Value As String)
                Me._email = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property EMPRESA() As String
            Get
                Return Me._empresa
            End Get
            Set(ByVal Value As String)
                Me._empresa = Value
            End Set
        End Property

    End Class 'TBL_USUARIOS
    Public Class PROVSEGUIMIENTO

        Private _ccoemp_codigo As String
        Private _ccosuc_cod As String
        Private _cco_id As Int32
        Private _ccotco_cod As String
        Private _cco_letra As String
        Private _cco_codpvt As String
        Private _cco_nro As String
        Private _cco_femision As DateTime
        Private _cco_fvto As DateTime
        Private _cco_impmonloc As Double
        Private _cco_saldomonloc As Double
        Private _cco_codpro As String
        Private _ccopro_razsoc As String
        Private _tiporeclamo As Int32
        Private _estado_id As Int32
        Private _usuario As String
        Private _adeudanc As Boolean
        Private _fechaultimoreclamo As DateTime

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' Código de empresa
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCOEMP_CODIGO() As String
            Get
                Return Me._ccoemp_codigo
            End Get
            Set(ByVal Value As String)
                Me._ccoemp_codigo = Value
            End Set
        End Property
        ''' <summary>
        ''' Código de sucursal.
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCOSUC_COD() As String
            Get
                Return Me._ccosuc_cod
            End Get
            Set(ByVal Value As String)
                Me._ccosuc_cod = Value
            End Set
        End Property
        ''' <summary>
        ''' Identificador del comprobante
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property CCO_ID() As Int32
            Get
                Return Me._cco_id
            End Get
            Set(ByVal Value As Int32)
                Me._cco_id = Value
            End Set
        End Property
        ''' <summary>
        ''' Tipo de comprobante
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCOTCO_COD() As String
            Get
                Return Me._ccotco_cod
            End Get
            Set(ByVal Value As String)
                Me._ccotco_cod = Value
            End Set
        End Property
        ''' <summary>
        ''' letra comprobante
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCO_LETRA() As String
            Get
                Return Me._cco_letra
            End Get
            Set(ByVal Value As String)
                Me._cco_letra = Value
            End Set
        End Property
        ''' <summary>
        ''' Punto de venta
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCO_CODPVT() As String
            Get
                Return Me._cco_codpvt
            End Get
            Set(ByVal Value As String)
                Me._cco_codpvt = Value
            End Set
        End Property
        ''' <summary>
        ''' Nro de comprobante
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCO_NRO() As String
            Get
                Return Me._cco_nro
            End Get
            Set(ByVal Value As String)
                Me._cco_nro = Value
            End Set
        End Property
        ''' <summary>
        ''' fecha de Emision
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property CCO_FEMISION() As DateTime
            Get
                Return Me._cco_femision
            End Get
            Set(ByVal Value As DateTime)
                Me._cco_femision = Value
            End Set
        End Property
        ''' <summary>
        ''' fecha de vto
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property CCO_FVTO() As DateTime
            Get
                Return Me._cco_fvto
            End Get
            Set(ByVal Value As DateTime)
                Me._cco_fvto = Value
            End Set
        End Property
        ''' <summary>
        ''' Importe
        ''' </summary>
        ''' <value></value>
        ''' <returns>Double</returns>
        ''' <remarks></remarks>
        Public Property CCO_IMPMONLOC() As Double
            Get
                Return Me._cco_impmonloc
            End Get
            Set(ByVal Value As Double)
                Me._cco_impmonloc = Value
            End Set
        End Property
        ''' <summary>
        ''' Saldo
        ''' </summary>
        ''' <value></value>
        ''' <returns>Double</returns>
        ''' <remarks></remarks>
        Public Property CCO_SALDOMONLOC() As Double
            Get
                Return Me._cco_saldomonloc
            End Get
            Set(ByVal Value As Double)
                Me._cco_saldomonloc = Value
            End Set
        End Property
        ''' <summary>
        ''' Codigo Proveedor
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCO_CODPRO() As String
            Get
                Return Me._cco_codpro
            End Get
            Set(ByVal Value As String)
                Me._cco_codpro = Value
            End Set
        End Property
        ''' <summary>
        ''' Nombre Proveedor
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCOPRO_RAZSOC() As String
            Get
                Return Me._ccopro_razsoc
            End Get
            Set(ByVal Value As String)
                Me._ccopro_razsoc = Value
            End Set
        End Property
        ''' <summary>
        ''' N: Normal / C: Crítico / U: Urgente
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property TIPORECLAMO() As Int32
            Get
                Return Me._tiporeclamo
            End Get
            Set(ByVal Value As Int32)
                Me._tiporeclamo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ESTADO_ID() As Int32
            Get
                Return Me._estado_id
            End Get
            Set(ByVal Value As Int32)
                Me._estado_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property ADEUDANC() As Boolean
            Get
                Return Me._adeudanc
            End Get
            Set(ByVal Value As Boolean)
                Me._adeudanc = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAULTIMORECLAMO() As DateTime
            Get
                Return Me._fechaultimoreclamo
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaultimoreclamo = Value
            End Set
        End Property

    End Class 'PROVSEGUIMIENTO
    Public Class ESTADORECLAMOPROVEEDOR

        Private _estado_id As Int32
        Private _descripcion As String

        Public Sub New()
            MyBase.New()
        End Sub


        Public Property ESTADO_ID() As Int32
            Get
                Return Me._estado_id
            End Get
            Set(ByVal Value As Int32)
                Me._estado_id = Value
            End Set
        End Property

        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property

    End Class 'ESTADORECLAMOPROVEEDOR
    Public Class TIPORECLAMOPROVEEDOR

        Private _tiporeclamo As Int32
        Private _descripcion As String

        Public Sub New()
            MyBase.New()
        End Sub


        Public Property TIPORECLAMO() As Int32
            Get
                Return Me._tiporeclamo
            End Get
            Set(ByVal Value As Int32)
                Me._tiporeclamo = Value
            End Set
        End Property

        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property

    End Class 'TIPORECLAMOPROVEEDOR
    Public Class ENTREGAORDENPAGO

        Private _ccoemp_codigo As String
        Private _ccosuc_cod As String
        Private _cco_id As Int32
        Private _cco_nro As String
        Private _cco_femision As DateTime
        Private _cco_impmonloc As Double
        Private _cco_codpro As String
        Private _ccopro_razsoc As String
        Private _fecharetiro As DateTime
        Private _usuario As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCOEMP_CODIGO() As String
            Get
                Return Me._ccoemp_codigo
            End Get
            Set(ByVal Value As String)
                Me._ccoemp_codigo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCOSUC_COD() As String
            Get
                Return Me._ccosuc_cod
            End Get
            Set(ByVal Value As String)
                Me._ccosuc_cod = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property CCO_ID() As Int32
            Get
                Return Me._cco_id
            End Get
            Set(ByVal Value As Int32)
                Me._cco_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCO_NRO() As String
            Get
                Return Me._cco_nro
            End Get
            Set(ByVal Value As String)
                Me._cco_nro = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property CCO_FEMISION() As DateTime
            Get
                Return Me._cco_femision
            End Get
            Set(ByVal Value As DateTime)
                Me._cco_femision = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Double</returns>
        ''' <remarks></remarks>
        Public Property CCO_IMPMONLOC() As Double
            Get
                Return Me._cco_impmonloc
            End Get
            Set(ByVal Value As Double)
                Me._cco_impmonloc = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCO_CODPRO() As String
            Get
                Return Me._cco_codpro
            End Get
            Set(ByVal Value As String)
                Me._cco_codpro = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCOPRO_RAZSOC() As String
            Get
                Return Me._ccopro_razsoc
            End Get
            Set(ByVal Value As String)
                Me._ccopro_razsoc = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHARETIRO() As DateTime
            Get
                Return Me._fecharetiro
            End Get
            Set(ByVal Value As DateTime)
                Me._fecharetiro = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property

    End Class 'ENTREGAORDENPAGO
    Public Class HISTORIALSEGUIMIENTO

        Private _id As Int32
        Private _ccoemp_codigo As String
        Private _ccosuc_cod As String
        Private _cco_id As Int32
        Private _fecha As DateTime
        Private _obs As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID() As Int32
            Get
                Return Me._id
            End Get
            Set(ByVal Value As Int32)
                Me._id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCOEMP_CODIGO() As String
            Get
                Return Me._ccoemp_codigo
            End Get
            Set(ByVal Value As String)
                Me._ccoemp_codigo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCOSUC_COD() As String
            Get
                Return Me._ccosuc_cod
            End Get
            Set(ByVal Value As String)
                Me._ccosuc_cod = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property CCO_ID() As Int32
            Get
                Return Me._cco_id
            End Get
            Set(ByVal Value As Int32)
                Me._cco_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property OBS() As String
            Get
                Return Me._obs
            End Get
            Set(ByVal Value As String)
                Me._obs = Value
            End Set
        End Property

    End Class 'HISTORIALSEGUIMIENTO
    Public Class RECLAMOFACTURASINCARGAR

        Private _id As Int32
        Private _ccoemp_Codigo As String
        Private _cco_codpro As String
        Private _ccopro_razsoc As String
        Private _cco_nro As String
        Private _cco_femision As DateTime
        Private _cco_impmonloc As Double
        Private _fechareclamo As DateTime
        Private _usuario As String
        Private _enbejerman As Int32
        Private _obs As String

        Public Sub New()
            MyBase.New()

        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID() As Int32
            Get
                Return Me._id
            End Get
            Set(ByVal Value As Int32)
                Me._id = Value
            End Set
        End Property

        Public Property CCOEMP_CODIGO() As String
            Get
                Return Me._ccoemp_Codigo
            End Get
            Set(ByVal Value As String)
                Me._ccoemp_Codigo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCO_CODPRO() As String
            Get
                Return Me._cco_codpro
            End Get
            Set(ByVal Value As String)
                Me._cco_codpro = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCOPRO_RAZSOC() As String
            Get
                Return Me._ccopro_razsoc
            End Get
            Set(ByVal Value As String)
                Me._ccopro_razsoc = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CCO_NRO() As String
            Get
                Return Me._cco_nro
            End Get
            Set(ByVal Value As String)
                Me._cco_nro = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property CCO_FEMISION() As DateTime
            Get
                Return Me._cco_femision
            End Get
            Set(ByVal Value As DateTime)
                Me._cco_femision = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Double</returns>
        ''' <remarks></remarks>
        Public Property CCO_IMPMONLOC() As Double
            Get
                Return Me._cco_impmonloc
            End Get
            Set(ByVal Value As Double)
                Me._cco_impmonloc = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHARECLAMO() As DateTime
            Get
                Return Me._fechareclamo
            End Get
            Set(ByVal Value As DateTime)
                Me._fechareclamo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ENBEJERMAN() As Int32
            Get
                Return Me._enbejerman
            End Get
            Set(ByVal Value As Int32)
                Me._enbejerman = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property OBS() As String
            Get
                Return Me._obs
            End Get
            Set(ByVal Value As String)
                Me._obs = Value
            End Set
        End Property

    End Class 'RECLAMOFACTURASINCARGAR
    Public Class STKENVIOSARTICULOS

        Private _codemp As String
        Private _fecha As DateTime
        Private _id_articulo As String
        Private _unimed As String
        Private _cantidad As Decimal
        Private _usuario As String
        Private _obs As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ID_ARTICULO() As String
            Get
                Return Me._id_articulo
            End Get
            Set(ByVal Value As String)
                Me._id_articulo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property OBS() As String
            Get
                Return Me._obs
            End Get
            Set(ByVal Value As String)
                Me._obs = Value
            End Set
        End Property

    End Class 'STKENVIOSARTICULOS
    Public Class COMAUTORIZACION

        Private _nivel_id As Int32
        Private _descripcion As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NIVEL_ID() As Int32
            Get
                Return Me._nivel_id
            End Get
            Set(ByVal Value As Int32)
                Me._nivel_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property

    End Class 'COMAUTORIZACION
    Public Class COMESTADO

        Private _estado_id As Int32
        Private _descripcion As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ESTADO_ID() As Int32
            Get
                Return Me._estado_id
            End Get
            Set(ByVal Value As Int32)
                Me._estado_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property

    End Class 'COMESTADO

    'Public Class COMORDENCOMPRA

    '    Private _codemp As String
    '    Private _ordencompra_id As Int32
    '    Private _codemprequerimiento As String
    '    Private _requerimiento_id As Int32
    '    Private _fecha As DateTime
    '    Private _proveed_id As String
    '    Private _sectorrequerimiento_id As Int32
    '    Private _estado_id As Int32
    '    Private _tipooc_id As Int32
    '    Private _modificacosto As Int32
    '    Private _condicionpago_id As String
    '    Private _obs As String
    '    Private _usuario As String
    '    Private _usuarioautoriza As String
    '    Private _pdc As Decimal
    '    Private _fechaautorizacion As DateTime
    '    Private _motivofinaliz_anulacion As String
    '    Private _fechafinaliz_anulacion As DateTime
    '    Private _pedidodiario As Boolean
    '    Private _proveed_original As String
    '    Private _sectorentrega_id As Int32

    '    Public Sub New()
    '        MyBase.New()
    '    End Sub

    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property CODEMP() As String
    '        Get
    '            Return Me._codemp
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._codemp = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Int32</returns>
    '    ''' <remarks></remarks>
    '    Public Property ORDENCOMPRA_ID() As Int32
    '        Get
    '            Return Me._ordencompra_id
    '        End Get
    '        Set(ByVal Value As Int32)
    '            Me._ordencompra_id = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property CODEMPREQUERIMIENTO() As String
    '        Get
    '            Return Me._codemprequerimiento
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._codemprequerimiento = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Int32</returns>
    '    ''' <remarks></remarks>
    '    Public Property REQUERIMIENTO_ID() As Int32
    '        Get
    '            Return Me._requerimiento_id
    '        End Get
    '        Set(ByVal Value As Int32)
    '            Me._requerimiento_id = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>DateTime</returns>
    '    ''' <remarks></remarks>
    '    Public Property FECHA() As DateTime
    '        Get
    '            Return Me._fecha
    '        End Get
    '        Set(ByVal Value As DateTime)
    '            Me._fecha = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property PROVEED_ID() As String
    '        Get
    '            Return Me._proveed_id
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._proveed_id = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Int32</returns>
    '    ''' <remarks></remarks>
    '    Public Property SECTORREQUERIMIENTO_ID() As Int32
    '        Get
    '            Return Me._sectorrequerimiento_id
    '        End Get
    '        Set(ByVal Value As Int32)
    '            Me._sectorrequerimiento_id = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Int32</returns>
    '    ''' <remarks></remarks>
    '    Public Property ESTADO_ID() As Int32
    '        Get
    '            Return Me._estado_id
    '        End Get
    '        Set(ByVal Value As Int32)
    '            Me._estado_id = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Int32</returns>
    '    ''' <remarks></remarks>
    '    Public Property TIPOOC_ID() As Int32
    '        Get
    '            Return Me._tipooc_id
    '        End Get
    '        Set(ByVal Value As Int32)
    '            Me._tipooc_id = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Int32</returns>
    '    ''' <remarks></remarks>
    '    Public Property MODIFICACOSTO() As Int32
    '        Get
    '            Return Me._modificacosto
    '        End Get
    '        Set(ByVal Value As Int32)
    '            Me._modificacosto = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property CONDICIONPAGO_ID() As String
    '        Get
    '            Return Me._condicionpago_id
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._condicionpago_id = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property OBS() As String
    '        Get
    '            Return Me._obs
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._obs = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property USUARIO() As String
    '        Get
    '            Return Me._usuario
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._usuario = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property USUARIOAUTORIZA() As String
    '        Get
    '            Return Me._usuarioautoriza
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._usuarioautoriza = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Decimal</returns>
    '    ''' <remarks></remarks>
    '    Public Property PDC() As Decimal
    '        Get
    '            Return Me._pdc
    '        End Get
    '        Set(ByVal Value As Decimal)
    '            Me._pdc = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>DateTime</returns>
    '    ''' <remarks></remarks>
    '    Public Property FECHAAUTORIZACION() As DateTime
    '        Get
    '            Return Me._fechaautorizacion
    '        End Get
    '        Set(ByVal Value As DateTime)
    '            Me._fechaautorizacion = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property MOTIVOFINALIZ_ANULACION() As String
    '        Get
    '            Return Me._motivofinaliz_anulacion
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._motivofinaliz_anulacion = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>DateTime</returns>
    '    ''' <remarks></remarks>
    '    Public Property FECHAFINALIZ_ANULACION() As DateTime
    '        Get
    '            Return Me._fechafinaliz_anulacion
    '        End Get
    '        Set(ByVal Value As DateTime)
    '            Me._fechafinaliz_anulacion = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Boolean</returns>
    '    ''' <remarks></remarks>
    '    Public Property PEDIDODIARIO() As Boolean
    '        Get
    '            Return Me._pedidodiario
    '        End Get
    '        Set(ByVal Value As Boolean)
    '            Me._pedidodiario = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>String</returns>
    '    ''' <remarks></remarks>
    '    Public Property PROVEED_ORIGINAL() As String
    '        Get
    '            Return Me._proveed_original
    '        End Get
    '        Set(ByVal Value As String)
    '            Me._proveed_original = Value
    '        End Set
    '    End Property
    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <value></value>
    '    ''' <returns>Int32</returns>
    '    ''' <remarks></remarks>
    '    Public Property SECTORENTREGA_ID() As Int32
    '        Get
    '            Return Me._sectorentrega_id
    '        End Get
    '        Set(ByVal Value As Int32)
    '            Me._sectorentrega_id = Value
    '        End Set
    '    End Property

    'End Class 'COMORDENCOMPRA

    Public Class COMORDENCOMPRA

        Private _codemp As String
        Private _ordencompra_id As Int32
        Private _codemprequerimiento As String
        Private _requerimiento_id As Int32
        Private _fecha As DateTime
        Private _proveed_id As String
        Private _sectorrequerimiento_id As Int32
        Private _estado_id As Int32
        Private _tipooc_id As Int32
        Private _modificacosto As Int32
        Private _condicionpago_id As String
        Private _obs As String
        Private _usuario As String
        Private _usuarioautoriza As String
        Private _pdc As Decimal
        Private _fechaautorizacion As DateTime
        Private _motivofinaliz_anulacion As String
        Private _fechafinaliz_anulacion As DateTime
        Private _pedidodiario As Boolean
        Private _proveed_original As String
        Private _sectorentrega_id As Int32
        Private _tipoprorrateo As Int16

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ORDENCOMPRA_ID() As Int32
            Get
                Return Me._ordencompra_id
            End Get
            Set(ByVal Value As Int32)
                Me._ordencompra_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMPREQUERIMIENTO() As String
            Get
                Return Me._codemprequerimiento
            End Get
            Set(ByVal Value As String)
                Me._codemprequerimiento = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property PROVEED_ID() As String
            Get
                Return Me._proveed_id
            End Get
            Set(ByVal Value As String)
                Me._proveed_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORREQUERIMIENTO_ID() As Int32
            Get
                Return Me._sectorrequerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectorrequerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ESTADO_ID() As Int32
            Get
                Return Me._estado_id
            End Get
            Set(ByVal Value As Int32)
                Me._estado_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property TIPOOC_ID() As Int32
            Get
                Return Me._tipooc_id
            End Get
            Set(ByVal Value As Int32)
                Me._tipooc_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property MODIFICACOSTO() As Int32
            Get
                Return Me._modificacosto
            End Get
            Set(ByVal Value As Int32)
                Me._modificacosto = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CONDICIONPAGO_ID() As String
            Get
                Return Me._condicionpago_id
            End Get
            Set(ByVal Value As String)
                Me._condicionpago_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property OBS() As String
            Get
                Return Me._obs
            End Get
            Set(ByVal Value As String)
                Me._obs = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIOAUTORIZA() As String
            Get
                Return Me._usuarioautoriza
            End Get
            Set(ByVal Value As String)
                Me._usuarioautoriza = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property PDC() As Decimal
            Get
                Return Me._pdc
            End Get
            Set(ByVal Value As Decimal)
                Me._pdc = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAAUTORIZACION() As DateTime
            Get
                Return Me._fechaautorizacion
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaautorizacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MOTIVOFINALIZ_ANULACION() As String
            Get
                Return Me._motivofinaliz_anulacion
            End Get
            Set(ByVal Value As String)
                Me._motivofinaliz_anulacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAFINALIZ_ANULACION() As DateTime
            Get
                Return Me._fechafinaliz_anulacion
            End Get
            Set(ByVal Value As DateTime)
                Me._fechafinaliz_anulacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property PEDIDODIARIO() As Boolean
            Get
                Return Me._pedidodiario
            End Get
            Set(ByVal Value As Boolean)
                Me._pedidodiario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property PROVEED_ORIGINAL() As String
            Get
                Return Me._proveed_original
            End Get
            Set(ByVal Value As String)
                Me._proveed_original = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORENTREGA_ID() As Int32
            Get
                Return Me._sectorentrega_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectorentrega_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int16</returns>
        ''' <remarks></remarks>
        Public Property TIPOPRORRATEO() As Int16
            Get
                Return Me._tipoprorrateo
            End Get
            Set(ByVal Value As Int16)
                Me._tipoprorrateo = Value
            End Set
        End Property

    End Class 'COMORDENCOMPRA

    Public Class COMORDENCOMPRAITEM

        Private _codemp As String
        Private _ordencompra_id As Int32
        Private _nroitem As Int32
        Private _articulo_id As String
        Private _unimed As String
        Private _cantidad As Decimal
        Private _precio As Decimal
        Private _nivelaut_id As Int32
        Private _fechaentrega As DateTime
        Private _fechaentrega1 As DateTime
        Private _cantidad1 As Decimal
        Private _embalaje As String
        Private _marca As String
        Private _codemprequerimiento As String
        Private _requerimiento_id As Int32
        Private _cantidadoriginal As Decimal
        Private _preciooriginal As Decimal
        Private _excluido As Boolean
        Private _motivoexclusion As String
        Private _usuarioexcluye As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ORDENCOMPRA_ID() As Int32
            Get
                Return Me._ordencompra_id
            End Get
            Set(ByVal Value As Int32)
                Me._ordencompra_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property PRECIO() As Decimal
            Get
                Return Me._precio
            End Get
            Set(ByVal Value As Decimal)
                Me._precio = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NIVELAUT_ID() As Int32
            Get
                Return Me._nivelaut_id
            End Get
            Set(ByVal Value As Int32)
                Me._nivelaut_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAENTREGA() As DateTime
            Get
                Return Me._fechaentrega
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaentrega = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAENTREGA1() As DateTime
            Get
                Return Me._fechaentrega1
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaentrega1 = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD1() As Decimal
            Get
                Return Me._cantidad1
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad1 = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property EMBALAJE() As String
            Get
                Return Me._embalaje
            End Get
            Set(ByVal Value As String)
                Me._embalaje = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MARCA() As String
            Get
                Return Me._marca
            End Get
            Set(ByVal Value As String)
                Me._marca = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMPREQUERIMIENTO() As String
            Get
                Return Me._codemprequerimiento
            End Get
            Set(ByVal Value As String)
                Me._codemprequerimiento = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDADORIGINAL() As Decimal
            Get
                Return Me._cantidadoriginal
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidadoriginal = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property PRECIOORIGINAL() As Decimal
            Get
                Return Me._preciooriginal
            End Get
            Set(ByVal Value As Decimal)
                Me._preciooriginal = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property EXCLUIDO() As Boolean
            Get
                Return Me._excluido
            End Get
            Set(ByVal Value As Boolean)
                Me._excluido = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MOTIVOEXCLUSION() As String
            Get
                Return Me._motivoexclusion
            End Get
            Set(ByVal Value As String)
                Me._motivoexclusion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIOEXCLUYE() As String
            Get
                Return Me._usuarioexcluye
            End Get
            Set(ByVal Value As String)
                Me._usuarioexcluye = Value
            End Set
        End Property

    End Class 'COMORDENCOMPRAITEM

    Public Class COMREQUERIMIENTO

        Private _codemp As String
        Private _requerimiento_id As Int32
        Private _fecha As DateTime
        Private _sectorrequerimiento_id As Int32
        Private _proveed_id As String
        Private _estado_id As Int32
        Private _obs As String
        Private _usuario As String
        Private _usuarioautoriza As String
        Private _fechaautorizacion As DateTime
        Private _motivoanulacion As String
        Private _pedidodiario As Boolean
        Private _sectorentrega_id As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORREQUERIMIENTO_ID() As Int32
            Get
                Return Me._sectorrequerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectorrequerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property PROVEED_ID() As String
            Get
                Return Me._proveed_id
            End Get
            Set(ByVal Value As String)
                Me._proveed_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ESTADO_ID() As Int32
            Get
                Return Me._estado_id
            End Get
            Set(ByVal Value As Int32)
                Me._estado_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property OBS() As String
            Get
                Return Me._obs
            End Get
            Set(ByVal Value As String)
                Me._obs = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIOAUTORIZA() As String
            Get
                Return Me._usuarioautoriza
            End Get
            Set(ByVal Value As String)
                Me._usuarioautoriza = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAAUTORIZACION() As DateTime
            Get
                Return Me._fechaautorizacion
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaautorizacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MOTIVOANULACION() As String
            Get
                Return Me._motivoanulacion
            End Get
            Set(ByVal Value As String)
                Me._motivoanulacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property PEDIDODIARIO() As Boolean
            Get
                Return Me._pedidodiario
            End Get
            Set(ByVal Value As Boolean)
                Me._pedidodiario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORENTREGA_ID() As Int32
            Get
                Return Me._sectorentrega_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectorentrega_id = Value
            End Set
        End Property

    End Class 'COMREQUERIMIENTO

    Public Class COMREQUERIMIENTOITEM

        Private _codemp As String
        Private _requerimiento_id As Int32
        Private _nroitem As Int32
        Private _articulo_id As String
        Private _unimed As String
        Private _cantidad As Decimal
        Private _nivelaut_id As Int32
        Private _fechaentrega As DateTime
        Private _marca As String
        Private _excluido As Int32
        Private _motivoexclusion As String
        Private _usuarioexcluye As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NIVELAUT_ID() As Int32
            Get
                Return Me._nivelaut_id
            End Get
            Set(ByVal Value As Int32)
                Me._nivelaut_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAENTREGA() As DateTime
            Get
                Return Me._fechaentrega
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaentrega = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MARCA() As String
            Get
                Return Me._marca
            End Get
            Set(ByVal Value As String)
                Me._marca = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property EXCLUIDO() As Int32
            Get
                Return Me._excluido
            End Get
            Set(ByVal Value As Int32)
                Me._excluido = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MOTIVOEXCLUSION() As String
            Get
                Return Me._motivoexclusion
            End Get
            Set(ByVal Value As String)
                Me._motivoexclusion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIOEXCLUYE() As String
            Get
                Return Me._usuarioexcluye
            End Get
            Set(ByVal Value As String)
                Me._usuarioexcluye = Value
            End Set
        End Property

    End Class 'COMREQUERIMIENTOITEM
    Public Class COMREQUERIMIENTOORDENCOMPRA

        Private _codemp As String
        Private _requerimiento_id As Int32
        Private _nroitem As Int32
        Private _codempoc As String
        Private _ordencompra_id As Int32
        Private _nroitemoc As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMPOC() As String
            Get
                Return Me._codempoc
            End Get
            Set(ByVal Value As String)
                Me._codempoc = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ORDENCOMPRA_ID() As Int32
            Get
                Return Me._ordencompra_id
            End Get
            Set(ByVal Value As Int32)
                Me._ordencompra_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEMOC() As Int32
            Get
                Return Me._nroitemoc
            End Get
            Set(ByVal Value As Int32)
                Me._nroitemoc = Value
            End Set
        End Property

    End Class 'COMREQUERIMIENTOORDENCOMPRA

    Public Class COMSECTORREQUERIMIENTO

        Private _sectorrequerimiento_id As Int32
        Private _descripcion As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORREQUERIMIENTO_ID() As Int32
            Get
                Return Me._sectorrequerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectorrequerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property

    End Class 'COMSECTORREQUERIMIENTO
    Public Class COMTIPOOC

        Private _tipooc_id As Int32
        Private _descripcion As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property TIPOOC_ID() As Int32
            Get
                Return Me._tipooc_id
            End Get
            Set(ByVal Value As Int32)
                Me._tipooc_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property

    End Class 'COMTIPOOC
    Public Class STKARTICULOS

        Private _codemp As String
        Private _articulo_id As String
        Private _descripcion As String
        Private _toleranciaingstock As Decimal
        Private _stockminimo As Decimal
        Private _stockmaximo As Decimal
        Private _vaastock As Int32
        Private _unimedppal As String
        Private _unimedsec As String
        Private _factorconversion As Decimal
        Private _codigoim As Int32
        Private _mostrarenrequerimiento As Boolean
        Private _trazable As Boolean
        Private _codigosubcuenta As Int32
        Private _llevareceta As Boolean
        Private _llevavencimiento As Boolean

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property
        ''' <summary>
        ''' Es porcentaje
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property TOLERANCIAINGSTOCK() As Decimal
            Get
                Return Me._toleranciaingstock
            End Get
            Set(ByVal Value As Decimal)
                Me._toleranciaingstock = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property STOCKMINIMO() As Decimal
            Get
                Return Me._stockminimo
            End Get
            Set(ByVal Value As Decimal)
                Me._stockminimo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property STOCKMAXIMO() As Decimal
            Get
                Return Me._stockmaximo
            End Get
            Set(ByVal Value As Decimal)
                Me._stockmaximo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property VAASTOCK() As Int32
            Get
                Return Me._vaastock
            End Get
            Set(ByVal Value As Int32)
                Me._vaastock = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMEDPPAL() As String
            Get
                Return Me._unimedppal
            End Get
            Set(ByVal Value As String)
                Me._unimedppal = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMEDSEC() As String
            Get
                Return Me._unimedsec
            End Get
            Set(ByVal Value As String)
                Me._unimedsec = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property FACTORCONVERSION() As Decimal
            Get
                Return Me._factorconversion
            End Get
            Set(ByVal Value As Decimal)
                Me._factorconversion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property CODIGOIM() As Int32
            Get
                Return Me._codigoim
            End Get
            Set(ByVal Value As Int32)
                Me._codigoim = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property MOSTRARENREQUERIMIENTO() As Boolean
            Get
                Return Me._mostrarenrequerimiento
            End Get
            Set(ByVal Value As Boolean)
                Me._mostrarenrequerimiento = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property TRAZABLE() As Boolean
            Get
                Return Me._trazable
            End Get
            Set(ByVal Value As Boolean)
                Me._trazable = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property CODIGOSUBCUENTA() As Int32
            Get
                Return Me._codigosubcuenta
            End Get
            Set(ByVal Value As Int32)
                Me._codigosubcuenta = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property LLEVARECETA() As Boolean
            Get
                Return Me._llevareceta
            End Get
            Set(ByVal Value As Boolean)
                Me._llevareceta = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property LLEVAVENCIMIENTO() As Boolean
            Get
                Return Me._llevavencimiento
            End Get
            Set(ByVal Value As Boolean)
                Me._llevavencimiento = Value
            End Set
        End Property

    End Class 'STKARTICULOS

    Public Class STKDEPOSITO

        Private _codemp As String
        Private _deposito_id As Int32
        Private _descripcion As String
        Private _stocknegativo As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property DEPOSITO_ID() As Int32
            Get
                Return Me._deposito_id
            End Get
            Set(ByVal Value As Int32)
                Me._deposito_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property STOCKNEGATIVO() As Int32
            Get
                Return Me._stocknegativo
            End Get
            Set(ByVal Value As Int32)
                Me._stocknegativo = Value
            End Set
        End Property

    End Class 'STKDEPOSITO
    Public Class STKENTRANSITO

        Private _codemp As String
        Private _comprobante As Int32
        Private _nroitem As Int32
        Private _cantoriginal As Decimal
        Private _cantrecibida As Decimal
        Private _unimed As String
        Private _estado_id As Int32
        Private _usuariogenera As String
        Private _usuariorecibe As String
        Private _fecharecepcion As DateTime

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTE() As Int32
            Get
                Return Me._comprobante
            End Get
            Set(ByVal Value As Int32)
                Me._comprobante = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTORIGINAL() As Decimal
            Get
                Return Me._cantoriginal
            End Get
            Set(ByVal Value As Decimal)
                Me._cantoriginal = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTRECIBIDA() As Decimal
            Get
                Return Me._cantrecibida
            End Get
            Set(ByVal Value As Decimal)
                Me._cantrecibida = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ESTADO_ID() As Int32
            Get
                Return Me._estado_id
            End Get
            Set(ByVal Value As Int32)
                Me._estado_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIOGENERA() As String
            Get
                Return Me._usuariogenera
            End Get
            Set(ByVal Value As String)
                Me._usuariogenera = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIORECIBE() As String
            Get
                Return Me._usuariorecibe
            End Get
            Set(ByVal Value As String)
                Me._usuariorecibe = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHARECEPCION() As DateTime
            Get
                Return Me._fecharecepcion
            End Get
            Set(ByVal Value As DateTime)
                Me._fecharecepcion = Value
            End Set
        End Property

    End Class 'STKENTRANSITO

    Public Class STKINVENTARIO


        Private _articulo_id As String
        Private _deposito_id As Int32
        Private _sector_id As Int32
        Private _unimed As String
        Private _cantidad As Decimal

        Public Sub New()
            MyBase.New()
        End Sub

        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property DEPOSITO_ID() As Int32
            Get
                Return Me._deposito_id
            End Get
            Set(ByVal Value As Int32)
                Me._deposito_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTOR_ID() As Int32
            Get
                Return Me._sector_id
            End Get
            Set(ByVal Value As Int32)
                Me._sector_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property

    End Class 'STKINVENTARIO

    Public Class STKREMITO

        Private _codemp As String
        Private _sucursal As String
        Private _comprobante As Int32
        Private _letra As String
        Private _fecha As DateTime
        Private _codempstk As String
        Private _comprobantestk As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property SUCURSAL() As String
            Get
                Return Me._sucursal
            End Get
            Set(ByVal Value As String)
                Me._sucursal = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTE() As Int32
            Get
                Return Me._comprobante
            End Get
            Set(ByVal Value As Int32)
                Me._comprobante = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property LETRA() As String
            Get
                Return Me._letra
            End Get
            Set(ByVal Value As String)
                Me._letra = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMPSTK() As String
            Get
                Return Me._codempstk
            End Get
            Set(ByVal Value As String)
                Me._codempstk = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTESTK() As Int32
            Get
                Return Me._comprobantestk
            End Get
            Set(ByVal Value As Int32)
                Me._comprobantestk = Value
            End Set
        End Property

    End Class 'STKREMITO

    Public Class STKMOVIMIENTO

        Private _codemp As String
        Private _comprobante As Int32
        Private _tipomov_id As Int32
        Private _subtipomov_id As Int32
        Private _fechamov As DateTime
        Private _depositoorigen_id As Int32
        Private _sectororigen_id As Int32
        Private _depositodestino_id As Int32
        Private _sectordestino_id As Int32
        Private _usuario As String
        Private _anulado As Int32
        Private _obs As String
        Private _motivoajuste_id As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTE() As Int32
            Get
                Return Me._comprobante
            End Get
            Set(ByVal Value As Int32)
                Me._comprobante = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property TIPOMOV_ID() As Int32
            Get
                Return Me._tipomov_id
            End Get
            Set(ByVal Value As Int32)
                Me._tipomov_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SUBTIPOMOV_ID() As Int32
            Get
                Return Me._subtipomov_id
            End Get
            Set(ByVal Value As Int32)
                Me._subtipomov_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAMOV() As DateTime
            Get
                Return Me._fechamov
            End Get
            Set(ByVal Value As DateTime)
                Me._fechamov = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property DEPOSITOORIGEN_ID() As Int32
            Get
                Return Me._depositoorigen_id
            End Get
            Set(ByVal Value As Int32)
                Me._depositoorigen_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORORIGEN_ID() As Int32
            Get
                Return Me._sectororigen_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectororigen_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property DEPOSITODESTINO_ID() As Int32
            Get
                Return Me._depositodestino_id
            End Get
            Set(ByVal Value As Int32)
                Me._depositodestino_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORDESTINO_ID() As Int32
            Get
                Return Me._sectordestino_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectordestino_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ANULADO() As Int32
            Get
                Return Me._anulado
            End Get
            Set(ByVal Value As Int32)
                Me._anulado = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property OBS() As String
            Get
                Return Me._obs
            End Get
            Set(ByVal Value As String)
                Me._obs = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property MOTIVOAJUSTE_ID() As Int32
            Get
                Return Me._motivoajuste_id
            End Get
            Set(ByVal Value As Int32)
                Me._motivoajuste_id = Value
            End Set
        End Property

    End Class 'STKMOVIMIENTO

    Public Class STKMOVIMIENTOITEM

        Private _codemp As String
        Private _comprobante As Int32
        Private _nroitem As Int32
        Private _articulo_id As String
        Private _unimed As String
        Private _cantidad As Decimal
        Private _costouni As Decimal

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTE() As Int32
            Get
                Return Me._comprobante
            End Get
            Set(ByVal Value As Int32)
                Me._comprobante = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property COSTOUNI() As Decimal
            Get
                Return Me._costouni
            End Get
            Set(ByVal Value As Decimal)
                Me._costouni = Value
            End Set
        End Property

    End Class 'STKMOVIMIENTOITEM
    Public Class STKSECTOR

        Private _codemp As String
        Private _deposito_id As Int32
        Private _sector_id As Int32
        Private _descripcion As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property DEPOSITO_ID() As Int32
            Get
                Return Me._deposito_id
            End Get
            Set(ByVal Value As Int32)
                Me._deposito_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTOR_ID() As Int32
            Get
                Return Me._sector_id
            End Get
            Set(ByVal Value As Int32)
                Me._sector_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property

    End Class 'STKSECTOR
    Public Class STKSUBTIPOMOV

        Private _subtipomov_id As Int32
        Private _descripcion As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SUBTIPOMOV_ID() As Int32
            Get
                Return Me._subtipomov_id
            End Get
            Set(ByVal Value As Int32)
                Me._subtipomov_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property

    End Class 'STKSUBTIPOMOV
    Public Class STKTIPOMOV

        Private _tipomov_id As Int32
        Private _descripcion As String
        Private _signo As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property TIPOMOV_ID() As Int32
            Get
                Return Me._tipomov_id
            End Get
            Set(ByVal Value As Int32)
                Me._tipomov_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SIGNO() As Int32
            Get
                Return Me._signo
            End Get
            Set(ByVal Value As Int32)
                Me._signo = Value
            End Set
        End Property

    End Class 'STKTIPOMOV
    Public Class STKMOVIOC

        Private _codempstk As String
        Private _comprobantestk As Int32
        Private _nroitemstk As Int32
        Private _codemp As String
        Private _ordencompra_id As Int32
        Private _nroitem As Int32
        Private _unimed As String
        Private _cantoriginal As Decimal
        Private _cantingresada As Decimal
        Private _remSucursal As String
        Private _remComprobante As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMPSTK() As String
            Get
                Return Me._codempstk
            End Get
            Set(ByVal Value As String)
                Me._codempstk = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTESTK() As Int32
            Get
                Return Me._comprobantestk
            End Get
            Set(ByVal Value As Int32)
                Me._comprobantestk = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEMSTK() As Int32
            Get
                Return Me._nroitemstk
            End Get
            Set(ByVal Value As Int32)
                Me._nroitemstk = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ORDENCOMPRA_ID() As Int32
            Get
                Return Me._ordencompra_id
            End Get
            Set(ByVal Value As Int32)
                Me._ordencompra_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTORIGINAL() As Decimal
            Get
                Return Me._cantoriginal
            End Get
            Set(ByVal Value As Decimal)
                Me._cantoriginal = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTINGRESADA() As Decimal
            Get
                Return Me._cantingresada
            End Get
            Set(ByVal Value As Decimal)
                Me._cantingresada = Value
            End Set
        End Property

        Public Property RemSucursal As String
            Get
                Return _remSucursal
            End Get
            Set(value As String)
                _remSucursal = value
            End Set
        End Property

        Public Property RemComprobante As Integer
            Get
                Return _remComprobante
            End Get
            Set(value As Integer)
                _remComprobante = value
            End Set
        End Property
    End Class 'STKMOVIOC
    Public Class STKCIERRESTOCK

        Private _codemp As String
        Private _anio As Int32
        Private _mes As Int32
        Private _articulo_id As String
        Private _unimed As String
        Private _stockreal As Decimal
        Private _cantreponer As Decimal
        Private _fechamov As DateTime

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ANIO() As Int32
            Get
                Return Me._anio
            End Get
            Set(ByVal Value As Int32)
                Me._anio = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property MES() As Int32
            Get
                Return Me._mes
            End Get
            Set(ByVal Value As Int32)
                Me._mes = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property STOCKREAL() As Decimal
            Get
                Return Me._stockreal
            End Get
            Set(ByVal Value As Decimal)
                Me._stockreal = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTREPONER() As Decimal
            Get
                Return Me._cantreponer
            End Get
            Set(ByVal Value As Decimal)
                Me._cantreponer = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAMOV() As DateTime
            Get
                Return Me._fechamov
            End Get
            Set(ByVal Value As DateTime)
                Me._fechamov = Value
            End Set
        End Property

    End Class 'STKCIERRESTOCK

    Public Class TESFACTURAPROVEED

        Private _codemp As String
        Private _sucfactura As String
        Private _comprobante As Int32
        Private _tipo As Int32
        Private _pro_cod As String
        Private _fechafact As DateTime
        Private _importe As Decimal
        Private _codigobarra As String
        Private _fechalectura As DateTime
        Private _usuario As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property SUCFACTURA() As String
            Get
                Return Me._sucfactura
            End Get
            Set(ByVal Value As String)
                Me._sucfactura = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTE() As Int32
            Get
                Return Me._comprobante
            End Get
            Set(ByVal Value As Int32)
                Me._comprobante = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property TIPO() As Int32
            Get
                Return Me._tipo
            End Get
            Set(ByVal Value As Int32)
                Me._tipo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property PRO_COD() As String
            Get
                Return Me._pro_cod
            End Get
            Set(ByVal Value As String)
                Me._pro_cod = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAFACT() As DateTime
            Get
                Return Me._fechafact
            End Get
            Set(ByVal Value As DateTime)
                Me._fechafact = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property IMPORTE() As Decimal
            Get
                Return Me._importe
            End Get
            Set(ByVal Value As Decimal)
                Me._importe = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODIGOBARRA() As String
            Get
                Return Me._codigobarra
            End Get
            Set(ByVal Value As String)
                Me._codigobarra = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHALECTURA() As DateTime
            Get
                Return Me._fechalectura
            End Get
            Set(ByVal Value As DateTime)
                Me._fechalectura = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property

    End Class 'TESFACTURAPROVEED

    Public Class COMREQUERIMIENTOBIONEXO

        Private _codemp As String
        Private _requerimiento_id As Int32
        Private _nroitem As Int32
        Private _nrosolicitud As Int32
        Private _cantidad As Decimal
        Private _fecha As DateTime

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROSOLICITUD() As Int32
            Get
                Return Me._nrosolicitud
            End Get
            Set(ByVal Value As Int32)
                Me._nrosolicitud = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property

    End Class 'COMREQUERIMIENTOBIONEXO

    Public Class TESFACTURASRECIBIDAS

        Private _codemp As String
        Private _letra As String
        Private _puntodeventa As String
        Private _numerocomprobante As String
        Private _codigoproveed As String
        Private _fecharecepcion As DateTime
        Private _fechacontable As DateTime
        Private _razonsocial As String
        Private _importe As Double
        Private _usuariorecibe As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property LETRA() As String
            Get
                Return Me._letra
            End Get
            Set(ByVal Value As String)
                Me._letra = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property PUNTODEVENTA() As String
            Get
                Return Me._puntodeventa
            End Get
            Set(ByVal Value As String)
                Me._puntodeventa = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property NUMEROCOMPROBANTE() As String
            Get
                Return Me._numerocomprobante
            End Get
            Set(ByVal Value As String)
                Me._numerocomprobante = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODIGOPROVEED() As String
            Get
                Return Me._codigoproveed
            End Get
            Set(ByVal Value As String)
                Me._codigoproveed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHARECEPCION() As DateTime
            Get
                Return Me._fecharecepcion
            End Get
            Set(ByVal Value As DateTime)
                Me._fecharecepcion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHACONTABLE() As DateTime
            Get
                Return Me._fechacontable
            End Get
            Set(ByVal Value As DateTime)
                Me._fechacontable = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property RAZONSOCIAL() As String
            Get
                Return Me._razonsocial
            End Get
            Set(ByVal Value As String)
                Me._razonsocial = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Double</returns>
        ''' <remarks></remarks>
        Public Property IMPORTE() As Double
            Get
                Return Me._importe
            End Get
            Set(ByVal Value As Double)
                Me._importe = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property USUARIORECIBE() As Int32
            Get
                Return Me._usuariorecibe
            End Get
            Set(ByVal Value As Int32)
                Me._usuariorecibe = Value
            End Set
        End Property

    End Class 'TESFACTURASRECIBIDAS

    Public Class USUARIOXSUBRUBRO

        Private _id_usuario As Int32
        Private _artda2_cod As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_USUARIO() As Int32
            Get
                Return Me._id_usuario
            End Get
            Set(ByVal Value As Int32)
                Me._id_usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTDA2_COD() As String
            Get
                Return Me._artda2_cod
            End Get
            Set(ByVal Value As String)
                Me._artda2_cod = Value
            End Set
        End Property

    End Class 'USUARIOXSUBRUBRO

    Public Class STKARTICULOMARCA

        Private _codemp As String
        Private _articulo_id As String
        Private _marca1 As String
        Private _marca2 As String
        Private _marca3 As String
        Private _marca4 As String
        Private _marca5 As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MARCA1() As String
            Get
                Return Me._marca1
            End Get
            Set(ByVal Value As String)
                Me._marca1 = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MARCA2() As String
            Get
                Return Me._marca2
            End Get
            Set(ByVal Value As String)
                Me._marca2 = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MARCA3() As String
            Get
                Return Me._marca3
            End Get
            Set(ByVal Value As String)
                Me._marca3 = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MARCA4() As String
            Get
                Return Me._marca4
            End Get
            Set(ByVal Value As String)
                Me._marca4 = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MARCA5() As String
            Get
                Return Me._marca5
            End Get
            Set(ByVal Value As String)
                Me._marca5 = Value
            End Set
        End Property

    End Class 'STKARTICULOMARCA

    Public Class COMPEDIDOCOTIZACIONPROVEEDDIRECTO

        Private _codemp As String
        Private _nrocotizacion As Int32
        Private _requerimiento_id As Int32
        Private _nroitem As Int32
        Private _articulo_id As String
        Private _proveed_id As String
        Private _unimed As String
        Private _cantidad As Decimal
        Private _fecha As DateTime
        Private _usuario As String
        Private _obs As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROCOTIZACION() As Int32
            Get
                Return Me._nrocotizacion
            End Get
            Set(ByVal Value As Int32)
                Me._nrocotizacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property PROVEED_ID() As String
            Get
                Return Me._proveed_id
            End Get
            Set(ByVal Value As String)
                Me._proveed_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property OBS() As String
            Get
                Return Me._obs
            End Get
            Set(ByVal Value As String)
                Me._obs = Value
            End Set
        End Property

    End Class 'COMPEDIDOCOTIZACIONPROVEEDDIRECTO
    Public Class STK_RECLAMODEMERCADERIA

        Private _id As Int32
        Private _plantillaid As Int32
        Private _sector_id As Int32
        Private _deposito_id As Int32
        Private _numfactura As Int32
        Private _numremito As Int32
        Private _articulo_id As String
        Private _cantidadfaltante As Decimal
        Private _cantidadrecibidademas As Decimal
        Private _cantidadrecibidaporerror As Decimal
        Private _anotacion As String
        Private _usuario_id As Int32
        Private _fecha As DateTime

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID() As Int32
            Get
                Return Me._id
            End Get
            Set(ByVal Value As Int32)
                Me._id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property PLANTILLAID() As Int32
            Get
                Return Me._plantillaid
            End Get
            Set(ByVal Value As Int32)
                Me._plantillaid = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTOR_ID() As Int32
            Get
                Return Me._sector_id
            End Get
            Set(ByVal Value As Int32)
                Me._sector_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property DEPOSITO_ID() As Int32
            Get
                Return Me._deposito_id
            End Get
            Set(ByVal Value As Int32)
                Me._deposito_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NUMFACTURA() As Int32
            Get
                Return Me._numfactura
            End Get
            Set(ByVal Value As Int32)
                Me._numfactura = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NUMREMITO() As Int32
            Get
                Return Me._numremito
            End Get
            Set(ByVal Value As Int32)
                Me._numremito = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDADFALTANTE() As Decimal
            Get
                Return Me._cantidadfaltante
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidadfaltante = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDADRECIBIDADEMAS() As Decimal
            Get
                Return Me._cantidadrecibidademas
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidadrecibidademas = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDADRECIBIDAPORERROR() As Decimal
            Get
                Return Me._cantidadrecibidaporerror
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidadrecibidaporerror = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ANOTACION() As String
            Get
                Return Me._anotacion
            End Get
            Set(ByVal Value As String)
                Me._anotacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property USUARIO_ID() As Int32
            Get
                Return Me._usuario_id
            End Get
            Set(ByVal Value As Int32)
                Me._usuario_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property

    End Class 'STK_RECLAMODEMERCADERIA

    Public Class COMARTICULOSPROVISORIOS

        Private _id As Int32
        Private _codprovisorio As Int32
        Private _codemp As String
        Private _requerimiento_id As Int32
        Private _nroitem As Int32
        Private _pendienteenbejerman As Int32
        Private _descripcion As String
        Private _presentacion As String
        Private _unimed As String
        Private _marca As String
        Private _embalaje As String
        Private _cantidad As Decimal
        Private _usuario_id As Int32
        Private _usuario_mail As String
        Private _sub_rubro As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID() As Int32
            Get
                Return Me._id
            End Get
            Set(ByVal Value As Int32)
                Me._id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property CODPROVISORIO() As Int32
            Get
                Return Me._codprovisorio
            End Get
            Set(ByVal Value As Int32)
                Me._codprovisorio = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property PENDIENTEENBEJERMAN() As Int32
            Get
                Return Me._pendienteenbejerman
            End Get
            Set(ByVal Value As Int32)
                Me._pendienteenbejerman = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property PRESENTACION() As String
            Get
                Return Me._presentacion
            End Get
            Set(ByVal Value As String)
                Me._presentacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MARCA() As String
            Get
                Return Me._marca
            End Get
            Set(ByVal Value As String)
                Me._marca = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property EMBALAJE() As String
            Get
                Return Me._embalaje
            End Get
            Set(ByVal Value As String)
                Me._embalaje = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property USUARIO_ID() As Int32
            Get
                Return Me._usuario_id
            End Get
            Set(ByVal Value As Int32)
                Me._usuario_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO_MAIL() As String
            Get
                Return Me._usuario_mail
            End Get
            Set(ByVal Value As String)
                Me._usuario_mail = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property SUB_RUBRO() As String
            Get
                Return Me._sub_rubro
            End Get
            Set(ByVal Value As String)
                Me._sub_rubro = Value
            End Set
        End Property

    End Class 'COMARTICULOSPROVISORIOS

    Public Class COMEQUIVALENCIAARTICULOSPROVEED

        Private _articulo_id As String
        Private _proveed_id As String
        Private _articulo_proveed As String
        Private _descrip_articulo_proveed As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property PROVEED_ID() As String
            Get
                Return Me._proveed_id
            End Get
            Set(ByVal Value As String)
                Me._proveed_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_PROVEED() As String
            Get
                Return Me._articulo_proveed
            End Get
            Set(ByVal Value As String)
                Me._articulo_proveed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIP_ARTICULO_PROVEED() As String
            Get
                Return Me._descrip_articulo_proveed
            End Get
            Set(ByVal Value As String)
                Me._descrip_articulo_proveed = Value
            End Set
        End Property

    End Class 'COMEQUIVALENCIAARTICULOSPROVEED

    Public Class COMUSUARIOAUTORIZAREQUERIMIENTOS

        Private _id_usuario As Int32
        Private _sectorrequerimiento As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_USUARIO() As Int32
            Get
                Return Me._id_usuario
            End Get
            Set(ByVal Value As Int32)
                Me._id_usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORREQUERIMIENTO() As Int32
            Get
                Return Me._sectorrequerimiento
            End Get
            Set(ByVal Value As Int32)
                Me._sectorrequerimiento = Value
            End Set
        End Property

    End Class 'COMUSUARIOAUTORIZAREQUERIMIENTOS

    Public Class COMCUENTAUSUARIO

        Private _id_usuario As Int32
        Private _agr_codigo As String
        Private _com_valor As String
        Private _cta_nrocta As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_USUARIO() As Int32
            Get
                Return Me._id_usuario
            End Get
            Set(ByVal Value As Int32)
                Me._id_usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property AGR_CODIGO() As String
            Get
                Return Me._agr_codigo
            End Get
            Set(ByVal Value As String)
                Me._agr_codigo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property COM_VALOR() As String
            Get
                Return Me._com_valor
            End Get
            Set(ByVal Value As String)
                Me._com_valor = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property CTA_NROCTA() As Int32
            Get
                Return Me._cta_nrocta
            End Get
            Set(ByVal Value As Int32)
                Me._cta_nrocta = Value
            End Set
        End Property

    End Class 'COMCUENTAUSUARIO

    Public Class COMLUGARENTREGA

        Private _lugar_id As Int32
        Private _codemp As String
        Private _descripcion As String
        Private _inactivo As Boolean
        Private _obs As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property LUGAR_ID() As Int32
            Get
                Return Me._lugar_id
            End Get
            Set(ByVal Value As Int32)
                Me._lugar_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property INACTIVO() As Boolean
            Get
                Return Me._inactivo
            End Get
            Set(ByVal Value As Boolean)
                Me._inactivo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property OBS() As String
            Get
                Return Me._obs
            End Get
            Set(ByVal Value As String)
                Me._obs = Value
            End Set
        End Property

    End Class 'COMLUGARENTREGA

    Public Class STK_CONTROLLIBRERIA

        Private _codemp As String
        Private _peridodo As String
        Private _anio As Int32
        Private _articulo_id As String
        Private _cant_recibida As Decimal
        Private _cant_solicitada As Decimal
        Private _usuario_id As Int32
        Private _fecha_cierre As DateTime

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property PERIDODO() As String
            Get
                Return Me._peridodo
            End Get
            Set(ByVal Value As String)
                Me._peridodo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ANIO() As Int32
            Get
                Return Me._anio
            End Get
            Set(ByVal Value As Int32)
                Me._anio = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANT_RECIBIDA() As Decimal
            Get
                Return Me._cant_recibida
            End Get
            Set(ByVal Value As Decimal)
                Me._cant_recibida = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANT_SOLICITADA() As Decimal
            Get
                Return Me._cant_solicitada
            End Get
            Set(ByVal Value As Decimal)
                Me._cant_solicitada = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property USUARIO_ID() As Int32
            Get
                Return Me._usuario_id
            End Get
            Set(ByVal Value As Int32)
                Me._usuario_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA_CIERRE() As DateTime
            Get
                Return Me._fecha_cierre
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha_cierre = Value
            End Set
        End Property

    End Class 'STK_CONTROLLIBRERIA

    Public Class EVENTOUSUARIO

        Private _id_usuario As Int32
        Private _evento_id As Int32
        Private _fecha As DateTime

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_USUARIO() As Int32
            Get
                Return Me._id_usuario
            End Get
            Set(ByVal Value As Int32)
                Me._id_usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property EVENTO_ID() As Int32
            Get
                Return Me._evento_id
            End Get
            Set(ByVal Value As Int32)
                Me._evento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property

    End Class 'EVENTOUSUARIO

    Public Class USR_ARTICULOSUBCUENTA

        Private _subcuenta As Int32
        Private _descripcion As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SUBCUENTA() As Int32
            Get
                Return Me._subcuenta
            End Get
            Set(ByVal Value As Int32)
                Me._subcuenta = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DESCRIPCION() As String
            Get
                Return Me._descripcion
            End Get
            Set(ByVal Value As String)
                Me._descripcion = Value
            End Set
        End Property

    End Class 'USR_ARTICULOSUBCUENTA

    Public Class COMREQUERIMIENTOINTERNO

        Private _codemp As String
        Private _requerimiento_id As Int32
        Private _fecha As DateTime
        Private _sectorrequerimiento_id As Int32
        Private _estado_id As Int32
        Private _obs As String
        Private _usuario As String
        Private _usuarioautoriza As String
        Private _fechaautorizacion As DateTime
        Private _motivoanulacion As String
        Private _pedidodiario As Boolean
        Private _sectorentrega_id As Int32
        Private _fechafinalizacion As DateTime
        Private _motivofinalizacion As String
        Private _usuariofinaliza As String
        Private _depositoorigen_id As Int32
        Private _sectordepositoorigen_id As Int32
        Private _depositodestino_id As Int32
        Private _sectordepositodestino_id As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORREQUERIMIENTO_ID() As Int32
            Get
                Return Me._sectorrequerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectorrequerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ESTADO_ID() As Int32
            Get
                Return Me._estado_id
            End Get
            Set(ByVal Value As Int32)
                Me._estado_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property OBS() As String
            Get
                Return Me._obs
            End Get
            Set(ByVal Value As String)
                Me._obs = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIOAUTORIZA() As String
            Get
                Return Me._usuarioautoriza
            End Get
            Set(ByVal Value As String)
                Me._usuarioautoriza = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAAUTORIZACION() As DateTime
            Get
                Return Me._fechaautorizacion
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaautorizacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MOTIVOANULACION() As String
            Get
                Return Me._motivoanulacion
            End Get
            Set(ByVal Value As String)
                Me._motivoanulacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property PEDIDODIARIO() As Boolean
            Get
                Return Me._pedidodiario
            End Get
            Set(ByVal Value As Boolean)
                Me._pedidodiario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORENTREGA_ID() As Int32
            Get
                Return Me._sectorentrega_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectorentrega_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAFINALIZACION() As DateTime
            Get
                Return Me._fechafinalizacion
            End Get
            Set(ByVal Value As DateTime)
                Me._fechafinalizacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MOTIVOFINALIZACION() As String
            Get
                Return Me._motivofinalizacion
            End Get
            Set(ByVal Value As String)
                Me._motivofinalizacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIOFINALIZA() As String
            Get
                Return Me._usuariofinaliza
            End Get
            Set(ByVal Value As String)
                Me._usuariofinaliza = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property DEPOSITOORIGEN_ID() As Int32
            Get
                Return Me._depositoorigen_id
            End Get
            Set(ByVal Value As Int32)
                Me._depositoorigen_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORDEPOSITOORIGEN_ID() As Int32
            Get
                Return Me._sectordepositoorigen_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectordepositoorigen_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property DEPOSITODESTINO_ID() As Int32
            Get
                Return Me._depositodestino_id
            End Get
            Set(ByVal Value As Int32)
                Me._depositodestino_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORDEPOSITODESTINO_ID() As Int32
            Get
                Return Me._sectordepositodestino_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectordepositodestino_id = Value
            End Set
        End Property

    End Class 'COMREQUERIMIENTOINTERNO

    Public Class COMREQUERIMIENTOINTERNOITEM

        Private _codemp As String
        Private _requerimiento_id As Int32
        Private _nroitem As Int32
        Private _articulo_id As String
        Private _unimed As String
        Private _cantidad As Decimal
        Private _nivelaut_id As Int32
        Private _fechaentrega As DateTime
        Private _marca As String
        Private _excluido As Int32
        Private _motivoexclusion As String
        Private _usuarioexcluye As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NIVELAUT_ID() As Int32
            Get
                Return Me._nivelaut_id
            End Get
            Set(ByVal Value As Int32)
                Me._nivelaut_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAENTREGA() As DateTime
            Get
                Return Me._fechaentrega
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaentrega = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MARCA() As String
            Get
                Return Me._marca
            End Get
            Set(ByVal Value As String)
                Me._marca = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property EXCLUIDO() As Int32
            Get
                Return Me._excluido
            End Get
            Set(ByVal Value As Int32)
                Me._excluido = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MOTIVOEXCLUSION() As String
            Get
                Return Me._motivoexclusion
            End Get
            Set(ByVal Value As String)
                Me._motivoexclusion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIOEXCLUYE() As String
            Get
                Return Me._usuarioexcluye
            End Get
            Set(ByVal Value As String)
                Me._usuarioexcluye = Value
            End Set
        End Property

    End Class 'COMREQUERIMIENTOINTERNOITEM

    Public Class STKVENCIMIENTO

        Private _id As Int32
        Private _codemp As String
        Private _comprobante As Int32
        Private _articulo_id As String
        Private _cantidad As Decimal
        Private _enstock As Decimal
        Private _vto As DateTime

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID() As Int32
            Get
                Return Me._id
            End Get
            Set(ByVal Value As Int32)
                Me._id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTE() As Int32
            Get
                Return Me._comprobante
            End Get
            Set(ByVal Value As Int32)
                Me._comprobante = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property ENSTOCK() As Decimal
            Get
                Return Me._enstock
            End Get
            Set(ByVal Value As Decimal)
                Me._enstock = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property VTO() As DateTime
            Get
                Return Me._vto
            End Get
            Set(ByVal Value As DateTime)
                Me._vto = Value
            End Set
        End Property

    End Class 'STKVENCIMIENTO

    Public Class COMORDENCOMPRADETALLE

        Private _codemp As String
        Private _ordencompra_id As Int32
        Private _nroitem As Int32
        Private _nivelauto_id As Int32
        Private _importe As Double
        Private _detalle As String
        Private _cantidad As Decimal

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ORDENCOMPRA_ID() As Int32
            Get
                Return Me._ordencompra_id
            End Get
            Set(ByVal Value As Int32)
                Me._ordencompra_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NIVELAUTO_ID() As Int32
            Get
                Return Me._nivelauto_id
            End Get
            Set(ByVal Value As Int32)
                Me._nivelauto_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Double</returns>
        ''' <remarks></remarks>
        Public Property IMPORTE() As Double
            Get
                Return Me._importe
            End Get
            Set(ByVal Value As Double)
                Me._importe = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property DETALLE() As String
            Get
                Return Me._detalle
            End Get
            Set(ByVal Value As String)
                Me._detalle = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property

    End Class 'COMORDENCOMPRADETALLE

    Public Class STKMOVIREQINTERNO

        Private _codempstk As String
        Private _comprobantestk As Int32
        Private _nroitemstk As Int32
        Private _codemp As String
        Private _requerimiento_id As Int32
        Private _nroitem As Int32
        Private _unimed As String
        Private _cantenviada As Decimal
        Private _remsucursal As String
        Private _remcomprobante As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMPSTK() As String
            Get
                Return Me._codempstk
            End Get
            Set(ByVal Value As String)
                Me._codempstk = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTESTK() As Int32
            Get
                Return Me._comprobantestk
            End Get
            Set(ByVal Value As Int32)
                Me._comprobantestk = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEMSTK() As Int32
            Get
                Return Me._nroitemstk
            End Get
            Set(ByVal Value As Int32)
                Me._nroitemstk = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTENVIADA() As Decimal
            Get
                Return Me._cantenviada
            End Get
            Set(ByVal Value As Decimal)
                Me._cantenviada = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property REMSUCURSAL() As String
            Get
                Return Me._remsucursal
            End Get
            Set(ByVal Value As String)
                Me._remsucursal = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REMCOMPROBANTE() As Int32
            Get
                Return Me._remcomprobante
            End Get
            Set(ByVal Value As Int32)
                Me._remcomprobante = Value
            End Set
        End Property

    End Class 'STKMOVIREQINTERNO
End Namespace 'Tables

Namespace Joins
    Public Class TBL_PERFILESPERMISOS

        Private _id_perfilpermisos As Int32
        Private _id_perfil As New Tables.TBL_PERFILES
        Private _id_menu As New Tables.TBL_MENUS
        Private _lectura As Boolean
        Private _escritura As Boolean
        Private _eliminacion As Boolean

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_PERFILPERMISOS() As Int32
            Get
                Return Me._id_perfilpermisos
            End Get
            Set(ByVal Value As Int32)
                Me._id_perfilpermisos = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>TBL_PERFILES</returns>
        ''' <remarks></remarks>
        Public Property ID_PERFIL() As Tables.TBL_PERFILES
            Get
                Return Me._id_perfil
            End Get
            Set(ByVal Value As Tables.TBL_PERFILES)
                Me._id_perfil = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>TBL_MENUS</returns>
        ''' <remarks></remarks>
        Public Property ID_MENU() As Tables.TBL_MENUS
            Get
                Return Me._id_menu
            End Get
            Set(ByVal Value As Tables.TBL_MENUS)
                Me._id_menu = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property LECTURA() As Boolean
            Get
                Return Me._lectura
            End Get
            Set(ByVal Value As Boolean)
                Me._lectura = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property ESCRITURA() As Boolean
            Get
                Return Me._escritura
            End Get
            Set(ByVal Value As Boolean)
                Me._escritura = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property ELIMINACION() As Boolean
            Get
                Return Me._eliminacion
            End Get
            Set(ByVal Value As Boolean)
                Me._eliminacion = Value
            End Set
        End Property
    End Class 'TBL_PERFILESPERMISOS
    Public Class TBL_USUARIOS

        Private _id_usuario As Int32
        Private _id_perfil As New Tables.TBL_PERFILES
        Private _identificadorusuario As String
        Private _contraseniausuario As String
        Private _nombreusuario As String
        Private _inactivo As Boolean
        Private _sector_id As New Tables.COMSECTORREQUERIMIENTO
        Private _email As String
        Private _empresa As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ID_USUARIO() As Int32
            Get
                Return Me._id_usuario
            End Get
            Set(ByVal Value As Int32)
                Me._id_usuario = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>TBL_PERFILES</returns>
        ''' <remarks></remarks>
        Public Property ID_PERFIL() As Tables.TBL_PERFILES
            Get
                Return Me._id_perfil
            End Get
            Set(ByVal Value As Tables.TBL_PERFILES)
                Me._id_perfil = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property IDENTIFICADORUSUARIO() As String
            Get
                Return Me._identificadorusuario
            End Get
            Set(ByVal Value As String)
                Me._identificadorusuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CONTRASENIAUSUARIO() As String
            Get
                Return Me._contraseniausuario
            End Get
            Set(ByVal Value As String)
                Me._contraseniausuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property NOMBREUSUARIO() As String
            Get
                Return Me._nombreusuario
            End Get
            Set(ByVal Value As String)
                Me._nombreusuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property INACTIVO() As Boolean
            Get
                Return Me._inactivo
            End Get
            Set(ByVal Value As Boolean)
                Me._inactivo = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMSECTORREQUERIMIENTO</returns>
        ''' <remarks></remarks>
        Public Property SECTOR_ID() As Tables.COMSECTORREQUERIMIENTO
            Get
                Return Me._sector_id
            End Get
            Set(ByVal Value As Tables.COMSECTORREQUERIMIENTO)
                Me._sector_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property EMAIL() As String
            Get
                Return Me._email
            End Get
            Set(ByVal Value As String)
                Me._email = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property EMPRESA() As String
            Get
                Return Me._empresa
            End Get
            Set(ByVal Value As String)
                Me._empresa = Value
            End Set
        End Property
    End Class 'TBL_USUARIOS

    Public Class COMORDENCOMPRA

        Private _codemp As String
        Private _ordencompra_id As Int32
        Private _codemprequerimiento As String
        Private _requerimiento_id As Int32
        Private _fecha As DateTime
        Private _proveed_id As String
        Private _sectorrequerimiento_id As Int32
        Private _estado_id As New Tables.COMESTADO
        Private _tipooc_id As New Tables.COMTIPOOC
        Private _modificacosto As Int32
        Private _condicionpago_id As String
        Private _obs As String
        Private _usuario As String
        Private _usuarioautoriza As String
        Private _pdc As Decimal
        Private _fechaautorizacion As DateTime
        Private _motivofinaliz_anulacion As String
        Private _fechafinaliz_anulacion As DateTime
        Private _pedidodiario As Boolean
        Private _proveed_original As String
        Private _sectorentrega_id As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ORDENCOMPRA_ID() As Int32
            Get
                Return Me._ordencompra_id
            End Get
            Set(ByVal Value As Int32)
                Me._ordencompra_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMPREQUERIMIENTO() As String
            Get
                Return Me._codemprequerimiento
            End Get
            Set(ByVal Value As String)
                Me._codemprequerimiento = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property PROVEED_ID() As String
            Get
                Return Me._proveed_id
            End Get
            Set(ByVal Value As String)
                Me._proveed_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORREQUERIMIENTO_ID() As Int32
            Get
                Return Me._sectorrequerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectorrequerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMESTADO</returns>
        ''' <remarks></remarks>
        Public Property ESTADO_ID() As Tables.COMESTADO
            Get
                Return Me._estado_id
            End Get
            Set(ByVal Value As Tables.COMESTADO)
                Me._estado_id = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMTIPOOC</returns>
        ''' <remarks></remarks>
        Public Property TIPOOC_ID() As Tables.COMTIPOOC
            Get
                Return Me._tipooc_id
            End Get
            Set(ByVal Value As Tables.COMTIPOOC)
                Me._tipooc_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property MODIFICACOSTO() As Int32
            Get
                Return Me._modificacosto
            End Get
            Set(ByVal Value As Int32)
                Me._modificacosto = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CONDICIONPAGO_ID() As String
            Get
                Return Me._condicionpago_id
            End Get
            Set(ByVal Value As String)
                Me._condicionpago_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property OBS() As String
            Get
                Return Me._obs
            End Get
            Set(ByVal Value As String)
                Me._obs = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIOAUTORIZA() As String
            Get
                Return Me._usuarioautoriza
            End Get
            Set(ByVal Value As String)
                Me._usuarioautoriza = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property PDC() As Decimal
            Get
                Return Me._pdc
            End Get
            Set(ByVal Value As Decimal)
                Me._pdc = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAAUTORIZACION() As DateTime
            Get
                Return Me._fechaautorizacion
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaautorizacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MOTIVOFINALIZ_ANULACION() As String
            Get
                Return Me._motivofinaliz_anulacion
            End Get
            Set(ByVal Value As String)
                Me._motivofinaliz_anulacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAFINALIZ_ANULACION() As DateTime
            Get
                Return Me._fechafinaliz_anulacion
            End Get
            Set(ByVal Value As DateTime)
                Me._fechafinaliz_anulacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property PEDIDODIARIO() As Boolean
            Get
                Return Me._pedidodiario
            End Get
            Set(ByVal Value As Boolean)
                Me._pedidodiario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property PROVEED_ORIGINAL() As String
            Get
                Return Me._proveed_original
            End Get
            Set(ByVal Value As String)
                Me._proveed_original = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORENTREGA_ID() As Int32
            Get
                Return Me._sectorentrega_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectorentrega_id = Value
            End Set
        End Property
    End Class 'COMORDENCOMPRA
    Public Class COMORDENCOMPRAITEM

        Private _codemp As String
        Private _ordencompra_id As Int32
        Private _nroitem As Int32
        Private _articulo_id As String
        Private _unimed As String
        Private _cantidad As Decimal
        Private _precio As Decimal
        Private _nivelaut_id As New Tables.COMAUTORIZACION
        Private _fechaentrega As DateTime
        Private _fechaentrega1 As DateTime
        Private _cantidad1 As Decimal
        Private _embalaje As String
        Private _marca As String
        Private _codemprequerimiento As String
        Private _requerimiento_id As Int32
        Private _cantidadoriginal As Decimal
        Private _preciooriginal As Decimal


        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ORDENCOMPRA_ID() As Int32
            Get
                Return Me._ordencompra_id
            End Get
            Set(ByVal Value As Int32)
                Me._ordencompra_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property PRECIO() As Decimal
            Get
                Return Me._precio
            End Get
            Set(ByVal Value As Decimal)
                Me._precio = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMAUTORIZACION</returns>
        ''' <remarks></remarks>
        Public Property NIVELAUT_ID() As Tables.COMAUTORIZACION
            Get
                Return Me._nivelaut_id
            End Get
            Set(ByVal Value As Tables.COMAUTORIZACION)
                Me._nivelaut_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAENTREGA() As DateTime
            Get
                Return Me._fechaentrega
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaentrega = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAENTREGA1() As DateTime
            Get
                Return Me._fechaentrega1
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaentrega1 = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD1() As Decimal
            Get
                Return Me._cantidad1
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad1 = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property EMBALAJE() As String
            Get
                Return Me._embalaje
            End Get
            Set(ByVal Value As String)
                Me._embalaje = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MARCA() As String
            Get
                Return Me._marca
            End Get
            Set(ByVal Value As String)
                Me._marca = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMPREQUERIMIENTO() As String
            Get
                Return Me._codemprequerimiento
            End Get
            Set(ByVal Value As String)
                Me._codemprequerimiento = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDADORIGINAL() As Decimal
            Get
                Return Me._cantidadoriginal
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidadoriginal = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property PRECIOORIGINAL() As Decimal
            Get
                Return Me._preciooriginal
            End Get
            Set(ByVal Value As Decimal)
                Me._preciooriginal = Value
            End Set
        End Property

    End Class 'COMORDENCOMPRAITEM

    Public Class COMREQUERIMIENTO

        Private _codemp As String
        Private _requerimiento_id As Int32
        Private _fecha As DateTime
        Private _sectorrequerimiento_id As New Tables.COMSECTORREQUERIMIENTO
        Private _proveed_id As String
        Private _estado_id As New Tables.COMESTADO
        Private _obs As String
        Private _usuario As String
        Private _usuarioautoriza As String
        Private _fechaautorizacion As DateTime
        Private _motivoanulacion As String
        Private _pedidodiario As Boolean

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMSECTORREQUERIMIENTO</returns>
        ''' <remarks></remarks>
        Public Property SECTORREQUERIMIENTO_ID() As Tables.COMSECTORREQUERIMIENTO
            Get
                Return Me._sectorrequerimiento_id
            End Get
            Set(ByVal Value As Tables.COMSECTORREQUERIMIENTO)
                Me._sectorrequerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property PROVEED_ID() As String
            Get
                Return Me._proveed_id
            End Get
            Set(ByVal Value As String)
                Me._proveed_id = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMESTADO</returns>
        ''' <remarks></remarks>
        Public Property ESTADO_ID() As Tables.COMESTADO
            Get
                Return Me._estado_id
            End Get
            Set(ByVal Value As Tables.COMESTADO)
                Me._estado_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property OBS() As String
            Get
                Return Me._obs
            End Get
            Set(ByVal Value As String)
                Me._obs = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIOAUTORIZA() As String
            Get
                Return Me._usuarioautoriza
            End Get
            Set(ByVal Value As String)
                Me._usuarioautoriza = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAAUTORIZACION() As DateTime
            Get
                Return Me._fechaautorizacion
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaautorizacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MOTIVOANULACION() As String
            Get
                Return Me._motivoanulacion
            End Get
            Set(ByVal Value As String)
                Me._motivoanulacion = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property PEDIDODIARIO() As Boolean
            Get
                Return Me._pedidodiario
            End Get
            Set(ByVal Value As Boolean)
                Me._pedidodiario = Value
            End Set
        End Property
    End Class 'COMREQUERIMIENTO


    Public Class COMREQUERIMIENTOITEM

        Private _codemp As String
        Private _requerimiento_id As Int32
        Private _nroitem As Int32
        Private _articulo_id As String
        Private _unimed As String
        Private _cantidad As Decimal
        Private _nivelaut_id As New Tables.COMAUTORIZACION
        Private _fechaentrega As DateTime
        Private _marca As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Int32
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Int32)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMAUTORIZACION</returns>
        ''' <remarks></remarks>
        Public Property NIVELAUT_ID() As Tables.COMAUTORIZACION
            Get
                Return Me._nivelaut_id
            End Get
            Set(ByVal Value As Tables.COMAUTORIZACION)
                Me._nivelaut_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAENTREGA() As DateTime
            Get
                Return Me._fechaentrega
            End Get
            Set(ByVal Value As DateTime)
                Me._fechaentrega = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property MARCA() As String
            Get
                Return Me._marca
            End Get
            Set(ByVal Value As String)
                Me._marca = Value
            End Set
        End Property
    End Class 'COMREQUERIMIENTOITEM

    Public Class COMREQUERIMIENTOORDENCOMPRA

        Private _codemp As New Joins.COMREQUERIMIENTOITEM
        Private _requerimiento_id As New Joins.COMREQUERIMIENTOITEM
        Private _nroitem As New Joins.COMREQUERIMIENTOITEM
        Private _codempoc As New Joins.COMORDENCOMPRAITEM
        Private _ordencompra_id As New Joins.COMORDENCOMPRAITEM
        Private _nroitemoc As New Joins.COMORDENCOMPRAITEM

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMREQUERIMIENTOITEM</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As Joins.COMREQUERIMIENTOITEM
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As Joins.COMREQUERIMIENTOITEM)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMREQUERIMIENTOITEM</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Joins.COMREQUERIMIENTOITEM
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Joins.COMREQUERIMIENTOITEM)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMREQUERIMIENTOITEM</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Joins.COMREQUERIMIENTOITEM
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Joins.COMREQUERIMIENTOITEM)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMORDENCOMPRAITEM</returns>
        ''' <remarks></remarks>
        Public Property CODEMPOC() As Joins.COMORDENCOMPRAITEM
            Get
                Return Me._codempoc
            End Get
            Set(ByVal Value As Joins.COMORDENCOMPRAITEM)
                Me._codempoc = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMORDENCOMPRAITEM</returns>
        ''' <remarks></remarks>
        Public Property ORDENCOMPRA_ID() As Joins.COMORDENCOMPRAITEM
            Get
                Return Me._ordencompra_id
            End Get
            Set(ByVal Value As Joins.COMORDENCOMPRAITEM)
                Me._ordencompra_id = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMORDENCOMPRAITEM</returns>
        ''' <remarks></remarks>
        Public Property NROITEMOC() As Joins.COMORDENCOMPRAITEM
            Get
                Return Me._nroitemoc
            End Get
            Set(ByVal Value As Joins.COMORDENCOMPRAITEM)
                Me._nroitemoc = Value
            End Set
        End Property
    End Class 'COMREQUERIMIENTOORDENCOMPRA

    Public Class STKENTRANSITO

        Private _codemp As New Joins.STKMOVIMIENTO
        Private _comprobante As New Joins.STKMOVIMIENTO
        Private _nroitem As Int32
        Private _cantoriginal As Decimal
        Private _cantrecibida As Decimal
        Private _unimed As String
        Private _estado_id As Int32
        Private _usuariogenera As String
        Private _usuariorecibe As String
        Private _fecharecepcion As DateTime

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKMOVIMIENTO</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As Joins.STKMOVIMIENTO
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As Joins.STKMOVIMIENTO)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKMOVIMIENTO</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTE() As Joins.STKMOVIMIENTO
            Get
                Return Me._comprobante
            End Get
            Set(ByVal Value As Joins.STKMOVIMIENTO)
                Me._comprobante = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTORIGINAL() As Decimal
            Get
                Return Me._cantoriginal
            End Get
            Set(ByVal Value As Decimal)
                Me._cantoriginal = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTRECIBIDA() As Decimal
            Get
                Return Me._cantrecibida
            End Get
            Set(ByVal Value As Decimal)
                Me._cantrecibida = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ESTADO_ID() As Int32
            Get
                Return Me._estado_id
            End Get
            Set(ByVal Value As Int32)
                Me._estado_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIOGENERA() As String
            Get
                Return Me._usuariogenera
            End Get
            Set(ByVal Value As String)
                Me._usuariogenera = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIORECIBE() As String
            Get
                Return Me._usuariorecibe
            End Get
            Set(ByVal Value As String)
                Me._usuariorecibe = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHARECEPCION() As DateTime
            Get
                Return Me._fecharecepcion
            End Get
            Set(ByVal Value As DateTime)
                Me._fecharecepcion = Value
            End Set
        End Property
    End Class 'STKENTRANSITO

    Public Class STKINVENTARIO

        Private _articulo_id As String
        Private _deposito_id As New Tables.STKSECTOR
        Private _sector_id As New Tables.STKSECTOR
        Private _unimed As String
        Private _cantidad As Decimal

        Public Sub New()
            MyBase.New()
        End Sub

        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKSECTOR</returns>
        ''' <remarks></remarks>
        Public Property DEPOSITO_ID() As Tables.STKSECTOR
            Get
                Return Me._deposito_id
            End Get
            Set(ByVal Value As Tables.STKSECTOR)
                Me._deposito_id = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKSECTOR</returns>
        ''' <remarks></remarks>
        Public Property SECTOR_ID() As Tables.STKSECTOR
            Get
                Return Me._sector_id
            End Get
            Set(ByVal Value As Tables.STKSECTOR)
                Me._sector_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
    End Class 'STKINVENTARIO

    Public Class STKMOVIMIENTO

        Private _codemp As String
        Private _comprobante As Int32
        Private _tipomov_id As New Tables.STKTIPOMOV
        Private _subtipomov_id As New Tables.STKSUBTIPOMOV
        Private _fechamov As DateTime
        Private _depositoorigen_id As Int32
        Private _sectororigen_id As Int32
        Private _depositodestino_id As Int32
        Private _sectordestino_id As Int32
        Private _usuario As String
        Private _anulado As Int32
        Private _obs As String

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTE() As Int32
            Get
                Return Me._comprobante
            End Get
            Set(ByVal Value As Int32)
                Me._comprobante = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKTIPOMOV</returns>
        ''' <remarks></remarks>
        Public Property TIPOMOV_ID() As Tables.STKTIPOMOV
            Get
                Return Me._tipomov_id
            End Get
            Set(ByVal Value As Tables.STKTIPOMOV)
                Me._tipomov_id = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKSUBTIPOMOV</returns>
        ''' <remarks></remarks>
        Public Property SUBTIPOMOV_ID() As Tables.STKSUBTIPOMOV
            Get
                Return Me._subtipomov_id
            End Get
            Set(ByVal Value As Tables.STKSUBTIPOMOV)
                Me._subtipomov_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHAMOV() As DateTime
            Get
                Return Me._fechamov
            End Get
            Set(ByVal Value As DateTime)
                Me._fechamov = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property DEPOSITOORIGEN_ID() As Int32
            Get
                Return Me._depositoorigen_id
            End Get
            Set(ByVal Value As Int32)
                Me._depositoorigen_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORORIGEN_ID() As Int32
            Get
                Return Me._sectororigen_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectororigen_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property DEPOSITODESTINO_ID() As Int32
            Get
                Return Me._depositodestino_id
            End Get
            Set(ByVal Value As Int32)
                Me._depositodestino_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property SECTORDESTINO_ID() As Int32
            Get
                Return Me._sectordestino_id
            End Get
            Set(ByVal Value As Int32)
                Me._sectordestino_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property USUARIO() As String
            Get
                Return Me._usuario
            End Get
            Set(ByVal Value As String)
                Me._usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property ANULADO() As Int32
            Get
                Return Me._anulado
            End Get
            Set(ByVal Value As Int32)
                Me._anulado = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property OBS() As String
            Get
                Return Me._obs
            End Get
            Set(ByVal Value As String)
                Me._obs = Value
            End Set
        End Property
    End Class 'STKMOVIMIENTO

    Public Class STKMOVIMIENTOITEM

        Private _codemp As New Joins.STKMOVIMIENTO
        Private _comprobante As New Joins.STKMOVIMIENTO
        Private _nroitem As Int32
        Private _articulo_id As String
        Private _unimed As String
        Private _cantidad As Decimal
        Private _costouni As Decimal

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKMOVIMIENTO</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As Joins.STKMOVIMIENTO
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As Joins.STKMOVIMIENTO)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKMOVIMIENTO</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTE() As Joins.STKMOVIMIENTO
            Get
                Return Me._comprobante
            End Get
            Set(ByVal Value As Joins.STKMOVIMIENTO)
                Me._comprobante = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Int32
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Int32)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property ARTICULO_ID() As String
            Get
                Return Me._articulo_id
            End Get
            Set(ByVal Value As String)
                Me._articulo_id = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property COSTOUNI() As Decimal
            Get
                Return Me._costouni
            End Get
            Set(ByVal Value As Decimal)
                Me._costouni = Value
            End Set
        End Property
    End Class 'STKMOVIMIENTOITEM

    Public Class STKMOVIOC

        Private _codempstk As New Joins.STKMOVIMIENTOITEM
        Private _comprobantestk As New Joins.STKMOVIMIENTOITEM
        Private _nroitemstk As New Joins.STKMOVIMIENTOITEM
        Private _codemp As New Joins.COMORDENCOMPRAITEM
        Private _ordencompra_id As New Joins.COMORDENCOMPRAITEM
        Private _nroitem As New Joins.COMORDENCOMPRAITEM
        Private _unimed As String
        Private _cantoriginal As Decimal
        Private _cantingresada As Decimal
        Private _remSucursal As String
        Private _remComprobante As Int32
        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKMOVIMIENTOITEM</returns>
        ''' <remarks></remarks>
        Public Property CODEMPSTK() As Joins.STKMOVIMIENTOITEM
            Get
                Return Me._codempstk
            End Get
            Set(ByVal Value As Joins.STKMOVIMIENTOITEM)
                Me._codempstk = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKMOVIMIENTOITEM</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTESTK() As Joins.STKMOVIMIENTOITEM
            Get
                Return Me._comprobantestk
            End Get
            Set(ByVal Value As Joins.STKMOVIMIENTOITEM)
                Me._comprobantestk = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKMOVIMIENTOITEM</returns>
        ''' <remarks></remarks>
        Public Property NROITEMSTK() As Joins.STKMOVIMIENTOITEM
            Get
                Return Me._nroitemstk
            End Get
            Set(ByVal Value As Joins.STKMOVIMIENTOITEM)
                Me._nroitemstk = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMORDENCOMPRAITEM</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As Joins.COMORDENCOMPRAITEM
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As Joins.COMORDENCOMPRAITEM)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMORDENCOMPRAITEM</returns>
        ''' <remarks></remarks>
        Public Property ORDENCOMPRA_ID() As Joins.COMORDENCOMPRAITEM
            Get
                Return Me._ordencompra_id
            End Get
            Set(ByVal Value As Joins.COMORDENCOMPRAITEM)
                Me._ordencompra_id = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMORDENCOMPRAITEM</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Joins.COMORDENCOMPRAITEM
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Joins.COMORDENCOMPRAITEM)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property UNIMED() As String
            Get
                Return Me._unimed
            End Get
            Set(ByVal Value As String)
                Me._unimed = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTORIGINAL() As Decimal
            Get
                Return Me._cantoriginal
            End Get
            Set(ByVal Value As Decimal)
                Me._cantoriginal = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTINGRESADA() As Decimal
            Get
                Return Me._cantingresada
            End Get
            Set(ByVal Value As Decimal)
                Me._cantingresada = Value
            End Set
        End Property

        Public Property RemSucursal As String
            Get
                Return _remSucursal
            End Get
            Set(value As String)
                _remSucursal = value
            End Set
        End Property

        Public Property RemComprobante As Integer
            Get
                Return _remComprobante
            End Get
            Set(value As Integer)
                _remComprobante = value
            End Set
        End Property
    End Class 'STKMOVIOC

    Public Class STKREMITO

        Private _codemp As String
        Private _sucursal As String
        Private _comprobante As Int32
        Private _letra As String
        Private _fecha As DateTime
        Private _codempstk As New Joins.STKMOVIMIENTO
        Private _comprobantestk As New Joins.STKMOVIMIENTO

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As String
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As String)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property SUCURSAL() As String
            Get
                Return Me._sucursal
            End Get
            Set(ByVal Value As String)
                Me._sucursal = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTE() As Int32
            Get
                Return Me._comprobante
            End Get
            Set(ByVal Value As Int32)
                Me._comprobante = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property LETRA() As String
            Get
                Return Me._letra
            End Get
            Set(ByVal Value As String)
                Me._letra = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKMOVIMIENTO</returns>
        ''' <remarks></remarks>
        Public Property CODEMPSTK() As Joins.STKMOVIMIENTO
            Get
                Return Me._codempstk
            End Get
            Set(ByVal Value As Joins.STKMOVIMIENTO)
                Me._codempstk = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>STKMOVIMIENTO</returns>
        ''' <remarks></remarks>
        Public Property COMPROBANTESTK() As Joins.STKMOVIMIENTO
            Get
                Return Me._comprobantestk
            End Get
            Set(ByVal Value As Joins.STKMOVIMIENTO)
                Me._comprobantestk = Value
            End Set
        End Property
    End Class 'STKREMITO

    Public Class COMREQUERIMIENTOBIONEXO

        Private _codemp As New Joins.COMREQUERIMIENTOITEM
        Private _requerimiento_id As New Joins.COMREQUERIMIENTOITEM
        Private _nroitem As New Joins.COMREQUERIMIENTOITEM
        Private _nrosolicitud As Int32
        Private _cantidad As Decimal
        Private _fecha As DateTime

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMREQUERIMIENTOITEM</returns>
        ''' <remarks></remarks>
        Public Property CODEMP() As Joins.COMREQUERIMIENTOITEM
            Get
                Return Me._codemp
            End Get
            Set(ByVal Value As Joins.COMREQUERIMIENTOITEM)
                Me._codemp = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMREQUERIMIENTOITEM</returns>
        ''' <remarks></remarks>
        Public Property REQUERIMIENTO_ID() As Joins.COMREQUERIMIENTOITEM
            Get
                Return Me._requerimiento_id
            End Get
            Set(ByVal Value As Joins.COMREQUERIMIENTOITEM)
                Me._requerimiento_id = Value
            End Set
        End Property
        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>COMREQUERIMIENTOITEM</returns>
        ''' <remarks></remarks>
        Public Property NROITEM() As Joins.COMREQUERIMIENTOITEM
            Get
                Return Me._nroitem
            End Get
            Set(ByVal Value As Joins.COMREQUERIMIENTOITEM)
                Me._nroitem = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property NROSOLICITUD() As Int32
            Get
                Return Me._nrosolicitud
            End Get
            Set(ByVal Value As Int32)
                Me._nrosolicitud = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Decimal</returns>
        ''' <remarks></remarks>
        Public Property CANTIDAD() As Decimal
            Get
                Return Me._cantidad
            End Get
            Set(ByVal Value As Decimal)
                Me._cantidad = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime</returns>
        ''' <remarks></remarks>
        Public Property FECHA() As DateTime
            Get
                Return Me._fecha
            End Get
            Set(ByVal Value As DateTime)
                Me._fecha = Value
            End Set
        End Property
    End Class 'COMREQUERIMIENTOBIONEXO

    Public Class COMCUENTAUSUARIO

        Private _id_usuario As New Joins.TBL_USUARIOS
        Private _agr_codigo As String
        Private _com_valor As String
        Private _cta_nrocta As Int32

        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        '''  (Instance) 
        ''' </summary>
        ''' <value></value>
        ''' <returns>TBL_USUARIOS</returns>
        ''' <remarks></remarks>
        Public Property ID_USUARIO() As Joins.TBL_USUARIOS
            Get
                Return Me._id_usuario
            End Get
            Set(ByVal Value As Joins.TBL_USUARIOS)
                Me._id_usuario = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property AGR_CODIGO() As String
            Get
                Return Me._agr_codigo
            End Get
            Set(ByVal Value As String)
                Me._agr_codigo = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property COM_VALOR() As String
            Get
                Return Me._com_valor
            End Get
            Set(ByVal Value As String)
                Me._com_valor = Value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns>Int32</returns>
        ''' <remarks></remarks>
        Public Property CTA_NROCTA() As Int32
            Get
                Return Me._cta_nrocta
            End Get
            Set(ByVal Value As Int32)
                Me._cta_nrocta = Value
            End Set
        End Property
    End Class 'COMCUENTAUSUARIO

End Namespace 'Joins
Namespace Procedures
    Public Class _EXISTEHISTORIAL
        Private _mes As System.Int32
        Public Property mes() As System.Int32
            Get
                Return _mes
            End Get
            Set(ByVal value As System.Int32)
                _mes = value
            End Set
        End Property

    End Class '_EXISTEHISTORIAL

    Public Class H_ACTUALIZAHISTORIALCOMPRAS
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'H_ACTUALIZAHISTORIALCOMPRAS

    Public Class H_GENERAHISTORIALIMPUTACIONCOMPRAS
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'H_GENERAHISTORIALIMPUTACIONCOMPRAS

    Public Class _H_FACTURAS_PROVEED_DISPONIBLES
        Private _scc_femision As System.DateTime
        Private _spctco_cod As System.String
        Private _spc_letra As System.String
        Private _spc_codpvt As System.String
        Private _spc_nro As System.String
        Public Property scc_femision() As System.DateTime
            Get
                Return _scc_femision
            End Get
            Set(ByVal value As System.DateTime)
                _scc_femision = value
            End Set
        End Property
        Public Property spctco_cod() As System.String
            Get
                Return _spctco_cod
            End Get
            Set(ByVal value As System.String)
                _spctco_cod = value
            End Set
        End Property
        Public Property spc_letra() As System.String
            Get
                Return _spc_letra
            End Get
            Set(ByVal value As System.String)
                _spc_letra = value
            End Set
        End Property
        Public Property spc_codpvt() As System.String
            Get
                Return _spc_codpvt
            End Get
            Set(ByVal value As System.String)
                _spc_codpvt = value
            End Set
        End Property
        Public Property spc_nro() As System.String
            Get
                Return _spc_nro
            End Get
            Set(ByVal value As System.String)
                _spc_nro = value
            End Set
        End Property

    End Class '_H_FACTURAS_PROVEED_DISPONIBLES

    Public Class _H_INGRESAUNIDADESFACTURA
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class '_H_INGRESAUNIDADESFACTURA

    Public Class _H_MODIFICAUNIDADES
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class '_H_MODIFICAUNIDADES

    Public Class _H_PROVEEDORES
        Private _pro_cod As System.String
        Private _pro_razsoc As System.String
        Public Property pro_cod() As System.String
            Get
                Return _pro_cod
            End Get
            Set(ByVal value As System.String)
                _pro_cod = value
            End Set
        End Property
        Public Property pro_razsoc() As System.String
            Get
                Return _pro_razsoc
            End Get
            Set(ByVal value As System.String)
                _pro_razsoc = value
            End Set
        End Property

    End Class '_H_PROVEEDORES

    Public Class _H_TRAEDETALLEFACTURA
        Private _art_codbarras As System.String
        Private _sdcstp_partida As System.String
        Private _sdcart_codgen As System.String
        Private _sdc_nreng As System.Int16
        Private _sdc_desc As System.String
        Private _unimed As System.String
        Private _cantum As System.Double
        Public Property art_codbarras() As System.String
            Get
                Return _art_codbarras
            End Get
            Set(ByVal value As System.String)
                _art_codbarras = value
            End Set
        End Property
        Public Property sdcstp_partida() As System.String
            Get
                Return _sdcstp_partida
            End Get
            Set(ByVal value As System.String)
                _sdcstp_partida = value
            End Set
        End Property
        Public Property sdcart_codgen() As System.String
            Get
                Return _sdcart_codgen
            End Get
            Set(ByVal value As System.String)
                _sdcart_codgen = value
            End Set
        End Property
        Public Property sdc_nreng() As System.Int16
            Get
                Return _sdc_nreng
            End Get
            Set(ByVal value As System.Int16)
                _sdc_nreng = value
            End Set
        End Property
        Public Property sdc_desc() As System.String
            Get
                Return _sdc_desc
            End Get
            Set(ByVal value As System.String)
                _sdc_desc = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantum() As System.Double
            Get
                Return _cantum
            End Get
            Set(ByVal value As System.Double)
                _cantum = value
            End Set
        End Property

    End Class '_H_TRAEDETALLEFACTURA

    Public Class _H_TRAEDETALLEORDENDECOMPRA
        Private _sccemp_codigo As System.String
        Private _sccsuc_cod As System.String
        Private _scc_id As System.Int32
        Private _sdcscc_id As System.Int32
        Private _spc_nro As System.String
        Private _art_codbarras As System.String
        Private _sdc_nreng As System.Int16
        Private _sdcart_codgen As System.String
        Private _sdc_desc As System.String
        Private _sdcstp_partida As System.String
        Private _sdcume_cod1 As System.String
        Private _sdc_cantum1 As System.Double
        Private _dsdc_cantbulto As System.Int32
        Public Property sccemp_codigo() As System.String
            Get
                Return _sccemp_codigo
            End Get
            Set(ByVal value As System.String)
                _sccemp_codigo = value
            End Set
        End Property
        Public Property sccsuc_cod() As System.String
            Get
                Return _sccsuc_cod
            End Get
            Set(ByVal value As System.String)
                _sccsuc_cod = value
            End Set
        End Property
        Public Property scc_id() As System.Int32
            Get
                Return _scc_id
            End Get
            Set(ByVal value As System.Int32)
                _scc_id = value
            End Set
        End Property
        Public Property sdcscc_id() As System.Int32
            Get
                Return _sdcscc_id
            End Get
            Set(ByVal value As System.Int32)
                _sdcscc_id = value
            End Set
        End Property
        Public Property spc_nro() As System.String
            Get
                Return _spc_nro
            End Get
            Set(ByVal value As System.String)
                _spc_nro = value
            End Set
        End Property
        Public Property art_codbarras() As System.String
            Get
                Return _art_codbarras
            End Get
            Set(ByVal value As System.String)
                _art_codbarras = value
            End Set
        End Property
        Public Property sdc_nreng() As System.Int16
            Get
                Return _sdc_nreng
            End Get
            Set(ByVal value As System.Int16)
                _sdc_nreng = value
            End Set
        End Property
        Public Property sdcart_codgen() As System.String
            Get
                Return _sdcart_codgen
            End Get
            Set(ByVal value As System.String)
                _sdcart_codgen = value
            End Set
        End Property
        Public Property sdc_desc() As System.String
            Get
                Return _sdc_desc
            End Get
            Set(ByVal value As System.String)
                _sdc_desc = value
            End Set
        End Property
        Public Property sdcstp_partida() As System.String
            Get
                Return _sdcstp_partida
            End Get
            Set(ByVal value As System.String)
                _sdcstp_partida = value
            End Set
        End Property
        Public Property sdcume_cod1() As System.String
            Get
                Return _sdcume_cod1
            End Get
            Set(ByVal value As System.String)
                _sdcume_cod1 = value
            End Set
        End Property
        Public Property sdc_cantum1() As System.Double
            Get
                Return _sdc_cantum1
            End Get
            Set(ByVal value As System.Double)
                _sdc_cantum1 = value
            End Set
        End Property
        Public Property dsdc_cantbulto() As System.Int32
            Get
                Return _dsdc_cantbulto
            End Get
            Set(ByVal value As System.Int32)
                _dsdc_cantbulto = value
            End Set
        End Property

    End Class '_H_TRAEDETALLEORDENDECOMPRA

    Public Class _H_TRAEORDENESDECOMPRA
        Private _sccemp_codigo As System.String
        Private _sccsuc_cod As System.String
        Private _scc_id As System.Int32
        Private _nroorden As System.String
        Private _scc_femision As System.DateTime
        Private _sccpro_cod As System.String
        Private _sccpro_razsoc As System.String
        Public Property sccemp_codigo() As System.String
            Get
                Return _sccemp_codigo
            End Get
            Set(ByVal value As System.String)
                _sccemp_codigo = value
            End Set
        End Property
        Public Property sccsuc_cod() As System.String
            Get
                Return _sccsuc_cod
            End Get
            Set(ByVal value As System.String)
                _sccsuc_cod = value
            End Set
        End Property
        Public Property scc_id() As System.Int32
            Get
                Return _scc_id
            End Get
            Set(ByVal value As System.Int32)
                _scc_id = value
            End Set
        End Property
        Public Property nroorden() As System.String
            Get
                Return _nroorden
            End Get
            Set(ByVal value As System.String)
                _nroorden = value
            End Set
        End Property
        Public Property scc_femision() As System.DateTime
            Get
                Return _scc_femision
            End Get
            Set(ByVal value As System.DateTime)
                _scc_femision = value
            End Set
        End Property
        Public Property sccpro_cod() As System.String
            Get
                Return _sccpro_cod
            End Get
            Set(ByVal value As System.String)
                _sccpro_cod = value
            End Set
        End Property
        Public Property sccpro_razsoc() As System.String
            Get
                Return _sccpro_razsoc
            End Get
            Set(ByVal value As System.String)
                _sccpro_razsoc = value
            End Set
        End Property

    End Class '_H_TRAEORDENESDECOMPRA

    Public Class _H_ARTICULOS
        Private _art_codgen As System.String
        Private _descripcion As System.String
        Public Property art_codgen() As System.String
            Get
                Return _art_codgen
            End Get
            Set(ByVal value As System.String)
                _art_codgen = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property

    End Class '_H_ARTICULOS

    Public Class _H_RUBROS
        Private _codigo As System.String
        Private _descripcion As System.String
        Public Property codigo() As System.String
            Get
                Return _codigo
            End Get
            Set(ByVal value As System.String)
                _codigo = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property

    End Class '_H_RUBROS

    Public Class _BUSCARPERFILESPERMISOS
        Private _id_menu As System.Int32
        Private _id_menupadre As System.Int32
        Private _descripcionmenu As System.String
        Private _posicionmenu As System.Int32
        Private _habilitadomenu As System.Boolean
        Private _urlmenu As System.String
        Private _formularioasociado As System.Boolean
        Private _id_perfil As System.Int32
        Public Property id_menu() As System.Int32
            Get
                Return _id_menu
            End Get
            Set(ByVal value As System.Int32)
                _id_menu = value
            End Set
        End Property
        Public Property id_menupadre() As System.Int32
            Get
                Return _id_menupadre
            End Get
            Set(ByVal value As System.Int32)
                _id_menupadre = value
            End Set
        End Property
        Public Property descripcionmenu() As System.String
            Get
                Return _descripcionmenu
            End Get
            Set(ByVal value As System.String)
                _descripcionmenu = value
            End Set
        End Property
        Public Property posicionmenu() As System.Int32
            Get
                Return _posicionmenu
            End Get
            Set(ByVal value As System.Int32)
                _posicionmenu = value
            End Set
        End Property
        Public Property habilitadomenu() As System.Boolean
            Get
                Return _habilitadomenu
            End Get
            Set(ByVal value As System.Boolean)
                _habilitadomenu = value
            End Set
        End Property
        Public Property urlmenu() As System.String
            Get
                Return _urlmenu
            End Get
            Set(ByVal value As System.String)
                _urlmenu = value
            End Set
        End Property
        Public Property formularioasociado() As System.Boolean
            Get
                Return _formularioasociado
            End Get
            Set(ByVal value As System.Boolean)
                _formularioasociado = value
            End Set
        End Property
        Public Property id_perfil() As System.Int32
            Get
                Return _id_perfil
            End Get
            Set(ByVal value As System.Int32)
                _id_perfil = value
            End Set
        End Property

    End Class '_BUSCARPERFILESPERMISOS
    Public Class _MENUES_HIJOS
        Private _id_menu As System.Int32
        Private _descripcionmenu As System.String
        Private _urlmenu As System.String
        Public Property id_menu() As System.Int32
            Get
                Return _id_menu
            End Get
            Set(ByVal value As System.Int32)
                _id_menu = value
            End Set
        End Property
        Public Property descripcionmenu() As System.String
            Get
                Return _descripcionmenu
            End Get
            Set(ByVal value As System.String)
                _descripcionmenu = value
            End Set
        End Property
        Public Property urlmenu() As System.String
            Get
                Return _urlmenu
            End Get
            Set(ByVal value As System.String)
                _urlmenu = value
            End Set
        End Property

    End Class '_MENUES_HIJOS
    Public Class _MENUES_PADRES
        Private _id_menu As System.Int32
        Private _descripcionmenu As System.String
        Public Property id_menu() As System.Int32
            Get
                Return _id_menu
            End Get
            Set(ByVal value As System.Int32)
                _id_menu = value
            End Set
        End Property
        Public Property descripcionmenu() As System.String
            Get
                Return _descripcionmenu
            End Get
            Set(ByVal value As System.String)
                _descripcionmenu = value
            End Set
        End Property

    End Class '_MENUES_PADRES
    Public Class _MENUES_PADRES_E_HIJOS
        Private _descripcionmenu As System.String
        Private _formularioasociado As System.Boolean
        Private _id_menu As System.Int32
        Private _id_menupadre As System.Int32
        Private _posicionmenu As System.Int32
        Private _habilitadomenu As System.Boolean
        Private _urlmenu As System.String
        Private _id_perfil As System.Int32
        Private _lectura As System.Boolean
        Private _escritura As System.Boolean
        Private _eliminacion As System.Boolean
        Public Property descripcionmenu() As System.String
            Get
                Return _descripcionmenu
            End Get
            Set(ByVal value As System.String)
                _descripcionmenu = value
            End Set
        End Property
        Public Property formularioasociado() As System.Boolean
            Get
                Return _formularioasociado
            End Get
            Set(ByVal value As System.Boolean)
                _formularioasociado = value
            End Set
        End Property
        Public Property id_menu() As System.Int32
            Get
                Return _id_menu
            End Get
            Set(ByVal value As System.Int32)
                _id_menu = value
            End Set
        End Property
        Public Property id_menupadre() As System.Int32
            Get
                Return _id_menupadre
            End Get
            Set(ByVal value As System.Int32)
                _id_menupadre = value
            End Set
        End Property
        Public Property posicionmenu() As System.Int32
            Get
                Return _posicionmenu
            End Get
            Set(ByVal value As System.Int32)
                _posicionmenu = value
            End Set
        End Property
        Public Property habilitadomenu() As System.Boolean
            Get
                Return _habilitadomenu
            End Get
            Set(ByVal value As System.Boolean)
                _habilitadomenu = value
            End Set
        End Property
        Public Property urlmenu() As System.String
            Get
                Return _urlmenu
            End Get
            Set(ByVal value As System.String)
                _urlmenu = value
            End Set
        End Property
        Public Property id_perfil() As System.Int32
            Get
                Return _id_perfil
            End Get
            Set(ByVal value As System.Int32)
                _id_perfil = value
            End Set
        End Property
        Public Property lectura() As System.Boolean
            Get
                Return _lectura
            End Get
            Set(ByVal value As System.Boolean)
                _lectura = value
            End Set
        End Property
        Public Property escritura() As System.Boolean
            Get
                Return _escritura
            End Get
            Set(ByVal value As System.Boolean)
                _escritura = value
            End Set
        End Property
        Public Property eliminacion() As System.Boolean
            Get
                Return _eliminacion
            End Get
            Set(ByVal value As System.Boolean)
                _eliminacion = value
            End Set
        End Property

    End Class '_MENUES_PADRES_E_HIJOS
    Public Class _OBTENERPERMISOS
        Private _lectura As System.Boolean
        Private _escritura As System.Boolean
        Private _eliminacion As System.Boolean
        Public Property lectura() As System.Boolean
            Get
                Return _lectura
            End Get
            Set(ByVal value As System.Boolean)
                _lectura = value
            End Set
        End Property
        Public Property escritura() As System.Boolean
            Get
                Return _escritura
            End Get
            Set(ByVal value As System.Boolean)
                _escritura = value
            End Set
        End Property
        Public Property eliminacion() As System.Boolean
            Get
                Return _eliminacion
            End Get
            Set(ByVal value As System.Boolean)
                _eliminacion = value
            End Set
        End Property

    End Class '_OBTENERPERMISOS
    Public Class _OBTENERPERMISOS_PORMODULO
        Private _id_menu As System.Int32
        Private _descripcionmenu As System.String
        Private _lectura As System.Int32
        Private _escritura As System.Int32
        Private _eliminacion As System.Int32
        Public Property id_menu() As System.Int32
            Get
                Return _id_menu
            End Get
            Set(ByVal value As System.Int32)
                _id_menu = value
            End Set
        End Property
        Public Property descripcionmenu() As System.String
            Get
                Return _descripcionmenu
            End Get
            Set(ByVal value As System.String)
                _descripcionmenu = value
            End Set
        End Property
        Public Property lectura() As System.Int32
            Get
                Return _lectura
            End Get
            Set(ByVal value As System.Int32)
                _lectura = value
            End Set
        End Property
        Public Property escritura() As System.Int32
            Get
                Return _escritura
            End Get
            Set(ByVal value As System.Int32)
                _escritura = value
            End Set
        End Property
        Public Property eliminacion() As System.Int32
            Get
                Return _eliminacion
            End Get
            Set(ByVal value As System.Int32)
                _eliminacion = value
            End Set
        End Property

    End Class '_OBTENERPERMISOS_PORMODULO
    Public Class _TBL_USUARIOS_UPDATE_SIN_CLAVE
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class '_TBL_USUARIOS_UPDATE_SIN_CLAVE
    Public Class _VALIDACREDENCIAL
        Private _idusuario As System.Int32
        Private _perfil As System.Int32
        Private _sector_id As System.Int32
        Private _email As System.String
        Private _empresa As System.String
        Public Property idusuario() As System.Int32
            Get
                Return _idusuario
            End Get
            Set(ByVal value As System.Int32)
                _idusuario = value
            End Set
        End Property
        Public Property perfil() As System.Int32
            Get
                Return _perfil
            End Get
            Set(ByVal value As System.Int32)
                _perfil = value
            End Set
        End Property

        Public Property sector_id() As System.Int32
            Get
                Return _sector_id
            End Get
            Set(ByVal value As System.Int32)
                _sector_id = value
            End Set
        End Property
        Public Property email() As System.String
            Get
                Return _email
            End Get
            Set(ByVal value As System.String)
                _email = value
            End Set
        End Property
        Public Property empresa() As System.String
            Get
                Return _empresa
            End Get
            Set(ByVal value As System.String)
                _empresa = value
            End Set
        End Property

    End Class '_VALIDACREDENCIAL
    Public Class ULTIMA_POSICION_MENU
        Private _ultimomenu As System.Int32
        Public Property ultimomenu() As System.Int32
            Get
                Return _ultimomenu
            End Get
            Set(ByVal value As System.Int32)
                _ultimomenu = value
            End Set
        End Property

    End Class 'ULTIMA_POSICION_MENU
    Public Class FACTURASCONOPSINRETIRAR
        Private _ccoemp_codigo As System.String
        Private _ccosuc_cod As System.String
        Private _cco_id As System.Int32
        Private _cco_codpvt As System.String
        Private _cco_letra As System.String
        Private _ccotco_cod As System.String
        Private _cco_nro As System.String
        Private _cco_codpro As System.String
        Private _ccopro_razsoc As System.String
        Private _cco_impmonloc As System.Double
        Private _cco_femision As System.DateTime
        Private _cco_fvto As System.DateTime
        Private _fechaop As System.DateTime
        Private _fecharetiro As System.DateTime
        Public Property ccoemp_codigo() As System.String
            Get
                Return _ccoemp_codigo
            End Get
            Set(ByVal value As System.String)
                _ccoemp_codigo = value
            End Set
        End Property
        Public Property ccosuc_cod() As System.String
            Get
                Return _ccosuc_cod
            End Get
            Set(ByVal value As System.String)
                _ccosuc_cod = value
            End Set
        End Property
        Public Property cco_id() As System.Int32
            Get
                Return _cco_id
            End Get
            Set(ByVal value As System.Int32)
                _cco_id = value
            End Set
        End Property
        Public Property cco_codpvt() As System.String
            Get
                Return _cco_codpvt
            End Get
            Set(ByVal value As System.String)
                _cco_codpvt = value
            End Set
        End Property
        Public Property cco_letra() As System.String
            Get
                Return _cco_letra
            End Get
            Set(ByVal value As System.String)
                _cco_letra = value
            End Set
        End Property
        Public Property ccotco_cod() As System.String
            Get
                Return _ccotco_cod
            End Get
            Set(ByVal value As System.String)
                _ccotco_cod = value
            End Set
        End Property
        Public Property cco_nro() As System.String
            Get
                Return _cco_nro
            End Get
            Set(ByVal value As System.String)
                _cco_nro = value
            End Set
        End Property
        Public Property cco_codpro() As System.String
            Get
                Return _cco_codpro
            End Get
            Set(ByVal value As System.String)
                _cco_codpro = value
            End Set
        End Property
        Public Property ccopro_razsoc() As System.String
            Get
                Return _ccopro_razsoc
            End Get
            Set(ByVal value As System.String)
                _ccopro_razsoc = value
            End Set
        End Property
        Public Property cco_impmonloc() As System.Double
            Get
                Return _cco_impmonloc
            End Get
            Set(ByVal value As System.Double)
                _cco_impmonloc = value
            End Set
        End Property
        Public Property cco_femision() As System.DateTime
            Get
                Return _cco_femision
            End Get
            Set(ByVal value As System.DateTime)
                _cco_femision = value
            End Set
        End Property
        Public Property cco_fvto() As System.DateTime
            Get
                Return _cco_fvto
            End Get
            Set(ByVal value As System.DateTime)
                _cco_fvto = value
            End Set
        End Property
        Public Property fechaop() As System.DateTime
            Get
                Return _fechaop
            End Get
            Set(ByVal value As System.DateTime)
                _fechaop = value
            End Set
        End Property
        Public Property fecharetiro() As System.DateTime
            Get
                Return _fecharetiro
            End Get
            Set(ByVal value As System.DateTime)
                _fecharetiro = value
            End Set
        End Property

    End Class 'FACTURASCONOPSINRETIRAR
    Public Class TRAECOMPROBANTESPENDIENTESPROVEEDOR
        Private _ccoemp_codigo As System.String
        Private _ccosuc_cod As System.String
        Private _cco_id As System.Int32
        Private _cco_codpvt As System.String
        Private _cco_letra As System.String
        Private _ccotco_cod As System.String
        Private _cco_nro As System.String
        Private _cco_impmonloc As System.Double
        Private _cco_saldomonloc As System.Double
        Private _cco_femision As System.DateTime
        Private _cco_fvto As System.DateTime
        Private _fechaultimoreclamo As System.DateTime
        Private _estado_id As System.Int32
        Private _tiporeclamo As System.Int32
        Private _adeudanc As System.Boolean
        Private _tieneObs As System.Int32
        Public Property ccoemp_codigo() As System.String
            Get
                Return _ccoemp_codigo
            End Get
            Set(ByVal value As System.String)
                _ccoemp_codigo = value
            End Set
        End Property
        Public Property ccosuc_cod() As System.String
            Get
                Return _ccosuc_cod
            End Get
            Set(ByVal value As System.String)
                _ccosuc_cod = value
            End Set
        End Property
        Public Property cco_id() As System.Int32
            Get
                Return _cco_id
            End Get
            Set(ByVal value As System.Int32)
                _cco_id = value
            End Set
        End Property
        Public Property cco_codpvt() As System.String
            Get
                Return _cco_codpvt
            End Get
            Set(ByVal value As System.String)
                _cco_codpvt = value
            End Set
        End Property
        Public Property cco_letra() As System.String
            Get
                Return _cco_letra
            End Get
            Set(ByVal value As System.String)
                _cco_letra = value
            End Set
        End Property
        Public Property ccotco_cod() As System.String
            Get
                Return _ccotco_cod
            End Get
            Set(ByVal value As System.String)
                _ccotco_cod = value
            End Set
        End Property
        Public Property cco_nro() As System.String
            Get
                Return _cco_nro
            End Get
            Set(ByVal value As System.String)
                _cco_nro = value
            End Set
        End Property
        Public Property cco_impmonloc() As System.Double
            Get
                Return _cco_impmonloc
            End Get
            Set(ByVal value As System.Double)
                _cco_impmonloc = value
            End Set
        End Property
        Public Property cco_saldomonloc() As System.Double
            Get
                Return _cco_saldomonloc
            End Get
            Set(ByVal value As System.Double)
                _cco_saldomonloc = value
            End Set
        End Property
        Public Property cco_femision() As System.DateTime
            Get
                Return _cco_femision
            End Get
            Set(ByVal value As System.DateTime)
                _cco_femision = value
            End Set
        End Property
        Public Property cco_fvto() As System.DateTime
            Get
                Return _cco_fvto
            End Get
            Set(ByVal value As System.DateTime)
                _cco_fvto = value
            End Set
        End Property
        Public Property fechaultimoreclamo() As System.DateTime
            Get
                Return _fechaultimoreclamo
            End Get
            Set(ByVal value As System.DateTime)
                _fechaultimoreclamo = value
            End Set
        End Property
        Public Property estado_id() As System.Int32
            Get
                Return _estado_id
            End Get
            Set(ByVal value As System.Int32)
                _estado_id = value
            End Set
        End Property
        Public Property tiporeclamo() As System.Int32
            Get
                Return _tiporeclamo
            End Get
            Set(ByVal value As System.Int32)
                _tiporeclamo = value
            End Set
        End Property
        Public Property adeudanc() As System.Boolean
            Get
                Return _adeudanc
            End Get
            Set(ByVal value As System.Boolean)
                _adeudanc = value
            End Set
        End Property

        Public Property tieneObs() As System.Int32
            Get
                Return _tieneObs
            End Get
            Set(ByVal value As System.Int32)
                _tieneObs = value
            End Set
        End Property
    End Class 'TRAECOMPROBANTESPENDIENTESPROVEEDOR
    Public Class PAGOSARETIRARPROVEEDORES
        Private _ccoemp_codigo As System.String
        Private _ccosuc_cod As System.String
        Private _cco_id As System.Int32
        Private _cco_nro As System.String
        Private _cco_femision As System.DateTime
        Private _cco_codpro As System.String
        Private _ccopro_razsoc As System.String
        Private _cco_impmonloc As System.Double
        Public Property ccoemp_codigo() As System.String
            Get
                Return _ccoemp_codigo
            End Get
            Set(ByVal value As System.String)
                _ccoemp_codigo = value
            End Set
        End Property
        Public Property ccosuc_cod() As System.String
            Get
                Return _ccosuc_cod
            End Get
            Set(ByVal value As System.String)
                _ccosuc_cod = value
            End Set
        End Property
        Public Property cco_id() As System.Int32
            Get
                Return _cco_id
            End Get
            Set(ByVal value As System.Int32)
                _cco_id = value
            End Set
        End Property
        Public Property cco_nro() As System.String
            Get
                Return _cco_nro
            End Get
            Set(ByVal value As System.String)
                _cco_nro = value
            End Set
        End Property
        Public Property cco_femision() As System.DateTime
            Get
                Return _cco_femision
            End Get
            Set(ByVal value As System.DateTime)
                _cco_femision = value
            End Set
        End Property
        Public Property cco_codpro() As System.String
            Get
                Return _cco_codpro
            End Get
            Set(ByVal value As System.String)
                _cco_codpro = value
            End Set
        End Property
        Public Property ccopro_razsoc() As System.String
            Get
                Return _ccopro_razsoc
            End Get
            Set(ByVal value As System.String)
                _ccopro_razsoc = value
            End Set
        End Property
        Public Property cco_impmonloc() As System.Double
            Get
                Return _cco_impmonloc
            End Get
            Set(ByVal value As System.Double)
                _cco_impmonloc = value
            End Set
        End Property

    End Class 'PAGOSARETIRARPROVEEDORES


    Public Class H_ARTICULOSDEPOSITO
        Private _art_codgen As System.String
        Private _art_descgen As System.String
        Private _unimed As System.String
        Private _cla_desc As System.String
        Private _rubro As System.String
        Private _descriprubro As System.String
        Private _presentacion As System.String
        Private _medida As System.String
        Private _subrubro As System.String
        Private _descripsubrubro As System.String
        Private _llevavencimiento As System.Boolean
        Public Property art_codgen() As System.String
            Get
                Return _art_codgen
            End Get
            Set(ByVal value As System.String)
                _art_codgen = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cla_desc() As System.String
            Get
                Return _cla_desc
            End Get
            Set(ByVal value As System.String)
                _cla_desc = value
            End Set
        End Property
        Public Property rubro() As System.String
            Get
                Return _rubro
            End Get
            Set(ByVal value As System.String)
                _rubro = value
            End Set
        End Property
        Public Property descriprubro() As System.String
            Get
                Return _descriprubro
            End Get
            Set(ByVal value As System.String)
                _descriprubro = value
            End Set
        End Property
        Public Property presentacion() As System.String
            Get
                Return _presentacion
            End Get
            Set(ByVal value As System.String)
                _presentacion = value
            End Set
        End Property
        Public Property medida() As System.String
            Get
                Return _medida
            End Get
            Set(ByVal value As System.String)
                _medida = value
            End Set
        End Property
        Public Property subrubro() As System.String
            Get
                Return _subrubro
            End Get
            Set(ByVal value As System.String)
                _subrubro = value
            End Set
        End Property
        Public Property descripsubrubro() As System.String
            Get
                Return _descripsubrubro
            End Get
            Set(ByVal value As System.String)
                _descripsubrubro = value
            End Set
        End Property
        Public Property llevavencimiento() As System.Boolean
            Get
                Return _llevavencimiento
            End Get
            Set(ByVal value As System.Boolean)
                _llevavencimiento = value
            End Set
        End Property

    End Class 'H_ARTICULOSDEPOSITO

    Public Class MERCADERIA_CARGADA
        Private _codemp As System.String
        Private _fecha As System.DateTime
        Private _id_articulo As System.String
        Private _art_descgen As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property id_articulo() As System.String
            Get
                Return _id_articulo
            End Get
            Set(ByVal value As System.String)
                _id_articulo = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property

    End Class 'MERCADERIA_CARGADA

    Public Class REQUERIMIENTOS_DISPONIBLES
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _fecha As System.DateTime
        Private _obs As System.String
        Private _descripcion As System.String
        Private _sectorrequerimiento_id As System.Int32
        Private _usuario As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property
        Public Property sectorrequerimiento_id() As System.Int32
            Get
                Return _sectorrequerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _sectorrequerimiento_id = value
            End Set
        End Property
        Public Property usuario() As System.String
            Get
                Return _usuario
            End Get
            Set(ByVal value As System.String)
                _usuario = value
            End Set
        End Property

    End Class 'REQUERIMIENTOS_DISPONIBLES
    Public Class UNIDADESDEMEDIDAS
        Private _unimed As System.String
        Private _descripcion As System.String
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property

    End Class 'UNIDADESDEMEDIDAS
    Public Class MAXCOMPROBANTESTKMOVIMIENTO
        Private _comprobante As System.Int32
        Public Property comprobante() As System.Int32
            Get
                Return _comprobante
            End Get
            Set(ByVal value As System.Int32)
                _comprobante = value
            End Set
        End Property

    End Class 'MAXCOMPROBANTESTKMOVIMIENTO
    Public Class MAXCOMPROBANTEREQUERIMIENTO
        Private _requerimiento_id As System.Int32
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property

    End Class 'MAXCOMPROBANTEREQUERIMIENTO
    Public Class H_CONDPAGOPROVEED
        Private _condpago As System.String
        Public Property condpago() As System.String
            Get
                Return _condpago
            End Get
            Set(ByVal value As System.String)
                _condpago = value
            End Set
        End Property

    End Class 'H_CONDPAGOPROVEED
    Public Class TRAEREQUERIMIENTOITEM
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _nroitem As System.Int32
        Private _art_descgen As System.String
        Private _articulo_id As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _nivelaut_id As System.Int32
        Private _fechaentrega As System.DateTime
        Private _marca As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property nivelaut_id() As System.Int32
            Get
                Return _nivelaut_id
            End Get
            Set(ByVal value As System.Int32)
                _nivelaut_id = value
            End Set
        End Property
        Public Property fechaentrega() As System.DateTime
            Get
                Return _fechaentrega
            End Get
            Set(ByVal value As System.DateTime)
                _fechaentrega = value
            End Set
        End Property

        Public Property Marca As String
            Get
                Return _marca
            End Get
            Set(value As String)
                _marca = value
            End Set
        End Property
    End Class 'TRAEREQUERIMIENTOITEM
    Public Class CIERRESTOCKMENSUAL
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'CIERRESTOCKMENSUAL
    Public Class MAXCOMPROBANTEOCDIRECTA
        Private _ordencompra_id As System.Int32
        Public Property ordencompra_id() As System.Int32
            Get
                Return _ordencompra_id
            End Get
            Set(ByVal value As System.Int32)
                _ordencompra_id = value
            End Set
        End Property

    End Class 'MAXCOMPROBANTEOCDIRECTA
    Public Class INFORMEREQUERIMIENTOS
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _sectorrequerimiento_id As System.Int32
        Private _descripcion As System.String
        Private _fecha As System.DateTime
        Private _estado_id As System.Int32
        Private _estado As System.String
        Private _obs As System.String
        Private _nroitem As System.Int32
        Private _articulo_id As System.String
        Private _descripcion1 As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _fechaentrega As System.DateTime
        Private _autorizacion As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property sectorrequerimiento_id() As System.Int32
            Get
                Return _sectorrequerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _sectorrequerimiento_id = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property estado_id() As System.Int32
            Get
                Return _estado_id
            End Get
            Set(ByVal value As System.Int32)
                _estado_id = value
            End Set
        End Property
        Public Property estado() As System.String
            Get
                Return _estado
            End Get
            Set(ByVal value As System.String)
                _estado = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property descripcion1() As System.String
            Get
                Return _descripcion1
            End Get
            Set(ByVal value As System.String)
                _descripcion1 = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property fechaentrega() As System.DateTime
            Get
                Return _fechaentrega
            End Get
            Set(ByVal value As System.DateTime)
                _fechaentrega = value
            End Set
        End Property
        Public Property autorizacion() As System.String
            Get
                Return _autorizacion
            End Get
            Set(ByVal value As System.String)
                _autorizacion = value
            End Set
        End Property

    End Class 'INFORMEREQUERIMIENTOS

    Public Class ORDENCOMPRA_DISPONIBLES
        Private _codemp As System.String
        Private _ordencompra_id As System.Int32
        Private _fecha As System.DateTime
        Private _proveed_id As System.String
        Private _obs As System.String
        Private _razonsocial As System.String
        Private _estado_id As System.Int32
        Private _tipooc_id As System.Int32
        Private _modificacosto As System.Int32
        Private _condicionpago_id As System.String
        Private _usuario As System.String
        Private _email As System.String
        Private _pedidodiario As System.Boolean
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property ordencompra_id() As System.Int32
            Get
                Return _ordencompra_id
            End Get
            Set(ByVal value As System.Int32)
                _ordencompra_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property proveed_id() As System.String
            Get
                Return _proveed_id
            End Get
            Set(ByVal value As System.String)
                _proveed_id = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property razonsocial() As System.String
            Get
                Return _razonsocial
            End Get
            Set(ByVal value As System.String)
                _razonsocial = value
            End Set
        End Property
        Public Property estado_id() As System.Int32
            Get
                Return _estado_id
            End Get
            Set(ByVal value As System.Int32)
                _estado_id = value
            End Set
        End Property
        Public Property tipooc_id() As System.Int32
            Get
                Return _tipooc_id
            End Get
            Set(ByVal value As System.Int32)
                _tipooc_id = value
            End Set
        End Property
        Public Property modificacosto() As System.Int32
            Get
                Return _modificacosto
            End Get
            Set(ByVal value As System.Int32)
                _modificacosto = value
            End Set
        End Property
        Public Property condicionpago_id() As System.String
            Get
                Return _condicionpago_id
            End Get
            Set(ByVal value As System.String)
                _condicionpago_id = value
            End Set
        End Property
        Public Property usuario() As System.String
            Get
                Return _usuario
            End Get
            Set(ByVal value As System.String)
                _usuario = value
            End Set
        End Property
        Public Property email() As System.String
            Get
                Return _email
            End Get
            Set(ByVal value As System.String)
                _email = value
            End Set
        End Property
        Public Property pedidodiario() As System.Boolean
            Get
                Return _pedidodiario
            End Get
            Set(ByVal value As System.Boolean)
                _pedidodiario = value
            End Set
        End Property

    End Class 'ORDENCOMPRA_DISPONIBLES

    'Public Class TRAEORDENCOMPRAITEM
    '    Private _codemp As System.String
    '    Private _ordencompra_id As System.Int32
    '    Private _nroitem As System.Int32
    '    Private _art_codgen As System.String
    '    Private _art_descgen As System.String
    '    Private _articulo_id As System.String
    '    Private _unimed As System.String
    '    Private _cantidad As System.Decimal
    '    Private _precio As System.Decimal
    '    Private _nivelaut_id As System.Int32
    '    Private _fechaentrega As System.DateTime
    '    Private _embalaje As System.String
    '    Private _marca As System.String
    '    Public Property codemp() As System.String
    '        Get
    '            Return _codemp
    '        End Get
    '        Set(ByVal value As System.String)
    '            _codemp = value
    '        End Set
    '    End Property
    '    Public Property ordencompra_id() As System.Int32
    '        Get
    '            Return _ordencompra_id
    '        End Get
    '        Set(ByVal value As System.Int32)
    '            _ordencompra_id = value
    '        End Set
    '    End Property
    '    Public Property nroitem() As System.Int32
    '        Get
    '            Return _nroitem
    '        End Get
    '        Set(ByVal value As System.Int32)
    '            _nroitem = value
    '        End Set
    '    End Property
    '    Public Property art_codgen() As System.String
    '        Get
    '            Return _art_codgen
    '        End Get
    '        Set(ByVal value As System.String)
    '            _art_codgen = value
    '        End Set
    '    End Property
    '    Public Property art_descgen() As System.String
    '        Get
    '            Return _art_descgen
    '        End Get
    '        Set(ByVal value As System.String)
    '            _art_descgen = value
    '        End Set
    '    End Property
    '    Public Property articulo_id() As System.String
    '        Get
    '            Return _articulo_id
    '        End Get
    '        Set(ByVal value As System.String)
    '            _articulo_id = value
    '        End Set
    '    End Property
    '    Public Property unimed() As System.String
    '        Get
    '            Return _unimed
    '        End Get
    '        Set(ByVal value As System.String)
    '            _unimed = value
    '        End Set
    '    End Property
    '    Public Property cantidad() As System.Decimal
    '        Get
    '            Return _cantidad
    '        End Get
    '        Set(ByVal value As System.Decimal)
    '            _cantidad = value
    '        End Set
    '    End Property
    '    Public Property precio() As System.Decimal
    '        Get
    '            Return _precio
    '        End Get
    '        Set(ByVal value As System.Decimal)
    '            _precio = value
    '        End Set
    '    End Property
    '    Public Property nivelaut_id() As System.Int32
    '        Get
    '            Return _nivelaut_id
    '        End Get
    '        Set(ByVal value As System.Int32)
    '            _nivelaut_id = value
    '        End Set
    '    End Property
    '    Public Property fechaentrega() As System.DateTime
    '        Get
    '            Return _fechaentrega
    '        End Get
    '        Set(ByVal value As System.DateTime)
    '            _fechaentrega = value
    '        End Set
    '    End Property
    '    Public Property embalaje() As System.String
    '        Get
    '            Return _embalaje
    '        End Get
    '        Set(ByVal value As System.String)
    '            _embalaje = value
    '        End Set
    '    End Property
    '    Public Property marca() As System.String
    '        Get
    '            Return _marca
    '        End Get
    '        Set(ByVal value As System.String)
    '            _marca = value
    '        End Set
    '    End Property

    'End Class 'TRAEORDENCOMPRAITEM

    Public Class TRAEORDENCOMPRAITEM
        Private _codemp As System.String
        Private _ordencompra_id As System.Int32
        Private _nroitem As System.Int32
        Private _art_codgen As System.String
        Private _art_descgen As System.String
        Private _articulo_id As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _precio As System.Decimal
        Private _nivelaut_id As System.Int32
        Private _fechaentrega As System.DateTime
        Private _embalaje As System.String
        Private _marca As System.String
        Private _excluido As System.Boolean
        Private _motivoexclusion As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property ordencompra_id() As System.Int32
            Get
                Return _ordencompra_id
            End Get
            Set(ByVal value As System.Int32)
                _ordencompra_id = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property art_codgen() As System.String
            Get
                Return _art_codgen
            End Get
            Set(ByVal value As System.String)
                _art_codgen = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property precio() As System.Decimal
            Get
                Return _precio
            End Get
            Set(ByVal value As System.Decimal)
                _precio = value
            End Set
        End Property
        Public Property nivelaut_id() As System.Int32
            Get
                Return _nivelaut_id
            End Get
            Set(ByVal value As System.Int32)
                _nivelaut_id = value
            End Set
        End Property
        Public Property fechaentrega() As System.DateTime
            Get
                Return _fechaentrega
            End Get
            Set(ByVal value As System.DateTime)
                _fechaentrega = value
            End Set
        End Property
        Public Property embalaje() As System.String
            Get
                Return _embalaje
            End Get
            Set(ByVal value As System.String)
                _embalaje = value
            End Set
        End Property
        Public Property marca() As System.String
            Get
                Return _marca
            End Get
            Set(ByVal value As System.String)
                _marca = value
            End Set
        End Property
        Public Property excluido() As System.Boolean
            Get
                Return _excluido
            End Get
            Set(ByVal value As System.Boolean)
                _excluido = value
            End Set
        End Property
        Public Property motivoexclusion() As System.String
            Get
                Return _motivoexclusion
            End Get
            Set(ByVal value As System.String)
                _motivoexclusion = value
            End Set
        End Property

    End Class 'TRAEORDENCOMPRAITEM

    Public Class ACTUALIZA_USUARIO_AUTORIZA
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ACTUALIZA_USUARIO_AUTORIZA

    Public Class REQUERIMIENTOS_PARAORDENDECOMPRA
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _fecha As System.DateTime
        Private _obs As System.String
        Private _descripcion As System.String
        Private _sectorrequerimiento_id As System.Int32
        Private _pedidodiario As System.Boolean
        Private _lugarentrega As System.String
        Private _entrega_id As System.Int32
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property
        Public Property sectorrequerimiento_id() As System.Int32
            Get
                Return _sectorrequerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _sectorrequerimiento_id = value
            End Set
        End Property
        Public Property pedidodiario() As System.Boolean
            Get
                Return _pedidodiario
            End Get
            Set(ByVal value As System.Boolean)
                _pedidodiario = value
            End Set
        End Property

        Public Property Lugarentrega As String
            Get
                Return _lugarentrega
            End Get
            Set(value As String)
                _lugarentrega = value
            End Set
        End Property

        Public Property Entrega_id As Integer
            Get
                Return _entrega_id
            End Get
            Set(value As Integer)
                _entrega_id = value
            End Set
        End Property
    End Class 'REQUERIMIENTOS_PARAORDENDECOMPRA

    Public Class TRAEREQUERIMIENTOITEMVARIOS
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _nroitem As System.Int32
        Private _art_descgen As System.String
        Private _articulo_id As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _nivelaut_id As System.Int32
        Private _fechaentrega As System.DateTime
        Private _marca As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property nivelaut_id() As System.Int32
            Get
                Return _nivelaut_id
            End Get
            Set(ByVal value As System.Int32)
                _nivelaut_id = value
            End Set
        End Property
        Public Property fechaentrega() As System.DateTime
            Get
                Return _fechaentrega
            End Get
            Set(ByVal value As System.DateTime)
                _fechaentrega = value
            End Set
        End Property

        Public Property Marca As String
            Get
                Return _marca
            End Get
            Set(value As String)
                _marca = value
            End Set
        End Property
    End Class 'TRAEREQUERIMIENTOITEMVARIOS

    Public Class ORDENCOMPRA_DISPONIBLES_PROVEEDOR
        Private _codemp As System.String
        Private _ordencompra_id As System.Int32
        Private _fecha As System.DateTime
        Private _proveed_id As System.String
        Private _obs As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property ordencompra_id() As System.Int32
            Get
                Return _ordencompra_id
            End Get
            Set(ByVal value As System.Int32)
                _ordencompra_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property proveed_id() As System.String
            Get
                Return _proveed_id
            End Get
            Set(ByVal value As System.String)
                _proveed_id = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property

    End Class 'ORDENCOMPRA_DISPONIBLES_PROVEEDOR

    Public Class TRAEORDENCOMPRAITEM_PENDIENTE_DE_ENTREGAR
        Private _codemp As System.String
        Private _ordencompra_id As System.Int32
        Private _nroitem As System.Int32
        Private _art_descgen As System.String
        Private _articulo_id As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _precio As System.Decimal
        Private _nivelaut_id As System.Int32
        Private _fechaentrega As System.DateTime
        Private _cantidadadeudada As System.Decimal
        Private _marca As System.String
        Private _porctoleranciareposicion As System.Decimal
        Private _llevavencimiento As System.Boolean
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property ordencompra_id() As System.Int32
            Get
                Return _ordencompra_id
            End Get
            Set(ByVal value As System.Int32)
                _ordencompra_id = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property precio() As System.Decimal
            Get
                Return _precio
            End Get
            Set(ByVal value As System.Decimal)
                _precio = value
            End Set
        End Property
        Public Property nivelaut_id() As System.Int32
            Get
                Return _nivelaut_id
            End Get
            Set(ByVal value As System.Int32)
                _nivelaut_id = value
            End Set
        End Property
        Public Property fechaentrega() As System.DateTime
            Get
                Return _fechaentrega
            End Get
            Set(ByVal value As System.DateTime)
                _fechaentrega = value
            End Set
        End Property
        Public Property cantidadadeudada() As System.Decimal
            Get
                Return _cantidadadeudada
            End Get
            Set(ByVal value As System.Decimal)
                _cantidadadeudada = value
            End Set
        End Property
        Public Property marca() As System.String
            Get
                Return _marca
            End Get
            Set(ByVal value As System.String)
                _marca = value
            End Set
        End Property
        Public Property porctoleranciareposicion() As System.Decimal
            Get
                Return _porctoleranciareposicion
            End Get
            Set(ByVal value As System.Decimal)
                _porctoleranciareposicion = value
            End Set
        End Property
        Public Property llevavencimiento() As System.Boolean
            Get
                Return _llevavencimiento
            End Get
            Set(ByVal value As System.Boolean)
                _llevavencimiento = value
            End Set
        End Property

    End Class 'TRAEORDENCOMPRAITEM_PENDIENTE_DE_ENTREGAR

    Public Class RECUPERAPROVEEDOREMPRESA
        Private _pro_cod As System.String
        Private _pro_razsoc As System.String
        Public Property pro_cod() As System.String
            Get
                Return _pro_cod
            End Get
            Set(ByVal value As System.String)
                _pro_cod = value
            End Set
        End Property
        Public Property pro_razsoc() As System.String
            Get
                Return _pro_razsoc
            End Get
            Set(ByVal value As System.String)
                _pro_razsoc = value
            End Set
        End Property

    End Class 'RECUPERAPROVEEDOREMPRESA

    Public Class ORDENCOMPRA_PENDIENTES_DE_ENTREGA
        Private _codemp As System.String
        Private _ordencompra_id As System.Int32
        Private _fecha As System.DateTime
        Private _proveed_id As System.String
        Private _sectorrequerimiento_id As System.Int32
        Private _estado_id As System.Int32
        Private _tipooc_id As System.Int32
        Private _modificacosto As System.Int32
        Private _condicionpago_id As System.String
        Private _obs As System.String
        Private _usuario As System.String
        Private _usuarioautoriza As System.String
        Private _razonsocial As System.String
        Private _pedidodiario As System.Boolean
        Private _sectroEntrega_id As Int32
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property ordencompra_id() As System.Int32
            Get
                Return _ordencompra_id
            End Get
            Set(ByVal value As System.Int32)
                _ordencompra_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property proveed_id() As System.String
            Get
                Return _proveed_id
            End Get
            Set(ByVal value As System.String)
                _proveed_id = value
            End Set
        End Property
        Public Property sectorrequerimiento_id() As System.Int32
            Get
                Return _sectorrequerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _sectorrequerimiento_id = value
            End Set
        End Property
        Public Property estado_id() As System.Int32
            Get
                Return _estado_id
            End Get
            Set(ByVal value As System.Int32)
                _estado_id = value
            End Set
        End Property
        Public Property tipooc_id() As System.Int32
            Get
                Return _tipooc_id
            End Get
            Set(ByVal value As System.Int32)
                _tipooc_id = value
            End Set
        End Property
        Public Property modificacosto() As System.Int32
            Get
                Return _modificacosto
            End Get
            Set(ByVal value As System.Int32)
                _modificacosto = value
            End Set
        End Property
        Public Property condicionpago_id() As System.String
            Get
                Return _condicionpago_id
            End Get
            Set(ByVal value As System.String)
                _condicionpago_id = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property usuario() As System.String
            Get
                Return _usuario
            End Get
            Set(ByVal value As System.String)
                _usuario = value
            End Set
        End Property
        Public Property usuarioautoriza() As System.String
            Get
                Return _usuarioautoriza
            End Get
            Set(ByVal value As System.String)
                _usuarioautoriza = value
            End Set
        End Property
        Public Property razonsocial() As System.String
            Get
                Return _razonsocial
            End Get
            Set(ByVal value As System.String)
                _razonsocial = value
            End Set
        End Property
        Public Property pedidodiario() As System.Boolean
            Get
                Return _pedidodiario
            End Get
            Set(ByVal value As System.Boolean)
                _pedidodiario = value
            End Set
        End Property

        Public Property SectroEntrega_id As Integer
            Get
                Return _sectroEntrega_id
            End Get
            Set(value As Integer)
                _sectroEntrega_id = value
            End Set
        End Property
    End Class 'ORDENCOMPRA_PENDIENTES_DE_ENTREGA

    Public Class TRAEREQUERIMIENTOITEMSDETALLE
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _nroitem As System.Int32
        Private _art_descgen As System.String
        Private _articulo_id As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _nivelaut_id As System.Int32
        Private _fechaentrega As System.DateTime
        Private _codrubro As System.String
        Private _descriprubro As System.String
        Private _codsubrubro As System.String
        Private _descripsubrubro As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property nivelaut_id() As System.Int32
            Get
                Return _nivelaut_id
            End Get
            Set(ByVal value As System.Int32)
                _nivelaut_id = value
            End Set
        End Property
        Public Property fechaentrega() As System.DateTime
            Get
                Return _fechaentrega
            End Get
            Set(ByVal value As System.DateTime)
                _fechaentrega = value
            End Set
        End Property
        Public Property codrubro() As System.String
            Get
                Return _codrubro
            End Get
            Set(ByVal value As System.String)
                _codrubro = value
            End Set
        End Property
        Public Property descriprubro() As System.String
            Get
                Return _descriprubro
            End Get
            Set(ByVal value As System.String)
                _descriprubro = value
            End Set
        End Property
        Public Property codsubrubro() As System.String
            Get
                Return _codsubrubro
            End Get
            Set(ByVal value As System.String)
                _codsubrubro = value
            End Set
        End Property
        Public Property descripsubrubro() As System.String
            Get
                Return _descripsubrubro
            End Get
            Set(ByVal value As System.String)
                _descripsubrubro = value
            End Set
        End Property

    End Class 'TRAEREQUERIMIENTOITEMSDETALLE

    Public Class IMPORTA_TXT_BIONEXO
        Private _oc_desde As System.Int64
        Private _oc_hasta As System.Int64
        Public Property oc_desde() As System.Int64
            Get
                Return _oc_desde
            End Get
            Set(ByVal value As System.Int64)
                _oc_desde = value
            End Set
        End Property
        Public Property oc_hasta() As System.Int64
            Get
                Return _oc_hasta
            End Get
            Set(ByVal value As System.Int64)
                _oc_hasta = value
            End Set
        End Property

    End Class 'IMPORTA_TXT_BIONEXO

    Public Class TRAEREQUERIMIENTOITEMSCOTIZADOS
        Private _articulo_id As System.String
        Private _art_descgen As System.String

        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property


    End Class 'TRAEREQUERIMIENTOITEMSCOTIZADOS

    Public Class ARTICULOCOTIZADO
        Private _articulo_id As System.String
        Private _art_descgen As System.String
        Private _obs As System.String
        Private _nrocotizacion As System.Int32
        Private _codemp As System.String
        Private _proveed_id As System.String
        Private _razonsocial As System.String
        Private _embalaje As System.String
        Private _marca As System.String
        Private _fechacotizacion As System.DateTime
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _precio As System.Decimal
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property nrocotizacion() As System.Int32
            Get
                Return _nrocotizacion
            End Get
            Set(ByVal value As System.Int32)
                _nrocotizacion = value
            End Set
        End Property
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property proveed_id() As System.String
            Get
                Return _proveed_id
            End Get
            Set(ByVal value As System.String)
                _proveed_id = value
            End Set
        End Property
        Public Property razonsocial() As System.String
            Get
                Return _razonsocial
            End Get
            Set(ByVal value As System.String)
                _razonsocial = value
            End Set
        End Property
        Public Property embalaje() As System.String
            Get
                Return _embalaje
            End Get
            Set(ByVal value As System.String)
                _embalaje = value
            End Set
        End Property
        Public Property marca() As System.String
            Get
                Return _marca
            End Get
            Set(ByVal value As System.String)
                _marca = value
            End Set
        End Property
        Public Property fechacotizacion() As System.DateTime
            Get
                Return _fechacotizacion
            End Get
            Set(ByVal value As System.DateTime)
                _fechacotizacion = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property precio() As System.Decimal
            Get
                Return _precio
            End Get
            Set(ByVal value As System.Decimal)
                _precio = value
            End Set
        End Property

    End Class 'ARTICULOCOTIZADO

    Public Class CANTIDADITEMPOREMPRESA
        Private _codemp As System.String
        Private _cantidad As System.Decimal
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property

    End Class 'CANTIDADITEMPOREMPRESA

    Public Class INGRESACOTIZACIONARTICULOEMPRESA
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'INGRESACOTIZACIONARTICULOEMPRESA

    Public Class RUBROARTICULOS
        Private _da1_cod As System.String
        Private _da1_desc As System.String
        Public Property da1_cod() As System.String
            Get
                Return _da1_cod
            End Get
            Set(ByVal value As System.String)
                _da1_cod = value
            End Set
        End Property
        Public Property da1_desc() As System.String
            Get
                Return _da1_desc
            End Get
            Set(ByVal value As System.String)
                _da1_desc = value
            End Set
        End Property

    End Class 'RUBROARTICULOS

    Public Class ELIMINACOTIZACION
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ELIMINACOTIZACION

    Public Class ACTUALIZARUBROUSUARIOS
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ACTUALIZARUBROUSUARIOS
    Public Class RUBROUSUARIOS
        Private _incluido As System.Int32
        Private _da1_cod As System.String
        Private _da1_desc As System.String
        Public Property incluido() As System.Int32
            Get
                Return _incluido
            End Get
            Set(ByVal value As System.Int32)
                _incluido = value
            End Set
        End Property
        Public Property da1_cod() As System.String
            Get
                Return _da1_cod
            End Get
            Set(ByVal value As System.String)
                _da1_cod = value
            End Set
        End Property
        Public Property da1_desc() As System.String
            Get
                Return _da1_desc
            End Get
            Set(ByVal value As System.String)
                _da1_desc = value
            End Set
        End Property

    End Class 'RUBROUSUARIOS

    Public Class TRAEFACTURASRECIBIDAS
        Private _fechacontable As System.DateTime
        Private _letracomprobante As System.String
        Private _puntodeventa As System.String
        Private _numerocomp As System.String
        Private _codigoprooved As System.String
        Private _razonsocial As System.String
        Private _importe As System.Double
        Public Property fechacontable() As System.DateTime
            Get
                Return _fechacontable
            End Get
            Set(ByVal value As System.DateTime)
                _fechacontable = value
            End Set
        End Property
        Public Property letracomprobante() As System.String
            Get
                Return _letracomprobante
            End Get
            Set(ByVal value As System.String)
                _letracomprobante = value
            End Set
        End Property
        Public Property puntodeventa() As System.String
            Get
                Return _puntodeventa
            End Get
            Set(ByVal value As System.String)
                _puntodeventa = value
            End Set
        End Property
        Public Property numerocomp() As System.String
            Get
                Return _numerocomp
            End Get
            Set(ByVal value As System.String)
                _numerocomp = value
            End Set
        End Property
        Public Property codigoprooved() As System.String
            Get
                Return _codigoprooved
            End Get
            Set(ByVal value As System.String)
                _codigoprooved = value
            End Set
        End Property
        Public Property razonsocial() As System.String
            Get
                Return _razonsocial
            End Get
            Set(ByVal value As System.String)
                _razonsocial = value
            End Set
        End Property
        Public Property importe() As System.Double
            Get
                Return _importe
            End Get
            Set(ByVal value As System.Double)
                _importe = value
            End Set
        End Property

    End Class 'TRAEFACTURASRECIBIDAS


    Public Class AUTORIZACOTIZACION
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'AUTORIZACOTIZACION

    Public Class TRAEARTICULOSCOTIZADOSPARAORDENDECOMPRA
        Private _articulo_id As System.String
        Private _unimed As System.String
        Private _descripcion As System.String
        Private _marca As System.String
        Private _embalaje As System.String
        Private _cantidad As System.Decimal
        Private _precio As System.Decimal
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property
        Public Property marca() As System.String
            Get
                Return _marca
            End Get
            Set(ByVal value As System.String)
                _marca = value
            End Set
        End Property
        Public Property embalaje() As System.String
            Get
                Return _embalaje
            End Get
            Set(ByVal value As System.String)
                _embalaje = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property precio() As System.Decimal
            Get
                Return _precio
            End Get
            Set(ByVal value As System.Decimal)
                _precio = value
            End Set
        End Property

    End Class 'TRAEARTICULOSCOTIZADOSPARAORDENDECOMPRA

    Public Class TRAEPROVEEDORESCOTIZADOS
        Private _nrocotizacion As System.Int32
        Private _codemp As System.String
        Private _proveed_id As System.String
        Private _razonsocial As System.String
        Public Property nrocotizacion() As System.Int32
            Get
                Return _nrocotizacion
            End Get
            Set(ByVal value As System.Int32)
                _nrocotizacion = value
            End Set
        End Property
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property proveed_id() As System.String
            Get
                Return _proveed_id
            End Get
            Set(ByVal value As System.String)
                _proveed_id = value
            End Set
        End Property
        Public Property razonsocial() As System.String
            Get
                Return _razonsocial
            End Get
            Set(ByVal value As System.String)
                _razonsocial = value
            End Set
        End Property

    End Class 'TRAEPROVEEDORESCOTIZADOS

    Public Class SUBRUBROUSUARIOS
        Private _incluido As System.Int32
        Private _artda2_cod As System.String
        Private _da2_desc As System.String
        Public Property incluido() As System.Int32
            Get
                Return _incluido
            End Get
            Set(ByVal value As System.Int32)
                _incluido = value
            End Set
        End Property
        Public Property artda2_cod() As System.String
            Get
                Return _artda2_cod
            End Get
            Set(ByVal value As System.String)
                _artda2_cod = value
            End Set
        End Property
        Public Property da2_desc() As System.String
            Get
                Return _da2_desc
            End Get
            Set(ByVal value As System.String)
                _da2_desc = value
            End Set
        End Property

    End Class 'SUBRUBROUSUARIOS

    Public Class ELIMINASUBRUBROSUSUARIO
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ELIMINASUBRUBROSUSUARIO

    Public Class TRAESUBRUBROSDELUSUARIO
        Private _artda2_cod As System.String
        Private _da2_desc As System.String
        Public Property artda2_cod() As System.String
            Get
                Return _artda2_cod
            End Get
            Set(ByVal value As System.String)
                _artda2_cod = value
            End Set
        End Property
        Public Property da2_desc() As System.String
            Get
                Return _da2_desc
            End Get
            Set(ByVal value As System.String)
                _da2_desc = value
            End Set
        End Property

    End Class 'TRAESUBRUBROSDELUSUARIO

    Public Class TRAEREQUERIMIENTOSPARAGENERARCOTIZACION
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _nroitem As System.Int32
        Private _art_descgen As System.String
        Private _articulo_id As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _nivelaut_id As System.Int32
        Private _fechaentrega As System.DateTime
        Private _cotizado As System.Int32
        Private _subrubro As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property nivelaut_id() As System.Int32
            Get
                Return _nivelaut_id
            End Get
            Set(ByVal value As System.Int32)
                _nivelaut_id = value
            End Set
        End Property
        Public Property fechaentrega() As System.DateTime
            Get
                Return _fechaentrega
            End Get
            Set(ByVal value As System.DateTime)
                _fechaentrega = value
            End Set
        End Property
        Public Property cotizado() As System.Int32
            Get
                Return _cotizado
            End Get
            Set(ByVal value As System.Int32)
                _cotizado = value
            End Set
        End Property
        Public Property subrubro() As System.String
            Get
                Return _subrubro
            End Get
            Set(ByVal value As System.String)
                _subrubro = value
            End Set
        End Property

    End Class 'TRAEREQUERIMIENTOSPARAGENERARCOTIZACION

    Public Class H_ARTICULOSMARCA
        Private _art_codGen As System.String
        Private _art_DescGen As System.String
        Private _marca1 As System.String
        Private _marca2 As System.String
        Private _marca3 As System.String
        Private _marca4 As System.String
        Private _marca5 As System.String

        Public Property Art_codGen As String
            Get
                Return _art_codGen
            End Get
            Set(value As String)
                _art_codGen = value
            End Set
        End Property

        Public Property Art_DescGen As String
            Get
                Return _art_DescGen
            End Get
            Set(value As String)
                _art_DescGen = value
            End Set
        End Property

        Public Property Marca1 As String
            Get
                Return _marca1
            End Get
            Set(value As String)
                _marca1 = value
            End Set
        End Property

        Public Property Marca2 As String
            Get
                Return _marca2
            End Get
            Set(value As String)
                _marca2 = value
            End Set
        End Property

        Public Property Marca3 As String
            Get
                Return _marca3
            End Get
            Set(value As String)
                _marca3 = value
            End Set
        End Property

        Public Property Marca4 As String
            Get
                Return _marca4
            End Get
            Set(value As String)
                _marca4 = value
            End Set
        End Property

        Public Property Marca5 As String
            Get
                Return _marca5
            End Get
            Set(value As String)
                _marca5 = value
            End Set
        End Property
    End Class 'H_ARTICULOSMARCA

    Public Class INGRESAPEDIDOCOTIZACIONARTICULOEMPRESA
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'INGRESAPEDIDOCOTIZACIONARTICULOEMPRESA

    Public Class MAXNROCOTIZACION
        Private _nrocotizacion As System.Int32
        Public Property nrocotizacion() As System.Int32
            Get
                Return _nrocotizacion
            End Get
            Set(ByVal value As System.Int32)
                _nrocotizacion = value
            End Set
        End Property

    End Class 'MAXNROCOTIZACION

    Public Class REQUERIMIENTOS_COTIZADOS_PROVEEDOR
        Private _nrocotizacion As System.Int32
        Private _codemp As System.String
        Private _proveed_id As System.String
        Private _pro_razsoc As System.String
        Private _cantidad As System.Decimal
        Private _fecha As System.DateTime
        Public Property nrocotizacion() As System.Int32
            Get
                Return _nrocotizacion
            End Get
            Set(ByVal value As System.Int32)
                _nrocotizacion = value
            End Set
        End Property
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property proveed_id() As System.String
            Get
                Return _proveed_id
            End Get
            Set(ByVal value As System.String)
                _proveed_id = value
            End Set
        End Property
        Public Property pro_razsoc() As System.String
            Get
                Return _pro_razsoc
            End Get
            Set(ByVal value As System.String)
                _pro_razsoc = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property

    End Class 'REQUERIMIENTOS_COTIZADOS_PROVEEDOR

    'Public Class ARTICULOSENVIADOSACOTIZAR
    '    Private _nrocotizacion As System.Int32
    '    Private _codemp As System.String
    '    Private _requerimiento_id As System.Int32
    '    Private _nroitem As System.Int32
    '    Private _articulo_id As System.String
    '    Private _art_descgen As System.String
    '    Private _proveed_id As System.String
    '    Private _unimed As System.String
    '    Private _cantidad As System.Decimal
    '    Private _fecha As System.DateTime
    '    Private _obs As System.String
    '    Public Property nrocotizacion() As System.Int32
    '        Get
    '            Return _nrocotizacion
    '        End Get
    '        Set(ByVal value As System.Int32)
    '            _nrocotizacion = value
    '        End Set
    '    End Property
    '    Public Property codemp() As System.String
    '        Get
    '            Return _codemp
    '        End Get
    '        Set(ByVal value As System.String)
    '            _codemp = value
    '        End Set
    '    End Property
    '    Public Property requerimiento_id() As System.Int32
    '        Get
    '            Return _requerimiento_id
    '        End Get
    '        Set(ByVal value As System.Int32)
    '            _requerimiento_id = value
    '        End Set
    '    End Property
    '    Public Property nroitem() As System.Int32
    '        Get
    '            Return _nroitem
    '        End Get
    '        Set(ByVal value As System.Int32)
    '            _nroitem = value
    '        End Set
    '    End Property
    '    Public Property articulo_id() As System.String
    '        Get
    '            Return _articulo_id
    '        End Get
    '        Set(ByVal value As System.String)
    '            _articulo_id = value
    '        End Set
    '    End Property
    '    Public Property art_descgen() As System.String
    '        Get
    '            Return _art_descgen
    '        End Get
    '        Set(ByVal value As System.String)
    '            _art_descgen = value
    '        End Set
    '    End Property
    '    Public Property proveed_id() As System.String
    '        Get
    '            Return _proveed_id
    '        End Get
    '        Set(ByVal value As System.String)
    '            _proveed_id = value
    '        End Set
    '    End Property
    '    Public Property unimed() As System.String
    '        Get
    '            Return _unimed
    '        End Get
    '        Set(ByVal value As System.String)
    '            _unimed = value
    '        End Set
    '    End Property
    '    Public Property cantidad() As System.Decimal
    '        Get
    '            Return _cantidad
    '        End Get
    '        Set(ByVal value As System.Decimal)
    '            _cantidad = value
    '        End Set
    '    End Property
    '    Public Property fecha() As System.DateTime
    '        Get
    '            Return _fecha
    '        End Get
    '        Set(ByVal value As System.DateTime)
    '            _fecha = value
    '        End Set
    '    End Property
    '    Public Property obs() As System.String
    '        Get
    '            Return _obs
    '        End Get
    '        Set(ByVal value As System.String)
    '            _obs = value
    '        End Set
    '    End Property

    'End Class 'ARTICULOSENVIADOSACOTIZAR

    Public Class TRAESUBRUBROSEMPRESA
        Private _da2_cod As System.String
        Private _da2_desc As System.String
        Public Property da2_cod() As System.String
            Get
                Return _da2_cod
            End Get
            Set(ByVal value As System.String)
                _da2_cod = value
            End Set
        End Property
        Public Property da2_desc() As System.String
            Get
                Return _da2_desc
            End Get
            Set(ByVal value As System.String)
                _da2_desc = value
            End Set
        End Property

    End Class 'TRAESUBRUBROSEMPRESA

    Public Class STKMAXIMOIDPLANTILLA
        Private _max As System.Int32
        Public Property max() As System.Int32
            Get
                Return _max
            End Get
            Set(ByVal value As System.Int32)
                _max = value
            End Set
        End Property

    End Class 'STKMAXIMOIDPLANTILLA

    Public Class FACTURASCARGADASPROVEEDOR
        Private _ccoemp_codigo As System.String
        Private _ccosuc_cod As System.String
        Private _cco_id As System.Int32
        Private _cco_nrocuota As System.String
        Private _cco_codpvt As System.String
        Private _cco_letra As System.String
        Private _ccotco_cod As System.String
        Private _cco_nro As System.String
        Private _cco_impmonloc As System.Double
        Private _cco_saldomonloc As System.Double
        Private _cco_femision As System.DateTime
        Private _cco_fcontab As System.DateTime
        Private _cco_fvto As System.DateTime
        Private _cco_codpro As System.String
        Public Property ccoemp_codigo() As System.String
            Get
                Return _ccoemp_codigo
            End Get
            Set(ByVal value As System.String)
                _ccoemp_codigo = value
            End Set
        End Property
        Public Property ccosuc_cod() As System.String
            Get
                Return _ccosuc_cod
            End Get
            Set(ByVal value As System.String)
                _ccosuc_cod = value
            End Set
        End Property
        Public Property cco_id() As System.Int32
            Get
                Return _cco_id
            End Get
            Set(ByVal value As System.Int32)
                _cco_id = value
            End Set
        End Property
        Public Property cco_nrocuota() As System.String
            Get
                Return _cco_nrocuota
            End Get
            Set(ByVal value As System.String)
                _cco_nrocuota = value
            End Set
        End Property
        Public Property cco_codpvt() As System.String
            Get
                Return _cco_codpvt
            End Get
            Set(ByVal value As System.String)
                _cco_codpvt = value
            End Set
        End Property
        Public Property cco_letra() As System.String
            Get
                Return _cco_letra
            End Get
            Set(ByVal value As System.String)
                _cco_letra = value
            End Set
        End Property
        Public Property ccotco_cod() As System.String
            Get
                Return _ccotco_cod
            End Get
            Set(ByVal value As System.String)
                _ccotco_cod = value
            End Set
        End Property
        Public Property cco_nro() As System.String
            Get
                Return _cco_nro
            End Get
            Set(ByVal value As System.String)
                _cco_nro = value
            End Set
        End Property
        Public Property cco_impmonloc() As System.Double
            Get
                Return _cco_impmonloc
            End Get
            Set(ByVal value As System.Double)
                _cco_impmonloc = value
            End Set
        End Property
        Public Property cco_saldomonloc() As System.Double
            Get
                Return _cco_saldomonloc
            End Get
            Set(ByVal value As System.Double)
                _cco_saldomonloc = value
            End Set
        End Property
        Public Property cco_femision() As System.DateTime
            Get
                Return _cco_femision
            End Get
            Set(ByVal value As System.DateTime)
                _cco_femision = value
            End Set
        End Property
        Public Property cco_fcontab() As System.DateTime
            Get
                Return _cco_fcontab
            End Get
            Set(ByVal value As System.DateTime)
                _cco_fcontab = value
            End Set
        End Property
        Public Property cco_fvto() As System.DateTime
            Get
                Return _cco_fvto
            End Get
            Set(ByVal value As System.DateTime)
                _cco_fvto = value
            End Set
        End Property
        Public Property cco_codpro() As System.String
            Get
                Return _cco_codpro
            End Get
            Set(ByVal value As System.String)
                _cco_codpro = value
            End Set
        End Property

    End Class 'FACTURASCARGADASPROVEEDOR

    Public Class COTIZACIONESPENDIENTESDEINGRESAR
        Private _nrocotizacion As System.Int32
        Private _codemp As System.String
        Private _proveed_id As System.String
        Private _pro_razsoc As System.String
        Private _fecha As System.DateTime
        Public Property nrocotizacion() As System.Int32
            Get
                Return _nrocotizacion
            End Get
            Set(ByVal value As System.Int32)
                _nrocotizacion = value
            End Set
        End Property
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property proveed_id() As System.String
            Get
                Return _proveed_id
            End Get
            Set(ByVal value As System.String)
                _proveed_id = value
            End Set
        End Property
        Public Property pro_razsoc() As System.String
            Get
                Return _pro_razsoc
            End Get
            Set(ByVal value As System.String)
                _pro_razsoc = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property

    End Class 'COTIZACIONESPENDIENTESDEINGRESAR

    Public Class ARTICULOSSEGUNCOTIZACION
        Private _articulo_id As System.String
        Private _art_descgen As System.String
        Private _obs As System.String
        Private _nrocotizacion As System.Int32
        Private _codemp As System.String
        Private _proveed_id As System.String
        Private _razonsocial As System.String
        Private _embalaje As System.String
        Private _marca As System.String
        Private _fechacotizacion As System.DateTime
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _precio As System.Decimal
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property nrocotizacion() As System.Int32
            Get
                Return _nrocotizacion
            End Get
            Set(ByVal value As System.Int32)
                _nrocotizacion = value
            End Set
        End Property
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property proveed_id() As System.String
            Get
                Return _proveed_id
            End Get
            Set(ByVal value As System.String)
                _proveed_id = value
            End Set
        End Property
        Public Property razonsocial() As System.String
            Get
                Return _razonsocial
            End Get
            Set(ByVal value As System.String)
                _razonsocial = value
            End Set
        End Property
        Public Property embalaje() As System.String
            Get
                Return _embalaje
            End Get
            Set(ByVal value As System.String)
                _embalaje = value
            End Set
        End Property
        Public Property marca() As System.String
            Get
                Return _marca
            End Get
            Set(ByVal value As System.String)
                _marca = value
            End Set
        End Property
        Public Property fechacotizacion() As System.DateTime
            Get
                Return _fechacotizacion
            End Get
            Set(ByVal value As System.DateTime)
                _fechacotizacion = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property precio() As System.Decimal
            Get
                Return _precio
            End Get
            Set(ByVal value As System.Decimal)
                _precio = value
            End Set
        End Property

    End Class 'ARTICULOSSEGUNCOTIZACION

    Public Class INSERTAREQUERIMIENTOORDENCOMPRA
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'INSERTAREQUERIMIENTOORDENCOMPRA

    Public Class SUBRUBROARTICULOS
        Private _da2_cod As System.String
        Private _da2_desc As System.String
        Public Property da2_cod() As System.String
            Get
                Return _da2_cod
            End Get
            Set(ByVal value As System.String)
                _da2_cod = value
            End Set
        End Property
        Public Property da2_desc() As System.String
            Get
                Return _da2_desc
            End Get
            Set(ByVal value As System.String)
                _da2_desc = value
            End Set
        End Property

    End Class 'SUBRUBROARTICULOS

    Public Class PROXIMONROSOLICITUD
        Private _nrosolicitud As System.Int32
        Public Property nrosolicitud() As System.Int32
            Get
                Return _nrosolicitud
            End Get
            Set(ByVal value As System.Int32)
                _nrosolicitud = value
            End Set
        End Property

    End Class 'PROXIMONROSOLICITUD

    Public Class PROXIMOCODPROVISORIO
        Private _codprovisorio As System.Int32
        Public Property codprovisorio() As System.Int32
            Get
                Return _codprovisorio
            End Get
            Set(ByVal value As System.Int32)
                _codprovisorio = value
            End Set
        End Property

    End Class 'PROXIMOCODPROVISORIO

    Public Class TRAEOBRASSOCIALESDATATECH
        Private _ins As System.String
        Private _des As System.String
        Public Property ins() As System.String
            Get
                Return _ins
            End Get
            Set(ByVal value As System.String)
                _ins = value
            End Set
        End Property
        Public Property des() As System.String
            Get
                Return _des
            End Get
            Set(ByVal value As System.String)
                _des = value
            End Set
        End Property

    End Class 'TRAEOBRASSOCIALESDATATECH

    Public Class ACTULIZAARTICULOSPROVISORIOS
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ACTULIZAARTICULOSPROVISORIOS

    Public Class PEDIENTEENTREGAARTICULO
        Private _diferencia As System.Decimal
        Public Property diferencia() As System.Decimal
            Get
                Return _diferencia
            End Get
            Set(ByVal value As System.Decimal)
                _diferencia = value
            End Set
        End Property

    End Class 'PEDIENTEENTREGAARTICULO

    Public Class PROVEEDORESXSUBRUBRO
        Private _pro_cod As System.String
        Private _pro_razsoc As System.String
        Public Property pro_cod() As System.String
            Get
                Return _pro_cod
            End Get
            Set(ByVal value As System.String)
                _pro_cod = value
            End Set
        End Property
        Public Property pro_razsoc() As System.String
            Get
                Return _pro_razsoc
            End Get
            Set(ByVal value As System.String)
                _pro_razsoc = value
            End Set
        End Property

    End Class 'PROVEEDORES

    Public Class EQUIVALENCIAARTICULOPROVEED
        Private _articulo_proveed As System.String
        Private _descripcionproveed As System.String
        Public Property articulo_proveed() As System.String
            Get
                Return _articulo_proveed
            End Get
            Set(ByVal value As System.String)
                _articulo_proveed = value
            End Set
        End Property
        Public Property descripcionproveed() As System.String
            Get
                Return _descripcionproveed
            End Get
            Set(ByVal value As System.String)
                _descripcionproveed = value
            End Set
        End Property

    End Class 'EQUIVALENCIAARTICULOPROVEED

    Public Class ACTUALIZA_OBS_OC
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ACTUALIZA_OBS_OC

    Public Class ELIMINASECTORAUTORIZAUSUARIO
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ELIMINASECTORAUTORIZAUSUARIO
    Public Class SECTORESAUTORIZAUSUARIO
        Private _incluido As System.Int32
        Private _sectorrequerimiento As System.Int32
        Private _descripcion As System.String
        Public Property incluido() As System.Int32
            Get
                Return _incluido
            End Get
            Set(ByVal value As System.Int32)
                _incluido = value
            End Set
        End Property
        Public Property sectorrequerimiento() As System.Int32
            Get
                Return _sectorrequerimiento
            End Get
            Set(ByVal value As System.Int32)
                _sectorrequerimiento = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property

    End Class 'SECTORESAUTORIZAUSUARIO

    Public Class COMUSUARIOAUTORIZAREQUERIMIENTOS_ADD
        Private _idusuario As System.Int32
        Private _sectorrequerimiento As System.Int32

        Public Property Idusuario() As System.Int32
            Get
                Return _idusuario
            End Get
            Set(ByVal value As System.Int32)
                _idusuario = value
            End Set
        End Property
        Public Property sectorrequerimiento() As System.Int32
            Get
                Return _sectorrequerimiento
            End Get
            Set(ByVal value As System.Int32)
                _sectorrequerimiento = value
            End Set
        End Property


    End Class 'COMUSUARIOAUTORIZAREQUERIMIENTOS_ADD

    Public Class ACTUALIZA_OBS_REQ
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ACTUALIZA_OBS_REQ

    Public Class FINALIZA_ANULA_OC
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'FINALIZA_ANULA_OC

    Public Class MODIFICAITEMOCAUTORIZADA
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'MODIFICAITEMOCAUTORIZADA

    Public Class ORDENCOMPRA_PARA_MODIFICAR
        Private _codemp As System.String
        Private _ordencompra_id As System.Int32
        Private _fecha As System.DateTime
        Private _proveed_id As System.String
        Private _obs As System.String
        Private _razonsocial As System.String
        Private _estado_id As System.Int32
        Private _tipooc_id As System.Int32
        Private _modificacosto As System.Int32
        Private _condicionpago_id As System.String
        Private _usuario As System.String
        Private _email As System.String
        Private _usuarioautoriza As System.String
        Private _pedidodiario As System.Boolean
        Private _sectorentrega_id As System.Int32
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property ordencompra_id() As System.Int32
            Get
                Return _ordencompra_id
            End Get
            Set(ByVal value As System.Int32)
                _ordencompra_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property proveed_id() As System.String
            Get
                Return _proveed_id
            End Get
            Set(ByVal value As System.String)
                _proveed_id = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property razonsocial() As System.String
            Get
                Return _razonsocial
            End Get
            Set(ByVal value As System.String)
                _razonsocial = value
            End Set
        End Property
        Public Property estado_id() As System.Int32
            Get
                Return _estado_id
            End Get
            Set(ByVal value As System.Int32)
                _estado_id = value
            End Set
        End Property
        Public Property tipooc_id() As System.Int32
            Get
                Return _tipooc_id
            End Get
            Set(ByVal value As System.Int32)
                _tipooc_id = value
            End Set
        End Property
        Public Property modificacosto() As System.Int32
            Get
                Return _modificacosto
            End Get
            Set(ByVal value As System.Int32)
                _modificacosto = value
            End Set
        End Property
        Public Property condicionpago_id() As System.String
            Get
                Return _condicionpago_id
            End Get
            Set(ByVal value As System.String)
                _condicionpago_id = value
            End Set
        End Property
        Public Property usuario() As System.String
            Get
                Return _usuario
            End Get
            Set(ByVal value As System.String)
                _usuario = value
            End Set
        End Property
        Public Property email() As System.String
            Get
                Return _email
            End Get
            Set(ByVal value As System.String)
                _email = value
            End Set
        End Property
        Public Property usuarioautoriza() As System.String
            Get
                Return _usuarioautoriza
            End Get
            Set(ByVal value As System.String)
                _usuarioautoriza = value
            End Set
        End Property
        Public Property pedidodiario() As System.Boolean
            Get
                Return _pedidodiario
            End Get
            Set(ByVal value As System.Boolean)
                _pedidodiario = value
            End Set
        End Property

        Public Property Sectorentrega_id As Integer
            Get
                Return _sectorentrega_id
            End Get
            Set(value As Integer)
                _sectorentrega_id = value
            End Set
        End Property
    End Class 'ORDENCOMPRA_PARA_MODIFICAR

    Public Class REQUERIMIENTOS_PARA_MODIFICAR
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _fecha As System.DateTime
        Private _obs As System.String
        Private _descripcion As System.String
        Private _sectorrequerimiento_id As System.Int32
        Private _usuario As System.String
        Private _usuarioautoriza As System.String
        Private _lugarentrega As System.String
        Private _entrega_id As System.Int32
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property
        Public Property sectorrequerimiento_id() As System.Int32
            Get
                Return _sectorrequerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _sectorrequerimiento_id = value
            End Set
        End Property
        Public Property usuario() As System.String
            Get
                Return _usuario
            End Get
            Set(ByVal value As System.String)
                _usuario = value
            End Set
        End Property
        Public Property usuarioautoriza() As System.String
            Get
                Return _usuarioautoriza
            End Get
            Set(ByVal value As System.String)
                _usuarioautoriza = value
            End Set
        End Property

        Public Property Lugarentrega As String
            Get
                Return _lugarentrega
            End Get
            Set(value As String)
                _lugarentrega = value
            End Set
        End Property

        Public Property Entrega_id As Integer
            Get
                Return _entrega_id
            End Get
            Set(value As Integer)
                _entrega_id = value
            End Set
        End Property
    End Class 'REQUERIMIENTOS_PARA_MODIFICAR

    Public Class ANULA_REQUERIMIENTO
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ANULA_REQUERIMIENTO

    Public Class ORDENCOMPRA_PARA_ANULAR
        Private _codemp As System.String
        Private _ordencompra_id As System.Int32
        Private _fecha As System.DateTime
        Private _proveed_id As System.String
        Private _obs As System.String
        Private _razonsocial As System.String
        Private _estado_id As System.Int32
        Private _tipooc_id As System.Int32
        Private _modificacosto As System.Int32
        Private _condicionpago_id As System.String
        Private _usuario As System.String
        Private _email As System.String
        Private _usuarioautoriza As System.String
        Private _pedidodiario As System.Boolean
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property ordencompra_id() As System.Int32
            Get
                Return _ordencompra_id
            End Get
            Set(ByVal value As System.Int32)
                _ordencompra_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property proveed_id() As System.String
            Get
                Return _proveed_id
            End Get
            Set(ByVal value As System.String)
                _proveed_id = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property razonsocial() As System.String
            Get
                Return _razonsocial
            End Get
            Set(ByVal value As System.String)
                _razonsocial = value
            End Set
        End Property
        Public Property estado_id() As System.Int32
            Get
                Return _estado_id
            End Get
            Set(ByVal value As System.Int32)
                _estado_id = value
            End Set
        End Property
        Public Property tipooc_id() As System.Int32
            Get
                Return _tipooc_id
            End Get
            Set(ByVal value As System.Int32)
                _tipooc_id = value
            End Set
        End Property
        Public Property modificacosto() As System.Int32
            Get
                Return _modificacosto
            End Get
            Set(ByVal value As System.Int32)
                _modificacosto = value
            End Set
        End Property
        Public Property condicionpago_id() As System.String
            Get
                Return _condicionpago_id
            End Get
            Set(ByVal value As System.String)
                _condicionpago_id = value
            End Set
        End Property
        Public Property usuario() As System.String
            Get
                Return _usuario
            End Get
            Set(ByVal value As System.String)
                _usuario = value
            End Set
        End Property
        Public Property email() As System.String
            Get
                Return _email
            End Get
            Set(ByVal value As System.String)
                _email = value
            End Set
        End Property
        Public Property usuarioautoriza() As System.String
            Get
                Return _usuarioautoriza
            End Get
            Set(ByVal value As System.String)
                _usuarioautoriza = value
            End Set
        End Property
        Public Property pedidodiario() As System.Boolean
            Get
                Return _pedidodiario
            End Get
            Set(ByVal value As System.Boolean)
                _pedidodiario = value
            End Set
        End Property

    End Class 'ORDENCOMPRA_PARA_ANULAR

    Public Class ANULA_OC
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ANULA_OC

    Public Class COM_CUENTAS_USUARIO
        Private _incluye As System.Int32
        Private _agr_codigo As System.String
        Private _com_valor As System.String
        Private _cta_descrip As System.String
        Private _cta_nrocta As System.Int32
        Public Property incluye() As System.Int32
            Get
                Return _incluye
            End Get
            Set(ByVal value As System.Int32)
                _incluye = value
            End Set
        End Property
        Public Property agr_codigo() As System.String
            Get
                Return _agr_codigo
            End Get
            Set(ByVal value As System.String)
                _agr_codigo = value
            End Set
        End Property
        Public Property com_valor() As System.String
            Get
                Return _com_valor
            End Get
            Set(ByVal value As System.String)
                _com_valor = value
            End Set
        End Property
        Public Property cta_descrip() As System.String
            Get
                Return _cta_descrip
            End Get
            Set(ByVal value As System.String)
                _cta_descrip = value
            End Set
        End Property
        Public Property cta_nrocta() As System.Int32
            Get
                Return _cta_nrocta
            End Get
            Set(ByVal value As System.Int32)
                _cta_nrocta = value
            End Set
        End Property

    End Class 'COM_CUENTAS_USUARIO

    Public Class USUARIO_CON_CUENTAS
        Private _id_usuario As System.Int32
        Private _email As System.String
        Public Property id_usuario() As System.Int32
            Get
                Return _id_usuario
            End Get
            Set(ByVal value As System.Int32)
                _id_usuario = value
            End Set
        End Property
        Public Property email() As System.String
            Get
                Return _email
            End Get
            Set(ByVal value As System.String)
                _email = value
            End Set
        End Property

    End Class 'USUARIO_CON_CUENTAS

    Public Class ACTUALIZACUENTASCONTABLECOMPRAS_ARTICULOS
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ACTUALIZACUENTASCONTABLECOMPRAS_ARTICULOS
    Public Class PLAN_DE_CUENTA
        Private _com_valor As System.String
        Private _cta_descrip As System.String
        Public Property com_valor() As System.String
            Get
                Return _com_valor
            End Get
            Set(ByVal value As System.String)
                _com_valor = value
            End Set
        End Property
        Public Property cta_descrip() As System.String
            Get
                Return _cta_descrip
            End Get
            Set(ByVal value As System.String)
                _cta_descrip = value
            End Set
        End Property

    End Class 'PLAN_DE_CUENTA

    Public Class TRAEMARCAARTICULOS
        Private _codemp As System.String
        Private _articulo_id As System.String
        Private _marca As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property marca() As System.String
            Get
                Return _marca
            End Get
            Set(ByVal value As System.String)
                _marca = value
            End Set
        End Property

    End Class 'TRAEMARCAARTICULOS

    Public Class GENERAPRORRATEOEMPRESA
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'GENERAPRORRATEOEMPRESA

    Public Class GENERAPRORRATEOEMPRESA_RSC
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'GENERAPRORRATEOEMPRESA_RSC

    Public Class ORDENCOMPRA_PARA_MODIFICAR_FECHA
        Private _codemp As System.String
        Private _ordencompra_id As System.Int32
        Private _fecha As System.DateTime
        Private _proveed_id As System.String
        Private _obs As System.String
        Private _razonsocial As System.String
        Private _estado_id As System.Int32
        Private _tipooc_id As System.Int32
        Private _modificacosto As System.Int32
        Private _condicionpago_id As System.String
        Private _usuario As System.String
        Private _email As System.String
        Private _usuarioautoriza As System.String
        Private _pedidodiario As System.Boolean
        Private _sectorentrega_id As System.Int32
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property ordencompra_id() As System.Int32
            Get
                Return _ordencompra_id
            End Get
            Set(ByVal value As System.Int32)
                _ordencompra_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property proveed_id() As System.String
            Get
                Return _proveed_id
            End Get
            Set(ByVal value As System.String)
                _proveed_id = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property razonsocial() As System.String
            Get
                Return _razonsocial
            End Get
            Set(ByVal value As System.String)
                _razonsocial = value
            End Set
        End Property
        Public Property estado_id() As System.Int32
            Get
                Return _estado_id
            End Get
            Set(ByVal value As System.Int32)
                _estado_id = value
            End Set
        End Property
        Public Property tipooc_id() As System.Int32
            Get
                Return _tipooc_id
            End Get
            Set(ByVal value As System.Int32)
                _tipooc_id = value
            End Set
        End Property
        Public Property modificacosto() As System.Int32
            Get
                Return _modificacosto
            End Get
            Set(ByVal value As System.Int32)
                _modificacosto = value
            End Set
        End Property
        Public Property condicionpago_id() As System.String
            Get
                Return _condicionpago_id
            End Get
            Set(ByVal value As System.String)
                _condicionpago_id = value
            End Set
        End Property
        Public Property usuario() As System.String
            Get
                Return _usuario
            End Get
            Set(ByVal value As System.String)
                _usuario = value
            End Set
        End Property
        Public Property email() As System.String
            Get
                Return _email
            End Get
            Set(ByVal value As System.String)
                _email = value
            End Set
        End Property
        Public Property usuarioautoriza() As System.String
            Get
                Return _usuarioautoriza
            End Get
            Set(ByVal value As System.String)
                _usuarioautoriza = value
            End Set
        End Property
        Public Property pedidodiario() As System.Boolean
            Get
                Return _pedidodiario
            End Get
            Set(ByVal value As System.Boolean)
                _pedidodiario = value
            End Set
        End Property

        Public Property Sectorentrega_id As Integer
            Get
                Return _sectorentrega_id
            End Get
            Set(value As Integer)
                _sectorentrega_id = value
            End Set
        End Property
    End Class 'ORDENCOMPRA_PARA_MODIFICAR_FECHA

    Public Class TRAELUGARESENTREGA
        Private _lugar_id As System.Int32
        Private _codemp As System.String
        Private _descripcion As System.String
        Private _inactivo As System.Boolean
        Private _obs As System.String
        Public Property lugar_id() As System.Int32
            Get
                Return _lugar_id
            End Get
            Set(ByVal value As System.Int32)
                _lugar_id = value
            End Set
        End Property
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property
        Public Property inactivo() As System.Boolean
            Get
                Return _inactivo
            End Get
            Set(ByVal value As System.Boolean)
                _inactivo = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property

    End Class 'TRAELUGARESENTREGA

    Public Class ENVIAMAILARTICULOSPROVISORIOS
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ENVIAMAILARTICULOSPROVISORIOS


    Public Class REQUERIMIENTOS_PARA_FINALIZAR
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _fecha As System.DateTime
        Private _obs As System.String
        Private _descripcion As System.String
        Private _sectorrequerimiento_id As System.Int32
        Private _usuario As System.String
        Private _usuarioautoriza As System.String
        Private _lugarentrega As System.String
        Private _entrega_id As System.Int32
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property
        Public Property sectorrequerimiento_id() As System.Int32
            Get
                Return _sectorrequerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _sectorrequerimiento_id = value
            End Set
        End Property
        Public Property usuario() As System.String
            Get
                Return _usuario
            End Get
            Set(ByVal value As System.String)
                _usuario = value
            End Set
        End Property
        Public Property usuarioautoriza() As System.String
            Get
                Return _usuarioautoriza
            End Get
            Set(ByVal value As System.String)
                _usuarioautoriza = value
            End Set
        End Property

        Public Property Lugarentrega As String
            Get
                Return _lugarentrega
            End Get
            Set(value As String)
                _lugarentrega = value
            End Set
        End Property

        Public Property Entrega_id As Integer
            Get
                Return _entrega_id
            End Get
            Set(value As Integer)
                _entrega_id = value
            End Set
        End Property
    End Class 'REQUERIMIENTOS_PARA_FINALIZAR

    Public Class REQUERIMIENTOITEM_SINOC
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _nroitem As System.Int32
        Private _art_descgen As System.String
        Private _articulo_id As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _nivelaut_id As System.Int32
        Private _fechaentrega As System.DateTime
        Private _marca As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property nivelaut_id() As System.Int32
            Get
                Return _nivelaut_id
            End Get
            Set(ByVal value As System.Int32)
                _nivelaut_id = value
            End Set
        End Property
        Public Property fechaentrega() As System.DateTime
            Get
                Return _fechaentrega
            End Get
            Set(ByVal value As System.DateTime)
                _fechaentrega = value
            End Set
        End Property

        Public Property Marca As String
            Get
                Return _marca
            End Get
            Set(value As String)
                _marca = value
            End Set
        End Property
    End Class 'REQUERIMIENTOITEM_SINOC

    Public Class PROXIMONROREMITO
        Private _nroremito As System.Int32
        Public Property nroremito() As System.Int32
            Get
                Return _nroremito
            End Get
            Set(ByVal value As System.Int32)
                _nroremito = value
            End Set
        End Property

    End Class 'TRAEREQUERIMIENTOSLIBRERIA

    Public Class TRAEDETALLEREMITOSPENDIENTES
        Private _nroitem As System.Int32
        Private _articulo_id As System.String
        Private _art_descgen As System.String
        Private _unimed As System.String
        Private _cantoriginal As System.Decimal
        Private _cantrecibida As System.Decimal
        Private _cantpedida As System.Decimal
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantoriginal() As System.Decimal
            Get
                Return _cantoriginal
            End Get
            Set(ByVal value As System.Decimal)
                _cantoriginal = value
            End Set
        End Property
        Public Property cantrecibida() As System.Decimal
            Get
                Return _cantrecibida
            End Get
            Set(ByVal value As System.Decimal)
                _cantrecibida = value
            End Set
        End Property
        Public Property cantpedida() As System.Decimal
            Get
                Return _cantpedida
            End Get
            Set(ByVal value As System.Decimal)
                _cantpedida = value
            End Set
        End Property

    End Class 'TRAEDETALLEREMITOSPENDIENTES
    Public Class TRAEREMITOSPENDIENTES
        Private _codemp As System.String
        Private _comprobante As System.Int32
        Private _letra As System.String
        Private _sucursal As System.String
        Private _fecha As System.DateTime
        Private _comprobantestk As System.Int32
        Private _codempstk As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property comprobante() As System.Int32
            Get
                Return _comprobante
            End Get
            Set(ByVal value As System.Int32)
                _comprobante = value
            End Set
        End Property
        Public Property letra() As System.String
            Get
                Return _letra
            End Get
            Set(ByVal value As System.String)
                _letra = value
            End Set
        End Property
        Public Property sucursal() As System.String
            Get
                Return _sucursal
            End Get
            Set(ByVal value As System.String)
                _sucursal = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property comprobantestk() As System.Int32
            Get
                Return _comprobantestk
            End Get
            Set(ByVal value As System.Int32)
                _comprobantestk = value
            End Set
        End Property
        Public Property codempstk() As System.String
            Get
                Return _codempstk
            End Get
            Set(ByVal value As System.String)
                _codempstk = value
            End Set
        End Property

    End Class 'TRAEREMITOSPENDIENTES

    Public Class TRAEREQUERIMIENTOSLIBRERIA
        Private _articulo_id As System.String
        Private _art_descgen As System.String
        Private _cantidad As System.Decimal
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property

    End Class 'TRAEREQUERIMIENTOSLIBRERIA

    Public Class ENVIAMAILARTICULOSCONDIFERENCIASSTK
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ENVIAMAILARTICULOSCONDIFERENCIASSTK

    Public Class TRAE_REMITOS_PARA_IMPRESION
        Private _codemp As System.String
        Private _comprobante As System.Int32
        Private _letra As System.String
        Private _sucursal As System.String
        Private _fecha As System.DateTime
        Private _comprobantestk As System.Int32
        Private _codempstk As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property comprobante() As System.Int32
            Get
                Return _comprobante
            End Get
            Set(ByVal value As System.Int32)
                _comprobante = value
            End Set
        End Property
        Public Property letra() As System.String
            Get
                Return _letra
            End Get
            Set(ByVal value As System.String)
                _letra = value
            End Set
        End Property
        Public Property sucursal() As System.String
            Get
                Return _sucursal
            End Get
            Set(ByVal value As System.String)
                _sucursal = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property comprobantestk() As System.Int32
            Get
                Return _comprobantestk
            End Get
            Set(ByVal value As System.Int32)
                _comprobantestk = value
            End Set
        End Property
        Public Property codempstk() As System.String
            Get
                Return _codempstk
            End Get
            Set(ByVal value As System.String)
                _codempstk = value
            End Set
        End Property

    End Class 'TRAE_REMITOS_PARA_IMPRESION

    Public Class GENERAHISTORIALSALDOPROVEEDOR
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'GENERAHISTORIALSALDOPROVEEDOR

    Public Class GENERANUEVOREQUERIMIENTO
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'GENERANUEVOREQUERIMIENTO

    Public Class REPOSICIONPORCONSUMO
        Private _articulo_id As System.String
        Private _art_descgen As System.String
        Private _unimed As System.String
        Private _codrubro As System.String
        Private _rubro As System.String
        Private _codsubrubro As System.String
        Private _subrubro As System.String
        Private _consumo As System.Decimal
        Private _cantpendientereq As System.Decimal
        Private _cantpendienteoc As System.Decimal
        Private _reponer As System.Decimal
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property codrubro() As System.String
            Get
                Return _codrubro
            End Get
            Set(ByVal value As System.String)
                _codrubro = value
            End Set
        End Property
        Public Property rubro() As System.String
            Get
                Return _rubro
            End Get
            Set(ByVal value As System.String)
                _rubro = value
            End Set
        End Property
        Public Property codsubrubro() As System.String
            Get
                Return _codsubrubro
            End Get
            Set(ByVal value As System.String)
                _codsubrubro = value
            End Set
        End Property
        Public Property subrubro() As System.String
            Get
                Return _subrubro
            End Get
            Set(ByVal value As System.String)
                _subrubro = value
            End Set
        End Property
        Public Property consumo() As System.Decimal
            Get
                Return _consumo
            End Get
            Set(ByVal value As System.Decimal)
                _consumo = value
            End Set
        End Property
        Public Property cantpendientereq() As System.Decimal
            Get
                Return _cantpendientereq
            End Get
            Set(ByVal value As System.Decimal)
                _cantpendientereq = value
            End Set
        End Property
        Public Property cantpendienteoc() As System.Decimal
            Get
                Return _cantpendienteoc
            End Get
            Set(ByVal value As System.Decimal)
                _cantpendienteoc = value
            End Set
        End Property
        Public Property reponer() As System.Decimal
            Get
                Return _reponer
            End Get
            Set(ByVal value As System.Decimal)
                _reponer = value
            End Set
        End Property

    End Class 'REPOSICIONPORCONSUMO

    Public Class EVENTOSUSUARIO
        Private _id As System.Int32
        Private _descripcion As System.String
        Public Property id() As System.Int32
            Get
                Return _id
            End Get
            Set(ByVal value As System.Int32)
                _id = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property

    End Class 'EVENTOSUSUARIO

    Public Class REQUERIMIENTOS_PARA_EXCLUIR_ARTICULOS
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _fecha As System.DateTime
        Private _obs As System.String
        Private _descripcion As System.String
        Private _sectorrequerimiento_id As System.Int32
        Private _usuario As System.String
        Private _usuarioautoriza As System.String
        Private _lugarentrega As System.String
        Private _entrega_id As System.Int32
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property
        Public Property sectorrequerimiento_id() As System.Int32
            Get
                Return _sectorrequerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _sectorrequerimiento_id = value
            End Set
        End Property
        Public Property usuario() As System.String
            Get
                Return _usuario
            End Get
            Set(ByVal value As System.String)
                _usuario = value
            End Set
        End Property
        Public Property usuarioautoriza() As System.String
            Get
                Return _usuarioautoriza
            End Get
            Set(ByVal value As System.String)
                _usuarioautoriza = value
            End Set
        End Property
        Public Property lugarentrega() As System.String
            Get
                Return _lugarentrega
            End Get
            Set(ByVal value As System.String)
                _lugarentrega = value
            End Set
        End Property
        Public Property entrega_id() As System.Int32
            Get
                Return _entrega_id
            End Get
            Set(ByVal value As System.Int32)
                _entrega_id = value
            End Set
        End Property

    End Class 'REQUERIMIENTOS_PARA_EXCLUIR_ARTICULOS

    Public Class EXCLUYEITEMSREQ
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'EXCLUYEITEMSREQ
    Public Class TRAEREQUERIMIENTOITEMPARAEXCLUIR
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _nroitem As System.Int32
        Private _art_descgen As System.String
        Private _articulo_id As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _nivelaut_id As System.Int32
        Private _fechaentrega As System.DateTime
        Private _marca As System.String
        Private _excluido As System.Int32
        Private _motivoexclusion As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property nivelaut_id() As System.Int32
            Get
                Return _nivelaut_id
            End Get
            Set(ByVal value As System.Int32)
                _nivelaut_id = value
            End Set
        End Property
        Public Property fechaentrega() As System.DateTime
            Get
                Return _fechaentrega
            End Get
            Set(ByVal value As System.DateTime)
                _fechaentrega = value
            End Set
        End Property
        Public Property marca() As System.String
            Get
                Return _marca
            End Get
            Set(ByVal value As System.String)
                _marca = value
            End Set
        End Property
        Public Property excluido() As System.Int32
            Get
                Return _excluido
            End Get
            Set(ByVal value As System.Int32)
                _excluido = value
            End Set
        End Property
        Public Property motivoexclusion() As System.String
            Get
                Return _motivoexclusion
            End Get
            Set(ByVal value As System.String)
                _motivoexclusion = value
            End Set
        End Property

    End Class 'TRAEREQUERIMIENTOITEMPARAEXCLUIR

    Public Class STOCK_A_FECHA_POREMPRESA
        Private _articulo_id As System.String
        Private _art_descgen As System.String
        Private _unimed As System.String
        Private _codrubro As System.String
        Private _rubro As System.String
        Private _codsubrubro As System.String
        Private _subrubro As System.String
        Private _cantidad As System.Decimal
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property codrubro() As System.String
            Get
                Return _codrubro
            End Get
            Set(ByVal value As System.String)
                _codrubro = value
            End Set
        End Property
        Public Property rubro() As System.String
            Get
                Return _rubro
            End Get
            Set(ByVal value As System.String)
                _rubro = value
            End Set
        End Property
        Public Property codsubrubro() As System.String
            Get
                Return _codsubrubro
            End Get
            Set(ByVal value As System.String)
                _codsubrubro = value
            End Set
        End Property
        Public Property subrubro() As System.String
            Get
                Return _subrubro
            End Get
            Set(ByVal value As System.String)
                _subrubro = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property

        'solo un comentario

    End Class 'STOCK_A_FECHA_POREMPRESA

    Public Class TRAESOLICITUDES
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _nrosolicitud As System.Int32
        Private _fecha As System.DateTime
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property nrosolicitud() As System.Int32
            Get
                Return _nrosolicitud
            End Get
            Set(ByVal value As System.Int32)
                _nrosolicitud = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property

    End Class 'TRAESOLICITUDES
    Public Class TRAECONCEPTOCTACONTABLE
        Private _con_cod As System.String
        Private _con_desc As System.String
        Private _cappla_cuentacpra As System.String
        Private _cta_descrip As System.String
        Private _descripsubcuenta As System.String
        Private _subcuenta As System.Int32
        Public Property con_cod() As System.String
            Get
                Return _con_cod
            End Get
            Set(ByVal value As System.String)
                _con_cod = value
            End Set
        End Property
        Public Property con_desc() As System.String
            Get
                Return _con_desc
            End Get
            Set(ByVal value As System.String)
                _con_desc = value
            End Set
        End Property
        Public Property cappla_cuentacpra() As System.String
            Get
                Return _cappla_cuentacpra
            End Get
            Set(ByVal value As System.String)
                _cappla_cuentacpra = value
            End Set
        End Property
        Public Property cta_descrip() As System.String
            Get
                Return _cta_descrip
            End Get
            Set(ByVal value As System.String)
                _cta_descrip = value
            End Set
        End Property
        Public Property descripsubcuenta() As System.String
            Get
                Return _descripsubcuenta
            End Get
            Set(ByVal value As System.String)
                _descripsubcuenta = value
            End Set
        End Property
        Public Property subcuenta() As System.Int32
            Get
                Return _subcuenta
            End Get
            Set(ByVal value As System.Int32)
                _subcuenta = value
            End Set
        End Property

    End Class 'TRAECONCEPTOCTACONTABLE

    Public Class USR_ACTULIZASUBCUENTACONCEPTO
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'USR_ACTULIZASUBCUENTACONCEPTO

    Public Class TRAECUENTASPORARTICULO
        Private _art_codgen As System.String
        Private _art_descgen As System.String
        Private _aappla_cuentacostos As System.String
        Private _aappla_cuentacpra As System.String
        Private _aappla_cuentavta As System.String
        Private _aappla_cuentainv As System.String
        Public Property art_codgen() As System.String
            Get
                Return _art_codgen
            End Get
            Set(ByVal value As System.String)
                _art_codgen = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property aappla_cuentacostos() As System.String
            Get
                Return _aappla_cuentacostos
            End Get
            Set(ByVal value As System.String)
                _aappla_cuentacostos = value
            End Set
        End Property
        Public Property aappla_cuentacpra() As System.String
            Get
                Return _aappla_cuentacpra
            End Get
            Set(ByVal value As System.String)
                _aappla_cuentacpra = value
            End Set
        End Property
        Public Property aappla_cuentavta() As System.String
            Get
                Return _aappla_cuentavta
            End Get
            Set(ByVal value As System.String)
                _aappla_cuentavta = value
            End Set
        End Property
        Public Property aappla_cuentainv() As System.String
            Get
                Return _aappla_cuentainv
            End Get
            Set(ByVal value As System.String)
                _aappla_cuentainv = value
            End Set
        End Property

    End Class 'TRAECUENTASPORARTICULO
    Public Class UPDATECUENTASPORARTICULO
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'UPDATECUENTASPORARTICULO

    Public Class ELIMINAPRORRATEO
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ELIMINAPRORRATEO

    Public Class USR_TRAEFACTURASPRORRATEADAS
        Private _emp As System.String
        Private _scc_id As System.Int32
        Private _sccsuc_cod As System.String
        Private _sccemp_codigo As System.String
        Private _femision As System.DateTime
        Private _letra As System.String
        Private _codigocomprob As System.String
        Private _descripcomprob As System.String
        Private _comprobante As System.String
        Private _codproveed As System.String
        Private _razonsocial As System.String
        Private _tipoprorrateo As System.String
        Public Property emp() As System.String
            Get
                Return _emp
            End Get
            Set(ByVal value As System.String)
                _emp = value
            End Set
        End Property
        Public Property scc_id() As System.Int32
            Get
                Return _scc_id
            End Get
            Set(ByVal value As System.Int32)
                _scc_id = value
            End Set
        End Property
        Public Property sccsuc_cod() As System.String
            Get
                Return _sccsuc_cod
            End Get
            Set(ByVal value As System.String)
                _sccsuc_cod = value
            End Set
        End Property
        Public Property sccemp_codigo() As System.String
            Get
                Return _sccemp_codigo
            End Get
            Set(ByVal value As System.String)
                _sccemp_codigo = value
            End Set
        End Property
        Public Property femision() As System.DateTime
            Get
                Return _femision
            End Get
            Set(ByVal value As System.DateTime)
                _femision = value
            End Set
        End Property
        Public Property letra() As System.String
            Get
                Return _letra
            End Get
            Set(ByVal value As System.String)
                _letra = value
            End Set
        End Property
        Public Property codigocomprob() As System.String
            Get
                Return _codigocomprob
            End Get
            Set(ByVal value As System.String)
                _codigocomprob = value
            End Set
        End Property
        Public Property descripcomprob() As System.String
            Get
                Return _descripcomprob
            End Get
            Set(ByVal value As System.String)
                _descripcomprob = value
            End Set
        End Property
        Public Property comprobante() As System.String
            Get
                Return _comprobante
            End Get
            Set(ByVal value As System.String)
                _comprobante = value
            End Set
        End Property
        Public Property codproveed() As System.String
            Get
                Return _codproveed
            End Get
            Set(ByVal value As System.String)
                _codproveed = value
            End Set
        End Property
        Public Property razonsocial() As System.String
            Get
                Return _razonsocial
            End Get
            Set(ByVal value As System.String)
                _razonsocial = value
            End Set
        End Property
        Public Property tipoprorrateo() As System.String
            Get
                Return _tipoprorrateo
            End Get
            Set(ByVal value As System.String)
                _tipoprorrateo = value
            End Set
        End Property

    End Class 'USR_TRAEFACTURASPRORRATEADAS

    Public Class ORDENCOMPRA_DISPONIBLES_SINSTOCK
        Private _codemp As System.String
        Private _ordencompra_id As System.Int32
        Private _fecha As System.DateTime
        Private _proveed_id As System.String
        Private _obs As System.String
        Private _razonsocial As System.String
        Private _estado_id As System.Int32
        Private _tipooc_id As System.Int32
        Private _modificacosto As System.Int32
        Private _condicionpago_id As System.String
        Private _usuario As System.String
        Private _email As System.String
        Private _pedidodiario As System.Boolean
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property ordencompra_id() As System.Int32
            Get
                Return _ordencompra_id
            End Get
            Set(ByVal value As System.Int32)
                _ordencompra_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property proveed_id() As System.String
            Get
                Return _proveed_id
            End Get
            Set(ByVal value As System.String)
                _proveed_id = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property razonsocial() As System.String
            Get
                Return _razonsocial
            End Get
            Set(ByVal value As System.String)
                _razonsocial = value
            End Set
        End Property
        Public Property estado_id() As System.Int32
            Get
                Return _estado_id
            End Get
            Set(ByVal value As System.Int32)
                _estado_id = value
            End Set
        End Property
        Public Property tipooc_id() As System.Int32
            Get
                Return _tipooc_id
            End Get
            Set(ByVal value As System.Int32)
                _tipooc_id = value
            End Set
        End Property
        Public Property modificacosto() As System.Int32
            Get
                Return _modificacosto
            End Get
            Set(ByVal value As System.Int32)
                _modificacosto = value
            End Set
        End Property
        Public Property condicionpago_id() As System.String
            Get
                Return _condicionpago_id
            End Get
            Set(ByVal value As System.String)
                _condicionpago_id = value
            End Set
        End Property
        Public Property usuario() As System.String
            Get
                Return _usuario
            End Get
            Set(ByVal value As System.String)
                _usuario = value
            End Set
        End Property
        Public Property email() As System.String
            Get
                Return _email
            End Get
            Set(ByVal value As System.String)
                _email = value
            End Set
        End Property
        Public Property pedidodiario() As System.Boolean
            Get
                Return _pedidodiario
            End Get
            Set(ByVal value As System.Boolean)
                _pedidodiario = value
            End Set
        End Property

    End Class 'ORDENCOMPRA_DISPONIBLES_SINSTOCK
    Public Class TRAEORDENCOMPRADETALLE
        Private _codemp As System.String
        Private _ordencompra_id As System.Int32
        Private _nroitem As System.Int32
        Private _cantidad As System.Int32
        Private _importe As System.Double
        Private _detalle As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property ordencompra_id() As System.Int32
            Get
                Return _ordencompra_id
            End Get
            Set(ByVal value As System.Int32)
                _ordencompra_id = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property cantidad() As System.Int32
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Int32)
                _cantidad = value
            End Set
        End Property
        Public Property importe() As System.Double
            Get
                Return _importe
            End Get
            Set(ByVal value As System.Double)
                _importe = value
            End Set
        End Property
        Public Property detalle() As System.String
            Get
                Return _detalle
            End Get
            Set(ByVal value As System.String)
                _detalle = value
            End Set
        End Property

    End Class 'TRAEORDENCOMPRADETALLE

    Public Class REQUERIMIENTOS_INERNO_DISPONIBLES
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _fecha As System.DateTime
        Private _obs As System.String
        Private _descripcion As System.String
        Private _sectorrequerimiento_id As System.Int32
        Private _usuario As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property descripcion() As System.String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As System.String)
                _descripcion = value
            End Set
        End Property
        Public Property sectorrequerimiento_id() As System.Int32
            Get
                Return _sectorrequerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _sectorrequerimiento_id = value
            End Set
        End Property
        Public Property usuario() As System.String
            Get
                Return _usuario
            End Get
            Set(ByVal value As System.String)
                _usuario = value
            End Set
        End Property

    End Class 'REQUERIMIENTOS_INERNO_DISPONIBLES

    Public Class TRAEREQUERIMIENTOINTERNOITEM
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _nroitem As System.Int32
        Private _art_descgen As System.String
        Private _articulo_id As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _nivelaut_id As System.Int32
        Private _fechaentrega As System.DateTime
        Private _marca As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property nivelaut_id() As System.Int32
            Get
                Return _nivelaut_id
            End Get
            Set(ByVal value As System.Int32)
                _nivelaut_id = value
            End Set
        End Property
        Public Property fechaentrega() As System.DateTime
            Get
                Return _fechaentrega
            End Get
            Set(ByVal value As System.DateTime)
                _fechaentrega = value
            End Set
        End Property

        Public Property Marca As String
            Get
                Return _marca
            End Get
            Set(value As String)
                _marca = value
            End Set
        End Property
    End Class 'TRAEREQUERIMIENTOINTERNOITEM

    Public Class MAXCOMPROBANTEREQUERIMIENTOINTERNO
        Private _requerimiento_id As System.Int32
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property

    End Class 'MAXCOMPROBANTEREQUERIMIENTOINTERNO

    Public Class REQUERIMIENTO_INTERNO_PENDIENTE_ENTREGAR
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _fecha As System.DateTime
        Private _usuario As System.String
        Private _obs As System.String
        Private _sectorentrega_id As System.Int32
        Private _lugarentrega As System.String
        Private _depositoorigen_id As System.Int32
        Private _sectordepositoorigen_id As System.Int32
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property fecha() As System.DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As System.DateTime)
                _fecha = value
            End Set
        End Property
        Public Property usuario() As System.String
            Get
                Return _usuario
            End Get
            Set(ByVal value As System.String)
                _usuario = value
            End Set
        End Property
        Public Property obs() As System.String
            Get
                Return _obs
            End Get
            Set(ByVal value As System.String)
                _obs = value
            End Set
        End Property
        Public Property sectorentrega_id() As System.Int32
            Get
                Return _sectorentrega_id
            End Get
            Set(ByVal value As System.Int32)
                _sectorentrega_id = value
            End Set
        End Property
        Public Property lugarentrega() As System.String
            Get
                Return _lugarentrega
            End Get
            Set(ByVal value As System.String)
                _lugarentrega = value
            End Set
        End Property
        Public Property depositoorigen_id() As System.Int32
            Get
                Return _depositoorigen_id
            End Get
            Set(ByVal value As System.Int32)
                _depositoorigen_id = value
            End Set
        End Property
        Public Property sectordepositoorigen_id() As System.Int32
            Get
                Return _sectordepositoorigen_id
            End Get
            Set(ByVal value As System.Int32)
                _sectordepositoorigen_id = value
            End Set
        End Property

    End Class 'REQUERIMIENTO_INTERNO_PENDIENTE_ENTREGAR

    Public Class TRAEREQUERIMIENTOITEM_PENDIENTE_DE_ENVIO
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _nroitem As System.Int32
        Private _art_descgen As System.String
        Private _articulo_id As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _nivelaut_id As System.Int32
        Private _fechaentrega As System.DateTime
        Private _cantidadadeudada As System.Decimal
        Private _marca As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property nivelaut_id() As System.Int32
            Get
                Return _nivelaut_id
            End Get
            Set(ByVal value As System.Int32)
                _nivelaut_id = value
            End Set
        End Property
        Public Property fechaentrega() As System.DateTime
            Get
                Return _fechaentrega
            End Get
            Set(ByVal value As System.DateTime)
                _fechaentrega = value
            End Set
        End Property
        Public Property cantidadadeudada() As System.Decimal
            Get
                Return _cantidadadeudada
            End Get
            Set(ByVal value As System.Decimal)
                _cantidadadeudada = value
            End Set
        End Property
        Public Property marca() As System.String
            Get
                Return _marca
            End Get
            Set(ByVal value As System.String)
                _marca = value
            End Set
        End Property

    End Class 'TRAEREQUERIMIENTOITEM_PENDIENTE_DE_ENVIO

    Public Class ACTUALIZA_OBS_REQ_INTERNO
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'ACTUALIZA_OBS_REQ_INTERNO

    Public Class EXCLUYEITEMSREQINTERNO
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'EXCLUYEITEMSREQINTERNO

    Public Class TRAEREQUERIMIENTOITEMPARAEXCLUIR_INTERNO
        Private _codemp As System.String
        Private _requerimiento_id As System.Int32
        Private _nroitem As System.Int32
        Private _art_descgen As System.String
        Private _articulo_id As System.String
        Private _unimed As System.String
        Private _cantidad As System.Decimal
        Private _nivelaut_id As System.Int32
        Private _fechaentrega As System.DateTime
        Private _marca As System.String
        Public Property codemp() As System.String
            Get
                Return _codemp
            End Get
            Set(ByVal value As System.String)
                _codemp = value
            End Set
        End Property
        Public Property requerimiento_id() As System.Int32
            Get
                Return _requerimiento_id
            End Get
            Set(ByVal value As System.Int32)
                _requerimiento_id = value
            End Set
        End Property
        Public Property nroitem() As System.Int32
            Get
                Return _nroitem
            End Get
            Set(ByVal value As System.Int32)
                _nroitem = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property articulo_id() As System.String
            Get
                Return _articulo_id
            End Get
            Set(ByVal value As System.String)
                _articulo_id = value
            End Set
        End Property
        Public Property unimed() As System.String
            Get
                Return _unimed
            End Get
            Set(ByVal value As System.String)
                _unimed = value
            End Set
        End Property
        Public Property cantidad() As System.Decimal
            Get
                Return _cantidad
            End Get
            Set(ByVal value As System.Decimal)
                _cantidad = value
            End Set
        End Property
        Public Property nivelaut_id() As System.Int32
            Get
                Return _nivelaut_id
            End Get
            Set(ByVal value As System.Int32)
                _nivelaut_id = value
            End Set
        End Property
        Public Property fechaentrega() As System.DateTime
            Get
                Return _fechaentrega
            End Get
            Set(ByVal value As System.DateTime)
                _fechaentrega = value
            End Set
        End Property
        Public Property marca() As System.String
            Get
                Return _marca
            End Get
            Set(ByVal value As System.String)
                _marca = value
            End Set
        End Property

    End Class 'TRAEREQUERIMIENTOITEMPARAEXCLUIR_INTERNO

    Public Class AJUSTEVENCIMIENTOS
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'AJUSTEVENCIMIENTOS

    Public Class DESCUENTAINVENTARIOAJUSTE
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'DESCUENTAINVENTARIOAJUSTE
End Namespace 'Procedures

Namespace UserObJ
    Public Class ReqOrdenCompra
        Dim _codEmp As String
        Dim _nroItem As Integer
        Dim _requerimiento_Id As Integer
        Dim _articulo_id As String

        Public Property CodEmp As String
            Get
                Return _codEmp
            End Get
            Set(value As String)
                _codEmp = value
            End Set
        End Property

        Public Property NroItem As Integer
            Get
                Return _nroItem
            End Get
            Set(value As Integer)
                _nroItem = value
            End Set
        End Property

        Public Property Requerimiento_Id As Integer
            Get
                Return _requerimiento_Id
            End Get
            Set(value As Integer)
                _requerimiento_Id = value
            End Set
        End Property

        Public Property Articulo_id As String
            Get
                Return _articulo_id
            End Get
            Set(value As String)
                _articulo_id = value
            End Set
        End Property
    End Class

    Public Class TRAECUENTASPORARTICULO
        Private _art_codgen As System.String
        Private _art_descgen As System.String
        Private _aappla_cuentacostos As System.String
        Private _aappla_cuentacpra As System.String
        Private _aappla_cuentavta As System.String
        Private _aappla_cuentainv As System.String
        Public Property art_codgen() As System.String
            Get
                Return _art_codgen
            End Get
            Set(ByVal value As System.String)
                _art_codgen = value
            End Set
        End Property
        Public Property art_descgen() As System.String
            Get
                Return _art_descgen
            End Get
            Set(ByVal value As System.String)
                _art_descgen = value
            End Set
        End Property
        Public Property aappla_cuentacostos() As System.String
            Get
                Return _aappla_cuentacostos
            End Get
            Set(ByVal value As System.String)
                _aappla_cuentacostos = value
            End Set
        End Property
        Public Property aappla_cuentacpra() As System.String
            Get
                Return _aappla_cuentacpra
            End Get
            Set(ByVal value As System.String)
                _aappla_cuentacpra = value
            End Set
        End Property
        Public Property aappla_cuentavta() As System.String
            Get
                Return _aappla_cuentavta
            End Get
            Set(ByVal value As System.String)
                _aappla_cuentavta = value
            End Set
        End Property
        Public Property aappla_cuentainv() As System.String
            Get
                Return _aappla_cuentainv
            End Get
            Set(ByVal value As System.String)
                _aappla_cuentainv = value
            End Set
        End Property

    End Class 'TRAECUENTASPORARTICULO
    Public Class UPDATECUENTASPORARTICULO
        Private _result As Object
        Public Property Result() As Object
            Get
                Return _result
            End Get
            Set(ByVal value As Object)
                _result = value
            End Set
        End Property

    End Class 'UPDATECUENTASPORARTICULO



End Namespace

Namespace Views

End Namespace 'Views

