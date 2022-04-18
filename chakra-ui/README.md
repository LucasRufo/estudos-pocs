# Chakra UI

O Chakra UI é uma biblioteca de componentes que possui foco em ter acessibilidade, ser customizável e ter uma ótima developer experience.

## Princípios

O Chakra segue algumas convenções/princípios que ajudam a manter os componentes consistentes. São eles:

- Style Props: Todos os estilos dos componentes podem ser sobrescrito ou extendidos com props. Assim reduzimos o uso de CSS.

- Simplicidade: APIs simples nos componentes.

- Composition: Quebrar componentes em partes menores com menos props para manter a complexidade baixa e compor os componentes juntos.

- Acessibilidade: Manter a acessibilidade quando criamos novos componentes. Isso inclui navegação pelo teclado, contraste e os atributos aria-* corretos.

- Dark mode: Manter os componentes compatíveis com uma possível versão escura.

- Nomeando Props: Manter os nomes das props bem indicativos. Conseguimos atingir isso usando palavras como "has", "is" e "should".

## Trade-off

O Chakra é ótimo e flexível com a maioria das aplicações, mas tudo possui prós e contras. No caso do chakra, ele utiliza CSS-in-JS por debaixo dos panos com as bibliotecas [emotion](https://emotion.sh/docs/introduction) e [styled-system](https://emotion.sh/docs/introduction) e isso pode causar lentidão por conta dos runtimes. A lentidão será perceptível se a aplicação for bem grande e contiver muitos dados que mudam com frequência.
