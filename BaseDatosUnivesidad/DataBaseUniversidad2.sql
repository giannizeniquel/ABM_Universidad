create database Universidad
use Universidad
-- Tabla Alumno
create table alumno(
	alumnoId int, 
	nombre_a varchar(50),
	apellido_a varchar (50),
	dni_a varchar (15),
	telefono_a varchar(20),
	fechaNacimiento_a datetime,
	edad_a int,
	direccion_a varchar(200),
	pais_a varchar (50),
	provincia_a varchar (50),
	localidad_a varchar (50),
	genero_a varchar (15),
	promedio_a float,
	constraint pk_ca primary key (alumnoId)
)

--Tabla Profesor
create table profesor(
	profesorId int, 
	nombre_p varchar(50),
	apellido_p varchar (50),
	dni_p varchar (15),
	telefono_p varchar(20),
	fechaNacimiento_p datetime,
	edad_p int,
	direccion_p varchar(200),
	pais_p varchar (50),
	provincia_p varchar (50),
	localidad_p varchar (50),
	genero_p varchar (15),
	constraint pk_cp primary key (profesorId)
)
--Table Materia
create table Materia(
	materiaId int,
	correlativaId int,
	nombre_m varchar (50),
	duracion_m varchar (15),
	constraint pk_cm primary key(materiaId),
	constraint fk_fcm1 foreign key (correlativaId) references Materia
)
--Agregamos Materias a ingenieria en sistemas
-- A�o 1
insert into Materia values(1,null,'An�lisis Matem�tico I','Anual')
insert into Materia values(2,null,'�lgebra y Geometr�a Anal�tica','Anual')
insert into Materia values(3,null,'Sistemas y Organizaciones','Anual')
insert into Materia values(4,null,'Algoritmos y Estructuras de Datos','Anual')
insert into Materia values(5,null,'Arquitectura de Computadoras','Anual')
insert into Materia values(6,null,'Sistemas de Representac�n','Anual')
insert into Materia values(7,null,'F�sica I','Anual')
insert into Materia values(8,null,'Matem�tica Discreta','Anual')
update Materia 
set nombre_m = 'Sistemas de Representaci�n'
where materiaId = 6
--A�o 2
insert into Materia values(9,8,'Sintaxis y Sem�ntica de los Lenguajes','Anual')
insert into Materia values(10,4,'Paradigmas de Programaci�n','Anual')
insert into Materia values(11,null,'Ingl�s I','Cuatrimestral')
insert into Materia values(12,3,'An�lisis de Sistemas','Anual')
insert into Materia values(13,8,'Quimica','Cuatrimestral')
insert into Materia values(14,7,'F�sica II','Anual')
insert into Materia values(15,4,'Sistemas Operativos','Anual')
insert into Materia values(35,1,'An�lisis Matem�tico II','Anual')
--A�o 3
insert into Materia values(16,2,'Probabilidades y Estad�sticas','Anual')
insert into Materia values(17,10,'Dise�o de Sistemas','Anual')
insert into Materia values(18,14,'Comunicaciones','Anual')
insert into Materia values(19,35,'Matem�tica Superior','Anual')
insert into Materia values(20,9,'Gesti�n de Datos','Cuatrimestral')
insert into Materia values(21,null,'Ingenier�a y Sociedad','Cuatrimestral')
insert into Materia values(22,12,'Econom�a','Cuatrimestral')
insert into Materia values(23,11,'Ingles II','Cuatrimestral')
-- A�o 4
insert into Materia values(24,18,'Redes de Informaci�n','Anual')
insert into Materia values(25,16,'Investigaci�n Operativa','Cuatrimestral')
insert into Materia values(26,20,'Ingenier�a de Software','Anual')
insert into Materia values(27,22,'Administraci�n de Recursos','Anual')
insert into Materia values(28,19,'Simulaci�n','Cuatrimestral')
insert into Materia values(29,19,'Teor�a de Control','Anual')
insert into Materia values(30,21,'Legislaci�n','Cuatrimestral')
--A�o 5
insert into Materia values(31,24,'Proyecto Final','Anual')
insert into Materia values(32,25,'Inteligencia Artificial','Anual')
insert into Materia values(33,27,'Administraci�n Gerencial','Cuatrimestral')
insert into Materia values(34,28,'Sistemas de Gesti�n','Cuatrimestal')

