Select DISTINCT A.idObra, B.RFC, b.Facturar, c.IdCliente, d.Cliente From PermisoEmpresa as A
inner join Obra As c on a.IdObra = c.Idobra
left join Razonsocial as b on b.RFC = c.RFC
left JOIN cliente as d on d.IdCliente = c.idcliente
order by A.idobra, b.RFC

