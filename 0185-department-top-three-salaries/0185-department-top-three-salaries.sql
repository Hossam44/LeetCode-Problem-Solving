select Department,Employee,Salary
from
(
    select D.name as Department,E.name as Employee, E.salary as Salary,
    DENSE_RANK() OVER (PARTITION BY D.id ORDER BY E.salary desc) AS Rank
    from Employee as E inner join Department as D
    on E.departmentId=D.id
) as newTable
where Rank<4