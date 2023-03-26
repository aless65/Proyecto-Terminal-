CREATE DATABASE dbTerminal
GO

USE dbTerminal
GO

CREATE SCHEMA term
GO
CREATE SCHEMA gral
GO
CREATE SCHEMA acce
GO



/************************************* TABLAS *********************************************/

			/* ESQUEMA 'GENERAL (gral)' */

--CREACION DE TABLA tbEstadosCiviles
CREATE TABLE gral.tbEstadosCiviles(
	estciv_ID					INT IDENTITY(1,1),
	estciv_Descripcion			VARCHAR(200),
	estciv_Estado				INT DEFAULT (1),
	estciv_UsuarioCreador		INT,
	estciv_FechaCreacion		DATETIME DEFAULT GETDATE(),
	estciv_UsuarioModificador	INT,
	estciv_FechaModificacion	DATETIME,
	CONSTRAINT PK_gral_tbEstadosCiviles_estciv_ID PRIMARY KEY (estciv_ID)
)
GO


--CREACION DE TABLA tbDepartamentos
CREATE TABLE gral.tbDepartamentos(
	dept_ID						CHAR(2),
	dept_Descripcion			NVARCHAR(200),
	dept_Estado					INT DEFAULT (1),
	dept_UsuarioCreador			INT,
	dept_FechaCreacion			DATETIME DEFAULT GETDATE(),
	dept_UsuarioModificador		INT,
	dept_FechaModificacion		DATETIME,	
	CONSTRAINT PK_gral_tbDepartamentos_dept_ID PRIMARY KEY (dept_ID)
)
GO


--CREACION DE TABLA tbMunicipios
CREATE TABLE gral.tbMunicipios(
	dept_ID						CHAR(2),
	muni_ID						CHAR(4),
	muni_Descripcion			NVARCHAR(200),
	muni_Estado					INT DEFAULT 1,
	muni_UsuarioCreador			INT,
	muni_FechaCreacion			DATETIME DEFAULT GETDATE(),
	muni_UsuarioModificador		INT,
	muni_FechaModificacion		DATETIME,
	CONSTRAINT PK_gral_tbMunicipios_muni_ID PRIMARY KEY (muni_ID),
	CONSTRAINT FK_gral_tbMunicipios_tbDepartamentos_dept_ID FOREIGN KEY(dept_ID) 
	REFERENCES gral.tbDepartamentos (dept_ID),
)
GO


--CREACION DE TABLA tbMetodosPago
CREATE TABLE gral.tbMetodosPago(
	pago_ID						INT IDENTITY(1,1),
	pago_Descripcion			NVARCHAR (200),
	pago_Estado					INT DEFAULT 1,
	pago_UsuarioCreador			INT,
	pago_FechaCreacion			DATETIME DEFAULT GETDATE(),
	pago_UsuarioModificador		INT,
	pago_FechaModificacion		DATETIME,

	CONSTRAINT PK_gral_tbMetodosPago_pago_ID PRIMARY KEY (pago_ID),
)
GO


			/* ESQUEMA ACCESO (acce) */

--CREACION DE TABLA tbRoles
CREATE TABLE acce.tbRoles(
	role_ID						INT IDENTITY(1,1),
	role_Descripcion			VARCHAR(250),
	role_Estado					INT DEFAULT 1,
	role_UsuarioCreador			INT,
	role_FechaCreacion			DATETIME DEFAULT GETDATE(),
	role_UsuarioModificador		INT,
	role_FechaModificacion		DATETIME,
	CONSTRAINT PK_acce_tbRoles_role_ID PRIMARY KEY (role_ID),
)
GO


--CREACION DE TABLA tbPantallas
CREATE TABLE acce.tbPantallas(
	pant_ID						INT IDENTITY(1,1),
	pant_Descripcion			VARCHAR (250),
	pant_Estado					INT DEFAULT 1,
	pant_UsuarioCreador			INT,
	pant_FechaCreacion			DATETIME DEFAULT GETDATE(),
	pant_UsuarioModificador		INT,
	pant_FechaModificacion		DATETIME,
	CONSTRAINT PK_acce_tbPantallas_pant_ID	PRIMARY KEY (pant_ID),
)
GO


--CREACION DE TABLA tbRolesXPantallas
CREATE TABLE acce.tbRolesXPantallas(
	roleXpant_ID				INT IDENTITY(1,1),
	role_ID						INT,
	pant_ID						INT,
	usua_ID						INT,
	roleXpant_Estado				INT DEFAULT 1,
	roleXpant_UsuarioCreador		INT,
	roleXpant_FechaCreacion			DATETIME DEFAULT GETDATE(),
	roleXpant_UsuarioModificador	INT,
	roleXpant_FechaModificacion		DATETIME,

	CONSTRAINT PK_acce_tbRolesXPantallas_roleXpant_ID PRIMARY KEY (roleXpant_ID),
	CONSTRAINT FK_acce_tbRolesXPantallas_tbRoles_role_ID FOREIGN KEY (role_ID) REFERENCES acce.tbRoles (role_ID),
	CONSTRAINT FK_acce_tbRolesXPantallas_tbPantallas_pant_ID FOREIGN KEY (pant_ID) REFERENCES acce.tbPantallas (pant_ID),
)
GO


