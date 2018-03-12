

Namespace Tables

    Partial Public Class PROVSEGUIMIENTO
        Inherits DAL.Tables.PROVSEGUIMIENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.PROVSEGUIMIENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal ccoemp_codigo As System.String, ByVal ccosuc_cod As System.String, ByVal cco_id As System.Int32) As List(Of Entities.Tables.PROVSEGUIMIENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.ccoemp_codigo, DAL.SqlEnums.OperandEnum.Equal, ccoemp_codigo)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.ccosuc_cod, DAL.SqlEnums.OperandEnum.Equal, ccosuc_cod)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.cco_id, DAL.SqlEnums.OperandEnum.Equal, cco_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PROVSEGUIMIENTO) As Entities.Tables.PROVSEGUIMIENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal ccoemp_codigo As System.String, ByVal ccosuc_cod As System.String, ByVal cco_id As System.Int32, ByVal ccotco_cod As System.String, ByVal cco_letra As System.String, ByVal cco_codpvt As System.String, ByVal cco_nro As System.String, ByVal cco_femision As System.DateTime, ByVal cco_fvto As System.DateTime, ByVal cco_impmonloc As System.Double, ByVal cco_saldomonloc As System.Double, ByVal cco_codpro As System.String, ByVal ccopro_razsoc As System.String, ByVal tiporeclamo As System.Int32, ByVal estado_id As System.Int32, ByVal usuario As System.String, ByVal adeudanc As System.Boolean, ByVal fechaultimoreclamo As System.DateTime) As Entities.Tables.PROVSEGUIMIENTO
            Try
                Dim NewItem As New Entities.Tables.PROVSEGUIMIENTO
                With NewItem
                    .ccoemp_codigo = ccoemp_codigo
                    .ccosuc_cod = ccosuc_cod
                    .cco_id = cco_id
                    .ccotco_cod = ccotco_cod
                    .cco_letra = cco_letra
                    .cco_codpvt = cco_codpvt
                    .cco_nro = cco_nro
                    .cco_femision = cco_femision
                    .cco_fvto = cco_fvto
                    .cco_impmonloc = cco_impmonloc
                    .cco_saldomonloc = cco_saldomonloc
                    .cco_codpro = cco_codpro
                    .ccopro_razsoc = ccopro_razsoc
                    .tiporeclamo = tiporeclamo
                    .estado_id = estado_id
                    .usuario = usuario
                    .adeudanc = adeudanc
                    .fechaultimoreclamo = fechaultimoreclamo

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PROVSEGUIMIENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal ccoemp_codigo As System.String, ByVal ccosuc_cod As System.String, ByVal cco_id As System.Int32, ByVal ccotco_cod As System.String, ByVal cco_letra As System.String, ByVal cco_codpvt As System.String, ByVal cco_nro As System.String, ByVal cco_femision As System.DateTime, ByVal cco_fvto As System.DateTime, ByVal cco_impmonloc As System.Double, ByVal cco_saldomonloc As System.Double, ByVal cco_codpro As System.String, ByVal ccopro_razsoc As System.String, ByVal tiporeclamo As System.Int32, ByVal estado_id As System.Int32, ByVal usuario As System.String, ByVal adeudanc As System.Boolean, ByVal fechaultimoreclamo As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PROVSEGUIMIENTO
                With NewItem
                    .ccoemp_codigo = ccoemp_codigo
                    .ccosuc_cod = ccosuc_cod
                    .cco_id = cco_id
                    .ccotco_cod = ccotco_cod
                    .cco_letra = cco_letra
                    .cco_codpvt = cco_codpvt
                    .cco_nro = cco_nro
                    .cco_femision = cco_femision
                    .cco_fvto = cco_fvto
                    .cco_impmonloc = cco_impmonloc
                    .cco_saldomonloc = cco_saldomonloc
                    .cco_codpro = cco_codpro
                    .ccopro_razsoc = ccopro_razsoc
                    .tiporeclamo = tiporeclamo
                    .estado_id = estado_id
                    .usuario = usuario
                    .adeudanc = adeudanc
                    .fechaultimoreclamo = fechaultimoreclamo

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PROVSEGUIMIENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal ccoemp_codigo As System.String, ByVal ccosuc_cod As System.String, ByVal cco_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.PROVSEGUIMIENTO
                With NewItem
                    .ccoemp_codigo = ccoemp_codigo
                    .ccosuc_cod = ccosuc_cod
                    .cco_id = cco_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PROVSEGUIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TBL_MENUS
        Inherits DAL.Tables.TBL_MENUS
        Public Overloads Function ItemList() As List(Of Entities.Tables.TBL_MENUS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_menu As System.Int32) As List(Of Entities.Tables.TBL_MENUS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id_Menu, DAL.SqlEnums.OperandEnum.Equal, id_menu)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.TBL_MENUS) As Entities.Tables.TBL_MENUS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_menu As System.Int32, ByVal id_menupadre As System.Int32, ByVal descripcionmenu As System.String, ByVal posicionmenu As System.Int32, ByVal habilitadomenu As System.Boolean, ByVal urlmenu As System.String, ByVal formularioasociado As System.Boolean) As Entities.Tables.TBL_MENUS
            Try
                Dim NewItem As New Entities.Tables.TBL_MENUS
                With NewItem
                    .ID_MENU = id_menu
                    .ID_MENUPADRE = id_menupadre
                    .DESCRIPCIONMENU = descripcionmenu
                    .POSICIONMENU = posicionmenu
                    .HABILITADOMENU = habilitadomenu
                    .URLMENU = urlmenu
                    .FORMULARIOASOCIADO = formularioasociado

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TBL_MENUS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id_menu As System.Int32, ByVal id_menupadre As System.Int32, ByVal descripcionmenu As System.String, ByVal posicionmenu As System.Int32, ByVal habilitadomenu As System.Boolean, ByVal urlmenu As System.String, ByVal formularioasociado As System.Boolean) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_MENUS
                With NewItem
                    .ID_MENU = id_menu
                    .ID_MENUPADRE = id_menupadre
                    .DESCRIPCIONMENU = descripcionmenu
                    .POSICIONMENU = posicionmenu
                    .HABILITADOMENU = habilitadomenu
                    .URLMENU = urlmenu
                    .FORMULARIOASOCIADO = formularioasociado

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TBL_MENUS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id_menu As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_MENUS
                With NewItem
                    .ID_MENU = id_menu

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.TBL_MENUS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TBL_PERFILES
        Inherits DAL.Tables.TBL_PERFILES
        Public Overloads Function ItemList() As List(Of Entities.Tables.TBL_PERFILES)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_perfil As System.Int32) As List(Of Entities.Tables.TBL_PERFILES)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id_Perfil, DAL.SqlEnums.OperandEnum.Equal, id_perfil)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.TBL_PERFILES) As Entities.Tables.TBL_PERFILES
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_perfil As System.Int32, ByVal nombreperfil As System.String, ByVal descripcionperfil As System.String) As Entities.Tables.TBL_PERFILES
            Try
                Dim NewItem As New Entities.Tables.TBL_PERFILES
                With NewItem
                    .ID_PERFIL = id_perfil
                    .NOMBREPERFIL = nombreperfil
                    .DESCRIPCIONPERFIL = descripcionperfil

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TBL_PERFILES) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id_perfil As System.Int32, ByVal nombreperfil As System.String, ByVal descripcionperfil As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_PERFILES
                With NewItem
                    .ID_PERFIL = id_perfil
                    .NOMBREPERFIL = nombreperfil
                    .DESCRIPCIONPERFIL = descripcionperfil

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TBL_PERFILES) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id_perfil As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_PERFILES
                With NewItem
                    .ID_PERFIL = id_perfil

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.TBL_PERFILES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TBL_PERFILESPERMISOS
        Inherits DAL.Tables.TBL_PERFILESPERMISOS
        Public Overloads Function ItemList() As List(Of Entities.Tables.TBL_PERFILESPERMISOS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_perfilpermisos As System.Int32) As List(Of Entities.Tables.TBL_PERFILESPERMISOS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id_PerfilPermisos, DAL.SqlEnums.OperandEnum.Equal, id_perfilpermisos)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.TBL_PERFILESPERMISOS) As Entities.Tables.TBL_PERFILESPERMISOS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_perfilpermisos As System.Int32, ByVal id_perfil As System.Int32, ByVal id_menu As System.Int32, ByVal lectura As System.Boolean, ByVal escritura As System.Boolean, ByVal eliminacion As System.Boolean) As Entities.Tables.TBL_PERFILESPERMISOS
            Try
                Dim NewItem As New Entities.Tables.TBL_PERFILESPERMISOS
                With NewItem
                    .ID_PERFILPERMISOS = id_perfilpermisos
                    .ID_PERFIL = id_perfil
                    .ID_MENU = id_menu
                    .LECTURA = lectura
                    .ESCRITURA = escritura
                    .ELIMINACION = eliminacion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TBL_PERFILESPERMISOS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id_perfilpermisos As System.Int32, ByVal id_perfil As System.Int32, ByVal id_menu As System.Int32, ByVal lectura As System.Boolean, ByVal escritura As System.Boolean, ByVal eliminacion As System.Boolean) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_PERFILESPERMISOS
                With NewItem
                    .ID_PERFILPERMISOS = id_perfilpermisos
                    .ID_PERFIL = id_perfil
                    .ID_MENU = id_menu
                    .LECTURA = lectura
                    .ESCRITURA = escritura
                    .ELIMINACION = eliminacion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TBL_PERFILESPERMISOS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id_perfilpermisos As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_PERFILESPERMISOS
                With NewItem
                    .ID_PERFILPERMISOS = id_perfilpermisos

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.TBL_PERFILESPERMISOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    'Partial Public Class TBL_USUARIOS
    '    Inherits DAL.Tables.TBL_USUARIOS
    '    Public Overloads Function ItemList() As List(Of Entities.Tables.TBL_USUARIOS)
    '        Return MyBase.Items
    '    End Function

    '    Public Overloads Function ItemList(ByVal id_usuario As System.Int32) As List(Of Entities.Tables.TBL_USUARIOS)
    '        Try
    '            MyBase.WhereParameter.Add(ColumnEnum.Id_Usuario, DAL.SqlEnums.OperandEnum.Equal, id_usuario)

    '            Return MyBase.Items
    '        Catch Ex As Exception
    '            Throw Ex
    '        End Try
    '    End Function
    '    Public Overloads Function AddItem(ByVal Item As Entities.Tables.TBL_USUARIOS) As Entities.Tables.TBL_USUARIOS
    '        Return MyBase.Add(Item)
    '    End Function

    '    Public Overloads Function AddItem(ByVal id_usuario As System.Int32, ByVal id_perfil As System.Int32, ByVal identificadorusuario As System.String, ByVal contraseniausuario As System.String, ByVal nombreusuario As System.String, ByVal inactivo As System.Boolean, ByVal sector_id As System.Int32, ByVal email As System.String) As Entities.Tables.TBL_USUARIOS
    '        Try
    '            Dim NewItem As New Entities.Tables.TBL_USUARIOS
    '            With NewItem
    '                .ID_USUARIO = id_usuario
    '                .ID_PERFIL = id_perfil
    '                .IDENTIFICADORUSUARIO = identificadorusuario
    '                .CONTRASENIAUSUARIO = contraseniausuario
    '                .NOMBREUSUARIO = nombreusuario
    '                .INACTIVO = inactivo
    '                .SECTOR_ID = sector_id
    '                .EMAIL = email

    '            End With
    '            MyBase.Add(NewItem)
    '            Return NewItem
    '        Catch Ex As Exception
    '            Throw Ex
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TBL_USUARIOS) As Boolean
    '        Return MyBase.Update(Item)
    '    End Function

    '    Public Overloads Function UpdateItem(ByVal id_usuario As System.Int32, ByVal id_perfil As System.Int32, ByVal identificadorusuario As System.String, ByVal contraseniausuario As System.String, ByVal nombreusuario As System.String, ByVal inactivo As System.Boolean, ByVal sector_id As System.Int32, ByVal email As System.String) As Boolean
    '        Try
    '            Dim NewItem As New Entities.Tables.TBL_USUARIOS
    '            With NewItem
    '                .ID_USUARIO = id_usuario
    '                .ID_PERFIL = id_perfil
    '                .IDENTIFICADORUSUARIO = identificadorusuario
    '                .CONTRASENIAUSUARIO = contraseniausuario
    '                .NOMBREUSUARIO = nombreusuario
    '                .INACTIVO = inactivo
    '                .SECTOR_ID = sector_id
    '                .EMAIL = email

    '            End With
    '            Return MyBase.Update(NewItem)
    '        Catch Ex As Exception
    '            Throw Ex
    '        End Try
    '    End Function

    '    Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TBL_USUARIOS) As Boolean
    '        Return MyBase.Remove(Item)
    '    End Function

    '    Public Overloads Function RemoveItem(ByVal id_usuario As System.Int32) As Boolean
    '        Try
    '            Dim NewItem As New Entities.Tables.TBL_USUARIOS
    '            With NewItem
    '                .ID_USUARIO = id_usuario

    '            End With
    '            Return MyBase.Remove(NewItem)
    '        Catch Ex As Exception
    '            Throw (Ex)
    '        End Try
    '    End Function

    '    Public ReadOnly Property Result() As List(Of Entities.Tables.TBL_USUARIOS)
    '        Get
    '            Return MyBase.Resultset
    '        End Get
    '    End Property

    'End Class '
    Partial Public Class TBL_USUARIOS
        Inherits DAL.Tables.TBL_USUARIOS
        Public Overloads Function ItemList() As List(Of Entities.Tables.TBL_USUARIOS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_usuario As System.Int32) As List(Of Entities.Tables.TBL_USUARIOS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id_Usuario, DAL.SqlEnums.OperandEnum.Equal, id_usuario)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.TBL_USUARIOS) As Entities.Tables.TBL_USUARIOS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_usuario As System.Int32, ByVal id_perfil As System.Int32, ByVal identificadorusuario As System.String, ByVal contraseniausuario As System.String, ByVal nombreusuario As System.String, ByVal inactivo As System.Boolean, ByVal sector_id As System.Int32, ByVal email As System.String, ByVal empresa As System.String) As Entities.Tables.TBL_USUARIOS
            Try
                Dim NewItem As New Entities.Tables.TBL_USUARIOS
                With NewItem
                    .ID_USUARIO = id_usuario
                    .ID_PERFIL = id_perfil
                    .IDENTIFICADORUSUARIO = identificadorusuario
                    .CONTRASENIAUSUARIO = contraseniausuario
                    .NOMBREUSUARIO = nombreusuario
                    .INACTIVO = inactivo
                    .SECTOR_ID = sector_id
                    .EMAIL = email
                    .EMPRESA = empresa

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TBL_USUARIOS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id_usuario As System.Int32, ByVal id_perfil As System.Int32, ByVal identificadorusuario As System.String, ByVal contraseniausuario As System.String, ByVal nombreusuario As System.String, ByVal inactivo As System.Boolean, ByVal sector_id As System.Int32, ByVal email As System.String, ByVal empresa As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_USUARIOS
                With NewItem
                    .ID_USUARIO = id_usuario
                    .ID_PERFIL = id_perfil
                    .IDENTIFICADORUSUARIO = identificadorusuario
                    .CONTRASENIAUSUARIO = contraseniausuario
                    .NOMBREUSUARIO = nombreusuario
                    .INACTIVO = inactivo
                    .SECTOR_ID = sector_id
                    .EMAIL = email
                    .EMPRESA = empresa

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TBL_USUARIOS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id_usuario As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_USUARIOS
                With NewItem
                    .ID_USUARIO = id_usuario

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.TBL_USUARIOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ESTADORECLAMOPROVEEDOR
        Inherits DAL.Tables.ESTADORECLAMOPROVEEDOR
        Public Overloads Function ItemList() As List(Of Entities.Tables.ESTADORECLAMOPROVEEDOR)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal estado_id As System.Int32) As List(Of Entities.Tables.ESTADORECLAMOPROVEEDOR)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Estado_id, DAL.SqlEnums.OperandEnum.Equal, estado_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.ESTADORECLAMOPROVEEDOR) As Entities.Tables.ESTADORECLAMOPROVEEDOR
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal estado_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.ESTADORECLAMOPROVEEDOR
            Try
                Dim NewItem As New Entities.Tables.ESTADORECLAMOPROVEEDOR
                With NewItem
                    .ESTADO_ID = estado_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.ESTADORECLAMOPROVEEDOR) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal estado_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.ESTADORECLAMOPROVEEDOR
                With NewItem
                    .ESTADO_ID = estado_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.ESTADORECLAMOPROVEEDOR) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal estado_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.ESTADORECLAMOPROVEEDOR
                With NewItem
                    .ESTADO_ID = estado_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.ESTADORECLAMOPROVEEDOR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TIPORECLAMOPROVEEDOR
        Inherits DAL.Tables.TIPORECLAMOPROVEEDOR
        Public Overloads Function ItemList() As List(Of Entities.Tables.TIPORECLAMOPROVEEDOR)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal tiporeclamo As System.Int32) As List(Of Entities.Tables.TIPORECLAMOPROVEEDOR)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.tipoReclamo, DAL.SqlEnums.OperandEnum.Equal, tiporeclamo)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.TIPORECLAMOPROVEEDOR) As Entities.Tables.TIPORECLAMOPROVEEDOR
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal tiporeclamo As System.Int32, ByVal descripcion As System.String) As Entities.Tables.TIPORECLAMOPROVEEDOR
            Try
                Dim NewItem As New Entities.Tables.TIPORECLAMOPROVEEDOR
                With NewItem
                    .TIPORECLAMO = tiporeclamo
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TIPORECLAMOPROVEEDOR) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal tiporeclamo As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TIPORECLAMOPROVEEDOR
                With NewItem
                    .TIPORECLAMO = tiporeclamo
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TIPORECLAMOPROVEEDOR) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal tiporeclamo As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TIPORECLAMOPROVEEDOR
                With NewItem
                    .TIPORECLAMO = tiporeclamo

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.TIPORECLAMOPROVEEDOR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class ENTREGAORDENPAGO
        Inherits DAL.Tables.ENTREGAORDENPAGO
        Public Overloads Function ItemList() As List(Of Entities.Tables.ENTREGAORDENPAGO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal ccoemp_codigo As System.String, ByVal ccosuc_cod As System.String, ByVal cco_id As System.Int32) As List(Of Entities.Tables.ENTREGAORDENPAGO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.ccoemp_codigo, DAL.SqlEnums.OperandEnum.Equal, ccoemp_codigo)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.ccosuc_cod, DAL.SqlEnums.OperandEnum.Equal, ccosuc_cod)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.cco_id, DAL.SqlEnums.OperandEnum.Equal, cco_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.ENTREGAORDENPAGO) As Entities.Tables.ENTREGAORDENPAGO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal ccoemp_codigo As System.String, ByVal ccosuc_cod As System.String, ByVal cco_id As System.Int32, ByVal cco_nro As System.String, ByVal cco_femision As System.DateTime, ByVal cco_impmonloc As System.Double, ByVal cco_codpro As System.String, ByVal ccopro_razsoc As System.String, ByVal fecharetiro As System.DateTime, ByVal usuario As System.String) As Entities.Tables.ENTREGAORDENPAGO
            Try
                Dim NewItem As New Entities.Tables.ENTREGAORDENPAGO
                With NewItem
                    .ccoemp_codigo = ccoemp_codigo
                    .ccosuc_cod = ccosuc_cod
                    .cco_id = cco_id
                    .cco_nro = cco_nro
                    .cco_femision = cco_femision
                    .cco_impmonloc = cco_impmonloc
                    .cco_codpro = cco_codpro
                    .ccopro_razsoc = ccopro_razsoc
                    .fecharetiro = fecharetiro
                    .usuario = usuario

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.ENTREGAORDENPAGO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal ccoemp_codigo As System.String, ByVal ccosuc_cod As System.String, ByVal cco_id As System.Int32, ByVal cco_nro As System.String, ByVal cco_femision As System.DateTime, ByVal cco_impmonloc As System.Double, ByVal cco_codpro As System.String, ByVal ccopro_razsoc As System.String, ByVal fecharetiro As System.DateTime, ByVal usuario As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.ENTREGAORDENPAGO
                With NewItem
                    .ccoemp_codigo = ccoemp_codigo
                    .ccosuc_cod = ccosuc_cod
                    .cco_id = cco_id
                    .cco_nro = cco_nro
                    .cco_femision = cco_femision
                    .cco_impmonloc = cco_impmonloc
                    .cco_codpro = cco_codpro
                    .ccopro_razsoc = ccopro_razsoc
                    .fecharetiro = fecharetiro
                    .usuario = usuario

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.ENTREGAORDENPAGO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal ccoemp_codigo As System.String, ByVal ccosuc_cod As System.String, ByVal cco_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.ENTREGAORDENPAGO
                With NewItem
                    .ccoemp_codigo = ccoemp_codigo
                    .ccosuc_cod = ccosuc_cod
                    .cco_id = cco_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.ENTREGAORDENPAGO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class HISTORIALSEGUIMIENTO
        Inherits DAL.Tables.HISTORIALSEGUIMIENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.HISTORIALSEGUIMIENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id As System.Int32, ByVal ccoemp_codigo As System.String, ByVal ccosuc_cod As System.String, ByVal cco_id As System.Int32) As List(Of Entities.Tables.HISTORIALSEGUIMIENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.ccoemp_Codigo, DAL.SqlEnums.OperandEnum.Equal, ccoemp_codigo)
                'MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.ccoemp_codigo, DAL.SqlEnums.OperandEnum.Equal, ccoemp_codigo)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.ccosuc_cod, DAL.SqlEnums.OperandEnum.Equal, ccosuc_cod)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.cco_id, DAL.SqlEnums.OperandEnum.Equal, cco_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.HISTORIALSEGUIMIENTO) As Entities.Tables.HISTORIALSEGUIMIENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id As System.Int32, ByVal ccoemp_codigo As System.String, ByVal ccosuc_cod As System.String, ByVal cco_id As System.Int32, ByVal fecha As System.DateTime, ByVal obs As System.String) As Entities.Tables.HISTORIALSEGUIMIENTO
            Try
                Dim NewItem As New Entities.Tables.HISTORIALSEGUIMIENTO
                With NewItem
                    .id = id
                    .ccoemp_codigo = ccoemp_codigo
                    .ccosuc_cod = ccosuc_cod
                    .cco_id = cco_id
                    .fecha = fecha
                    .obs = obs

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.HISTORIALSEGUIMIENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id As System.Int32, ByVal ccoemp_codigo As System.String, ByVal ccosuc_cod As System.String, ByVal cco_id As System.Int32, ByVal fecha As System.DateTime, ByVal obs As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.HISTORIALSEGUIMIENTO
                With NewItem
                    .id = id
                    .ccoemp_codigo = ccoemp_codigo
                    .ccosuc_cod = ccosuc_cod
                    .cco_id = cco_id
                    .fecha = fecha
                    .obs = obs

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.HISTORIALSEGUIMIENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id As System.Int32, ByVal ccoemp_codigo As System.String, ByVal ccosuc_cod As System.String, ByVal cco_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.HISTORIALSEGUIMIENTO
                With NewItem
                    .id = id
                    .ccoemp_codigo = ccoemp_codigo
                    .ccosuc_cod = ccosuc_cod
                    .cco_id = cco_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.HISTORIALSEGUIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class RECLAMOFACTURASINCARGAR
        Inherits DAL.Tables.RECLAMOFACTURASINCARGAR
        Public Overloads Function ItemList() As List(Of Entities.Tables.RECLAMOFACTURASINCARGAR)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id As System.Int32) As List(Of Entities.Tables.RECLAMOFACTURASINCARGAR)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.id, DAL.SqlEnums.OperandEnum.Equal, id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.RECLAMOFACTURASINCARGAR) As Entities.Tables.RECLAMOFACTURASINCARGAR
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id As System.Int32, ByVal ccoEmp_Codigo As System.String, ByVal cco_codpro As System.String, ByVal ccopro_razsoc As System.String, ByVal cco_nro As System.String, ByVal cco_femision As System.DateTime, ByVal cco_impmonloc As System.Double, ByVal fechareclamo As System.DateTime, ByVal usuario As System.String, ByVal enbejerman As System.Int32, ByVal obs As System.String) As Entities.Tables.RECLAMOFACTURASINCARGAR
            Try
                Dim NewItem As New Entities.Tables.RECLAMOFACTURASINCARGAR
                With NewItem
                    .ID = id
                    .CCOEMP_CODIGO = ccoEmp_Codigo
                    .CCO_CODPRO = cco_codpro
                    .CCOPRO_RAZSOC = ccopro_razsoc
                    .CCO_NRO = cco_nro
                    .CCO_FEMISION = cco_femision
                    .CCO_IMPMONLOC = cco_impmonloc
                    .FECHARECLAMO = fechareclamo
                    .USUARIO = usuario
                    .ENBEJERMAN = enbejerman
                    .OBS = obs

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.RECLAMOFACTURASINCARGAR) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id As System.Int32, ByVal ccoEmp_Codigo As System.String, ByVal cco_codpro As System.String, ByVal ccopro_razsoc As System.String, ByVal cco_nro As System.String, ByVal cco_femision As System.DateTime, ByVal cco_impmonloc As System.Double, ByVal fechareclamo As System.DateTime, ByVal usuario As System.String, ByVal enbejerman As System.Int32, ByVal obs As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.RECLAMOFACTURASINCARGAR
                With NewItem
                    .ID = id
                    .CCOEMP_CODIGO = ccoEmp_Codigo
                    .CCO_CODPRO = cco_codpro
                    .CCOPRO_RAZSOC = ccopro_razsoc
                    .CCO_NRO = cco_nro
                    .CCO_FEMISION = cco_femision
                    .CCO_IMPMONLOC = cco_impmonloc
                    .FECHARECLAMO = fechareclamo
                    .USUARIO = usuario
                    .ENBEJERMAN = enbejerman
                    .OBS = obs

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.RECLAMOFACTURASINCARGAR) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.RECLAMOFACTURASINCARGAR
                With NewItem
                    .id = id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.RECLAMOFACTURASINCARGAR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKENVIOSARTICULOS
        Inherits DAL.Tables.STKENVIOSARTICULOS
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKENVIOSARTICULOS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal fecha As System.DateTime) As List(Of Entities.Tables.STKENVIOSARTICULOS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codemp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.fecha, DAL.SqlEnums.OperandEnum.Equal, fecha)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKENVIOSARTICULOS) As Entities.Tables.STKENVIOSARTICULOS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal fecha As System.DateTime, ByVal id_articulo As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal usuario As System.String, ByVal obs As System.String) As Entities.Tables.STKENVIOSARTICULOS
            Try
                Dim NewItem As New Entities.Tables.STKENVIOSARTICULOS
                With NewItem
                    .codemp = codemp
                    .fecha = fecha
                    .id_articulo = id_articulo
                    .unimed = unimed
                    .cantidad = cantidad
                    .usuario = usuario
                    .obs = obs

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKENVIOSARTICULOS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal fecha As System.DateTime, ByVal id_articulo As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal usuario As System.String, ByVal obs As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKENVIOSARTICULOS
                With NewItem
                    .codemp = codemp
                    .fecha = fecha
                    .id_articulo = id_articulo
                    .unimed = unimed
                    .cantidad = cantidad
                    .usuario = usuario
                    .obs = obs

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKENVIOSARTICULOS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal fecha As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.tables.STKENVIOSARTICULOS
                With NewItem
                    .codemp = codemp
                    .fecha = fecha

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKENVIOSARTICULOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMAUTORIZACION
        Inherits DAL.Tables.COMAUTORIZACION
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMAUTORIZACION)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal nivel_id As System.Int32) As List(Of Entities.Tables.COMAUTORIZACION)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.nivel_id, DAL.SqlEnums.OperandEnum.Equal, nivel_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMAUTORIZACION) As Entities.Tables.COMAUTORIZACION
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal nivel_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.COMAUTORIZACION
            Try
                Dim NewItem As New Entities.Tables.COMAUTORIZACION
                With NewItem
                    .nivel_id = nivel_id
                    .descripcion = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMAUTORIZACION) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal nivel_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMAUTORIZACION
                With NewItem
                    .nivel_id = nivel_id
                    .descripcion = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMAUTORIZACION) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal nivel_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.COMAUTORIZACION
                With NewItem
                    .nivel_id = nivel_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMAUTORIZACION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

  
    Partial Public Class COMESTADO
        Inherits DAL.Tables.COMESTADO
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMESTADO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal estado_id As System.Int32) As List(Of Entities.Tables.COMESTADO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.estado_id, DAL.SqlEnums.OperandEnum.Equal, estado_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMESTADO) As Entities.Tables.COMESTADO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal estado_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.COMESTADO
            Try
                Dim NewItem As New Entities.Tables.COMESTADO
                With NewItem
                    .estado_id = estado_id
                    .descripcion = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMESTADO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal estado_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMESTADO
                With NewItem
                    .estado_id = estado_id
                    .descripcion = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMESTADO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal estado_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.COMESTADO
                With NewItem
                    .estado_id = estado_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMESTADO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    'Partial Public Class COMORDENCOMPRA
    '    Inherits DAL.Tables.COMORDENCOMPRA
    '    Public Overloads Function ItemList() As List(Of Entities.Tables.COMORDENCOMPRA)
    '        Return MyBase.Items
    '    End Function

    '    Public Overloads Function ItemList(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32) As List(Of Entities.Tables.COMORDENCOMPRA)
    '        Try
    '            MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
    '            MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.ordenCompra_id, DAL.SqlEnums.OperandEnum.Equal, ordencompra_id)

    '            Return MyBase.Items
    '        Catch Ex As Exception
    '            Throw Ex
    '        End Try
    '    End Function
    '    Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMORDENCOMPRA) As Entities.Tables.COMORDENCOMPRA
    '        Return MyBase.Add(Item)
    '    End Function

    '    Public Overloads Function AddItem(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal codemprequerimiento As System.String, ByVal requerimiento_id As System.Int32, ByVal fecha As System.DateTime, ByVal proveed_id As System.String, ByVal sectorrequerimiento_id As System.Int32, ByVal estado_id As System.Int32, ByVal tipooc_id As System.Int32, ByVal modificacosto As System.Int32, ByVal condicionpago_id As System.String, ByVal obs As System.String, ByVal usuario As System.String, ByVal usuarioautoriza As System.String, ByVal pdc As System.Decimal, ByVal fechaautorizacion As System.DateTime, ByVal motivofinaliz_anulacion As System.String, ByVal fechafinaliz_anulacion As System.DateTime, ByVal pedidodiario As System.Boolean, ByVal proveed_original As System.String, ByVal sectorentrega_id As System.Int32) As Entities.Tables.COMORDENCOMPRA
    '        Try
    '            Dim NewItem As New Entities.Tables.COMORDENCOMPRA
    '            With NewItem
    '                .CODEMP = codemp
    '                .ORDENCOMPRA_ID = ordencompra_id
    '                .CODEMPREQUERIMIENTO = codemprequerimiento
    '                .REQUERIMIENTO_ID = requerimiento_id
    '                .FECHA = fecha
    '                .PROVEED_ID = proveed_id
    '                .SECTORREQUERIMIENTO_ID = sectorrequerimiento_id
    '                .ESTADO_ID = estado_id
    '                .TIPOOC_ID = tipooc_id
    '                .MODIFICACOSTO = modificacosto
    '                .CONDICIONPAGO_ID = condicionpago_id
    '                .OBS = obs
    '                .USUARIO = usuario
    '                .USUARIOAUTORIZA = usuarioautoriza
    '                .PDC = pdc
    '                .FECHAAUTORIZACION = fechaautorizacion
    '                .MOTIVOFINALIZ_ANULACION = motivofinaliz_anulacion
    '                .FECHAFINALIZ_ANULACION = fechafinaliz_anulacion
    '                .PEDIDODIARIO = pedidodiario
    '                .PROVEED_ORIGINAL = proveed_original
    '                .SECTORENTREGA_ID = sectorentrega_id

    '            End With
    '            MyBase.Add(NewItem)
    '            Return NewItem
    '        Catch Ex As Exception
    '            Throw Ex
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMORDENCOMPRA) As Boolean
    '        Return MyBase.Update(Item)
    '    End Function

    '    Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal codemprequerimiento As System.String, ByVal requerimiento_id As System.Int32, ByVal fecha As System.DateTime, ByVal proveed_id As System.String, ByVal sectorrequerimiento_id As System.Int32, ByVal estado_id As System.Int32, ByVal tipooc_id As System.Int32, ByVal modificacosto As System.Int32, ByVal condicionpago_id As System.String, ByVal obs As System.String, ByVal usuario As System.String, ByVal usuarioautoriza As System.String, ByVal pdc As System.Decimal, ByVal fechaautorizacion As System.DateTime, ByVal motivofinaliz_anulacion As System.String, ByVal fechafinaliz_anulacion As System.DateTime, ByVal pedidodiario As System.Boolean, ByVal proveed_original As System.String, ByVal sectorentrega_id As System.Int32) As Boolean
    '        Try
    '            Dim NewItem As New Entities.Tables.COMORDENCOMPRA
    '            With NewItem
    '                .CODEMP = codemp
    '                .ORDENCOMPRA_ID = ordencompra_id
    '                .CODEMPREQUERIMIENTO = codemprequerimiento
    '                .REQUERIMIENTO_ID = requerimiento_id
    '                .FECHA = fecha
    '                .PROVEED_ID = proveed_id
    '                .SECTORREQUERIMIENTO_ID = sectorrequerimiento_id
    '                .ESTADO_ID = estado_id
    '                .TIPOOC_ID = tipooc_id
    '                .MODIFICACOSTO = modificacosto
    '                .CONDICIONPAGO_ID = condicionpago_id
    '                .OBS = obs
    '                .USUARIO = usuario
    '                .USUARIOAUTORIZA = usuarioautoriza
    '                .PDC = pdc
    '                .FECHAAUTORIZACION = fechaautorizacion
    '                .MOTIVOFINALIZ_ANULACION = motivofinaliz_anulacion
    '                .FECHAFINALIZ_ANULACION = fechafinaliz_anulacion
    '                .PEDIDODIARIO = pedidodiario
    '                .PROVEED_ORIGINAL = proveed_original
    '                .SECTORENTREGA_ID = sectorentrega_id

    '            End With
    '            Return MyBase.Update(NewItem)
    '        Catch Ex As Exception
    '            Throw Ex
    '        End Try
    '    End Function

    '    Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMORDENCOMPRA) As Boolean
    '        Return MyBase.Remove(Item)
    '    End Function

    '    Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32) As Boolean
    '        Try
    '            Dim NewItem As New Entities.Tables.COMORDENCOMPRA
    '            With NewItem
    '                .CODEMP = codemp
    '                .ORDENCOMPRA_ID = ordencompra_id

    '            End With
    '            Return MyBase.Remove(NewItem)
    '        Catch Ex As Exception
    '            Throw (Ex)
    '        End Try
    '    End Function

    '    Public ReadOnly Property Result() As List(Of Entities.Tables.COMORDENCOMPRA)
    '        Get
    '            Return MyBase.Resultset
    '        End Get
    '    End Property

    'End Class '

    Partial Public Class COMORDENCOMPRA
        Inherits DAL.Tables.COMORDENCOMPRA
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMORDENCOMPRA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32) As List(Of Entities.Tables.COMORDENCOMPRA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.ordenCompra_id, DAL.SqlEnums.OperandEnum.Equal, ordencompra_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMORDENCOMPRA) As Entities.Tables.COMORDENCOMPRA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal codemprequerimiento As System.String, ByVal requerimiento_id As System.Int32, ByVal fecha As System.DateTime, ByVal proveed_id As System.String, ByVal sectorrequerimiento_id As System.Int32, ByVal estado_id As System.Int32, ByVal tipooc_id As System.Int32, ByVal modificacosto As System.Int32, ByVal condicionpago_id As System.String, ByVal obs As System.String, ByVal usuario As System.String, ByVal usuarioautoriza As System.String, ByVal pdc As System.Decimal, ByVal fechaautorizacion As System.DateTime, ByVal motivofinaliz_anulacion As System.String, ByVal fechafinaliz_anulacion As System.DateTime, ByVal pedidodiario As System.Boolean, ByVal proveed_original As System.String, ByVal sectorentrega_id As System.Int32, ByVal tipoprorrateo As System.Int16) As Entities.Tables.COMORDENCOMPRA
            Try
                Dim NewItem As New Entities.Tables.COMORDENCOMPRA
                With NewItem
                    .CODEMP = codemp
                    .ORDENCOMPRA_ID = ordencompra_id
                    .CODEMPREQUERIMIENTO = codemprequerimiento
                    .REQUERIMIENTO_ID = requerimiento_id
                    .FECHA = fecha
                    .PROVEED_ID = proveed_id
                    .SECTORREQUERIMIENTO_ID = sectorrequerimiento_id
                    .ESTADO_ID = estado_id
                    .TIPOOC_ID = tipooc_id
                    .MODIFICACOSTO = modificacosto
                    .CONDICIONPAGO_ID = condicionpago_id
                    .OBS = obs
                    .USUARIO = usuario
                    .USUARIOAUTORIZA = usuarioautoriza
                    .PDC = pdc
                    .FECHAAUTORIZACION = fechaautorizacion
                    .MOTIVOFINALIZ_ANULACION = motivofinaliz_anulacion
                    .FECHAFINALIZ_ANULACION = fechafinaliz_anulacion
                    .PEDIDODIARIO = pedidodiario
                    .PROVEED_ORIGINAL = proveed_original
                    .SECTORENTREGA_ID = sectorentrega_id
                    .TIPOPRORRATEO = tipoprorrateo

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMORDENCOMPRA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal codemprequerimiento As System.String, ByVal requerimiento_id As System.Int32, ByVal fecha As System.DateTime, ByVal proveed_id As System.String, ByVal sectorrequerimiento_id As System.Int32, ByVal estado_id As System.Int32, ByVal tipooc_id As System.Int32, ByVal modificacosto As System.Int32, ByVal condicionpago_id As System.String, ByVal obs As System.String, ByVal usuario As System.String, ByVal usuarioautoriza As System.String, ByVal pdc As System.Decimal, ByVal fechaautorizacion As System.DateTime, ByVal motivofinaliz_anulacion As System.String, ByVal fechafinaliz_anulacion As System.DateTime, ByVal pedidodiario As System.Boolean, ByVal proveed_original As System.String, ByVal sectorentrega_id As System.Int32, ByVal tipoprorrateo As System.Int16) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMORDENCOMPRA
                With NewItem
                    .CODEMP = codemp
                    .ORDENCOMPRA_ID = ordencompra_id
                    .CODEMPREQUERIMIENTO = codemprequerimiento
                    .REQUERIMIENTO_ID = requerimiento_id
                    .FECHA = fecha
                    .PROVEED_ID = proveed_id
                    .SECTORREQUERIMIENTO_ID = sectorrequerimiento_id
                    .ESTADO_ID = estado_id
                    .TIPOOC_ID = tipooc_id
                    .MODIFICACOSTO = modificacosto
                    .CONDICIONPAGO_ID = condicionpago_id
                    .OBS = obs
                    .USUARIO = usuario
                    .USUARIOAUTORIZA = usuarioautoriza
                    .PDC = pdc
                    .FECHAAUTORIZACION = fechaautorizacion
                    .MOTIVOFINALIZ_ANULACION = motivofinaliz_anulacion
                    .FECHAFINALIZ_ANULACION = fechafinaliz_anulacion
                    .PEDIDODIARIO = pedidodiario
                    .PROVEED_ORIGINAL = proveed_original
                    .SECTORENTREGA_ID = sectorentrega_id
                    .TIPOPRORRATEO = tipoprorrateo

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMORDENCOMPRA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMORDENCOMPRA
                With NewItem
                    .CODEMP = codemp
                    .ORDENCOMPRA_ID = ordencompra_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMORDENCOMPRA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMORDENCOMPRAITEM
        Inherits DAL.Tables.COMORDENCOMPRAITEM
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMORDENCOMPRAITEM)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32) As List(Of Entities.Tables.COMORDENCOMPRAITEM)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.ordenCompra_id, DAL.SqlEnums.OperandEnum.Equal, ordencompra_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroItem, DAL.SqlEnums.OperandEnum.Equal, nroitem)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMORDENCOMPRAITEM) As Entities.Tables.COMORDENCOMPRAITEM
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32, ByVal articulo_id As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal precio As System.Decimal, ByVal nivelaut_id As System.Int32, ByVal fechaentrega As System.DateTime, ByVal fechaentrega1 As System.DateTime, ByVal cantidad1 As System.Decimal, ByVal embalaje As System.String, ByVal marca As System.String, ByVal codemprequerimiento As System.String, ByVal requerimiento_id As System.Int32, ByVal cantidadoriginal As System.Decimal, ByVal preciooriginal As System.Decimal) As Entities.Tables.COMORDENCOMPRAITEM
            Try
                Dim NewItem As New Entities.Tables.COMORDENCOMPRAITEM
                With NewItem
                    .CODEMP = codemp
                    .ORDENCOMPRA_ID = ordencompra_id
                    .NROITEM = nroitem
                    .ARTICULO_ID = articulo_id
                    .UNIMED = unimed
                    .CANTIDAD = cantidad
                    .PRECIO = precio
                    .NIVELAUT_ID = nivelaut_id
                    .FECHAENTREGA = fechaentrega
                    .FECHAENTREGA1 = fechaentrega1
                    .CANTIDAD1 = cantidad1
                    .EMBALAJE = embalaje
                    .MARCA = marca
                    .CODEMPREQUERIMIENTO = codemprequerimiento
                    .REQUERIMIENTO_ID = requerimiento_id
                    .CANTIDADORIGINAL = cantidadoriginal
                    .PRECIOORIGINAL = preciooriginal


                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMORDENCOMPRAITEM) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32, ByVal articulo_id As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal precio As System.Decimal, ByVal nivelaut_id As System.Int32, ByVal fechaentrega As System.DateTime, ByVal fechaentrega1 As System.DateTime, ByVal cantidad1 As System.Decimal, ByVal embalaje As System.String, ByVal marca As System.String, ByVal codemprequerimiento As System.String, ByVal requerimiento_id As System.Int32, ByVal cantidadoriginal As System.Decimal, ByVal preciooriginal As System.Decimal) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMORDENCOMPRAITEM
                With NewItem
                    .CODEMP = codemp
                    .ORDENCOMPRA_ID = ordencompra_id
                    .NROITEM = nroitem
                    .ARTICULO_ID = articulo_id
                    .UNIMED = unimed
                    .CANTIDAD = cantidad
                    .PRECIO = precio
                    .NIVELAUT_ID = nivelaut_id
                    .FECHAENTREGA = fechaentrega
                    .FECHAENTREGA1 = fechaentrega1
                    .CANTIDAD1 = cantidad1
                    .EMBALAJE = embalaje
                    .MARCA = marca
                    .CODEMPREQUERIMIENTO = codemprequerimiento
                    .REQUERIMIENTO_ID = requerimiento_id
                    .CANTIDADORIGINAL = cantidadoriginal
                    .PRECIOORIGINAL = preciooriginal


                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMORDENCOMPRAITEM) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMORDENCOMPRAITEM
                With NewItem
                    .CODEMP = codemp
                    .ORDENCOMPRA_ID = ordencompra_id
                    .NROITEM = nroitem

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMORDENCOMPRAITEM)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMREQUERIMIENTO
        Inherits DAL.Tables.COMREQUERIMIENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMREQUERIMIENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32) As List(Of Entities.Tables.COMREQUERIMIENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.requerimiento_id, DAL.SqlEnums.OperandEnum.Equal, requerimiento_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMREQUERIMIENTO) As Entities.Tables.COMREQUERIMIENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal fecha As System.DateTime, ByVal sectorrequerimiento_id As System.Int32, ByVal proveed_id As System.String, ByVal estado_id As System.Int32, ByVal obs As System.String, ByVal usuario As System.String, ByVal usuarioautoriza As System.String, ByVal fechaautorizacion As System.DateTime, ByVal motivoanulacion As System.String, ByVal pedidodiario As System.Boolean, ByVal sectorentrega_id As System.Int32) As Entities.Tables.COMREQUERIMIENTO
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTO
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .FECHA = fecha
                    .SECTORREQUERIMIENTO_ID = sectorrequerimiento_id
                    .PROVEED_ID = proveed_id
                    .ESTADO_ID = estado_id
                    .OBS = obs
                    .USUARIO = usuario
                    .USUARIOAUTORIZA = usuarioautoriza
                    .FECHAAUTORIZACION = fechaautorizacion
                    .MOTIVOANULACION = motivoanulacion
                    .PEDIDODIARIO = pedidodiario
                    .SECTORENTREGA_ID = sectorentrega_id

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMREQUERIMIENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal fecha As System.DateTime, ByVal sectorrequerimiento_id As System.Int32, ByVal proveed_id As System.String, ByVal estado_id As System.Int32, ByVal obs As System.String, ByVal usuario As System.String, ByVal usuarioautoriza As System.String, ByVal fechaautorizacion As System.DateTime, ByVal motivoanulacion As System.String, ByVal pedidodiario As System.Boolean, ByVal sectorentrega_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTO
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .FECHA = fecha
                    .SECTORREQUERIMIENTO_ID = sectorrequerimiento_id
                    .PROVEED_ID = proveed_id
                    .ESTADO_ID = estado_id
                    .OBS = obs
                    .USUARIO = usuario
                    .USUARIOAUTORIZA = usuarioautoriza
                    .FECHAAUTORIZACION = fechaautorizacion
                    .MOTIVOANULACION = motivoanulacion
                    .PEDIDODIARIO = pedidodiario
                    .SECTORENTREGA_ID = sectorentrega_id

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMREQUERIMIENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTO
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMREQUERIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '


    Partial Public Class COMREQUERIMIENTOITEM
        Inherits DAL.Tables.COMREQUERIMIENTOITEM
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMREQUERIMIENTOITEM)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32) As List(Of Entities.Tables.COMREQUERIMIENTOITEM)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.requerimiento_id, DAL.SqlEnums.OperandEnum.Equal, requerimiento_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroItem, DAL.SqlEnums.OperandEnum.Equal, nroitem)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOITEM) As Entities.Tables.COMREQUERIMIENTOITEM
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal articulo_id As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal nivelaut_id As System.Int32, ByVal fechaentrega As System.DateTime, ByVal marca As System.String) As Entities.Tables.COMREQUERIMIENTOITEM
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOITEM
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .ARTICULO_ID = articulo_id
                    .UNIMED = unimed
                    .CANTIDAD = cantidad
                    .NIVELAUT_ID = nivelaut_id
                    .FECHAENTREGA = fechaentrega
                    .MARCA = marca

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOITEM) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal articulo_id As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal nivelaut_id As System.Int32, ByVal fechaentrega As System.DateTime, ByVal marca As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOITEM
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .ARTICULO_ID = articulo_id
                    .UNIMED = unimed
                    .CANTIDAD = cantidad
                    .NIVELAUT_ID = nivelaut_id
                    .FECHAENTREGA = fechaentrega
                    .MARCA = marca

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOITEM) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOITEM
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMREQUERIMIENTOITEM)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMREQUERIMIENTOORDENCOMPRA
        Inherits DAL.Tables.COMREQUERIMIENTOORDENCOMPRA
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMREQUERIMIENTOORDENCOMPRA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal codempoc As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitemoc As System.Int32) As List(Of Entities.Tables.COMREQUERIMIENTOORDENCOMPRA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.requerimiento_id, DAL.SqlEnums.OperandEnum.Equal, requerimiento_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroItem, DAL.SqlEnums.OperandEnum.Equal, nroitem)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.codEmpOC, DAL.SqlEnums.OperandEnum.Equal, codempoc)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.ordenCompra_id, DAL.SqlEnums.OperandEnum.Equal, ordencompra_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroItemOC, DAL.SqlEnums.OperandEnum.Equal, nroitemoc)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOORDENCOMPRA) As Entities.Tables.COMREQUERIMIENTOORDENCOMPRA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal codempoc As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitemoc As System.Int32) As Entities.Tables.COMREQUERIMIENTOORDENCOMPRA
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOORDENCOMPRA
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .CODEMPOC = codempoc
                    .ORDENCOMPRA_ID = ordencompra_id
                    .NROITEMOC = nroitemoc

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOORDENCOMPRA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal codempoc As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitemoc As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOORDENCOMPRA
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .CODEMPOC = codempoc
                    .ORDENCOMPRA_ID = ordencompra_id
                    .NROITEMOC = nroitemoc

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOORDENCOMPRA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal codempoc As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitemoc As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOORDENCOMPRA
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .CODEMPOC = codempoc
                    .ORDENCOMPRA_ID = ordencompra_id
                    .NROITEMOC = nroitemoc

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMREQUERIMIENTOORDENCOMPRA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMSECTORREQUERIMIENTO
        Inherits DAL.Tables.COMSECTORREQUERIMIENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMSECTORREQUERIMIENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal sectorrequerimiento_id As System.Int32) As List(Of Entities.Tables.COMSECTORREQUERIMIENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.sectorrequerimiento_id, DAL.SqlEnums.OperandEnum.Equal, sectorrequerimiento_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMSECTORREQUERIMIENTO) As Entities.Tables.COMSECTORREQUERIMIENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal sectorrequerimiento_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.COMSECTORREQUERIMIENTO
            Try
                Dim NewItem As New Entities.Tables.COMSECTORREQUERIMIENTO
                With NewItem
                    .sectorrequerimiento_id = sectorrequerimiento_id
                    .descripcion = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMSECTORREQUERIMIENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal sectorrequerimiento_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMSECTORREQUERIMIENTO
                With NewItem
                    .sectorrequerimiento_id = sectorrequerimiento_id
                    .descripcion = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMSECTORREQUERIMIENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal sectorrequerimiento_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.COMSECTORREQUERIMIENTO
                With NewItem
                    .sectorrequerimiento_id = sectorrequerimiento_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMSECTORREQUERIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '


    Partial Public Class COMTIPOOC
        Inherits DAL.Tables.COMTIPOOC
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMTIPOOC)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal tipooc_id As System.Int32) As List(Of Entities.Tables.COMTIPOOC)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.tipooc_id, DAL.SqlEnums.OperandEnum.Equal, tipooc_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMTIPOOC) As Entities.Tables.COMTIPOOC
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal tipooc_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.COMTIPOOC
            Try
                Dim NewItem As New Entities.Tables.COMTIPOOC
                With NewItem
                    .tipooc_id = tipooc_id
                    .descripcion = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMTIPOOC) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal tipooc_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMTIPOOC
                With NewItem
                    .tipooc_id = tipooc_id
                    .descripcion = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMTIPOOC) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal tipooc_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.COMTIPOOC
                With NewItem
                    .tipooc_id = tipooc_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMTIPOOC)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '


    Partial Public Class STKARTICULOS
        Inherits DAL.Tables.STKARTICULOS
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKARTICULOS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal articulo_id As System.String) As List(Of Entities.Tables.STKARTICULOS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.articulo_id, DAL.SqlEnums.OperandEnum.Equal, articulo_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKARTICULOS) As Entities.Tables.STKARTICULOS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal articulo_id As System.String, ByVal descripcion As System.String, ByVal toleranciaingstock As System.Decimal, ByVal stockminimo As System.Decimal, ByVal stockmaximo As System.Decimal, ByVal vaastock As System.Int32, ByVal unimedppal As System.String, ByVal unimedsec As System.String, ByVal factorconversion As System.Decimal, ByVal codigoim As System.Int32, ByVal mostrarenrequerimiento As System.Boolean, ByVal trazable As System.Boolean, ByVal codigosubcuenta As System.Int32, ByVal llevareceta As System.Boolean, ByVal llevavencimiento As System.Boolean) As Entities.Tables.STKARTICULOS
            Try
                Dim NewItem As New Entities.Tables.STKARTICULOS
                With NewItem
                    .CODEMP = codemp
                    .ARTICULO_ID = articulo_id
                    .DESCRIPCION = descripcion
                    .TOLERANCIAINGSTOCK = toleranciaingstock
                    .STOCKMINIMO = stockminimo
                    .STOCKMAXIMO = stockmaximo
                    .VAASTOCK = vaastock
                    .UNIMEDPPAL = unimedppal
                    .UNIMEDSEC = unimedsec
                    .FACTORCONVERSION = factorconversion
                    .CODIGOIM = codigoim
                    .MOSTRARENREQUERIMIENTO = mostrarenrequerimiento
                    .TRAZABLE = trazable
                    .CODIGOSUBCUENTA = codigosubcuenta
                    .LLEVARECETA = llevareceta
                    .LLEVAVENCIMIENTO = llevavencimiento

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKARTICULOS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal articulo_id As System.String, ByVal descripcion As System.String, ByVal toleranciaingstock As System.Decimal, ByVal stockminimo As System.Decimal, ByVal stockmaximo As System.Decimal, ByVal vaastock As System.Int32, ByVal unimedppal As System.String, ByVal unimedsec As System.String, ByVal factorconversion As System.Decimal, ByVal codigoim As System.Int32, ByVal mostrarenrequerimiento As System.Boolean, ByVal trazable As System.Boolean, ByVal codigosubcuenta As System.Int32, ByVal llevareceta As System.Boolean, ByVal llevavencimiento As System.Boolean) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKARTICULOS
                With NewItem
                    .CODEMP = codemp
                    .ARTICULO_ID = articulo_id
                    .DESCRIPCION = descripcion
                    .TOLERANCIAINGSTOCK = toleranciaingstock
                    .STOCKMINIMO = stockminimo
                    .STOCKMAXIMO = stockmaximo
                    .VAASTOCK = vaastock
                    .UNIMEDPPAL = unimedppal
                    .UNIMEDSEC = unimedsec
                    .FACTORCONVERSION = factorconversion
                    .CODIGOIM = codigoim
                    .MOSTRARENREQUERIMIENTO = mostrarenrequerimiento
                    .TRAZABLE = trazable
                    .CODIGOSUBCUENTA = codigosubcuenta
                    .LLEVARECETA = llevareceta
                    .LLEVAVENCIMIENTO = llevavencimiento

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKARTICULOS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal articulo_id As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKARTICULOS
                With NewItem
                    .CODEMP = codemp
                    .ARTICULO_ID = articulo_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKARTICULOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKDEPOSITO
        Inherits DAL.Tables.STKDEPOSITO
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKDEPOSITO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal deposito_id As System.Int32) As List(Of Entities.Tables.STKDEPOSITO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codemp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.deposito_id, DAL.SqlEnums.OperandEnum.Equal, deposito_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKDEPOSITO) As Entities.Tables.STKDEPOSITO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal deposito_id As System.Int32, ByVal descripcion As System.String, ByVal stocknegativo As System.Int32) As Entities.Tables.STKDEPOSITO
            Try
                Dim NewItem As New Entities.Tables.STKDEPOSITO
                With NewItem
                    .codemp = codemp
                    .deposito_id = deposito_id
                    .descripcion = descripcion
                    .stocknegativo = stocknegativo

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKDEPOSITO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal deposito_id As System.Int32, ByVal descripcion As System.String, ByVal stocknegativo As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKDEPOSITO
                With NewItem
                    .codemp = codemp
                    .deposito_id = deposito_id
                    .descripcion = descripcion
                    .stocknegativo = stocknegativo

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKDEPOSITO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal deposito_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.STKDEPOSITO
                With NewItem
                    .codemp = codemp
                    .deposito_id = deposito_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKDEPOSITO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKENTRANSITO
        Inherits DAL.Tables.STKENTRANSITO
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKENTRANSITO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal comprobante As System.Int32, ByVal nroitem As System.Int32) As List(Of Entities.Tables.STKENTRANSITO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.comprobante, DAL.SqlEnums.OperandEnum.Equal, comprobante)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroItem, DAL.SqlEnums.OperandEnum.Equal, nroitem)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKENTRANSITO) As Entities.Tables.STKENTRANSITO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal comprobante As System.Int32, ByVal nroitem As System.Int32, ByVal cantoriginal As System.Decimal, ByVal cantrecibida As System.Decimal, ByVal unimed As System.String, ByVal estado_id As System.Int32, ByVal usuariogenera As System.String, ByVal usuariorecibe As System.String, ByVal fecharecepcion As System.DateTime) As Entities.Tables.STKENTRANSITO
            Try
                Dim NewItem As New Entities.Tables.STKENTRANSITO
                With NewItem
                    .CODEMP = codemp
                    .COMPROBANTE = comprobante
                    .NROITEM = nroitem
                    .CANTORIGINAL = cantoriginal
                    .CANTRECIBIDA = cantrecibida
                    .UNIMED = unimed
                    .ESTADO_ID = estado_id
                    .USUARIOGENERA = usuariogenera
                    .USUARIORECIBE = usuariorecibe
                    .FECHARECEPCION = fecharecepcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKENTRANSITO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal comprobante As System.Int32, ByVal nroitem As System.Int32, ByVal cantoriginal As System.Decimal, ByVal cantrecibida As System.Decimal, ByVal unimed As System.String, ByVal estado_id As System.Int32, ByVal usuariogenera As System.String, ByVal usuariorecibe As System.String, ByVal fecharecepcion As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKENTRANSITO
                With NewItem
                    .CODEMP = codemp
                    .COMPROBANTE = comprobante
                    .NROITEM = nroitem
                    .CANTORIGINAL = cantoriginal
                    .CANTRECIBIDA = cantrecibida
                    .UNIMED = unimed
                    .ESTADO_ID = estado_id
                    .USUARIOGENERA = usuariogenera
                    .USUARIORECIBE = usuariorecibe
                    .FECHARECEPCION = fecharecepcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKENTRANSITO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal comprobante As System.Int32, ByVal nroitem As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKENTRANSITO
                With NewItem
                    .CODEMP = codemp
                    .COMPROBANTE = comprobante
                    .NROITEM = nroitem

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKENTRANSITO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '


    Partial Public Class STKINVENTARIO
        Inherits DAL.Tables.STKINVENTARIO
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKINVENTARIO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal articulo_id As System.String, ByVal deposito_id As System.Int32) As List(Of Entities.Tables.STKINVENTARIO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.articulo_id, DAL.SqlEnums.OperandEnum.Equal, articulo_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.deposito_id, DAL.SqlEnums.OperandEnum.Equal, deposito_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKINVENTARIO) As Entities.Tables.STKINVENTARIO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal articulo_id As System.String, ByVal deposito_id As System.Int32, ByVal sector_id As System.Int32, ByVal unimed As System.String, ByVal cantidad As System.Decimal) As Entities.Tables.STKINVENTARIO
            Try
                Dim NewItem As New Entities.Tables.STKINVENTARIO
                With NewItem
                    .ARTICULO_ID = articulo_id
                    .DEPOSITO_ID = deposito_id
                    .SECTOR_ID = sector_id
                    .UNIMED = unimed
                    .CANTIDAD = cantidad

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKINVENTARIO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal articulo_id As System.String, ByVal deposito_id As System.Int32, ByVal sector_id As System.Int32, ByVal unimed As System.String, ByVal cantidad As System.Decimal) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKINVENTARIO
                With NewItem
                    .ARTICULO_ID = articulo_id
                    .DEPOSITO_ID = deposito_id
                    .SECTOR_ID = sector_id
                    .UNIMED = unimed
                    .CANTIDAD = cantidad

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKINVENTARIO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal articulo_id As System.String, ByVal deposito_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKINVENTARIO
                With NewItem
                    .ARTICULO_ID = articulo_id
                    .DEPOSITO_ID = deposito_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKINVENTARIO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKMOVIMIENTO
        Inherits DAL.Tables.STKMOVIMIENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKMOVIMIENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal comprobante As System.Int32) As List(Of Entities.Tables.STKMOVIMIENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.comprobante, DAL.SqlEnums.OperandEnum.Equal, comprobante)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKMOVIMIENTO) As Entities.Tables.STKMOVIMIENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal comprobante As System.Int32, ByVal tipomov_id As System.Int32, ByVal subtipomov_id As System.Int32, ByVal fechamov As System.DateTime, ByVal depositoorigen_id As System.Int32, ByVal sectororigen_id As System.Int32, ByVal depositodestino_id As System.Int32, ByVal sectordestino_id As System.Int32, ByVal usuario As System.String, ByVal anulado As System.Int32, ByVal obs As System.String) As Entities.Tables.STKMOVIMIENTO
            Try
                Dim NewItem As New Entities.Tables.STKMOVIMIENTO
                With NewItem
                    .CODEMP = codemp
                    .COMPROBANTE = comprobante
                    .TIPOMOV_ID = tipomov_id
                    .SUBTIPOMOV_ID = subtipomov_id
                    .FECHAMOV = fechamov
                    .DEPOSITOORIGEN_ID = depositoorigen_id
                    .SECTORORIGEN_ID = sectororigen_id
                    .DEPOSITODESTINO_ID = depositodestino_id
                    .SECTORDESTINO_ID = sectordestino_id
                    .USUARIO = usuario
                    .ANULADO = anulado
                    .OBS = obs

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKMOVIMIENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal comprobante As System.Int32, ByVal tipomov_id As System.Int32, ByVal subtipomov_id As System.Int32, ByVal fechamov As System.DateTime, ByVal depositoorigen_id As System.Int32, ByVal sectororigen_id As System.Int32, ByVal depositodestino_id As System.Int32, ByVal sectordestino_id As System.Int32, ByVal usuario As System.String, ByVal anulado As System.Int32, ByVal obs As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKMOVIMIENTO
                With NewItem
                    .CODEMP = codemp
                    .COMPROBANTE = comprobante
                    .TIPOMOV_ID = tipomov_id
                    .SUBTIPOMOV_ID = subtipomov_id
                    .FECHAMOV = fechamov
                    .DEPOSITOORIGEN_ID = depositoorigen_id
                    .SECTORORIGEN_ID = sectororigen_id
                    .DEPOSITODESTINO_ID = depositodestino_id
                    .SECTORDESTINO_ID = sectordestino_id
                    .USUARIO = usuario
                    .ANULADO = anulado
                    .OBS = obs

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKMOVIMIENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal comprobante As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKMOVIMIENTO
                With NewItem
                    .CODEMP = codemp
                    .COMPROBANTE = comprobante

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKMOVIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '


    Partial Public Class STKMOVIMIENTOITEM
        Inherits DAL.Tables.STKMOVIMIENTOITEM
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKMOVIMIENTOITEM)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal comprobante As System.Int32, ByVal nroitem As System.Int32) As List(Of Entities.Tables.STKMOVIMIENTOITEM)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.comprobante, DAL.SqlEnums.OperandEnum.Equal, comprobante)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroItem, DAL.SqlEnums.OperandEnum.Equal, nroitem)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKMOVIMIENTOITEM) As Entities.Tables.STKMOVIMIENTOITEM
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal comprobante As System.Int32, ByVal nroitem As System.Int32, ByVal articulo_id As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal costouni As System.Decimal) As Entities.Tables.STKMOVIMIENTOITEM
            Try
                Dim NewItem As New Entities.Tables.STKMOVIMIENTOITEM
                With NewItem
                    .CODEMP = codemp
                    .COMPROBANTE = comprobante
                    .NROITEM = nroitem
                    .ARTICULO_ID = articulo_id
                    .UNIMED = unimed
                    .CANTIDAD = cantidad
                    .COSTOUNI = costouni

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKMOVIMIENTOITEM) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal comprobante As System.Int32, ByVal nroitem As System.Int32, ByVal articulo_id As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal costouni As System.Decimal) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKMOVIMIENTOITEM
                With NewItem
                    .CODEMP = codemp
                    .COMPROBANTE = comprobante
                    .NROITEM = nroitem
                    .ARTICULO_ID = articulo_id
                    .UNIMED = unimed
                    .CANTIDAD = cantidad
                    .COSTOUNI = costouni

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKMOVIMIENTOITEM) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal comprobante As System.Int32, ByVal nroitem As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKMOVIMIENTOITEM
                With NewItem
                    .CODEMP = codemp
                    .COMPROBANTE = comprobante
                    .NROITEM = nroitem

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKMOVIMIENTOITEM)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKMOVIOC
        Inherits DAL.Tables.STKMOVIOC
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKMOVIOC)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codempstk As System.String, ByVal comprobantestk As System.Int32, ByVal nroitemstk As System.Int32, ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32) As List(Of Entities.Tables.STKMOVIOC)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codempstk, DAL.SqlEnums.OperandEnum.Equal, codempstk)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.comprobantestk, DAL.SqlEnums.OperandEnum.Equal, comprobantestk)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroitemstk, DAL.SqlEnums.OperandEnum.Equal, nroitemstk)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.codemp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.ordencompra_id, DAL.SqlEnums.OperandEnum.Equal, ordencompra_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroitem, DAL.SqlEnums.OperandEnum.Equal, nroitem)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKMOVIOC) As Entities.Tables.STKMOVIOC
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codempstk As System.String, ByVal comprobantestk As System.Int32, ByVal nroitemstk As System.Int32, ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32, ByVal unimed As System.String, ByVal cantoriginal As System.Decimal, ByVal cantingresada As System.Decimal, ByVal remSucursal As System.String, ByVal remComprobante As System.Int32) As Entities.Tables.STKMOVIOC
            Try
                Dim NewItem As New Entities.Tables.STKMOVIOC
                With NewItem
                    .CODEMPSTK = codempstk
                    .COMPROBANTESTK = comprobantestk
                    .NROITEMSTK = nroitemstk
                    .CODEMP = codemp
                    .ORDENCOMPRA_ID = ordencompra_id
                    .NROITEM = nroitem
                    .UNIMED = unimed
                    .CANTORIGINAL = cantoriginal
                    .CANTINGRESADA = cantingresada
                    .RemSucursal = remComprobante
                    .RemComprobante = remComprobante

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKMOVIOC) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codempstk As System.String, ByVal comprobantestk As System.Int32, ByVal nroitemstk As System.Int32, ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32, ByVal unimed As System.String, ByVal cantoriginal As System.Decimal, ByVal cantingresada As System.Decimal) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKMOVIOC
                With NewItem
                    .codempstk = codempstk
                    .comprobantestk = comprobantestk
                    .nroitemstk = nroitemstk
                    .codemp = codemp
                    .ordencompra_id = ordencompra_id
                    .nroitem = nroitem
                    .unimed = unimed
                    .cantoriginal = cantoriginal
                    .cantingresada = cantingresada

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKMOVIOC) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codempstk As System.String, ByVal comprobantestk As System.Int32, ByVal nroitemstk As System.Int32, ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.STKMOVIOC
                With NewItem
                    .codempstk = codempstk
                    .comprobantestk = comprobantestk
                    .nroitemstk = nroitemstk
                    .codemp = codemp
                    .ordencompra_id = ordencompra_id
                    .nroitem = nroitem

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKMOVIOC)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

  
    Partial Public Class STKREMITO
        Inherits DAL.Tables.STKREMITO
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKREMITO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal sucursal As System.String, ByVal comprobante As System.Int32, ByVal letra As System.String) As List(Of Entities.Tables.STKREMITO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codemp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.sucursal, DAL.SqlEnums.OperandEnum.Equal, sucursal)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.comprobante, DAL.SqlEnums.OperandEnum.Equal, comprobante)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.letra, DAL.SqlEnums.OperandEnum.Equal, letra)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKREMITO) As Entities.Tables.STKREMITO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal sucursal As System.String, ByVal comprobante As System.Int32, ByVal letra As System.String, ByVal fecha As System.DateTime, ByVal codempstk As System.String, ByVal comprobantestk As System.Int32) As Entities.Tables.STKREMITO
            Try
                Dim NewItem As New Entities.Tables.STKREMITO
                With NewItem
                    .codemp = codemp
                    .sucursal = sucursal
                    .comprobante = comprobante
                    .letra = letra
                    .fecha = fecha
                    .codempstk = codempstk
                    .comprobantestk = comprobantestk

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKREMITO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal sucursal As System.String, ByVal comprobante As System.Int32, ByVal letra As System.String, ByVal fecha As System.DateTime, ByVal codempstk As System.String, ByVal comprobantestk As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKREMITO
                With NewItem
                    .codemp = codemp
                    .sucursal = sucursal
                    .comprobante = comprobante
                    .letra = letra
                    .fecha = fecha
                    .codempstk = codempstk
                    .comprobantestk = comprobantestk

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKREMITO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal sucursal As System.String, ByVal comprobante As System.Int32, ByVal letra As System.String) As Boolean
            Try
                Dim NewItem As New Entities.tables.STKREMITO
                With NewItem
                    .codemp = codemp
                    .sucursal = sucursal
                    .comprobante = comprobante
                    .letra = letra

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKREMITO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKSECTOR
        Inherits DAL.Tables.STKSECTOR
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKSECTOR)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal deposito_id As System.Int32) As List(Of Entities.Tables.STKSECTOR)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.deposito_id, DAL.SqlEnums.OperandEnum.Equal, deposito_id)
                'MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.sector_id, DAL.SqlEnums.OperandEnum.Equal, sector_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKSECTOR) As Entities.Tables.STKSECTOR
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal deposito_id As System.Int32, ByVal sector_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.STKSECTOR
            Try
                Dim NewItem As New Entities.Tables.STKSECTOR
                With NewItem
                    .codemp = codemp
                    .deposito_id = deposito_id
                    .sector_id = sector_id
                    .descripcion = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKSECTOR) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal deposito_id As System.Int32, ByVal sector_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKSECTOR
                With NewItem
                    .codemp = codemp
                    .deposito_id = deposito_id
                    .sector_id = sector_id
                    .descripcion = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKSECTOR) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal deposito_id As System.Int32, ByVal sector_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.STKSECTOR
                With NewItem
                    .codemp = codemp
                    .deposito_id = deposito_id
                    .sector_id = sector_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKSECTOR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKSUBTIPOMOV
        Inherits DAL.Tables.STKSUBTIPOMOV
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKSUBTIPOMOV)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal subtipomov_id As System.Int32) As List(Of Entities.Tables.STKSUBTIPOMOV)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.subtipomov_id, DAL.SqlEnums.OperandEnum.Equal, subtipomov_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKSUBTIPOMOV) As Entities.Tables.STKSUBTIPOMOV
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal subtipomov_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.STKSUBTIPOMOV
            Try
                Dim NewItem As New Entities.Tables.STKSUBTIPOMOV
                With NewItem
                    .subtipomov_id = subtipomov_id
                    .descripcion = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKSUBTIPOMOV) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal subtipomov_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKSUBTIPOMOV
                With NewItem
                    .subtipomov_id = subtipomov_id
                    .descripcion = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKSUBTIPOMOV) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal subtipomov_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.STKSUBTIPOMOV
                With NewItem
                    .subtipomov_id = subtipomov_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKSUBTIPOMOV)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKTIPOMOV
        Inherits DAL.Tables.STKTIPOMOV
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKTIPOMOV)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal tipomov_id As System.Int32) As List(Of Entities.Tables.STKTIPOMOV)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.tipomov_id, DAL.SqlEnums.OperandEnum.Equal, tipomov_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKTIPOMOV) As Entities.Tables.STKTIPOMOV
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal tipomov_id As System.Int32, ByVal descripcion As System.String, ByVal signo As System.Int32) As Entities.Tables.STKTIPOMOV
            Try
                Dim NewItem As New Entities.Tables.STKTIPOMOV
                With NewItem
                    .tipomov_id = tipomov_id
                    .descripcion = descripcion
                    .signo = signo

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKTIPOMOV) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal tipomov_id As System.Int32, ByVal descripcion As System.String, ByVal signo As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKTIPOMOV
                With NewItem
                    .tipomov_id = tipomov_id
                    .descripcion = descripcion
                    .signo = signo

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKTIPOMOV) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal tipomov_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.STKTIPOMOV
                With NewItem
                    .tipomov_id = tipomov_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKTIPOMOV)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKCIERRESTOCK
        Inherits DAL.Tables.STKCIERRESTOCK
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKCIERRESTOCK)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal anio As System.Int32, ByVal mes As System.Int32) As List(Of Entities.Tables.STKCIERRESTOCK)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Anio, DAL.SqlEnums.OperandEnum.Equal, anio)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.Mes, DAL.SqlEnums.OperandEnum.Equal, mes)
                'MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.Mes, DAL.SqlEnums.OperandEnum.Equal, mes)
                'MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.articulo_id, DAL.SqlEnums.OperandEnum.Equal, articulo_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKCIERRESTOCK) As Entities.Tables.STKCIERRESTOCK
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal anio As System.Int32, ByVal mes As System.Int32, ByVal articulo_id As System.String, ByVal unimed As System.String, ByVal stockreal As System.Decimal, ByVal cantreponer As System.Decimal, ByVal fechamov As System.DateTime) As Entities.Tables.STKCIERRESTOCK
            Try
                Dim NewItem As New Entities.Tables.STKCIERRESTOCK
                With NewItem
                    .codemp = codemp
                    .anio = anio
                    .mes = mes
                    .articulo_id = articulo_id
                    .unimed = unimed
                    .stockreal = stockreal
                    .cantreponer = cantreponer
                    .fechamov = fechamov

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKCIERRESTOCK) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal anio As System.Int32, ByVal mes As System.Int32, ByVal articulo_id As System.String, ByVal unimed As System.String, ByVal stockreal As System.Decimal, ByVal cantreponer As System.Decimal, ByVal fechamov As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKCIERRESTOCK
                With NewItem
                    .codemp = codemp
                    .anio = anio
                    .mes = mes
                    .articulo_id = articulo_id
                    .unimed = unimed
                    .stockreal = stockreal
                    .cantreponer = cantreponer
                    .fechamov = fechamov

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKCIERRESTOCK) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal anio As System.Int32, ByVal mes As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKCIERRESTOCK
                With NewItem
                    .ANIO = anio
                    .MES = mes

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKCIERRESTOCK)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TESFACTURAPROVEED
        Inherits DAL.Tables.TESFACTURAPROVEED
        Public Overloads Function ItemList() As List(Of Entities.Tables.TESFACTURAPROVEED)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal sucfactura As System.String, ByVal comprobante As System.Int32, ByVal tipo As System.Int32, ByVal pro_cod As System.String) As List(Of Entities.Tables.TESFACTURAPROVEED)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codemp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.sucfactura, DAL.SqlEnums.OperandEnum.Equal, sucfactura)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.comprobante, DAL.SqlEnums.OperandEnum.Equal, comprobante)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.tipo, DAL.SqlEnums.OperandEnum.Equal, tipo)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.pro_cod, DAL.SqlEnums.OperandEnum.Equal, pro_cod)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.TESFACTURAPROVEED) As Entities.Tables.TESFACTURAPROVEED
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal sucfactura As System.String, ByVal comprobante As System.Int32, ByVal tipo As System.Int32, ByVal pro_cod As System.String, ByVal fechafact As System.DateTime, ByVal importe As System.Decimal, ByVal codigobarra As System.String, ByVal fechalectura As System.DateTime, ByVal usuario As System.String) As Entities.Tables.TESFACTURAPROVEED
            Try
                Dim NewItem As New Entities.Tables.TESFACTURAPROVEED
                With NewItem
                    .codemp = codemp
                    .sucfactura = sucfactura
                    .comprobante = comprobante
                    .tipo = tipo
                    .pro_cod = pro_cod
                    .fechafact = fechafact
                    .importe = importe
                    .codigobarra = codigobarra
                    .fechalectura = fechalectura
                    .usuario = usuario

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TESFACTURAPROVEED) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal sucfactura As System.String, ByVal comprobante As System.Int32, ByVal tipo As System.Int32, ByVal pro_cod As System.String, ByVal fechafact As System.DateTime, ByVal importe As System.Decimal, ByVal codigobarra As System.String, ByVal fechalectura As System.DateTime, ByVal usuario As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TESFACTURAPROVEED
                With NewItem
                    .codemp = codemp
                    .sucfactura = sucfactura
                    .comprobante = comprobante
                    .tipo = tipo
                    .pro_cod = pro_cod
                    .fechafact = fechafact
                    .importe = importe
                    .codigobarra = codigobarra
                    .fechalectura = fechalectura
                    .usuario = usuario

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TESFACTURAPROVEED) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal sucfactura As System.String, ByVal comprobante As System.Int32, ByVal tipo As System.Int32, ByVal pro_cod As System.String) As Boolean
            Try
                Dim NewItem As New Entities.tables.TESFACTURAPROVEED
                With NewItem
                    .codemp = codemp
                    .sucfactura = sucfactura
                    .comprobante = comprobante
                    .tipo = tipo
                    .pro_cod = pro_cod

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.TESFACTURAPROVEED)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMREQUERIMIENTOBIONEXO
        Inherits DAL.Tables.COMREQUERIMIENTOBIONEXO
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMREQUERIMIENTOBIONEXO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal nrosolicitud As System.Int32) As List(Of Entities.Tables.COMREQUERIMIENTOBIONEXO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codemp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.requerimiento_id, DAL.SqlEnums.OperandEnum.Equal, requerimiento_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroitem, DAL.SqlEnums.OperandEnum.Equal, nroitem)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nrosolicitud, DAL.SqlEnums.OperandEnum.Equal, nrosolicitud)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOBIONEXO) As Entities.Tables.COMREQUERIMIENTOBIONEXO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal nrosolicitud As System.Int32, ByVal cantidad As System.Decimal, ByVal fecha As System.DateTime) As Entities.Tables.COMREQUERIMIENTOBIONEXO
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOBIONEXO
                With NewItem
                    .codemp = codemp
                    .requerimiento_id = requerimiento_id
                    .nroitem = nroitem
                    .nrosolicitud = nrosolicitud
                    .cantidad = cantidad
                    .fecha = fecha

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOBIONEXO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal nrosolicitud As System.Int32, ByVal cantidad As System.Decimal, ByVal fecha As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOBIONEXO
                With NewItem
                    .codemp = codemp
                    .requerimiento_id = requerimiento_id
                    .nroitem = nroitem
                    .nrosolicitud = nrosolicitud
                    .cantidad = cantidad
                    .fecha = fecha

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOBIONEXO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal nrosolicitud As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.tables.COMREQUERIMIENTOBIONEXO
                With NewItem
                    .codemp = codemp
                    .requerimiento_id = requerimiento_id
                    .nroitem = nroitem
                    .nrosolicitud = nrosolicitud

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMREQUERIMIENTOBIONEXO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TESFACTURASRECIBIDAS
        Inherits DAL.Tables.TESFACTURASRECIBIDAS
        Public Overloads Function ItemList() As List(Of Entities.Tables.TESFACTURASRECIBIDAS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal letra As System.String, ByVal puntodeventa As System.String, ByVal numerocomprobante As System.String, ByVal codigoproveed As System.String) As List(Of Entities.Tables.TESFACTURASRECIBIDAS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codemp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.letra, DAL.SqlEnums.OperandEnum.Equal, letra)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.puntodeventa, DAL.SqlEnums.OperandEnum.Equal, puntodeventa)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.numerocomprobante, DAL.SqlEnums.OperandEnum.Equal, numerocomprobante)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.codigoproveed, DAL.SqlEnums.OperandEnum.Equal, codigoproveed)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.TESFACTURASRECIBIDAS) As Entities.Tables.TESFACTURASRECIBIDAS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal letra As System.String, ByVal puntodeventa As System.String, ByVal numerocomprobante As System.String, ByVal codigoproveed As System.String, ByVal fecharecepcion As System.DateTime, ByVal fechacontable As System.DateTime, ByVal razonsocial As System.String, ByVal importe As System.Double, ByVal usuariorecibe As System.Int32) As Entities.Tables.TESFACTURASRECIBIDAS
            Try
                Dim NewItem As New Entities.Tables.TESFACTURASRECIBIDAS
                With NewItem
                    .codemp = codemp
                    .letra = letra
                    .puntodeventa = puntodeventa
                    .numerocomprobante = numerocomprobante
                    .codigoproveed = codigoproveed
                    .fecharecepcion = fecharecepcion
                    .fechacontable = fechacontable
                    .razonsocial = razonsocial
                    .importe = importe
                    .usuariorecibe = usuariorecibe

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TESFACTURASRECIBIDAS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal letra As System.String, ByVal puntodeventa As System.String, ByVal numerocomprobante As System.String, ByVal codigoproveed As System.String, ByVal fecharecepcion As System.DateTime, ByVal fechacontable As System.DateTime, ByVal razonsocial As System.String, ByVal importe As System.Double, ByVal usuariorecibe As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TESFACTURASRECIBIDAS
                With NewItem
                    .codemp = codemp
                    .letra = letra
                    .puntodeventa = puntodeventa
                    .numerocomprobante = numerocomprobante
                    .codigoproveed = codigoproveed
                    .fecharecepcion = fecharecepcion
                    .fechacontable = fechacontable
                    .razonsocial = razonsocial
                    .importe = importe
                    .usuariorecibe = usuariorecibe

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TESFACTURASRECIBIDAS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal letra As System.String, ByVal puntodeventa As System.String, ByVal numerocomprobante As System.String, ByVal codigoproveed As System.String) As Boolean
            Try
                Dim NewItem As New Entities.tables.TESFACTURASRECIBIDAS
                With NewItem
                    .codemp = codemp
                    .letra = letra
                    .puntodeventa = puntodeventa
                    .numerocomprobante = numerocomprobante
                    .codigoproveed = codigoproveed

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.TESFACTURASRECIBIDAS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class USUARIOXSUBRUBRO
        Inherits DAL.Tables.USUARIOXSUBRUBRO
        Public Overloads Function ItemList() As List(Of Entities.Tables.USUARIOXSUBRUBRO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_usuario As System.Int32, ByVal artda2_cod As System.String) As List(Of Entities.Tables.USUARIOXSUBRUBRO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.id_usuario, DAL.SqlEnums.OperandEnum.Equal, id_usuario)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.artda2_cod, DAL.SqlEnums.OperandEnum.Equal, artda2_cod)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.USUARIOXSUBRUBRO) As Entities.Tables.USUARIOXSUBRUBRO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_usuario As System.Int32, ByVal artda2_cod As System.String) As Entities.Tables.USUARIOXSUBRUBRO
            Try
                Dim NewItem As New Entities.Tables.USUARIOXSUBRUBRO
                With NewItem
                    .id_usuario = id_usuario
                    .artda2_cod = artda2_cod

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.USUARIOXSUBRUBRO) As Boolean
            Return MyBase.Update(Item)
        End Function
    End Class

    Partial Public Class STKARTICULOMARCA
        Inherits DAL.Tables.STKARTICULOMARCA
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKARTICULOMARCA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal articulo_id As System.String) As List(Of Entities.Tables.STKARTICULOMARCA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.articulo_id, DAL.SqlEnums.OperandEnum.Equal, articulo_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKARTICULOMARCA) As Entities.Tables.STKARTICULOMARCA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal articulo_id As System.String, ByVal marca1 As System.String, ByVal marca2 As System.String, ByVal marca3 As System.String, ByVal marca4 As System.String, ByVal marca5 As System.String) As Entities.Tables.STKARTICULOMARCA
            Try
                Dim NewItem As New Entities.Tables.STKARTICULOMARCA
                With NewItem
                    .CODEMP = codemp
                    .ARTICULO_ID = articulo_id
                    .MARCA1 = marca1
                    .MARCA2 = marca2
                    .MARCA3 = marca3
                    .MARCA4 = marca4
                    .MARCA5 = marca5

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKARTICULOMARCA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal articulo_id As System.String, ByVal marca1 As System.String, ByVal marca2 As System.String, ByVal marca3 As System.String, ByVal marca4 As System.String, ByVal marca5 As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKARTICULOMARCA
                With NewItem
                    .CODEMP = codemp
                    .ARTICULO_ID = articulo_id
                    .MARCA1 = marca1
                    .MARCA2 = marca2
                    .MARCA3 = marca3
                    .MARCA4 = marca4
                    .MARCA5 = marca5

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKARTICULOMARCA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal articulo_id As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKARTICULOMARCA
                With NewItem
                    .CODEMP = codemp
                    .ARTICULO_ID = articulo_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKARTICULOMARCA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMPEDIDOCOTIZACIONPROVEEDDIRECTO
        Inherits DAL.Tables.COMPEDIDOCOTIZACIONPROVEEDDIRECTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMPEDIDOCOTIZACIONPROVEEDDIRECTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal nrocotizacion As System.Int32) As List(Of Entities.Tables.COMPEDIDOCOTIZACIONPROVEEDDIRECTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.NroCotizacion, DAL.SqlEnums.OperandEnum.Equal, nrocotizacion)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMPEDIDOCOTIZACIONPROVEEDDIRECTO) As Entities.Tables.COMPEDIDOCOTIZACIONPROVEEDDIRECTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal nrocotizacion As System.Int32, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal articulo_id As System.String, ByVal proveed_id As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal fecha As System.DateTime, ByVal usuario As System.String, ByVal obs As System.String) As Entities.Tables.COMPEDIDOCOTIZACIONPROVEEDDIRECTO
            Try
                Dim NewItem As New Entities.Tables.COMPEDIDOCOTIZACIONPROVEEDDIRECTO
                With NewItem
                    .CODEMP = codemp
                    .NROCOTIZACION = nrocotizacion
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .ARTICULO_ID = articulo_id
                    .PROVEED_ID = proveed_id
                    .UNIMED = unimed
                    .CANTIDAD = cantidad
                    .FECHA = fecha
                    .USUARIO = usuario
                    .OBS = obs

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMPEDIDOCOTIZACIONPROVEEDDIRECTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal nrocotizacion As System.Int32, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal articulo_id As System.String, ByVal proveed_id As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal fecha As System.DateTime, ByVal usuario As System.String, ByVal obs As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMPEDIDOCOTIZACIONPROVEEDDIRECTO
                With NewItem
                    .CODEMP = codemp
                    .NROCOTIZACION = nrocotizacion
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .ARTICULO_ID = articulo_id
                    .PROVEED_ID = proveed_id
                    .UNIMED = unimed
                    .CANTIDAD = cantidad
                    .FECHA = fecha
                    .USUARIO = usuario
                    .OBS = obs

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMPEDIDOCOTIZACIONPROVEEDDIRECTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal nrocotizacion As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMPEDIDOCOTIZACIONPROVEEDDIRECTO
                With NewItem
                    .CODEMP = codemp
                    .NROCOTIZACION = nrocotizacion

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMPEDIDOCOTIZACIONPROVEEDDIRECTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STK_RECLAMODEMERCADERIA
        Inherits DAL.Tables.STK_RECLAMODEMERCADERIA
        Public Overloads Function ItemList() As List(Of Entities.Tables.STK_RECLAMODEMERCADERIA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id As System.Int32) As List(Of Entities.Tables.STK_RECLAMODEMERCADERIA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.id, DAL.SqlEnums.OperandEnum.Equal, id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STK_RECLAMODEMERCADERIA) As Entities.Tables.STK_RECLAMODEMERCADERIA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id As System.Int32, ByVal plantillaid As System.Int32, ByVal sector_id As System.Int32, ByVal deposito_id As System.Int32, ByVal numfactura As System.Int32, ByVal numremito As System.Int32, ByVal articulo_id As System.String, ByVal cantidadfaltante As System.Decimal, ByVal cantidadrecibidademas As System.Decimal, ByVal cantidadrecibidaporerror As System.Decimal, ByVal anotacion As System.String, ByVal usuario_id As System.Int32, ByVal fecha As System.DateTime) As Entities.Tables.STK_RECLAMODEMERCADERIA
            Try
                Dim NewItem As New Entities.Tables.STK_RECLAMODEMERCADERIA
                With NewItem
                    .id = id
                    .plantillaid = plantillaid
                    .sector_id = sector_id
                    .deposito_id = deposito_id
                    .numfactura = numfactura
                    .numremito = numremito
                    .articulo_id = articulo_id
                    .cantidadfaltante = cantidadfaltante
                    .cantidadrecibidademas = cantidadrecibidademas
                    .cantidadrecibidaporerror = cantidadrecibidaporerror
                    .anotacion = anotacion
                    .usuario_id = usuario_id
                    .fecha = fecha

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STK_RECLAMODEMERCADERIA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id As System.Int32, ByVal plantillaid As System.Int32, ByVal sector_id As System.Int32, ByVal deposito_id As System.Int32, ByVal numfactura As System.Int32, ByVal numremito As System.Int32, ByVal articulo_id As System.String, ByVal cantidadfaltante As System.Decimal, ByVal cantidadrecibidademas As System.Decimal, ByVal cantidadrecibidaporerror As System.Decimal, ByVal anotacion As System.String, ByVal usuario_id As System.Int32, ByVal fecha As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STK_RECLAMODEMERCADERIA
                With NewItem
                    .id = id
                    .plantillaid = plantillaid
                    .sector_id = sector_id
                    .deposito_id = deposito_id
                    .numfactura = numfactura
                    .numremito = numremito
                    .articulo_id = articulo_id
                    .cantidadfaltante = cantidadfaltante
                    .cantidadrecibidademas = cantidadrecibidademas
                    .cantidadrecibidaporerror = cantidadrecibidaporerror
                    .anotacion = anotacion
                    .usuario_id = usuario_id
                    .fecha = fecha

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STK_RECLAMODEMERCADERIA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STK_RECLAMODEMERCADERIA
                With NewItem
                    .id = id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STK_RECLAMODEMERCADERIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMARTICULOSPROVISORIOS
        Inherits DAL.Tables.COMARTICULOSPROVISORIOS
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMARTICULOSPROVISORIOS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id As System.Int32) As List(Of Entities.Tables.COMARTICULOSPROVISORIOS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id, DAL.SqlEnums.OperandEnum.Equal, id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMARTICULOSPROVISORIOS) As Entities.Tables.COMARTICULOSPROVISORIOS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id As System.Int32, ByVal codprovisorio As System.Int32, ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal pendienteenbejerman As System.Int32, ByVal descripcion As System.String, ByVal presentacion As System.String, ByVal unimed As System.String, ByVal marca As System.String, ByVal embalaje As System.String, ByVal cantidad As System.Decimal, ByVal usuario_id As System.Int32, ByVal usuario_mail As System.String, ByVal sub_rubro As System.String) As Entities.Tables.COMARTICULOSPROVISORIOS
            Try
                Dim NewItem As New Entities.Tables.COMARTICULOSPROVISORIOS
                With NewItem
                    .ID = id
                    .CODPROVISORIO = codprovisorio
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .PENDIENTEENBEJERMAN = pendienteenbejerman
                    .DESCRIPCION = descripcion
                    .PRESENTACION = presentacion
                    .UNIMED = unimed
                    .MARCA = marca
                    .EMBALAJE = embalaje
                    .CANTIDAD = cantidad
                    .USUARIO_ID = usuario_id
                    .USUARIO_MAIL = usuario_mail
                    .SUB_RUBRO = sub_rubro

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMARTICULOSPROVISORIOS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id As System.Int32, ByVal codprovisorio As System.Int32, ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal pendienteenbejerman As System.Int32, ByVal descripcion As System.String, ByVal presentacion As System.String, ByVal unimed As System.String, ByVal marca As System.String, ByVal embalaje As System.String, ByVal cantidad As System.Decimal, ByVal usuario_id As System.Int32, ByVal usuario_mail As System.String, ByVal sub_rubro As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMARTICULOSPROVISORIOS
                With NewItem
                    .ID = id
                    .CODPROVISORIO = codprovisorio
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .PENDIENTEENBEJERMAN = pendienteenbejerman
                    .DESCRIPCION = descripcion
                    .PRESENTACION = presentacion
                    .UNIMED = unimed
                    .MARCA = marca
                    .EMBALAJE = embalaje
                    .CANTIDAD = cantidad
                    .USUARIO_ID = usuario_id
                    .USUARIO_MAIL = usuario_mail
                    .SUB_RUBRO = sub_rubro

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMARTICULOSPROVISORIOS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMARTICULOSPROVISORIOS
                With NewItem
                    .ID = id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMARTICULOSPROVISORIOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMEQUIVALENCIAARTICULOSPROVEED
        Inherits DAL.Tables.COMEQUIVALENCIAARTICULOSPROVEED
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal articulo_id As System.String, ByVal proveed_id As System.String) As List(Of Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.articulo_id, DAL.SqlEnums.OperandEnum.Equal, articulo_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.proveed_id, DAL.SqlEnums.OperandEnum.Equal, proveed_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED) As Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal articulo_id As System.String, ByVal proveed_id As System.String, ByVal articulo_proveed As System.String, ByVal descrip_articulo_proveed As System.String) As Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED
            Try
                Dim NewItem As New Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED
                With NewItem
                    .ARTICULO_ID = articulo_id
                    .PROVEED_ID = proveed_id
                    .ARTICULO_PROVEED = articulo_proveed
                    .DESCRIP_ARTICULO_PROVEED = descrip_articulo_proveed

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal articulo_id As System.String, ByVal proveed_id As System.String, ByVal articulo_proveed As System.String, ByVal descrip_articulo_proveed As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED
                With NewItem
                    .ARTICULO_ID = articulo_id
                    .PROVEED_ID = proveed_id
                    .ARTICULO_PROVEED = articulo_proveed
                    .DESCRIP_ARTICULO_PROVEED = descrip_articulo_proveed

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal articulo_id As System.String, ByVal proveed_id As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED
                With NewItem
                    .ARTICULO_ID = articulo_id
                    .PROVEED_ID = proveed_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMUSUARIOAUTORIZAREQUERIMIENTOS
        Inherits DAL.Tables.COMUSUARIOAUTORIZAREQUERIMIENTOS
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMUSUARIOAUTORIZAREQUERIMIENTOS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_usuario As System.Int32, ByVal sectorrequerimiento As System.Int32) As List(Of Entities.Tables.COMUSUARIOAUTORIZAREQUERIMIENTOS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id_Usuario, DAL.SqlEnums.OperandEnum.Equal, id_usuario)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.sectorRequerimiento, DAL.SqlEnums.OperandEnum.Equal, sectorrequerimiento)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function


    End Class '

    Partial Public Class COMCUENTAUSUARIO
        Inherits DAL.Tables.COMCUENTAUSUARIO
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMCUENTAUSUARIO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_usuario As System.Int32, ByVal agr_codigo As System.String, ByVal com_valor As System.String, ByVal cta_nrocta As System.Int32) As List(Of Entities.Tables.COMCUENTAUSUARIO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id_Usuario, DAL.SqlEnums.OperandEnum.Equal, id_usuario)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.agr_codigo, DAL.SqlEnums.OperandEnum.Equal, agr_codigo)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.com_valor, DAL.SqlEnums.OperandEnum.Equal, com_valor)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.cta_nrocta, DAL.SqlEnums.OperandEnum.Equal, cta_nrocta)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMCUENTAUSUARIO) As Entities.Tables.COMCUENTAUSUARIO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_usuario As System.Int32, ByVal agr_codigo As System.String, ByVal com_valor As System.String, ByVal cta_nrocta As System.Int32) As Entities.Tables.COMCUENTAUSUARIO
            Try
                Dim NewItem As New Entities.Tables.COMCUENTAUSUARIO
                With NewItem
                    .ID_USUARIO = id_usuario
                    .AGR_CODIGO = agr_codigo
                    .COM_VALOR = com_valor
                    .CTA_NROCTA = cta_nrocta

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMCUENTAUSUARIO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id_usuario As System.Int32, ByVal agr_codigo As System.String, ByVal com_valor As System.String, ByVal cta_nrocta As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMCUENTAUSUARIO
                With NewItem
                    .ID_USUARIO = id_usuario
                    .AGR_CODIGO = agr_codigo
                    .COM_VALOR = com_valor
                    .CTA_NROCTA = cta_nrocta

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMCUENTAUSUARIO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id_usuario As System.Int32, ByVal agr_codigo As System.String, ByVal com_valor As System.String, ByVal cta_nrocta As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMCUENTAUSUARIO
                With NewItem
                    .ID_USUARIO = id_usuario
                    .AGR_CODIGO = agr_codigo
                    .COM_VALOR = com_valor
                    .CTA_NROCTA = cta_nrocta

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMCUENTAUSUARIO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMLUGARENTREGA
        Inherits DAL.Tables.COMLUGARENTREGA
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMLUGARENTREGA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal lugar_id As System.Int32, ByVal codemp As System.String) As List(Of Entities.Tables.COMLUGARENTREGA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.lugar_id, DAL.SqlEnums.OperandEnum.Equal, lugar_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMLUGARENTREGA) As Entities.Tables.COMLUGARENTREGA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal lugar_id As System.Int32, ByVal codemp As System.String, ByVal descripcion As System.String, ByVal inactivo As System.Boolean, ByVal obs As System.String) As Entities.Tables.COMLUGARENTREGA
            Try
                Dim NewItem As New Entities.Tables.COMLUGARENTREGA
                With NewItem
                    .LUGAR_ID = lugar_id
                    .CODEMP = codemp
                    .DESCRIPCION = descripcion
                    .INACTIVO = inactivo
                    .OBS = obs

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMLUGARENTREGA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal lugar_id As System.Int32, ByVal codemp As System.String, ByVal descripcion As System.String, ByVal inactivo As System.Boolean, ByVal obs As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMLUGARENTREGA
                With NewItem
                    .LUGAR_ID = lugar_id
                    .CODEMP = codemp
                    .DESCRIPCION = descripcion
                    .INACTIVO = inactivo
                    .OBS = obs

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMLUGARENTREGA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal lugar_id As System.Int32, ByVal codemp As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMLUGARENTREGA
                With NewItem
                    .LUGAR_ID = lugar_id
                    .CODEMP = codemp

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMLUGARENTREGA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class EVENTOUSUARIO
        Inherits DAL.Tables.EVENTOUSUARIO
        Public Overloads Function ItemList() As List(Of Entities.Tables.EVENTOUSUARIO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_usuario As System.Int32, ByVal evento_id As System.Int32) As List(Of Entities.Tables.EVENTOUSUARIO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id_Usuario, DAL.SqlEnums.OperandEnum.Equal, id_usuario)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.Evento_id, DAL.SqlEnums.OperandEnum.Equal, evento_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.EVENTOUSUARIO) As Entities.Tables.EVENTOUSUARIO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_usuario As System.Int32, ByVal evento_id As System.Int32, ByVal fecha As System.DateTime) As Entities.Tables.EVENTOUSUARIO
            Try
                Dim NewItem As New Entities.Tables.EVENTOUSUARIO
                With NewItem
                    .ID_USUARIO = id_usuario
                    .EVENTO_ID = evento_id
                    .FECHA = fecha

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.EVENTOUSUARIO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id_usuario As System.Int32, ByVal evento_id As System.Int32, ByVal fecha As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EVENTOUSUARIO
                With NewItem
                    .ID_USUARIO = id_usuario
                    .EVENTO_ID = evento_id
                    .FECHA = fecha

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.EVENTOUSUARIO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id_usuario As System.Int32, ByVal evento_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EVENTOUSUARIO
                With NewItem
                    .ID_USUARIO = id_usuario
                    .EVENTO_ID = evento_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.EVENTOUSUARIO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class USR_ARTICULOSUBCUENTA
        Inherits DAL.Tables.USR_ARTICULOSUBCUENTA
        Public Overloads Function ItemList() As List(Of Entities.Tables.USR_ARTICULOSUBCUENTA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal subcuenta As System.Int32) As List(Of Entities.Tables.USR_ARTICULOSUBCUENTA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.subCuenta, DAL.SqlEnums.OperandEnum.Equal, subcuenta)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.USR_ARTICULOSUBCUENTA) As Entities.Tables.USR_ARTICULOSUBCUENTA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal subcuenta As System.Int32, ByVal descripcion As System.String) As Entities.Tables.USR_ARTICULOSUBCUENTA
            Try
                Dim NewItem As New Entities.Tables.USR_ARTICULOSUBCUENTA
                With NewItem
                    .SUBCUENTA = subcuenta
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.USR_ARTICULOSUBCUENTA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal subcuenta As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.USR_ARTICULOSUBCUENTA
                With NewItem
                    .SUBCUENTA = subcuenta
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.USR_ARTICULOSUBCUENTA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal subcuenta As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.USR_ARTICULOSUBCUENTA
                With NewItem
                    .SUBCUENTA = subcuenta

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.USR_ARTICULOSUBCUENTA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMREQUERIMIENTOINTERNO
        Inherits DAL.Tables.COMREQUERIMIENTOINTERNO
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMREQUERIMIENTOINTERNO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32) As List(Of Entities.Tables.COMREQUERIMIENTOINTERNO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.requerimiento_id, DAL.SqlEnums.OperandEnum.Equal, requerimiento_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOINTERNO) As Entities.Tables.COMREQUERIMIENTOINTERNO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal fecha As System.DateTime, ByVal sectorrequerimiento_id As System.Int32, ByVal estado_id As System.Int32, ByVal obs As System.String, ByVal usuario As System.String, ByVal usuarioautoriza As System.String, ByVal fechaautorizacion As System.DateTime, ByVal motivoanulacion As System.String, ByVal pedidodiario As System.Boolean, ByVal sectorentrega_id As System.Int32, ByVal fechafinalizacion As System.DateTime, ByVal motivofinalizacion As System.String, ByVal usuariofinaliza As System.String, ByVal depositoorigen_id As System.Int32, ByVal sectordepositoorigen_id As System.Int32, ByVal depositodestino_id As System.Int32, ByVal sectordepositodestino_id As System.Int32) As Entities.Tables.COMREQUERIMIENTOINTERNO
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOINTERNO
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .FECHA = fecha
                    .SECTORREQUERIMIENTO_ID = sectorrequerimiento_id
                    .ESTADO_ID = estado_id
                    .OBS = obs
                    .USUARIO = usuario
                    .USUARIOAUTORIZA = usuarioautoriza
                    .FECHAAUTORIZACION = fechaautorizacion
                    .MOTIVOANULACION = motivoanulacion
                    .PEDIDODIARIO = pedidodiario
                    .SECTORENTREGA_ID = sectorentrega_id
                    .FECHAFINALIZACION = fechafinalizacion
                    .MOTIVOFINALIZACION = motivofinalizacion
                    .USUARIOFINALIZA = usuariofinaliza
                    .DEPOSITOORIGEN_ID = depositoorigen_id
                    .SECTORDEPOSITOORIGEN_ID = sectordepositoorigen_id
                    .DEPOSITODESTINO_ID = depositodestino_id
                    .SECTORDEPOSITODESTINO_ID = sectordepositodestino_id

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOINTERNO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal fecha As System.DateTime, ByVal sectorrequerimiento_id As System.Int32, ByVal estado_id As System.Int32, ByVal obs As System.String, ByVal usuario As System.String, ByVal usuarioautoriza As System.String, ByVal fechaautorizacion As System.DateTime, ByVal motivoanulacion As System.String, ByVal pedidodiario As System.Boolean, ByVal sectorentrega_id As System.Int32, ByVal fechafinalizacion As System.DateTime, ByVal motivofinalizacion As System.String, ByVal usuariofinaliza As System.String, ByVal depositoorigen_id As System.Int32, ByVal sectordepositoorigen_id As System.Int32, ByVal depositodestino_id As System.Int32, ByVal sectordepositodestino_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOINTERNO
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .FECHA = fecha
                    .SECTORREQUERIMIENTO_ID = sectorrequerimiento_id
                    .ESTADO_ID = estado_id
                    .OBS = obs
                    .USUARIO = usuario
                    .USUARIOAUTORIZA = usuarioautoriza
                    .FECHAAUTORIZACION = fechaautorizacion
                    .MOTIVOANULACION = motivoanulacion
                    .PEDIDODIARIO = pedidodiario
                    .SECTORENTREGA_ID = sectorentrega_id
                    .FECHAFINALIZACION = fechafinalizacion
                    .MOTIVOFINALIZACION = motivofinalizacion
                    .USUARIOFINALIZA = usuariofinaliza
                    .DEPOSITOORIGEN_ID = depositoorigen_id
                    .SECTORDEPOSITOORIGEN_ID = sectordepositoorigen_id
                    .DEPOSITODESTINO_ID = depositodestino_id
                    .SECTORDEPOSITODESTINO_ID = sectordepositodestino_id

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOINTERNO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOINTERNO
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMREQUERIMIENTOINTERNO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMREQUERIMIENTOINTERNOITEM
        Inherits DAL.Tables.COMREQUERIMIENTOINTERNOITEM
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMREQUERIMIENTOINTERNOITEM)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32) As List(Of Entities.Tables.COMREQUERIMIENTOINTERNOITEM)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.requerimiento_id, DAL.SqlEnums.OperandEnum.Equal, requerimiento_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroItem, DAL.SqlEnums.OperandEnum.Equal, nroitem)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOINTERNOITEM) As Entities.Tables.COMREQUERIMIENTOINTERNOITEM
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal articulo_id As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal nivelaut_id As System.Int32, ByVal fechaentrega As System.DateTime, ByVal marca As System.String, ByVal excluido As System.Int32, ByVal motivoexclusion As System.String, ByVal usuarioexcluye As System.String) As Entities.Tables.COMREQUERIMIENTOINTERNOITEM
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOINTERNOITEM
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .ARTICULO_ID = articulo_id
                    .UNIMED = unimed
                    .CANTIDAD = cantidad
                    .NIVELAUT_ID = nivelaut_id
                    .FECHAENTREGA = fechaentrega
                    .MARCA = marca
                    .EXCLUIDO = excluido
                    .MOTIVOEXCLUSION = motivoexclusion
                    .USUARIOEXCLUYE = usuarioexcluye

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOINTERNOITEM) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal articulo_id As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal nivelaut_id As System.Int32, ByVal fechaentrega As System.DateTime, ByVal marca As System.String, ByVal excluido As System.Int32, ByVal motivoexclusion As System.String, ByVal usuarioexcluye As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOINTERNOITEM
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .ARTICULO_ID = articulo_id
                    .UNIMED = unimed
                    .CANTIDAD = cantidad
                    .NIVELAUT_ID = nivelaut_id
                    .FECHAENTREGA = fechaentrega
                    .MARCA = marca
                    .EXCLUIDO = excluido
                    .MOTIVOEXCLUSION = motivoexclusion
                    .USUARIOEXCLUYE = usuarioexcluye

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMREQUERIMIENTOINTERNOITEM) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMREQUERIMIENTOINTERNOITEM
                With NewItem
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMREQUERIMIENTOINTERNOITEM)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKVENCIMIENTO
        Inherits DAL.Tables.STKVENCIMIENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKVENCIMIENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id As System.Int32) As List(Of Entities.Tables.STKVENCIMIENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id, DAL.SqlEnums.OperandEnum.Equal, id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKVENCIMIENTO) As Entities.Tables.STKVENCIMIENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id As System.Int32, ByVal codemp As System.String, ByVal comprobante As System.Int32, ByVal articulo_id As System.String, ByVal cantidad As System.Decimal, ByVal enstock As System.Decimal, ByVal vto As System.DateTime) As Entities.Tables.STKVENCIMIENTO
            Try
                Dim NewItem As New Entities.Tables.STKVENCIMIENTO
                With NewItem
                    .ID = id
                    .CODEMP = codemp
                    .COMPROBANTE = comprobante
                    .ARTICULO_ID = articulo_id
                    .CANTIDAD = cantidad
                    .ENSTOCK = enstock
                    .VTO = vto

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKVENCIMIENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id As System.Int32, ByVal codemp As System.String, ByVal comprobante As System.Int32, ByVal articulo_id As System.String, ByVal cantidad As System.Decimal, ByVal enstock As System.Decimal, ByVal vto As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKVENCIMIENTO
                With NewItem
                    .ID = id
                    .CODEMP = codemp
                    .COMPROBANTE = comprobante
                    .ARTICULO_ID = articulo_id
                    .CANTIDAD = cantidad
                    .ENSTOCK = enstock
                    .VTO = vto

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKVENCIMIENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKVENCIMIENTO
                With NewItem
                    .ID = id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKVENCIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMORDENCOMPRADETALLE
        Inherits DAL.Tables.COMORDENCOMPRADETALLE
        Public Overloads Function ItemList() As List(Of Entities.Tables.COMORDENCOMPRADETALLE)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32) As List(Of Entities.Tables.COMORDENCOMPRADETALLE)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.ordenCompra_id, DAL.SqlEnums.OperandEnum.Equal, ordencompra_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroItem, DAL.SqlEnums.OperandEnum.Equal, nroitem)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.COMORDENCOMPRADETALLE) As Entities.Tables.COMORDENCOMPRADETALLE
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32, ByVal nivelauto_id As System.Int32, ByVal importe As System.Double, ByVal detalle As System.String, ByVal cantidad As System.Decimal) As Entities.Tables.COMORDENCOMPRADETALLE
            Try
                Dim NewItem As New Entities.Tables.COMORDENCOMPRADETALLE
                With NewItem
                    .CODEMP = codemp
                    .ORDENCOMPRA_ID = ordencompra_id
                    .NROITEM = nroitem
                    .NIVELAUTO_ID = nivelauto_id
                    .IMPORTE = importe
                    .DETALLE = detalle
                    .CANTIDAD = cantidad

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.COMORDENCOMPRADETALLE) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32, ByVal nivelauto_id As System.Int32, ByVal importe As System.Double, ByVal detalle As System.String, ByVal cantidad As System.Decimal) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMORDENCOMPRADETALLE
                With NewItem
                    .CODEMP = codemp
                    .ORDENCOMPRA_ID = ordencompra_id
                    .NROITEM = nroitem
                    .NIVELAUTO_ID = nivelauto_id
                    .IMPORTE = importe
                    .DETALLE = detalle
                    .CANTIDAD = cantidad

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.COMORDENCOMPRADETALLE) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.COMORDENCOMPRADETALLE
                With NewItem
                    .CODEMP = codemp
                    .ORDENCOMPRA_ID = ordencompra_id
                    .NROITEM = nroitem

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.COMORDENCOMPRADETALLE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKMOVIREQINTERNO
        Inherits DAL.Tables.STKMOVIREQINTERNO
        Public Overloads Function ItemList() As List(Of Entities.Tables.STKMOVIREQINTERNO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codempstk As System.String, ByVal comprobantestk As System.Int32, ByVal nroitemstk As System.Int32, ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32) As List(Of Entities.Tables.STKMOVIREQINTERNO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmpStk, DAL.SqlEnums.OperandEnum.Equal, codempstk)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.comprobanteStk, DAL.SqlEnums.OperandEnum.Equal, comprobantestk)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroItemStk, DAL.SqlEnums.OperandEnum.Equal, nroitemstk)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.requerimiento_id, DAL.SqlEnums.OperandEnum.Equal, requerimiento_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroItem, DAL.SqlEnums.OperandEnum.Equal, nroitem)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STKMOVIREQINTERNO) As Entities.Tables.STKMOVIREQINTERNO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codempstk As System.String, ByVal comprobantestk As System.Int32, ByVal nroitemstk As System.Int32, ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal unimed As System.String, ByVal cantenviada As System.Decimal, ByVal remsucursal As System.String, ByVal remcomprobante As System.Int32) As Entities.Tables.STKMOVIREQINTERNO
            Try
                Dim NewItem As New Entities.Tables.STKMOVIREQINTERNO
                With NewItem
                    .CODEMPSTK = codempstk
                    .COMPROBANTESTK = comprobantestk
                    .NROITEMSTK = nroitemstk
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .UNIMED = unimed
                    .CANTENVIADA = cantenviada
                    .REMSUCURSAL = remsucursal
                    .REMCOMPROBANTE = remcomprobante

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STKMOVIREQINTERNO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codempstk As System.String, ByVal comprobantestk As System.Int32, ByVal nroitemstk As System.Int32, ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal unimed As System.String, ByVal cantenviada As System.Decimal, ByVal remsucursal As System.String, ByVal remcomprobante As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKMOVIREQINTERNO
                With NewItem
                    .CODEMPSTK = codempstk
                    .COMPROBANTESTK = comprobantestk
                    .NROITEMSTK = nroitemstk
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem
                    .UNIMED = unimed
                    .CANTENVIADA = cantenviada
                    .REMSUCURSAL = remsucursal
                    .REMCOMPROBANTE = remcomprobante

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STKMOVIREQINTERNO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codempstk As System.String, ByVal comprobantestk As System.Int32, ByVal nroitemstk As System.Int32, ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STKMOVIREQINTERNO
                With NewItem
                    .CODEMPSTK = codempstk
                    .COMPROBANTESTK = comprobantestk
                    .NROITEMSTK = nroitemstk
                    .CODEMP = codemp
                    .REQUERIMIENTO_ID = requerimiento_id
                    .NROITEM = nroitem

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKMOVIREQINTERNO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
End Namespace 'Tables

 ' - Classes derivadas de Tablas y sus Foreign Keys

