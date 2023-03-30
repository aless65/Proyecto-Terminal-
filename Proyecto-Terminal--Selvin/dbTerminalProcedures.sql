
/*************************************** PROCEDURES *******************************/
USE dbTerminal 
GO



/*###############  tbCargos ###############*/

-------->	VIEW tbCargos
CREATE OR ALTER VIEW term.VW_tbCargos
AS
SELECT	carg_ID, 
		carg_Nombre, 
		carg_Estado, 
		carg_UsuarioCreador,
		usr1.usua_Usuario AS carg_UsuarioCreador_Nombre,
		carg_FechaCreacion,
		carg_UsuarioModificador,
		usr2.usua_Usuario AS carg_UsuarioModificador_Nombre,
		carg_FechaModificacion
FROM term.tbCargos AS cargo INNER JOIN acce.tbUsuarios AS usr1
ON cargo.carg_UsuarioCreador = usr1.usua_ID LEFT JOIN acce.tbUsuarios AS usr2
ON cargo.carg_UsuarioModificador = usr2.usua_ID
GO

DECLARE @fff TIME = GETDATE()
SELECT @fff
GO

-------->	READ
CREATE OR ALTER PROCEDURE term.UDP_VW_tbCargos_VW
AS
BEGIN
	SELECT * FROM term.VW_tbCargos WHERE carg_Estado = 1
END
GO


-------->	CREATE
CREATE OR ALTER PROCEDURE term.UDP_tbCargos_Create
@carg_UsuarioCreador INT,
@carg_Nombre VARCHAR(200)
AS
BEGIN
	BEGIN TRY
		INSERT INTO term.tbCargos(carg_Nombre, carg_UsuarioCreador, carg_UsuarioModificador, carg_FechaModificacion)
		VALUES (@carg_Nombre, @carg_UsuarioCreador, NULL, NULL)
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO


-------->	FIND
CREATE OR ALTER PROCEDURE term.UDP_tbCargos_Find 
@carg_ID INT
AS
BEGIN


	SELECT carg_ID, 
		carg_Nombre, 
		carg_Estado, 
		carg_UsuarioCreador,
		carg_UsuarioCreador_Nombre,
		carg_FechaCreacion,
		carg_UsuarioModificador,
		carg_UsuarioModificador_Nombre,
		carg_FechaModificacion
	FROM term.VW_tbCargos
	WHERE carg_ID = @carg_ID

END
GO


-------->	UPDATE
CREATE OR ALTER PROCEDURE term.UDP_tbCargos_Update
	@carg_UsuarioModificador	INT,
	@carg_ID					INT,
	@carg_Nombre				VARCHAR(200)
AS
BEGIN
	BEGIN TRY
		UPDATE term.tbCargos 
		SET carg_Nombre = @carg_Nombre, 
		carg_UsuarioModificador = @carg_UsuarioModificador, 
		carg_FechaModificacion = GETDATE()
		WHERE carg_ID = @carg_ID
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO

-------->	DELETE
CREATE OR ALTER PROCEDURE term.UDP_tbCargos_Delete
	@carg_ID	INT
AS
BEGIN
	BEGIN TRY
		UPDATE term.tbCargos
		SET carg_Estado = 0
		WHERE carg_ID = @carg_ID
		SELECT 1
	END TRY
	BEGIN CATCH 
		SELECT 0
	END CATCH 
END
GO



/*###############  tbClientes  ###############*/


CREATE OR ALTER VIEW term.VW_tbClientes
AS
SELECT	clie_ID, 
		clie_Nombres, 
		clie_Apellidos,
		CONCAT(clie_Nombres,  ' ', clie_Apellidos) AS clie_NombreCompleto,
		clie_DNI,
		clie_Sexo,
		clie_Telefono,
		clie_Email,		
		clie_Estado,
		clie_UsuarioCreador,
		usr1.usua_Usuario AS clie_UsuarioCreador_Nombre,
		clie_FechaCreacion,
		clie_UsuarioModificador, 
		usr2.usua_Usuario AS clie_UsuarioModificador_Nombre,
		clie_FechaModificacion