--------> CREACION DE TABLA tbUsuarios
CREATE TABLE acce.tbUsuarios( 
	usua_ID						INT IDENTITY(1,1), 
	usua_Usuario				NVARCHAR(100), 
	usua_Clave					VARBINARY(MAX),
	usua_EsAdmin				INT,
	empl_ID						INT,
	usua_Estado					INT DEFAULT 1,
	usua_UsuarioCreador			INT,
	usua_FechaCreacion			DATETIME DEFAULT GETDATE(),
	usua_UsuarioModificador		INT,
	usua_FechaModificacion		DATETIME,

	CONSTRAINT PK_acce_tbUsuarios_usua_ID PRIMARY KEY (usua_ID), 
	CONSTRAINT UQ_acce_tbUsuarios_usua_Usuario UNIQUE (usua_Usuario),
)
GO






			/* ESQUEMA TERMINAL (term) */

CREATE TABLE term.tbCargos(
	carg_ID						INT IDENTITY(1,1),
	carg_Nombre					VARCHAR(200),
	carg_Estado					INT DEFAULT 1,
	carg_UsuarioCreador			INT,
	carg_FechaCreacion			DATETIME DEFAULT GETDATE(),
	carg_UsuarioModificador		INT,
	carg_FechaModificacion		DATETIME,

	CONSTRAINT PK_term_tbCargos_carg_ID PRIMARY KEY (carg_ID),
)


--------> CREACION DE TABLA tbEmpleados
CREATE TABLE term.tbEmpleados(
	empl_ID						INT IDENTITY(1,1),
	empl_PrimerNombre			NVARCHAR(100),
	empl_SegundoNombre			NVARCHAR(100),
	empl_PrimerApellido			NVARCHAR(100),
	empl_SegundoApellido		NVARCHAR(100),
	empl_DNI					CHAR(13),
	empl_FechaNacimiento		DATE,
	empl_Sexo					CHAR(1),
	empl_Telefono				CHAR(8),
	carg_ID						INT,
	estciv_ID					INT,
	muni_ID						CHAR(4),
	empl_Estado					INT DEFAULT 1,
	empl_UsuarioCreador			INT,
	empl_FechaCreacion			DATETIME DEFAULT GETDATE(),
	empl_UsuarioModificador		INT,
	empl_FechaModificacion		DATETIME,

	CONSTRAINT PK_term_tbEmpleados_empl_ID PRIMARY KEY (empl_ID),
	CONSTRAINT CK_term_tbEmpleados_empl_Genero CHECK (empl_Sexo = 'M' OR empl_Sexo = 'F'),
	CONSTRAINT UQ_term_tbEmpleados_empl_DNI UNIQUE (empl_DNI),
	CONSTRAINT FK_term_tbEmpleados_gral_tbEstadosCiviles_estciv_ID FOREIGN KEY (estciv_ID) REFERENCES gral.tbEstadosCiviles (estciv_ID),
	CONSTRAINT FK_term_tbEmpleados_gral_tbMunicipios_muni_ID FOREIGN KEY (muni_ID) REFERENCES gral.tbMunicipios (muni_ID),
	CONSTRAINT FK_term_tbEmpleados_tbCargos_carg_ID	FOREIGN KEY (carg_ID) REFERENCES term.tbCargos (carg_ID) 
)
GO


--CREACION  DE TABLA tbTerminales
CREATE TABLE term.tbTerminales(
	term_ID						INT IDENTITY(1,1),
	muni_ID						CHAR(4),
	term_Nombre					VARCHAR(300),
	term_DireccionExacta		VARCHAR(500),
	term_CantidadTransportes	INT,
	term_Estado					INT DEFAULT 1,
	term_UsuarioCreador			INT,
	term_FechaCreacion			DATETIME DEFAULT GETDATE(),
	term_UsuarioModificador		INT,
	term_FechaModificacion		DATETIME,
	CONSTRAINT PK_term_tbTerminales_term_ID PRIMARY KEY (term_ID),
	CONSTRAINT FK_term_tbTerminales_gral_tbMunicipios_muni_ID FOREIGN KEY (muni_ID)REFERENCES gral.tbMunicipios (muni_ID)
)
GO


