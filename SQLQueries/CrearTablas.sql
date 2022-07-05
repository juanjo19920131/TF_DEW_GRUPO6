USE E31B_G6
GO
CREATE TABLE Usuario
(
IdUsuario			INT PRIMARY KEY IDENTITY(1,1),
LoginUsuario		VARCHAR(50) NOT NULL,
PasswordUsuario		VARCHAR(50) NOT NULL,
IdPerfil			INT NOT NULL,
ApellidoPaterno		VARCHAR(50),
ApellidoMaterno		VARCHAR(50),
Nombre				VARCHAR(100),
DocumentoIdentidad	VARCHAR(20),
Activo				BIT,
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME
)
CREATE TABLE Pais
(
CodPais				CHAR(3) PRIMARY KEY,
DescripPais			VARCHAR(30),
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME
)
GO
CREATE TABLE Departamento
(
CodDepartamento		CHAR(2) PRIMARY KEY,
DescripDepartamento	VARCHAR(50),
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME
)
CREATE TABLE Provincia
(
CodProvincia		CHAR(2),
DescripProvincia	VARCHAR(50),
CodDepartamento		CHAR(2),
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME,
PRIMARY KEY			(CodDepartamento, CodProvincia),
FOREIGN KEY (CodDepartamento) REFERENCES Departamento(CodDepartamento)
)
CREATE TABLE Distrito
(
CodDistrito			CHAR(2),
DescripDistrito		VARCHAR(50),
CodProvincia		CHAR(2),
CodDepartamento		CHAR(2), 
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME,
PRIMARY KEY			(CodDepartamento, CodProvincia, CodDistrito),
FOREIGN KEY (CodDepartamento, CodProvincia) REFERENCES Provincia(CodDepartamento, CodProvincia)
)
CREATE TABLE Marca
(
IdMarca				INT PRIMARY KEY IDENTITY(1,1),
DescripMarca		VARCHAR(20),
CodPais				CHAR(3),
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME,
FOREIGN KEY (CodPais) REFERENCES Pais(CodPais)
)
GO
CREATE TABLE Carroceria
(
IdCarroceria		INT PRIMARY KEY IDENTITY(1,1),
DescripCarroceria	VARCHAR(20),
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME
)
GO
CREATE TABLE Combustible
(
IdCombustible		INT PRIMARY KEY IDENTITY(1,1),
DescripCombustible	VARCHAR(10),
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME
)
GO
CREATE TABLE Color
(
CodColor			CHAR(1) PRIMARY KEY,
DescripColor		VARCHAR(10),
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME
)
GO
CREATE TABLE Modelo
(
IdModelo			INT PRIMARY KEY IDENTITY(1,1),
IdMarca				INT,
DescripModelo		VARCHAR(20),
IdCarroceria		INT,
IdCombustible		INT,
Motor				DECIMAL(6,1),
PotenciaHP			INT,
PotenciaRPM			INT,
CodColores			VARCHAR(20),
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME,
FOREIGN KEY (IdMarca) REFERENCES Marca(IdMarca),
FOREIGN KEY (IdCarroceria) REFERENCES Carroceria(IdCarroceria),
FOREIGN KEY (IdCombustible) REFERENCES Combustible(IdCombustible)
)
GO
CREATE TABLE Estado
(
IdEstado			INT PRIMARY KEY IDENTITY(1,1),
DescripEstado		VARCHAR(50),
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME
)
GO
CREATE TABLE TipoRevision
(
IdRevision			INT PRIMARY KEY IDENTITY(1,1),
DescripRevision		VARCHAR(50),
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME
)
GO
CREATE TABLE VehiculoNuevo
(
IdVehiculo			INT PRIMARY KEY IDENTITY(1,1),
IdMarca				INT,
IdModelo			INT,
CodColor			CHAR(1),
Disponible			BIT,
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME,
FOREIGN KEY (IdMarca) REFERENCES Marca(IdMarca),
FOREIGN KEY (IdModelo) REFERENCES Modelo(IdModelo),
FOREIGN KEY (CodColor) REFERENCES Color(CodColor)
)
GO
CREATE TABLE VehiculoUsado
(
IdVehiculo			INT PRIMARY KEY IDENTITY(1,1),
IdMarca				INT,
IdModelo			INT,
CodColor			CHAR(1),
Anio				INT,
IdEstado				INT,
MarcaKM				INT,
IdCombustible		INT,
FlagArosAleacion	BIT,
FlagAirbag			BIT,
FlagNeblineros		BIT,
FlagAC				BIT,
FlagFarosAN			BIT,
FlagABS				BIT,
FlagRadio			BIT,
Disponible			BIT,
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME,
FOREIGN KEY (IdMarca) REFERENCES Marca(IdMarca),
FOREIGN KEY (IdModelo) REFERENCES Modelo(IdModelo),
FOREIGN KEY (CodColor) REFERENCES Color(CodColor),
FOREIGN KEY (IdEstado) REFERENCES Estado(IdEstado),
FOREIGN KEY (IdCombustible) REFERENCES Combustible(IdCombustible)
)
GO
CREATE TABLE Cotizacion
(
IdCotizacion		INT PRIMARY KEY IDENTITY(1,1),
TipoVehiculo		CHAR(5), --NUEVO/USADO
IdVehiculo			INT,
FlagArosAleacion	BIT,
FlagAirbag			BIT,
FlagNeblineros		BIT,
FlagAC				BIT,
FlagFarosAN			BIT,
FlagABS				BIT,
FlagRadio			BIT,
ApellidoPaterno		VARCHAR(50),
ApellidoMaterno		VARCHAR(50),
Nombre				VARCHAR(100),
DocumentoIdentidad	VARCHAR(20),
TelefonoContacto	VARCHAR(10),
CodDepartamento		CHAR(2),
CodProvincia		CHAR(2),
CodDistrito			CHAR(2),
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME,
FOREIGN KEY (CodDepartamento, CodProvincia, CodDistrito) REFERENCES Distrito(CodDepartamento, CodProvincia, CodDistrito)
)
GO
CREATE TABLE SolicitudTaller
(
IdSolicitud			INT PRIMARY KEY IDENTITY(1,1),
IdRevision			INT,
IdMarca				INT,
IdModelo			INT,
CodColor			CHAR(1),
Anio				INT,
IdEstado			INT,
MarcaKM				INT,
IdCombustible		INT,
FlagArosAleacion	BIT,
FlagAirbag			BIT,
FlagNeblineros		BIT,
FlagAC				BIT,
FlagFarosAN			BIT,
FlagABS				BIT,
FlagRadio			BIT,
Observaciones		VARCHAR(800),
ApellidoPaterno		VARCHAR(50),
ApellidoMaterno		VARCHAR(50),
Nombre				VARCHAR(100),
DocumentoIdentidad	VARCHAR(20),
TelefonoContacto	VARCHAR(10),
CodDepartamento		CHAR(2),
CodProvincia		CHAR(2),
CodDistrito			CHAR(2),
UsuarioCrea			INT,
UsuarioModifica		INT,
FechaCrea			DATETIME,
FechaModifica		DATETIME,
FOREIGN KEY (IdRevision) REFERENCES TipoRevision(IdRevision),
FOREIGN KEY (IdMarca) REFERENCES Marca(IdMarca),
FOREIGN KEY (IdModelo) REFERENCES Modelo(IdModelo),
FOREIGN KEY (CodColor) REFERENCES Color(CodColor),
FOREIGN KEY (IdEstado) REFERENCES Estado(IdEstado),
FOREIGN KEY (IdCombustible) REFERENCES Combustible(IdCombustible),
FOREIGN KEY (CodDepartamento, CodProvincia, CodDistrito) REFERENCES Distrito(CodDepartamento, CodProvincia, CodDistrito)
)
GO




