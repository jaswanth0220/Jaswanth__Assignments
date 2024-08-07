-- a. Equijoin
SELECT *
FROM works_on w
JOIN project p ON w.project_id = p.project_id;

-- b. Natural Join
SELECT *
FROM works_on
NATURAL JOIN project;

-- c. Cartesian Product
SELECT *
FROM works_on, project;

-- 2. Employee Numbers and Job Titles of Employees Working on Project Gemini
SELECT e.employee_id, e.job_title
FROM employee e
JOIN works_on w ON e.employee_id = w.employee_id
JOIN project p ON w.project_id = p.project_id
WHERE p.project_name = 'Gemini';

-- 3. First and Last Names of Employees Working for Departments Research or Accounting
SELECT e.first_name, e.last_name
FROM employee e
WHERE e.department_id IN (
    SELECT department_id
    FROM department
    WHERE department_name IN ('Research', 'Accounting')
);

-- 4. Enter Dates of All Clerks Belonging to Department d1
SELECT w.enter_date
FROM works_on w
JOIN employee e ON w.employee_id = e.employee_id
WHERE e.department_id = 'd1' AND e.job_title = 'Clerk';

-- 5. Names of Projects on Which Two or More Clerks Are Working
SELECT p.project_name
FROM project p
JOIN works_on w ON p.project_id = w.project_id
JOIN employee e ON w.employee_id = e.employee_id
WHERE e.job_title = 'Clerk'
GROUP BY p.project_name
HAVING COUNT(DISTINCT e.employee_id) >= 2;

-- 6. First and Last Names of Managers Working on Project Mercury
SELECT e.first_name, e.last_name
FROM employee e
JOIN works_on w ON e.employee_id = w.employee_id
JOIN project p ON w.project_id = p.project_id
WHERE p.project_name = 'Mercury' AND e.job_title = 'Manager';

-- 7. First and Last Names of Employees Entering the Project at the Same Time as At Least One Other Employee
SELECT e1.first_name, e1.last_name
FROM employee e1
JOIN works_on w1 ON e1.employee_id = w1.employee_id
WHERE EXISTS (
    SELECT 1
    FROM works_on w2
    WHERE w1.project_id = w2.project_id
    AND w1.enter_date = w2.enter_date
    AND w1.employee_id <> w2.employee_id
);

-- 8. Employee Numbers of Employees Living in the Same Location and Belonging to the Same Department
SELECT e1.employee_id
FROM employee e1
JOIN employee e2 ON e1.location = e2.location AND e1.department_id = e2.department_id
WHERE e1.employee_id <> e2.employee_id;

-- 9. Employee Numbers of Employees in the Marketing Department

-- Using JOIN Operator
SELECT e.employee_id
FROM employee e
JOIN department d ON e.department_id = d.department_id
WHERE d.department_name = 'Marketing';

-- Using Correlated Subquery
SELECT e.employee_id
FROM employee e
WHERE e.department_id = (
    SELECT d.department_id
    FROM department d
    WHERE d.department_name = 'Marketing'
);

-- Modifying Table Contents

-- 1. Insert Data of a New Employee
INSERT INTO employee (employee_id, first_name, last_name)
VALUES (1111, 'Julia', 'Long');

-- 2. Create a New Table and Load Data
CREATE TABLE emp_d1_d2 AS
SELECT *
FROM employee
WHERE department_id IN ('d1', 'd2');

-- 3. Modify the Job of All Employees in Project p1 Who Are Managers
UPDATE employee e
SET job_title = 'Clerk'
WHERE e.employee_id IN (
    SELECT w.employee_id
    FROM works_on w
    WHERE w.project_id = 'p1'
)
AND e.job_title = 'Manager';

-- 4. Set All Project Budgets to NULL
UPDATE project
SET budget = NULL;

-- 5. Increase the Budget of the Project Managed by Employee 10102 by 10%
UPDATE project
SET budget = budget * 1.10
WHERE project_id = (
    SELECT project_id
    FROM works_on
    WHERE employee_id = 10102
);

-- 6. Change Enter Date for Projects for Employees in Project p1 and Department Sales
UPDATE works_on w
SET enter_date = '1998-12-12'
WHERE w.project_id = 'p1'
AND EXISTS (
    SELECT 1
    FROM employee e
    WHERE e.employee_id = w.employee_id
    AND e.department_id = (
        SELECT department_id
        FROM department
        WHERE department_name = 'Sales'
    )
);

-- 7. Create a Stored Procedure to Insert Data into Department and Employee Tables
CREATE PROCEDURE InsertEmployeeDepartment
    @emp_id INT,
    @first_name NVARCHAR(50),
    @last_name NVARCHAR(50),
    @job_title NVARCHAR(50),
    @dept_id NVARCHAR(10)
AS
BEGIN
    INSERT INTO employee (employee_id, first_name, last_name, job_title, department_id)
    VALUES (@emp_id, @first_name, @last_name, @job_title, @dept_id);
END;