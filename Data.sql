use StuManage;
--插入数据（学生）
insert into Student1 values('15030120001','孙武','男','80','210803199607140000');
insert into Student1 values('15030120002','卫青','男','79','210803199607140001');
insert into Student1 values('15030120056','范德萨','男','78','210803199607140002');
insert into Student1 values('15030199001','秦少游','男','77','210803199607140004');
insert into Student1 values('15030199002','刘禹锡','男','91','210803199607140005');
insert into Student1 values('15030199003','王阳明','男','92','210803199607140006');
insert into Student1 values('15060110001','刘依','女','93','210803199607140007');
insert into Student1 values('15080110002','赵晨','女','88','210803199607140008');
select * from Student1;

insert into Student1 values('1010001','李康','男','57','21010001');
--插入数据（教师）
insert into Teacher1 values('03001','张平','男','40','210803199607140010');
insert into Teacher1 values('03002','刘静','女','51','210803199607140020');
insert into Teacher1 values('03003','王芳','女','42','210803199607140030');
insert into Teacher1 values('03004','赵甲','男','60','210803199607140040');
insert into Teacher1 values('03005','孙平方','男','40','210803199607140050');
insert into Teacher1 values('03006','曲一线','男','35','210803199607140060');
insert into Teacher1 values('03007','王凯','男','21','210803199607140070');
insert into Teacher1 values('02001','程龙','男','40','210803199607140080');
insert into Teacher1 values('06001','秦绍','男','20','210803199607140090');
insert into Teacher1 values('08001','周盛','男','40','210803199607140100');
select * from Teacher1;
--插入数据（实时）
insert into College1 values('1010001','2016.8.12','渭南市恒昌花园','37.2','1');
insert into College1 values('15030120002','2018/03/20 12:01','床','37.1','1');
insert into College1 values('15030120056','2018/03/20 12:02','床','37.1','1');
insert into College1 values('15030120001','2018/03/20 12:01','床','37.0','1');
select * from College1;
--插入数据（专业）
insert into Subject1 values('1010001','2016.8.12','37.0','56次/分','67','90-130','5.6','97','4.3','AST：26','BUN：4.2');
insert into Subject1 values('15030120002','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
insert into Subject1 values('15030120056','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
insert into Subject1 values('15030199001','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
insert into Subject1 values('15030199002','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
insert into Subject1 values('15030199003','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
insert into Subject1 values('15060110001','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
insert into Subject1 values('15080110002','2018/03/20 12:00','37.0','1','1','1','1','1','1','1','1');
select * from Subject1;
delete from Subject1 where Stu_no='1010001';
--插入数据（班级）
insert into Class1 values('1010001','青霉素','心脏病','辛辣');
insert into Class1 values('15030120002','啤酒','肠胃炎','注意过敏饮食');
insert into Class1 values('15030120056','淀粉','无','注意过敏饮食');
insert into Class1 values('15030199001','香菜','肠胃炎','注意过敏饮食');
insert into Class1 values('15030199002','海鲜','无','注意过敏饮食');
insert into Class1 values('15030199003','鸡蛋','肠胃炎','注意过敏饮食');
insert into Class1 values('15060110001','海鲜','无','注意过敏饮食');
insert into Class1 values('15080110002','鸡蛋','肠胃炎','注意过敏饮食');
select * from Class1;
--插入数据(课程)
insert into Course1 values('1010001','2016.8.12','胃肠溶阿斯匹林抗凝,单硝酸异山梨醇酯扩冠','JPG1','下周复查');
insert into Course1 values('15030120002','2018/03/20 12:00','xx药','肠胃不适','注意饮食');
insert into Course1 values('15030120056','2018/03/20 12:00','xx药','肠胃不适','注意饮食');
insert into Course1 values('15030199001','2018/03/20 12:00','xx药','肠胃不适','注意饮食');
insert into Course1 values('15030199002','2018/03/20 12:00','xx药','肠胃不适','注意饮食');
insert into Course1 values('15030199003','2018/03/20 12:00','xx药','肠胃不适','注意饮食');
insert into Course1 values('15060110001','2018/03/20 12:00','xx药','肠胃不适','注意饮食');
insert into Course1 values('15080110002','2018/03/20 12:00','xx药','肠胃不适','注意饮食');
insert into Course1 values('15030120001','2018/03/21 12:00','xx药','肠胃不适','注意饮食');
select * from Course1;
delete Class1;
delete Course1;
delete Subject1;