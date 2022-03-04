--查看是否有重名的库，有则覆盖
use master
if exists(select *from sysdatabases where name='NJAUST')
 drop database NJAUST
go
--打开配置权限，在f盘创建指定文件夹
RECONFIGURE
execute sp_configure 'show advanced options',1
RECONFIGURE
execute sp_configure 'xp_cmdshell',1
RECONFIGURE
go
execute xp_cmdshell 'mkdir f:\SQLData\MyData',no_output
go
----------------------建库
create database NJAUST
on primary
(
name='NJAUST_data',
size=20mb,
filegrowth=15%,
maxsize=200mb,
filename='f:\SQLData\MyData\NJAUST_data.mdf'
)
log on
(
name='NJAU_log',
size=20mb,
filegrowth=15%,
filename='f:\SQLData\MyData\NJAUST_log.ldf'
)
go
----------------------建表
use NJAUST
go
--管理员表
if exists(select *from sysobjects where name='ADM_Table')
 drop table ADM_Table
go
create table ADM_Table
(
ADMNo int not null identity(1,1),
ADMName nchar(10) not null,
ADMCode nchar(6) not null
)
go
--用户表
if exists(select *from sysobjects where name='USER_Table')
 drop table USER_Table
go
create table USER_Table
(
UNo int not null identity(1,1),
UName nchar(10) not null,
UCode nchar(6) not null,
UTname nchar(10) not null,
UGender bit not null,
UAge int not null,
UPnum nchar(11) not null,
UCid int null,
UFid int null,
UPid int null,
UTvalue int not null,
USvalue int not null,
UEntrust int not null,
ULearn int not null,
UStatus bit not null
)
go
--学院表
if exists(select *from sysobjects where name='COLLEGE_Table')
 drop table COLLEGE_Table
go
create table COLLEGE_Table
(
COid int not null identity(1,1),
COName nchar(15) not null
)
go
--领域表
if exists(select *from sysobjects where name='FIELD_Table')
 drop table FIELD_Table
go
create table FIELD_Table
(
Fid int not null identity(1,1),
FCid int null,
FName nchar(10) not null
)
go
--领域分类表
if exists(select *from sysobjects where name='FIELDCLASS_Table')
 drop table FIELDCLASS_Table
go
create table FIELDCLASS_Table
(
Cid int not null identity(1,1),
CName nchar(10) not null
)
go
--学习场所表
if exists(select *from sysobjects where name='PLACE_Table')
 drop table PLACE_Table
go
create table PLACE_Table
(
Pid int not null identity(1,1),
PName nchar(10) not null
)
go
--问题记录表
if exists(select *from sysobjects where name='QUESTION_Table')
 drop table QUESTION_Table
go
create table QUESTION_Table
(
Qno int not null identity(1,1),
QName nchar(10) not null,
QTime datetime not null,
QFid int null,
QDescribe nchar(50) null,
QSolve bit not null
)
go
--登录日志表
if exists(select *from sysobjects where name='SIGNLOG_Table')
 drop table SIGNLOG_Table
go
create table SIGNLOG_Table
(
SLno int not null identity(1,1),
SLName nchar(10) not null,
SLStatus nchar(15) not null,
SLTime datetime not null,
SLReturn nchar(15) not null
)
go
--学习记录表
if exists(select *from sysobjects where name='LEARN_RECORD_Table')
 drop table LEARN_RECORD_Table
go
create table LEARN_RECORD_Table
(
LRno int not null identity(1,1),
LTName nchar(10) not null,
LSName nchar(10) not null,
LRFid int null,
StartTime datetime not null,
EndTime datetime null,
STEva int null,
TSEva int null
) 
go
--拜师记录表
if exists(select *from sysobjects where name='MASTER_RECORD_Table')
 drop table MASTER_RECORD_Table
go
create table MASTER_RECORD_Table
(
MRno int not null identity(1,1),
MSName nchar(10) not null,
MTName nchar(10) not null,
MFid int null,
Flag bit not null
)
go
----------------------相关约束
----------------------ADM表
--ADMName为主键
if exists(select *from sysobjects where name='PK_ADM_ADMName')
 alter table ADM_Table drop constraint PK_ADM_ADMName
go
alter table ADM_Table
add constraint PK_ADM_ADMName primary key(ADMName)
go
--ADMCode只能为6位数字
if exists(select *from sysobjects where name='CK_ADM_ADMCode')
 alter table ADM_Table drop constraint CK_ADM_ADMCode
