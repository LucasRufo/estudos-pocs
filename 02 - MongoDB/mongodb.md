# MongoDB

O MongoDB é um banco de dados NoSQL que guarda suas informações como documentos, por isso chamamos ele de banco de dados NoSQL orientado a documentos. Os documentos são guardados dentro de coleções e sua estrutura é bem parecida com a de um JSON. Um documento é uma forma de organizar os dados com campos e valores.

O MongoDB armazena os dados na memória em formato BSON (Binary JSON), pois guardar as informações exatamente como JSON seria ineficiente já que JSON é *text-based* e ocupa bastante espaço. O formato BSON foi feito para tirar os gaps que o JSON oferece como velocidade e flexibilidade, ele também oferece alguns formatos a mais que não são suportados pelo formato JSON, como *datetimes*.

Todo documento no MongoDB tem que ter o campo "_id" com um valor único para cada documento, quando adicionamos um documento, esse campo já é automaticamente gerado com o tipo `ObjectId()`.

---
Curso MongoDB M001:

JSON = Mongo Import e Export
BSON = Mongo Dump e Restore
