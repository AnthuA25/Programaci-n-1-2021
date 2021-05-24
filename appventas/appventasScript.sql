select *from t_contacto 
insert into t_contacto (firstname,lastname) values('Juan','Perez');
insert into t_contacto (firstname,lastname) values('Angelica','Santa Cruz');
update t_contacto set lastname = 'Garcia'
update t_contacto set lastname = 'Santa Cruz' where firstname = 'Angelica'

update t_contacto set lastname = 'Santa Cruz' where firstname = 'Angelica'
insert into t_contacto (firstname,lastname) values('Julia','Vargas');
delete from t_contacto where firstname = 'Angelica'
d