FROM term.tbClientes AS clie INNER JOIN acce.tbUsuarios AS usr1
ON clie.clie_UsuarioCreador = usr1.usua_ID LEFT JOIN acce.tbUsuarios AS usr2
ON clie.clie_UsuarioModificador = usr2.usua_ID
GO


-------->	READ
CREATE OR ALTER PROCEDURE term.UDP_VW_tbClientes_VW
AS
BEGIN
	SELECT * FROM term.VW_tbClientes WHERE clie_Estado = 1

END
GO

-------->	CREATE	
CREATE OR ALTER PROCEDURE term.UDP_tbClientes_Create
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

-------->	FIND
CREATE OR ALTER PROCEDURE term.UDP_tbClientes_Find 
@clie_ID INT
AS
BEGIN

	SELECT clie_ID, clie_Nombres, clie_Apellidos, clie_NombreCompleto, clie_DNI, clie_Sexo, clie_Telefono, clie_Email, clie_Estado, clie_UsuarioCreador, clie_UsuarioCreador_Nombre, clie_FechaCreacion, clie_UsuarioModificador, clie_UsuarioModificador_Nombre, clie_FechaModificacion
	FROM term.VW_tbClientes
	WHERE clie_ID = @clie_ID
 
END
GO

-------->	UPDATE	
CREATE OR ALTER PROCEDURE term.UDP_tbClientes_Update
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
CREATE OR ALTER PROCEDURE term.UDP_tbClientes_Delete
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





/*###############  tbHorarios  ###############*/
/*Vista*/
CREATE OR ALTER VIEW term.VW_tbHorarios
AS
SELECT	hora_ID,
		hora_FechaSalida,
		hora_FechaLlegada,
		hora_Origen,
		dept1.dept_Descripcion AS hora_Origen_DeptoNombre,
		hora_Destino,
		dept2.dept_Descripcion AS hora_Destino_DeptoNombre,
		CONCAT(hora_FechaSalida, ' / ' , dept2.dept_Descripcion ) AS horario,
		hora_CantidadPasajeros,
		hora_Precio,
		hora_Estado,
		hora_UsuarioCreador,
		usr1.usua_Usuario AS hora_UsuarioCreador_Nombre,
		hora_FechaCreacion,
		hora_UsuarioModificador,
		usr2.usua_Usuario AS hora_UsuarioModificador_Nombre,
		hora_FechaModificacion

FROM term.tbHorarios AS hora INNER JOIN gral.tbDepartamentos AS dept1
ON hora.hora_Origen = dept1.dept_ID INNER JOIN gral.tbDepartamentos AS dept2
ON hora.hora_Destino = dept2.dept_ID INNER JOIN acce.tbUsuarios AS usr1
ON hora.hora_UsuarioCreador = usr1.usua_ID LEFT JOIN acce.tbUsuarios AS usr2
ON hora.hora_UsuarioModificador = usr2.usua_ID
GO


CREATE OR ALTER PROCEDURE term.UDP_VW_tbHorarios_VW
AS
BEGIN
	SELECT * FROM term.VW_tbHorarios WHERE hora_Estado = 1
END
GO


--------> CREATE
CREATE OR ALTER PROCEDURE term.UDP_tbHorarios_Create
	@hora_UsuarioCreador		INT,
	@hora_FechaSalida			DATETIME,
	@hora_FechaLlegada			DATETIME,
	@hora_Origen				CHAR(2),
	@hora_Destino				CHAR(2),
	@hora_Precio				DECIMAL(18,2),
	@hora_CantidadPasajeros		INT
AS
BEGIN
	BEGIN TRY

		INSERT INTO term.tbHorarios(hora_FechaSalida, hora_FechaLlegada, hora_Origen, hora_Destino, hora_Precio,hora_CantidadPasajeros, hora_UsuarioCreador, hora_UsuarioModificador, hora_FechaModificacion)
		VALUES(@hora_FechaSalida, @hora_FechaLlegada, @hora_Origen, @hora_Destino, @hora_Precio ,@hora_CantidadPasajeros, @hora_UsuarioCreador, NULL, NULL)								
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO


