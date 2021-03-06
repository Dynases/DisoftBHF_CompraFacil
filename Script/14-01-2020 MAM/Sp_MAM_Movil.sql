USE [BDDistBHF_CF]
GO
/****** Object:  StoredProcedure [dbo].[sp_go_TC004_appMovil]    Script Date: 14/01/2020 06:41:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 /*this.oanumi = oanumi;
            this.oafdoc = oafdoc;
            this.oahora = oahora;
            this.oaccli = oaccli;
            this.cliente = cliente;
            this.oarepa = oarepa;
            this.oaest = oaest;
            this.oaobs = oaobs;
            this.latitud = latitud;
            this.longitud = longitud;
            this.total = total;
            this.tipocobro = tipocobro;
            this.estado = estado;
            this.codigogenerado = codigogenerad*/
ALTER PROCEDURE [dbo].[sp_go_TC004_appMovil](@tipo int, @code_id int=-1, @full_name nvarchar(50)='', @business_name nvarchar(200)='',
											  @nit nvarchar(20)='', @mail nvarchar(255)='', @phone nvarchar(50)='',
											  @cell_phone nvarchar(50)='', @address nvarchar(200)='', @reference nvarchar(200)='',
											  @location_lat decimal(18,14)=0, @location_log decimal(18,14)=0, @password_cli nvarchar(255)='',
											  @old_password_cli nvarchar(255)='',@new_password_cli nvarchar(255)='',@observacion nvarchar(200)='',
											  @categoria nvarchar(20)='',@pedido int=-1,@TO0011 xml=null,@json nvarchar(250)='',
											  @fingreso date=null,@credito decimal(18,2)=0,@chofer int=-1,@fechapedido date=null,@idRepartidor int=-1,
											  @oanumi nvarchar(60)='',@oafdoc date=null,@oahora nvarchar(10)='',@oaccli int=-1,
											  @oarepa int=-1,@oaest int=-1,@oaobs nvarchar(200)='',@latitud decimal(18,14)=0,@longitud decimal(18,14)=0,
											  @total decimal(18,2)=0,@tipocobro int=-1,@codigogenerado nvarchar(50)='',@cczona int=-1)
