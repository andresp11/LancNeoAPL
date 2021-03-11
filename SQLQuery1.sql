use lanc
select O.IdObra, R.RFC, R.Facturar, C.IdCliente, C.Cliente from Obra as O
inner join Razonsocial as R on O.RFC = R.RFC
inner join cliente as C on R.IdCliente = C.IdCliente
order by C.Cliente, R.RFC, Idobra

select E.IdObra, u.IDPERFILWEB, U.IDUSUARIO FROM PermisoEmpresa as E
INNER join USUARIOWEB as U on ltrim(rtrim(E.IdPerfil)) = ltrim(rtrim(U.IDUSUARIO))
where ltrim(rtrim(U.IDPERFILWEB)) <> 'adm001' and ltrim(rtrim(U.IDPERFILWEB)) <> 'Gerent'
Order By E.IdObra