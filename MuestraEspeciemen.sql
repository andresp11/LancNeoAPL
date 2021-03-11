Use lanc

Select E.IdObra, E.Fecha, E.Consecutivo, E.IdEspecimen, e.dia, M.tipo, vapor From Especimen as E
inner join Muestras as M on M.IdObra = E.IdObra and M.Fecha = E.Fecha and M.Consecutivo = E.Consecutivo
Where M.Tipo = 7 --and IdEspecimen > 4
order by Fecha desc