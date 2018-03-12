Imports System.Linq


Namespace Tables

    'creo una clase del tipo COMREQUERIMIENTO
    Partial Public Class COMREQUERIMIENTO
        Inherits DAL.Tables.COMREQUERIMIENTO
        Public Overloads Function AddItem(ByVal ItemCab As Entities.Tables.COMREQUERIMIENTO, ByVal Items As List(Of Entities.Tables.COMREQUERIMIENTOITEM), ByVal codEmp As String, ByVal ItemsProvisorios As List(Of Entities.Tables.COMARTICULOSPROVISORIOS), Optional ByRef NroReqGenerado As Integer = 0) As Boolean
            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.MAXCOMPROBANTEREQUERIMIENTO

            If _prox.Items(codEmp).Count > 0 Then
                _proximoID = _prox.Resultset(0).requerimiento_id + 1
            Else
                _proximoID = 1
            End If

            Dim NewComReq As New DAL.Tables.COMREQUERIMIENTO
            Dim ItemReq As New Entities.Tables.COMREQUERIMIENTOITEM

            Try
                'ESTABLEZCO LA TRANSACCION
                NewComReq.BeginTransaction()

                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                ItemCab.CODEMP = codEmp
                ItemCab.REQUERIMIENTO_ID = _proximoID

                NewComReq.Add(ItemCab)

                'SOLO GUARDO ITEMS DE ARTICULOS QUE EXISTEN EN BEJERMAN, SI LA COLECCION TIENE DATOS
                Dim i As Integer
                i = 1
                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewComReqItem As New DAL.Tables.COMREQUERIMIENTOITEM(NewComReq)

                If Items.Count > 0 Then

                    For Each _itemcuerpo As Entities.Tables.COMREQUERIMIENTOITEM In Items
                        ItemReq = New Entities.Tables.COMREQUERIMIENTOITEM()
                        ItemReq.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                        ItemReq.CANTIDAD = _itemcuerpo.CANTIDAD
                        ItemReq.CODEMP = codEmp
                        ItemReq.FECHAENTREGA = _itemcuerpo.FECHAENTREGA
                        ItemReq.NIVELAUT_ID = _itemcuerpo.NIVELAUT_ID
                        ItemReq.NROITEM = i
                        ItemReq.REQUERIMIENTO_ID = _proximoID
                        ItemReq.UNIMED = _itemcuerpo.UNIMED
                        ItemReq.MARCA = _itemcuerpo.MARCA
                        NewComReqItem.Add(ItemReq)

                        i = i + 1
                    Next

                End If
                'AHORA VERIFICO SI TIENE ARTICULOS PROVISORIOS
                If ItemsProvisorios.Count > 0 Then
                    Dim _proximoIDProvisorio As Integer
                    Dim _proxProvisorio As New DAL.Procedures.PROXIMOCODPROVISORIO
                    _proxProvisorio.Items()
                    _proximoIDProvisorio = _proxProvisorio.Resultset(0).codprovisorio

                    'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION TABLA ARTICULOS PROVISORIOS
                    Dim NewItemProvisorio As New DAL.Tables.COMARTICULOSPROVISORIOS(NewComReq)
                    Dim ItemReqProvis As New Entities.Tables.COMARTICULOSPROVISORIOS

                    ' ***************INSERTO EN DOS TABLAS : COMREQUERIMIENTOSITEM Y COMARTICULOSPROVISORIOS *****************************
                    For Each _itemcuerpo As Entities.Tables.COMARTICULOSPROVISORIOS In ItemsProvisorios
                        ItemReq = New Entities.Tables.COMREQUERIMIENTOITEM()
                        'OBJETOS DE COMREQUERIMIENTOITEM
                        ItemReq.ARTICULO_ID = "0" 'ENVIO UN CERO EN ARTICULO PORQUE ES PROVISORIO
                        ItemReq.CANTIDAD = _itemcuerpo.CANTIDAD
                        ItemReq.CODEMP = codEmp
                        ItemReq.FECHAENTREGA = DateTime.Now.ToShortDateString()
                        ItemReq.NIVELAUT_ID = 1
                        ItemReq.NROITEM = i ' ESO LA MISMA VARIABLE QUE EL FOR DE ARRIBA.. PARA CONTINUAR CON EL NRO DE ITEM, DE LO CONTRARIO EMPIEZA DE 1..
                        ItemReq.REQUERIMIENTO_ID = _proximoID
                        ItemReq.UNIMED = _itemcuerpo.UNIMED

                        NewComReqItem.Add(ItemReq)

                        ItemReqProvis = New Entities.Tables.COMARTICULOSPROVISORIOS
                        'OBJETOS DE COMARTICULOSPROVISORIOS
                        ItemReqProvis.CANTIDAD = _itemcuerpo.CANTIDAD
                        ItemReqProvis.CODEMP = codEmp
                        ItemReqProvis.CODPROVISORIO = _proximoIDProvisorio
                        ItemReqProvis.DESCRIPCION = _itemcuerpo.DESCRIPCION
                        ItemReqProvis.EMBALAJE = _itemcuerpo.EMBALAJE
                        ItemReqProvis.MARCA = _itemcuerpo.MARCA
                        ItemReqProvis.NROITEM = i
                        ItemReqProvis.PENDIENTEENBEJERMAN = 1 'SIGNIFICA QUE ESTA PENDIENTE DE CREACION EN BEJERMAN
                        ItemReqProvis.PRESENTACION = _itemcuerpo.PRESENTACION
                        ItemReqProvis.REQUERIMIENTO_ID = _proximoID
                        ItemReqProvis.UNIMED = _itemcuerpo.UNIMED
                        ItemReqProvis.USUARIO_ID = _itemcuerpo.USUARIO_ID
                        ItemReqProvis.SUB_RUBRO = _itemcuerpo.SUB_RUBRO

                        NewItemProvisorio.Add(ItemReqProvis)


                        i = i + 1
                    Next


                End If
                NroReqGenerado = _proximoID 'DEVUELVO EN ESTA VARIABLE EL NRO DE REQUERIMIENTO QUE SE GENERO

                'HAGO EL COMMIT
                NewComReq.EndTransaction(True)
                Return True


            Catch ex As Exception
                'POR CUALQUIER ERROR HAGO EL ROLLBACK
                NewComReq.EndTransaction(False)
                Return False
            End Try

        End Function

        Public Function AutorizaRequerimiento(ByVal Items As List(Of Entities.Tables.COMREQUERIMIENTOITEM), ByVal ItemCab As Entities.Tables.COMREQUERIMIENTO)
            Dim NewComReq As New DAL.Procedures.ACTUALIZA_USUARIO_AUTORIZA
            Dim ItemReq As New Entities.Tables.COMREQUERIMIENTOITEM
            Try

                'ESTABLEZCO LA TRANSACCION
                NewComReq.BeginTransaction()
                'ACTUALIZO EL USUARIO QUE AUTORIZA
                NewComReq.Items("RE", ItemCab.CODEMP, ItemCab.REQUERIMIENTO_ID, ItemCab.USUARIOAUTORIZA, ItemCab.PEDIDODIARIO)

                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewComReqItem As New DAL.Tables.COMREQUERIMIENTOITEM(NewComReq)

                For Each _itemcuerpo As Entities.Tables.COMREQUERIMIENTOITEM In Items
                    ItemReq = New Entities.Tables.COMREQUERIMIENTOITEM()
                    ItemReq.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    ItemReq.CANTIDAD = _itemcuerpo.CANTIDAD
                    ItemReq.CODEMP = _itemcuerpo.CODEMP
                    ItemReq.REQUERIMIENTO_ID = _itemcuerpo.REQUERIMIENTO_ID
                    ItemReq.FECHAENTREGA = _itemcuerpo.FECHAENTREGA
                    ItemReq.NIVELAUT_ID = _itemcuerpo.NIVELAUT_ID
                    ItemReq.NROITEM = _itemcuerpo.NROITEM
                    ItemReq.UNIMED = _itemcuerpo.UNIMED
                    ItemReq.MARCA = _itemcuerpo.MARCA
                    'VOY AUTORIZANDO LOS ITEMS
                    NewComReqItem.Update(ItemReq)

                Next

                'HAGO EL COMMIT
                NewComReq.EndTransaction(True)
                Return True


            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewComReq.EndTransaction(False)
                Return False
            End Try
        End Function

        Public Function GeneraNuevosRequerimientos(ByVal Items As List(Of Entities.Tables.COMORDENCOMPRA), ByVal Tipo As String) As Boolean
            Dim _genera As New DAL.Procedures.GENERANUEVOREQUERIMIENTO()
            Try
                For Each OC As Entities.Tables.COMORDENCOMPRA In Items
                    _genera.Items(OC.CODEMP, OC.ORDENCOMPRA_ID, Tipo) 'por cada OC voy 
                Next

                Return True

            Catch ex As Exception

                Return False
            End Try
        End Function

        Public Function GeneraNuevosRequerimientos(ByVal CODEMP As String, ByVal ORDENCOMPRA_ID As Integer, ByVal Tipo As String) As Boolean
            Dim _genera As New DAL.Procedures.GENERANUEVOREQUERIMIENTO()
            Try

                _genera.Items(CODEMP, ORDENCOMPRA_ID, Tipo) 'llamo al stored que se encarga de generar un nuevo requerimiento

                Return True

            Catch ex As Exception

                Return False
            End Try
        End Function
    End Class

    Partial Public Class COMREQUERIMIENTOITEM
        Inherits DAL.Tables.COMREQUERIMIENTOITEM

        Public Overloads Function RemoveItem(ByVal codEmp As String, ByVal NroOC As Integer, ByVal NuevosItem As List(Of Entities.Tables.COMREQUERIMIENTOITEM), ByVal ItemsProvisorios As List(Of Entities.Tables.COMARTICULOSPROVISORIOS), obs As String, ByVal Entrega_id As Integer) As Boolean

            Dim ocCabecera As New DAL.Procedures.ACTUALIZA_OBS_REQ

            Dim Update As New DAL.Tables.COMREQUERIMIENTOITEM
            Dim OrdenCompraItem As New BLL.Tables.COMREQUERIMIENTOITEM
            OrdenCompraItem.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codEmp)
            OrdenCompraItem.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.requerimiento_id, DAL.SqlEnums.OperandEnum.Equal, NroOC)

            'ANTES DE ENTTRAR A LA TRANSACCION ACTUALIZO LA OBS.. SI ES QUE TIENE
            If obs <> String.Empty Then
                ocCabecera.Items(codEmp, NroOC, obs, Entrega_id)
            End If

            Try
                Dim newItem As New Entities.Tables.COMREQUERIMIENTOITEM
                Dim _nroRequerimiento As Int16

                Update.BeginTransaction()
                'RECUPERO TODOS LOS ITEMS DEL REQUERIMIENTO, PARA ELIMINARLOS A TODOS..... 
                For Each _item As Entities.Tables.COMREQUERIMIENTOITEM In OrdenCompraItem.Items()
                    newItem = New Entities.Tables.COMREQUERIMIENTOITEM

                    newItem.CODEMP = _item.CODEMP 'CODEMP
                    newItem.REQUERIMIENTO_ID = _item.REQUERIMIENTO_ID 'OC_ID
                    _nroRequerimiento = _item.REQUERIMIENTO_ID
                    newItem.NROITEM = _item.NROITEM

                    Update.Remove(newItem)
                Next
                Dim i As Integer
                i = 1

                'AHORA VUEVO A CREARLOS, PORQUE PUEDE SER QUE HAYA ELIMINADO ITEMS
                If NuevosItem.Count > 0 Then
                    For Each _item As Entities.Tables.COMREQUERIMIENTOITEM In NuevosItem
                        newItem = New Entities.Tables.COMREQUERIMIENTOITEM

                        newItem.ARTICULO_ID = _item.ARTICULO_ID
                        newItem.CANTIDAD = _item.CANTIDAD
                        newItem.CODEMP = _item.CODEMP 'CODEMP
                        newItem.REQUERIMIENTO_ID = _item.REQUERIMIENTO_ID 'OC_ID
                        newItem.FECHAENTREGA = _item.FECHAENTREGA
                        newItem.NIVELAUT_ID = _item.NIVELAUT_ID
                        newItem.NROITEM = i
                        newItem.UNIMED = _item.UNIMED
                        Update.Add(newItem)
                        i = i + 1
                    Next
                End If

                'BORRO TODOS LOS ARTICULOS PROVISORIOS... SI EXISTEN ALGUNOS LO VUELVO A DAR DE ALTA.. SINO QUEDAN TODOS ELIMINADOS
                Dim _proximoIDProvisorio As Integer
                Dim _proxProvisorio As New DAL.Procedures.PROXIMOCODPROVISORIO
                _proxProvisorio.Items()
                _proximoIDProvisorio = _proxProvisorio.Resultset(0).codprovisorio

                'RECUPERO TODOS LOS ITEMS PROVISORIOS PARA IR ELIMINANDOLOS ASI LOS GRABO DE NUEVO
                Dim _provisorios As New DAL.Tables.COMARTICULOSPROVISORIOS()
                Dim newProvisorios As New Entities.Tables.COMARTICULOSPROVISORIOS

                _provisorios.WhereParameter.Add(DAL.Tables.COMARTICULOSPROVISORIOS.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codEmp)
                _provisorios.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, DAL.Tables.COMARTICULOSPROVISORIOS.ColumnEnum.requerimiento_id, DAL.SqlEnums.OperandEnum.Equal, _nroRequerimiento)
                For Each _itemcuerpoProv As Entities.Tables.COMARTICULOSPROVISORIOS In _provisorios.Items()
                    newProvisorios = New Entities.Tables.COMARTICULOSPROVISORIOS
                    newProvisorios.ID = _itemcuerpoProv.ID

                    _provisorios.WhereParameter.Clear()

                    _provisorios.Remove(newProvisorios)
                Next
                'FIN BORRA ARTICULOS PROVISORIOS

                'SOLAMENTE VUELVO A INGRESAR ARTICULOS PROVISORIOS SU AL MENOS HAY UNO.... PUEDE SER QUE EL USUARIO HAYA BORRADO TODOS..
                If ItemsProvisorios.Count > 0 Then
                    'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION TABLA ARTICULOS PROVISORIOS
                    Dim NewItemProvisorio As New DAL.Tables.COMARTICULOSPROVISORIOS()
                    Dim ItemReqProvis As New Entities.Tables.COMARTICULOSPROVISORIOS

                    ' ***************INSERTO EN DOS TABLAS : COMREQUERIMIENTOSITEM Y COMARTICULOSPROVISORIOS *****************************
                    For Each _itemcuerpo As Entities.Tables.COMARTICULOSPROVISORIOS In ItemsProvisorios
                        newItem = New Entities.Tables.COMREQUERIMIENTOITEM()
                        'OBJETOS DE COMREQUERIMIENTOITEM
                        newItem.ARTICULO_ID = "0" 'ENVIO UN CERO EN ARTICULO PORQUE ES PROVISORIO
                        newItem.CANTIDAD = _itemcuerpo.CANTIDAD
                        newItem.CODEMP = codEmp
                        newItem.FECHAENTREGA = DateTime.Now.ToShortDateString()
                        newItem.NIVELAUT_ID = 1
                        newItem.NROITEM = i ' ESO LA MISMA VARIABLE QUE EL FOR DE ARRIBA.. PARA CONTINUAR CON EL NRO DE ITEM, DE LO CONTRARIO EMPIEZA DE 1..
                        newItem.REQUERIMIENTO_ID = _nroRequerimiento
                        newItem.UNIMED = _itemcuerpo.UNIMED

                        Update.Add(newItem)

                        ItemReqProvis = New Entities.Tables.COMARTICULOSPROVISORIOS
                        'OBJETOS DE COMARTICULOSPROVISORIOS
                        ItemReqProvis.CANTIDAD = _itemcuerpo.CANTIDAD
                        ItemReqProvis.CODEMP = codEmp
                        ItemReqProvis.CODPROVISORIO = _proximoIDProvisorio
                        ItemReqProvis.DESCRIPCION = _itemcuerpo.DESCRIPCION
                        ItemReqProvis.EMBALAJE = _itemcuerpo.EMBALAJE
                        ItemReqProvis.MARCA = _itemcuerpo.MARCA
                        ItemReqProvis.NROITEM = i
                        ItemReqProvis.PENDIENTEENBEJERMAN = 1 'SIGNIFICA QUE ESTA PENDIENTE DE CREACION EN BEJERMAN
                        ItemReqProvis.PRESENTACION = _itemcuerpo.PRESENTACION
                        ItemReqProvis.REQUERIMIENTO_ID = _nroRequerimiento
                        ItemReqProvis.UNIMED = _itemcuerpo.UNIMED


                        NewItemProvisorio.Add(ItemReqProvis)


                        i = i + 1
                    Next


                End If



                Update.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                Update.EndTransaction(False)
                Return False
            End Try

        End Function


    End Class

    Partial Public Class COMREQUERIMIENTOINTERNO
        Inherits DAL.Tables.COMREQUERIMIENTOINTERNO
        Public Overloads Function AddItem(ByVal ItemCab As Entities.Tables.COMREQUERIMIENTOINTERNO, ByVal Items As List(Of Entities.Tables.COMREQUERIMIENTOINTERNOITEM), ByVal codEmp As String, Optional ByRef NroReqGenerado As Integer = 0) As Boolean
            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.MAXCOMPROBANTEREQUERIMIENTOINTERNO

            If _prox.Items(codEmp).Count > 0 Then
                _proximoID = _prox.Resultset(0).requerimiento_id + 1
            Else
                _proximoID = 1
            End If

            Dim NewComReq As New DAL.Tables.COMREQUERIMIENTOINTERNO
            Dim ItemReq As New Entities.Tables.COMREQUERIMIENTOINTERNOITEM

            Try
                'ESTABLEZCO LA TRANSACCION
                NewComReq.BeginTransaction()

                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                ItemCab.CODEMP = codEmp
                ItemCab.FECHAAUTORIZACION = DateTime.Now()
                ItemCab.FECHAFINALIZACION = DateTime.Now()
                ItemCab.REQUERIMIENTO_ID = _proximoID

                NewComReq.Add(ItemCab)

                'SOLO GUARDO ITEMS DE ARTICULOS QUE EXISTEN EN BEJERMAN, SI LA COLECCION TIENE DATOS
                Dim i As Integer
                i = 1
                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewComReqItem As New DAL.Tables.COMREQUERIMIENTOINTERNOITEM(NewComReq)

                If Items.Count > 0 Then

                    For Each _itemcuerpo As Entities.Tables.COMREQUERIMIENTOINTERNOITEM In Items
                        ItemReq = New Entities.Tables.COMREQUERIMIENTOINTERNOITEM()
                        ItemReq.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                        ItemReq.CANTIDAD = _itemcuerpo.CANTIDAD
                        ItemReq.CODEMP = codEmp
                        ItemReq.FECHAENTREGA = _itemcuerpo.FECHAENTREGA
                        ItemReq.NIVELAUT_ID = _itemcuerpo.NIVELAUT_ID
                        ItemReq.NROITEM = i
                        ItemReq.REQUERIMIENTO_ID = _proximoID
                        ItemReq.UNIMED = _itemcuerpo.UNIMED
                        ItemReq.MARCA = _itemcuerpo.MARCA
                        NewComReqItem.Add(ItemReq)

                        i = i + 1
                    Next

                End If
                NroReqGenerado = _proximoID 'DEVUELVO EN ESTA VARIABLE EL NRO DE REQUERIMIENTO QUE SE GENERO

                'HAGO EL COMMIT
                NewComReq.EndTransaction(True)
                Return True


            Catch ex As Exception
                'POR CUALQUIER ERROR HAGO EL ROLLBACK
                NewComReq.EndTransaction(False)
                Return False
            End Try
        End Function

        Public Function AutorizaRequerimiento(ByVal Items As List(Of Entities.Tables.COMREQUERIMIENTOINTERNOITEM), ByVal ItemCab As Entities.Tables.COMREQUERIMIENTOINTERNO)
            Dim NewComReq As New DAL.Procedures.ACTUALIZA_USUARIO_AUTORIZA
            Dim ItemReq As New Entities.Tables.COMREQUERIMIENTOINTERNOITEM
            Try

                'ESTABLEZCO LA TRANSACCION
                NewComReq.BeginTransaction()
                'ACTUALIZO EL USUARIO QUE AUTORIZA
                NewComReq.Items("RI", ItemCab.CODEMP, ItemCab.REQUERIMIENTO_ID, ItemCab.USUARIOAUTORIZA, ItemCab.PEDIDODIARIO)

                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewComReqItem As New DAL.Tables.COMREQUERIMIENTOINTERNOITEM(NewComReq)

                For Each _itemcuerpo As Entities.Tables.COMREQUERIMIENTOINTERNOITEM In Items
                    ItemReq = New Entities.Tables.COMREQUERIMIENTOINTERNOITEM()
                    ItemReq.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    ItemReq.CANTIDAD = _itemcuerpo.CANTIDAD
                    ItemReq.CODEMP = _itemcuerpo.CODEMP
                    ItemReq.REQUERIMIENTO_ID = _itemcuerpo.REQUERIMIENTO_ID
                    ItemReq.FECHAENTREGA = _itemcuerpo.FECHAENTREGA
                    ItemReq.NIVELAUT_ID = _itemcuerpo.NIVELAUT_ID
                    ItemReq.NROITEM = _itemcuerpo.NROITEM
                    ItemReq.UNIMED = _itemcuerpo.UNIMED
                    ItemReq.MARCA = _itemcuerpo.MARCA
                    'VOY AUTORIZANDO LOS ITEMS
                    NewComReqItem.Update(ItemReq)

                Next

                'HAGO EL COMMIT
                NewComReq.EndTransaction(True)
                Return True


            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewComReq.EndTransaction(False)
                Return False
            End Try
        End Function
    End Class

    Partial Public Class COMREQUERIMIENTOINTERNOITEM
        Inherits DAL.Tables.COMREQUERIMIENTOINTERNOITEM
        Public Overloads Function RemoveItem(ByVal codEmp As String, ByVal NroReq As Integer, ByVal NuevosItem As List(Of Entities.Tables.COMREQUERIMIENTOINTERNOITEM), obs As String, ByVal _depositoOrigen_id As Int32, ByVal _sectorDepositoOrigen_id As Int32, ByVal _depositoDestino_id As Int32, ByVal _SectorDepositoDestino_id As Int32) As Boolean

            Dim ocCabecera As New DAL.Procedures.ACTUALIZA_OBS_REQ_INTERNO

            Dim Update As New DAL.Tables.COMREQUERIMIENTOINTERNOITEM
            Dim OrdenCompraItem As New BLL.Tables.COMREQUERIMIENTOINTERNOITEM
            OrdenCompraItem.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codEmp)
            OrdenCompraItem.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.requerimiento_id, DAL.SqlEnums.OperandEnum.Equal, NroReq)

            'ANTES DE ENTTRAR A LA TRANSACCION ACTUALIZO LA OBS.. SI ES QUE TIENE
            'If obs <> String.Empty Then
            ocCabecera.Items(codEmp, NroReq, obs, _depositoOrigen_id, _sectorDepositoOrigen_id, _depositoDestino_id, _SectorDepositoDestino_id)
            'End If

            Try
                Dim newItem As New Entities.Tables.COMREQUERIMIENTOINTERNOITEM
                Dim _nroRequerimiento As Int32

                Update.BeginTransaction()
                'RECUPERO TODOS LOS ITEMS DEL REQUERIMIENTO, PARA ELIMINARLOS A TODOS..... 
                For Each _item As Entities.Tables.COMREQUERIMIENTOINTERNOITEM In OrdenCompraItem.Items()
                    newItem = New Entities.Tables.COMREQUERIMIENTOINTERNOITEM

                    newItem.CODEMP = _item.CODEMP 'CODEMP
                    newItem.REQUERIMIENTO_ID = _item.REQUERIMIENTO_ID 'OC_ID
                    _nroRequerimiento = _item.REQUERIMIENTO_ID
                    newItem.NROITEM = _item.NROITEM

                    Update.Remove(newItem)
                Next
                Dim i As Integer
                i = 1

                'AHORA VUEVO A CREARLOS, PORQUE PUEDE SER QUE HAYA ELIMINADO ITEMS
                If NuevosItem.Count > 0 Then
                    For Each _item As Entities.Tables.COMREQUERIMIENTOINTERNOITEM In NuevosItem
                        newItem = New Entities.Tables.COMREQUERIMIENTOINTERNOITEM

                        newItem.ARTICULO_ID = _item.ARTICULO_ID
                        newItem.CANTIDAD = _item.CANTIDAD
                        newItem.CODEMP = _item.CODEMP 'CODEMP
                        newItem.REQUERIMIENTO_ID = _item.REQUERIMIENTO_ID 'OC_ID
                        newItem.FECHAENTREGA = _item.FECHAENTREGA
                        newItem.NIVELAUT_ID = _item.NIVELAUT_ID
                        newItem.NROITEM = i
                        newItem.UNIMED = _item.UNIMED
                        Update.Add(newItem)
                        i = i + 1
                    Next
                End If




                Update.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                Update.EndTransaction(False)
                Return False
            End Try

        End Function

    End Class

    Partial Public Class COMORDENCOMPRA
        Inherits DAL.Tables.COMORDENCOMPRA
        Public Overloads Function AddItem(ByVal ItemCab As Entities.Tables.COMORDENCOMPRA, ByVal Items As List(Of Entities.Tables.COMORDENCOMPRAITEM)) As Integer
            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.MAXCOMPROBANTEOCDIRECTA

            If _prox.Items(ItemCab.CODEMP).Count > 0 Then
                _proximoID = _prox.Resultset(0).ordencompra_id + 1
            Else
                _proximoID = 1
            End If

            Dim NewComOC As New DAL.Tables.COMORDENCOMPRA
            Dim ItemOC As New Entities.Tables.COMORDENCOMPRAITEM

            Try
                'ESTABLEZCO LA TRANSACCION
                NewComOC.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                ItemCab.ORDENCOMPRA_ID = _proximoID
                NewComOC.Add(ItemCab)

                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewComOCItem As New DAL.Tables.COMORDENCOMPRAITEM(NewComOC)
                Dim i As Integer
                i = 1
                For Each _itemcuerpo As Entities.Tables.COMORDENCOMPRAITEM In Items
                    ItemOC = New Entities.Tables.COMORDENCOMPRAITEM()
                    ItemOC.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    ItemOC.CANTIDAD = _itemcuerpo.CANTIDAD
                    ItemOC.CODEMP = _itemcuerpo.CODEMP 'CODEMP
                    ItemOC.ORDENCOMPRA_ID = _proximoID 'OC_ID
                    ItemOC.FECHAENTREGA = _itemcuerpo.FECHAENTREGA
                    ItemOC.NIVELAUT_ID = _itemcuerpo.NIVELAUT_ID
                    ItemOC.NROITEM = i
                    ItemOC.MARCA = _itemcuerpo.MARCA
                    ItemOC.UNIMED = _itemcuerpo.UNIMED
                    ItemOC.PRECIO = _itemcuerpo.PRECIO

                    NewComOCItem.Add(ItemOC)

                    i = i + 1
                Next

                'HAGO EL COMMIT
                NewComOC.EndTransaction(True)
                Return _proximoID


            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewComOC.EndTransaction(False)
                Return _proximoID
            End Try

        End Function

        Public Overloads Function AddItem(ByVal ItemCab As Entities.Tables.COMORDENCOMPRA, ByVal Items As List(Of Entities.Tables.COMORDENCOMPRAITEM), ByVal segunRequerimiento As Boolean) As Integer
            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.MAXCOMPROBANTEOCDIRECTA

            If _prox.Items(ItemCab.CODEMP).Count > 0 Then
                _proximoID = _prox.Resultset(0).ordencompra_id + 1
            Else
                _proximoID = 1
            End If

            Dim NewComOC As New DAL.Tables.COMORDENCOMPRA
            Dim ItemOC As New Entities.Tables.COMORDENCOMPRAITEM
            Dim ItemReqOC As New Entities.Tables.COMREQUERIMIENTOORDENCOMPRA

            Try
                'ESTABLEZCO LA TRANSACCION
                NewComOC.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                ItemCab.ORDENCOMPRA_ID = _proximoID
                NewComOC.Add(ItemCab)

                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewComOCItem As New DAL.Tables.COMORDENCOMPRAITEM(NewComOC)
                Dim NewItemReqOC As New DAL.Tables.COMREQUERIMIENTOORDENCOMPRA(NewComOC)
                Dim i As Integer
                i = 1
                For Each _itemcuerpo As Entities.Tables.COMORDENCOMPRAITEM In Items
                    ItemOC = New Entities.Tables.COMORDENCOMPRAITEM()
                    ItemOC.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    ItemOC.CANTIDAD = _itemcuerpo.CANTIDAD
                    ItemOC.CODEMP = ItemCab.CODEMP 'CODEMP DE LA CABECERA DE LA OC
                    ItemOC.ORDENCOMPRA_ID = _proximoID 'OC_ID
                    ItemOC.FECHAENTREGA = _itemcuerpo.FECHAENTREGA
                    ItemOC.NIVELAUT_ID = _itemcuerpo.NIVELAUT_ID
                    ItemOC.NROITEM = i

                    ItemOC.UNIMED = _itemcuerpo.UNIMED
                    ItemOC.PRECIO = _itemcuerpo.PRECIO
                    ItemOC.MARCA = _itemcuerpo.MARCA
                    'VOY GUARDANDO EN LA TABLA COMORDENCOMPRAITEM
                    NewComOCItem.Add(ItemOC)

                    'AHORA VOY GUARDANDO EN LA TABLA comRequerimientoOrdenCompra, QUE ES LA RELACION ENTRE LOS ITEM DEL REQUERIMIENTO Y LOS ITEMS DE LA OC
                    ' HACER UN FOR CICLANDO POR EL ARTICULO
                    ItemReqOC = New Entities.Tables.COMREQUERIMIENTOORDENCOMPRA
                    ItemReqOC.CODEMP = _itemcuerpo.CODEMPREQUERIMIENTO 'CODEMP DEL REQUERIMIENTO
                    ItemReqOC.REQUERIMIENTO_ID = _itemcuerpo.REQUERIMIENTO_ID
                    ItemReqOC.NROITEM = _itemcuerpo.NROITEM 'ITEM ORIGINAL DEL REQUERIMIENTO
                    ItemReqOC.CODEMPOC = ItemCab.CODEMP 'EMPRESA DE LA ORDEN DE COMPRA
                    ItemReqOC.ORDENCOMPRA_ID = _proximoID 'ID DE OC
                    ItemReqOC.NROITEMOC = i

                    NewItemReqOC.Add(ItemReqOC)

                    i = i + 1
                Next


                'HAGO EL COMMIT
                NewComOC.EndTransaction(True)
                Return _proximoID


            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewComOC.EndTransaction(False)
                Return _proximoID
            End Try

        End Function

        Public Overloads Function AddItem(ByVal ItemCab As Entities.Tables.COMORDENCOMPRA, ByVal Items As List(Of Entities.Tables.COMORDENCOMPRAITEM), ByVal itemsReqOC As List(Of Entities.UserObJ.ReqOrdenCompra)) As Integer
            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.MAXCOMPROBANTEOCDIRECTA

            If _prox.Items(ItemCab.CODEMP).Count > 0 Then
                _proximoID = _prox.Resultset(0).ordencompra_id + 1
            Else
                _proximoID = 1
            End If

            Dim NewComOC As New DAL.Tables.COMORDENCOMPRA
            Dim ItemOC As New Entities.Tables.COMORDENCOMPRAITEM
            Dim ItemReqOC As New Entities.Tables.COMREQUERIMIENTOORDENCOMPRA

            Try
                'ESTABLEZCO LA TRANSACCION
                NewComOC.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                ItemCab.ORDENCOMPRA_ID = _proximoID
                NewComOC.Add(ItemCab)

                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewComOCItem As New DAL.Tables.COMORDENCOMPRAITEM(NewComOC)
                Dim NewItemReqOC As New DAL.Tables.COMREQUERIMIENTOORDENCOMPRA(NewComOC)
                Dim i As Integer
                ' Dim query As Entities.UserObJ.ReqOrdenCompra
                i = 1
                For Each _itemcuerpo As Entities.Tables.COMORDENCOMPRAITEM In Items
                    ItemOC = New Entities.Tables.COMORDENCOMPRAITEM()
                    ItemOC.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    ItemOC.CANTIDAD = _itemcuerpo.CANTIDAD
                    ItemOC.CODEMP = ItemCab.CODEMP 'CODEMP DE LA CABECERA DE LA OC
                    ItemOC.ORDENCOMPRA_ID = _proximoID 'OC_ID
                    ItemOC.FECHAENTREGA = _itemcuerpo.FECHAENTREGA
                    ItemOC.NIVELAUT_ID = _itemcuerpo.NIVELAUT_ID
                    ItemOC.NROITEM = i

                    ItemOC.UNIMED = _itemcuerpo.UNIMED
                    ItemOC.PRECIO = _itemcuerpo.PRECIO
                    ItemOC.MARCA = _itemcuerpo.MARCA
                    'VOY GUARDANDO EN LA TABLA COMORDENCOMPRAITEM
                    NewComOCItem.Add(ItemOC)

                    'BUSCO EN LA COLECCION ESTE ARTICULO, PARA SABER QUE REQUERIMIENTO LE CORRESPONDE, PUEDE HABER EL MISMO ARTICULO EN MAS DE UN REQUERIMIENTO
                    'query = New Entities.UserObJ.ReqOrdenCompra
                    For Each ItemArt As Entities.UserObJ.ReqOrdenCompra In itemsReqOC
                        If ItemArt.Articulo_id.Trim() = ItemOC.ARTICULO_ID.Trim() Then
                            ItemReqOC = New Entities.Tables.COMREQUERIMIENTOORDENCOMPRA
                            ItemReqOC.CODEMP = ItemArt.CodEmp 'CODEMP DEL REQUERIMIENTO
                            ItemReqOC.REQUERIMIENTO_ID = ItemArt.Requerimiento_Id
                            ItemReqOC.NROITEM = ItemArt.NroItem 'ITEM ORIGINAL DEL REQUERIMIENTO
                            ItemReqOC.CODEMPOC = ItemCab.CODEMP 'EMPRESA DE LA ORDEN DE COMPRA
                            ItemReqOC.ORDENCOMPRA_ID = _proximoID 'ID DE OC
                            ItemReqOC.NROITEMOC = i

                            NewItemReqOC.Add(ItemReqOC)
                        End If

                    Next

                    i = i + 1
                Next


                'HAGO EL COMMIT
                NewComOC.EndTransaction(True)
                Return _proximoID


            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewComOC.EndTransaction(False)
                Return _proximoID
            End Try

        End Function

        Public Overloads Function AddItem(ByVal ItemCab As Entities.Tables.COMORDENCOMPRA, ByVal detalle As List(Of Entities.Tables.COMORDENCOMPRADETALLE)) As Integer
            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.MAXCOMPROBANTEOCDIRECTA

            If _prox.Items(ItemCab.CODEMP).Count > 0 Then
                _proximoID = _prox.Resultset(0).ordencompra_id + 1
            Else
                _proximoID = 1
            End If

            Dim NewComOC As New DAL.Tables.COMORDENCOMPRA


            Try
                'ESTABLEZCO LA TRANSACCION
                NewComOC.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                ItemCab.ORDENCOMPRA_ID = _proximoID
                NewComOC.Add(ItemCab)

                'INSERTO EN DETALLE
                Dim NewComOCItem As New DAL.Tables.COMORDENCOMPRADETALLE(NewComOC)
                Dim _deta As New Entities.Tables.COMORDENCOMPRADETALLE

                For Each item As Entities.Tables.COMORDENCOMPRADETALLE In detalle
                    _deta = New Entities.Tables.COMORDENCOMPRADETALLE

                    _deta.ORDENCOMPRA_ID = _proximoID
                    _deta.CANTIDAD = item.CANTIDAD
                    _deta.CODEMP = item.CODEMP
                    _deta.DETALLE = item.DETALLE
                    _deta.IMPORTE = item.IMPORTE
                    _deta.NIVELAUTO_ID = item.NIVELAUTO_ID
                    _deta.NROITEM = item.NROITEM


                    NewComOCItem.Add(_deta)
                Next


                'HAGO EL COMMIT
                NewComOC.EndTransaction(True)
                Return _proximoID


            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewComOC.EndTransaction(False)
                Return 0
            End Try

        End Function

        Public Function ModificaOCSinStock(ByVal ItemCab As Entities.Tables.COMORDENCOMPRA, ByVal detalle As List(Of Entities.Tables.COMORDENCOMPRADETALLE)) As Boolean


            Dim ocCabecera As New DAL.Procedures.ACTUALIZA_OBS_OC


            ocCabecera.Items(ItemCab.CODEMP, ItemCab.ORDENCOMPRA_ID, ItemCab.OBS, ItemCab.PROVEED_ID, ItemCab.PEDIDODIARIO, ItemCab.SECTORENTREGA_ID, ItemCab.TIPOPRORRATEO)


            Dim Update As New DAL.Tables.COMORDENCOMPRADETALLE
            Dim OcDetalle As New BLL.Tables.COMORDENCOMPRADETALLE
            OcDetalle.WhereParameter.Add(DAL.Tables.COMORDENCOMPRADETALLE.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, ItemCab.CODEMP)
            OcDetalle.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, DAL.Tables.COMORDENCOMPRADETALLE.ColumnEnum.ordenCompra_id, DAL.SqlEnums.OperandEnum.Equal, ItemCab.ORDENCOMPRA_ID)

            Try
                Dim newItem As New Entities.Tables.COMORDENCOMPRADETALLE


                Update.BeginTransaction()
                'RECUPERO TODOS LOS ITEMS DE LA OC, PARA ELIMINARLOS A TODOS..... 
                For Each _item As Entities.Tables.COMORDENCOMPRADETALLE In OcDetalle.Items()
                    newItem = New Entities.Tables.COMORDENCOMPRADETALLE

                    newItem.CODEMP = _item.CODEMP 'CODEMP
                    newItem.ORDENCOMPRA_ID = _item.ORDENCOMPRA_ID 'OC_ID
                    newItem.NROITEM = _item.NROITEM

                    Update.Remove(newItem)
                Next
                Dim i As Integer
                i = 1

                'AHORA VUEVO A CREARLOS, PORQUE PUEDE SER QUE HAYA ELIMINADO ITEMS
                If detalle.Count > 0 Then
                    For Each _item As Entities.Tables.COMORDENCOMPRADETALLE In detalle
                        newItem = New Entities.Tables.COMORDENCOMPRADETALLE


                        newItem.CODEMP = _item.CODEMP 'CODEMP
                        newItem.ORDENCOMPRA_ID = _item.ORDENCOMPRA_ID 'OC_ID
                        newItem.NROITEM = i
                        newItem.NIVELAUTO_ID = _item.NIVELAUTO_ID
                        newItem.IMPORTE = _item.IMPORTE
                        newItem.DETALLE = _item.DETALLE
                        newItem.CANTIDAD = _item.CANTIDAD

                        Update.Add(newItem)
                        i = i + 1
                    Next
                End If




                Update.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                Update.EndTransaction(False)
                Return False
            End Try

        End Function


        Public Overloads Function GeneraOrdenDeCompraSegunCotizacion(ByVal ItemCab As Entities.Tables.COMORDENCOMPRA, ByVal Items As List(Of Entities.Tables.COMORDENCOMPRAITEM), ByVal NroCotizacion As Integer) As Integer
            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.MAXCOMPROBANTEOCDIRECTA

            If _prox.Items(ItemCab.CODEMP).Count > 0 Then
                _proximoID = _prox.Resultset(0).ordencompra_id + 1
            Else
                _proximoID = 1
            End If

            Dim NewComOC As New DAL.Tables.COMORDENCOMPRA
            Dim ItemOC As New Entities.Tables.COMORDENCOMPRAITEM
            'Dim ItemReqOC As New Entities.Tables.COMREQUERIMIENTOORDENCOMPRA

            Try
                'ESTABLEZCO LA TRANSACCION
                NewComOC.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                ItemCab.ORDENCOMPRA_ID = _proximoID
                NewComOC.Add(ItemCab)

                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewComOCItem As New DAL.Tables.COMORDENCOMPRAITEM(NewComOC)
                Dim NewItemReqOC As New DAL.Procedures.INSERTAREQUERIMIENTOORDENCOMPRA(NewComOC)
                Dim i As Integer
                i = 1
                For Each _itemcuerpo As Entities.Tables.COMORDENCOMPRAITEM In Items
                    ItemOC = New Entities.Tables.COMORDENCOMPRAITEM()
                    ItemOC.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    ItemOC.CANTIDAD = _itemcuerpo.CANTIDAD
                    ItemOC.CODEMP = ItemCab.CODEMP 'CODEMP DE LA CABECERA DE LA OC
                    ItemOC.ORDENCOMPRA_ID = _proximoID 'OC_ID
                    ItemOC.FECHAENTREGA = _itemcuerpo.FECHAENTREGA
                    ItemOC.NIVELAUT_ID = _itemcuerpo.NIVELAUT_ID
                    ItemOC.NROITEM = i

                    ItemOC.UNIMED = _itemcuerpo.UNIMED
                    ItemOC.PRECIO = _itemcuerpo.PRECIO
                    'VOY GUARDANDO EN LA TABLA COMORDENCOMPRAITEM
                    NewComOCItem.Add(ItemOC)

                    'LLAMO AL STORED QUE ME GUARDA EN LA TABLA COMREQUERIMIENTOORDENCOMPRA, ES UN STORED ESPECIAL QUE BUSCA LOS REQUERIMIENTOS DE ESTA COTIZACION
                    'ItemReqOC = New Entities.Tables.COMREQUERIMIENTOORDENCOMPRA
                    'ItemReqOC.CODEMP = _itemcuerpo.CODEMPREQUERIMIENTO 'CODEMP DEL REQUERIMIENTO
                    'ItemReqOC.REQUERIMIENTO_ID = _itemcuerpo.REQUERIMIENTO_ID
                    'ItemReqOC.NROITEM = _itemcuerpo.NROITEM 'ITEM ORIGINAL DEL REQUERIMIENTO
                    'ItemReqOC.CODEMPOC = ItemCab.CODEMP 'EMPRESA DE LA ORDEN DE COMPRA
                    'ItemReqOC.ORDENCOMPRA_ID = _proximoID 'ID DE OC
                    'ItemReqOC.NROITEMOC = i

                    NewItemReqOC.Add(ItemCab.CODEMP, NroCotizacion, _proximoID, i, _itemcuerpo.ARTICULO_ID, ItemCab.PROVEED_ID)

                    i = i + 1
                Next


                'HAGO EL COMMIT
                NewComOC.EndTransaction(True)
                Return _proximoID


            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewComOC.EndTransaction(False)
                Return _proximoID
            End Try

        End Function

        Public Function AutorizaOrdenCompra(ByVal Items As List(Of Entities.Tables.COMORDENCOMPRAITEM), ByVal ItemCab As Entities.Tables.COMORDENCOMPRA)
            Dim NewOC As New DAL.Procedures.ACTUALIZA_USUARIO_AUTORIZA
            Dim ItemOC As New Entities.Tables.COMORDENCOMPRAITEM
            Try

                'ESTABLEZCO LA TRANSACCION
                NewOC.BeginTransaction()
                'ACTUALIZO EL USUARIO QUE AUTORIZA
                NewOC.Items("OC", ItemCab.CODEMP, ItemCab.ORDENCOMPRA_ID, ItemCab.USUARIOAUTORIZA, ItemCab.PEDIDODIARIO)

                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewComOCItem As New DAL.Tables.COMORDENCOMPRAITEM(NewOC)

                For Each _itemcuerpo As Entities.Tables.COMORDENCOMPRAITEM In Items
                    ItemOC = New Entities.Tables.COMORDENCOMPRAITEM()
                    ItemOC.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    ItemOC.CANTIDAD = _itemcuerpo.CANTIDAD
                    ItemOC.PRECIO = _itemcuerpo.PRECIO
                    ItemOC.CODEMP = _itemcuerpo.CODEMP 'CODEMP
                    ItemOC.ORDENCOMPRA_ID = _itemcuerpo.ORDENCOMPRA_ID 'OC_ID
                    ItemOC.FECHAENTREGA = _itemcuerpo.FECHAENTREGA
                    ItemOC.NIVELAUT_ID = _itemcuerpo.NIVELAUT_ID
                    ItemOC.NROITEM = _itemcuerpo.NROITEM
                    ItemOC.UNIMED = _itemcuerpo.UNIMED
                    ItemOC.MARCA = _itemcuerpo.MARCA

                    'VOY AUTORIZANDO LOS ITEMS
                    NewComOCItem.Update(ItemOC)

                Next

                'HAGO EL COMMIT
                NewOC.EndTransaction(True)
                Return True


            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewOC.EndTransaction(False)
                Return False
            End Try
        End Function

        Public Function AutorizaOrdenCompra(ByVal Items As List(Of Entities.Tables.COMORDENCOMPRADETALLE), ByVal ItemCab As Entities.Tables.COMORDENCOMPRA)
            Dim NewOC As New DAL.Procedures.ACTUALIZA_USUARIO_AUTORIZA
            Dim ItemOC As New Entities.Tables.COMORDENCOMPRADETALLE
            Try

                'ESTABLEZCO LA TRANSACCION
                NewOC.BeginTransaction()
                'ACTUALIZO EL USUARIO QUE AUTORIZA
                NewOC.Items("OC", ItemCab.CODEMP, ItemCab.ORDENCOMPRA_ID, ItemCab.USUARIOAUTORIZA, ItemCab.PEDIDODIARIO)

                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewComOCItem As New DAL.Tables.COMORDENCOMPRADETALLE(NewOC)

                For Each _itemcuerpo As Entities.Tables.COMORDENCOMPRADETALLE In Items
                    ItemOC = New Entities.Tables.COMORDENCOMPRADETALLE()

                    ItemOC.CANTIDAD = _itemcuerpo.CANTIDAD
                    ItemOC.IMPORTE = _itemcuerpo.IMPORTE
                    ItemOC.CODEMP = _itemcuerpo.CODEMP 'CODEMP
                    ItemOC.ORDENCOMPRA_ID = _itemcuerpo.ORDENCOMPRA_ID 'OC_ID
                    ItemOC.NIVELAUTO_ID = _itemcuerpo.NIVELAUTO_ID
                    ItemOC.NROITEM = _itemcuerpo.NROITEM
                    ItemOC.DETALLE = _itemcuerpo.DETALLE
                    'VOY AUTORIZANDO LOS ITEMS
                    NewComOCItem.Update(ItemOC)

                Next

                'HAGO EL COMMIT
                NewOC.EndTransaction(True)
                Return True


            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewOC.EndTransaction(False)
                Return False
            End Try
        End Function

    End Class

    Partial Public Class COMORDENCOMPRAITEM
        Inherits DAL.Tables.COMORDENCOMPRAITEM

        Public Overloads Function RemoveItem(ByVal codEmp As String, ByVal NroOC As Integer, ByVal NuevosItem As List(Of Entities.Tables.COMORDENCOMPRAITEM), ByVal obs As String, ByVal Proveed As String, ByVal pedidodiario As Boolean, ByVal sectorentrega As Int32) As Boolean

            Dim ocCabecera As New DAL.Procedures.ACTUALIZA_OBS_OC

            Dim OrdenCompraItem As New BLL.Tables.COMORDENCOMPRAITEM
            OrdenCompraItem.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codEmp)
            OrdenCompraItem.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.ordenCompra_id, DAL.SqlEnums.OperandEnum.Equal, NroOC)

            Dim Update As New DAL.Tables.COMORDENCOMPRAITEM()
            'ANTES DE ENTTRAR A LA TRANSACCION ACTUALIZO LA OBS.. SI ES QUE TIENE

            ocCabecera.Items(codEmp, NroOC, obs, Proveed, pedidodiario, sectorentrega, 1)



            Try
                Dim newItem As New Entities.Tables.COMORDENCOMPRAITEM
                'RECUPERO TODOAS LOS ITEMS DE LA OC ORIGINAL Y LOS VOY ELIMINANDO
                Update.BeginTransaction()

                For Each _item As Entities.Tables.COMORDENCOMPRAITEM In OrdenCompraItem.Items()
                    newItem = New Entities.Tables.COMORDENCOMPRAITEM

                    newItem.CODEMP = _item.CODEMP 'CODEMP
                    newItem.ORDENCOMPRA_ID = _item.ORDENCOMPRA_ID 'OC_ID
                    newItem.NROITEM = _item.NROITEM

                    Update.Remove(newItem)
                Next
                Dim i As Integer
                i = 1
                'AHORA GRABO LOS NUEVOS
                For Each _item As Entities.Tables.COMORDENCOMPRAITEM In NuevosItem
                    newItem = New Entities.Tables.COMORDENCOMPRAITEM

                    newItem.ARTICULO_ID = _item.ARTICULO_ID
                    newItem.CANTIDAD = _item.CANTIDAD
                    newItem.CODEMP = _item.CODEMP 'CODEMP
                    newItem.ORDENCOMPRA_ID = _item.ORDENCOMPRA_ID 'OC_ID
                    newItem.FECHAENTREGA = _item.FECHAENTREGA
                    newItem.NIVELAUT_ID = _item.NIVELAUT_ID
                    newItem.NROITEM = i
                    newItem.UNIMED = _item.UNIMED
                    newItem.PRECIO = _item.PRECIO
                    Update.Add(newItem)


                    i = i + 1
                Next



                Update.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                Update.EndTransaction(False)
                Return False
            End Try

        End Function

        Public Overloads Function ActualizaOcItemAutorizada(ByVal codEmp As String, ByVal NroOC As Integer, Items As List(Of Entities.Tables.COMORDENCOMPRAITEM), ByVal obs As String, ByVal Proveed As String, ByVal pedidodiario As Boolean, ByVal sectorentrega As Int32) As Boolean
            Dim ocCabecera As New DAL.Procedures.ACTUALIZA_OBS_OC
            'ANTES DE ENTTRAR A LA TRANSACCION ACTUALIZO LA OBS.. SI ES QUE TIENE

            ocCabecera.Items(codEmp, NroOC, obs, Proveed, pedidodiario, sectorentrega, 1)


            Try
                Dim _modifOCItem = New DAL.Procedures.MODIFICAITEMOCAUTORIZADA()

                For Each item As Entities.Tables.COMORDENCOMPRAITEM In Items
                    _modifOCItem.Items(codEmp, NroOC, item.NROITEM, item.CANTIDAD, item.CANTIDADORIGINAL, item.PRECIO, item.PRECIOORIGINAL, item.EMBALAJE, item.MARCA)

                Next

                Return True
            Catch ex As Exception
                Return False
            End Try



        End Function

    End Class
    'CLASE QUE INGRESA LA MERCADERIA AL STOCK... TAMBIEN SE UTILIZA PARA REGISTRAR LOS CAMBIOS DE DEPOSITO
    Partial Public Class STKMOVIMIENTO
        Inherits DAL.Tables.STKMOVIMIENTO
        Public Overloads Function SalidaMercaderiaPorRequerimientoInterno(ByVal _itemsInventario As List(Of Entities.Tables.STKINVENTARIO), ByVal _itemMovimiento As Entities.Tables.STKMOVIMIENTO, ByVal _itemsMov As List(Of Entities.Tables.STKMOVIMIENTOITEM), ByVal _codEmp As String, ByVal _requerimiento_id As Int32) As Integer
            'RECUPERO PROXIMO NRO DE COMPROBANTE
            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.MAXCOMPROBANTESTKMOVIMIENTO
            Dim _proxNroRemito As Integer

            If _prox.Items(_itemMovimiento.CODEMP).Count > 0 Then
                _proximoID = _prox.Resultset(0).comprobante + 1
            Else
                _proximoID = 1
            End If
            'FIN PROXIMO NRO COMPROBANTE

            Dim _stkRemito As New BLL.Procedures.PROXIMONROREMITO
            If _stkRemito.Items().Count > 0 Then
                _proxNroRemito = _stkRemito.Resultset(0).nroremito
            Else
                _proxNroRemito = 1
            End If

            Dim NewMov As New DAL.Tables.STKMOVIMIENTO



            Try
                'EMPIEZO TRANSACCION
                NewMov.BeginTransaction()
                'COMPLETO EL OBJETO
                _itemMovimiento.COMPROBANTE = _proximoID
                '*** INSERTO EN TABLA STKMOVIMIENTOS ***
                NewMov.Add(_itemMovimiento)

                'AHORA INSERTO EN LOS ITEMS
                Dim newItemMov As New DAL.Tables.STKMOVIMIENTOITEM(NewMov)
                Dim newitemsMov As New Entities.Tables.STKMOVIMIENTOITEM

                Dim newItemStkEnTransito As New DAL.Tables.STKENTRANSITO(NewMov)
                Dim newitemsTransito As New Entities.Tables.STKENTRANSITO

                'ITEMS DE LA TABLA STKMOVIREQINTERNO
                Dim newItemMoviReq As New DAL.Tables.STKMOVIREQINTERNO(NewMov)
                Dim newitemsMoviReq As New Entities.Tables.STKMOVIREQINTERNO

                Dim i As Integer
                i = 1
                For Each _itemcuerpo As Entities.Tables.STKMOVIMIENTOITEM In _itemsMov
                    newitemsMov = New Entities.Tables.STKMOVIMIENTOITEM

                    newitemsMov.CODEMP = _itemcuerpo.CODEMP
                    newitemsMov.COMPROBANTE = _proximoID
                    newitemsMov.NROITEM = i
                    newitemsMov.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    newitemsMov.UNIMED = _itemcuerpo.UNIMED
                    newitemsMov.CANTIDAD = _itemcuerpo.CANTIDAD
                    newitemsMov.COSTOUNI = 0 'VER ESTO SI ESTA BIEN
                    'VOY GUARDANDO LOS ITEMS
                    newItemMov.Add(newitemsMov)

                    'AHORA GUARDO GENERANADO LA TABLA STKMOVIReqIntero
                    newitemsMoviReq = New Entities.Tables.STKMOVIREQINTERNO
                    newitemsMoviReq.CODEMP = _itemcuerpo.CODEMP 'CODEMP REQUERIMIENTO INTERNO
                    newitemsMoviReq.REQUERIMIENTO_ID = _requerimiento_id '  NRO DE REQUERIMIENTO
                    newitemsMoviReq.CANTENVIADA = _itemcuerpo.CANTIDAD 'CANTIDAD RECIBIDA
                    newitemsMoviReq.NROITEM = _itemcuerpo.NROITEM ' NRO ITEM DEL REQUERIMIENTO
                    newitemsMoviReq.CODEMPSTK = _itemcuerpo.CODEMP 'CODEMP DE LA TABLA STKMIMIENTOSITEM
                    newitemsMoviReq.COMPROBANTESTK = _proximoID 'NRO DE COMPROBANTE DE LA TABLA STKMOVIMIENTOITEM
                    newitemsMoviReq.NROITEMSTK = i 'NRO DE ITEM GENERADO EN LA TABLA STKMOVIMIENTOITEM
                    newitemsMoviReq.UNIMED = _itemcuerpo.UNIMED
                    newitemsMoviReq.REMSUCURSAL = "0001" 'SUCURSAL DEL REMITO 
                    newitemsMoviReq.REMCOMPROBANTE = _proxNroRemito 'NRO DE REMITO 


                    newItemMoviReq.Add(newitemsMoviReq)

                    'VERIFICO, SI ES UN CAMBIO DE DEPOSITO... ENTONCES REGISTRO EN EL DEPOSITO TRANSITO Y EN STKREMITOS

                    If _itemMovimiento.TIPOMOV_ID = 2 And _itemMovimiento.SUBTIPOMOV_ID = 2 Then
                        newitemsTransito = New Entities.Tables.STKENTRANSITO

                        newitemsTransito.CODEMP = _itemcuerpo.CODEMP
                        newitemsTransito.COMPROBANTE = _proximoID
                        newitemsTransito.NROITEM = i
                        newitemsTransito.CANTORIGINAL = _itemcuerpo.CANTIDAD
                        newitemsTransito.CANTRECIBIDA = 0
                        newitemsTransito.UNIMED = _itemcuerpo.UNIMED
                        newitemsTransito.ESTADO_ID = 0 'NO SE USA
                        newitemsTransito.USUARIOGENERA = _itemMovimiento.USUARIO
                        'VOY INSERTANDO LOS ITEMS
                        newItemStkEnTransito.Add(newitemsTransito)

                    End If

                    i = i + 1
                Next
                i = 1

                'AHORA INSERTO EN LOS ITEMS EN STKINVENTARIO, SI EL PRODUCTO EXISTE, ACTUALIZO EL STOCK SINO CREO EL PRODUCTO
                Dim newItemInv As New DAL.Tables.STKINVENTARIO(NewMov)
                Dim newitemsInv As New Entities.Tables.STKINVENTARIO

                Dim existeProd As New BLL.Tables.STKINVENTARIO

                For Each _itemcuerpo2 As Entities.Tables.STKINVENTARIO In _itemsInventario
                    newitemsInv = New Entities.Tables.STKINVENTARIO


                    newitemsInv.ARTICULO_ID = _itemcuerpo2.ARTICULO_ID
                    newitemsInv.DEPOSITO_ID = _itemcuerpo2.DEPOSITO_ID
                    newitemsInv.SECTOR_ID = _itemcuerpo2.SECTOR_ID 'NO SE USA EN EL STORED
                    newitemsInv.UNIMED = _itemcuerpo2.UNIMED

                    If _itemMovimiento.TIPOMOV_ID = 1 Then
                        newitemsInv.CANTIDAD = _itemcuerpo2.CANTIDAD
                    Else
                        newitemsInv.CANTIDAD = (_itemcuerpo2.CANTIDAD * -1) 'PORQUE ESTOY RESTANDO DEL STOCK, LO ENVIO EN NEGATIVO, EL STORED... RESTA O SUMA
                    End If

                    'VERIFICO SI EXISTE ESTE PRODUCTO>

                    If existeProd.ItemList(_itemcuerpo2.ARTICULO_ID, _itemcuerpo2.DEPOSITO_ID).Count > 0 Then
                        newItemInv.Update(newitemsInv)

                    Else
                        'VOY GUARDANDO LOS ITEMS, **** SI ESTE ARTICULO LLEVA VTO. VOY DESCONTANDO TAMBIEN DE LA TABLA STKVENCIMIENTOS... DE LA FECHA MAS PROXIMA ******
                        newItemInv.Add(newitemsInv)
                    End If
                    i = i + 1
                    existeProd.WhereParameter.Clear()
                Next

                'TAMBIEN SI ES UN CAMBIO DE DEPOSITO, GENERO LA TABLE REMITO
                If _itemMovimiento.TIPOMOV_ID = 2 And _itemMovimiento.SUBTIPOMOV_ID = 2 Then


                    Dim _stkRemitoAdd = New DAL.Tables.STKREMITO(NewMov)
                    Dim newStkRemito As New Entities.Tables.STKREMITO

                    newStkRemito.CODEMP = _itemMovimiento.CODEMP
                    newStkRemito.CODEMPSTK = _itemMovimiento.CODEMP
                    newStkRemito.COMPROBANTE = _proxNroRemito
                    newStkRemito.COMPROBANTESTK = _proximoID
                    newStkRemito.FECHA = DateTime.Now.ToShortDateString()
                    newStkRemito.LETRA = "R"
                    newStkRemito.SUCURSAL = "0001"
                    'GENERO EL COMPROBANTE DEL REMITO
                    _stkRemitoAdd.Add(newStkRemito)


                End If


                NewMov.EndTransaction(True)
                'SI ES UN INGRESO DE STOCK COMUN.. DEVUELVO CERO
                Return _proxNroRemito

            Catch ex As Exception
                NewMov.EndTransaction(False)
                Return False
            End Try


        End Function

        Public Overloads Function GenerarMovStock(ByVal _itemsInventario As List(Of Entities.Tables.STKINVENTARIO), ByVal _itemMovimiento As Entities.Tables.STKMOVIMIENTO, ByVal _itemsMov As List(Of Entities.Tables.STKMOVIMIENTOITEM)) As Integer
            'RECUPERO PROXIMO NRO DE COMPROBANTE
            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.MAXCOMPROBANTESTKMOVIMIENTO
            Dim _proxNroRemito As Integer

            If _prox.Items(_itemMovimiento.CODEMP).Count > 0 Then
                _proximoID = _prox.Resultset(0).comprobante + 1


            Else
                _proximoID = 1
            End If
            'FIN PROXIMO NRO COMPROBANTE

            Dim NewMov As New DAL.Tables.STKMOVIMIENTO

            Try
                'EMPIEZO TRANSACCION
                NewMov.BeginTransaction()
                'COMPLETO EL OBJETO
                _itemMovimiento.COMPROBANTE = _proximoID
                '*** INSERTO EN TABLA STKMOVIMIENTOS ***
                NewMov.Add(_itemMovimiento)

                'AHORA INSERTO EN LOS ITEMS
                Dim newItemMov As New DAL.Tables.STKMOVIMIENTOITEM(NewMov)
                Dim newitemsMov As New Entities.Tables.STKMOVIMIENTOITEM

                Dim newItemStkEnTransito As New DAL.Tables.STKENTRANSITO(NewMov)
                Dim newitemsTransito As New Entities.Tables.STKENTRANSITO


                Dim i As Integer
                i = 1
                For Each _itemcuerpo As Entities.Tables.STKMOVIMIENTOITEM In _itemsMov
                    newitemsMov = New Entities.Tables.STKMOVIMIENTOITEM

                    newitemsMov.CODEMP = _itemcuerpo.CODEMP
                    newitemsMov.COMPROBANTE = _proximoID
                    newitemsMov.NROITEM = i
                    newitemsMov.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    newitemsMov.UNIMED = _itemcuerpo.UNIMED
                    newitemsMov.CANTIDAD = _itemcuerpo.CANTIDAD
                    newitemsMov.COSTOUNI = 0 'VER ESTO SI ESTA BIEN
                    'VOY GUARDANDO LOS ITEMS
                    newItemMov.Add(newitemsMov)

                    'VERIFICO, SI ES UN CAMBIO DE DEPOSITO... ENTONCES REGISTRO EN EL DEPOSITO TRANSITO Y EN STKREMITOS

                    If _itemMovimiento.TIPOMOV_ID = 2 And _itemMovimiento.SUBTIPOMOV_ID = 2 Then
                        newitemsTransito = New Entities.Tables.STKENTRANSITO

                        newitemsTransito.CODEMP = _itemcuerpo.CODEMP
                        newitemsTransito.COMPROBANTE = _proximoID
                        newitemsTransito.NROITEM = i
                        newitemsTransito.CANTORIGINAL = _itemcuerpo.CANTIDAD
                        newitemsTransito.CANTRECIBIDA = 0
                        newitemsTransito.UNIMED = _itemcuerpo.UNIMED
                        newitemsTransito.ESTADO_ID = 0 'NO SE USA
                        newitemsTransito.USUARIOGENERA = _itemMovimiento.USUARIO
                        'VOY INSERTANDO LOS ITEMS
                        newItemStkEnTransito.Add(newitemsTransito)

                    End If

                    i = i + 1
                Next
                i = 1

                'AHORA INSERTO EN LOS ITEMS EN STKINVENTARIO, SI EL PRODUCTO EXISTE, ACTUALIZO EL STOCK SINO CREO EL PRODUCTO
                Dim newItemInv As New DAL.Tables.STKINVENTARIO(NewMov)
                Dim newitemsInv As New Entities.Tables.STKINVENTARIO

                Dim existeProd As New BLL.Tables.STKINVENTARIO

                For Each _itemcuerpo2 As Entities.Tables.STKINVENTARIO In _itemsInventario
                    newitemsInv = New Entities.Tables.STKINVENTARIO


                    newitemsInv.ARTICULO_ID = _itemcuerpo2.ARTICULO_ID
                    newitemsInv.DEPOSITO_ID = _itemcuerpo2.DEPOSITO_ID
                    newitemsInv.SECTOR_ID = _itemcuerpo2.SECTOR_ID 'NO SE USA EN EL STORED
                    newitemsInv.UNIMED = _itemcuerpo2.UNIMED

                    If _itemMovimiento.TIPOMOV_ID = 1 Then
                        newitemsInv.CANTIDAD = _itemcuerpo2.CANTIDAD
                    Else
                        newitemsInv.CANTIDAD = (_itemcuerpo2.CANTIDAD * -1) 'PORQUE ESTOY RESTANDO DEL STOCK, LO ENVIO EN NEGATIVO, EL STORED... RESTA O SUMA
                    End If

                    'VERIFICO SI EXISTE ESTE PRODUCTO>

                    If existeProd.ItemList(_itemcuerpo2.ARTICULO_ID, _itemcuerpo2.DEPOSITO_ID).Count > 0 Then
                        newItemInv.Update(newitemsInv)

                    Else
                        'VOY GUARDANDO LOS ITEMS, **** SI ESTE ARTICULO LLEVA VTO. VOY DESCONTANDO TAMBIEN DE LA TABLA STKVENCIMIENTOS... DE LA FECHA MAS PROXIMA ******
                        newItemInv.Add(newitemsInv)
                    End If
                    i = i + 1
                    existeProd.WhereParameter.Clear()
                Next

                'TAMBIEN SI ES UN CAMBIO DE DEPOSITO, GENERO LA TABLE REMITO
                If _itemMovimiento.TIPOMOV_ID = 2 And _itemMovimiento.SUBTIPOMOV_ID = 2 Then

                    Dim _stkRemito As New BLL.Procedures.PROXIMONROREMITO
                    If _stkRemito.Items().Count > 0 Then
                        _proxNroRemito = _stkRemito.Resultset(0).nroremito
                    Else
                        _proxNroRemito = 1
                    End If

                    Dim _stkRemitoAdd = New DAL.Tables.STKREMITO(NewMov)
                    Dim newStkRemito As New Entities.Tables.STKREMITO

                    newStkRemito.CODEMP = _itemMovimiento.CODEMP
                    newStkRemito.CODEMPSTK = _itemMovimiento.CODEMP
                    newStkRemito.COMPROBANTE = _proxNroRemito
                    newStkRemito.COMPROBANTESTK = _proximoID
                    newStkRemito.FECHA = DateTime.Now.ToShortDateString()
                    newStkRemito.LETRA = "R"
                    newStkRemito.SUCURSAL = "0001"
                    'GENERO EL COMPROBANTE DEL REMITO
                    _stkRemitoAdd.Add(newStkRemito)


                End If


                NewMov.EndTransaction(True)
                'SI ES UN INGRESO DE STOCK COMUN.. DEVUELVO CERO
                Return _proxNroRemito

            Catch ex As Exception
                NewMov.EndTransaction(False)
                Return False
            End Try


        End Function

        Public Overloads Function GenerarMovStock(ByVal _itemsInventario As List(Of Entities.Tables.STKINVENTARIO), ByVal _itemMovimiento As Entities.Tables.STKMOVIMIENTO, ByVal _itemsMov As List(Of Entities.Tables.STKMOVIMIENTOITEM), ByVal _itemsVtos As List(Of Entities.Tables.STKVENCIMIENTO)) As Integer
            'RECUPERO PROXIMO NRO DE COMPROBANTE
            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.MAXCOMPROBANTESTKMOVIMIENTO
            Dim _proxNroRemito As Integer

            If _prox.Items(_itemMovimiento.CODEMP).Count > 0 Then
                _proximoID = _prox.Resultset(0).comprobante + 1


            Else
                _proximoID = 1
            End If
            'FIN PROXIMO NRO COMPROBANTE

            Dim NewMov As New DAL.Tables.STKMOVIMIENTO

            Try
                'EMPIEZO TRANSACCION
                NewMov.BeginTransaction()
                'COMPLETO EL OBJETO
                _itemMovimiento.COMPROBANTE = _proximoID
                '*** INSERTO EN TABLA STKMOVIMIENTOS ***
                NewMov.Add(_itemMovimiento)

                'AHORA INSERTO EN LOS ITEMS
                Dim newItemMov As New DAL.Tables.STKMOVIMIENTOITEM(NewMov)
                Dim newitemsMov As New Entities.Tables.STKMOVIMIENTOITEM

                Dim newItemStkEnTransito As New DAL.Tables.STKENTRANSITO(NewMov)
                Dim newitemsTransito As New Entities.Tables.STKENTRANSITO

                Dim i As Integer
                i = 1
                For Each _itemcuerpo As Entities.Tables.STKMOVIMIENTOITEM In _itemsMov
                    newitemsMov = New Entities.Tables.STKMOVIMIENTOITEM

                    newitemsMov.CODEMP = _itemcuerpo.CODEMP
                    newitemsMov.COMPROBANTE = _proximoID
                    newitemsMov.NROITEM = i
                    newitemsMov.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    newitemsMov.UNIMED = _itemcuerpo.UNIMED
                    newitemsMov.CANTIDAD = _itemcuerpo.CANTIDAD
                    newitemsMov.COSTOUNI = 0 'VER ESTO SI ESTA BIEN
                    'VOY GUARDANDO LOS ITEMS
                    newItemMov.Add(newitemsMov)

                    'VERIFICO, SI ES UN CAMBIO DE DEPOSITO... ENTONCES REGISTRO EN EL DEPOSITO TRANSITO Y EN STKREMITOS

                    If _itemMovimiento.TIPOMOV_ID = 2 And _itemMovimiento.SUBTIPOMOV_ID = 2 Then
                        newitemsTransito = New Entities.Tables.STKENTRANSITO

                        newitemsTransito.CODEMP = _itemcuerpo.CODEMP
                        newitemsTransito.COMPROBANTE = _proximoID
                        newitemsTransito.NROITEM = i
                        newitemsTransito.CANTORIGINAL = _itemcuerpo.CANTIDAD
                        newitemsTransito.CANTRECIBIDA = 0
                        newitemsTransito.UNIMED = _itemcuerpo.UNIMED
                        newitemsTransito.ESTADO_ID = 0 'NO SE USA
                        newitemsTransito.USUARIOGENERA = _itemMovimiento.USUARIO
                        'VOY INSERTANDO LOS ITEMS
                        newItemStkEnTransito.Add(newitemsTransito)

                    End If

                    i = i + 1
                Next
                i = 1

                'AHORA INSERTO EN LOS ITEMS EN STKINVENTARIO, SI EL PRODUCTO EXISTE, ACTUALIZO EL STOCK SINO CREO EL PRODUCTO
                Dim newItemInv As New DAL.Tables.STKINVENTARIO(NewMov)
                Dim newitemsInv As New Entities.Tables.STKINVENTARIO

                Dim existeProd As New BLL.Tables.STKINVENTARIO

                For Each _itemcuerpo2 As Entities.Tables.STKINVENTARIO In _itemsInventario
                    newitemsInv = New Entities.Tables.STKINVENTARIO


                    newitemsInv.ARTICULO_ID = _itemcuerpo2.ARTICULO_ID
                    newitemsInv.DEPOSITO_ID = _itemcuerpo2.DEPOSITO_ID
                    newitemsInv.SECTOR_ID = _itemcuerpo2.SECTOR_ID 'NO SE USA EN EL STORED
                    newitemsInv.UNIMED = _itemcuerpo2.UNIMED

                    If _itemMovimiento.TIPOMOV_ID = 1 Then
                        newitemsInv.CANTIDAD = _itemcuerpo2.CANTIDAD
                    Else
                        newitemsInv.CANTIDAD = (_itemcuerpo2.CANTIDAD * -1) 'PORQUE ESTOY RESTANDO DEL STOCK, LO ENVIO EN NEGATIVO, EL STORED... RESTA O SUMA
                    End If

                    'VERIFICO SI EXISTE ESTE PRODUCTO>

                    If existeProd.ItemList(_itemcuerpo2.ARTICULO_ID, _itemcuerpo2.DEPOSITO_ID).Count > 0 Then
                        newItemInv.Update(newitemsInv)

                    Else
                        'VOY GUARDANDO LOS ITEMS, **** SI ESTE ARTICULO LLEVA VTO. VOY DESCONTANDO TAMBIEN DE LA TABLA STKVENCIMIENTOS... DE LA FECHA MAS PROXIMA ******
                        newItemInv.Add(newitemsInv)
                    End If
                    i = i + 1
                    existeProd.WhereParameter.Clear()
                Next

                'VERIFICO SI TIENE ARTICULOS CON VTOS....
                If _itemsVtos.Count > 0 Then
                    Dim newItemVtos As New DAL.Tables.STKVENCIMIENTO(NewMov)
                    Dim _itemV As New Entities.Tables.STKVENCIMIENTO
                    For Each _vtos As Entities.Tables.STKVENCIMIENTO In _itemsVtos
                        _itemV = New Entities.Tables.STKVENCIMIENTO
                        _itemV.CODEMP = _itemMovimiento.CODEMP
                        _itemV.COMPROBANTE = _proximoID
                        _itemV.ARTICULO_ID = _vtos.ARTICULO_ID
                        _itemV.CANTIDAD = _vtos.CANTIDAD
                        _itemV.ENSTOCK = _vtos.CANTIDAD
                        _itemV.VTO = _vtos.VTO
                        'VOY GUARDANDO EN TABLA 
                        newItemVtos.Add(_itemV)
                    Next
                End If

                'TAMBIEN SI ES UN CAMBIO DE DEPOSITO, GENERO LA TABLE REMITO
                If _itemMovimiento.TIPOMOV_ID = 2 And _itemMovimiento.SUBTIPOMOV_ID = 2 Then

                    Dim _stkRemito As New BLL.Procedures.PROXIMONROREMITO
                    If _stkRemito.Items().Count > 0 Then
                        _proxNroRemito = _stkRemito.Resultset(0).nroremito
                    Else
                        _proxNroRemito = 1
                    End If

                    Dim _stkRemitoAdd = New DAL.Tables.STKREMITO(NewMov)
                    Dim newStkRemito As New Entities.Tables.STKREMITO

                    newStkRemito.CODEMP = _itemMovimiento.CODEMP
                    newStkRemito.CODEMPSTK = _itemMovimiento.CODEMP
                    newStkRemito.COMPROBANTE = _proxNroRemito
                    newStkRemito.COMPROBANTESTK = _proximoID
                    newStkRemito.FECHA = DateTime.Now.ToShortDateString()
                    newStkRemito.LETRA = "R"
                    newStkRemito.SUCURSAL = "0001"
                    'GENERO EL COMPROBANTE DEL REMITO
                    _stkRemitoAdd.Add(newStkRemito)


                End If


                NewMov.EndTransaction(True)
                'SI ES UN INGRESO DE STOCK COMUN.. DEVUELVO CERO
                Return _proxNroRemito

            Catch ex As Exception
                NewMov.EndTransaction(False)
                Return False
            End Try


        End Function
        Public Overloads Function IngresoStockDepositoPorOC(ByVal _itemsInventario As List(Of Entities.Tables.STKINVENTARIO), ByVal _itemMovimiento As Entities.Tables.STKMOVIMIENTO, ByVal _itemsMov As List(Of Entities.Tables.STKMOVIMIENTOITEM), ByVal NroOC As Integer, ByVal codEmpOC As String, ByVal remSucursal As String, ByVal remComprobante As Int32, ByVal _itemsVtos As List(Of Entities.Tables.STKVENCIMIENTO)) As Boolean
            'RECUPERO PROXIMO NRO DE COMPROBANTE
            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.MAXCOMPROBANTESTKMOVIMIENTO

            If _prox.Items(_itemMovimiento.CODEMP).Count > 0 Then
                _proximoID = _prox.Resultset(0).comprobante + 1


            Else
                _proximoID = 1
            End If
            'FIN PROXIMO NRO COMPROBANTE

            Dim NewMov As New DAL.Tables.STKMOVIMIENTO

            Try
                'EMPIEZO TRANSACCION
                NewMov.BeginTransaction()
                'COMPLETO EL OBJETO
                _itemMovimiento.COMPROBANTE = _proximoID
                '*** INSERTO EN TABLA STKMOVIMIENTOS ***
                NewMov.Add(_itemMovimiento)

                'AHORA INSERTO EN LOS ITEMS
                Dim newItemMov As New DAL.Tables.STKMOVIMIENTOITEM(NewMov)
                Dim newitemsMov As New Entities.Tables.STKMOVIMIENTOITEM

                'ITEMS DE LA TABLA STKMOVIOC
                Dim newItemMoviOC As New DAL.Tables.STKMOVIOC(NewMov)
                Dim newitemsMoviOC As New Entities.Tables.STKMOVIOC

                Dim i As Integer
                i = 1
                For Each _itemcuerpo As Entities.Tables.STKMOVIMIENTOITEM In _itemsMov
                    newitemsMov = New Entities.Tables.STKMOVIMIENTOITEM

                    newitemsMov.CODEMP = _itemcuerpo.CODEMP
                    newitemsMov.COMPROBANTE = _proximoID
                    newitemsMov.NROITEM = i
                    newitemsMov.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    newitemsMov.UNIMED = _itemcuerpo.UNIMED
                    newitemsMov.CANTIDAD = _itemcuerpo.CANTIDAD
                    newitemsMov.COSTOUNI = 0 'VER ESTO SI ESTA BIEN
                    'VOY GUARDANDO LOS ITEMS
                    newItemMov.Add(newitemsMov)

                    'AHORA GUARDO GENERANADO LA TABLA STKMOVIOC
                    newitemsMoviOC = New Entities.Tables.STKMOVIOC
                    newitemsMoviOC.CODEMP = codEmpOC 'CODEMP ORDEN DE COMPRA
                    newitemsMoviOC.ORDENCOMPRA_ID = NroOC 'NRO DE LA ORDEN DE COMPRA
                    newitemsMoviOC.CANTINGRESADA = _itemcuerpo.CANTIDAD 'CANTIDAD RECIBIDA
                    newitemsMoviOC.CANTORIGINAL = 0 'NO VOY A USAR ESTE VALOR......
                    newitemsMoviOC.NROITEM = _itemcuerpo.NROITEM ' NRO ITEM DE LA ORDEN DE COMPRA
                    newitemsMoviOC.CODEMPSTK = _itemcuerpo.CODEMP 'CODEMP DE LA TABLA STKMIMIENTOSITEM
                    newitemsMoviOC.COMPROBANTESTK = _proximoID 'NRO DE COMPROBANTE DE LA TABLA STKMOVIMIENTOITEM
                    newitemsMoviOC.NROITEMSTK = i 'NRO DE ITEM GENERADO EN LA TABLA STKMOVIMIENTOITEM
                    newitemsMoviOC.UNIMED = _itemcuerpo.UNIMED
                    newitemsMoviOC.RemSucursal = remSucursal 'SUCURSAL DEL REMITO DEL PROVEEEDOR
                    newitemsMoviOC.RemComprobante = remComprobante 'NRO DE REMITO DEL PROVEEDOR
                    newItemMoviOC.Add(newitemsMoviOC)

                    i = i + 1
                Next
                i = 1

                'AHORA INSERTO EN LOS ITEMS EN STKINVENTARIO, SI EL PRODUCTO EXISTE, ACTUALIZO EL STOCK SINO CREO EL PRODUCTO
                Dim newItemInv As New DAL.Tables.STKINVENTARIO(NewMov)
                Dim newitemsInv As New Entities.Tables.STKINVENTARIO

                Dim existeProd As New BLL.Tables.STKINVENTARIO

                For Each _itemcuerpo2 As Entities.Tables.STKINVENTARIO In _itemsInventario
                    newitemsInv = New Entities.Tables.STKINVENTARIO


                    newitemsInv.ARTICULO_ID = _itemcuerpo2.ARTICULO_ID
                    newitemsInv.DEPOSITO_ID = _itemcuerpo2.DEPOSITO_ID
                    newitemsInv.SECTOR_ID = _itemcuerpo2.SECTOR_ID 'NO SE UTILIZA EN EL STORED
                    newitemsInv.UNIMED = _itemcuerpo2.UNIMED
                    If _itemMovimiento.TIPOMOV_ID = 1 Then
                        newitemsInv.CANTIDAD = _itemcuerpo2.CANTIDAD
                    Else
                        newitemsInv.CANTIDAD = (_itemcuerpo2.CANTIDAD * -1) 'PORQUE ESTOY RESTANDO DEL STOCK
                    End If

                    'VERIFICO SI EXISTE ESTE PRODUCTO>

                    If existeProd.ItemList(_itemcuerpo2.ARTICULO_ID, _itemcuerpo2.DEPOSITO_ID).Count > 0 Then
                        newItemInv.Update(newitemsInv)

                    Else
                        'VOY GUARDANDO LOS ITEMS
                        newItemInv.Add(newitemsInv)
                    End If

                    i = i + 1
                    existeProd.WhereParameter.Clear()
                Next

                'VERIFICO SI TIENE ARTICULOS CON VTOS....
                If _itemsVtos.Count > 0 Then
                    Dim newItemVtos As New DAL.Tables.STKVENCIMIENTO(NewMov)
                    Dim _itemV As New Entities.Tables.STKVENCIMIENTO
                    For Each _vtos As Entities.Tables.STKVENCIMIENTO In _itemsVtos
                        _itemV = New Entities.Tables.STKVENCIMIENTO
                        _itemV.CODEMP = _itemMovimiento.CODEMP
                        _itemV.COMPROBANTE = _proximoID
                        _itemV.ARTICULO_ID = _vtos.ARTICULO_ID
                        _itemV.CANTIDAD = _vtos.CANTIDAD
                        _itemV.ENSTOCK = _vtos.CANTIDAD
                        _itemV.VTO = _vtos.VTO
                        'VOY GUARDANDO EN TABLA 
                        newItemVtos.Add(_itemV)
                    Next
                End If

                NewMov.EndTransaction(True)
                Return True

            Catch ex As Exception
                NewMov.EndTransaction(False)
                Return False
            End Try


        End Function

        Public Overloads Function RecepcionArticulos(ByVal _itemsEnTransito As List(Of Entities.Tables.STKENTRANSITO), ByVal _itemMovimiento As Entities.Tables.STKMOVIMIENTO, ByVal _itemsMov As List(Of Entities.Tables.STKMOVIMIENTOITEM)) As Boolean
            'RECUPERO PROXIMO NRO DE COMPROBANTE
            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.MAXCOMPROBANTESTKMOVIMIENTO

            If _prox.Items(_itemMovimiento.CODEMP).Count > 0 Then
                _proximoID = _prox.Resultset(0).comprobante + 1
            Else
                _proximoID = 1
            End If
            'FIN PROXIMO NRO COMPROBANTE

            Dim NewMov As New DAL.Tables.STKMOVIMIENTO

            Try
                'EMPIEZO TRANSACCION
                NewMov.BeginTransaction()
                'COMPLETO EL OBJETO
                _itemMovimiento.COMPROBANTE = _proximoID
                '*** INSERTO EN TABLA STKMOVIMIENTOS ***
                NewMov.Add(_itemMovimiento)

                'AHORA INSERTO EN LOS ITEMS
                Dim newItemMov As New DAL.Tables.STKMOVIMIENTOITEM(NewMov)
                Dim newitemsMov As New Entities.Tables.STKMOVIMIENTOITEM

                Dim i As Integer
                i = 1
                For Each _itemcuerpo As Entities.Tables.STKMOVIMIENTOITEM In _itemsMov
                    newitemsMov = New Entities.Tables.STKMOVIMIENTOITEM

                    newitemsMov.CODEMP = _itemcuerpo.CODEMP
                    newitemsMov.COMPROBANTE = _proximoID
                    newitemsMov.NROITEM = i
                    newitemsMov.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    newitemsMov.UNIMED = _itemcuerpo.UNIMED
                    newitemsMov.CANTIDAD = _itemcuerpo.CANTIDAD
                    newitemsMov.COSTOUNI = 0 'VER ESTO SI ESTA BIEN
                    'VOY GUARDANDO LOS ITEMS
                    newItemMov.Add(newitemsMov)


                    i = i + 1
                Next
                i = 1

                'AHORA HAGO UPDATE DE STK EN TRANSITO
                Dim newItemTra As New DAL.Tables.STKENTRANSITO(NewMov)
                Dim newitemsTra As New Entities.Tables.STKENTRANSITO

                Dim existeProd As New BLL.Tables.STKENTRANSITO

                For Each _itemcuerpo2 As Entities.Tables.STKENTRANSITO In _itemsEnTransito
                    newitemsTra = New Entities.Tables.STKENTRANSITO

                    newitemsTra.CODEMP = _itemcuerpo2.CODEMP
                    newitemsTra.COMPROBANTE = _itemcuerpo2.COMPROBANTE
                    newitemsTra.NROITEM = _itemcuerpo2.NROITEM
                    newitemsTra.FECHARECEPCION = _itemcuerpo2.FECHARECEPCION
                    newitemsTra.UNIMED = _itemcuerpo2.UNIMED
                    newitemsTra.USUARIOGENERA = _itemcuerpo2.USUARIOGENERA
                    newitemsTra.USUARIORECIBE = _itemcuerpo2.USUARIORECIBE
                    newitemsTra.ESTADO_ID = _itemcuerpo2.ESTADO_ID
                    newitemsTra.CANTRECIBIDA = _itemcuerpo2.CANTRECIBIDA
                    newitemsTra.CANTORIGINAL = _itemcuerpo2.CANTORIGINAL

                    newItemTra.Update(newitemsTra)

                Next


                'VUELVO A DAR EL ARTICULO DE BAJA COMO CONSUMIDO EN EL MOMENTO QUE RECIBE
                _itemMovimiento.COMPROBANTE = _proximoID + 1
                _itemMovimiento.TIPOMOV_ID = 2
                _itemMovimiento.SUBTIPOMOV_ID = 5 'SALIDA DE STOCK
                '*** INSERTO EN TABLA STKMOVIMIENTOS ***
                NewMov.Add(_itemMovimiento)

                i = 1
                For Each _itemcuerpo As Entities.Tables.STKMOVIMIENTOITEM In _itemsMov
                    newitemsMov = New Entities.Tables.STKMOVIMIENTOITEM

                    newitemsMov.CODEMP = _itemcuerpo.CODEMP
                    newitemsMov.COMPROBANTE = _proximoID + 1
                    newitemsMov.NROITEM = i
                    newitemsMov.ARTICULO_ID = _itemcuerpo.ARTICULO_ID
                    newitemsMov.UNIMED = _itemcuerpo.UNIMED
                    newitemsMov.CANTIDAD = _itemcuerpo.CANTIDAD
                    newitemsMov.COSTOUNI = 0 'VER ESTO SI ESTA BIEN
                    'VOY GUARDANDO LOS ITEMS
                    newItemMov.Add(newitemsMov)


                    i = i + 1
                Next
                i = 1

                NewMov.EndTransaction(True)
                Return True

            Catch ex As Exception
                NewMov.EndTransaction(False)
                Return False
            End Try


        End Function
    End Class

    Partial Public Class STKSECTOR
        'MODIFICADO PARA QUE SOLO ME TRAIGA LOS SECTORES DE ESE DEPOSITO, NO IMPORTA LA EMPRESA
        Inherits DAL.Tables.STKSECTOR
        Public Overloads Function ItemList(ByVal deposito_id As System.Int32) As List(Of Entities.Tables.STKSECTOR)
            Try
                MyBase.WhereParameter.Clear()
                MyBase.WhereParameter.Add(ColumnEnum.deposito_id, DAL.SqlEnums.OperandEnum.Equal, deposito_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

    End Class

    Partial Public Class STK_CONTROLLIBRERIA
        Inherits DAL.Tables.STK_CONTROLLIBRERIA
        Public Overloads Function ItemList() As List(Of Entities.Tables.STK_CONTROLLIBRERIA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal codemp As System.String, ByVal peridodo As System.String, ByVal anio As System.Int32) As List(Of Entities.Tables.STK_CONTROLLIBRERIA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, codemp)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.Peridodo, DAL.SqlEnums.OperandEnum.Equal, peridodo)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.Anio, DAL.SqlEnums.OperandEnum.Equal, anio)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.STK_CONTROLLIBRERIA) As Entities.Tables.STK_CONTROLLIBRERIA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal codemp As System.String, ByVal peridodo As System.String, ByVal anio As System.Int32, ByVal articulo_id As System.String, ByVal cant_recibida As System.Decimal, ByVal cant_solicitada As System.Decimal, ByVal usuario_id As System.Int32, ByVal fecha_cierre As System.DateTime) As Entities.Tables.STK_CONTROLLIBRERIA
            Try
                Dim NewItem As New Entities.Tables.STK_CONTROLLIBRERIA
                With NewItem
                    .CODEMP = codemp
                    .PERIDODO = peridodo
                    .ANIO = anio
                    .ARTICULO_ID = articulo_id
                    .CANT_RECIBIDA = cant_recibida
                    .CANT_SOLICITADA = cant_solicitada
                    .USUARIO_ID = usuario_id
                    .FECHA_CIERRE = fecha_cierre

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.STK_CONTROLLIBRERIA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal codemp As System.String, ByVal peridodo As System.String, ByVal anio As System.Int32, ByVal articulo_id As System.String, ByVal cant_recibida As System.Decimal, ByVal cant_solicitada As System.Decimal, ByVal usuario_id As System.Int32, ByVal fecha_cierre As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STK_CONTROLLIBRERIA
                With NewItem
                    .CODEMP = codemp
                    .PERIDODO = peridodo
                    .ANIO = anio
                    .ARTICULO_ID = articulo_id
                    .CANT_RECIBIDA = cant_recibida
                    .CANT_SOLICITADA = cant_solicitada
                    .USUARIO_ID = usuario_id
                    .FECHA_CIERRE = fecha_cierre

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.STK_CONTROLLIBRERIA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal codemp As System.String, ByVal peridodo As System.String, ByVal anio As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.STK_CONTROLLIBRERIA
                With NewItem
                    .CODEMP = codemp
                    .PERIDODO = peridodo
                    .ANIO = anio

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.STK_CONTROLLIBRERIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
End Namespace 'Tables