AS
BEGIN
	DECLARE @newHora nvarchar(5)
	
		declare @ofnumi int 
	set @newHora=CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE()))
	
	DECLARE @newFecha date
	set @newFecha=GETDATE()
	set @fechapedido=GETDATE ()  ----AQUIII
	IF @tipo=-1 --ELIMINAR REGISTRO
	BEGIN
		BEGIN TRY 
			--Eliminar TC004B
			delete from TC004B where ccbnumi=@code_id

			DELETE FROM TC0041 WHERE chnumi=@code_id
			DELETE FROM TC004 WHERE ccnumi=@code_id
			SELECT @code_id AS newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), -1, @newFecha, @newHora, 'CLIMOVIL')
		END CATCH
	END

	IF @tipo=1 --NUEVO REGISTRO
	BEGIN
		BEGIN TRAN INSERTAR
		BEGIN TRY 
			set @code_id=IIF((select COUNT(ccnumi) from TC004)= 0, 0, (select MAX(ccnumi) from TC004))+1

			if(not exists(select a.* from TC004 as a where a.ccemail=@mail))
			begin
			INSERT INTO TC004 (ccnumi, cccod, ccdesc, cczona, ccdct, ccdctnum, ccdirec, cctelf1, cctelf2, cccat, ccest, cclat, cclongi,
							   ccprconsu, cceven, ccobs, ccfnac, ccnomfac, ccnit, ccultped, ccfecing, ccultvent, ccrecven, ccsupven,
							   ccpreven, ccemail, ccref, ccpass, ccfact, cchact, ccuact) 
				   VALUES (@code_id, '0', UPPER(LTRIM(RTRIM(@full_name))), '4', 1, 0, UPPER(LTRIM(RTRIM(@address))), 
						   LTRIM(RTRIM(@phone)), LTRIM(RTRIM(@cell_phone)), 2, 1, @location_lat, @location_log, 
						   -1, 1, '', '2000/01/01', UPPER(LTRIM(RTRIM(@business_name))), LTRIM(RTRIM(@nit)), DATEADD(day, -1, 
						   @newFecha), @newFecha, '2000/01/01', 1, 5, 3, @mail, UPPER(LTRIM(RTRIM(@reference))), @password_cli,
						   @newFecha, @newHora, 'CLIMOVIL') 
			-- Insertar TC004B
			insert into TC004B values(@code_id, '4', 1)

			-- DEVUELVO VALORES DE CONFIRMACION
			--SELECT @code_id AS newNumi
			
			select a.ccnumi as code_id, a.ccdesc as full_name, a.ccnomfac as business_name, a.ccnit as nit, 
				   a.ccemail as mail, a.cctelf1 as phone, a.cctelf2 as cell_phone, a.ccdirec as [address], 
				   a.ccref as reference, a.cclat as location_lat, a.cclongi as location_log, 
				   a.ccpass as password_cli, a.ccpass as password_cli_copy
			from TC004 a
			where a.ccnumi=@code_id

			
		

			
			end
			else
				begin
				select * from TC004 as a where a.ccnumi =-1
			end
		
			

			COMMIT TRAN INSERTAR
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 1, @newFecha, @newHora, 'CLIMOVIL')

			ROLLBACK TRAN INSERTAR
		END CATCH
	END
		IF @tipo=111 --NUEVO REGISTRO
	BEGIN
		BEGIN TRAN INSERTAR
		BEGIN TRY 
			set @code_id=IIF((select COUNT(ccnumi) from TC004)= 0, 0, (select MAX(ccnumi) from TC004))+1

			if(not exists(select a.* from TC004 as a where a.ccobs =@observacion ))
			begin
			INSERT INTO TC004 (ccnumi, cccod, ccdesc, cczona, ccdct, ccdctnum, ccdirec, cctelf1, cctelf2, cccat, ccest, cclat, cclongi,
							   ccprconsu, cceven, ccobs, ccfnac, ccnomfac, ccnit, ccultped, ccfecing, ccultvent, ccrecven, ccsupven,
							   ccpreven, ccemail, ccref, ccpass, ccfact, cchact, ccuact) 
				   VALUES (@code_id, '0', UPPER(LTRIM(RTRIM(@full_name))), @cczona , 1, 0, UPPER(LTRIM(RTRIM(@address))), 
						   LTRIM(RTRIM(@phone)), LTRIM(RTRIM(@cell_phone)), 2, 1, @location_lat, @location_log, 
						   -1, 1,@observacion , '2000/01/01', UPPER(LTRIM(RTRIM(@business_name))), LTRIM(RTRIM(@nit)), DATEADD(day, -1, 
						   @newFecha), @newFecha, '2000/01/01', 1, 3, 2, @mail, UPPER(LTRIM(RTRIM(@reference))), @password_cli,
						   @newFecha, @newHora, 'CLIMOVIL') 
			-- Insertar TC004B
			insert into TC004B values(@code_id, @cczona, 1)

			-- DEVUELVO VALORES DE CONFIRMACION
			--SELECT @code_id AS newNumi
			
			select a.ccnumi as code_id, a.ccdesc as full_name, a.ccnomfac as business_name, a.ccnit as nit, 
				   a.ccemail as mail, a.cctelf1 as phone, a.cctelf2 as cell_phone, a.ccdirec as [address], 
				   a.ccref as reference, a.cclat as location_lat, a.cclongi as location_log, 
				   a.ccpass as password_cli, a.ccpass as password_cli_copy
			from TC004 a
			where a.ccnumi=@code_id

			
		

			
			end
			else
				begin
				select * from TC004 as a where a.ccnumi =-1
			end
		
			

			COMMIT TRAN INSERTAR
		END TRY
		BEGIN CATCH
		--select ERROR_MESSAGE()
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 1, @newFecha, @newHora, 'CLIMOVIL')

			ROLLBACK TRAN INSERTAR
		END CATCH
	END
		IF @tipo=112 --NUEVO REGISTRO CLIENTE
	BEGIN
		BEGIN TRAN INSERTAR
		BEGIN TRY 
			set @code_id=IIF((select COUNT(ccnumi) from TC004)= 0, 0, (select MAX(ccnumi) from TC004))+1

			if(not exists(select a.* from TC004 as a where a.ccobs =@observacion ))
			begin
			declare @idzona int 
			set @idzona=(select top 1 zona.lcnumi from  TL0012 as zona where  zona.lccbnumi=@idRepartidor order by zona.lcnumi desc )
			INSERT INTO TC004 (ccnumi, cccod, ccdesc, cczona, ccdct, ccdctnum, ccdirec, cctelf1, cctelf2, cccat, ccest, cclat, cclongi,
							   ccprconsu, cceven, ccobs, ccfnac, ccnomfac, ccnit, ccultped, ccfecing, ccultvent, ccrecven, ccsupven,
							   ccpreven, ccemail, ccref, ccpass, ccfact, cchact, ccuact) 
				   VALUES (@code_id, '0', UPPER(LTRIM(RTRIM(@full_name))), @idzona , 1, 0, UPPER(LTRIM(RTRIM(@address))), 
						   LTRIM(RTRIM(@phone)), LTRIM(RTRIM(@cell_phone)), 2, 1, @location_lat, @location_log, 
						   -1, 1,@observacion , '2000/01/01', UPPER(LTRIM(RTRIM(@business_name))), LTRIM(RTRIM(@nit)), DATEADD(day, -1, 
						   @newFecha), @newFecha, '2000/01/01', 1, 3, 2, @mail, UPPER(LTRIM(RTRIM(@reference))), @password_cli,
						   @newFecha, @newHora, 'CLIMOVIL') 
			-- Insertar TC004B
			insert into TC004B values(@code_id, @idzona, 1)

			-- DEVUELVO VALORES DE CONFIRMACION
			--SELECT @code_id AS newNumi
			
			select a.ccnumi as code_id, a.ccdesc as full_name, a.ccnomfac as business_name, a.ccnit as nit, 
				   a.ccemail as mail, a.cctelf1 as phone, a.cctelf2 as cell_phone, a.ccdirec as [address], 
				   a.ccref as reference, a.cclat as location_lat, a.cclongi as location_log, 
				   a.ccpass as password_cli, a.ccpass as password_cli_copy
			from TC004 a
			where a.ccnumi=@code_id

			
		

			
			end
			else
				begin

				select a.ccnumi as code_id, a.ccdesc as full_name, a.ccnomfac as business_name, a.ccnit as nit, 
				   a.ccemail as mail, a.cctelf1 as phone, a.cctelf2 as cell_phone, a.ccdirec as [address], 
				   a.ccref as reference, a.cclat as location_lat, a.cclongi as location_log, 
				   a.ccpass as password_cli, a.ccpass as password_cli_copy
			from TC004 a
			where a.ccobs =@observacion
				
			end
		
			

			COMMIT TRAN INSERTAR
		END TRY
		BEGIN CATCH
		--select ERROR_MESSAGE()
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 1, @newFecha, @newHora, 'CLIMOVIL')

			ROLLBACK TRAN INSERTAR
		END CATCH
	END
	IF @tipo=2--MODIFICACION
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

			UPDATE TC004 SET ccdesc=@full_name, ccnomfac=@business_name, ccnit=@nit, ccemail=@mail, cctelf1=@phone,
							 cctelf2=@cell_phone, ccdirec=@address, ccref=@reference, cclat=@location_lat, cclongi=@location_log,
							 ccpass=@password_cli,
							 ccfact=@newFecha, cchact=@newHora, ccuact='CLIMOVIL'
					 Where ccnumi = @code_id

			--DEVUELVO VALORES DE CONFIRMACION
			select @code_id as newNumi
			COMMIT TRAN
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN
		END CATCH
	END

	IF @tipo=3 --OBTENER UN CLIENTE
	BEGIN
		BEGIN TRY
			select  a.ccdesc as full_name, a.ccnomfac as business_name, a.ccnit as nit, 
				   a.ccemail as mail, a.cctelf1 as phone, a.cctelf2 as cell_phone, a.ccdirec as [address], 
				   a.ccref as reference, a.cclat as location_lat, a.cclongi as location_log
			from TC004 a
			where a.ccnumi=@code_id
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 3, @newFecha, @newHora, 'CLIMOVIL')
		END CATCH
	END

	IF @tipo=4--MODIFICACION - RECUPERACIÓN DE CONTRASEÑA
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

			UPDATE TC004 SET ccpass=@password_cli,
							 ccfact=@newFecha, cchact=@newHora, ccuact='CLIMOVIL'
					 Where ccnumi = @code_id

			--DEVUELVO VALORES DE CONFIRMACION
			--select @code_id as newNumi

			select a.ccnumi as code_id, a.ccemail as mail, a.ccpass as password_cli
			from TC004 a
			where a.ccnumi=@code_id

			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END

	
	IF @tipo=5--Verifico Si Existe Email y Password
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

					--DEVUELVO VALORES DE CONFIRMACION
			--select @code_id as newNumi

			select top 1 a.ccnumi as code_id, a.ccemail as mail, a.ccpass as password_cli
			from TC004 a
			where a.ccemail =@mail  and a.ccpass =@password_cli  

			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END
		IF @tipo=6--Verifico Si Existe Email y Password
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 
			if( exists(select a.* from TC004 as a where a.ccemail=@mail))
			begin
			declare @numi int
			set @numi =(select top 1 a.ccnumi  from TC004 as a where a.ccemail =@mail )
			update TC004  set TC004.ccpass =@password_cli where 
			TC004.ccnumi =@numi 


				select top 1 a.ccnumi as code_id, a.ccemail as mail, a.ccpass as password_cli
			from TC004 a
			where a.ccnumi =@numi 
			end
			else
			begin
				select * from TC004 as a where a.ccnumi =-1
			end
		

					--DEVUELVO VALORES DE CONFIRMACION
			--select @code_id as newNumi

		

			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END
	
		IF @tipo=7--OBTENER CATEGORIAS DE PRODUCTOS
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 
		if(exists(select  * from TC005C where caest=1))

		begin
		select a.canumi  as codigo,a.canombre  as nombre,Concat('http://190.180.84.22:8000/Disoft_Doc/Imagenes/Imagenes Categoria/', a.caimg COLLATE Modern_Spanish_CI_AS ,'.jpg') as foto
			,a.cadesc as descripcion
