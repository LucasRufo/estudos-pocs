# NoSQL

O termo NoSQL refere-se a Not-Only-SQL e basicamente são bancos de dados que armazenam os dados em formatos diferentes de tabelas relacionais. Bancos de dados NoSQL também podem armazenar dados que possuem relacionamentos, mas armazenam de forma diferente que bancos de dados relacionais. Geralmente é mais fácil realizar a modelagem dos dados em bancos de dados NoSQL, pois dados que são relacionados não precisam estar em tabelas separadas.

# Da onde surgiu o NoSQL?

Basicamente os bancos de dados NoSQL surgiram a partir da frustração de desenvolvedores com bancos SQL, então certos devs e empresar começaram a criar seus próprios bancos de dados de forma interna e depois disponibilizaram grande parte de deles de forma open-source. A intenção desses programadores era oferecer a flexibilidade, escalabilidade e performance que os bancos de dados SQL não poderiam oferecer.

# Vantagens que o NoSQL pode oferecer:

## Modelagem de dados:
Como temos vários tipos de formatos de bancos de dados NoSQL, você pode escolher um que se adeque ao seu caso e que será mais interessante para armazenar seus dados. Exemplo disso são os bancos de dados NoSQL chave-valor, como Redis, que suportam queries simples de forma extremamente eficiente.

## Performace:
Os bancos de dados NoSQL podem garantir melhorias significativas na performace de suas queries também, supondo que você esteja utilizando um banco de dados orientado a documentos como o MongoDB, seus dados poderiam ficar todos em uma mesma estrutura, sendo que geralmente em bancos de dados SQL, teriamos que montar uma querie com diversos Joins entre as tabelas relacionadas.

## Escalabilidade:
Bancos de dados NoSQL são projetados para escalar horizontalmente de forma fácil, então caso sua massa de dados cresça e você precise de mais servidores isso pode ser feito sem muita dor de cabeça.

## Flexibilidade:
Bancos de dados NoSQL permitem que os desenvolvedores atualizem suas estruturas de dados de formas mais simples. Conforme a complexidade do négocio aumenta, suas estruturas de dados armazenadas em bancos NoSQL podem aumentar junto, para corresponder aos novos requisitos. É uma alternativa interessante também para microsserviços.

# Tipos de bancos de dados NoSQL

## Banco de dados orientado a documentos:
Esse tipo de banco de dados guarda os dados em uma estrutura muito similar ao objetos JSON, então cada "documento" pode conter inúmeros campos. Os documentos se adaptam a estrutura que o desenvolvedor está usando no código, então caso haja uma mudança de escopo e mais um campo precise ser adicionado a estrutura, os documentos vão conseguir se adaptar e aceitar esse campo novo sem que o desenvolvedor tenha que alterar nada na base. Pode ser usado de forma geral em projetos, como um banco de dados normal e também pode escalar de forma simples mesmo para grandes massas de dados. Um dos databases mais famosos desse tipo é o MongoDB.

## Banco de dados Chave-Valor:
São bancos de dados que armazenam estruturas de dados simples, como o próprio nome diz, apenas com chave e valor. Geralmente para buscarmos um valor, fazemos isso através de sua chave.
Esses bancos de dados são bons para casos que queremos guardar uma informação que não precisa de uma querie muito complexa para ser retornado, geralmente é utilizado para cache ou preferencias do usuário, mas hoje em dia o uso para outras coisas também vem crescendo bastante. Exemplo de banco de dados assim é o Redis.

## Banco de dados de colunas largas:
Tipo de banco de dados que armazena os dados em tabelas, linhas e colunas dinâmicas. Esse tipo provê uma flexibilidade maior em relação aos bancos relacionais pois nem toda linha precisa ter as mesmas colunas. São bons para casos em que você precisa armazenar grandes quantidades de dados e pode prever como os padrões de suas queries serão. Exemplo de banco de dados desse tipo é o Cassandra.

## Banco de dados orientado a grafos:
Esse tipo de banco de dados armazena os dados em nós como se fossem grafos. Geralmente é utilizado para guardados dados que são muito relacionados, como informações de uma rede social.
Basicamente os dados de uma pessoa ficariam armazenados em um nó e ela teria relacionamentos com divesos outros nós, que podem levar a descobrirmos padrões nos relacionamentos entre os nós. Exemplo de bancos de dados é o Neo4j.

# Quando queremos usar um bancos de dados NoSQL ao inves de um SQL?

## Velocidade do desenvolvimento
Geralmente, bancos de dados NoSQL permitem que os desenvolvedores tenham o controle das estruturas de dados armazenadas e isso encaixa muito bem para um desenvolvimento mais ágil. Quando um dev tem que parar o seu trabalho e pedir para um DBA alterar algo na estrutura da base, temos um processo de desenvolvimento mais lento.

## As estruturas de dados evoluem
Bancos de dados NoSQL podem armazenar dados estruturados, semi-estruturados e desestruturados. As estruturas também podem evoluir conforme a aplicação cresce.

## Grande volume de dados
Os bancos de dados NoSQL escalam de forma mais simples, então quando sua massa de dados começa a crescer de mais, colocar um servidor a mais será tranquilo. Outro ponto é que você pode fazer a escala com zero de downtime.

# Contras de utilizar NoSQL
Os bancos de dados NoSQL também possuem disvantagens, uma delas é que eles são de certa forma uma tecnologia mais recente, enquanto temos o SQL desde 1970, os bancos NoSQL começacaram a se popularizar nos anos 2000. Outro ponto é que cada tipo de banco de dados NoSQL pode oferecer uma linguagem para as queries diferente e isso pode demandar certo tempo para aprendizado.

---
ACID:

A - Atomicidade (atomicity)

C - Consistência (consistency)

I - Isolação (isolation)

D - Durabilidade (durability)

# Referências

https://www.mongodb.com/compare/mongodb-postgresql
https://www.mongodb.com/nosql-explained/when-to-use-nosql
https://www.mongodb.com/nosql-explained/nosql-vs-sql
https://www.mongodb.com/nosql-explained/advantages
https://www.mongodb.com/document-databases
