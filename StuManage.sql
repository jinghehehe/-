--����һ����ѧ��ѧ���������ݿ�ϵͳ
create database StuManage;
use StuManage;
--ҽ��������Ϣ��
create table Student1(
 Stu_no char(20) primary key,
 Stu_name char(10) not null,--ѧ�������趨Ϊ�ǿ�ֵ
 Stu_sex char(2) check(Stu_sex='��' or Stu_sex='Ů'),--�Ա�ֻ��ȡ�л�Ů
 Stu_age char(3) check(Stu_age>0 and Stu_age<120),
 Stu_birth char(20)  
);
select * from Student1;
--����������Ϣ��
create table Teacher1(
 Tea_no char(20) primary key,
 Tea_name char(10) not null,
 --Tea_sex char(2) check(Tea_sex='��' or Tea_sex='Ů'),
 Tea_age char(3) check(Tea_age>0 and Tea_age<120),
 Tea_birth char(20)  
);
--ʵʱ��Ϣ��
create table College1(
 Stu_no char(20) not null,
 Stu_time char(20)  not null,
 Stu_place char(30) not null,--λ��
 Stu_tem char(20) not null,--�¶�
 Stu_view char(20) not null,--��Ƶ
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
--����ָ���
create table Subject1(
 Stu_no char(20) not null,
 Stu_time1 char(20)  not null,
 Stu_tem1 char(20)  not null,--����
 Stu_tem2 char(20) not null,--����
 Stu_tem3 char(20) not null,--����
 Stu_tem4 char(20) not null,--Ѫѹ
 Stu_tem5 char(20)  not null,--Ѫ��
 Stu_tem6 char(20) not null,--�ǻ�Ѫ�쵰��
 Stu_tem7 char(20) not null,--Ѫ֬
 Stu_tem8 char(20) not null,--�ι���
 Stu_tem9 char(20) not null,--������
);
select *
from Subject1 c;
--�����¼��
create table Class1(
 Stu_no char(20) not null,
 Stu_guo char(20)  not null,--����
 Stu_li char(20) not null,--��ʷ����
 Stu_jin char(20) not null,--����
);
--�����
create table Course1(
 Stu_no char(20) not null,
 Stu_tim char(20)  not null,--ʱ��
 Stu_chu char(50)  not null,--����
 Stu_hua char(20) not null,--���鵥
 Stu_bei char(20) not null,--��ע
);