from TC005C  as a 	where a.caest=1

		end

		else
		begin
		select 0
		end
			

			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END
		IF @tipo=8--
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 
		select p.canumi as codigo,p.cadesc as nombre,p.cadesc2 as descripcion,
		IIF(p.caimg =null or p.caimg='','',Concat('http://190.180.84.22:8000/Disoft_Doc/Imagenes/Producto/', p.caimg COLLATE Modern_Spanish_CI_AS))  as 
		foto,precio.chprecio  as precio   from TC001 as p ,TC003 as precio where p.caest >0
and precio .chcprod =p.canumi and precio .chcatcl =1
and p.cacat =@categoria and precio.chprecio>0
	

			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END



			IF @tipo=9--INSERTAR PEDIDO NUEVO
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

		set @oanumi=IIF((select COUNT(oanumi) from TO001)=0,0,(select MAX(oanumi) from TO001))+1
		
		declare @oazona int
		set @oazona=IIF(exists(select TC004.cczona from TC004 where TC004.ccnumi=@code_id),(select TC004.cczona from TC004 where TC004.ccnumi=@code_id),0)
		
		INSERT INTO TO001 VALUES(@oanumi,@newFecha ,CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE())),@code_id
		,4,4,'','',1,1,0,GETDATE(),CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE())),'MOVIL')	
		---- INSERTO EL DETALLE

		INSERT INTO TO0011(obnumi,obcprod,obpcant,obpbase,obptot)
		SELECT distinct @oanumi,'codigo_producto'=x.v.value('codigo_producto[1]','int'),
						'cantidad'=x.v.value('cantidad[1]','numeric(18,2)'),
						precio.chprecio as precio,(precio .chprecio *x.v.value('cantidad[1]','numeric(18,2)'))as total
		FROM @TO0011.nodes('/row/row')x(v)
		,TC003 as precio,TC004 as cliente
		where cliente.ccnumi =@code_id and  precio.chcprod =x.v.value('codigo_producto[1]','int')
		and precio .chcatcl =cliente.cccat 

		declare @numiPrevendedor int 
		set @numiPrevendedor =(select a.cbnumi  from TC002 as a where a.cbnumi =(select Max(b.cbnumi )  from TC002 as b))
		insert into TO001A values(@oanumi,9 ,1,0)
		-- DEVUELVO VALORES DE CONFIRMACION
		SELECT TO001.oanumi  ,cliente.ccdesc ,cliente.ccemail  from TO001,TC004 as cliente where oanumi=@oanumi
		and cliente.ccnumi =@code_id 

			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END


		IF @tipo=10
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 
	select pedido.oanumi as cod_pedido,(FORMAT (pedido.oafdoc , 'dd-MM-yyyy') + ' ' + pedido.oahora ) as fecha ,
	 IIF(pedido.oaap=2,4,pedido.oaest)  as estado ,Sum(detalle.obptot )as total 