Namespace Joins


    
    Partial Public Class TBL_PERFILESPERMISOS
         Inherits DAL.Joins.TBL_PERFILESPERMISOS
        Public Function ItemList() As List(Of Entities.Joins.TBL_PERFILESPERMISOS)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.TBL_PERFILESPERMISOS)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.TBL_PERFILESPERMISOS)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.TBL_PERFILESPERMISOS)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.TBL_PERFILESPERMISOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TBL_USUARIOS
         Inherits DAL.Joins.TBL_USUARIOS
        Public Function ItemList() As List(Of Entities.Joins.TBL_USUARIOS)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.TBL_USUARIOS)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.TBL_USUARIOS)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.TBL_USUARIOS)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.TBL_USUARIOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMORDENCOMPRA
        Inherits DAL.Joins.COMORDENCOMPRA
        Public Function ItemList() As List(Of Entities.Joins.COMORDENCOMPRA)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.COMORDENCOMPRA)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.COMORDENCOMPRA)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.COMORDENCOMPRA)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.COMORDENCOMPRA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '


    Partial Public Class COMORDENCOMPRAITEM
        Inherits DAL.Joins.COMORDENCOMPRAITEM
        Public Function ItemList() As List(Of Entities.Joins.COMORDENCOMPRAITEM)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.COMORDENCOMPRAITEM)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.COMORDENCOMPRAITEM)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.COMORDENCOMPRAITEM)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.COMORDENCOMPRAITEM)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMREQUERIMIENTO
        Inherits DAL.Joins.COMREQUERIMIENTO
        Public Function ItemList() As List(Of Entities.Joins.COMREQUERIMIENTO)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.COMREQUERIMIENTO)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.COMREQUERIMIENTO)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.COMREQUERIMIENTO)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.COMREQUERIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMREQUERIMIENTOITEM
        Inherits DAL.Joins.COMREQUERIMIENTOITEM
        Public Function ItemList() As List(Of Entities.Joins.COMREQUERIMIENTOITEM)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.COMREQUERIMIENTOITEM)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.COMREQUERIMIENTOITEM)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.COMREQUERIMIENTOITEM)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.COMREQUERIMIENTOITEM)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKENTRANSITO
        Inherits DAL.Joins.STKENTRANSITO
        Public Function ItemList() As List(Of Entities.Joins.STKENTRANSITO)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.STKENTRANSITO)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.STKENTRANSITO)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.STKENTRANSITO)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.STKENTRANSITO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

 
    Partial Public Class STKINVENTARIO
        Inherits DAL.Joins.STKINVENTARIO
        Public Function ItemList() As List(Of Entities.Joins.STKINVENTARIO)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.STKINVENTARIO)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.STKINVENTARIO)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.STKINVENTARIO)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.STKINVENTARIO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

 
    Partial Public Class STKMOVIMIENTO
        Inherits DAL.Joins.STKMOVIMIENTO
        Public Function ItemList() As List(Of Entities.Joins.STKMOVIMIENTO)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.STKMOVIMIENTO)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.STKMOVIMIENTO)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.STKMOVIMIENTO)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.STKMOVIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

 
    Partial Public Class STKMOVIMIENTOITEM
        Inherits DAL.Joins.STKMOVIMIENTOITEM
        Public Function ItemList() As List(Of Entities.Joins.STKMOVIMIENTOITEM)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.STKMOVIMIENTOITEM)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.STKMOVIMIENTOITEM)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.STKMOVIMIENTOITEM)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.STKMOVIMIENTOITEM)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '


    Partial Public Class STKMOVIOC
        Inherits DAL.Joins.STKMOVIOC
        Public Function ItemList() As List(Of Entities.Joins.STKMOVIOC)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.STKMOVIOC)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.STKMOVIOC)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.STKMOVIOC)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.STKMOVIOC)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKREMITO
        Inherits DAL.Joins.STKREMITO
        Public Function ItemList() As List(Of Entities.Joins.STKREMITO)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.STKREMITO)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.STKREMITO)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.STKREMITO)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.STKREMITO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKSECTOR
        Inherits DAL.Tables.STKSECTOR
        Public Function ItemList() As List(Of Entities.Tables.STKSECTOR)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Tables.STKSECTOR)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Tables.STKSECTOR)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Tables.STKSECTOR)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STKSECTOR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMREQUERIMIENTOBIONEXO
        Inherits DAL.Joins.COMREQUERIMIENTOBIONEXO
        Public Function ItemList() As List(Of Entities.Joins.COMREQUERIMIENTOBIONEXO)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.COMREQUERIMIENTOBIONEXO)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.COMREQUERIMIENTOBIONEXO)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.COMREQUERIMIENTOBIONEXO)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.COMREQUERIMIENTOBIONEXO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMCUENTAUSUARIO
        Inherits DAL.Joins.COMCUENTAUSUARIO
        Public Function ItemList() As List(Of Entities.Joins.COMCUENTAUSUARIO)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.COMCUENTAUSUARIO)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.COMCUENTAUSUARIO)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.COMCUENTAUSUARIO)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.COMCUENTAUSUARIO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
End Namespace 'Joins

Namespace Procedures
 ' - Clases derivadas de Stored Procedures - 

End Namespace 'Procedures

Namespace Views
 ' - Classes derivadas de Vistas - 

End Namespace 'Views