--------> UPDATE
CREATE OR ALTER PROCEDURE term.UDP_VW_tbHorarios_Find
	@hora_ID INT
AS
BEGIN
	SELECT hora_ID,
		hora_FechaSalida,
		hora_FechaLlegada,
		hora_Origen,
		hora_Origen_DeptoNombre,
		hora_Destino,
		hora_Destino_DeptoNombre,
		hora_CantidadPasajeros,
		hora_Precio,
		hora_Estado,
		hora_UsuarioCreador,
		hora_UsuarioCreador_Nombre,
		hora_FechaCreacion,
		hora_UsuarioModificador,
		hora_UsuarioModificador_Nombre,
		hora_FechaModificacion
	FROM term.VW_tbHorarios WHERE hora_ID = @hora_ID
END
GO


--------> UPDATE
CREATE OR ALTER PROCEDURE term.UDP_tbHorarios_Update
	@hora_UsuarioModificador	INT,
	@hora_ID					INT,
	@hora_FechaSalida			DATETIME,
	@hora_FechaLlegada			DATETIME,
	@hora_Origen				CHAR(2),
	@hora_Destino				CHAR(2),
	@hora_Precio				DECIMAL(18,2),
	@hora_CantidadPasajeros		INT
AS
BEGIN
	UPDATE	term.tbHorarios 
	SET		hora_FechaSalida = @hora_FechaSalida, 
			hora_FechaLlegada = @hora_FechaLlegada, 
			hora_Origen = @hora_Origen, 
			hora_Destino = @hora_Destino,
			hora_Precio = @hora_Precio,
			hora_CantidadPasajeros = @hora_CantidadPasajeros,
			hora_UsuarioModificador = @hora_UsuarioModificador, 
			hora_FechaModificacion = GETDATE()
	WHERE	hora_ID = @hora_ID
END
GO

CREATE OR ALTER PROCEDURE term.UDP_tbHorarios_Delete
	@hora_ID INT
AS
BEGIN
	UPDATE term.tbHorarios
	SET hora_Estado = 0
	WHERE hora_ID = @hora_ID 
END
GO



/*###############  tbTerminales  ###############*/

CREATE OR ALTER VIEW term.VW_tbTerminales
AS
SELECT	term_ID, 
		terminal.muni_ID,
		muni.muni_Descripcion,
		muni.dept_ID,
		depto.dept_Descripcion,
		term_Nombre,
		term_DireccionExacta, 
		term_CantidadTransportes, 
		term_Estado, 
		term_UsuarioCreador,
		usr1.usua_Usuario AS term_UsuarioCreador_Nombre,
		term_FechaCreacion, 
		term_UsuarioModificador, 
		usr2.usua_Usuario AS term_UsuarioModificador_Nombre,
		term_FechaModificacion
FROM term.tbTerminales AS terminal INNER JOIN gral.tbMunicipios AS muni
ON terminal.muni_ID = muni.muni_ID INNER JOIN gral.tbDepartamentos AS depto
ON muni.dept_ID = depto.dept_ID INNER JOIN acce.tbUsuarios AS usr1
ON terminal.term_UsuarioCreador = usr1.usua_ID LEFT JOIN acce.tbUsuarios AS usr2
ON terminal.term_UsuarioModificador = usr2.usua_ID
GO


-------->	READ
CREATE OR ALTER PROCEDURE term.UDP_VW_tbTerminales_VW
AS
BEGIN
	SELECT * FROM term.VW_tbTerminales WHERE term_Estado = 1
END
GO

--------> CREATE
CREATE OR ALTER PROCEDURE term.UDP_tbTerminales_Create
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


--------> FIND
CREATE OR ALTER PROCEDURE term.UDP_VW_tbTerminales_Find
@term_ID INT
AS
BEGIN
	SELECT	term_ID, 
			muni_ID,
			muni_Descripcion,
			dept_ID,
			dept_Descripcion,
			term_Nombre,
			term_DireccionExacta, 
			term_CantidadTransportes, 
			term_Estado, 
			term_UsuarioCreador,
			term_UsuarioCreador_Nombre,
			term_FechaCreacion, 
			term_UsuarioModificador, 
			term_UsuarioModificador_Nombre,
			term_FechaModificacion
	FROM term.VW_tbTerminales 
	WHERE term_ID = @term_ID