from TO001 as pedido inner join TO0011 as detalle 
on pedido.oanumi=detalle .obnumi  and pedido.oaccli =@code_id -----Numi del cliente
group by pedido.oanumi ,pedido .oafdoc ,pedido.oaest ,pedido.oahora ,pedido.oaap
order by pedido .oanumi desc


			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END
		IF @tipo=11
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 
select detalle .obcprod as codigo_producto,producto .cadesc as producto,detalle.obpbase as precio_unitario,
detalle.obpcant as cantidad,detalle .obptot as subtotal
from TO001 as pedido inner join TO0011 as detalle 
on pedido.oanumi=detalle .obnumi  and pedido.oaccli =@code_id -----Numi del cliente
inner join TC001 as producto on producto .canumi =detalle .obcprod 
where pedido .oanumi =@pedido  ----Numi del pedido
group by pedido.oanumi ,pedido .oafdoc ,pedido.oaest ,detalle .obpcant ,detalle .obpbase  ,detalle .obptot ,detalle.obcprod ,
producto .cadesc 
order by pedido .oanumi desc


			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END

		IF @tipo=12--ANULAR PEDIDO
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

		update TO001 set TO001.oaap=2 where TO001.oanumi =@pedido and TO001.oaccli =@code_id 
		
		set @ofnumi =IIF((select COUNT(ofnumi) from TO0014)=0,0,(select MAX(ofnumi) from TO0014))+1
		insert into TO0014  values(@ofnumi,@pedido,1,'Cancelacion de pedido de la app',3,2,@newfecha,@newhora,'CLIMOVIL')
		
		select * from TO001 where TO001.oanumi =@pedido and TO001.oaap =2
			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END




	IF @tipo=14 --NUEVO REGISTRO
	BEGIN
		BEGIN TRAN INSERTAR
		BEGIN TRY 
			Update TC004 set ccdesc = UPPER(LTRIM(RTRIM(@full_name))) ,ccnomfac = UPPER(LTRIM(RTRIM(@business_name))) ,ccnit =@nit ,cctelf1 =@phone ,cctelf2 =@cell_phone ,
	ccdirec =UPPER(LTRIM(RTRIM(@address))) ,ccref =UPPER(LTRIM(RTRIM(@reference))) ,cclat =@location_lat ,cclongi =@location_log 
	where TC004.ccnumi =@code_id 

	select * from TC004 where TC004.ccnumi=@code_id 
			

			COMMIT TRAN INSERTAR
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 1, @newFecha, @newHora, 'CLIMOVIL')

			ROLLBACK TRAN INSERTAR
		END CATCH
	END

	
	IF @tipo=15 
	BEGIN
		BEGIN TRAN INSERTAR
		BEGIN TRY 
		if(exists(select *   from TC004 where ccnumi=@code_id and ccpass=@old_password_cli))
		begin
			Update TC004 set ccpass =@new_password_cli where TC004.ccnumi =@code_id
			

	select * from TC004 where TC004.ccnumi=@code_id 

		end			

			COMMIT TRAN INSERTAR
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 1, @newFecha, @newHora, 'CLIMOVIL')

			ROLLBACK TRAN INSERTAR
		END CATCH
	END


			IF @tipo=16--
	BEGIN

		BEGIN TRAN MODIFICACION
		BEGIN TRY 
			if( (select top 1 a.ccprecapp from TC0001 as a )=1)
			begin
				select  a.canumi as id, a.cadesc as name,ISNULL(d.chprecio, 0) as price
				,Cast(IIF((select top 1 ccstock  from TC0001)=1,isnull((select top 1 isnull(co.Cant,0)  from  Vr_Conciliacion as co where co.Prod=a.canumi
				and co.Chofer =@chofer and co.Fecha =getdate()),0),-1) as decimal(18,2)) as cant
			from TC001 a left join TC0042 b on a.canumi=b.cpprod
						 left join TC007 c on b.cpcat=c.cinumi
						 left join TC003 d on b.cpcat=d.chcatcl and d.chcatcl=c.cinumi and d.chcprod=a.canumi
			where cpcli = @code_id --Id de Cliente
			order by canumi asc
			end
			else
			begin
				select producto.canumi as id,producto.cadesc as name, categoria.chprecio as price
				,Cast(IIF((select top 1 ccstock  from TC0001)=1,isnull((select top 1 isnull(co.Cant,0)  from  Vr_Conciliacion as co where co.Prod=producto.canumi
				and co.Chofer =@chofer and co.Fecha =getdate()),0),-1) as decimal(18,2)) as cant
