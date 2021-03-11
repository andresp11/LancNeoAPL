use lanc
SELECT DISTINCT IdObra, Muestra, IdObra + str(Muestra,10), Fecha as Campo FROM Muestras
WHERE (IdObra + str(Muestra,10)) In 
(SELECT IdObra + str(Muestra,10) as Campo FROM Muestras As psudónimo 
GROUP BY (IdObra + str(Muestra,10)) HAVING Count(*) > 1 ) 
ORDER BY Campo
