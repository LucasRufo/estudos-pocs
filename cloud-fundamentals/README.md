# Fundamentos Cloud

## Introdução

A computação em cloud oferece uma forma de usarmos recursos computacionais como serviço. Então ao invés de comprarmos e mantermos os nossos próprios servidores e data centers podemos acessar diversos serviços como pode computacional, armazenamento e bancos de dados atráves da rede e pagarmos apenas pelo o que estamos de fato usando.

Alguns benefícios de utilizar cloud são:

Agilidade: A cloud oferece fácil acesso a diversas tecnologias de forma rápida. É possível criar recursos conforme sua necessidade e escalar também se torna extremamente rápido.

Elasticidade: Com a cloud você não precisa provisionar mais recursos do que o necessário para certo momento, mas ainda tem a possibilidade de escalar em momentos de pico ou em momentos que sua infra precisa crescer.

Custos: Como você não precisa provisiona sua própria infraestrutura e você só pagará pelo o que usar, você acaba tendo um custo menor.

## Tipos de computação em cloud

Infrastructure as a Service (IaaS): É o modelo mais básico entre os 3, geralmente oferece o poder computacional através de máquinas virtuais que o cliente escolhe a configuração como memória, CPU e armazenamento. Ela oferece a maior flexibilidade entre os modelos existentes. Um exeplo de IaaS é o EC2 da AWS, visto que é somente provisionado a Máquina Virtual, toda a configuração e manuseio fica por sua conta.

Platform as a Service (PaaS): É um modelo que remove a complexidade de você ter que cuidar da camada do sistema operacional e da capacidade computacional da máquina. Esse modelo ajuda na eficiência já que você não cuida dos updates e da manutenção dos recursos que estão "abaixo". Um exemplo de PaaS são as Azure Functions do Azure, já que o desenvolvedor pode executar uma porção de código sem se preocupar com a infraestrutura que estará utilizando.

Software as a Service (SaaS): Já esse modelo, oferece um produto completo que roda e é gerenciado pelo provedor do serviço. Com o modelo de SaaS você não precisa se preocupar em como esse serviço é gerenciado ou como a infraestrutura que executa ele é gerenciada. Você só precisa se preocupar em como você vai utilizar o serviço. Um exemplo de SaaS é o Dropbox, que oferece serviço compatilhamento e armazenamento de arquivos.

## Referências

https://aws.amazon.com/what-is-cloud-computing/?nc1=h_ls
https://docs.microsoft.com/en-us/learn/modules/cmu-cloud-computing-overview/4-building-blocks