from tc001 as producto inner join TC003 as categoria 
on categoria.chcprod=producto.canumi 
inner join TC004 as cliente on cliente.cccat=categoria.chcatcl
inner join TC007 as catname on catname .cinumi =categoria.chcatcl
and cliente.ccnumi  =@code_id  ----Id de lCliente
			end
		

					--DEVUELVO VALORES DE CONFIRMACION
			--select @code_id as newNumi

		

			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END



		IF @tipo=17--
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 
			if( (select Count(a.oanumi ) from TO001 as a where a.oanumi =@code_id )=1)
			begin
			Update TO001 set oaest =3 where oanumi =@code_id

			insert into TO001A1 values(@code_id,@credito ) 
			insert into TO001B values (@code_id ,@location_lat,@location_log)


			select 1 as estado
			end		

					--DEVUELVO VALORES DE CONFIRMACION
			--select @code_id as newNumi @location_lat

		

			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END

		IF @tipo=20--Verifico Si Existe el repartidor
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

					--DEVUELVO VALORES DE CONFIRMACION
			--select @code_id as newNumi

		
			select top 1 a.cbnumi  as code_id, a.cbdesc as repartidor,a.cbci as ci ,zona.lcnumi as zona
			,cast(0 as integer) as mapa,cast(1 as integer) as pedido,cast(1 as integer ) as update_cliente,a.cbcat as categoria,0 as stock
			from TC002 a, TL0012 zona 
			where a.cbnumi  =@mail  and a.cbci  =@password_cli  and zona.lccbnumi =a.cbnumi 
			order by zona.lcnumi desc
			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END

		IF @tipo=21--ObtenerClientes
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

			select a.ccnumi as numi,a.cccod as codigo,a.ccdesc as namecliente,a.ccnit as nit ,a.ccdirec as direccion,a.cctelf1 as telefono,
