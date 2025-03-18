// app.module.ts
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router'; // Importar RouterModule
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { HeroComponent } from './components/hero/hero.component';
import { CursosComponent } from './components/cursos/cursos.component';
import { DepoimentosComponent } from './components/depoimentos/depoimentos.component';
import { ContatoComponent } from './components/contato/contato.component';
import { FooterComponent } from './components/footer/footer.component';
import { AppRoutingModule } from './app-routing.module'; // Importar AppRoutingModule

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HeroComponent,
    CursosComponent,
    DepoimentosComponent,
    ContatoComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, // Adicionar AppRoutingModule aos imports
    RouterModule // Adicionar RouterModule aos imports
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
