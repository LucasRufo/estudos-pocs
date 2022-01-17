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

## Diferença do Docker para Máquinas Virtuais

A grande diferença entre utilizar Docker e utilizar máquinas virtuais é que o Docker consegue compartilhar grande parte dos recursos do kernel do computador Host. Com máquinas virtuais temos que para cada máquina virtual ter um sistema operacional inteiro, enquanto que com o Docker compartilhamos diversos recursos entre os containers.

## Principais comandos Docker

Para buscar as imagens que estão disponíveis no Host:

```bash
docker images
```

Para buscar os containers que estão rodando no Host:

```bash
docker ps
```

Esse comando ainda aceita parâmetros, como por exemplo:

`-a` ou `--all` para mostrar todos os containers, mesmos os que estão parados.

## Volumes

Volumes são diretórios externos aos containers e que podem ser acessados pelos containers. O principal uso dos volumes é persistir arquivos, já que os próprios diretórios dos containers são voláteis e com a morte de um container todos os arquivos escritos lá são perdidos.

Volumes são inicializados quando os containers são criados e caso ocorra de já haver dados no diretório que você está montando o volume, aqueles dados serão copiados para o volume.

## Multi-stage

Multi-stage é uma forma de criarmos uma espécie de pipeline via Dockerfile, podendo utilizar o comando `FROM` mais de uma vez, assim podemos usar uma imagem para buildar nossa aplicação e outra para rodar. A maior vantagem é não precisarmos manter as ferramentas de build da nossa aplicação na imagem final. O tamanho das imagens pode ter uma diferença brutal se o recurso for bem utilizado e o docker também é inteligente para utilizar cache em alguns passos e o processo de build da imagem também fica mais rápido.

## Referências

https://docs.docker.com/get-started/overview/
https://stack.desenvolvedor.expert/appendix/docker/comandos.html
https://github.com/badtuxx/DescomplicandoDocker

