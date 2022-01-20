# Amazon Web Services

Anotações baseadas no [curso de AWS da Free Code Camp](https://www.youtube.com/watch?v=ulprqHHWlng).

## Section 1 - AWS Basics

AZ = Availability Zone.
VPC = Virtual Private Cloud

É possível criar alarmes referente ao uso de recursos da AWS, para que caso o você deixe algo ligado sem querer por certo tempo, um email seja enviado para te notificar. Isso é feito através do Billing Dashboard e através do CloudWatch.

É uma boa prática sempre colocar os usuarios do IAM em grupos com as policies bem definidas, do que colocar as policies diretamente no usuário.

Criamos as VPCs dentro das regiões, e criamos as Subnets dentro das AZs disponíveis para aquela VPC/Região. Dentro das nossas subnets podemos executar serviçoes como o EC2.

Subnets podem ser públicas ou privadas, as públicas recebem um IP público e podem se comunicar com a internet.

## Section 2 - Elastic Compute Cloud (EC2)

O EC2 é um serviço que permite que você crie instâncias de máquinas virtuais, que podem ser usadas para executar serviços.

Para conectar nas instâncias podemos usar SSH, seguindo os passos mostrados no console da AWS.

Podemos colocar Roles do IAM nas nossas instâncias, para que elas possam acessar outros serviços.

Também é possivel utilizar o Elastic Load Balancer para ficar na frente das nossas máquinas do EC2 e rotear o trafego para máquinas diferentes conforme a carga de requisições.

## Section 3 - Storage Services

Os principais serviços relacionados a armazenamento são: Elastic Block Store, Elastic File System e o S3.

Buckets S3 podem ser públicos ou privados e os buckets sempre tem que possuir um nome único.

Também é possível habilitar versionamento nos buckets S3, para que seja possível fazer backup e restaurar arquivos.

## Section 4 - Databases

A AWS possui o RDS (Relational Database Service) que oferece um serviço de banco de dados relacional gerenciado. As instâncias rodam no EC2.

As opções de banco de dados são: Aurora (DB da própia AWS), MySQL, MariaDB, PostgreSQL, Oracle e SQL Server.	

É possível adicionar réplicas de leitura no RDS, assim você pode diminuir a carga do seu banco de dados principal.

A AWS oferece também o DynamoDB, que é um banco de dados NoSQL da própria AWS.

## Section 5 - Automation

O Cloudformation é um serviço da AWS que permite a definição da nossa infraestrutura em forma de código JSON ou YAML. Então podemos provisionar diversos outros serviços e conecta-los utilizando os templates.

O Elastic Beanstalk é uma abstração em cima dos serviços como o EC2. Ele permite que o desenvolvedor faça o deploy das suas aplicações de forma mais rápida, sem se preocupar muito com a configuração "por debaixo dos panos".

O Elastic Beanstalk se encaixa como um PaaS (Platform as a Service).

## Section 6 - CI/CD

Para CI e CD a AWS oferece alguns serviços como o CodeCommit, CodeBuild, CodeDeploy, CodePipeline e o CodeStar.

## Section 7 - DNS e CDN

Para DNS a AWS oferece o Route53, ele oferece alguns serviços como registros de domínios, hosted zones, health checks de instâncias EC2 e outros.

Para CDN temos o CloudFront, você cria uma "origin" e esse contéudo é distribuído para diversos outros servidores ao redor do mundo. Então assim os usuários podem se acessar o seu conteúdo atráves do servidor mais próximo e com menos latência.

## Section 8 - Docker e Serveless

A AWS oferece para containers o ECS (Elastic Container Service), nele você pode executar seus containers Docker. Dentro do ECS você pode utilizar o Fargate ou o EC2 para executar as "tasks".

Também temos a Lambda, que é o serviço da AWS que executa funções Serverless. Serveless significa que não precisamos cuidar da infraestrutura necessária para executar a função, a própria AWS cuida disso. Você também paga por uso nesse caso, então só pagamos quando o código executa.