END
GO


--------> UPDATE	
CREATE OR ALTER PROCEDURE term.UDP_tbTerminales_Update
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
      ,[term_CantidadTransportes] = @term_CantidadTransportes
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

CREATE OR ALTER PROCEDURE term.UDP_tbTerminales_Delete
@term_ID					INT
AS
BEGIN

BEGIN TRY

UPDATE [term].[tbTerminales]
   SET [term_Estado] = 0
  WHERE term_ID	= @term_ID	


 SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO


/*###############  tbBoletos  ###############*/

--------> VIEW	
CREATE OR ALTER VIEW term.VW_tbBoletos
AS
	SELECT	bole_ID, 
			bole_Fecha,
			bole.term_ID,
			term.term_Nombre,
			term.term_DireccionExacta,
			bole.comp_ID,
			comp.comp_Nombre,
			comp.comp_Direccion,
			bole.empl_ID,
			empl.empl_PrimerNombre,
			empl.empl_SegundoNombre,
			empl.empl_PrimerApellido,
			empl.empl_SegundoApellido,
			CONCAT(empl_PrimerNombre, ' ', empl_SegundoNombre, ' ', empl_PrimerApellido , ' ', empl_SegundoApellido) AS bole_empl_Nombre_Completo,
			bole.clie_ID,
			clie.clie_Nombres,
			clie.clie_Apellidos,
			CONCAT(clie_Nombres, ' ', clie_Apellidos) AS bole_clie_Nombre_Completo,
			clie.clie_Sexo,
			bole.hora_ID,
			hora.hora_FechaSalida,
			hora.hora_Origen,
			dept1.dept_Descripcion AS bole_hora_Origen_Nombre,
			hora.hora_FechaLlegada,
			hora.hora_Destino,
			dept2.dept_Descripcion AS bole_hora_Destino_Nombre,
			bole.pago_ID,
			pago.pago_Descripcion,
			hora.hora_Precio,
			bole_Estado,
			bole_UsuarioCreador,
			usr1.usua_Usuario AS bole_UsuarioCreador_Nombre,
			bole_FechaCreacion,
			bole_UsuarioModificador,
			usr2.usua_Usuario AS bole_UsuarioModificador_Nombre,
			bole_FechaModificacion

	FROM term.tbBoletos AS bole INNER JOIN term.tbTerminales AS term
	ON bole.term_ID = term.term_ID INNER JOIN term.tbCompania AS comp
	ON bole.comp_ID = comp.comp_ID INNER JOIN term.tbEmpleados AS empl
	ON bole.empl_ID = empl.empl_ID INNER JOIN term.tbClientes AS clie
	ON bole.clie_ID = clie.clie_ID INNER JOIN term.tbHorarios AS hora
	ON bole.hora_ID = hora.hora_ID INNER JOIN gral.tbMetodosPago AS pago
	ON bole.pago_ID = pago.pago_ID INNER JOIN acce.tbUsuarios AS usr1
	ON bole.bole_UsuarioCreador = usr1.usua_ID LEFT JOIN acce.tbUsuarios AS usr2
	ON bole.bole_UsuarioModificador = usr2.usua_ID INNER JOIN gral.tbDepartamentos AS dept1
	ON hora.hora_Origen = dept1.dept_ID LEFT JOIN gral.tbDepartamentos AS dept2
	ON hora.hora_Destino = dept2.dept_ID
GO