Namespace Procedures
    Partial Public Class _EXISTEHISTORIAL
        Inherits DAL.Procedures._EXISTEHISTORIAL
        Public Function ItemList(ByVal fecha As System.DateTime, ByVal codemp As System.String) As List(Of Entities.Procedures._EXISTEHISTORIAL)
            Return MyBase.Items(fecha, codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._EXISTEHISTORIAL)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class H_ACTUALIZAHISTORIALCOMPRAS
        Inherits DAL.Procedures.H_ACTUALIZAHISTORIALCOMPRAS
        Public Function ActualizaHistorial(ByVal anio As System.Int32, ByVal mes As System.Int32, ByVal codemp As System.String) As Object
            Return MyBase.Actualizar(anio, mes, codemp)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class H_GENERAHISTORIALIMPUTACIONCOMPRAS
        Inherits DAL.Procedures.H_GENERAHISTORIALIMPUTACIONCOMPRAS
        Public Function GenerarHistorial(ByVal fechadesde As System.DateTime, ByVal fechahasta As System.DateTime, ByVal porcdistrven As System.Double, ByVal Empresa As String) As Object
            Return MyBase.Generar(fechadesde, fechahasta, porcdistrven, Empresa)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _H_FACTURAS_PROVEED_DISPONIBLES
        Inherits DAL.Procedures._H_FACTURAS_PROVEED_DISPONIBLES
        Public Function ItemList(ByVal codproveed As System.String, ByVal fechadesde As System.DateTime, ByVal fechahasta As System.DateTime) As List(Of Entities.Procedures._H_FACTURAS_PROVEED_DISPONIBLES)
            Return MyBase.Items(codproveed, fechadesde, fechahasta)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._H_FACTURAS_PROVEED_DISPONIBLES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _H_INGRESAUNIDADESFACTURA
        Inherits DAL.Procedures._H_INGRESAUNIDADESFACTURA
        Public Function IngresarUnidades(ByVal fechaalta As System.DateTime, ByVal sccpro_cod As System.String, ByVal spctco_cod As System.String, ByVal spc_letra As System.String, ByVal spc_codpvt As System.String, ByVal spc_nro As System.String, ByVal sdcart_codgen As System.String, ByVal sdc_nreng As System.Int16, ByVal sdc_desc As System.String, ByVal sdcume_cod1 As System.String, ByVal sdc_cantum1 As System.Double, ByVal cantidad As System.Double, ByVal sdcstp_partida As System.String, ByVal fechamod As System.DateTime, ByVal art_codbarras As System.String) As Object
            Return MyBase.Items(fechaalta, sccpro_cod, spctco_cod, spc_letra, spc_codpvt, spc_nro, sdcart_codgen, sdc_nreng, sdc_desc, sdcume_cod1, sdc_cantum1, cantidad, sdcstp_partida, fechamod, art_codbarras)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _H_MODIFICAUNIDADES
        Inherits DAL.Procedures._H_MODIFICAUNIDADES
        Public Function ModificarUnidad(ByVal spctco_cod As System.String, ByVal spc_letra As System.String, ByVal spc_codpvt As System.String, ByVal spc_nro As System.String, ByVal sccpro_cod As System.String, ByVal sdc_nreng As System.Int16, ByVal cantidad As System.Double) As Object
            Return MyBase.Items(spctco_cod, spc_letra, spc_codpvt, spc_nro, sccpro_cod, sdc_nreng, cantidad)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _H_PROVEEDORES
        Inherits DAL.Procedures._H_PROVEEDORES
        Public Function ItemList(ByVal _codEmp As String) As List(Of Entities.Procedures._H_PROVEEDORES)
            Return MyBase.Items(_codEmp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._H_PROVEEDORES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _H_TRAEDETALLEFACTURA
        Inherits DAL.Procedures._H_TRAEDETALLEFACTURA
        Public Function ItemList(ByVal spctco_cod As System.String, ByVal spc_letra As System.String, ByVal spc_codpvt As System.String, ByVal spc_nro As System.String, ByVal sccpro_cod As System.String) As List(Of Entities.Procedures._H_TRAEDETALLEFACTURA)
            Return MyBase.Items(spctco_cod, spc_letra, spc_codpvt, spc_nro, sccpro_cod)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._H_TRAEDETALLEFACTURA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _H_TRAEDETALLEORDENDECOMPRA
        Inherits DAL.Procedures._H_TRAEDETALLEORDENDECOMPRA
        Public Function ItemList(ByVal sccemp_codigo As System.String, ByVal sccsuc_cod As System.String, ByVal scc_id As System.Int32) As List(Of Entities.Procedures._H_TRAEDETALLEORDENDECOMPRA)
            Return MyBase.Items(sccemp_codigo, sccsuc_cod, scc_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._H_TRAEDETALLEORDENDECOMPRA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _H_TRAEORDENESDECOMPRA
        Inherits DAL.Procedures._H_TRAEORDENESDECOMPRA
        Public Function ItemList(ByVal sccpro_cod As System.String) As List(Of Entities.Procedures._H_TRAEORDENESDECOMPRA)
            Return MyBase.Items(sccpro_cod)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._H_TRAEORDENESDECOMPRA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _H_ARTICULOS
        Inherits DAL.Procedures._H_ARTICULOS
        Public Function ItemList(ByVal _codEmp As String) As List(Of Entities.Procedures._H_ARTICULOS)
            Return MyBase.Items(_codEmp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._H_ARTICULOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _H_RUBROS
        Inherits DAL.Procedures._H_RUBROS
        Public Function ItemList(ByVal _condEmp) As List(Of Entities.Procedures._H_RUBROS)
            Return MyBase.Items(_condEmp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._H_RUBROS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _BUSCARPERFILESPERMISOS
        Inherits DAL.Procedures._BUSCARPERFILESPERMISOS
        Public Function ItemList(ByVal vsql As System.String) As List(Of Entities.Procedures._BUSCARPERFILESPERMISOS)
            Return MyBase.Items(vsql)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._BUSCARPERFILESPERMISOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _MENUES_HIJOS
        Inherits DAL.Procedures._MENUES_HIJOS
        Public Function ItemList(ByVal padre As System.Int32) As List(Of Entities.Procedures._MENUES_HIJOS)
            Return MyBase.Items(padre)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._MENUES_HIJOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _MENUES_PADRES
        Inherits DAL.Procedures._MENUES_PADRES
        Public Function ItemList() As List(Of Entities.Procedures._MENUES_PADRES)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._MENUES_PADRES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _MENUES_PADRES_E_HIJOS
        Inherits DAL.Procedures._MENUES_PADRES_E_HIJOS
        Public Function ItemList(ByVal padre As System.Int32, ByVal perfil As System.Int32) As List(Of Entities.Procedures._MENUES_PADRES_E_HIJOS)
            Return MyBase.Items(padre, perfil)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._MENUES_PADRES_E_HIJOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _OBTENERPERMISOS
        Inherits DAL.Procedures._OBTENERPERMISOS
        Public Function ItemList(ByVal perfil As System.Int32, ByVal idmenu As System.Int32) As List(Of Entities.Procedures._OBTENERPERMISOS)
            Return MyBase.Items(perfil, idmenu)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._OBTENERPERMISOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _OBTENERPERMISOS_PORMODULO
        Inherits DAL.Procedures._OBTENERPERMISOS_PORMODULO
        Public Function ItemList(ByVal perfil As System.Int32, ByVal idmenu As System.Int32) As List(Of Entities.Procedures._OBTENERPERMISOS_PORMODULO)
            Return MyBase.Items(perfil, idmenu)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._OBTENERPERMISOS_PORMODULO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _TBL_USUARIOS_UPDATE_SIN_CLAVE
        Inherits DAL.Procedures._TBL_USUARIOS_UPDATE_SIN_CLAVE
        Public Function UpdateUsuario(ByVal id_usuario As System.Int32, ByVal id_perfil As System.Int32, ByVal identificadorusuario As System.String, ByVal nombreusuario As System.String, ByVal inactivo As System.Boolean, ByVal sector_id As System.Int32, ByVal email As System.String, ByVal empresa As String) As Object
            Return MyBase.ActualizaSinClave(id_usuario, id_perfil, identificadorusuario, nombreusuario, inactivo, sector_id, email, empresa)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class _VALIDACREDENCIAL
        Inherits DAL.Procedures._VALIDACREDENCIAL
        Public Function ItemList(ByVal nombreusuario As System.String, ByVal contrasenia As System.String) As List(Of Entities.Procedures._VALIDACREDENCIAL)
            Return MyBase.Items(nombreusuario, contrasenia)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._VALIDACREDENCIAL)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ULTIMA_POSICION_MENU
        Inherits DAL.Procedures.ULTIMA_POSICION_MENU
        Public Function ItemList(ByVal menuapadre As System.Int32) As List(Of Entities.Procedures.ULTIMA_POSICION_MENU)
            Return MyBase.Items(menuapadre)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.ULTIMA_POSICION_MENU)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class FACTURASCONOPSINRETIRAR
        Inherits DAL.Procedures.FACTURASCONOPSINRETIRAR
        Public Function ItemList(ByVal codemp As System.String, ByVal codprov As System.String) As List(Of Entities.Procedures.FACTURASCONOPSINRETIRAR)
            Return MyBase.Items(codemp, codprov)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.FACTURASCONOPSINRETIRAR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAECOMPROBANTESPENDIENTESPROVEEDOR
        Inherits DAL.Procedures.TRAECOMPROBANTESPENDIENTESPROVEEDOR
        Public Function ItemList(ByVal codemp As System.String, ByVal codprov As System.String) As List(Of Entities.Procedures.TRAECOMPROBANTESPENDIENTESPROVEEDOR)
            Return MyBase.Items(codemp, codprov)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAECOMPROBANTESPENDIENTESPROVEEDOR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class PAGOSARETIRARPROVEEDORES
        Inherits DAL.Procedures.PAGOSARETIRARPROVEEDORES
        Public Function ItemList(ByVal _emp As String) As List(Of Entities.Procedures.PAGOSARETIRARPROVEEDORES)
            Return MyBase.Items(_emp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PAGOSARETIRARPROVEEDORES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class H_ARTICULOSDEPOSITO
        Inherits DAL.Procedures.H_ARTICULOSDEPOSITO
        Public Function ItemList() As List(Of Entities.Procedures.H_ARTICULOSDEPOSITO)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.H_ARTICULOSDEPOSITO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '


    Partial Public Class MERCADERIA_CARGADA
        Inherits DAL.Procedures.MERCADERIA_CARGADA
        Public Function ItemList(ByVal fecha As System.DateTime) As List(Of Entities.Procedures.MERCADERIA_CARGADA)
            Return MyBase.Items(fecha)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MERCADERIA_CARGADA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class REQUERIMIENTOS_DISPONIBLES
        Inherits DAL.Procedures.REQUERIMIENTOS_DISPONIBLES
        Public Function ItemList(ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.REQUERIMIENTOS_DISPONIBLES)
            Return MyBase.Items(nivelaut_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.REQUERIMIENTOS_DISPONIBLES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class UNIDADESDEMEDIDAS
        Inherits DAL.Procedures.UNIDADESDEMEDIDAS
        Public Function ItemList() As List(Of Entities.Procedures.UNIDADESDEMEDIDAS)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.UNIDADESDEMEDIDAS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class MAXCOMPROBANTESTKMOVIMIENTO
        Inherits DAL.Procedures.MAXCOMPROBANTESTKMOVIMIENTO
        Public Function ItemList(ByVal codemp As System.String) As List(Of Entities.Procedures.MAXCOMPROBANTESTKMOVIMIENTO)
            Return MyBase.Items(codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MAXCOMPROBANTESTKMOVIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class MAXCOMPROBANTEREQUERIMIENTO
        Inherits DAL.Procedures.MAXCOMPROBANTEREQUERIMIENTO
        Public Function ItemList(ByVal codemp As System.String) As List(Of Entities.Procedures.MAXCOMPROBANTEREQUERIMIENTO)
            Return MyBase.Items(codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MAXCOMPROBANTEREQUERIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class H_CONDPAGOPROVEED
        Inherits DAL.Procedures.H_CONDPAGOPROVEED
        Public Function ItemList(ByVal codemp As System.String, ByVal proveed As System.String) As List(Of Entities.Procedures.H_CONDPAGOPROVEED)
            Return MyBase.Items(codemp, proveed)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.H_CONDPAGOPROVEED)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEREQUERIMIENTOITEM
        Inherits DAL.Procedures.TRAEREQUERIMIENTOITEM
        Public Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEM)
            Return MyBase.Items(codemp, requerimiento_id, nivelaut_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEM)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class CIERRESTOCKMENSUAL
        Inherits DAL.Procedures.CIERRESTOCKMENSUAL
        Public Function ItemList(ByVal anio As System.Int32, ByVal mes As System.Int32) As Object
            Return MyBase.Items(anio, mes)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class MAXCOMPROBANTEOCDIRECTA
        Inherits DAL.Procedures.MAXCOMPROBANTEOCDIRECTA
        Public Function ItemList(ByVal codemp As System.String) As List(Of Entities.Procedures.MAXCOMPROBANTEOCDIRECTA)
            Return MyBase.Items(codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MAXCOMPROBANTEOCDIRECTA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class INFORMEREQUERIMIENTOS
        Inherits DAL.Procedures.INFORMEREQUERIMIENTOS
        Public Function ItemList(ByVal fechadesde As System.DateTime, ByVal fechahasta As System.DateTime, ByVal tipo As System.String) As List(Of Entities.Procedures.INFORMEREQUERIMIENTOS)
            Return MyBase.Items(fechadesde, fechahasta, tipo)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.INFORMEREQUERIMIENTOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ORDENCOMPRA_DISPONIBLES
        Inherits DAL.Procedures.ORDENCOMPRA_DISPONIBLES
        Public Function ItemList() As List(Of Entities.Procedures.ORDENCOMPRA_DISPONIBLES)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.ORDENCOMPRA_DISPONIBLES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEORDENCOMPRAITEM
        Inherits DAL.Procedures.TRAEORDENCOMPRAITEM
        Public Function ItemList(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.TRAEORDENCOMPRAITEM)
            Return MyBase.Items(codemp, ordencompra_id, nivelaut_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEORDENCOMPRAITEM)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ACTUALIZA_USUARIO_AUTORIZA
        Inherits DAL.Procedures.ACTUALIZA_USUARIO_AUTORIZA
        Public Function ItemList(ByVal tipo As System.String, ByVal codemp As System.String, ByVal nrocomprobante As System.Int32, ByVal usuario As System.String, pedidoDiario As Boolean) As Object
            Return MyBase.Items(tipo, codemp, nrocomprobante, usuario, pedidoDiario)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class REQUERIMIENTOS_PARAORDENDECOMPRA
        Inherits DAL.Procedures.REQUERIMIENTOS_PARAORDENDECOMPRA
        Public Function ItemList(ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.REQUERIMIENTOS_PARAORDENDECOMPRA)
            Return MyBase.Items(nivelaut_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.REQUERIMIENTOS_PARAORDENDECOMPRA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEREQUERIMIENTOITEMVARIOS
        Inherits DAL.Procedures.TRAEREQUERIMIENTOITEMVARIOS
        Public Function ItemList(ByVal codemp As System.String, ByVal requerimiento As System.String, ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEMVARIOS)
            Return MyBase.Items(codemp, requerimiento, nivelaut_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEMVARIOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ORDENCOMPRA_DISPONIBLES_PROVEEDOR
        Inherits DAL.Procedures.ORDENCOMPRA_DISPONIBLES_PROVEEDOR
        Public Function ItemList(ByVal proveed As System.String, ByVal codEmp As String) As List(Of Entities.Procedures.ORDENCOMPRA_DISPONIBLES_PROVEEDOR)
            Return MyBase.Items(proveed, codEmp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.ORDENCOMPRA_DISPONIBLES_PROVEEDOR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEORDENCOMPRAITEM_PENDIENTE_DE_ENTREGAR
        Inherits DAL.Procedures.TRAEORDENCOMPRAITEM_PENDIENTE_DE_ENTREGAR
        Public Function ItemList(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.TRAEORDENCOMPRAITEM_PENDIENTE_DE_ENTREGAR)
            Return MyBase.Items(codemp, ordencompra_id, nivelaut_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEORDENCOMPRAITEM_PENDIENTE_DE_ENTREGAR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class RECUPERAPROVEEDOREMPRESA
        Inherits DAL.Procedures.RECUPERAPROVEEDOREMPRESA
        Public Function ItemList(ByVal codemp As System.String, ByVal cuit As System.String) As List(Of Entities.Procedures.RECUPERAPROVEEDOREMPRESA)
            Return MyBase.Items(codemp, cuit)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.RECUPERAPROVEEDOREMPRESA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ORDENCOMPRA_PENDIENTES_DE_ENTREGA
        Inherits DAL.Procedures.ORDENCOMPRA_PENDIENTES_DE_ENTREGA
        Public Function ItemList(ByVal fechadesde As System.DateTime, ByVal fechahasta As System.DateTime) As List(Of Entities.Procedures.ORDENCOMPRA_PENDIENTES_DE_ENTREGA)
            Return MyBase.Items(fechadesde, fechahasta)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.ORDENCOMPRA_PENDIENTES_DE_ENTREGA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    'Partial Public Class TRAEREQUERIMIENTOITEMSDETALLE
    '    Inherits DAL.Procedures.TRAEREQUERIMIENTOITEMSDETALLE
    '    Public Function ItemList(ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEMSDETALLE)
    '        Return MyBase.Items(nivelaut_id)
    '    End Function
    '    Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEMSDETALLE)
    '        Get
    '            Return MyBase.Resultset
    '        End Get
    '    End Property

    'End Class '

    Partial Public Class TRAEREQUERIMIENTOITEMSDETALLE
        Inherits DAL.Procedures.TRAEREQUERIMIENTOITEMSDETALLE
        Public Function ItemList(ByVal codemp As System.String, ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEMSDETALLE)
            Return MyBase.Items(codemp, nivelaut_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEMSDETALLE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    'Partial Public Class IMPORTA_TXT_BIONEXO
    '    Inherits DAL.Procedures.IMPORTA_TXT_BIONEXO
    '    Public Function ItemList(ByVal registros As System.String, ByVal separadorfilas As System.String, ByVal filainicio As System.Int32, ByVal filafin As System.Int32, ByVal codemp As System.String, ByVal usuario As System.String) As Object
    '        Return MyBase.Items(registros, separadorfilas, filainicio, filafin, codemp, usuario)
    '    End Function
    '    Public ReadOnly Property Result() As Object
    '        Get
    '            Return MyBase.Resultset
    '        End Get
    '    End Property

    'End Class '
    Partial Public Class IMPORTA_TXT_BIONEXO
        Inherits DAL.Procedures.IMPORTA_TXT_BIONEXO
        Public Function ItemList(ByVal registros As System.String, ByVal separadorfilas As System.String, ByVal filainicio As System.Int32, ByVal filafin As System.Int32, ByVal codemp As System.String, ByVal usuario As System.String) As List(Of Entities.Procedures.IMPORTA_TXT_BIONEXO)
            Return MyBase.Items(registros, separadorfilas, filainicio, filafin, codemp, usuario)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.IMPORTA_TXT_BIONEXO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ARTICULOCOTIZADO
        Inherits DAL.Procedures.ARTICULOCOTIZADO
        Public Function ItemList(ByVal articulo_id As System.String, ByVal codemp As System.String) As List(Of Entities.Procedures.ARTICULOCOTIZADO)
            Return MyBase.Items(articulo_id, codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.ARTICULOCOTIZADO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class CANTIDADITEMPOREMPRESA
        Inherits DAL.Procedures.CANTIDADITEMPOREMPRESA
        Public Function ItemList(ByVal nivel_id As System.Int32, ByVal articulo_id As System.String) As List(Of Entities.Procedures.CANTIDADITEMPOREMPRESA)
            Return MyBase.Items(nivel_id, articulo_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.CANTIDADITEMPOREMPRESA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class INGRESACOTIZACIONARTICULOEMPRESA
        Inherits DAL.Procedures.INGRESACOTIZACIONARTICULOEMPRESA
        Public Function ItemList(ByVal codemp As System.String, ByVal nrocotizacion As System.Int32, ByVal proveed As System.String, ByVal articulo_id As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal precio As System.Decimal, ByVal fecha As System.DateTime, ByVal usuario As System.String, ByVal embalaje As System.String, ByVal marca As System.String) As Object
            Return MyBase.Items(codemp, nrocotizacion, proveed, articulo_id, unimed, cantidad, precio, fecha, usuario, embalaje, marca)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '


    Partial Public Class RUBROARTICULOS
        Inherits DAL.Procedures.RUBROARTICULOS
        Public Function ItemList() As List(Of Entities.Procedures.RUBROARTICULOS)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.RUBROARTICULOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ELIMINACOTIZACION
        Inherits DAL.Procedures.ELIMINACOTIZACION
        Public Function EliminaCotizacion(ByVal codemp As System.String, ByVal articulo_id As System.String, ByVal proveed As System.String) As Object
            Return MyBase.EliminaItems(codemp, articulo_id, proveed)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ACTUALIZARUBROUSUARIOS
        Inherits DAL.Procedures.ACTUALIZARUBROUSUARIOS
        Public Function ItemList(ByVal tipo As System.String, ByVal id_usuario As System.Int32, ByVal codrubro As System.String) As Object
            Return MyBase.Items(tipo, id_usuario, codrubro)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '


    Partial Public Class RUBROUSUARIOS
        Inherits DAL.Procedures.RUBROUSUARIOS
        Public Function ItemList(ByVal id_usuario As System.Int32) As List(Of Entities.Procedures.RUBROUSUARIOS)
            Return MyBase.Items(id_usuario)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.RUBROUSUARIOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEFACTURASRECIBIDAS
        Inherits DAL.Procedures.TRAEFACTURASRECIBIDAS
        Public Function ItemList(ByVal codemp As System.String, ByVal fechadesde As System.DateTime, ByVal fechahasta As System.DateTime) As List(Of Entities.Procedures.TRAEFACTURASRECIBIDAS)
            Return MyBase.Items(codemp, fechadesde, fechahasta)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEFACTURASRECIBIDAS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEREQUERIMIENTOITEMSCOTIZADOS
        Inherits DAL.Procedures.TRAEREQUERIMIENTOITEMSCOTIZADOS
        Public Function ItemList(ByVal codemp As System.String, ByVal subrubro As System.String) As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEMSCOTIZADOS)
            Return MyBase.Items(codemp, subrubro)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEMSCOTIZADOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class AUTORIZACOTIZACION
        Inherits DAL.Procedures.AUTORIZACOTIZACION
        Public Function ItemList(ByVal codemp As System.String, ByVal nrocotizacion As System.Int32, ByVal proveed As System.String, ByVal articulo As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal precio As System.Decimal, ByVal fecha As System.DateTime, ByVal usuario As System.String, ByVal embalaje As System.String, ByVal marca As System.String, ByVal autorizado As System.Int32, ByVal finalizado As System.Int32) As Object
            Return MyBase.Items(codemp, nrocotizacion, proveed, articulo, unimed, cantidad, precio, fecha, usuario, embalaje, marca, autorizado, finalizado)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class ''

    Partial Public Class TRAEARTICULOSCOTIZADOSPARAORDENDECOMPRA
        Inherits DAL.Procedures.TRAEARTICULOSCOTIZADOSPARAORDENDECOMPRA
        Public Function ItemList(ByVal codemp As System.String, ByVal proveed_id As System.String, ByVal nrocotizacion As System.Int32) As List(Of Entities.Procedures.TRAEARTICULOSCOTIZADOSPARAORDENDECOMPRA)
            Return MyBase.Items(codemp, proveed_id, nrocotizacion)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEARTICULOSCOTIZADOSPARAORDENDECOMPRA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEPROVEEDORESCOTIZADOS
        Inherits DAL.Procedures.TRAEPROVEEDORESCOTIZADOS
        Public Function ItemList(ByVal codemp As System.String) As List(Of Entities.Procedures.TRAEPROVEEDORESCOTIZADOS)
            Return MyBase.Items(codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEPROVEEDORESCOTIZADOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class SUBRUBROUSUARIOS
        Inherits DAL.Procedures.SUBRUBROUSUARIOS
        Public Function ItemList(ByVal id_usuario As System.Int32) As List(Of Entities.Procedures.SUBRUBROUSUARIOS)
            Return MyBase.Items(id_usuario)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.SUBRUBROUSUARIOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ELIMINASUBRUBROSUSUARIO
        Inherits DAL.Procedures.ELIMINASUBRUBROSUSUARIO
        Public Function ItemList(ByVal id_usuario As System.Int32) As Object
            Return MyBase.Items(id_usuario)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAESUBRUBROSDELUSUARIO
        Inherits DAL.Procedures.TRAESUBRUBROSDELUSUARIO
        Public Function ItemList(ByVal id_usuario As System.Int32) As List(Of Entities.Procedures.TRAESUBRUBROSDELUSUARIO)
            Return MyBase.Items(id_usuario)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAESUBRUBROSDELUSUARIO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

        Public Shared Widening Operator CType(v As TRAESUBRUBROSDELUSUARIO) As TRAESUBRUBROSEMPRESA
            Throw New NotImplementedException()
        End Operator
    End Class '

    Partial Public Class TRAEREQUERIMIENTOSPARAGENERARCOTIZACION
        Inherits DAL.Procedures.TRAEREQUERIMIENTOSPARAGENERARCOTIZACION
        Public Function ItemList(ByVal subrubro As System.String, ByVal codemp As System.String) As List(Of Entities.Procedures.TRAEREQUERIMIENTOSPARAGENERARCOTIZACION)
            Return MyBase.Items(subrubro, codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEREQUERIMIENTOSPARAGENERARCOTIZACION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class H_ARICULOSMARCA
        Inherits DAL.Procedures.H_ARTICULOSMARCA
        Public Function ItemList(ByVal empresa As System.String) As List(Of Entities.Procedures.H_ARTICULOSMARCA)
            Return MyBase.Items(empresa)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.H_ARTICULOSMARCA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class INGRESAPEDIDOCOTIZACIONARTICULOEMPRESA
        Inherits DAL.Procedures.INGRESAPEDIDOCOTIZACIONARTICULOEMPRESA
        Public Function ItemList(ByVal codemp As System.String, ByVal nrocotizacion As System.Int32, ByVal articulo_id As System.String, ByVal unimed As System.String, ByVal cantidad As System.Decimal, ByVal precio As System.Decimal, ByVal proveed As System.String, ByVal fecha As System.DateTime, ByVal usuario As System.String, ByVal obs As System.String) As Object
            Return MyBase.Items(codemp, nrocotizacion, articulo_id, unimed, cantidad, precio, proveed, fecha, usuario, obs)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class MAXNROCOTIZACION
        Inherits DAL.Procedures.MAXNROCOTIZACION
        Public Function ItemList() As List(Of Entities.Procedures.MAXNROCOTIZACION)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MAXNROCOTIZACION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class REQUERIMIENTOS_COTIZADOS_PROVEEDOR
        Inherits DAL.Procedures.REQUERIMIENTOS_COTIZADOS_PROVEEDOR
        Public Function ItemList(ByVal articulo_id As System.String, ByVal codemp As System.String) As List(Of Entities.Procedures.REQUERIMIENTOS_COTIZADOS_PROVEEDOR)
            Return MyBase.Items(articulo_id, codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.REQUERIMIENTOS_COTIZADOS_PROVEEDOR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    'Partial Public Class ARTICULOSENVIADOSACOTIZAR
    '    Inherits DAL.Procedures.ARTICULOSENVIADOSACOTIZAR
    '    Public Function ItemList(ByVal codemp As System.String) As List(Of Entities.Procedures.ARTICULOSENVIADOSACOTIZAR)
    '        Return MyBase.Items(codemp)
    '    End Function
    '    Public ReadOnly Property Result() As List(Of Entities.Procedures.ARTICULOSENVIADOSACOTIZAR)
    '        Get
    '            Return MyBase.Resultset
    '        End Get
    '    End Property

    'End Class '

    Partial Public Class TRAESUBRUBROSEMPRESA
        Inherits DAL.Procedures.TRAESUBRUBROSEMPRESA
        Public Function ItemList(ByVal codemp As System.String) As List(Of Entities.Procedures.TRAESUBRUBROSEMPRESA)
            Return MyBase.Items(codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAESUBRUBROSEMPRESA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STKMAXIMOIDPLANTILLA
        Inherits DAL.Procedures.STKMAXIMOIDPLANTILLA
        Public Function ItemList() As List(Of Entities.Procedures.STKMAXIMOIDPLANTILLA)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.STKMAXIMOIDPLANTILLA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class

    Partial Public Class FACTURASCARGADASPROVEEDOR
        Inherits DAL.Procedures.FACTURASCARGADASPROVEEDOR
        Public Function ItemList(ByVal codemp As System.String, ByVal codprov As System.String, ByVal fechadesde As System.DateTime, ByVal fechahasta As System.DateTime) As List(Of Entities.Procedures.FACTURASCARGADASPROVEEDOR)
            Return MyBase.Items(codemp, codprov, fechadesde, fechahasta)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.FACTURASCARGADASPROVEEDOR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COTIZACIONESPENDIENTESDEINGRESAR
        Inherits DAL.Procedures.COTIZACIONESPENDIENTESDEINGRESAR
        Public Function ItemList(ByVal codemp As System.String) As List(Of Entities.Procedures.COTIZACIONESPENDIENTESDEINGRESAR)
            Return MyBase.Items(codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.COTIZACIONESPENDIENTESDEINGRESAR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ARTICULOSSEGUNCOTIZACION
        Inherits DAL.Procedures.ARTICULOSSEGUNCOTIZACION
        Public Function ItemList(ByVal nrocotizacion As System.Int32, ByVal codemp As System.String) As List(Of Entities.Procedures.ARTICULOSSEGUNCOTIZACION)
            Return MyBase.Items(nrocotizacion, codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.ARTICULOSSEGUNCOTIZACION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class INSERTAREQUERIMIENTOORDENCOMPRA
        Inherits DAL.Procedures.INSERTAREQUERIMIENTOORDENCOMPRA
        Public Function Insertar(ByVal codemp As System.String, ByVal nrocotizacion As System.Int32, ByVal ordencompra_id As System.Int32, ByVal nroitemoc As System.Int32, ByVal articulo_id As System.String, ByVal proveed_id As System.String) As Object
            Return MyBase.Add(codemp, nrocotizacion, ordencompra_id, nroitemoc, articulo_id, proveed_id)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class SUBRUBROARTICULOS
        Inherits DAL.Procedures.SUBRUBROARTICULOS
        Public Function ItemList(ByVal codemp As System.String) As List(Of Entities.Procedures.SUBRUBROARTICULOS)
            Return MyBase.Items(codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.SUBRUBROARTICULOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class PROXIMONROSOLICITUD
        Inherits DAL.Procedures.PROXIMONROSOLICITUD
        Public Function ItemList() As List(Of Entities.Procedures.PROXIMONROSOLICITUD)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PROXIMONROSOLICITUD)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TRAEOBRASSOCIALESDATATECH
        Inherits DAL.Procedures.TRAEOBRASSOCIALESDATATECH
        Public Function ItemList() As List(Of Entities.Procedures.TRAEOBRASSOCIALESDATATECH)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEOBRASSOCIALESDATATECH)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ACTULIZAARTICULOSPROVISORIOS
        Inherits DAL.Procedures.ACTULIZAARTICULOSPROVISORIOS
        Public Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nroitem As System.Int32, ByVal articulo As System.String) As Object
            Return MyBase.Items(codemp, requerimiento_id, nroitem, articulo)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class PEDIENTEENTREGAARTICULO
        Inherits DAL.Procedures.PEDIENTEENTREGAARTICULO
        Public Function ItemList(ByVal codemp As System.String, ByVal articulo_id As System.String) As List(Of Entities.Procedures.PEDIENTEENTREGAARTICULO)
            Return MyBase.Items(codemp, articulo_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PEDIENTEENTREGAARTICULO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class PROVEEDORESXSUBRUBRO
        Inherits DAL.Procedures.PROVEEDORESXSUBRUBRO
        Public Function ItemList(ByVal codemp As System.String, ByVal subrubro As System.String) As List(Of Entities.Procedures.PROVEEDORESXSUBRUBRO)
            Return MyBase.Items(codemp, subrubro)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PROVEEDORESXSUBRUBRO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class EQUIVALENCIAARTICULOPROVEED
        Inherits DAL.Procedures.EQUIVALENCIAARTICULOPROVEED
        Public Function ItemList(ByVal articulo_id As System.String, ByVal proveed_id As System.String) As List(Of Entities.Procedures.EQUIVALENCIAARTICULOPROVEED)
            Return MyBase.Items(articulo_id, proveed_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.EQUIVALENCIAARTICULOPROVEED)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    'Partial Public Class ACTUALIZA_OBS_OC
    '    Inherits DAL.Procedures.ACTUALIZA_OBS_OC
    '    Public Function ItemList(ByVal codemp As System.String, ByVal nro As System.Int32, ByVal obs As System.String, ByVal proveed As System.Int32, ByVal pedidodiario As Boolean, ByVal sectorentrega As Int16) As Object
    '        Return MyBase.Items(codemp, nro, obs, proveed, pedidodiario, sectorentrega)
    '    End Function
    '    Public ReadOnly Property Result() As Object
    '        Get
    '            Return MyBase.Resultset
    '        End Get
    '    End Property

    'End Class '
    Partial Public Class ACTUALIZA_OBS_OC
        Inherits DAL.Procedures.ACTUALIZA_OBS_OC
        Public Function ItemList(ByVal codemp As System.String, ByVal nro As System.Int32, ByVal obs As System.String, ByVal proveed As System.String, ByVal pedidodiario As System.Boolean, ByVal sectorentrega As System.Int32, ByVal tipoprorrateo As System.Int32) As Object
            Return MyBase.Items(codemp, nro, obs, proveed, pedidodiario, sectorentrega, tipoprorrateo)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ELIMINASECTORAUTORIZAUSUARIO
        Inherits DAL.Procedures.ELIMINASECTORAUTORIZAUSUARIO
        Public Function ItemList(ByVal id_usuario As System.Int32) As Object
            Return MyBase.Items(id_usuario)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    ''' <summary>
    ''' Nombre de la Clase   : SECTORESAUTORIZAUSUARIO
    ''' Descripcion  : 
    ''' Fecha de creación: lunes, 9 de mayo de 2016
    ''' </summary>
    ''' <remarks></remarks>
    Partial Public Class SECTORESAUTORIZAUSUARIO
        Inherits DAL.Procedures.SECTORESAUTORIZAUSUARIO
        Public Function ItemList(ByVal id_usuario As System.Int32) As List(Of Entities.Procedures.SECTORESAUTORIZAUSUARIO)
            Return MyBase.Items(id_usuario)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.SECTORESAUTORIZAUSUARIO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COMUSUARIOAUTORIZAREQUERIMIENTOS_ADD
        Inherits DAL.Procedures.COMUSUARIOAUTORIZAREQUERIMIENTOS_ADD
        Public Function ItemList(ByVal id_usuario As System.Int32, ByVal sectorrequerimiento As System.Int32) As Object
            Return MyBase.Items(id_usuario, sectorrequerimiento)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ACTUALIZA_OBS_REQ
        Inherits DAL.Procedures.ACTUALIZA_OBS_REQ
        Public Function ItemList(ByVal codemp As System.String, ByVal nro As System.Int32, ByVal obs As System.String, ByVal entrega_id As Int32) As Object
            Return MyBase.Items(codemp, nro, obs, entrega_id)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class FINALIZA_ANULA_OC
        Inherits DAL.Procedures.FINALIZA_ANULA_OC
        Public Function ItemList(ByVal tipo As System.String, ByVal codemp As System.String, ByVal nrooc As System.Int32, ByVal motivo As System.String) As Object
            Return MyBase.Items(tipo, codemp, nrooc, motivo)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class MODIFICAITEMOCAUTORIZADA
        Inherits DAL.Procedures.MODIFICAITEMOCAUTORIZADA
        Public Function ItemList(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nroitem As System.Int32, ByVal cantidad As System.Decimal, ByVal cantoriginal As System.Decimal, ByVal precio As System.Decimal, ByVal preciooriginal As System.Decimal, ByVal embalaje As System.String, ByVal marca As System.String) As Object
            Return MyBase.Items(codemp, ordencompra_id, nroitem, cantidad, cantoriginal, precio, preciooriginal, embalaje, marca)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '


    Partial Public Class ORDENCOMPRA_PARA_MODIFICAR
        Inherits DAL.Procedures.ORDENCOMPRA_PARA_MODIFICAR
        Public Function ItemList(ByVal tipo As System.Int32) As List(Of Entities.Procedures.ORDENCOMPRA_PARA_MODIFICAR)
            Return MyBase.Items(tipo)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.ORDENCOMPRA_PARA_MODIFICAR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    'Partial Public Class REQUERIMIENTOS_PARA_MODIFICAR
    '    Inherits DAL.Procedures.REQUERIMIENTOS_PARA_MODIFICAR
    '    Public Function ItemList() As List(Of Entities.Procedures.REQUERIMIENTOS_PARA_MODIFICAR)
    '        Return MyBase.Items()
    '    End Function
    '    Public ReadOnly Property Result() As List(Of Entities.Procedures.REQUERIMIENTOS_PARA_MODIFICAR)
    '        Get
    '            Return MyBase.Resultset
    '        End Get
    '    End Property

    'End Class '

    Partial Public Class REQUERIMIENTOS_PARA_MODIFICAR
        Inherits DAL.Procedures.REQUERIMIENTOS_PARA_MODIFICAR
        Public Function ItemList(ByVal sector As System.Int32, ByVal idUsuario As Integer) As List(Of Entities.Procedures.REQUERIMIENTOS_PARA_MODIFICAR)
            Return MyBase.Items(sector, idUsuario)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.REQUERIMIENTOS_PARA_MODIFICAR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class

    Partial Public Class ANULA_REQUERIMIENTO
        Inherits DAL.Procedures.ANULA_REQUERIMIENTO
        Public Function AnulaRequerimiento(ByVal codemp As System.String, ByVal nrorequerimiento As System.Int32, ByVal motivo As System.String) As Object
            Return MyBase.Items(codemp, nrorequerimiento, motivo)
        End Function

        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ORDENCOMPRA_PARA_ANULAR
        Inherits DAL.Procedures.ORDENCOMPRA_PARA_ANULAR
        Public Function ItemList() As List(Of Entities.Procedures.ORDENCOMPRA_PARA_ANULAR)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.ORDENCOMPRA_PARA_ANULAR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ANULA_OC
        Inherits DAL.Procedures.ANULA_OC
        Public Function AnulaOrdenDeCompra(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal fechaanulacion As System.DateTime, ByVal motivo As System.String) As Object
            Return MyBase.Items(codemp, ordencompra_id, fechaanulacion, motivo)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class COM_CUENTAS_USUARIO
        Inherits DAL.Procedures.COM_CUENTAS_USUARIO
        Public Function ItemList(ByVal id_usuario As System.Int32) As List(Of Entities.Procedures.COM_CUENTAS_USUARIO)
            Return MyBase.Items(id_usuario)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.COM_CUENTAS_USUARIO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class USUARIO_CON_CUENTAS
        Inherits DAL.Procedures.USUARIO_CON_CUENTAS
        Public Function ItemList() As List(Of Entities.Procedures.USUARIO_CON_CUENTAS)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.USUARIO_CON_CUENTAS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ACTUALIZACUENTASCONTABLECOMPRAS_ARTICULOS
        Inherits DAL.Procedures.ACTUALIZACUENTASCONTABLECOMPRAS_ARTICULOS
        Public Function ItemList(ByVal articulo As System.String, ByVal cuenta As System.String) As Object
            Return MyBase.Items(articulo, cuenta)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class PLAN_DE_CUENTA
        Inherits DAL.Procedures.PLAN_DE_CUENTA
        Public Function ItemList() As List(Of Entities.Procedures.PLAN_DE_CUENTA)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PLAN_DE_CUENTA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEMARCAARTICULOS
        Inherits DAL.Procedures.TRAEMARCAARTICULOS
        Public Function ItemList(ByVal codemp As System.String) As List(Of Entities.Procedures.TRAEMARCAARTICULOS)
            Return MyBase.Items(codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEMARCAARTICULOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class GENERAPRORRATEOEMPRESA
        Inherits DAL.Procedures.GENERAPRORRATEOEMPRESA
        Public Function ItemList(ByVal fechacontdesde As System.DateTime, ByVal fechaconthasta As System.DateTime, ByVal porcdistrven As System.Double) As Object
            Return MyBase.Items(fechacontdesde, fechaconthasta, porcdistrven)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class GENERAPRORRATEOEMPRESA_RSC
        Inherits DAL.Procedures.GENERAPRORRATEOEMPRESA_RSC
        Public Function ItemList(ByVal fechacontdesde As System.DateTime, ByVal fechaconthasta As System.DateTime) As Object
            Return MyBase.Items(fechacontdesde, fechaconthasta)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ORDENCOMPRA_PARA_MODIFICAR_FECHA
        Inherits DAL.Procedures.ORDENCOMPRA_PARA_MODIFICAR_FECHA
        Public Function ItemList(ByVal fechadesde As System.DateTime, ByVal fechahasta As System.DateTime) As List(Of Entities.Procedures.ORDENCOMPRA_PARA_MODIFICAR_FECHA)
            Return MyBase.Items(fechadesde, fechahasta)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.ORDENCOMPRA_PARA_MODIFICAR_FECHA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class EXCLUYEITEMSOC
        Inherits DAL.Procedures.EXCLUYEITEMSOC
        Public Function ExcluyeItem(ByVal item As List(Of Entities.Tables.COMORDENCOMPRAITEM)) As Object
            For Each _item As Entities.Tables.COMORDENCOMPRAITEM In item
                MyBase.Excluir(_item.CODEMP, _item.ORDENCOMPRA_ID, _item.NROITEM, _item.MOTIVOEXCLUSION, _item.USUARIOEXCLUYE, _item.EXCLUIDO)

            Next

        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAELUGARESENTREGA
        Inherits DAL.Procedures.TRAELUGARESENTREGA
        Public Function ItemList(ByVal codemp As System.String) As List(Of Entities.Procedures.TRAELUGARESENTREGA)
            Return MyBase.Items(codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAELUGARESENTREGA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ENVIAMAILARTICULOSPROVISORIOS
        Inherits DAL.Procedures.ENVIAMAILARTICULOSPROVISORIOS
        Public Function ItemList() As Object
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class REQUERIMIENTOS_PARA_FINALIZAR
        Inherits DAL.Procedures.REQUERIMIENTOS_PARA_FINALIZAR
        Public Function ItemList(ByVal sector As System.Int32, ByVal idUsuario As Integer) As List(Of Entities.Procedures.REQUERIMIENTOS_PARA_FINALIZAR)
            Return MyBase.Items(sector, idUsuario)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.REQUERIMIENTOS_PARA_FINALIZAR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class

    Partial Public Class REQUERIMIENTOITEM_SINOC
        Inherits DAL.Procedures.REQUERIMIENTOITEM_SINOC
        Public Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.REQUERIMIENTOITEM_SINOC)
            Return MyBase.Items(codemp, requerimiento_id, nivelaut_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.REQUERIMIENTOITEM_SINOC)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class PROXIMONROREMITO
        Inherits DAL.Procedures.PROXIMONROREMITO
        Public Function ItemList() As List(Of Entities.Procedures.PROXIMONROREMITO)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PROXIMONROREMITO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEDETALLEREMITOSPENDIENTES
        Inherits DAL.Procedures.TRAEDETALLEREMITOSPENDIENTES
        Public Function ItemList(ByVal codemp As System.String, ByVal comprobante As System.Int32) As List(Of Entities.Procedures.TRAEDETALLEREMITOSPENDIENTES)
            Return MyBase.Items(codemp, comprobante)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEDETALLEREMITOSPENDIENTES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    ''' <summary>
    ''' Nombre de la Clase   : TRAEREMITOSPENDIENTES
    ''' Descripcion  : 
    ''' Fecha de creación: lunes, 31 de octubre de 2016
    ''' </summary>
    ''' <remarks></remarks>
    Partial Public Class TRAEREMITOSPENDIENTES
        Inherits DAL.Procedures.TRAEREMITOSPENDIENTES
        Public Function ItemList(ByVal fechadesde As System.DateTime, ByVal fechahasta As System.DateTime, ByVal sector As Integer, ByVal deposito As System.Int32) As List(Of Entities.Procedures.TRAEREMITOSPENDIENTES)
            Return MyBase.Items(fechadesde, fechahasta, sector, deposito)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEREMITOSPENDIENTES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEREQUERIMIENTOSLIBRERIA
        Inherits DAL.Procedures.TRAEREQUERIMIENTOSLIBRERIA
        Public Function ItemList(ByVal fechadesde As System.DateTime, ByVal fechahasta As System.DateTime) As List(Of Entities.Procedures.TRAEREQUERIMIENTOSLIBRERIA)
            Return MyBase.Items(fechadesde, fechahasta)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEREQUERIMIENTOSLIBRERIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ENVIAMAILARTICULOSCONDIFERENCIASSTK
        Inherits DAL.Procedures.ENVIAMAILARTICULOSCONDIFERENCIASSTK
        Public Function ItemList(ByVal codemp As System.String, ByVal comprobante As System.Int32) As Object
            Return MyBase.Items(codemp, comprobante)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAE_REMITOS_PARA_IMPRESION
        Inherits DAL.Procedures.TRAE_REMITOS_PARA_IMPRESION
        Public Function ItemList(ByVal fechadesde As System.DateTime, ByVal fechahasta As System.DateTime, ByVal sector As Int32, ByVal deposito As System.Int32) As List(Of Entities.Procedures.TRAE_REMITOS_PARA_IMPRESION)
            Return MyBase.Items(fechadesde, fechahasta, sector, deposito)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAE_REMITOS_PARA_IMPRESION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class GENERAHISTORIALSALDOPROVEEDOR
        Inherits DAL.Procedures.GENERAHISTORIALSALDOPROVEEDOR
        Public Function ItemList(ByVal codemp As System.String, ByVal anio As System.Int32, ByVal mes As System.Int32) As Object
            Return MyBase.Items(codemp, anio, mes)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class GENERANUEVOREQUERIMIENTO
        Inherits DAL.Procedures.GENERANUEVOREQUERIMIENTO
        Public Function ItemList(ByVal codemp As System.String, ByVal nrooc As System.Int32, ByVal tipo As String) As Object
            Return MyBase.Items(codemp, nrooc, tipo)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class REPOSICIONPORCONSUMO
        Inherits DAL.Procedures.REPOSICIONPORCONSUMO
        Public Function ItemList(ByVal codemp As System.String, ByVal filtro As System.String, ByVal rubro As System.String, ByVal subrubro As System.String, ByVal fechadesde As System.DateTime, ByVal fechahasta As System.DateTime) As List(Of Entities.Procedures.REPOSICIONPORCONSUMO)
            Return MyBase.Items(codemp, filtro, rubro, subrubro, fechadesde, fechahasta)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.REPOSICIONPORCONSUMO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class EVENTOSUSUARIO
        Inherits DAL.Procedures.EVENTOSUSUARIO
        Public Function ItemList(ByVal usuarioid As System.Int32) As List(Of Entities.Procedures.EVENTOSUSUARIO)
            Return MyBase.Items(usuarioid)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.EVENTOSUSUARIO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class REQUERIMIENTOS_PARA_EXCLUIR_ARTICULOS
        Inherits DAL.Procedures.REQUERIMIENTOS_PARA_EXCLUIR_ARTICULOS
        Public Function ItemList(ByVal sector As System.Int32, ByVal idusuario As System.Int32, ByVal codemp As System.String) As List(Of Entities.Procedures.REQUERIMIENTOS_PARA_EXCLUIR_ARTICULOS)
            Return MyBase.Items(sector, idusuario, codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.REQUERIMIENTOS_PARA_EXCLUIR_ARTICULOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEREQUERIMIENTOITEMPARAEXCLUIR
        Inherits DAL.Procedures.TRAEREQUERIMIENTOITEMPARAEXCLUIR
        Public Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32) As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEMPARAEXCLUIR)
            Return MyBase.Items(codemp, requerimiento_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEMPARAEXCLUIR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class EXCLUYEITEMSREQ
        Inherits DAL.Procedures.EXCLUYEITEMSREQ
        Public Function ExcluyeItem(ByVal item As List(Of Entities.Tables.COMREQUERIMIENTOITEM)) As Object
            For Each _item As Entities.Tables.COMREQUERIMIENTOITEM In item
                MyBase.Items(_item.CODEMP, _item.REQUERIMIENTO_ID, _item.NROITEM, _item.MOTIVOEXCLUSION, _item.USUARIOEXCLUYE, _item.EXCLUIDO)

            Next

        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class STOCK_A_FECHA_POREMPRESA
        Inherits DAL.Procedures.STOCK_A_FECHA_POREMPRESA
        Public Function ItemList(ByVal deposito As System.String, ByVal filtro As System.String, ByVal rubro As System.String, ByVal subrubro As System.String, ByVal articulo As System.String) As List(Of Entities.Procedures.STOCK_A_FECHA_POREMPRESA)
            Return MyBase.Items(deposito, filtro, rubro, subrubro, articulo)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.STOCK_A_FECHA_POREMPRESA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAESOLICITUDES
        Inherits DAL.Procedures.TRAESOLICITUDES
        Public Function ItemList(ByVal codemp As System.String, ByVal fechadesde As System.DateTime, ByVal fechahasta As System.DateTime) As List(Of Entities.Procedures.TRAESOLICITUDES)
            Return MyBase.Items(codemp, fechadesde, fechahasta)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAESOLICITUDES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAECUENTASPORARTICULO
        Inherits DAL.Procedures.TRAECUENTASPORARTICULO
        Public Function ItemList(ByVal codemp As System.String) As List(Of Entities.Procedures.TRAECUENTASPORARTICULO)
            Return MyBase.Items(codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAECUENTASPORARTICULO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    ''' <summary>
    ''' Nombre de la Clase   : UPDATECUENTASPORARTICULO
    ''' Descripcion  : 
    ''' Fecha de creación: viernes, 28 de abril de 2017
    ''' </summary>
    ''' <remarks></remarks>
    Partial Public Class UPDATECUENTASPORARTICULO
        Inherits DAL.Procedures.UPDATECUENTASPORARTICULO
        Public Function ItemList(ByVal codemp As System.String, ByVal codart As System.String, ByVal ctacosto As System.String, ByVal ctacompras As System.String, ByVal ctaventas As System.String, ByVal ctainventario As System.String) As Object
            Return MyBase.Items(codemp, codart, ctacosto, ctacompras, ctaventas, ctainventario)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAECONCEPTOCTACONTABLE
        Inherits DAL.Procedures.TRAECONCEPTOCTACONTABLE
        Public Function ItemList() As List(Of Entities.Procedures.TRAECONCEPTOCTACONTABLE)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAECONCEPTOCTACONTABLE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    ''' <summary>
    ''' Nombre de la Clase   : USR_ACTULIZASUBCUENTACONCEPTO
    ''' Descripcion  : 
    ''' Fecha de creación: martes, 2 de mayo de 2017
    ''' </summary>
    ''' <remarks></remarks>
    Partial Public Class USR_ACTULIZASUBCUENTACONCEPTO
        Inherits DAL.Procedures.USR_ACTULIZASUBCUENTACONCEPTO
        Public Function ItemList(ByVal nro_cta As System.Int32, ByVal descripcion As System.String, ByVal esdeproducto As System.Boolean, ByVal concepto As System.String) As Object
            Return MyBase.Items(nro_cta, descripcion, esdeproducto, concepto)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ELIMINAPRORRATEO
        Inherits DAL.Procedures.ELIMINAPRORRATEO
        Public Function ItemList(ByVal codemp As System.String, ByVal scc_id As System.Int32, ByVal sccsuc_cod As System.String, ByVal sccemp_codigo As System.String) As Object
            Return MyBase.Items(codemp, scc_id, sccsuc_cod, sccemp_codigo)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    ''' <summary>
    ''' Nombre de la Clase   : USR_TRAEFACTURASPRORRATEADAS
    ''' Descripcion  : 
    ''' Fecha de creación: miércoles, 6 de septiembre de 2017
    ''' </summary>
    ''' <remarks></remarks>
    Partial Public Class USR_TRAEFACTURASPRORRATEADAS
        Inherits DAL.Procedures.USR_TRAEFACTURASPRORRATEADAS
        Public Function ItemList(ByVal femisiondesde As System.DateTime, ByVal femisionhasta As System.DateTime) As List(Of Entities.Procedures.USR_TRAEFACTURASPRORRATEADAS)
            Return MyBase.Items(femisiondesde, femisionhasta)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.USR_TRAEFACTURASPRORRATEADAS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class ORDENCOMPRA_DISPONIBLES_SINSTOCK
        Inherits DAL.Procedures.ORDENCOMPRA_DISPONIBLES_SINSTOCK
        Public Function ItemList() As List(Of Entities.Procedures.ORDENCOMPRA_DISPONIBLES_SINSTOCK)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.ORDENCOMPRA_DISPONIBLES_SINSTOCK)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    ''' <summary>
    ''' Nombre de la Clase   : TRAEORDENCOMPRADETALLE
    ''' Descripcion  : 
    ''' Fecha de creación: lunes, 11 de septiembre de 2017
    ''' </summary>
    ''' <remarks></remarks>
    Partial Public Class TRAEORDENCOMPRADETALLE
        Inherits DAL.Procedures.TRAEORDENCOMPRADETALLE
        Public Function ItemList(ByVal codemp As System.String, ByVal ordencompra_id As System.Int32, ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.TRAEORDENCOMPRADETALLE)
            Return MyBase.Items(codemp, ordencompra_id, nivelaut_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEORDENCOMPRADETALLE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class REQUERIMIENTOS_INERNO_DISPONIBLES
        Inherits DAL.Procedures.REQUERIMIENTOS_INERNO_DISPONIBLES
        Public Function ItemList(ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.REQUERIMIENTOS_INERNO_DISPONIBLES)
            Return MyBase.Items(nivelaut_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.REQUERIMIENTOS_INERNO_DISPONIBLES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEREQUERIMIENTOINTERNOITEM
        Inherits DAL.Procedures.TRAEREQUERIMIENTOINTERNOITEM
        Public Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.TRAEREQUERIMIENTOINTERNOITEM)
            Return MyBase.Items(codemp, requerimiento_id, nivelaut_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEREQUERIMIENTOINTERNOITEM)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class MAXCOMPROBANTEREQUERIMIENTOINTERNO
        Inherits DAL.Procedures.MAXCOMPROBANTEREQUERIMIENTOINTERNO
        Public Function ItemList(ByVal codemp As System.String) As List(Of Entities.Procedures.MAXCOMPROBANTEREQUERIMIENTOINTERNO)
            Return MyBase.Items(codemp)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MAXCOMPROBANTEREQUERIMIENTOINTERNO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class REQUERIMIENTO_INTERNO_PENDIENTE_ENTREGAR
        Inherits DAL.Procedures.REQUERIMIENTO_INTERNO_PENDIENTE_ENTREGAR
        Public Function ItemList(ByVal codemp As System.String, ByVal deposito_id As System.Int32, ByVal sector_id As System.Int32) As List(Of Entities.Procedures.REQUERIMIENTO_INTERNO_PENDIENTE_ENTREGAR)
            Return MyBase.Items(codemp, deposito_id, sector_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.REQUERIMIENTO_INTERNO_PENDIENTE_ENTREGAR)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEREQUERIMIENTOITEM_PENDIENTE_DE_ENVIO
        Inherits DAL.Procedures.TRAEREQUERIMIENTOITEM_PENDIENTE_DE_ENVIO
        Public Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32, ByVal nivelaut_id As System.Int32) As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEM_PENDIENTE_DE_ENVIO)
            Return MyBase.Items(codemp, requerimiento_id, nivelaut_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEM_PENDIENTE_DE_ENVIO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class TRAEREQUERIMIENTOITEMPARAEXCLUIR_INTERNO
        Inherits DAL.Procedures.TRAEREQUERIMIENTOITEMPARAEXCLUIR_INTERNO
        Public Function ItemList(ByVal codemp As System.String, ByVal requerimiento_id As System.Int32) As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEMPARAEXCLUIR_INTERNO)
            Return MyBase.Items(codemp, requerimiento_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEREQUERIMIENTOITEMPARAEXCLUIR_INTERNO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
End Namespace 'Procedures



Namespace Views
    ' - Classes derivadas de Vistas - 

End Namespace 'Views