go
alter table ADM_Table
add constraint CK_ADM_ADMCode check([ADMCode] like '[0-9][0-9][0-9][0-9][0-9][0-9]')
go
----------------------COLLEGE表
--COid为主键
if exists(select *from sysobjects where name='PK_COLLEGE_COid')
 alter table COLLEGE_Table drop constraint PK_COLLEGE_COid
go
alter table COLLEGE_Table
add constraint PK_COLLEGE_COid primary key(COid)
go
--COName唯一
if exists(select *from sysobjects where name='UQ_COLLEGE_COName')
 alter table COLLEGE_Table drop constraint UQ_COLLEGE_COName
go
alter table COLLEGE_Table
add constraint UQ_COLLEGE_COName unique(COid)
go
----------------------FIELDCLASS表
--Cid为主键
if exists(select *from sysobjects where name='PK_FIELDCLASS_Cid')
 alter table FIELDCLASS_Table drop constraint PK_FIELDCLASS_Cid
go
alter table FIELDCLASS_Table
add constraint PK_FIELDCLASS_Cid primary key(Cid)
go
--CName唯一
if exists(select *from sysobjects where name='PK_FIELDCLASS_CName')
 alter table FIELDCLASS_Table drop constraint PK_FIELDCLASS_CName
go
alter table FIELDCLASS_Table
add constraint PK_FIELDCLASS_CName unique(CName)
go
----------------------FIELD表
--Fid为主键
if exists(select *from sysobjects where name='PK_FIELD_Fid')
 alter table FIELD_Table drop constraint PK_FIELD_Fid
go
alter table FIELD_Table
add constraint PK_FIELD_Fid primary key(Fid)
go
--FName唯一
if exists(select *from sysobjects where name='UQ_FIELD_FName')
 alter table FIELD_Table drop constraint UQ_FIELD_FName
go
alter table FIELD_Table
add constraint UQ_FIELD_FName unique(FName)
go
--FCid为外键
if exists(select *from sysobjects where name='FK_FIELD_FCid_FIELDCLASS_Cid')
 alter table FIELD_Table drop constraint FK_FIELD_FCid_FIELDCLASS_Cid
go
alter table FIELD_Table
add constraint FK_FIELD_FCid_FIELDCLASS_Cid foreign key(FCid) references FIELDCLASS_Table(Cid)
on update cascade
on delete set null
go
----------------------PLACE表
--Pid为主键
if exists(select *from sysobjects where name='PK_PLACE_Pid')
 alter table PLACE_Table drop constraint PK_PLACE_Pid
go
alter table PLACE_Table
add constraint PK_PLACE_Pid primary key(Pid)
go
--PName唯一
if exists(select *from sysobjects where name='UQ_PLACE_PName')
 alter table PLACE_Table drop constraint UQ_PLACE_PName
go
alter table PLACE_Table
add constraint UQ_PLACE_PName unique(PName)
go
----------------------USER表
--UNo为主键
if exists(select *from sysobjects where name='PK_USER_UNo')
 alter table USER_Table drop constraint PK_USER_UNo
go
alter table USER_Table
add constraint PK_USER_UNo primary key(UNo)
go
--UName唯一键
if exists(select *from sysobjects where name='UQ_USER_UName')
 alter table USER_Table drop constraint UQ_USER_UName
go
alter table USER_Table
add constraint UQ_USER_UName unique key(UName)
go
--UPnum唯一
if exists(select *from sysobjects where name='UQ_USER_UPnum')
 alter table USER_Table drop constraint UQ_USER_UPnum
go
alter table USER_Table
add constraint UQ_USER_UPnum unique(UPnum)
go
--部分属性的初始值
if exists(select *from sysobjects where name='DF_USER_UEntrust')
 alter table USER_Table drop constraint DF_USER_UEntrust
go
alter table USER_Table
add constraint DF_USER_UEntrust default(0) for UEntrust
go
if exists(select *from sysobjects where name='DF_USER_ULearn')
 alter table USER_Table drop constraint DF_USER_ULearn
go
alter table USER_Table
add constraint DF_USER_ULearn default(0) for ULearn
go
if exists(select *from sysobjects where name='DF_USER_UTvalue')
 alter table USER_Table drop constraint DF_USER_UTvalue
