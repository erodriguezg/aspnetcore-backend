create table comunas (
   id_comuna            int4                 not null,
   id_provincia         int4                 null,
   nombre               varchar(100)         not null,
   constraint pk_comunas primary key (id_comuna)
);

create table perfiles_usuarios (
   id_perfil_usuario    int4                 not null,
   nombre               varchar(100)         not null,
   constraint pk_perfiles_usuarios primary key (id_perfil_usuario)
);

create table personas (
   id_persona           bigserial            not null,
   id_comuna            int4                 null,
   run                  int4                 null,
   nombres              varchar(255)         not null,
   apellido_paterno      varchar(255)         not null,
   apellido_materno      varchar(255)         null,
   fechanacimiento      date                 null,
   telefono             varchar(20)          null,
   email                varchar(100)         not null,
   constraint pk_personas primary key (id_persona)
);

create unique index idx_personas_email on personas (email);
create unique index idx_personas_run on personas (run);

create table provincias (
   id_provincia         int4                 not null,
   id_region            int4                 null,
   nombre               varchar(100)         not null,
   constraint pk_provincias primary key (id_provincia)
);

create table regiones (
   id_region            int4                 not null,
   nombre               varchar(100)         not null,
   constraint pk_regiones primary key (id_region)
);

create table usuarios (
   id_persona           int8                 not null,
   id_perfil_usuario    int4                 not null,
   username             varchar(255)         not null,
   password             varchar(500)         null,
   habilitado           boolean              not null,
   constraint pk_usuarios primary key (id_persona)
);

create unique index idx_usuarios_username on usuarios (username);

alter table comunas
   add constraint fk_comunas_reference_provinci foreign key (id_provincia)
      references provincias (id_provincia);

alter table provincias
   add constraint fk_provinci_reference_region foreign key (id_region)
      references regiones (id_region);

alter table usuarios
   add constraint fk_usuarios_reference_persona foreign key (id_persona)
      references personas (id_persona);

alter table usuarios
   add constraint fk_usuarios_reference_perfil_u foreign key (id_perfil_usuario)
      references perfiles_usuarios (id_perfil_usuario);

alter table personas
   add constraint fk_persona_reference_comuna foreign key (id_comuna)
      references comunas (id_comuna);