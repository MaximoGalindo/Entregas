CREATE PROC SP_tipoCuenta
AS
Select * from TipoCuenta

go
CREATE PROC SP_lstClientes
AS
SELECT * FROM Cliente


go
Create PROC [dbo].[SP_lstCuentas]
AS
SELECT dni,cbu,saldo,id_cuenta,ultMov 
FROM Cuenta


go
CREATE PROC SP_insertCliente
@dni int,
@nombre varchar(60),
@apellido varchar(60)
AS
INSERT INTO Cliente (dni,nombre,apellido) VALUES (@dni,@nombre,@apellido)

GO
CREATE PROC SP_insertCuenta
@saldo money,
@tipoCuenta int, 
@ultMov datetime,
@dni int
AS
INSERT INTO Cuenta (saldo,id_cuenta,ultMov,dni) VALUES (@saldo,@tipoCuenta,@ultMov,@dni)

go
CREATE PROC SP_deleteCliente
@dni int
AS
DELETE Cliente where dni = @dni

Create Proc SP_cuentaTipo
AS
select cl.dni, nombre,apellido,cbu,saldo,tipoCuenta,ultMov
from Cuenta c  join Cliente cl on c.dni = cl.dni join TipoCuenta t on c.id_cuenta = t.id_cuenta


create proc cargarCuentaCliente
@dni int 
as 
select cbu,tipoCuenta,ultMov,saldo from Cuenta c join TipoCuenta t on c.id_cuenta = t.id_cuenta
where dni = @dni


create proc cargarCliente 
@dni int 
as
select * from Cliente
where dni = @dni