--Tabla Curso
create table curso(
	cursoId int,
	anio_c int,
	division_c char(1),
	constraint pk_cc primary key (cursoId)
)
-- Agregamos Cursos
insert into curso values (1,1,'A')
insert into curso values (2,1,'B')
insert into curso values (3,2,'A')
insert into curso values (4,2,'B')
insert into curso values (5,3,'A')
insert into curso values (6,3,'B')
insert into curso values (7,4,'A')
insert into curso values (8,5,'A')


--Tabla Aula
create table aula(
	aulaId int,
	capacidad_au int,
	proyector_au bit,
	conexionRed_au bit,
	constraint pk_cau primary key (aulaId)
)
insert into aula values(1,50,1,0)
insert into aula values(2,50,1,0)
insert into aula values(3,30,1,0)
insert into aula values(4,30,1,0)
insert into aula values(5,30,1,1)
insert into aula values(6,30,1,1)
insert into aula values(7,25,1,1)
insert into aula values(8,25,1,1)

-- Tabla connectAll
create table connectAll(
	connectAllId int,
	alumnoId_1 int,
	cursoMateriaId_1 int,
	aulaId_1 int,
	parcial_1 float,
	parcial_2 float,
	parcial_3 float,
	notaFinal float,
	constraint pk_cca primary key (connectAllId),
	constraint fk_fa1 foreign key (alumnoId_1) references alumno (alumnoId),
	constraint fk_fcm2 foreign key (cursoMateriaId_1) references cursoMateria(cursoMateriaId),
	constraint fk_fau1 foreign key (aulaId_1) references aula(aulaId),
)

create table cursoMateria(
	cursoMateriaId int,
	materiaId_1 int,
	cursoId_1 int,
	constraint pk_ccm primary key (cursoMateriaId),
	constraint fk_fm1 foreign key (materiaId_1) references materia (materiaId),
	constraint fk_fc1 foreign key (cursoId_1) references curso (cursoId)
)

--MATERIAS CURSO PRIMER A�O
insert into cursoMateria values(1,1,1)
insert into cursoMateria values(2,1,2)


insert into cursoMateria values(3,2,1)
insert into cursoMateria values(4,2,2)

insert into cursoMateria values(5,3,1)
insert into cursoMateria values(6,3,2)

insert into cursoMateria values(7,4,1)
insert into cursoMateria values(8,4,2)

insert into cursoMateria values(9,5,1)
insert into cursoMateria values(10,5,2)

insert into cursoMateria values(11,6,1)
insert into cursoMateria values(12,6,2)

insert into cursoMateria values(13,7,1)
insert into cursoMateria values(14,7,2)

insert into cursoMateria values(15,8,1)
insert into cursoMateria values(16,8,2)

--MATERIAS CURSO SEGUNDO A�O
insert into cursoMateria values(47,35,3)
insert into cursoMateria values(48,35,4)

insert into cursoMateria values(17,9,3)
insert into cursoMateria values(18,9,4)

insert into cursoMateria values(19,10,3)
insert into cursoMateria values(20,10,4)

insert into cursoMateria values(21,11,3)
insert into cursoMateria values(22,11,4)

insert into cursoMateria values(23,12,3)
insert into cursoMateria values(24,12,4)

insert into cursoMateria values(25,13,3)
insert into cursoMateria values(26,13,4)

insert into cursoMateria values(27,14,3)
insert into cursoMateria values(28,14,4)

insert into cursoMateria values(29,15,3)
insert into cursoMateria values(30,15,4)

--MATERIAS CURSO TERCER A�O
insert into cursoMateria values(31,16,5)
insert into cursoMateria values(32,16,6)

