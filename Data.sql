use StuManage;
--�������ݣ�ѧ����
insert into Student1 values('15030120001','����','��','80','210803199607140000');
insert into Student1 values('15030120002','����','��','79','210803199607140001');
insert into Student1 values('15030120056','������','��','78','210803199607140002');
insert into Student1 values('15030199001','������','��','77','210803199607140004');
insert into Student1 values('15030199002','������','��','91','210803199607140005');
insert into Student1 values('15030199003','������','��','92','210803199607140006');
insert into Student1 values('15060110001','����','Ů','93','210803199607140007');
insert into Student1 values('15080110002','�Գ�','Ů','88','210803199607140008');
select * from Student1;

insert into Student1 values('1010001','�','��','57','21010001');
--�������ݣ���ʦ��
insert into Teacher1 values('03001','��ƽ','��','40','210803199607140010');
insert into Teacher1 values('03002','����','Ů','51','210803199607140020');
insert into Teacher1 values('03003','����','Ů','42','210803199607140030');
insert into Teacher1 values('03004','�Լ�','��','60','210803199607140040');
insert into Teacher1 values('03005','��ƽ��','��','40','210803199607140050');
insert into Teacher1 values('03006','��һ��','��','35','210803199607140060');
insert into Teacher1 values('03007','����','��','21','210803199607140070');
insert into Teacher1 values('02001','����','��','40','210803199607140080');
insert into Teacher1 values('06001','����','��','20','210803199607140090');
insert into Teacher1 values('08001','��ʢ','��','40','210803199607140100');
select * from Teacher1;
--�������ݣ�ʵʱ��
insert into College1 values('1010001','2016.8.12','μ���к����԰','37.2','1');
insert into College1 values('15030120002','2018/03/20 12:01','��','37.1','1');
insert into College1 values('15030120056','2018/03/20 12:02','��','37.1','1');
insert into College1 values('15030120001','2018/03/20 12:01','��','37.0','1');
select * from College1;
--�������ݣ�רҵ��
insert into Subject1 values('1010001','2016.8.12','37.0','56��/��','67','90-130','5.6','97','4.3','AST��26','BUN��4.2');
insert into Subject1 values('15030120002','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
insert into Subject1 values('15030120056','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
insert into Subject1 values('15030199001','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
insert into Subject1 values('15030199002','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
insert into Subject1 values('15030199003','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
insert into Subject1 values('15060110001','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
insert into Subject1 values('15080110002','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
select * from Subject1;
delete from Subject1 where Stu_no='1010001';
--�������ݣ��༶��
insert into Class1 values('1010001','��ù��','���ಡ','����');
insert into Class1 values('15030120002','ơ��','��θ��','ע�������ʳ');
insert into Class1 values('15030120056','���','��','ע�������ʳ');
insert into Class1 values('15030199001','���','��θ��','ע�������ʳ');
insert into Class1 values('15030199002','����','��','ע�������ʳ');
insert into Class1 values('15030199003','����','��θ��','ע�������ʳ');
insert into Class1 values('15060110001','����','��','ע�������ʳ');
insert into Class1 values('15080110002','����','��θ��','ע�������ʳ');
select * from Class1;
--��������(�γ�)
insert into Course1 values('1010001','2016.8.12','θ���ܰ�˹ƥ�ֿ���,��������ɽ�洼������','JPG1','���ܸ���');
insert into Course1 values('15030120002','2018/03/20 12:00','xxҩ','��θ����','ע����ʳ');
insert into Course1 values('15030120056','2018/03/20 12:00','xxҩ','��θ����','ע����ʳ');
insert into Course1 values('15030199001','2018/03/20 12:00','xxҩ','��θ����','ע����ʳ');
insert into Course1 values('15030199002','2018/03/20 12:00','xxҩ','��θ����','ע����ʳ');
insert into Course1 values('15030199003','2018/03/20 12:00','xxҩ','��θ����','ע����ʳ');
insert into Course1 values('15060110001','2018/03/20 12:00','xxҩ','��θ����','ע����ʳ');
insert into Course1 values('15080110002','2018/03/20 12:00','xxҩ','��θ����','ע����ʳ');
insert into Course1 values('15030120001','2018/03/21 12:00','xxҩ','��θ����','ע����ʳ');
select * from Course1;
delete Class1;
delete Course1;
delete Subject1;