go
alter table USER_Table
add constraint DF_USER_UTvalue default(60) for UTvalue
go
if exists(select *from sysobjects where name='DF_USER_USvalue')
 alter table USER_Table drop constraint DF_USER_USvalue
go
alter table USER_Table
add constraint DF_USER_USvalue default(60) for USvalue
go
if exists(select *from sysobjects where name='DF_USER_UStatus')
 alter table USER_Table drop constraint DF_USER_UStatus
go
alter table USER_Table
add constraint DF_USER_UStatus default('False') for UStatus
go
--部分属性的check约束
if exists(select *from sysobjects where name='CK_USER_UAge')
 alter table USER_Table drop constraint CK_USER_UAge
go
alter table USER_Table
add constraint CK_USER_UAge check([UAge]>(0) AND [UAge]<=(150))
go
if exists(select *from sysobjects where name='CK_USER_UCode')
 alter table USER_Table drop constraint CK_USER_UCode
go
alter table USER_Table
add constraint CK_USER_UCode check([UCode] like '[0-9][0-9][0-9][0-9][0-9][0-9]')
go
if exists(select *from sysobjects where name='CK_USER_UPnum')
 alter table USER_Table drop constraint CK_USER_UPnum
go
alter table USER_Table
add constraint CK_USER_UPnum check([UPnum] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
go
--添加外键
if exists(select *from sysobjects where name='FK_USER_UCid_COLLEGE_COid')
 alter table USER_Table drop constraint FK_USER_UCid_COLLEGE_COid
go
alter table USER_Table
add constraint FK_USER_UCid_COLLEGE_COid foreign key(UCid) references COLLEGE_Table(COid)
on update cascade
on delete set null
go
if exists(select *from sysobjects where name='FK_USER_UFid_FIELD_Fid')
 alter table USER_Table drop constraint FK_USER_UFid_FIELD_Fid
go
alter table USER_Table
add constraint FK_USER_UFid_FIELD_Fid foreign key(UFid) references FIELD_Table(Fid)
on update cascade
on delete set null
go
if exists(select *from sysobjects where name='FK_USER_UPid_PLACE_Pid')
 alter table USER_Table drop constraint FK_USER_UPid_PLACE_Pid
go
alter table USER_Table
add constraint FK_USER_UPid_PLACE_Pid foreign key(UPid) references PLACE_Table(Pid)
on update cascade
on delete set null
go
----------------------LEARN_RECORD表
--LRno为主键
if exists(select *from sysobjects where name='PK_LEARN_LRno')
 alter table LEARN_RECORD_Table drop constraint PK_LEARN_LRno
go
alter table LEARN_RECORD_Table
add constraint PK_LEARN_LRno primary key(LRno)
go
--部分列的check约束
if exists(select *from sysobjects where name='CK_LEARN_STEva')
 alter table LEARN_RECORD_Table drop constraint CK_LEARN_STEva
go
alter table LEARN_RECORD_Table
add constraint CK_LEARN_STEva check([STEva]>=(0) AND [STEva]<=(100))
go
if exists(select *from sysobjects where name='CK_LEARN_TSEva')
 alter table LEARN_RECORD_Table drop constraint CK_LEARN_TSEva
go
alter table LEARN_RECORD_Table
add constraint CK_LEARN_TSEva check([TSEva]>=(0) AND [TSEva]<=(100))
go
--添加外键
if exists(select *from sysobjects where name='FK_LEARN_LRFid_FIELD_Fid')
 alter table LEARN_RECORD_Table drop constraint FK_LEARN_LRFid_FIELD_Fid
go
alter table LEARN_RECORD_Table
add constraint FK_LEARN_LRFid_FIELD_Fid foreign key(LRFid) references FIELD_Table(Fid)
on update cascade
on delete set null
go
if exists(select *from sysobjects where name='FK_LEARN_LSName_USER_UName')
 alter table LEARN_RECORD_Table drop constraint FK_LEARN_LSName_USER_UName
go
alter table LEARN_RECORD_Table
add constraint FK_LEARN_LSName_USER_UName foreign key(LSName) references USER_Table(UName)
on update no action
on delete no action
go
if exists(select *from sysobjects where name='FK_LEARN_LTName_USER_UName')
 alter table LEARN_RECORD_Table drop constraint FK_LEARN_LTName_USER_UName
go
alter table LEARN_RECORD_Table
add constraint FK_LEARN_LTName_USER_UName foreign key(LTName) references USER_Table(UName)
on update no action
on delete no action
go
----------------------MASTER_RECORD表
--MRno为主键
if exists(select *from sysobjects where name='PK_MASTER_MRno')
 alter table MASTER_RECORD_Table drop constraint PK_MASTER_MRno
go
alter table MASTER_RECORD_Table
add constraint PK_MASTER_MRno primary key(MRno)
go
--Flag只能为True或者False
if exists(select *from sysobjects where name='CK_MASTER_Flag')
 alter table MASTER_RECORD_Table drop constraint CK_MASTER_Flag
go
alter table MASTER_RECORD_Table
add constraint CK_MASTER_Flag check(Flag=1 OR Flag=0)
go
--添加外键
if exists(select *from sysobjects where name='FK_MASTER_MFid_FIELD_Fid')
 alter table MASTER_RECORD_Table drop constraint FK_MASTER_MFid_FIELD_Fid
go
alter table MASTER_RECORD_Table
add constraint FK_MASTER_MFid_FIELD_Fid foreign key(MFid) references FIELD_Table(Fid)
on update cascade
on delete set null
go
if exists(select *from sysobjects where name='FK_MASTER_MSName_USER_UName')
 alter table MASTER_RECORD_Table drop constraint FK_MASTER_MSName_USER_UName
go
alter table MASTER_RECORD_Table
add constraint FK_MASTER_MSName_USER_UName foreign key(MSName) references USER_Table(UName)
on update no action
on delete no action
go
if exists(select *from sysobjects where name='FK_MASTER_MTName_USER_UName')
 alter table MASTER_RECORD_Table drop constraint FK_MASTER_MTName_USER_UName
go
alter table MASTER_RECORD_Table
add constraint FK_MASTER_MTName_USER_UName foreign key(MTName) references USER_Table(UName)
on update no action
on delete no action
go
----------------------QUESTION表
--Qno为主键
if exists(select *from sysobjects where name='PK_QUESTION_Qno')
 alter table QUESTION_Table drop constraint PK_QUESTION_Qno
go
alter table QUESTION_Table
add constraint PK_QUESTION_Qno primary key(Qno)
go
--QSolve只能为True与False,初值为False
if exists(select *from sysobjects where name='CK_QUESTION_QSolve')
 alter table QUESTION_Table drop constraint CK_QUESTION_QSolve
go
alter table QUESTION_Table
add constraint CK_QUESTION_QSolve check(QSolve=0 OR QSolve=1)
go
if exists(select *from sysobjects where name='DF_QUESTION_QSolve')
 alter table QUESTION_Table drop constraint DF_QUESTION_QSolve
go
alter table QUESTION_Table
add constraint DF_QUESTION_QSolve default(0) for QSolve
go
--添加外键
if exists(select *from sysobjects where name='FK_QUESTION_QFid_FIELD_Fid')
 alter table QUESTION_Table drop constraint FK_QUESTION_QFid_FIELD_Fid
go
alter table QUESTION_Table
add constraint FK_QUESTION_QFid_FIELD_Fid foreign key(QFid) references FIELD_Table(Fid)
on update cascade
on delete set null
go
if exists(select *from sysobjects where name='FK_QUESTION_QName_USER_UName')
 alter table QUESTION_Table drop constraint FK_QUESTION_QName_USER_UName
go
alter table QUESTION_Table
add constraint FK_QUESTION_QName_USER_UName foreign key(QName) references USER_Table(UName)
on update no action
on delete no action
go
----------------------SIGNLOG表
--SLno为主键
if exists(select *from sysobjects where name='PK_SIGNLOG_SLno')
 alter table SIGNLOG_Table drop constraint PK_SIGNLOG_SLno
go
alter table SIGNLOG_Table
add constraint PK_SIGNLOG_SLno primary key(SLno)
go
--约束
if exists(select *from sysobjects where name='CK_SIGNLOG_SLStatus')
 alter table SIGNLOG_Table drop constraint CK_SIGNLOG_SLStatus
go
alter table SIGNLOG_Table
add constraint CK_SIGNLOG_SLStatus check([SLStatus]='User' OR [SLStatus]='Administrator')
go
if exists(select *from sysobjects where name='CK_SIGNLOG_SLReturn')
 alter table SIGNLOG_Table drop constraint CK_SIGNLOG_SLReturn
go
alter table SIGNLOG_Table
add constraint CK_SIGNLOG_SLReturn check([SLReturn]='Allowed' OR [SLReturn]='Refused')
go
--添加外键
if exists(select *from sysobjects where name='FK_SIGNLOG_SLName_USER_UName')
 alter table SIGNLOG_Table drop constraint FK_SIGNLOG_SLName_USER_UName
go
alter table SIGNLOG_Table
add constraint FK_SIGNLOG_SLName_USER_UName foreign key(SLName) references USER_Table(UName)
on delete no action
on update no action
go

----------------------创建视图
--视图就是将常用基本表中的id替换为name并显示出来
----------------------FIELD_FIELDCLASS_VIEW
if exists(select *from sysobjects where name='FIELD_FIELDCLASS_VIEW')
 drop view USER_MORE_VIEW
go
if exists(select *from sysobjects where name='FIELD_FIELDCLASS_VIEW')
 drop view FIELD_FIELDCLASS_VIEW
go
create view FIELD_FIELDCLASS_VIEW
as
select Fid,CName,FName
from FIELD_Table,FIELDCLASS_Table
where Cid=FCid
with check option
go
----------------------USER_MORE_VIEW
if exists(select *from sysobjects where name='USER_MORE_VIEW')
 drop view USER_MORE_VIEW
go
create view USER_MORE_VIEW
as
select UName,UCode,UTname,UGender,UAge,UPnum,COName,CName,FName,PName,UTvalue,USvalue,UEntrust,ULearn,UStatus
from USER_Table,COLLEGE_Table,PLACE_Table,FIELD_FIELDCLASS_VIEW
where UFid=Fid and UPid=Pid and UCid=COid
with check option
go
----------------------LEARN_MORE_VIEW
if exists(select *from sysobjects where name='LEARN_MORE_VIEW')
 drop view LEARN_MORE_VIEW
go
create view LEARN_MORE_VIEW
as
select LRno,LTName,LSName,LRFid,FName,StartTime,EndTime,STEva,TSEva
from LEARN_RECORD_Table,FIELD_Table
where LRFid=Fid
with check option
go
----------------------MASTER_MORE_VIEW
if exists(select *from sysobjects where name='MASTER_MORE_VIEW')
 drop view MASTER_MORE_VIEW
go
create view MASTER_MORE_VIEW
as
select MRno,MSName,MTName,MFid,FName,Flag
from MASTER_RECORD_Table,FIELD_Table
where MFid=Fid
with check option
go
----------------------QUESTION_MORE_VIEW
if exists(select *from sysobjects where name='QUESTION_MORE_VIEW')
 drop view QUESTION_MORE_VIEW
go
create view QUESTION_MORE_VIEW
as
select Qno,QName,QTime,QFid,FName,QDescribe,QSolve
from QUESTION_Table,FIELD_Table
where QFid=Fid
with check option
go

----------------------创建触发器
if exists(select *from sysobjects where name='LEARN_EndTime_TRIGGER')
 drop trigger LEARN_EndTime_TRIGGER
go
create trigger LEARN_EndTime_TRIGGER
on LEARN_RECORD_Table
after update
as
begin
if update(STEva) or update(TSEva)
begin
	declare @lrno int
	declare @tname nchar(10)
	declare @sname nchar(10)
	select @lrno=LRno from inserted
	select @tname=LTName from inserted
	select @sname=LSName from inserted
	if exists(select * from inserted,deleted where inserted.LRno=deleted.LRno and inserted.TSEva is not null and inserted.STEva is not null)
	begin
		update LEARN_RECORD_Table set EndTime=(select GETDATE()) where LRno=@lrno
		update USER_Table set UEntrust+=1 where UName=@tname
		update USER_Table set ULearn+=1 where UName=@sname
	end;
end;
end;
go

if exists(select *from sysobjects where name='LEARN_Eva_TRIGGER')
 drop trigger LEARN_Eva_TRIGGER
go
create trigger LEARN_Eva_TRIGGER
on LEARN_RECORD_Table
after update
as
begin
if update(EndTime)
begin
	declare @tname nchar(10)
	declare @sname nchar(10)
	declare @steva int
	declare @tseva int
	select @tname=LTName from inserted
	select @steva=STEva from inserted
	select @sname=LSName from inserted
	select @tseva=TSEva from inserted
	update USER_Table set UTvalue=(UTvalue+@steva)/2 where UName=@tname
	update USER_Table set USvalue=(USvalue+@tseva)/2 where UName=@sname
end;
end;
go