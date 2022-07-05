USE E31B_G6
GO
CREATE PROC usp_UserLogin
AS
BEGIN
	SELECT
	A.IdUsuario,
	A.LoginUsuario,
	A.PasswordUsuario,
	A.IdPerfil,
	A.ApellidoPaterno,
	A.ApellidoMaterno,
	A.Nombre,
	A.DocumentoIdentidad,
	A.Activo,
	A.UsuarioCrea,
	A.UsuarioModifica,
	A.FechaCrea,
	A.FechaModifica
	FROM Usuario A
END
GO
CREATE PROC usp_ListarPaises
AS
BEGIN
	SELECT
	A.CodPais,
	A.DescripPais,
	A.UsuarioCrea,
	A.UsuarioModifica,
	A.FechaCrea,
	A.FechaModifica
	FROM Pais A
END
GO
CREATE PROC usp_ListarDepartamentos
AS
BEGIN
	SELECT
	A.CodDepartamento,
	A.DescripDepartamento,
	A.UsuarioCrea,
	A.UsuarioModifica,
	A.FechaCrea,
	A.FechaModifica
	FROM Departamento A
END
GO
CREATE PROC usp_ListarProvinciasPorDepartamento
(
@CodDepartamento	CHAR(2)
)
AS
BEGIN
	SELECT
	A.CodProvincia,
	A.DescripProvincia,
	A.CodDepartamento,
	A.UsuarioCrea,
	A.UsuarioModifica,
	A.FechaCrea,
	A.FechaModifica
	FROM Provincia A
	WHERE A.CodDepartamento = @CodDepartamento
END
GO
CREATE PROC usp_ListarDistritosPorProvincia
(
@CodDepartamento	CHAR(2),
@CodProvincia		CHAR(2)
)
AS
BEGIN
	SELECT
	A.CodDistrito,
	A.DescripDistrito,
	A.CodProvincia,
	A.CodDepartamento,
	A.UsuarioCrea,
	A.UsuarioModifica,
	A.FechaCrea,
	A.FechaModifica
	FROM Distrito A
	WHERE A.CodDepartamento = @CodDepartamento
	AND A.CodProvincia = @CodProvincia
END
GO
CREATE PROC usp_ListarMarcas
AS
BEGIN
	SELECT
	A.IdMarca,
	A.DescripMarca,
	A.CodPais,
	A.UsuarioCrea,
	A.UsuarioModifica,
	A.FechaCrea,
	A.FechaModifica
	FROM Marca A
END
CREATE PROC usp_ListarModelosPorMarca
(
@IdMarca	INT
)
AS
BEGIN
	SELECT
	A.IdModelo,
	A.IdMarca,
	A.DescripModelo,
	A.IdCarroceria,
	A.IdCombustible,
	A.Motor,
	A.PotenciaHP,
	A.PotenciaRPM,
	A.CodColores,
	A.UsuarioCrea,
	A.UsuarioModifica,
	A.FechaCrea,
	A.FechaModifica
	FROM Modelo A
	WHERE A.IdMarca = @IdMarca
END
GO
CREATE PROC usp_ListarCarrocerias
AS
BEGIN
	SELECT
	A.IdCarroceria,
	A.DescripCarroceria,
	A.UsuarioCrea,
	A.UsuarioModifica,
	A.FechaCrea,
	A.FechaModifica
	FROM Carroceria A
END
GO
CREATE PROC usp_ListarCombustibles
AS
BEGIN
	SELECT
	A.IdCombustible,
	A.DescripCombustible,
	A.UsuarioCrea,
	A.UsuarioModifica,
	A.FechaCrea,
	A.FechaModifica
	FROM Combustible A
END
GO
CREATE PROC usp_ListarColores
AS
BEGIN
	SELECT
	A.CodColor,
	A.DescripColor,
	A.UsuarioCrea,
	A.UsuarioModifica,
	A.FechaCrea,
	A.FechaModifica
	FROM Color A
END
CREATE PROC usp_ListarEstados
AS
BEGIN
	SELECT
	A.IdEstado,
	A.DescripEstado,
	A.UsuarioCrea,
	A.UsuarioModifica,
	A.FechaCrea,
	A.FechaModifica
	FROM Estado A
END
CREATE PROC usp_ListarTipoRevision
AS
BEGIN
	SELECT
	A.IdRevision,
	A.DescripRevision,
	A.UsuarioCrea,
	A.UsuarioModifica,
	A.FechaCrea,
	A.FechaModifica
	FROM TipoRevision A