a.cclat as latitud,a.cclongi as longitud,a.ccfact as fechaingreso,1 as estado,
cast(a.ccnumi as nvarchar(200)) as codigogenerado,a.cccat,a.cczona
from TC004 as a where a.ccest=1 and a.cczona  in 
(select zona.lcnumi from  TL0012 as zona where  zona.lccbnumi=@idRepartidor )

order by a.ccnumi asc
			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END

		IF @tipo=22--ListarProductos
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

SELECT a.canumi as numi, a.cacod as cod, a.cadesc as producto, a.cadesc2 as desccorta, a.cacat as idcategoria, b.canombre as categoria,
Cast(0 as decimal(18,2)) as precio
				FROM TC001 a inner join TC005C b on a.cacat=b.canumi and a.caserie=0 and a.caest =1
				
				ORDER BY a.canumi ASC
			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END
		IF @tipo=23--ListarPrecios
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

select chnumi,chcprod ,chcatcl ,cast(chprecio as decimal (18,2)) as chprecio 
from TC003 
			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END

		IF @tipo=24--ListPedidos
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

select a.oanumi,DATEADD (DAY ,1,a.oafdoc) as oafdoc,a.oahora ,cast(a.oaccli as nvarchar(200)) as oaccli ,cliente .ccdesc as cliente,a.oarepa ,a.oaest,a.oaobs,
isnull((select distinct l.oblatitud  from TO001B as l where l.obnumi =a.oanumi ),0) as latitud,
isnull((select distinct l.oblatitud  from TO001B as l where l.obnumi =a.oanumi ),0) as longitud,
isnull((Select sum(obptot ) from TO0011 as detalle where detalle.obnumi =a.oanumi ),0) as total,1 as tipocobro,0 as totalcredito,1 as estado,
cast(a.oanumi as nvarchar(200)) as codigogenerado,1 as estadoupdate
from TO001 as a,TC004 as cliente where Year(a.oafdoc) >=Year(GETDATE ()) and
cliente.ccnumi =a.oaccli  and a.oaest in (1,2)
and a.oazona in
(select zona.lcnumi from  TL0012 as zona where  zona.lccbnumi=@idRepartidor )
and a.oaap =1

--union

--select a.oanumi,a.oafdoc ,a.oahora ,cast(a.oaccli as nvarchar(200)) as oaccli ,cliente .ccdesc as cliente,a.oarepa ,a.oaest,a.oaobs,
--isnull((select distinct l.oblatitud  from TO001B as l where l.obnumi =a.oanumi ),0) as latitud,
--isnull((select distinct l.oblatitud  from TO001B as l where l.obnumi =a.oanumi ),0) as longitud,
--isnull((Select sum(obptot ) from TO0011 as detalle where detalle.obnumi =a.oanumi ),0) as total,1 as tipocobro,1 as estado,
--cast(a.oanumi as nvarchar(200)) as codigogenerado,1 as estadoupdate
--from TO001 as a,TC004 as cliente where Year(a.oafdoc) >=Year(GETDATE ()) and
--cliente.ccnumi =a.oaccli  and a.oaest in (3)
--and a.oazona in
--(select zona.lcnumi from  TL0012 as zona where  zona.lccbnumi=@idRepartidor )and a.oaap =1

