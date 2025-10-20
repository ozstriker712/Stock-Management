INSERT INTO [gestion_de_stock].[dbo].[usersSet]
           ([user_names]
           ,[passwords]
           ,[permissions])
     VALUES
           ('Administrateur' ,  '' , 1)
            
GO

INSERT INTO [gestion_de_stock].[dbo].[settingsSet]
           ([etat_price]
           ,[etat_config])
     VALUES
           (1,'False')
GO

