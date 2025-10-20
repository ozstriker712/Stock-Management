create TRIGGER [dbo].[5_tracking_event_prix_MAX]
   ON  [dbo].[stocks_inSet] 
   AFTER  INSERT,UPDATE 
AS 
 
  declare @code_materiel int;
  declare @prix decimal;
  
BEGIN
  set @code_materiel = (select les_articles_id_article  from inserted);
  set @prix	=(select MAX(prix_article) from stocks_inSet where les_articles_id_article=@code_materiel)
 
  update les_articlesSet
  set prixx_artcl_stock=@prix
  from les_articlesSet
  where id_article = @code_materiel;
  
END