# MongoDB

## Introdução

O MongoDB é um banco de dados NoSQL que guarda suas informações como documentos, por isso chamamos ele de banco de dados NoSQL orientado a documentos. Os documentos são guardados dentro de coleções e sua estrutura é bem parecida com a de um JSON. Um documento é uma forma de organizar os dados com campos e valores.

O MongoDB armazena os dados na memória em formato BSON (Binary JSON), pois guardar as informações exatamente como JSON seria ineficiente já que JSON é *text-based* e ocupa bastante espaço. O formato BSON foi feito para tirar os gaps que o JSON oferece como velocidade e flexibilidade, ele também oferece alguns formatos a mais que não são suportados pelo formato JSON, como *datetimes*.

Todo documento no MongoDB tem que ter o campo "_id" com um valor único para cada documento, quando adicionamos um documento, esse campo já é automaticamente gerado com o tipo `ObjectId()`.

## Porque utilizar o MongoDB

Quando queremos que nossa estrutura de banco de dados se adapte ao modelos da nossa aplicação, podemos utilizar o MongoDB, ele oferece uma estrutura que pode evoluir junto com as estruturas do negócio e também pode suportar bastante tráfego de leituras e escritas.

Alguns problemas que o MongoDB resolve:

- Integrar grandes quantidades de dados: Caso tenhamos várias fontes de dados, a flexibilidade do modelo orientado a documentos pode oferecer uma visão unificada dos recursos, que bancos de dados relacionais não podem.

- Descrever estruturas de dados complexas que evoluem: Bancos de dados orientados a documentos permitem o aninhamento de documentos dentro de outros documentos e toleram variações.

- Alta performace: O MongoDB pode suportar muitas transações e possui fácil escalabidade.

- Desenvolvimento Ágil: Os bancos de dados orientados a documentos colocam os desenvolvedores no comando dos dados. Os dados se tornam algo que é familiar e amigável para os desenvolvedores.

O MongoDB também oferece uma ótima experiência de desenvolvimento com drivers para as principais linguagens como Java, C#, Javascript, etc.

A principal regra para modelagem de dados no Mongo é:
- Dados devem ser guardados da maneira que são utilizados.

## MQL = Mongo Query Language

Operações principais

- db.collection.find({query})
  - Podemos utilizar o comando `it` após para trazer mais 20 registros.

- db.collection.findOne({query})

Utilizar a função `pretty()` no final das chamadas acima para vizualizar melhor os dados.

- db.collection.insertOne({new item})
- db.collection.insertMany([new item array])

- db.collection.updateOne({update query}, {update action/operation})
- db.collection.updateMany({update query}, {update action/operation})

- db.collection.deleteOne({delete query})
- db.collection.deleteMany({delete query})

## Operadores do MQL

Nos ajudam a realizar queries com melhores filtros. Sempre possuem o símbolo `$` antes.
Exemplos:

$eq - Equals to
$ne - Not Equals to

$gt - Greater than
$lt - Less than

$gte - Greater than or equal
$lte - Less than or equal

A sintaxe para uso desses operadores é a seguinte

`{ "field": { "operator": "value" }}`

### Projeção

No comando `find()`, é possivel passar como segundo argumento, um objeto com as propriedades que queremos que sejam retornadas pelo MongoDB.

Devemos colocar o nome do campo e apenas os valores 1 e 0. Não é possivel utilizar projeções que contém campos misturados com o valor 1 e 0, apenas no caso de desejarmos remover o campo _id da consulta.

1 - Para trazer o campo
0 - Para não trazer o campo

### Sort

A função `sort()` pode ser usada para ordenar os retornos de queries. O argumento deve conter o nome do campo e podemos usar os seguintes valores:

1 - Para buscar de forma crescente
-1 - Para buscar de forma decrescente

Observação: O MongoDB sempre assumirá que o `sort()` virá antes do comando `limit()` mesmo que tenhamos a seguinte query:

db.collection.limit(5).sort(sortQuery)

A query acima é transformada para:

db.collection.sort(sortQuery).limit(5)

## Aggregation

É uma espécie de framework construído em volta do MQL que oferece muito mais poder do que apenas filtros, como operações de agrupamento e modificação. Funciona como um pipeline de execução, então cada operação é feita seguindo a ordem do array. Exemplo:

- db.collection.aggregate([pipeline]);

## Indexes

Um index no MongoDB, é uma estrutura de dados especial que armazena parte dos dados de uma collection de forma organizada, a fim de facilitar uma possivel busca.

O comando para criar um Index no MongoDB é o seguinte:

db.collection.createIndex({"field": 1})

---
Comandos

JSON = Mongo Import e Export
BSON = Mongo Dump e Restore

## Referências

https://www.mongodb.com/why-use-mongodb

Curso M001 da Mongo University
https://university.mongodb.com/
