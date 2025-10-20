CREATE TRIGGER [dbo].[1_tracking_event_delete]
   ON  [dbo].[stocks_inSet]  
   after delete 
AS 
  declare @somme int;
  declare @somme_other int;
  declare @code_materiel int;
  declare @get_id_stock_in int;
  
BEGIN
  set @code_materiel = (select les_articles_id_article  from deleted) 
  set @somme = (select SUM(quantite_in) from stocks_inSet where les_articles_id_article= @code_materiel)
  set @somme_other = (select  sum(quantite_out)  from stock_outSet where les_articles_id_article= @code_materiel)
  set @get_id_stock_in = (select  id_stock_in  from deleted)
  
  IF (@somme_other!=0) 
  update les_articlesSet
  set quantite_total=@somme-@somme_other
  from les_articlesSet
  where id_article = @code_materiel;
  
  ELSE
  update les_articlesSet
  set quantite_total=@somme	 
  from les_articlesSet
  where id_article = @code_materiel;
  
  update stocks_inSet
  set prix_in_unitaire_x_quntite =quantite_in*prix_article
  from stocks_inSet
  where id_stock_in = @get_id_stock_in
  
END