CREATE OR ALTER VIEW term.VW_tbBoletos2
AS
	SELECT	bole_ID, 
			bole_Fecha,
 			CONCAT(clie_Nombres, ' ', clie_Apellidos) AS bole_clie_Nombre_Completo,
 			dept1.dept_Descripcion AS bole_hora_Origen_Nombre,
 			dept2.dept_Descripcion AS bole_hora_Destino_Nombre,
			comp_Nombre
 
	FROM term.tbBoletos AS bole INNER JOIN term.tbTerminales AS term
	ON bole.term_ID = term.term_ID INNER JOIN term.tbCompania AS comp
	ON bole.comp_ID = comp.comp_ID INNER JOIN term.tbEmpleados AS empl
	ON bole.empl_ID = empl.empl_ID INNER JOIN term.tbClientes AS clie
	ON bole.clie_ID = clie.clie_ID INNER JOIN term.tbHorarios AS hora
	ON bole.hora_ID = hora.hora_ID INNER JOIN gral.tbMetodosPago AS pago
	ON bole.pago_ID = pago.pago_ID INNER JOIN acce.tbUsuarios AS usr1
	ON bole.bole_UsuarioCreador = usr1.usua_ID LEFT JOIN acce.tbUsuarios AS usr2
	ON bole.bole_UsuarioModificador = usr2.usua_ID INNER JOIN gral.tbDepartamentos AS dept1
	ON hora.hora_Origen = dept1.dept_ID LEFT JOIN gral.tbDepartamentos AS dept2
	ON hora.hora_Destino = dept2.dept_ID
GO

--------> READ
CREATE OR ALTER PROCEDURE term.UDP_VW_tbBoletos_VW
AS
BEGIN
	SELECT * FROM term.VW_tbBoletos WHERE bole_Estado = 1
END
GO

 
CREATE OR ALTER PROCEDURE term.UDP_VW_VistaPrevia_VW
AS
BEGIN
	select * from term.VW_tbBoletos2
END
GO

--------> CREATE	
CREATE OR ALTER PROCEDURE term.UDP_tbBoletos_Create
	@bole_UsuarioCreador	INT,
	@term_ID				INT,
	@comp_ID				INT,
	@empl_ID				INT,
	@clie_ID				INT,
	@hora_ID				INT,
	@pago_ID				INT
AS
BEGIN 
	BEGIN TRY
		INSERT INTO term.tbBoletos (term_ID, comp_ID, empl_ID, clie_ID, hora_ID, pago_ID,
					bole_UsuarioCreador, bole_UsuarioModificador, bole_FechaModificacion)
		VALUES (@term_ID, @comp_ID, @empl_ID, @clie_ID, @hora_ID, @pago_ID,
				@bole_UsuarioCreador, NULL, NULL)
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH 
END
GO


--------> FIND	
CREATE OR ALTER PROCEDURE term.UDP_VW_tbBoletos_Find
	@bole_ID INT
AS
BEGIN
	SELECT bole_ID, 
			bole_Fecha,
			term_ID,
			term_Nombre,
			term_DireccionExacta,
			comp_ID,
			comp_Nombre,
			comp_Direccion,
			empl_ID,
			empl_PrimerNombre,
			empl_SegundoNombre,
			empl_PrimerApellido,
			empl_SegundoApellido,
			bole_empl_Nombre_Completo,
			clie_ID,
			clie_Nombres,
			clie_Apellidos,
			bole_clie_Nombre_Completo,
			clie_Sexo,
			hora_ID,
			hora_FechaSalida,
			hora_Origen,
			bole_hora_Origen_Nombre,
			hora_FechaLlegada,
			hora_Destino,
			bole_hora_Destino_Nombre,
			pago_ID,
			pago_Descripcion,
			hora_Precio,
			bole_Estado,
			bole_UsuarioCreador,
			bole_UsuarioCreador_Nombre,
			bole_FechaCreacion,
			bole_UsuarioModificador,
			bole_UsuarioModificador_Nombre,
			bole_FechaModificacion
	FROM term.VW_tbBoletos WHERE bole_ID = @bole_ID
END
GO



--------> UPDATE	
CREATE OR ALTER PROCEDURE term.UDP_tbBoletos_Update
	@bole_UsuarioModificador	INT,
	@bole_ID					INT ,
	@term_ID					INT,
	@comp_ID					INT,
	@empl_ID					INT,
	@clie_ID					INT,
	@hora_ID					INT,
	@pago_ID					INT
