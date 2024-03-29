USE [LABORATORIO_TESTES]
GO
/****** Object:  Table [dbo].[tblPrevilegio]    Script Date: 10/09/2015 00:16:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPrevilegio](
	[IDPrevilegio] [int] IDENTITY(1,1) NOT NULL,
	[Previlegio] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblPrivilegio] PRIMARY KEY CLUSTERED 
(
	[IDPrevilegio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 10/09/2015 00:16:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUsuario](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[IDPrevilegio] [int] NOT NULL,
 CONSTRAINT [PK_tblUsuario] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPermissao]    Script Date: 10/09/2015 00:16:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPermissao](
	[IDPrevilegio] [int] NOT NULL,
	[Permissao] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[procedUsuarioPrevilegioInserir]    Script Date: 10/09/2015 00:16:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procedUsuarioPrevilegioInserir]

	@Previlegio varchar(50)
	
AS
BEGIN

	INSERT INTO tblPrevilegio
	(
		Previlegio
	)
	VALUES
	(
		@Previlegio	
	)
	
	SELECT @@IDENTITY AS Retorno
	
END
GO
/****** Object:  StoredProcedure [dbo].[procedUsuarioPrevilegioEditar]    Script Date: 10/09/2015 00:16:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procedUsuarioPrevilegioEditar]
	@IDPrevilegio int, 
	@Previlegio varchar(50)
AS
BEGIN

	UPDATE tblPrevilegio
	SET
		Previlegio = @Previlegio	
	
	WHERE IDPrevilegio = @IDPrevilegio
	
	SELECT @IDPrevilegio AS Retorno
	
END
GO
/****** Object:  StoredProcedure [dbo].[procedUsuarioPrevilegioConsulta]    Script Date: 10/09/2015 00:16:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procedUsuarioPrevilegioConsulta]
	
AS
BEGIN

	SELECT 
	
		IDPrevilegio, 
		Previlegio
		
	FROM tblPrevilegio
	
END
GO
/****** Object:  StoredProcedure [dbo].[procedUsuarioPermissaoInserir]    Script Date: 10/09/2015 00:16:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procedUsuarioPermissaoInserir]
	@IDPrevilegio int, 
	@Permissao varchar(50)
AS
BEGIN

	INSERT INTO tblPermissao
	(
		IDPrevilegio,
		Permissao
	)
	VALUES
	(
		@IDPrevilegio,
		@Permissao
	)
	
	SELECT @@IDENTITY AS Retorno
	
END
GO
/****** Object:  StoredProcedure [dbo].[procedUsuarioPermissaoEditar]    Script Date: 10/09/2015 00:16:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procedUsuarioPermissaoEditar]
	@IDPrevilegio int, 
	@Permissao varchar(50)
AS
BEGIN

	UPDATE tblPermissao
	SET
		IDPrevilegio = @IDPrevilegio,
		Permissao = @Permissao
	
	WHERE Permissao = @Permissao
	
	SELECT @Permissao AS Retorno
	
END
GO
/****** Object:  StoredProcedure [dbo].[procedUsuarioPermissaoConsulta]    Script Date: 10/09/2015 00:16:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procedUsuarioPermissaoConsulta]

AS
BEGIN

	SELECT
	 
		tblPermissao.IDPrevilegio, 
		tblPermissao.Permissao,
		tblPrevilegio.Previlegio

	FROM tblPermissao
		LEFT JOIN tblPrevilegio ON
			tblPrevilegio.IDPrevilegio = tblPermissao.IDPrevilegio
			
	
END
GO
/****** Object:  StoredProcedure [dbo].[procedUsuarioInserir]    Script Date: 10/09/2015 00:16:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procedUsuarioInserir]
	
	@IDUsuario int, 
	@Nome varchar(50), 
	@IDPrevilegio int
	
AS
BEGIN

	INSERT INTO tblUsuario
	(
		IDUsuario, Nome, IDPrevilegio
	)
	VALUES
	(
		@IDUsuario, @Nome, @IDPrevilegio
	)
	
	SELECT @@IDENTITY AS Retorno

END
GO
/****** Object:  StoredProcedure [dbo].[procedUsuarioEditar]    Script Date: 10/09/2015 00:16:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procedUsuarioEditar]
	
	@IDUsuario int, 
	@Nome varchar(50), 
	@IDPrevilegio int
	
AS
BEGIN

	UPDATE tblUsuario

	SET
	
		Nome = @Nome, 
		IDPrevilegio = @IDPrevilegio
	
	WHERE 
	
		IDUsuario = @IDUsuario
	
	SELECT @IDUsuario AS Retorno

END
GO
/****** Object:  StoredProcedure [dbo].[procedUsuarioConsulta]    Script Date: 10/09/2015 00:16:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procedUsuarioConsulta]
	
AS
BEGIN

	SELECT 
	
		tblUsuario.IDUsuario, 
		tblUsuario.Nome, 
		tblPrevilegio.Previlegio

	FROM 
		tblUsuario
		
	LEFT JOIN
		tblPrevilegio ON
			tblPrevilegio.IDPrevilegio = tblUsuario.IDPrevilegio
		
END
GO
/****** Object:  StoredProcedure [dbo].[procedTestarPermissao]    Script Date: 10/09/2015 00:16:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procedTestarPermissao]

	@IDUsuario int,
	@Permissao varchar(50)
	
AS
BEGIN
	
	SELECT
		tblUsuario.IDPrevilegio
	FROM
		tblUsuario
		
			JOIN tblPrevilegio ON
				tblPrevilegio.IDPrevilegio = tblUsuario.IDPrevilegio
					JOIN tblPermissao ON
						tblPermissao.IDPrevilegio = tblPrevilegio.IDPrevilegio
							AND 
								tblPermissao.Permissao = @Permissao
								
	WHERE 
		tblUsuario.IDUsuario = @IDUsuario

END
GO
/****** Object:  ForeignKey [FK_tblUsuario_tblPrivilegio]    Script Date: 10/09/2015 00:16:18 ******/
ALTER TABLE [dbo].[tblUsuario]  WITH CHECK ADD  CONSTRAINT [FK_tblUsuario_tblPrivilegio] FOREIGN KEY([IDPrevilegio])
REFERENCES [dbo].[tblPrevilegio] ([IDPrevilegio])
GO
ALTER TABLE [dbo].[tblUsuario] CHECK CONSTRAINT [FK_tblUsuario_tblPrivilegio]
GO
/****** Object:  ForeignKey [FK_tblPermissao_tblPrivilegio]    Script Date: 10/09/2015 00:16:18 ******/
ALTER TABLE [dbo].[tblPermissao]  WITH CHECK ADD  CONSTRAINT [FK_tblPermissao_tblPrivilegio] FOREIGN KEY([IDPrevilegio])
REFERENCES [dbo].[tblPrevilegio] ([IDPrevilegio])
GO
ALTER TABLE [dbo].[tblPermissao] CHECK CONSTRAINT [FK_tblPermissao_tblPrivilegio]
GO
