CREATE TRIGGER [dbo].[4_tracking_event_delete_out_stock]
   ON  [dbo].[stock_outSet]  
   after delete 
AS 
  declare @sommein int;
  declare @sommeout int;
  declare @code_materiel int;
  declare @result int;
bEGIN
  set @code_materiel = (select les_articles_id_article  from deleted);
  set @sommein = (select   sum(quantite_in)  from stocks_inSet where les_articles_id_article= @code_materiel)
  set @sommeout = (select   sum(quantite_out)  from stock_outSet where les_articles_id_article= @code_materiel)
   set @result = @sommein-@sommeout
   
   
 if (@sommein-@sommeout !='0') 
  
  update les_articlesSet
  set quantite_total=@result 
  from les_articlesSet
  where id_article = @code_materiel;
 else
 update les_articlesSet
  set quantite_total=@sommein
  from les_articlesSet
  where id_article = @code_materiel;

END