END
CREATE PROC usp_InsertarUsuario
(
@IdUsuario			INT OUTPUT,
@LoginUsuario		VARCHAR(50),
@PasswordUsuario	VARCHAR(50),
@IdPerfil			INT,
@ApellidoPaterno	VARCHAR(50),
@ApellidoMaterno	VARCHAR(50),
@Nombre				VARCHAR(100),
@DocumentoIdentidad	VARCHAR(20),
@UsuarioCrea		INT
)
AS
BEGIN
	INSERT INTO Usuario (LoginUsuario, PasswordUsuario, IdPerfil, ApellidoPaterno, ApellidoMaterno, Nombre, UsuarioCrea, FechaCrea)
	VALUES (@LoginUsuario, @PasswordUsuario, @IdPerfil, @ApellidoPaterno, @ApellidoMaterno, @Nombre, @UsuarioCrea, GETDATE())

	SET @IdUsuario = SCOPE_IDENTITY()
END
CREATE PROC usp_InsertarVehiculoNuevo
(
@IdVehiculo		INT OUTPUT,
@IdMarca		INT,
@IdModelo		INT,
@CodColor		CHAR(1),
@Disponible		BIT,
@UsuarioCrea	INT
)
AS
BEGIN

	INSERT INTO VehiculoNuevo (IdMarca, IdModelo, CodColor, Disponible, UsuarioCrea, FechaCrea)
	VALUES (@IdMarca, @IdModelo, @CodColor, @Disponible, @UsuarioCrea, GETDATE())

	SET @IdVehiculo = SCOPE_IDENTITY()
END
CREATE PROC usp_InsertarVehiculoUsado
(
@IdVehiculo			INT OUTPUT,
@IdMarca			INT,
@IdModelo			INT,
@CodColor			CHAR(1),
@Anio				INT,
@IdEstado			INT,
@MarcaKM			INT,
@IdCombustible		INT,
@FlagArosAleacion	BIT,
@FlagAirbag			BIT,
@FlagNeblineros		BIT,
@FlagAC				BIT,
@FlagFarosAN		BIT,
@FlagABS			BIT,
@FlagRadio			BIT,
@Disponible			BIT,
@UsuarioCrea		INT
)
AS
BEGIN

	INSERT INTO VehiculoUsado (IdMarca, IdModelo, CodColor, Anio, IdEstado, MarcaKM, IdCombustible, FlagArosAleacion, FlagAirbag, FlagNeblineros, FlagAC, FlagFarosAN, FlagABS, FlagRadio, Disponible, UsuarioCrea, FechaCrea)
	VALUES (@IdMarca, @IdModelo, @CodColor, @Anio, @IdEstado, @MarcaKM, @IdCombustible, @FlagArosAleacion, @FlagAirbag, @FlagNeblineros, @FlagAC, @FlagFarosAN, @FlagABS, @FlagRadio, @Disponible, @UsuarioCrea, GETDATE())

	SET @IdVehiculo = SCOPE_IDENTITY()
END
CREATE PROC usp_InsertarSolicitudTaller
(
@IdSolicitud		INT OUTPUT,
@IdRevision			INT,
@IdMarca			INT,
@IdModelo			INT,
@CodColor			CHAR(1),
@Anio				INT,
@IdEstado			INT,
@MarcaKM			INT,
@IdCombustible		INT,
@FlagArosAleacion	BIT,
@FlagAirbag			BIT,
@FlagNeblineros		BIT,
@FlagAC				BIT,
@FlagFarosAN		BIT,
@FlagABS			BIT,
@FlagRadio			BIT,
@Observaciones		VARCHAR(800),
@ApellidoPaterno	VARCHAR(50),
@ApellidoMaterno	VARCHAR(50),
@Nombre				VARCHAR(100),
@DocumentoIdentidad	VARCHAR(20),
@TelefonoContacto	VARCHAR(10),
@CodDepartamento	CHAR(2),
@CodProvincia		CHAR(2),
@CodDistrito		CHAR(2),
@UsuarioCrea		INT
)
AS
BEGIN

	INSERT INTO SolicitudTaller (IdRevision, IdMarca, IdModelo, CodColor, Anio, IdEstado, MarcaKM, IdCombustible, FlagArosAleacion, FlagAirbag, FlagNeblineros, FlagAC, FlagFarosAN, FlagABS, FlagRadio,
								 Observaciones, ApellidoPaterno, ApellidoMaterno, Nombre, DocumentoIdentidad, TelefonoContacto, CodDepartamento, CodProvincia, CodDistrito, UsuarioCrea, FechaCrea)
	VALUES (@IdRevision, @IdMarca, @IdModelo, @CodColor, @Anio, @IdEstado, @MarcaKM, @IdCombustible, @FlagArosAleacion, @FlagAirbag, @FlagNeblineros, @FlagAC, @FlagFarosAN, @FlagABS, @FlagRadio,
			@Observaciones, @ApellidoPaterno, @ApellidoMaterno, @Nombre, @DocumentoIdentidad, @TelefonoContacto, @CodDepartamento, @CodProvincia, @CodDistrito, @UsuarioCrea, GETDATE())
	
	SET @IdSolicitud = SCOPE_IDENTITY()
END