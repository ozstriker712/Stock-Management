
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/05/2018 23:40:39
-- Generated from EDMX file: E:\MY Application\GESTION DE STOCK\GESTION_DE_STOCK\GESTION_DE_STOCK\GESTION_DE_STOCK\GESTION_DE_STOCK\model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [gestion_de_stock];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_les_articlesstocks_in]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[stocks_inSet] DROP CONSTRAINT [FK_les_articlesstocks_in];
GO
IF OBJECT_ID(N'[dbo].[FK_les_articlesstock_out]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[stock_outSet] DROP CONSTRAINT [FK_les_articlesstock_out];
GO
IF OBJECT_ID(N'[dbo].[FK_fornisseurdevis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[devisSet] DROP CONSTRAINT [FK_fornisseurdevis];
GO
IF OBJECT_ID(N'[dbo].[FK_devisstocks_in]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[stocks_inSet] DROP CONSTRAINT [FK_devisstocks_in];
GO
IF OBJECT_ID(N'[dbo].[FK_les_servicesles_bon]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[les_bonSet] DROP CONSTRAINT [FK_les_servicesles_bon];
GO
IF OBJECT_ID(N'[dbo].[FK_les_bonstock_out]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[stock_outSet] DROP CONSTRAINT [FK_les_bonstock_out];
GO
IF OBJECT_ID(N'[dbo].[FK_catgrles_articles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[les_articlesSet] DROP CONSTRAINT [FK_catgrles_articles];
GO
IF OBJECT_ID(N'[dbo].[FK_fornisseurforni_activite]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[forni_activiteSet] DROP CONSTRAINT [FK_fornisseurforni_activite];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[usersSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usersSet];
GO
IF OBJECT_ID(N'[dbo].[les_articlesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[les_articlesSet];
GO
IF OBJECT_ID(N'[dbo].[stocks_inSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[stocks_inSet];
GO
IF OBJECT_ID(N'[dbo].[stock_outSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[stock_outSet];
GO
IF OBJECT_ID(N'[dbo].[fornisseurSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[fornisseurSet];
GO
IF OBJECT_ID(N'[dbo].[devisSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[devisSet];
GO
IF OBJECT_ID(N'[dbo].[les_servicesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[les_servicesSet];
GO
IF OBJECT_ID(N'[dbo].[les_bonSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[les_bonSet];
GO
IF OBJECT_ID(N'[dbo].[catgrSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[catgrSet];
GO
IF OBJECT_ID(N'[dbo].[settingsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[settingsSet];
GO
IF OBJECT_ID(N'[dbo].[type_activite_fornisseurSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[type_activite_fornisseurSet];
GO
IF OBJECT_ID(N'[dbo].[forni_activiteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[forni_activiteSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'usersSet'
CREATE TABLE [dbo].[usersSet] (
    [id_user] int IDENTITY(1,1) NOT NULL,
    [user_names] nvarchar(max)  NOT NULL,
    [passwords] nvarchar(max)  NOT NULL,
    [permissions] int  NOT NULL
);
GO

-- Creating table 'les_articlesSet'
CREATE TABLE [dbo].[les_articlesSet] (
    [id_article] int IDENTITY(1,1) NOT NULL,
    [nom_article] nvarchar(max)  NOT NULL,
    [quantite_total] int  NULL,
    [catgr_id_catgr] int  NOT NULL,
    [prixx_artcl_stock] decimal(18,2)  NULL
);
GO

-- Creating table 'stocks_inSet'
CREATE TABLE [dbo].[stocks_inSet] (
    [id_stock_in] int IDENTITY(1,1) NOT NULL,
    [date_in] datetime  NOT NULL,
    [quantite_in] int  NOT NULL,
    [les_articles_id_article] int  NOT NULL,
    [prix_article] decimal(18,2)  NOT NULL,
    [devis_id_devis] int  NOT NULL,
    [prix_in_unitaire_x_quntite] decimal(18,2)  NULL
);
GO

-- Creating table 'stock_outSet'
CREATE TABLE [dbo].[stock_outSet] (
    [id_stock_out] int IDENTITY(1,1) NOT NULL,
    [date_out] datetime  NOT NULL,
    [quantite_out] int  NOT NULL,
    [les_articles_id_article] int  NOT NULL,
    [les_bon_id_bon] int  NOT NULL,
    [prix_article_out] decimal(18,2)  NOT NULL,
    [prix_out_unitaire_x_quantite] decimal(18,2)  NULL
);
GO

-- Creating table 'fornisseurSet'
CREATE TABLE [dbo].[fornisseurSet] (
    [id_fornisseur] int IDENTITY(1,1) NOT NULL,
    [nom_fornisseur] nvarchar(max)  NOT NULL,
    [prenom_fornisseur] nvarchar(max)  NOT NULL,
    [societe_fornisseur] nvarchar(max)  NULL,
    [date_naic_forn] datetime  NULL,
    [lieu_naic_forn] nvarchar(max)  NULL,
    [addrs_forn_pers] nvarchar(max)  NOT NULL,
    [addrs_forn_fonct] nvarchar(max)  NOT NULL,
    [phone_numbre_forn] int  NULL,
    [num_id_fiscale] int  NOT NULL,
    [num_id_statistique] int  NOT NULL,
    [num_eng_commercial] nvarchar(max)  NOT NULL,
    [date_eng_commercial] datetime  NOT NULL,
    [num_bankaire] int  NOT NULL,
    [nom_bankaire] nvarchar(max)  NOT NULL,
    [nom_agence_bankaire] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'devisSet'
CREATE TABLE [dbo].[devisSet] (
    [id_devis] int IDENTITY(1,1) NOT NULL,
    [n_facture] int  NOT NULL,
    [date_facture] datetime  NOT NULL,
    [fornisseur_id_fornisseur] int  NOT NULL
);
GO

-- Creating table 'les_servicesSet'
CREATE TABLE [dbo].[les_servicesSet] (
    [id_service] int IDENTITY(1,1) NOT NULL,
    [nom_service] nvarchar(max)  NOT NULL,
    [nom_responsable_srvc] nvarchar(max)  NULL
);
GO

-- Creating table 'les_bonSet'
CREATE TABLE [dbo].[les_bonSet] (
    [id_bon] int IDENTITY(1,1) NOT NULL,
    [n_bon] int  NOT NULL,
    [date_bon] datetime  NOT NULL,
    [les_services_id_service] int  NOT NULL
);
GO

-- Creating table 'catgrSet'
CREATE TABLE [dbo].[catgrSet] (
    [id_catgr] int IDENTITY(1,1) NOT NULL,
    [nom_catgr] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'settingsSet'
CREATE TABLE [dbo].[settingsSet] (
    [id_setting] int IDENTITY(1,1) NOT NULL,
    [etat_price] int  NOT NULL,
    [etat_config] bit  NOT NULL
);
GO

-- Creating table 'type_activite_fornisseurSet'
CREATE TABLE [dbo].[type_activite_fornisseurSet] (
    [id_activi_forn] int IDENTITY(1,1) NOT NULL,
    [code_activite] int  NOT NULL,
    [nom_activite] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'forni_activiteSet'
CREATE TABLE [dbo].[forni_activiteSet] (
    [id_forni_actv] int IDENTITY(1,1) NOT NULL,
    [code_active] int  NOT NULL,
    [nom_active] nvarchar(max)  NOT NULL,
    [fornisseur_id_fornisseur] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id_user] in table 'usersSet'
ALTER TABLE [dbo].[usersSet]
ADD CONSTRAINT [PK_usersSet]
    PRIMARY KEY CLUSTERED ([id_user] ASC);
GO

-- Creating primary key on [id_article] in table 'les_articlesSet'
ALTER TABLE [dbo].[les_articlesSet]
ADD CONSTRAINT [PK_les_articlesSet]
    PRIMARY KEY CLUSTERED ([id_article] ASC);
GO

-- Creating primary key on [id_stock_in] in table 'stocks_inSet'
ALTER TABLE [dbo].[stocks_inSet]
ADD CONSTRAINT [PK_stocks_inSet]
    PRIMARY KEY CLUSTERED ([id_stock_in] ASC);
GO

-- Creating primary key on [id_stock_out] in table 'stock_outSet'
ALTER TABLE [dbo].[stock_outSet]
ADD CONSTRAINT [PK_stock_outSet]
    PRIMARY KEY CLUSTERED ([id_stock_out] ASC);
GO

-- Creating primary key on [id_fornisseur] in table 'fornisseurSet'
ALTER TABLE [dbo].[fornisseurSet]
ADD CONSTRAINT [PK_fornisseurSet]
    PRIMARY KEY CLUSTERED ([id_fornisseur] ASC);
GO

-- Creating primary key on [id_devis] in table 'devisSet'
ALTER TABLE [dbo].[devisSet]
ADD CONSTRAINT [PK_devisSet]
    PRIMARY KEY CLUSTERED ([id_devis] ASC);
GO

-- Creating primary key on [id_service] in table 'les_servicesSet'
ALTER TABLE [dbo].[les_servicesSet]
ADD CONSTRAINT [PK_les_servicesSet]
    PRIMARY KEY CLUSTERED ([id_service] ASC);
GO

-- Creating primary key on [id_bon] in table 'les_bonSet'
ALTER TABLE [dbo].[les_bonSet]
ADD CONSTRAINT [PK_les_bonSet]
    PRIMARY KEY CLUSTERED ([id_bon] ASC);
GO

-- Creating primary key on [id_catgr] in table 'catgrSet'
ALTER TABLE [dbo].[catgrSet]
ADD CONSTRAINT [PK_catgrSet]
    PRIMARY KEY CLUSTERED ([id_catgr] ASC);
GO

-- Creating primary key on [id_setting] in table 'settingsSet'
ALTER TABLE [dbo].[settingsSet]
ADD CONSTRAINT [PK_settingsSet]
    PRIMARY KEY CLUSTERED ([id_setting] ASC);
GO

-- Creating primary key on [id_activi_forn] in table 'type_activite_fornisseurSet'
ALTER TABLE [dbo].[type_activite_fornisseurSet]
ADD CONSTRAINT [PK_type_activite_fornisseurSet]
    PRIMARY KEY CLUSTERED ([id_activi_forn] ASC);
GO

-- Creating primary key on [id_forni_actv] in table 'forni_activiteSet'
ALTER TABLE [dbo].[forni_activiteSet]
ADD CONSTRAINT [PK_forni_activiteSet]
    PRIMARY KEY CLUSTERED ([id_forni_actv] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [les_articles_id_article] in table 'stocks_inSet'
ALTER TABLE [dbo].[stocks_inSet]
ADD CONSTRAINT [FK_les_articlesstocks_in]
    FOREIGN KEY ([les_articles_id_article])
    REFERENCES [dbo].[les_articlesSet]
        ([id_article])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_les_articlesstocks_in'
CREATE INDEX [IX_FK_les_articlesstocks_in]
ON [dbo].[stocks_inSet]
    ([les_articles_id_article]);
GO

-- Creating foreign key on [les_articles_id_article] in table 'stock_outSet'
ALTER TABLE [dbo].[stock_outSet]
ADD CONSTRAINT [FK_les_articlesstock_out]
    FOREIGN KEY ([les_articles_id_article])
    REFERENCES [dbo].[les_articlesSet]
        ([id_article])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_les_articlesstock_out'
CREATE INDEX [IX_FK_les_articlesstock_out]
ON [dbo].[stock_outSet]
    ([les_articles_id_article]);
GO

-- Creating foreign key on [fornisseur_id_fornisseur] in table 'devisSet'
ALTER TABLE [dbo].[devisSet]
ADD CONSTRAINT [FK_fornisseurdevis]
    FOREIGN KEY ([fornisseur_id_fornisseur])
    REFERENCES [dbo].[fornisseurSet]
        ([id_fornisseur])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_fornisseurdevis'
CREATE INDEX [IX_FK_fornisseurdevis]
ON [dbo].[devisSet]
    ([fornisseur_id_fornisseur]);
GO

-- Creating foreign key on [devis_id_devis] in table 'stocks_inSet'
ALTER TABLE [dbo].[stocks_inSet]
ADD CONSTRAINT [FK_devisstocks_in]
    FOREIGN KEY ([devis_id_devis])
    REFERENCES [dbo].[devisSet]
        ([id_devis])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_devisstocks_in'
CREATE INDEX [IX_FK_devisstocks_in]
ON [dbo].[stocks_inSet]
    ([devis_id_devis]);
GO

-- Creating foreign key on [les_services_id_service] in table 'les_bonSet'
ALTER TABLE [dbo].[les_bonSet]
ADD CONSTRAINT [FK_les_servicesles_bon]
    FOREIGN KEY ([les_services_id_service])
    REFERENCES [dbo].[les_servicesSet]
        ([id_service])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_les_servicesles_bon'
CREATE INDEX [IX_FK_les_servicesles_bon]
ON [dbo].[les_bonSet]
    ([les_services_id_service]);
GO

-- Creating foreign key on [les_bon_id_bon] in table 'stock_outSet'
ALTER TABLE [dbo].[stock_outSet]
ADD CONSTRAINT [FK_les_bonstock_out]
    FOREIGN KEY ([les_bon_id_bon])
    REFERENCES [dbo].[les_bonSet]
        ([id_bon])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_les_bonstock_out'
CREATE INDEX [IX_FK_les_bonstock_out]
ON [dbo].[stock_outSet]
    ([les_bon_id_bon]);
GO

-- Creating foreign key on [catgr_id_catgr] in table 'les_articlesSet'
ALTER TABLE [dbo].[les_articlesSet]
ADD CONSTRAINT [FK_catgrles_articles]
    FOREIGN KEY ([catgr_id_catgr])
    REFERENCES [dbo].[catgrSet]
        ([id_catgr])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_catgrles_articles'
CREATE INDEX [IX_FK_catgrles_articles]
ON [dbo].[les_articlesSet]
    ([catgr_id_catgr]);
GO

-- Creating foreign key on [fornisseur_id_fornisseur] in table 'forni_activiteSet'
ALTER TABLE [dbo].[forni_activiteSet]
ADD CONSTRAINT [FK_fornisseurforni_activite]
    FOREIGN KEY ([fornisseur_id_fornisseur])
    REFERENCES [dbo].[fornisseurSet]
        ([id_fornisseur])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_fornisseurforni_activite'
CREATE INDEX [IX_FK_fornisseurforni_activite]
ON [dbo].[forni_activiteSet]
    ([fornisseur_id_fornisseur]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------