insert into cursoMateria values(33,17,5)
insert into cursoMateria values(34,17,6)

insert into cursoMateria values(35,18,5)
insert into cursoMateria values(36,18,6)

insert into cursoMateria values(37,19,5)
insert into cursoMateria values(38,19,6)

insert into cursoMateria values(39,20,5)
insert into cursoMateria values(40,20,6)

insert into cursoMateria values(41,21,5)
insert into cursoMateria values(42,21,6)

insert into cursoMateria values(43,22,5)
insert into cursoMateria values(44,22,6)

insert into cursoMateria values(45,23,5)
insert into cursoMateria values(46,23,6)

--MATERIAS CURSO CUARTO A�O
insert into cursoMateria values(49,24,7)
insert into cursoMateria values(50,25,7)
insert into cursoMateria values(51,26,7)
insert into cursoMateria values(52,27,7)
insert into cursoMateria values(53,28,7)
insert into cursoMateria values(54,29,7)
insert into cursoMateria values(55,30,7)
--MATERIAS CURSO Quinto A�O
insert into cursoMateria values(56,31,8)
insert into cursoMateria values(57,32,8)
insert into cursoMateria values(58,33,8)
insert into cursoMateria values(59,34,8)



--Insertamos MateriaCurso

create table ProfesorMateria (
	profesorMateriaId int,
	profesorId_1 int,
	materiaId_2 int,
	turno varchar (50),
	constraint pk_cpm primary key (profesorMateriaId),
	constraint fk_fp1 foreign key (profesorId_1) references profesor (profesorId),
	constraint fk_fm2 foreign key (materiaId_2) references materia (materiaId)
)