-- CREACION DE TABLA tbCompa�ias
CREATE TABLE term.tbCompania(
	comp_ID						INT IDENTITY(1,1),
	comp_Nombre					VARCHAR(200),
	muni_ID						CHAR(4),
	comp_Direccion				VARCHAR(300),
	comp_Estado					INT DEFAULT 1,
	comp_UsuarioCreador			INT,
	comp_FechaCreacion			DATETIME DEFAULT GETDATE(),
	comp_UsuarioModificador		INT,
	comp_FechaModificacion		DATETIME,

	CONSTRAINT PK_term_tbCompania_comp_ID PRIMARY KEY (comp_ID)
)
GO



--CREACION DE TABLA tbPasajeros
CREATE TABLE term.tbClientes(
	clie_ID						INT IDENTITY(1,1),
	clie_Nombres				NVARCHAR(200),
	clie_Apellidos				NVARCHAR(200),
	clie_DNI					CHAR(13),
	clie_Sexo					CHAR(1),
	clie_Telefono				CHAR(8),
	clie_Email					NVARCHAR(300),
	clie_Estado					INT DEFAULT 1,
	clie_UsuarioCreador			INT,
	clie_FechaCreacion			DATETIME DEFAULT GETDATE(),
	clie_UsuarioModificador		INT,
	clie_FechaModificacion		DATETIME,
	CONSTRAINT PK_term_tbPasajeros_psjr_ID PRIMARY KEY (clie_ID),
	CONSTRAINT CK_term_tbPasajeros_psjr_Genero CHECK (clie_Sexo = 'M' OR clie_Sexo = 'F'),
	CONSTRAINT UQ_term_tbPasajeros_psjr_DNI UNIQUE (clie_DNI),
)
GO


-- CREACION DE TABLA tbHorarios
CREATE TABLE term.tbHorarios(
	hora_ID						INT IDENTITY(1,1),
	hora_FechaSalida			DATETIME,
	hora_FechaLlegada			DATETIME,
	hora_Origen					CHAR(2),
	hora_Destino				CHAR(2),
	hora_CantidadPasajeros		INT,
	hora_Estado					INT DEFAULT 1,
	hora_UsuarioCreador			INT,
	hora_FechaCreacion			DATETIME DEFAULT GETDATE(),
	hora_UsuarioModificador		INT,
	hora_FechaModificacion		DATETIME,

	CONSTRAINT PK_term_tbHorarios_hora_ID PRIMARY KEY (hora_ID),
	CONSTRAINT FK_term_tbHorarios_hora_Origen_gral_tbDepartamentos_dept_ID FOREIGN KEY (hora_Origen) REFERENCES gral.tbDepartamentos (dept_ID),
	CONSTRAINT FK_term_tbHorarios_hora_Destino_gral_tbDepartamentos_dept_ID FOREIGN KEY (hora_Destino) REFERENCES gral.tbDepartamentos (dept_ID)
	
)
GO


-- CREACION DE TABLA tbBoletos
CREATE TABLE term.tbBoletos(
	bole_ID						INT IDENTITY(1,1),
	bole_Fecha					DATETIME DEFAULT GETDATE(),
	term_ID						INT,
	comp_ID						INT,
	empl_ID						INT,
	clie_ID						INT,
	hora_ID						INT,
	pago_ID						INT,
	bole_Precio					NUMERIC(18,2),
	bole_Estado					INT DEFAULT 1,
	bole_UsuarioCreador			INT,
	bole_FechaCreacion			DATETIME DEFAULT GETDATE(),
	bole_UsuarioModificador		INT,
	bole_FechaModificacion		DATETIME,

	CONSTRAINT PK_term_tbBoletos_bole_ID PRIMARY KEY (bole_ID),
	CONSTRAINT FK_term_tbBoletos_tbTerminales_term_ID FOREIGN KEY (term_ID) REFERENCES term.tbTerminales (term_ID),
	CONSTRAINT FK_term_tbBoletos_tbCompanias_comp_ID FOREIGN KEY (comp_ID) REFERENCES term.tbCompania (comp_ID),
	CONSTRAINT FK_term_tbBoletos_tbEmpleados_empl_ID FOREIGN KEY (empl_ID) REFERENCES term.tbEmpleados (empl_ID),
	CONSTRAINT FK_term_tbBoletos_tbClientes_clie_ID FOREIGN KEY (clie_ID) REFERENCES term.tbClientes (clie_ID),
	CONSTRAINT FK_term_tbBoletos_tbHorarios_hora_ID FOREIGN KEY (hora_ID) REFERENCES term.tbHorarios (hora_ID),
	CONSTRAINT FK_term_tbBoletos_gral_tbMetodosPago_pago_ID FOREIGN KEY (pago_ID) REFERENCES gral.tbMetodosPago (pago_ID),	
)
GO


-- por mostrar en proyecto final 
--cargos , boletos, clientes, horarios, terminales











