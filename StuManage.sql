--建立一所大学的学籍管理数据库系统
create database StuManage;
use StuManage;
--医生基本信息表
create table Student1(
 Stu_no char(20) primary key,
 Stu_name char(10) not null,--学生姓名设定为非空值
 Stu_sex char(2) check(Stu_sex='男' or Stu_sex='女'),--性别只能取男或女
 Stu_age char(3) check(Stu_age>0 and Stu_age<120),
 Stu_birth char(20)  
);
select * from Student1;
--家属基本信息表
create table Teacher1(
 Tea_no char(20) primary key,
 Tea_name char(10) not null,
 --Tea_sex char(2) check(Tea_sex='男' or Tea_sex='女'),
 Tea_age char(3) check(Tea_age>0 and Tea_age<120),
 Tea_birth char(20)  
);
--实时信息表
create table College1(
 Stu_no char(20) not null,
 Stu_time char(20)  not null,
 Stu_place char(30) not null,--位置
 Stu_tem char(20) not null,--温度
 Stu_view char(20) not null,--视频
);
select *
from Student1 s,College1 c
where s.Stu_no=c.Stu_no;
select *
from College1 c;
drop table College1;
drop table Student1;
drop table Subject1;
drop table Class1;
drop table Course1;
--身体指标表
create table Subject1(
 Stu_no char(20) not null,
 Stu_time1 char(20)  not null,
 Stu_tem1 char(20)  not null,--体温
 Stu_tem2 char(20) not null,--脉搏
 Stu_tem3 char(20) not null,--呼吸
 Stu_tem4 char(20) not null,--血压
 Stu_tem5 char(20)  not null,--血糖
 Stu_tem6 char(20) not null,--糖化血红蛋白
 Stu_tem7 char(20) not null,--血脂
 Stu_tem8 char(20) not null,--肝功能
 Stu_tem9 char(20) not null,--肾功能
);
select *
from Subject1 c;
--病情记录表
create table Class1(
 Stu_no char(20) not null,
 Stu_guo char(20)  not null,--过敏
 Stu_li char(20) not null,--历史病情
 Stu_jin char(20) not null,--禁忌
);
--化验表
create table Course1(
 Stu_no char(20) not null,
 Stu_tim char(20)  not null,--时间
 Stu_chu char(50)  not null,--处方
 Stu_hua char(20) not null,--化验单
 Stu_bei char(20) not null,--备注
);