/*use Universidad

--Tabla alumno
create table alumno(
alumnoId int,
nombre_a varchar(50),
apellido_a varchar(50),
dni_a varchar(15),
telefono_a varchar(20),
fechaNacimiento_a datetime,
edad_a int,
direccion_a varchar(200),
pais_a varchar(50),
provincia_a varchar(50),
localidad_a varchar(50),
genero_a varchar(15),
promedio_a float,

constraint pk_ca primary key (alumnoId)
)

select *from alumno
select *from profesor
delete from alumno
delete from profesor

--Tabla profesor
create table profesor(
profesorId int,
nombre_p varchar(50),
apellido_p varchar(50),
dni_p varchar(15),
telefono_p varchar(20),
fechaNacimiento_p datetime,
edad_p int,
direccion_p varchar(200),
pais_p varchar(50),
provincia_p varchar(50),
localidad_p varchar(50),
genero_p varchar(15),

constraint pk_cp primary key (profesorId)
)

drop table profesor
drop table profesorMateria

--Tabla materia
create table materia(
materiaId int,
correlativaId int,
nombre_m varchar(50),
duracion_m varchar(15),

constraint pk_cm primary key (materiaId),
constraint fk_fcm1 foreign key (correlativaId) references materia (materiaId)
)
--Agregamos materias
-- Primer a�o
insert into materia values (1, null, 'An�lisis Matem�tico I', 'Anual')
insert into materia values(2, null, 'Arquitectura de Computadoras', 'Anual')
insert into materia values(3, null, '�lgebra y Geometr�a Anal�tica', 'Anual')
insert into materia values(4, null, 'Sistema de representaci�n', 'Anual')
insert into materia values(5, null, 'Sistema y Organizaciones', 'Anual')
insert into materia values(6, null, 'F�sica I', 'Anual')
insert into materia values(7, null, 'Algoritmos y Estructuras de Datos', 'Anual')
insert into materia values(8, null, 'Matem�tica Discreta', 'Anual')
--Segundo a�o
insert into materia values(9, 8, 'Sintaxis y Sem�ntica de los Lenguajes', 'Anual')
insert into materia values(10, 8, 'Quimica', 'Cuatrimestral')
insert into materia values(11, 7, 'Paradigmas de Programaci�n', 'Anual')
insert into materia values(12, 1, 'An�lisis Matem�tico II', 'Anual')
insert into materia values(13, null, 'Ingl�s I', 'Cuatrimestral')
insert into materia values(14, 6, 'F�sica II', 'Anual')
insert into materia values(15, 5, 'An�lisis de Sistemas', 'Anual')
insert into materia values(16, 7, 'Sistemas Operativos', 'Anual')
--Tercer a�o
insert into materia values(17, 2, 'Probabilidades y Estad�sticas', 'Anual')
insert into materia values(18, 9, 'Gesti�n de Datos', 'Cuatrimestral')
insert into materia values(19, 11, 'Dise�o de Sistemas', 'Anual')
insert into materia values(20, null, 'Ingenier�a y Sociedad', 'Cuatrimestral')
insert into materia values(21, 13, 'Ingl�s II', 'Cuatrimestral')
insert into materia values(22, 14, 'Comunicaciones', 'Anual')
insert into materia values(23, 15, 'Econom�a', 'Cuatrimestral')
insert into materia values(24, 12, 'Matem�tica Superior', 'Anual')
--Cuarto a�o
insert into materia values(25, 22, 'Redes de Informaci�n', 'Anual')
insert into materia values(26, 24, 'Simulaci�n', 'Cuatrimestral')
insert into materia values(27, 17, 'Investigaci�n Operativa', 'Cuatrimestral')
insert into materia values(28, 24, 'Teor�a de Control', 'Anual')
insert into materia values(29, 18, 'Ingenier�a de Software', 'Anual')
insert into materia values(30, 20, 'Legislaci�n', 'Cuatrimestral')
insert into materia values(31, 23, 'Administraci�n de Recursos', 'Anual')
--Quinto a�o
insert into materia values(32, 25, 'Proyecto Final', 'Anual')
insert into materia values(33, 27, 'Inteligencia Artificial', 'Anual')
insert into materia values(34, 31, 'Administraci�n Gerencial', 'Cuatrimestral')
insert into materia values(35, 26, 'Sistemas de Gesti�n', 'Cuatrimestral')


--Tabla Curso
create table curso(
cursoID int,
division_c char(1),
anio_c int,

constraint pk_cc primary key (cursoId)
)

--Agregamos cursos
insert into curso values(1, 'A', 1)
insert into curso values(2, 'B', 1)
insert into curso values(3, 'A', 2)
insert into curso values(4, 'B', 2)
insert into curso values(5, 'A', 3)
insert into curso values(6, 'B', 3)
insert into curso values(7, 'A', 4)
insert into curso values(8, 'A', 5)

--Tabla aula
create table aula(
aulaId int,
capacidad_au int,
proyector_au bit,
conexionRed_au bit,

constraint pk_cau primary key (aulaId)
)

insert into aula values (1, 50, 1, 0)
insert into aula values (2, 50, 1, 0)
insert into aula values (3, 30, 1, 0)
insert into aula values (4, 30, 1, 0)
insert into aula values (5, 30, 1, 1)
insert into aula values (6, 30, 1, 1)
insert into aula values (7, 25, 1, 1)
insert into aula values (8, 25, 1, 1)

--Tabla connectAll
create table connectAll(
connectAllId int,
alumnoId_1 int,
cursoMateriaId_1 int,
aulaId_1 int,
parcial_1 float,
parcial_2 float,
parcial_3 float,
notaFinal float,

constraint pk_cca primary key (connectAllId),
constraint fk_fa1 foreign key (alumnoId_1) references alumno (alumnoId),
constraint fk_fcm2 foreign key (cursoMateriaId_1) references cursoMateria (cursoMateriaId),
constraint fk_fau1 foreign key (aulaId_1) references aula (aulaId),
)

--Tabla Profesor/Materia
create table profesorMateria(
profesorMateriaId int,
profesorId_1 int,
materiaId_2 int,
turno varchar(50),

constraint pk_cpm primary key (profesorMateriaId),
constraint fk_fp1 foreign key (profesorId_1) references profesor (profesorId),
constraint fk_fm2 foreign key (materiaId_2) references materia (materiaId)
)

--Tabla curso/Materia
create table cursoMateria(
cursoMateriaId int,
materiaId_1 int,
cursoId_1 int,

constraint pk_ccm primary key (cursoMateriaId),
constraint fk_fm1 foreign key (materiaId_1) references materia (materiaId),
constraint fk_fc1 foreign key (cursoId_1) references curso (cursoId)
)

drop table connectAll
drop table cursoMateria
drop table profesorMateria
drop table materia
drop table alumno

-- Agregamos curso/materia
--Primer a�o
insert into cursoMateria values (1, 1, 1)
insert into cursoMateria values (2, 1, 2)
insert into cursoMateria values (3, 2, 1)
insert into cursoMateria values (4, 2, 2)
insert into cursoMateria values (5, 3, 1)
insert into cursoMateria values (6, 3, 2)
insert into cursoMateria values (7, 4, 1)
insert into cursoMateria values (8, 4, 2)
insert into cursoMateria values (9, 5, 1)
insert into cursoMateria values (10, 5, 2)
insert into cursoMateria values (11, 6, 1)
insert into cursoMateria values (12, 6, 2)
insert into cursoMateria values (13, 7, 1)
insert into cursoMateria values (14, 7, 2)
insert into cursoMateria values (15, 8, 1)
insert into cursoMateria values (16, 8, 2)
--Segundo a�o
insert into cursoMateria values (17, 9, 3)
insert into cursoMateria values (18, 9, 4)
insert into cursoMateria values (19, 10, 3)
insert into cursoMateria values (20, 10, 4)
insert into cursoMateria values (21, 11, 3)
insert into cursoMateria values (22, 11, 4)
insert into cursoMateria values (23, 12, 3)
insert into cursoMateria values (24, 12, 4)
insert into cursoMateria values (25, 13, 3)
insert into cursoMateria values (26, 13, 4)
insert into cursoMateria values (27, 14, 3)
insert into cursoMateria values (28, 14, 4)
insert into cursoMateria values (29, 15, 3)
insert into cursoMateria values (30, 15, 4)
insert into cursoMateria values (31, 16, 3)
insert into cursoMateria values (32, 16, 4)
--Tercer a�o
insert into cursoMateria values (33, 17, 5)
insert into cursoMateria values (34, 17, 6)
insert into cursoMateria values (35, 18, 5)
insert into cursoMateria values (36, 18, 6)
insert into cursoMateria values (37, 19, 5)
insert into cursoMateria values (38, 19, 6)
insert into cursoMateria values (39, 20, 5)
insert into cursoMateria values (40, 20, 6)
insert into cursoMateria values (41, 21, 5)
insert into cursoMateria values (42, 21, 6)
insert into cursoMateria values (43, 22, 5)
insert into cursoMateria values (44, 22, 6)
insert into cursoMateria values (45, 23, 5)
insert into cursoMateria values (46, 23, 6)
insert into cursoMateria values (47, 24, 5)
insert into cursoMateria values (48, 24, 6)
--Cuarto a�o
insert into cursoMateria values (49, 25, 7)
insert into cursoMateria values (50, 26, 7)
insert into cursoMateria values (51, 27, 7)
insert into cursoMateria values (52, 28, 7)
insert into cursoMateria values (53, 29, 7)
insert into cursoMateria values (54, 30, 7)
insert into cursoMateria values (55, 31, 7)
--Quinto a�o
insert into cursoMateria values (56, 32, 8)
insert into cursoMateria values (57, 33, 8)
insert into cursoMateria values (58, 34, 8)
insert into cursoMateria values (59, 35, 8)
--Fin carga curso/Materia

drop table alumno
drop table aula
drop table connectAll
drop table curso
drop table cursoMateria
drop table materia
drop table profesor
drop table profesorMateria*/
