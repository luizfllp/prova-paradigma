Resposta da primeira tarefa

Eu criei um readme simplificado para mostrar os resultados obtidos.

Github com o código da tarefa 1

[https://github.com/luizfllp/prova-paradigma](https://github.com/luizfllp/prova-paradigma)


Resposta da segunda tarefa 

"Escreva uma consulta usando linguagem SQL para encontrar os colaboradores que tem o salário mais alto em cada um dos departamentos."

```SQL
select 
	d.Nome Departamento,
	p.Nome Pessoa,
	p.Salario Salario
from Pessoa p
inner join Departamento d on p.DeptId = d.ID
inner join (
	select 
		DeptId,
		MAX(Salario) Salario 
	from 
	Pessoa
	group by DeptId 
) g on p.DeptId = g.DeptId and p.Salario = g.Salario

```