AS
BEGIN 
	BEGIN TRY
		UPDATE term.tbBoletos 
		SET term_ID = @term_ID, 
		comp_ID = @comp_ID, 
		empl_ID = @empl_ID, 
		clie_ID = @clie_ID, 
		hora_ID = @hora_ID, 
		pago_ID = @pago_ID,
		bole_UsuarioModificador = @bole_UsuarioModificador, 
		bole_FechaModificacion = GETDATE()
		WHERE bole_ID = @bole_ID
		SELECT 1
	END TRY 
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO



--------> DELETE	
CREATE OR ALTER PROCEDURE term.UDP_tbBoletos_Delete
	@bole_ID				INT
AS
BEGIN 
	BEGIN TRY
		UPDATE term.tbBoletos
		SET bole_Estado = 0
		WHERE bole_ID = @bole_ID
		SELECT 1
	END TRY
	BEGIN CATCH 
		SELECT 0
	END CATCH
END
GO


go
CREATE OR ALTER PROCEDURE gral.UDP_CargarDepartamento_Load 
AS
BEGIN
SELECT [dept_ID], 
[dept_Descripcion], 
[dept_Estado], 
[dept_UsuarioCreador],
[dept_FechaCreacion], 
[dept_UsuarioModificador],
[dept_FechaModificacion]
FROM [gral].[tbDepartamentos]
WHERE dept_Estado = 1

END

go
CREATE OR ALTER PROCEDURE gral.UDP_CargarMunicipio_Load 
@dept_ID   varchar(10)
AS
BEGIN
SELECT  [dept_ID], 
		[muni_ID], 
		[muni_Descripcion],
		[muni_Estado],
		[muni_UsuarioCreador],
		[muni_FechaCreacion], 
		[muni_UsuarioModificador],
		[muni_FechaModificacion]
FROM [gral].[tbMunicipios]
WHERE [dept_ID] = @dept_ID

END

GO
CREATE OR ALTER VIEW gral.VW_graficaViaje
AS
SELECT bole_hora_Destino_Nombre, COUNT(hora_Destino) AS Cantidad
    FROM term.VW_tbBoletos
	group by hora_Destino,bole_hora_Destino_Nombre



GO
CREATE OR ALTER VIEW gral.VW_graficaSexo
AS
 
select	( SELECT COUNT(clie_Sexo) FROM term.VW_tbBoletos where clie_Sexo = 'M' group by clie_Sexo ) Masculino,
			( SELECT COUNT(clie_Sexo) FROM term.VW_tbBoletos where clie_Sexo = 'F' group by clie_Sexo ) Femenino


GO
CREATE OR ALTER PROCEDURE gral.UDP_GraficaViajes_Load
AS
BEGIN
 
	SELECT * from gral.VW_graficaViaje

END 


GO
CREATE OR ALTER PROCEDURE gral.UDP_GraficaSexo_Load
AS
BEGIN

SELECT * FROM gral.VW_graficaSexo
		
END 
/*###############  tbCompa�ia ###############*/
GO
CREATE OR ALTER PROCEDURE term.UDP_tbCompania_List
AS
BEGIN
SELECT * FROM term.tbCompania WHERE comp_Estado = 1 
END

/*###############  tbEmpleados ###############*/
/*Empleados Vista*/
GO
CREATE OR ALTER VIEW term.VW_tbEmpleados
AS
SELECT empl_ID, 
empl_PrimerNombre, 
empl_SegundoNombre, 
empl_PrimerApellido, 
empl_SegundoApellido, 
CONCAT(empl_PrimerNombre, ' ' ,empl_PrimerApellido) AS empl_NombreCompleto, 
empl_DNI, 
empl_FechaNacimiento, 
empl_Sexo, 
empl_Telefono, 
carg_ID, 
estciv_ID, 
muni_ID, 
empl_Estado, 
empl_UsuarioCreador, 
empl_FechaCreacion, 
empl_UsuarioModificador, 
empl_FechaModificacion
FROM term.tbEmpleados

/*Empleados Vista UDP*/
GO
CREATE OR ALTER PROCEDURE term.UDP_tbEmpleado_List
AS
BEGIN
SELECT * FROM term.VW_tbEmpleados WHERE empl_Estado = 1
END
