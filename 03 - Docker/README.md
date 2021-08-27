# MongoDB

## Introdução - O que é Docker?

Docker é uma plataforma que vem para facilitar o desenvolvimento e o deploy das nossas aplicações em ambientes isolados que são chamados de containers. Containers são ambientes isolados a nível de disco, memória, processamento e rede. Então temos um ambiente separado, que contém todas as dependências e configurações que nossa aplicação precisa para ser executada, que rodará de forma igual em um notebook e dentro de um servidor, pois o docker irá provisiar o mesmo container nos dois ambientes.

Então com o Docker podemos ter um processo parecido com:

- Desenvolver nossa aplicação utilizando containers.
- O container se tornará uma forma de distribuirmos nossa aplicação.
- Quando estivermos prontos para realizar o deploy, nossa aplicação funcionará em produção da mesma maneira que estava funcionando em nossa máquina.

O docker trabalha com 3 principais elementos, o Dockerfile, as imagens e os containers.

Dockerfile: É um arquivo que descreve como o Docker montará nossa imagem, nele descrevemos todo o processo que será necessário para executar nossa aplicação.

Imagem: É o template criado a partir do Dockerfile, que diz para o Docker todos os componentes e passos que ele precisará para executar um container. Geralmente as imagens são construídas por cima de outras imagens em um esquema de camadas, por exemplo, podemos ter uma imagem que é baseada no Ubuntu, mas que ainda instala um Servidor Web para nossa aplicação.

Container: É a instância de uma imagem. Você pode criar, iniciar, parar ou deletar um container utilizando a CLI do Docker. É o ambiente isolado que desejamos rodar nossas aplicações, mas é configuravel até que ponto queremos essa isolação. Quando remover um container, toda mudança ou estado que estava dentro do container é perdido.

## Referências

https://docs.docker.com/get-started/overview/
https://stack.desenvolvedor.expert/appendix/docker/comandos.html

