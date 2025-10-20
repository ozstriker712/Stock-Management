create TRIGGER [dbo].[6_tracking_event_prix_AVG]
   ON  [dbo].[stocks_inSet] 
   AFTER  INSERT,UPDATE 
AS 
 
  declare @code_materiel int;
  declare @prix decimal;
  
BEGIN
  set @code_materiel = (select les_articles_id_article  from inserted);
  set @prix	=(select AVG(prix_article) from stocks_inSet where les_articles_id_article=@code_materiel)
 
  update les_articlesSet
  set prixx_artcl_stock=@prix
  from les_articlesSet
  where id_article = @code_materiel;
  
END