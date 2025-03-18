// Importações necessárias para a criação de um componente no Angular e para a definição de metadados do componente. 
import { Component } from '@angular/core';

// O @Component é um decorador que permite que você marque uma classe como um componente e forneça metadados que dizem ao Angular como criar e usar o componente. O Angular usa o @Component para criar e exibir instâncias do componente. O @Component é uma função que recebe um objeto de metadados que permite que você defina as propriedades do componente.
@Component({
  // Selector Serve para adicionar um seletor ao componente em questão e é uma propriedade obrigatória do @Component do Angular.
  selector: 'app-cursos',
  // O Angular permite que você defina se o componente é um componente independente ou não. Se você definir o valor de standalone como true, o Angular tratará o componente como um componente independente. Se você definir o valor de standalone como false, o Angular tratará o componente como um componente não independente. O valor padrão de standalone é false.
  standalone: false,
  // Template Serve para adicionar o HTML ao componente em questão e é uma propriedade obrigatória do @Component do Angular.
  templateUrl: './cursos.component.html',
  // Style Serve para adicionar estilos ao componente em questão e é uma propriedade opcional do @Component do Angular.
  styleUrl: './cursos.component.css'
})
  // A classe CursosComponent é responsável por controlar o comportamento do componente de cursos.
export class CursosComponent {

}