order by oanumi asc
			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END

	IF @tipo=25--ListarPedidoDetalle
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 
select cast(obnumi as nvarchar(70))as obnumi,obcprod,producto .cadesc  ,cast(obpcant as decimal (18,2)) as obpcant ,
cast(obpbase as decimal (18,2)) as obpbase ,cast(obptot as decimal (18,2)) as obptot,cast(1 as bit) as estado,cast(1 as integer) as obupdate
from TO0011 inner join 
TO001 on oanumi =obnumi and Year(oafdoc) >=Year(GETDATE ())
inner join TC001 as producto on producto .canumi =obcprod  and oaest in (1,2)and oaap =1
and oazona in
(select zona.lcnumi from  TL0012 as zona where  zona.lccbnumi=@idRepartidor )
			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END

		IF @tipo=26--INSERTAR PEDIDO NUEVO
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

		set @oanumi=IIF((select COUNT(oanumi) from TO001)=0,0,(select MAX(oanumi) from TO001))+1
		
		declare @oazona2 int
		set @oazona2=IIF(exists(select TC004.cczona from TC004 where TC004.ccnumi=@oaccli),(select TC004.cczona from TC004 where TC004.ccnumi=@oaccli),0)
		if (not exists(select * from TO001 where oaobs2 =@codigogenerado ))
		begin
		INSERT INTO TO001 VALUES(@oanumi,GETDATE ()  ,@oahora ,@oaccli 
		,@oazona2,@oarepa ,@oaobs ,@codigogenerado,@oaest ,1,0,GETDATE(),CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE())),'MOVIL')	
		---- INSERTO EL DETALLE
		insert into TO001A values(@oanumi,@oarepa ,1,0)
		--insert into TO001A1 values(@code_id,@credito ) 
			insert into TO001B values (@oanumi ,@latitud,@longitud)
		-- DEVUELVO VALORES DE CONFIRMACION
		SELECT TO001.oanumi as code_id   from TO001 where oanumi=@oanumi
		end
		else
		begin
		-- DEVUELVO VALORES DE CONFIRMACION
		SELECT TO001.oanumi as code_id  from TO001 where oaobs2 =@codigogenerado 

		end
		
		
		

			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END

		IF @tipo=27--INSERTAR DETALLE PEDIDO NUEVO
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

	/* this.obnumi = obnumi;
        this.obcprod = obcprod;
        this.cadesc = cadesc;
        this.obpcant = obpcant;
        this.obpbase = obpbase;
        this.obptot = obptot;
        this.estado = estado;*/
		if (not exists (select * from TO0011 a where a.obnumi =@oanumi ))
		begin
		
		INSERT INTO TO0011(obnumi,obcprod,obpcant,obpbase,obptot)
		SELECT distinct @oanumi,'obcprod'=x.v.value('obcprod[1]','int'),
						'obpcant'=x.v.value('obpcant[1]','numeric(18,2)'),
						x.v.value('obpbase[1]','numeric(18,2)') as precio,(x.v.value('obpbase[1]','numeric(18,2)') *x.v.value('obpcant[1]','numeric(18,2)'))as total
		FROM @TO0011.nodes('/row/row')x(v)
		
		SELECT TO001.oanumi as code_id   from TO001 where oanumi=@oanumi
		end

		else
		begin
				SELECT TO001.oanumi as code_id   from TO001 where oanumi=@oanumi
		end


		

			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END

	IF @tipo=28--INSERTAR PEDIDO NUEVO
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

	/* this.obnumi = obnumi;
        this.obcprod = obcprod;
        this.cadesc = cadesc;
        this.obpcant = obpcant;
        this.obpbase = obpbase;
        this.obptot = obptot;
        this.estado = estado;*/
		if ( exists (select * from TO001 a where a.oanumi =@oanumi ))
		begin
		update TO001 set oaest =@oaest,oaobs =@oaobs  where oanumi = @oanumi
				SELECT TO001.oanumi as code_id   from TO001 where oanumi=@oanumi

		if (@tipocobro=2 and  Exists(select * from TO001A1 where ognumi =@oanumi ))
		begin

		update TO001A1 set ogcred =@credito where ognumi =@oanumi 
		
		end
		if (@tipocobro=1 and  Exists(select * from TO001A1 where ognumi =@oanumi ))
		begin

		delete  TO001A1 where ognumi =@oanumi 
		
		end
		if (@tipocobro=2 and not Exists(select * from TO001A1 where ognumi =@oanumi ))
		begin


		insert into TO001A1 values(@oanumi,@credito ) 
		end
		
	    end
		else
		begin

		select 6666 as oanumi

		end
		


		

			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END

		IF @tipo=29--INSERTAR PEDIDO NUEVO
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY 

	/* this.obnumi = obnumi;
        this.obcprod = obcprod;
        this.cadesc = cadesc;
        this.obpcant = obpcant;
        this.obpbase = obpbase;
        this.obptot = obptot;
        this.estado = estado;*/
		if (exists (select * from TO0011 a where a.obnumi =@oanumi ))
		begin
		--ELIMINO LOS REGISTROS
			DELETE FROM TO0011 WHERE obcprod  in (SELECT x.v.value('obcprod[1]','int') FROM @TO0011.nodes('/row/row')x(v) WHERE x.v.value('obupdate[1]','int')=-1)and obnumi =@oanumi 

	INSERT INTO TO0011(obnumi,obcprod,obpcant,obpbase,obptot)
		SELECT distinct @oanumi,'obcprod'=x.v.value('obcprod[1]','int'),
						'obpcant'=x.v.value('obpcant[1]','numeric(18,2)'),
						x.v.value('obpbase[1]','numeric(18,2)') as precio,(x.v.value('obpbase[1]','numeric(18,2)') *x.v.value('obpcant[1]','numeric(18,2)'))as total
		FROM @TO0011.nodes('/row/row')x(v) where (x.v.value('obupdate[1]','int'))=0
		

				--MODIFICO LOS REGISTROS
			UPDATE TO0011
			SET obpcant  =x.v.value('obpcant[1]','numeric(18,2)'),obptot=(x.v.value('obpbase[1]','numeric(18,2)') *x.v.value('obpcant[1]','numeric(18,2)'))
			FROM TO0011  INNER JOIN @TO0011.nodes('/row/row')x(v) 
			ON x.v.value('obupdate[1]','int')=2 and obcprod=x.v.value('obcprod[1]','int')
			and obnumi =@oanumi ;

			

		SELECT TO001.oanumi as code_id   from TO001 where oanumi=@oanumi
		end

		else
		begin
				SELECT TO001.oanumi as code_id   from TO001 where oanumi=@oanumi
		end


		

			COMMIT TRAN MODIFICACION
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, 'CLIMOVIL')
			ROLLBACK TRAN MODIFICACION
		END CATCH
	END

	IF @tipo=30 --Modificar Cliente
	BEGIN
		BEGIN TRAN INSERTAR
		BEGIN TRY 
		
			if(exists(select a.* from TC004 as a where a.ccnumi  =@code_id ))
			begin
		
		
		update TC004 set ccdesc =@full_name ,ccdirec =@address ,cctelf1 =@phone ,cctelf2 =@cell_phone ,
		ccnit =@nit ,cclat =@location_lat ,cclongi =@location_log where ccnumi =@code_id

			-- DEVUELVO VALORES DE CONFIRMACION
			--SELECT @code_id AS newNumi
			
			select a.ccnumi as code_id, a.ccdesc as full_name
			from TC004 a
			where a.ccnumi=@code_id	

			
			end
			else
				begin
				select 1 
			end
		
			

			COMMIT TRAN INSERTAR
		END TRY
		BEGIN CATCH
		select ERROR_MESSAGE()
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 1, @newFecha, @newHora, 'CLIMOVIL')

			ROLLBACK TRAN INSERTAR
		END CATCH
	END

	IF @tipo=31 --MObtener Stock
	BEGIN
		BEGIN TRAN INSERTAR
		BEGIN TRY 
		
		select iacprod as codigoProducto,iacant as cantidad,iaalm as almacen
		 from TI001 
					COMMIT TRAN INSERTAR
		END TRY
		BEGIN CATCH
		select ERROR_MESSAGE()
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 1, @newFecha, @newHora, 'CLIMOVIL')

			ROLLBACK TRAN INSERTAR
		END CATCH
	END
END



