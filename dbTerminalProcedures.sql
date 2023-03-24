
/*************************************** PROCEDURES *******************************/
USE dbTerminal 
GO





/*###############  tbEmpleados  ###############*/

-------->	CREATE
CREATE OR ALTER PROCEDURE term.UDP_tbEmpleados_Create
	@empl_UsuarioCreador	INT,
	@empl_PrimerNombre		NVARCHAR(100),
	@empl_SegundoNombre		NVARCHAR(100),
	@empl_PrimerApellido	NVARCHAR(100),
	@empl_SegundoApellido	NVARCHAR(100),
	@empl_DNI				VARCHAR(13),
	@empl_FechaNacimiento	DATE,
	@empl_Sexo				CHAR(1),
	@empl_Telefono			VARCHAR(8),
	@carg_ID				INT,
	@estciv_ID				INT,
	@muni_ID				CHAR(4)
AS
BEGIN
	BEGIN TRY
		INSERT INTO term.tbEmpleados	(empl_PrimerNombre, empl_SegundoNombre, empl_PrimerApellido, 
										empl_SegundoApellido, empl_DNI, empl_FechaNacimiento, empl_Sexo, empl_Telefono, 
										carg_ID, estciv_ID, muni_ID, empl_UsuarioCreador, 
										empl_UsuarioModificador, empl_FechaModificacion)

		VALUES(@empl_PrimerNombre, @empl_SegundoNombre, @empl_PrimerApellido, @empl_SegundoApellido, @empl_DNI, 
				@empl_FechaNacimiento, @empl_Sexo ,@empl_Telefono, @carg_ID ,@estciv_ID, @muni_ID, @empl_UsuarioCreador, NULL, NULL);
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO

-------->	EDIT		
CREATE OR ALTER PROCEDURE term.UDP_tbEmpleados_Update
	@empl_UsuarioModificador	INT,
	@empl_ID					INT,
	@empl_PrimerNombre			NVARCHAR(100),
	@empl_SegundoNombre			NVARCHAR(100),
	@empl_PrimerApellido		NVARCHAR(100),
	@empl_SegundoApellido		NVARCHAR(100),
	@empl_DNI					VARCHAR(13),
	@empl_FechaNacimiento		DATE,
	@empl_Sexo					CHAR(1),
	@empl_Telefono				VARCHAR(8),
	@carg_ID					INT,
	@estciv_ID					INT,
	@muni_ID					CHAR(4)
AS
BEGIN	
	BEGIN TRY
		UPDATE	term.tbEmpleados
		SET		empl_PrimerNombre = @empl_PrimerNombre, 
				empl_SegundoNombre = @empl_SegundoNombre, 
				empl_PrimerApellido = @empl_PrimerApellido, 
				empl_SegundoApellido = @empl_SegundoApellido, 
				empl_DNI = @empl_DNI, 
				empl_FechaNacimiento = @empl_FechaNacimiento, 
				empl_Sexo = @empl_Sexo, 
				empl_Telefono = @empl_Telefono, 
				carg_ID = @carg_ID,
				estciv_ID = @estciv_ID, 
				muni_ID = @muni_ID, 
				empl_UsuarioModificador = @empl_UsuarioModificador, 
				empl_FechaModificacion = GETDATE()
		WHERE	empl_ID = @empl_ID
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO

-------->	DELETE		
CREATE OR ALTER PROCEDURE term.UDP_tbEmpleados_Delete
@empl_ID INT
AS
BEGIN
	BEGIN TRY
		UPDATE	term.tbEmpleados
		SET		empl_Estado = 0
		WHERE	empl_ID = @empl_ID
		SELECT 1
	END TRY
	BEGIN CATCH
	 SELECT 0
	END CATCH
END
GO



/*###############  tbPasajeros  ###############*/

-------->	CREATE	
CREATE OR ALTER PROCEDURE term.UDP_tbPasajeros_Create
	@clie_UsuarioCreador		INT,
	@clie_Nombres				NVARCHAR(100),
	@clie_Apellidos				NVARCHAR(100),
	@clie_DNI					CHAR(13),
	@clie_Sexo					CHAR(1),
	@clie_Telefono				CHAR(8),
	@clie_Email					NVARCHAR(300)
AS
BEGIN
	BEGIN TRY
		INSERT INTO term.tbClientes(clie_Nombres ,clie_Apellidos,clie_DNI ,clie_Sexo, clie_Telefono, clie_Email, clie_UsuarioCreador, 
									clie_UsuarioModificador, clie_FechaModificacion)
		VALUES	(@clie_Nombres, @clie_Apellidos ,@clie_DNI, @clie_Sexo, @clie_Telefono, 
				@clie_Email, @clie_UsuarioCreador, NULL, NULL)
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO

-------->	UPDATE	
CREATE OR ALTER PROCEDURE term.UDP_tbPasajeros_Update
	@clie_UsuarioModificador	INT,
	@clie_ID					INT,
	@clie_Nombres				NVARCHAR(100),
	@clie_Apellidos				NVARCHAR(100),
	@clie_DNI					CHAR(13),
	@clie_Sexo					CHAR(1),
	@clie_Telefono				CHAR(8),
	@clie_Email					NVARCHAR(300)
AS
BEGIN
	BEGIN TRY
		UPDATE	term.tbClientes 
		SET		clie_Nombres = @clie_Nombres,
				clie_Apellidos = @clie_Apellidos,
				clie_DNI = @clie_DNI,
				clie_Sexo = @clie_Sexo, 
				clie_Telefono= @clie_Telefono, 
				clie_Email = @clie_Email,
				clie_UsuarioModificador = @clie_UsuarioModificador, 
				clie_FechaModificacion = GETDATE()
		WHERE	clie_ID = @clie_ID
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO

-------->	DELETE	
CREATE OR ALTER PROCEDURE term.UDP_tbPasajeros_Delete
@clie_ID INT
AS
BEGIN
	BEGIN TRY
		UPDATE	term.tbClientes
		SET		clie_Estado  = 0
		WHERE clie_ID = @clie_ID
		SELECT 1
	END TRY

	BEGIN CATCH 
		SELECT 0
	END CATCH
END
GO



/*###############  tbMetodos De Pago  ###############*/


--------> Insert  tbMetodosPago
CREATE OR ALTER PROCEDURE gral.UDP_tbMetodosPago_Insert
    @pago_Descripcion		VARCHAR(100),
	@pago_UsuarioCreador    INT
AS
BEGIN
BEGIN TRY

	INSERT INTO gral.tbMetodosPago(pago_Descripcion, pago_UsuarioCreador, 
									pago_UsuarioModificador,pago_FechaModificacion)
	VALUES (@pago_Descripcion, @pago_UsuarioCreador, NULL, NULL)
	SELECT 1
END TRY
BEGIN CATCH
	SELECT 0
	END CATCH
	END
GO

--------> Update tbMetodosPagos 
CREATE OR ALTER PROCEDURE gral.UDP_tbMetodosPagos_Update
	@pago_ID					INT,
	@pago_Descripcion			NVARCHAR(200),
    @pago_UsuarioModificador	INT
AS
BEGIN
	BEGIN TRY
	UPDATE	gral.tbMetodosPago
	SET		pago_Descripcion = @pago_Descripcion,
			pago_UsuarioModificador = @pago_UsuarioModificador, 
			pago_FechaModificacion = GETDATE()
	WHERE	pago_ID = @pago_ID
	SELECT 1
	END TRY
	BEGIN CATCH
	SELECT 0
	END CATCH
END
GO
	
--------> Delete tbMetodosPagos
CREATE OR ALTER PROCEDURE gral.UDP_tbMetodosPagos_Delete
	@pago_ID	INT
AS
BEGIN
	BEGIN TRY
		UPDATE	gral.tbMetodosPago
		SET		pago_Estado  = 0
		WHERE	pago_ID = @pago_ID
		SELECT 1
	END TRY
	BEGIN CATCH 
		SELECT 0
	END CATCH
END
GO


/*###############  tbUsuario  ###############*/

--------> CREATE
CREATE OR ALTER PROCEDURE acce.UDP_tbUsuarios_Create
	@usua_UsuarioCreador	INT,
	@usua_Usuario			NVARCHAR(100), 
	@usua_Clave				VARCHAR(MAX), 
	@usua_EsAdmin				INT,
	@empl_ID				INT
AS
BEGIN
	BEGIN TRY
		DECLARE @ClaveEncriptada VARBINARY(MAX) = HASHBYTES('SHA2_512', @usua_Clave)

		INSERT INTO acce.tbUsuarios	(usua_Usuario, usua_Clave, usua_EsAdmin, empl_ID, usua_Estado, 
										usua_UsuarioCreador, usua_UsuarioModificador, usua_FechaModificacion)
		VALUES (@usua_Usuario, @ClaveEncriptada, @usua_EsAdmin, @empl_ID, '1', @usua_UsuarioCreador, NULL, NULL)
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO

-------->EDIT	
CREATE OR ALTER PROCEDURE acce.UDP_tbUsuarios_Edit
	@usua_UsuarioModificador	INT,
	@usua_ID					INT,
	@usua_Usuario				NVARCHAR(100),
	@usua_Clave					VARCHAR(MAX),
	@usua_EsAdmin					INT,
	@empl_ID					INT
AS
BEGIN
	BEGIN TRY
		DECLARE @ClaveEncriptada VARBINARY(MAX) = HASHBYTES('SHA2_512', @usua_Clave)

		UPDATE	acce.tbUsuarios	
		SET		usua_Usuario = @usua_Usuario,
				empl_ID = @empl_ID,
				usua_Clave = @ClaveEncriptada,
				usua_EsAdmin = @usua_EsAdmin,
				usua_UsuarioModificador = @usua_UsuarioModificador, 
				usua_FechaModificacion = GETDATE() 
		WHERE	usua_ID = @usua_ID
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO

-------->DELETE		
CREATE OR ALTER PROCEDURE acce.UDP_tbUsuarios_Delete
	@usua_ID INT
AS
BEGIN
	BEGIN TRY
		UPDATE	acce.tbUsuarios
		SET		usua_Estado = 0
		WHERE	usua_ID = @usua_ID
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO


/*###############  tbItinerarios  ###############*/

--------> CREATE
CREATE OR ALTER PROCEDURE term.UDP_tbItinerarios_Create
	@hora_UsuarioCreador		INT,
	@hora_FechaSalida			DATETIME,
	@hora_FechaLlegada			DATETIME,
	@tran_ID					INT,
	@hora_CantidadPasajeros		INT
AS
BEGIN
	INSERT INTO term.tbHorarios(hora_FechaSalida, hora_FechaLlegada, hora_CantidadPasajeros,
									hora_UsuarioCreador, hora_UsuarioModificador, hora_FechaModificacion)
	VALUES(@hora_FechaSalida, @hora_FechaLlegada, @tran_ID, @hora_CantidadPasajeros, @hora_UsuarioCreador, NULL, NULL)								
END
GO

--------> UPDATE
CREATE OR ALTER PROCEDURE term.UDP_tbItinerarios_Update
	@hora_UsuarioModificador	INT,
	@hora_ID					INT,
	@hora_FechaSalida			DATETIME,
	@hora_FechaLlegada			DATETIME,
	@tran_ID					INT,
	@hora_CantidadPasajeros		INT
AS
BEGIN
	UPDATE 	term.tbHorarios
	SET 	hora_FechaSalida =@hora_FechaSalida, 
			hora_FechaLlegada =@hora_FechaLlegada,
	  		hora_CantidadPasajeros =@hora_CantidadPasajeros,
			hora_UsuarioModificador = @hora_UsuarioModificador,
			hora_FechaModificacion = GETDATE()
	WHERE hora_ID = @hora_ID					
END
GO

CREATE OR ALTER PROCEDURE term.UDP_tbItinerarios_Delete
	@hora_ID INT
AS
BEGIN
	UPDATE term.tbHorarios
	SET hora_Estado = 0
	WHERE hora_ID = @hora_ID 
END
GO





/*###############  tbTerminal  ###############*/
--------> CREATE

CREATE OR ALTER PROCEDURE term.UDP_tbTerminal_Create
@muni_ID					CHAR(4),
@term_Nombre				VARCHAR(300),
@term_DireccionExacta		VARCHAR(500),
@term_CantidadTransportes	INT,
@term_UsuarioCreador		INT
AS
BEGIN

BEGIN TRY

	INSERT INTO [term].[tbTerminales]
           ([muni_ID]
           ,[term_Nombre]
           ,[term_DireccionExacta]
           ,[term_CantidadTransportes]
           ,[term_UsuarioCreador]
           ,[term_UsuarioModificador]
           ,[term_FechaModificacion])
     VALUES
           (@muni_ID
           ,@term_Nombre
           ,@term_DireccionExacta
           ,@term_CantidadTransportes
           ,@term_UsuarioCreador
           ,NULL
           ,NULL)
SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH

END
GO

--------> UPDATE	

CREATE OR ALTER PROCEDURE term.UDP_tbTerminal_Update
@term_ID					INT,
@muni_ID					CHAR(4),
@term_Nombre				VARCHAR(300),
@term_DireccionExacta		VARCHAR(500),
@term_CantidadTransportes	INT,
@term_UsuarioModificador	INT
AS
BEGIN

BEGIN TRY

UPDATE [term].[tbTerminales]
   SET [muni_ID] = @muni_ID
      ,[term_Nombre] = @term_Nombre
      ,[term_DireccionExacta] = @term_DireccionExacta
      ,[term_CantidadTransportes] = @term_DireccionExacta
      ,[term_UsuarioModificador] = @term_UsuarioModificador
      ,[term_FechaModificacion] = GETDATE()
 WHERE term_ID	= @term_ID	

 SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH

END
GO
--------> DELETE	

CREATE OR ALTER PROCEDURE term.UDP_tbTerminal_DELETE
@term_ID					INT,
@term_UsuarioModificador	INT
AS
BEGIN

BEGIN TRY

UPDATE [term].[tbTerminales]
   SET [term_Estado] = 0
      ,[term_UsuarioModificador] = @term_ID
      ,[term_FechaModificacion] = @term_UsuarioModificador
  WHERE term_ID	= @term_ID	


 SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO
/*###############  tbTerminal  ###############*/

CREATE OR ALTER PROCEDURE term.UDP_VW_tbClientes_VW
AS
BEGIN
	SELECT * FROM tbClientes WHERE clie_Estado = 1
END
GO