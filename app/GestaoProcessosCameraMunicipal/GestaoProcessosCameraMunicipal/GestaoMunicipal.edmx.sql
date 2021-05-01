
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/01/2021 12:23:16
-- Generated from EDMX file: C:\Users\badal\OneDrive\Documentos\GitHub\PSI_DA_PL1-A\app\GestaoProcessosCameraMunicipal\GestaoProcessosCameraMunicipal\GestaoMunicipal.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GestaoMunicipal];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TipoDocumentoSet'
CREATE TABLE [dbo].[TipoDocumentoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PromotorSet'
CREATE TABLE [dbo].[PromotorSet] (
    [NIF] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [CodigoAcesso] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProcessoSet'
CREATE TABLE [dbo].[ProcessoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataInicio] datetime  NOT NULL,
    [PromotorNIF] int  NOT NULL,
    [EstadoProcessoId] int  NOT NULL
);
GO

-- Creating table 'EstadoProcessoSet'
CREATE TABLE [dbo].[EstadoProcessoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DescricaoEstado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DocumentoSet'
CREATE TABLE [dbo].[DocumentoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Titulo] nvarchar(max)  NOT NULL,
    [DataEntrega] datetime  NOT NULL,
    [TipoDocumentoId] int  NOT NULL,
    [ProjetoId] int  NOT NULL,
    [ProjetoProcessoId] int  NOT NULL,
    [ParecerNumero] int  NOT NULL
);
GO

-- Creating table 'ProjetoSet'
CREATE TABLE [dbo].[ProjetoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EstadoProjeto] nvarchar(max)  NOT NULL,
    [DataEntrada] datetime  NOT NULL,
    [DataAprovacao] datetime  NOT NULL,
    [TipoProjetoId] int  NOT NULL,
    [ProcessoId] int  NOT NULL
);
GO

-- Creating table 'TipoProjetoSet'
CREATE TABLE [dbo].[TipoProjetoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NrDiasAprovacao] int  NOT NULL,
    [TipoProjetoId] int  NOT NULL
);
GO

-- Creating table 'ParecerSet'
CREATE TABLE [dbo].[ParecerSet] (
    [Numero] int IDENTITY(1,1) NOT NULL,
    [TextoParecer] nvarchar(max)  NOT NULL,
    [DataParecer] datetime  NOT NULL,
    [ProjetoId] int  NOT NULL,
    [ProjetoProcessoId] int  NOT NULL,
    [FuncionarioNumero] int  NOT NULL
);
GO

