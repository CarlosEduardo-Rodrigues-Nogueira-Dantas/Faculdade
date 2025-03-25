import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HeroComponent } from './components/hero/hero.component';
import { CursosComponent } from './components/cursos/cursos.component';
import { DepoimentosComponent } from './components/depoimentos/depoimentos.component';
import { ContatoComponent } from './components/contato/contato.component';

const routes: Routes = [
  { path: '', component: HeroComponent },
  { path: 'cursos', component: CursosComponent },
  { path: 'depoimentos', component: DepoimentosComponent },
  { path: 'contato', component: ContatoComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
