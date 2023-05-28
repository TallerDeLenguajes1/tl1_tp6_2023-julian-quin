<p><img aling ="rigth" src ="https://github.com/TallerDeLenguajes1/tl1_tp3_2023-julian-quin/blob/main/pato-caminando.gif" heigth="300" width="350" </p><br>

<strong>¿String es una tipo por valor o un tipo por referencia?</strong>

  Se considera un tipo de dato por referencia porque se almacena en la zona de memoria (heap). Significa que cuando se crea una cadena, se asigna un espacio en ese lugar para almacenar su contenido.
  Cuando trabajamos con una variable de tipo string, en realidad tienes una referencia de la ubicación de la cadena en el heap. Es decir, la variable no contiene directamente el contenido de la cadena, sino una forma de encontrarlo en la memoria.

<strong>¿Qué secuencias de escape tiene el tipo string?</strong>
  <p>
    \" Representa el carácter de comillas dobles (")<br>
    \' Representa el carácter de comilla simple (')<br>
    \\ Representa el carácter de barra invertida (\)<br>
    \n Representa un salto de línea<br>
    \r Representa un retorno de carro<br>
    \t Representa un tabulador horizontal<br>
    \b Representa un retroceso<br>
    \f Representa un avance de página<br>
  </p>

<strong>¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?</strong>
<p>Cuando se utiliza el carácter @ antes de una cadena de texto, significa que la cadena se interpreta literalmente y los caracteres de escape, como las secuencias \n, \t, etc., no se procesan.</p>
<p>uando se utiliza el símbolo $ antes de una cadena de texto, se crea una cadena de texto interpolada. Permite incrustar expresiones o variables dentro de una cadena de texto utilizando la sintaxis {}. Las expresiones o variables dentro de {} se evalúan y se insertan en la cadena de texto en tiempo de ejecución.</p>