-- Creating table 'FuncionarioSet'
CREATE TABLE [dbo].[FuncionarioSet] (
    [Numero] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Extencao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EspecialistaSet'
CREATE TABLE [dbo].[EspecialistaSet] (
    [TipoProjetoId] int  NOT NULL,
    [FuncionarioNumero1] int  NOT NULL
);
GO

-- Creating table 'ProjetoAtribuidoSet'
CREATE TABLE [dbo].[ProjetoAtribuidoSet] (
    [Data] datetime  NOT NULL,
    [ProjetoId] int  NOT NULL,
    [ProjetoProcessoId] int  NOT NULL,
    [FuncionarioNumero] int  NOT NULL,
    [Projeto_Id] int  NOT NULL,
    [Projeto_ProcessoId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TipoDocumentoSet'
ALTER TABLE [dbo].[TipoDocumentoSet]
ADD CONSTRAINT [PK_TipoDocumentoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [NIF] in table 'PromotorSet'
ALTER TABLE [dbo].[PromotorSet]
ADD CONSTRAINT [PK_PromotorSet]
    PRIMARY KEY CLUSTERED ([NIF] ASC);
GO

-- Creating primary key on [Id] in table 'ProcessoSet'
ALTER TABLE [dbo].[ProcessoSet]
ADD CONSTRAINT [PK_ProcessoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EstadoProcessoSet'
ALTER TABLE [dbo].[EstadoProcessoSet]
ADD CONSTRAINT [PK_EstadoProcessoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id], [ProjetoId], [ProjetoProcessoId] in table 'DocumentoSet'
ALTER TABLE [dbo].[DocumentoSet]
ADD CONSTRAINT [PK_DocumentoSet]
    PRIMARY KEY CLUSTERED ([Id], [ProjetoId], [ProjetoProcessoId] ASC);
GO

-- Creating primary key on [Id], [ProcessoId] in table 'ProjetoSet'
ALTER TABLE [dbo].[ProjetoSet]
ADD CONSTRAINT [PK_ProjetoSet]
    PRIMARY KEY CLUSTERED ([Id], [ProcessoId] ASC);
GO

-- Creating primary key on [Id] in table 'TipoProjetoSet'
ALTER TABLE [dbo].[TipoProjetoSet]
ADD CONSTRAINT [PK_TipoProjetoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Numero] in table 'ParecerSet'
ALTER TABLE [dbo].[ParecerSet]
ADD CONSTRAINT [PK_ParecerSet]
    PRIMARY KEY CLUSTERED ([Numero] ASC);
GO

-- Creating primary key on [Numero] in table 'FuncionarioSet'
ALTER TABLE [dbo].[FuncionarioSet]
ADD CONSTRAINT [PK_FuncionarioSet]
    PRIMARY KEY CLUSTERED ([Numero] ASC);
GO

-- Creating primary key on [TipoProjetoId], [FuncionarioNumero1] in table 'EspecialistaSet'
ALTER TABLE [dbo].[EspecialistaSet]
ADD CONSTRAINT [PK_EspecialistaSet]
    PRIMARY KEY CLUSTERED ([TipoProjetoId], [FuncionarioNumero1] ASC);
GO

-- Creating primary key on [ProjetoId], [ProjetoProcessoId] in table 'ProjetoAtribuidoSet'
ALTER TABLE [dbo].[ProjetoAtribuidoSet]
ADD CONSTRAINT [PK_ProjetoAtribuidoSet]
    PRIMARY KEY CLUSTERED ([ProjetoId], [ProjetoProcessoId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TipoDocumentoId] in table 'DocumentoSet'
ALTER TABLE [dbo].[DocumentoSet]
ADD CONSTRAINT [FK_TipoDocumentoDocumento]
    FOREIGN KEY ([TipoDocumentoId])
    REFERENCES [dbo].[TipoDocumentoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoDocumentoDocumento'
CREATE INDEX [IX_FK_TipoDocumentoDocumento]
ON [dbo].[DocumentoSet]
    ([TipoDocumentoId]);
GO

-- Creating foreign key on [PromotorNIF] in table 'ProcessoSet'
ALTER TABLE [dbo].[ProcessoSet]
ADD CONSTRAINT [FK_PromotorProcesso]
    FOREIGN KEY ([PromotorNIF])
    REFERENCES [dbo].[PromotorSet]
        ([NIF])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PromotorProcesso'
CREATE INDEX [IX_FK_PromotorProcesso]
ON [dbo].[ProcessoSet]
    ([PromotorNIF]);
GO

-- Creating foreign key on [EstadoProcessoId] in table 'ProcessoSet'
ALTER TABLE [dbo].[ProcessoSet]
ADD CONSTRAINT [FK_EstadoProcessoProcesso]
    FOREIGN KEY ([EstadoProcessoId])
    REFERENCES [dbo].[EstadoProcessoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoProcessoProcesso'
CREATE INDEX [IX_FK_EstadoProcessoProcesso]
ON [dbo].[ProcessoSet]
    ([EstadoProcessoId]);
GO

-- Creating foreign key on [TipoProjetoId] in table 'ProjetoSet'
ALTER TABLE [dbo].[ProjetoSet]
ADD CONSTRAINT [FK_TipoProjetoProjeto]
    FOREIGN KEY ([TipoProjetoId])
    REFERENCES [dbo].[TipoProjetoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoProjetoProjeto'
CREATE INDEX [IX_FK_TipoProjetoProjeto]
ON [dbo].[ProjetoSet]
    ([TipoProjetoId]);
GO

-- Creating foreign key on [ProcessoId] in table 'ProjetoSet'
ALTER TABLE [dbo].[ProjetoSet]
ADD CONSTRAINT [FK_ProcessoProjeto]
    FOREIGN KEY ([ProcessoId])
    REFERENCES [dbo].[ProcessoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProcessoProjeto'
CREATE INDEX [IX_FK_ProcessoProjeto]
ON [dbo].[ProjetoSet]
    ([ProcessoId]);
GO

-- Creating foreign key on [ProjetoId], [ProjetoProcessoId] in table 'DocumentoSet'
ALTER TABLE [dbo].[DocumentoSet]
ADD CONSTRAINT [FK_ProjetoDocumento]
    FOREIGN KEY ([ProjetoId], [ProjetoProcessoId])
    REFERENCES [dbo].[ProjetoSet]
        ([Id], [ProcessoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjetoDocumento'
CREATE INDEX [IX_FK_ProjetoDocumento]
ON [dbo].[DocumentoSet]
    ([ProjetoId], [ProjetoProcessoId]);
GO

-- Creating foreign key on [ProjetoId], [ProjetoProcessoId] in table 'ParecerSet'
ALTER TABLE [dbo].[ParecerSet]
ADD CONSTRAINT [FK_ProjetoParecer]
    FOREIGN KEY ([ProjetoId], [ProjetoProcessoId])
    REFERENCES [dbo].[ProjetoSet]
        ([Id], [ProcessoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjetoParecer'
CREATE INDEX [IX_FK_ProjetoParecer]
ON [dbo].[ParecerSet]
    ([ProjetoId], [ProjetoProcessoId]);
GO

-- Creating foreign key on [Projeto_Id], [Projeto_ProcessoId] in table 'ProjetoAtribuidoSet'
ALTER TABLE [dbo].[ProjetoAtribuidoSet]
ADD CONSTRAINT [FK_ProjetoProjetoAtribuido]
    FOREIGN KEY ([Projeto_Id], [Projeto_ProcessoId])
    REFERENCES [dbo].[ProjetoSet]
        ([Id], [ProcessoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjetoProjetoAtribuido'
CREATE INDEX [IX_FK_ProjetoProjetoAtribuido]
ON [dbo].[ProjetoAtribuidoSet]
    ([Projeto_Id], [Projeto_ProcessoId]);
GO

-- Creating foreign key on [FuncionarioNumero] in table 'ParecerSet'
ALTER TABLE [dbo].[ParecerSet]
ADD CONSTRAINT [FK_FuncionarioParecer]
    FOREIGN KEY ([FuncionarioNumero])
    REFERENCES [dbo].[FuncionarioSet]
        ([Numero])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionarioParecer'
CREATE INDEX [IX_FK_FuncionarioParecer]
ON [dbo].[ParecerSet]
    ([FuncionarioNumero]);
GO

-- Creating foreign key on [FuncionarioNumero1] in table 'EspecialistaSet'
ALTER TABLE [dbo].[EspecialistaSet]
ADD CONSTRAINT [FK_FuncionarioEspecialista]
    FOREIGN KEY ([FuncionarioNumero1])
    REFERENCES [dbo].[FuncionarioSet]
        ([Numero])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionarioEspecialista'
CREATE INDEX [IX_FK_FuncionarioEspecialista]
ON [dbo].[EspecialistaSet]
    ([FuncionarioNumero1]);
GO

-- Creating foreign key on [FuncionarioNumero] in table 'ProjetoAtribuidoSet'
ALTER TABLE [dbo].[ProjetoAtribuidoSet]
ADD CONSTRAINT [FK_FuncionarioProjetoAtribuido]
    FOREIGN KEY ([FuncionarioNumero])
    REFERENCES [dbo].[FuncionarioSet]
        ([Numero])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionarioProjetoAtribuido'
CREATE INDEX [IX_FK_FuncionarioProjetoAtribuido]
ON [dbo].[ProjetoAtribuidoSet]
    ([FuncionarioNumero]);
GO

-- Creating foreign key on [TipoProjetoId] in table 'EspecialistaSet'
ALTER TABLE [dbo].[EspecialistaSet]
ADD CONSTRAINT [FK_TipoProjetoEspecialista]
    FOREIGN KEY ([TipoProjetoId])
    REFERENCES [dbo].[TipoProjetoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------