select distinct(num) as ConsecutiveNums
from
(
    select num,
    lag(num) OVER(order by id) as PreviousNumber,
    lead(num) OVER(order by id) as NextNumber
    from Logs
) as newTable
where num=PreviousNumber and num=NextNumber