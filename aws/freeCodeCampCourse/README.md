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

## Section 3 - Databases