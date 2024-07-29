
DROP TABLE IF EXISTS works_on;
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS project;
DROP TABLE IF EXISTS Department;


CREATE TABLE Department (
    Dept_no VARCHAR(2) PRIMARY KEY,
    Dept_name VARCHAR(20),
    location VARCHAR(30)
);


CREATE TABLE Employee (
    emp_no INT PRIMARY KEY,
    emp_fname VARCHAR(20),
    emp_lname VARCHAR(20),
    Dept_no VARCHAR(2),
    FOREIGN KEY (Dept_no) REFERENCES Department(Dept_no)
);


CREATE TABLE project (
    project_no VARCHAR(2) PRIMARY KEY,
    project_nameabk VARCHAR(20),
    Budget INT
);


CREATE TABLE works_on (
    emp_no INT,
    project_no VARCHAR(2),
    Job VARCHAR(20),
    enter_date DATE,
    FOREIGN KEY (emp_no) REFERENCES Employee(emp_no),
    FOREIGN KEY (project_no) REFERENCES project(project_no)
);


INSERT INTO Department VALUES
('d1', 'Research', 'Dallas'),
('d2', 'Accounting', 'Seattle'),
('d3', 'Marketing', 'Dallas');


INSERT INTO Employee VALUES
(25348, 'Matthew', 'Smith', 'd3'),
(10102, 'Ann', 'Jones', 'd3'),
(18316, 'John', 'Barrimore', 'd1'),
(29346, 'James', 'James', 'd2');


INSERT INTO project VALUES
('p1', 'Apollo', 120000),
('p2', 'Gemini', 95000),
('p3', 'Mercury', 185600);


INSERT INTO works_on VALUES
(10102, 'p1', 'Analyst', '1997-10-01'),
(10102, 'p3', 'Manager', '1999-01-01'),
(25348, 'p2', 'Clerk', '1998-02-15'),
(18316, 'p2', 'NULL', '1998-06-01'),
(29346, 'p2', 'NULL', '1997-12-15'),
(29346, 'p1', 'Clerk', '1998-01-04');



select *from works_on 

select emp_no from works_on where job='clerk'

select emp_no from works_on where project_no='p2' and emp_no <10000;

select emp_no from works_on where year(enter_date)!=1998

select emp_no from works_on  where project_no='p1' and job in('Analyst','manager')

select enter_date from works_on where project_no='p2' and job not in('Analyst','manager','Clerk')

select emp_no,emp_lname from Employee where emp_fname like '%tt%'

select emp_no,emp_fname from Employee where emp_lname like '_o%es' or emp_lname like '_a%es'

select e.emp_no from Employee e join Department d on e.Dept_no=d.Dept_no where d.location='Seattle'

select e.emp_fname,e.emp_lname from Employee e join works_on w on e.emp_no=w.emp_no where w.enter_date='1998-01-04'


SELECT 
    e.emp_no, 
    e.emp_fname, 
    e.emp_lname, 
    e.dept_no, 
    d.Dept_name, 
    d.location 
FROM 
    Employee e 
JOIN 
    Department d 
ON 
    d.Dept_no = e.Dept_no 
GROUP BY 
    d.location, 
    e.emp_no, 
    e.emp_fname, 
    e.emp_lname, 
    e.dept_no, 
    d.Dept_name;

select MAX(emp_no) from works_on
SELECT Job FROM Works_on GROUP BY Job HAVING COUNT(emp_no) > 2;
SELECT emp_no FROM Works_on WHERE Job = 'Clerk'
UNION
SELECT emp_no FROM Employee WHERE dept_no = 'd3';