# Golang

## Setar o GOPATH

### Windows

```bash
setx GOPATH %USERPROFILE%\go
setx path "%path%;%USERPROFILE%\bin"
```

### Unix, adicionar ao .profile ou .zshrc

```bash
export GOPATH=$HOME/go
export PATH=$PATH:$GOPATH/bin
```

## Executando programas Go

Podemos usar o comando `go run` para executar os arquivos de forma imediata. O comando compila seu código em binário e o executa em uma pasta temporária, logo após a execução, o binário é deletado.

Já o comando `go build` vai apenas compilar seu código para um binário, sem executá-lo. Podemos usar a flag `-o` para definir o nome do binário.

## Go runtime

Go possui um runtime para possibilitar serviços como alocação de memória, garbage collection e concorrência. Ele é compilado junto com todos os binários Go. Isso é diferente de algumas linguagens que utilizam máquinas virtuais para executar os programas. Com isso, a distribuição de programas em Go fica bem mais simples.

## Instalando pacotes de terceiros

Para instalar ferramentas de terceiros, podemos usar o comando `go install`, ele busca o binário diretamente do código fonte, por isso passamos como argumento o caminho do código e a versão que deverá ser intalada. Exemplo `go install github.com/rakyll/hey@latest`.

Os executáveis vão ficar na pasta `bin` do seu GOPATH.

## Formatação

Go já possui um estilo de formatação muito bem definido, muito para que não ocorram discussões de qual seria o melhor estilo de formatação para o código.

Em Go também não precisamos colocar ponto e virgula no final de uma linha, pois o compilador já faz isso. Go também oferece diversas ferramentas de lint e formatação como `golint` ou `go fmt`. Também tem a ferramenta `golangci-lint` que executa diversas ferramentas de uma vez.

---

## Declaração de variáveis

Podemos declarar variáveis de algumas maneiras, a primeira delas é utilizando o comando `var`.

```go
var x int = 10
```

Podemos remover o tipo da declaração, pois o compilador consegue fazer a inferência. No caso de valores inteiros, o tipo inferido sempre será `int`.

```go
var x = 10
```

Também podemos declarar diversas váriaveis de uma só vez com `var`.

```go
var x, y, z = 1, 2, 3
```

A outra forma de declarar variáveis é utilizando o comando `:=`. Essa formna só pode ser utilizada dentro de funções.

```go
x := 10
```

## Composite types

### Arrays

Go possui arrays assim como a maioria das linguagens, sua declaração é assim.

```go
var x [3]int

var y [3]int{10, 20, 30}

var z [...]int{1, 2, 3, 4, 5}
```

### Slices

Slices são a estrutura de dados comum quando queremos guardar uma sequência de dados. A principal vantagem de um slice é que o tamanho dele não é parte da definição do seu tipo. Declaramos slices da seguinte maneira.

```go
var x = []int{1, 2, 3}

//nil slice
var y = []int

//non nil slice
var z = []int{}
```

Caso não seja definido valores iniciais para o slice, o compilador cria um slice vazio contendo o valor `nil`, que seria algo como a ausência de um valor.

Para adicionarmos valores a um slice, podemos utilizar o comando `append`.

```go
var y = []int

y := append(y, 4, 5, 6)
```

Também podemos adicionar os valores de um slice a outro slice utilizando o operador `...`.

```go
var x = []int{1, 2, 3}

var y = []int

y := append(y, x...)
```

Geralmente declaramos slices vazios, porque pode ser que a função que o utiliza retorne `nil`, com isso nem alocamos memória de forma desnecessária.

### Funções auxiliares

Tanto para slices, quanto para arrays, podemos utilizar a função `len` para saber o tamanho da estrutura.

A função `cap` é utilizada para sabermos a capacidade restante de um slice. Caso um array seja passado para ela, ela sempre retornará o mesmo valor da função `len`.

Para criamos slices também podemos utilizar a função `make`. Ela recebe o tipo, o tamanho e opcionalmente a capacidade.

```go
var x = make([]int, 3)

//último parametro é a capacidade
var y = make([]int, 3, 10)
```

### Slicing

Para utilizamos slicing, usamos um offset inicial e um offset final, separados por um `:`. Caso algum dos offsets não seja especificado, 0 é o valor assumido.

O offset inicial é inclusive, enquanto o offset final é exclusivo.

```go
x := []int{1, 2, 3, 4}
y := x[:2]
z := x[1:]
d := x[1:3]
e := x[:]

x: [1 2 3 4]
y: [1 2]
z: [2 3 4]
d: [2 3]
e: [1 2 3 4]
```

Ao utilizarmos slicing, não criamos novas variáveis, mas trabalhamos com o mesmo endereço de memória. Ou seja, alterando um valor em variáveis resultante de um slicing, a variável original também será alterada. O contrário também ocorre, alterando a variável original, o valor da variável resultante também será alterado.

```go
x := []int{1, 2, 3, 4}
y := x[:2]
x[1] = 20

x: [10 20 3 4]
y: [10 20]
```

### Strings

Strings permitem o uso de slicing assim como arrays e slices.

```go
var s string = "Hello there"
var s2 string = s[4:7]
```

### Maps





[Effective Go](https://go.dev/doc/effective_go)

[Go Code Review Comments](https://github.com/golang/go/wiki/CodeReviewComments)
